Imports EASendMail

Public Class frmEmail

#Region "Public/Private Variables"
    Private m_bcancel As Boolean = False
    Private m_eventtick As Long = 0
    Private m_htmlDoc As mshtml.IHTMLDocument2

#End Region

#Region "Initialize Fonts List"
    Protected Sub InitFonts()
        Dim arFonts() As String = {"Choose Font Style ...",
                  "Allegro BT",
                  "Arial",
                  "Arial Baltic",
                  "Arial Black",
                  "Arial CE",
                  "Arial CYR",
                  "Arial Greek",
                  "Arial Narrow",
                  "Arial TUR",
                  "AvantGarde Bk BT",
                  "BankGothic Md BT",
                  "Basemic",
                  "Basemic Symbol",
                  "Basemic Times",
                  "Batang",
                  "BatangChe",
                  "Benguiat Bk BT",
                  "BernhardFashion BT",
                  "BernhardMod BT",
                  "Book Antiqua",
                  "Bookman Old Style",
                  "Bremen Bd BT",
                  "Century Gothic",
                  "Charlesworth",
                  "Comic Sans MS",
                  "CommonBullets",
                  "CopprplGoth Bd BT",
                  "Courier",
                  "Courier New",
                  "Courier New Baltic",
                  "Courier New CE",
                  "Courier New CYR",
                  "Courier New Greek",
                  "Courier New TUR",
                  "Dauphin",
                  "Dotum",
                  "DotumChe",
                  "Dungeon",
                  "English111 Vivace BT",
                  "Estrangelo Edessa",
                  "Fixedsys",
                  "Franklin Gothic Medium",
                  "Futura Lt BT",
                  "Futura Md BT",
                  "Futura XBlk BT",
                  "FuturaBlack BT",
                  "Garamond",
                  "Gautami",
                  "Georgia",
                  "GoudyHandtooled BT",
                  "GoudyOlSt BT",
                  "Gulim",
                  "GulimChe",
                  "Gungsuh",
                  "GungsuhChe",
                  "Haettenschweiler",
                  "Humanst521 BT",
                  "Impact",
                  "Kabel Bk BT",
                  "Kabel Ult BT",
                  "Kingsoft Phonetic Plain",
                  "Latha",
                  "Lithograph",
                  "LithographLight",
                  "Lucida Console",
                  "Lucida Sans Unicode",
                  "Mangal",
                  "Marlett",
                  "Microsoft Sans Serif",
                  "MingLiU",
                  "Modern",
                  "Monotype Corsiva",
                  "MS Gothic",
                  "MS Mincho",
                  "MS Outlook",
                  "MS PGothic",
                  "MS PMincho",
                  "MS Sans Serif",
                  "MS Serif",
                  "MS UI Gothic",
                  "MT Extra",
                  "MV Boli",
                  "Myriad Condensed Web",
                  "Myriad Web",
                  "OzHandicraft BT",
                  "Palatino Linotype",
                  "PMingLiU",
                  "PosterBodoni BT",
                  "Raavi",
                  "Roman",
                  "Script",
                  "Serifa BT",
                  "Serifa Th BT",
                  "Shruti",
                  "Small Fonts",
                  "Souvenir Lt BT",
                  "Staccato222 BT",
                  "Swiss911 XCm BT",
                  "Sylfaen",
                  "Symbol",
                  "System",
                  "Tahoma",
                  "Terminal",
                  "Times New Roman",
                  "Times New Roman Baltic",
                  "Times New Roman CE",
                  "Times New Roman CYR",
                  "Times New Roman Greek",
                  "Times New Roman TUR",
                  "Trebuchet MS",
                  "Tunga",
                  "TypoUpright BT",
                  "Verdana",
                  "VisualUI",
                  "Webdings",
                  "Wingdings",
                  "Wingdings 2",
                  "Wingdings 3",
                  "WP Arabic Sihafa",
                  "WP ArabicScript Sihafa",
                  "WP BoxDrawing",
                  "WP CyrillicA",
                  "WP CyrillicB",
                  "WP Greek Century",
                  "WP Greek Courier",
                  "WP Greek Helve",
                  "WP Hebrew David",
                  "WP IconicSymbolsA",
                  "WP IconicSymbolsB",
                  "WP Japanese",
                  "WP MathA",
                  "WP MathB",
                  "WP MathExtendedA",
                  "WP MathExtendedB",
                  "WP MultinationalA Courier",
                  "WP MultinationalA Helve",
                  "WP MultinationalA Roman",
                  "WP MultinationalB Courier",
                  "WP MultinationalB Helve",
                  "WP MultinationalB Roman",
                  "WP Phonetic",
                  "WP TypographicSymbols",
                  "WST_Czec",
                  "WST_Engl",
                  "WST_Fren",
                  "WST_Germ",
                  "WST_Ital",
                  "WST_Span",
                  "WST_Swed",
                  "ZapfEllipt BT",
                  "Zurich Ex BT"}

        Dim i As Integer
        Dim nCount As Integer = arFonts.Length
        For i = 0 To nCount - 1
            lstFont.Items.Add(arFonts(i))
        Next

        lstFont.SelectedIndex = 0
        lstSize.Items.Add("Font Size ... ")
        For i = 1 To 9
            lstSize.Items.Add(i)
        Next
        lstSize.SelectedIndex = 0
    End Sub
