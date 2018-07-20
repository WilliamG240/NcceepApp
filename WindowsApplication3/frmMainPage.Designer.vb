<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPage))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlDrag = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dtagrdContact = New System.Windows.Forms.DataGridView()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.chMembers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.chkSokoni = New System.Windows.Forms.CheckBox()
        Me.chkExecutives = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtagrdContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlDrag)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 483)
        Me.Panel1.TabIndex = 0
        '
        'pnlDrag
        '
        Me.pnlDrag.Location = New System.Drawing.Point(0, 1)
        Me.pnlDrag.Name = "pnlDrag"
        Me.pnlDrag.Size = New System.Drawing.Size(167, 17)
        Me.pnlDrag.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(1, 143)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 52)
        Me.Panel4.TabIndex = 3
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(0, 279)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(168, 52)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send Emails"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(0, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(168, 52)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(0, 143)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 52)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Member / Subscriber"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(167, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(759, 18)
        Me.Panel2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(686, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 18)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.picLogo)
        Me.Panel3.Location = New System.Drawing.Point(193, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(104, 106)
        Me.Panel3.TabIndex = 2
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(0, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(104, 103)
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(310, 57)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 19)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(440, 57)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(118, 19)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(610, 57)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 19)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(314, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(444, 100)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(147, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(614, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 14
        '
        'dtagrdContact
        '
        Me.dtagrdContact.AllowUserToAddRows = False
        Me.dtagrdContact.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtagrdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtagrdContact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmName, Me.clmPhone, Me.clmEmail})
        Me.dtagrdContact.Location = New System.Drawing.Point(220, 271)
        Me.dtagrdContact.Name = "dtagrdContact"
        Me.dtagrdContact.ReadOnly = True
        Me.dtagrdContact.RowHeadersWidth = 50
        Me.dtagrdContact.Size = New System.Drawing.Size(536, 190)
        Me.dtagrdContact.TabIndex = 16
        '
        'clmName
        '
        Me.clmName.HeaderText = "Name"
        Me.clmName.Name = "clmName"
        Me.clmName.ReadOnly = True
        '
        'clmPhone
        '
        Me.clmPhone.HeaderText = "Phone"
        Me.clmPhone.Name = "clmPhone"
        Me.clmPhone.ReadOnly = True
        '
        'clmEmail
        '
        Me.clmEmail.HeaderText = "Email"
        Me.clmEmail.Name = "clmEmail"
        Me.clmEmail.ReadOnly = True
        Me.clmEmail.Width = 200
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Location = New System.Drawing.Point(648, 464)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(108, 13)
        Me.Copyright.TabIndex = 0
        Me.Copyright.Text = "© William Nono 2018"
        '
        'chMembers
        '
        Me.chMembers.BackColor = System.Drawing.Color.Gainsboro
        Me.chMembers.BorderlineColor = System.Drawing.Color.Gainsboro
        ChartArea1.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.chMembers.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Gainsboro
        Legend1.Name = "Legend1"
        Me.chMembers.Legends.Add(Legend1)
        Me.chMembers.Location = New System.Drawing.Point(220, 143)
        Me.chMembers.Name = "chMembers"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Members"
        Series1.ShadowColor = System.Drawing.Color.Silver
        Me.chMembers.Series.Add(Series1)
        Me.chMembers.Size = New System.Drawing.Size(536, 115)
        Me.chMembers.TabIndex = 17
        Me.chMembers.Text = "Chart1"
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategories.Location = New System.Drawing.Point(780, 57)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(88, 19)
        Me.lblCategories.TabIndex = 18
        Me.lblCategories.Text = "Categories"
        '
        'chkSokoni
        '
        Me.chkSokoni.AutoSize = True
        Me.chkSokoni.Location = New System.Drawing.Point(783, 79)
        Me.chkSokoni.Name = "chkSokoni"
        Me.chkSokoni.Size = New System.Drawing.Size(59, 17)
        Me.chkSokoni.TabIndex = 19
        Me.chkSokoni.Text = "Sokoni"
        Me.chkSokoni.UseVisualStyleBackColor = True
        '
        'chkExecutives
        '
        Me.chkExecutives.AutoSize = True
        Me.chkExecutives.Location = New System.Drawing.Point(783, 103)
        Me.chkExecutives.Name = "chkExecutives"
        Me.chkExecutives.Size = New System.Drawing.Size(78, 17)
        Me.chkExecutives.TabIndex = 20
        Me.chkExecutives.Text = "Executives"
        Me.chkExecutives.UseVisualStyleBackColor = True
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(926, 483)
        Me.Controls.Add(Me.chkExecutives)
        Me.Controls.Add(Me.chkSokoni)
        Me.Controls.Add(Me.lblCategories)
        Me.Controls.Add(Me.chMembers)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.dtagrdContact)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtagrdContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents dtagrdContact As System.Windows.Forms.DataGridView
    Friend WithEvents clmName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlDrag As System.Windows.Forms.Panel
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents chMembers As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblCategories As Label
    Friend WithEvents chkSokoni As CheckBox
    Friend WithEvents chkExecutives As CheckBox
End Class
