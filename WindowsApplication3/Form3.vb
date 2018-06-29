Imports System.IO
Imports System.Data

Public Class frmMainPage

#Region "Public Variables"
    'Current date
    Public date1 As String
    'Handles the amount of participants
    Public amount_old_part As Integer
    Public amount_total_curr_part As Integer
#End Region

#Region "Form Events"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("C:\Users\William\Dropbox\Participants_list.csv") = True Then
            For Each line As String In System.IO.File.ReadAllLines("C:\Users\William\Dropbox\Participants_list.csv")

                If Not line.StartsWith("2018") And line.Contains("Name") = False Then
                    DataGridView1.Rows.Add(line.Split(","))
                End If
            Next

        End If

    End Sub

    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Reads the data from csv file and signals to reconfirm if new month
        date1 = System.DateTime.Now.ToString("yyyy/MM")
        If System.IO.File.Exists("C:\Users\William\Dropbox\Participants_list.csv") = True Then
            For Each line As String In System.IO.File.ReadAllLines("C:\Users\William\Dropbox\Participants_list.csv")
                If line.StartsWith("2018") Then
                    If Not line.Equals(date1) Then
                        MsgBox("Please reconfirm with the shown businesses if they would like to participate in Sokoni again")
                    End If
                End If
            Next

            My.Computer.FileSystem.DeleteFile("C:\Users\William\Dropbox\Participants_list.csv")
        End If


        'Reads the data in csv file and converts it to show on chart on form
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\William\Dropbox\Participants_Date.csv")
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {","}
            Dim currentRow As String()
            Dim CurrentPoint As Integer = 0
            Chart1.Series(0).Points.Clear()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim D As String = currentRow(0)
                    Try

                        Dim Y As Double = CDbl(currentRow(1))
                        Chart1.Series(0).Points.AddY(Y)
                        Chart1.Series(0).Points(CurrentPoint).AxisLabel = D
                        If D.Contains(date1) Then
                            amount_total_curr_part += Y
                        End If
                        CurrentPoint += 1
                    Catch ex As InvalidCastException
                        If CurrentPoint <> 0 Then
                            MsgBox("Item " & currentRow(1) & " is invalid.  Skipping")
                        End If
                    End Try

                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    If CurrentPoint <> 0 Then
                        MsgBox("Line " & ex.Message & " is invalid.  Skipping")
                    End If
                End Try
            End While
        End Using
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Build the CSV file data as a Comma separated string.
        Dim csv As String = String.Empty
        Dim csvP As String = String.Empty

        'Add the Header row for CSV file.
        For Each column As DataGridViewColumn In DataGridView1.Columns
            csv += column.HeaderText & ","c
        Next

        'Add new line.
        csv += vbCr & vbLf
        Dim count As Integer = 0
        'Adding the Rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                'Add the Data rows.
                csv += cell.Value.ToString().Replace(",", ";") & ","c
            Next
            count += 1
            'Add new line.
            csv += vbCr & vbLf
        Next
        csv += date1
        'Exporting to Excel
        Dim folderPath As String = "C:\Users\William\Dropbox\"
        File.WriteAllText(folderPath & "Participants_list.csv", csv)

        'Exporting chart data of participants to csv
        If System.IO.File.Exists("C:\Users\William\Dropbox\Participants_Date.csv") = True Then
            For Each line As String In System.IO.File.ReadAllLines("C:\Users\William\Dropbox\Participants_Date.csv")
                If Not line.Contains(date1) Then
                    csvP += line + vbCr & vbLf
                End If
            Next

            My.Computer.FileSystem.DeleteFile("C:\Users\William\Dropbox\Participants_Date.csv")
        End If

        csvP += date1 + "," + amount_total_curr_part.ToString()

        File.WriteAllText(folderPath & "Participants_Date.csv", csvP)
    End Sub
#End Region

#Region "Form Movement"
    'Code for the moving panel that also moves the form
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

    Private Sub pnlDrag_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlDrag.MouseDown
        StartPoint = Me.PointToScreen(New Point(e.X, e.Y))
        FirstPoint = StartPoint
        IsDragging = True
    End Sub

    Private Sub pnlDrag_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlDrag.MouseMove
        If IsDragging Then
            Dim EndPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))
            IsClick = False
            Me.Left += (EndPoint.X - StartPoint.X)
            Me.Top += (EndPoint.Y - StartPoint.Y)
            StartPoint = EndPoint
            LastPoint = EndPoint
        End If
    End Sub

    Private Sub pnlDrag_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlDrag.MouseUp
        IsDragging = False
        If LastPoint = StartPoint Then IsClick = True Else IsClick = False
    End Sub

#End Region

#Region "Form Component Events"
    Private Sub picLogo_DoubleClick(sender As Object, e As EventArgs) Handles picLogo.DoubleClick
        Process.Start("https://www.ncceep.com/")
    End Sub

    'Enter key triggers the addition of participants
    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (txtName.Text.Equals(txtPhone.Text) And txtName.Text.Equals(txtEmail.Text) And txtName.Text.Equals("") = True) Then
                DataGridView1.Rows.Add(txtName.Text, txtPhone.Text, txtEmail.Text)
                amount_total_curr_part += 1
            End If
        End If
    End Sub

    'Clears the entries in the textboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmail.Text = String.Empty
        txtName.Text = String.Empty
        txtPhone.Text = String.Empty
    End Sub

    'Adds participants to database
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (txtName.Text.Equals(txtPhone.Text) And txtName.Text.Equals(txtEmail.Text) And txtName.Text.Equals("") = True) Then
            DataGridView1.Rows.Add(txtName.Text, txtPhone.Text, txtEmail.Text)
            amount_total_curr_part += 1
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Button to send batch of emails
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        frmEmail.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        amount_total_curr_part += 1
    End Sub
#End Region

End Class