#End Region

#Region "EASendMail EventHandler"

    Sub OnIdle(ByVal sender As Object, ByRef cancel As Boolean)
        cancel = m_bcancel
        If Not cancel Then
            Application.DoEvents() 'waiting server reponse or connecting server.
        End If
    End Sub

    Sub OnConnected(ByVal sender As Object, ByRef cancel As Boolean)
        _SetStatus("Connected")
        cancel = m_bcancel
    End Sub


    Sub OnSendingDataStream(ByVal sender As Object, ByVal sent As Integer, ByVal total As Integer, ByRef cancel As Boolean)
        If pgSending.Value = 0 Then
            _SetStatus("Sending ...")
        End If
        _SetProgress(sent, total)
        cancel = m_bcancel
        If sent = total Then
            _SetStatus("Disconnecting ...")
        End If

    End Sub

    Sub OnAuthorized(ByVal sender As Object, ByRef cancel As Boolean)
        _SetStatus("Authorized")
        cancel = m_bcancel
    End Sub

    Sub OnSecuring(ByVal sender As Object, ByRef cancel As Boolean)
        _SetStatus("Securing ...")
        cancel = m_bcancel
    End Sub

#End Region

#Region "Form Events"
    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        htmlEditor.Navigate("about:blank")
        m_htmlDoc = CType(htmlEditor.Document.DomDocument, mshtml.IHTMLDocument2)
        m_htmlDoc.designMode = "on"
        InitFonts()
    End Sub


#End Region

