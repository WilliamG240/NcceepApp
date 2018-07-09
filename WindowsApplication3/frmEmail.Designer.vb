<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmail))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.textSubject = New System.Windows.Forms.TextBox()
        Me.textCc = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pgSending = New System.Windows.Forms.ProgressBar()
        Me.htmlEditor = New System.Windows.Forms.WebBrowser()
        Me.lstSize = New System.Windows.Forms.ComboBox()
        Me.lstFont = New System.Windows.Forms.ComboBox()
        Me.sbStatus = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2.SuspendLayout()
        Me.sbStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 18)
        Me.Panel2.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(668, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 18)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Location = New System.Drawing.Point(489, 321)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(115, 35)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'textSubject
        '
        Me.textSubject.Location = New System.Drawing.Point(59, 51)
        Me.textSubject.Name = "textSubject"
        Me.textSubject.Size = New System.Drawing.Size(297, 20)
        Me.textSubject.TabIndex = 15
        '
        'textCc
        '
        Me.textCc.Location = New System.Drawing.Point(59, 26)
        Me.textCc.Name = "textCc"
        Me.textCc.Size = New System.Drawing.Size(297, 20)
        Me.textCc.TabIndex = 14
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(7, 51)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 32
        Me.label4.Text = "Subject"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(20, 13)
        Me.label3.TabIndex = 31
        Me.label3.Text = "Cc"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(614, 321)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 35)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pgSending
        '
        Me.pgSending.Location = New System.Drawing.Point(3, 336)
        Me.pgSending.Name = "pgSending"
        Me.pgSending.Size = New System.Drawing.Size(480, 8)
        Me.pgSending.TabIndex = 38
        '
        'htmlEditor
        '
        Me.htmlEditor.Location = New System.Drawing.Point(12, 104)
        Me.htmlEditor.MinimumSize = New System.Drawing.Size(20, 20)
        Me.htmlEditor.Name = "htmlEditor"
        Me.htmlEditor.Size = New System.Drawing.Size(726, 211)
        Me.htmlEditor.TabIndex = 42
        '
        'lstSize
        '
        Me.lstSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstSize.Location = New System.Drawing.Point(154, 77)
        Me.lstSize.Name = "lstSize"
        Me.lstSize.Size = New System.Drawing.Size(80, 21)
        Me.lstSize.TabIndex = 44
        '
        'lstFont
        '
        Me.lstFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstFont.Location = New System.Drawing.Point(12, 77)
        Me.lstFont.Name = "lstFont"
        Me.lstFont.Size = New System.Drawing.Size(136, 21)
        Me.lstFont.TabIndex = 43
        '
        'sbStatus
        '
        Me.sbStatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.sbStatus.Location = New System.Drawing.Point(0, 364)
        Me.sbStatus.Name = "sbStatus"
        Me.sbStatus.Size = New System.Drawing.Size(736, 22)
        Me.sbStatus.TabIndex = 45
        Me.sbStatus.Text = "jjkh"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'frmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 386)
        Me.Controls.Add(Me.sbStatus)
        Me.Controls.Add(Me.lstSize)
        Me.Controls.Add(Me.lstFont)
        Me.Controls.Add(Me.htmlEditor)
        Me.Controls.Add(Me.pgSending)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textSubject)
        Me.Controls.Add(Me.textCc)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmail"
        Me.Panel2.ResumeLayout(False)
        Me.sbStatus.ResumeLayout(False)
        Me.sbStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents textSubject As TextBox
    Friend WithEvents textCc As TextBox
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents pgSending As ProgressBar
    Friend WithEvents htmlEditor As WebBrowser
    Friend WithEvents lstSize As ComboBox
    Friend WithEvents lstFont As ComboBox
    Friend WithEvents sbStatus As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
