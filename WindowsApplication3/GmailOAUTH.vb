Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports EASendMail

Public Class GmailOAUTH

#Region "Public Variables"
    Private m_client_id As String = "931912589092-94b9hv9afn7i1ihtc31rqt57qnbh44kl.apps.googleusercontent.com"
    Private m_client_secret As String = "a2Yc4j6HHuSqoBmTk0gdllTZ"

    Private m_redirect_uri As String = "urn:ietf:wg:oauth:2.0:oob"
    Private m_scope As String = "https://www.googleapis.com/auth/plus.profile.emails.read%20https://www.googleapis.com/auth/plus.me%20https://mail.google.com" '%20
    Private m_auth_uri As String = "https://accounts.google.com/o/oauth2/v2/auth"
    Private m_token_uri As String = "https://www.googleapis.com/oauth2/v4/token"
    Private m_plus_api_uri As String = "https://www.googleapis.com/plus/v1/people/me?fields=emails&access_token="
    Public m_access_token As String = ""
    Public m_refresh_token As String = ""
    Public m_user As String = ""

#End Region

    Private Sub GmailOAUTH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim authURI As String = String.Format("{0}?scope={1}&redirect_uri={2}&response_type=code&client_id={3}",
                   m_auth_uri, m_scope, m_redirect_uri, m_client_id)

        webOAUTH.Navigate(authURI) 'start to open Gmail OAUTH login web page.
    End Sub

    Private Sub webOAUTH_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webOAUTH.DocumentCompleted
        If m_access_token.Length > 0 Then
            Return
        End If

        Dim elment As System.Windows.Forms.HtmlElement = webOAUTH.Document.GetElementById("code")
        If elment IsNot Nothing Then
            Dim code As String = elment.GetAttribute("value")
            GetAccessToken(code)
        End If
    End Sub
    ' Get access_token from Google server.
    Private Sub GetAccessToken(ByVal code As String)
        Dim encoder As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")
        webOAUTH.Document.Body.InnerHtml = "<div style=""padding:30px;"" id=""eas_auth_desc"">Requesting access token from Google server ...</div>"
        Application.DoEvents()

        Try
            Dim url As String = m_token_uri
            Dim oClient As HttpWebRequest = TryCast(WebRequest.Create(url), HttpWebRequest)
            oClient.Method = "POST"
            oClient.ContentType = "application/x-www-form-urlencoded"

            Dim client_id As String = m_client_id
            Dim client_secret As String = m_client_secret
            Dim redirect_uri As String = m_redirect_uri

            Dim data As String = "code=" & code
            data += "&client_id=" & client_id
            data += "&client_secret=" & client_secret
            data += "&redirect_uri=" & redirect_uri
            data += "&grant_type=authorization_code"


            Dim rqstAr As IAsyncResult = oClient.BeginGetRequestStream(Nothing, Nothing)
            Application.DoEvents()
            While (Not rqstAr.AsyncWaitHandle.WaitOne(5, False))
                Application.DoEvents()
            End While
            Dim ofs As Stream = oClient.EndGetRequestStream(rqstAr)

            Dim dt As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
            ofs.Write(dt, 0, dt.Length)
            ofs.Close()

            Dim ar As IAsyncResult = oClient.BeginGetResponse(Nothing, Nothing)
            While (Not ar.AsyncWaitHandle.WaitOne(5, False))
                Application.DoEvents()
            End While

            Dim oResponse As HttpWebResponse = TryCast(oClient.EndGetResponse(ar), HttpWebResponse)

            Dim readStream As New System.IO.StreamReader(oResponse.GetResponseStream(), encoder)
            Dim responseText As String = readStream.ReadToEnd()

            m_access_token = SimpleJsonParser.GetJsonValue(responseText, "access_token").Trim(("""" & vbTab & vbCr & vbLf & " ").ToCharArray())
            m_refresh_token = SimpleJsonParser.GetJsonValue(responseText, "refresh_token").Trim(("""" & vbTab & vbCr & vbLf & " ").ToCharArray())

            If (m_access_token.Length = 0) Then
                Dim elment As System.Windows.Forms.HtmlElement = webOAUTH.Document.GetElementById("eas_auth_desc")
                If (elment IsNot Nothing) Then
                    elment.InnerText = responseText
                End If
                Return
            End If
        Catch ex As WebException
            Dim errorDesc As String = ex.Message
            If (ex.Response IsNot Nothing) Then
                Dim readStream As New System.IO.StreamReader(ex.Response.GetResponseStream(), encoder)
                errorDesc = readStream.ReadToEnd()
            End If

            Dim elment As System.Windows.Forms.HtmlElement = webOAUTH.Document.GetElementById("eas_auth_desc")
            If (elment IsNot Nothing) Then
                elment.InnerText = errorDesc
            End If
            Return
        End Try

        QueryUserProfile(m_access_token)
    End Sub

    ' Query authenticated user email address by Google+ API
    Private Sub QueryUserProfile(ByVal access_token As String)
        Dim url As String = m_plus_api_uri
        url += access_token

        Dim encoder As System.Text.Encoding = System.Text.Encoding.GetEncoding("utf-8")
        Try
            Dim elment As System.Windows.Forms.HtmlElement = webOAUTH.Document.GetElementById("eas_auth_desc")
            If (elment IsNot Nothing) Then
                elment.InnerText = "Querying user email address ... "
                Application.DoEvents()
            End If

            Dim oClient As HttpWebRequest = TryCast(WebRequest.Create(url), HttpWebRequest)
            oClient.Method = "GET"

            Dim ar As IAsyncResult = oClient.BeginGetResponse(Nothing, Nothing)
            While (Not ar.AsyncWaitHandle.WaitOne(5, False))
                Application.DoEvents()
            End While

            Dim oResponse As HttpWebResponse = TryCast(oClient.EndGetResponse(ar), HttpWebResponse)
            '   Dim oResponse As HttpWebResponse = oClient.GetResponse()
            Dim readStream As New System.IO.StreamReader(oResponse.GetResponseStream(), encoder)
            Dim responseText As String = readStream.ReadToEnd()

            ParseUserEmail(responseText)
        Catch ex As WebException
            Dim errorDesc As String = ex.Message
            If (ex.Response IsNot Nothing) Then
                Dim readStream As New System.IO.StreamReader(ex.Response.GetResponseStream(), encoder)
                errorDesc = readStream.ReadToEnd()
            End If

            Dim elment As System.Windows.Forms.HtmlElement = webOAUTH.Document.GetElementById("eas_auth_desc")
            If (elment IsNot Nothing) Then
                elment.InnerText = errorDesc
            End If

            Return
        End Try
    End Sub

    'Parse result, Query authenticated user email address by Google+ API
    Private Sub ParseUserEmail(ByVal s As String)
        Dim emails As String = SimpleJsonParser.GetJsonValue(s, "emails")
        Dim ar As String() = SimpleJsonParser.ParseArray(emails)

        For i As Integer = 0 To ar.Length - 1
            Dim t As String = ar(i)
            Dim address As String = SimpleJsonParser.GetJsonValue(t, "value").Trim((vbCr & vbLf & vbTab & " """).ToCharArray())
            Dim type As String = SimpleJsonParser.GetJsonValue(t, "type").Trim((vbCr & vbLf & vbTab & " """).ToCharArray())
            If [String].Compare(type, "account", True) <> 0 Then
                Continue For
            End If

            m_user = address
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
            Return
        Next

        Dim elment As System.Windows.Forms.HtmlElement = webOAUTH.Document.GetElementById("eas_auth_desc")
        If (elment IsNot Nothing) Then
            elment.InnerText = "Failed to get user email address!"
        End If

    End Sub
End Class