#Region "Form Component Events"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Close()
            frmMainPage.Show()
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click


        Dim dlgOAUTH As New GmailOAUTH()
        If dlgOAUTH.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim user As String = dlgOAUTH.m_user
        Dim password As String = dlgOAUTH.m_access_token

        btnSend.Enabled = False
        btnCancel.Enabled = True
        m_bcancel = False

        Dim oMail As SmtpMail = New SmtpMail("TryIt")
        Dim oSmtp As SmtpClient = New SmtpClient

        Dim errStr As String = ""

        Try
            oMail.Reset()

            oMail.From = New MailAddress(user)


            'To, Cc and Bcc is a AddressCollection object
            'The example code
            'oMail.To = New AddressCollection( "test1@adminsystem.com, test2@adminsystem.com" )
            'oMail.To = New AddressCollection( "Tester1<test@adminsystem.com>, Tester2<test2@adminsystem.com>")
            For Each row As DataGridViewRow In frmMainPage.dtagrdContact.Rows
                If cboTo.SelectedItem.Equals("All") Then
                    oMail.To.Add(row.Cells(2).Value)
                ElseIf row.Cells(3).Value.Equals(cboTo.SelectedItem) Then
                    oMail.To.Add(row.Cells(2).Value)
                ElseIf row.Cells(2).Value.Equals(cboTo.Text) Then
                    oMail.To.Add(row.Cells(2).Value)
                End If
            Next
            'You can add more recipient by Add method
            'oMail.To.Add( new MailAddress( "tester", "test@adminsystem.com"))

            For Each row As DataGridViewRow In frmMainPage.dtagrdContact.Rows
                If row.Cells(3).Value.Equals(cboCc.SelectedItem) Then
                    oMail.Cc.Add(row.Cells(2).Value)
                End If
            Next

            oMail.Subject = textSubject.Text

            Dim basepath As String = Application.ExecutablePath
            Dim pos As Integer = basepath.LastIndexOfAny("/\".ToCharArray())
            If pos <> -1 Then
                basepath = basepath.Substring(0, pos)
            End If

            Dim body As String = m_htmlDoc.body.innerHTML


            oMail.ImportHtml(body,
                Application.ExecutablePath,
                ImportHtmlBodyOptions.ImportLocalPictures)



            Dim oServer As SmtpServer = New SmtpServer("smtp.gmail.com")
            oServer.Protocol = ServerProtocol.SMTP
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
            oServer.AuthType = SmtpAuthType.XOAUTH2
            oServer.Port = 587

            oServer.User = user
            oServer.Password = password


            'Catching the following events is not necessary, 
            'just make the application more user friendly.
            'If you use the object in asp.net/windows service or non-gui application, 
            'You need not to catch the following events.
            'To learn more detail, please refer to the code in EASendMail EventHandler region
            AddHandler oSmtp.OnIdle, AddressOf OnIdle
            AddHandler oSmtp.OnAuthorized, AddressOf OnAuthorized
            AddHandler oSmtp.OnConnected, AddressOf OnConnected
            AddHandler oSmtp.OnSecuring, AddressOf OnSecuring
            AddHandler oSmtp.OnSendingDataStream, AddressOf OnSendingDataStream


            sbStatus.Text = "Connecting ... "
            pgSending.Value = 0
            oSmtp.SendMail(oServer, oMail)
            MessageBox.Show("The email has been sent successfully!")
            sbStatus.Text = "Completed"

        Catch exp As SmtpTerminatedException
            errStr = exp.Message
        Catch exp As System.Exception
            errStr = "Exception: " + exp.Message
        End Try
        If errStr.Length > 0 Then
            MessageBox.Show(errStr)
            sbStatus.Text = errStr
        End If
        btnSend.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Close()
            frmMainPage.Show()
        End If
    End Sub

    Private Sub lstSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSize.SelectedIndexChanged
        Dim size As String = lstSize.Text
        lstSize.SelectedIndex = 0
        m_htmlDoc.execCommand("fontsize", False, size)
        htmlEditor.Focus()
    End Sub

    Private Sub lstFont_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFont.SelectedIndexChanged
        Dim font As String = lstFont.Text
        lstFont.SelectedIndex = 0
        m_htmlDoc.execCommand("fontname", False, font)
        htmlEditor.Focus()
    End Sub


    'Updates ComboBox such that when name is inputted searches for an email corresponding to said name
    Private Sub cboTo_TextUpdate(sender As Object, e As EventArgs) Handles cboTo.TextUpdate

        If Not cboTo.Text.Equals("") Then
            Dim index As Integer = 0
            Dim item_array(30)
            If Not cboTo.Items.Contains(cboTo.Text) Then
                'removing all the items in the comboBox
                For Each item In cboTo.Items
                    item_array(index) = item
                    index += 1
                Next

                For i = 0 To 30
                    cboTo.Items.Remove(item_array(i))
                Next i

                'Adding the new items into the ComboBox referring to the email corresponding to the give text
                For Each row As DataGridViewRow In frmMainPage.dtagrdContact.Rows
                    If row.Cells(0).Value.ToString.Contains(cboTo.Text) Then
                        cboTo.Items.Add(row.Cells(2).Value)
                    End If
                Next
            End If
        Else
            'removing all the current items
            Dim index As Integer = 0
            Dim item_array(30)
            For Each item In cboTo.Items
                item_array(Index) = item
                Index += 1
            Next

            For i = 0 To 30
                cboTo.Items.Remove(item_array(i))
            Next i

            'Adding back all the default items
            cboTo.Items.Add("Executives")
            cboTo.Items.Add("Associate Staff")
            cboTo.Items.Add("Applicants")
            cboTo.Items.Add("Omoluabi")
            cboTo.Items.Add("Sokoni")
            cboTo.Items.Add("Seniors")
            cboTo.Items.Add("BYAP")
            cboTo.Items.Add("BPO")
            cboTo.Items.Add("All")

        End If

    End Sub

    Private Sub cboCc_TextUpdate(sender As Object, e As EventArgs) Handles cboCc.TextUpdate
        'Updates ComboBox such that when name is inputted searches for an email corresponding to said name
        If Not cboCc.Text.Equals("") Then
            Dim index As Integer = 0
            Dim item_array(30)
            If Not cboCc.Items.Contains(cboCc.Text) Then
                'removing all the items in the comboBox
                For Each item In cboCc.Items
                    item_array(index) = item
                    index += 1
                Next

                For i = 0 To 30
                    cboCc.Items.Remove(item_array(i))
                Next i

                'Adding the new items into the ComboBox referring to the email corresponding to the give text
                For Each row As DataGridViewRow In frmMainPage.dtagrdContact.Rows
                    If row.Cells(0).Value.ToString.Contains(cboCc.Text) Then
                        cboCc.Items.Add(row.Cells(2).Value)
                    End If
                Next
            End If
        Else
            'removing all the current items
            Dim index As Integer = 0
            Dim item_array(30)
            For Each item In cboCc.Items
                item_array(index) = item
                index += 1
            Next

            For i = 0 To 30
                cboCc.Items.Remove(item_array(i))
            Next i

            'Adding back all the default items
            cboCc.Items.Add("Executives")
            cboCc.Items.Add("Associate Staff")
            cboCc.Items.Add("Applicants")
            cboCc.Items.Add("Omoluabi")
            cboCc.Items.Add("Sokoni")
            cboCc.Items.Add("Seniors")
            cboCc.Items.Add("BYAP")
            cboCc.Items.Add("BPO")
            cboCc.Items.Add("All")

        End If
    End Sub
#End Region

#Region "Form Movement"
    Public IsDragging As Boolean = False, IsClick As Boolean = False
    Public StartPoint, FirstPoint, LastPoint As Point
    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        StartPoint = Me.PointToScreen(New Point(e.X, e.Y))
        FirstPoint = StartPoint
        IsDragging = True
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If IsDragging Then
            Dim EndPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))
            IsClick = False
            Me.Left += (EndPoint.X - StartPoint.X)
            Me.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
            LastPoint = EndPoint
        End If
    End Sub

    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        IsDragging = False
        If LastPoint = StartPoint Then IsClick = True Else IsClick = False
    End Sub
#End Region

#Region "Cross Thread Access Control"
    Private Delegate Sub SetStatusDelegate(ByVal v As String)
    Private Delegate Sub SetProgressDelegate(ByVal sent As Integer, ByVal total As Integer)

    Private Sub _SetStatusCallBack(ByVal v As String)
        lblStatus.Text = v
    End Sub

    Private Sub _SetProgressCallBack(ByVal sent As Integer, ByVal total As Integer)
        Dim t As Long = sent
        t = t * 100
        t = t / total
        Dim x As Integer = t
        pgSending.Value = x

        Dim tick As Long = System.DateTime.Now.Ticks
        ' call DoEvents every 0.2 second 

        If (tick - m_eventtick > 2000000) Then
            ' Do not call DoEvents too frequently in a very fast lan + larg email.
            m_eventtick = tick
            Application.DoEvents()
        End If

    End Sub

    'Why we need to change the control item text by this function.
    'Because with BeginSendMail method, all the events are fired on another
    'thread, to change the list item safety, we used this function to 
    'update list item. more detail, please refer to Control.BeginInvoke method
    'in MSDN
    Private Sub _SetStatus(ByVal v As String)
        If InvokeRequired Then
            Dim args(0) As Object
            args(0) = v

            Dim d As SetStatusDelegate = New SetStatusDelegate(AddressOf _SetStatusCallBack)
            BeginInvoke(d, args)
        Else
            _SetStatusCallBack(v)
        End If
    End Sub
    Private Sub _SetProgress(ByVal sent As Integer, ByVal total As Integer)
        If InvokeRequired Then
            Dim args(1) As Object
            args(0) = sent
            args(1) = total
            Dim d As SetProgressDelegate = New SetProgressDelegate(AddressOf _SetProgressCallBack)
            BeginInvoke(d, args)
        Else
            _SetProgressCallBack(sent, total)
        End If
    End Sub


#End Region

End Class
