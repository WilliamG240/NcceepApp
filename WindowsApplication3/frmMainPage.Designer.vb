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
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.Copyright = New System.Windows.Forms.Label()
        Me.chMembers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpCategories = New System.Windows.Forms.GroupBox()
        Me.radSokoni = New System.Windows.Forms.RadioButton()
        Me.radExec = New System.Windows.Forms.RadioButton()
        Me.radAssociate = New System.Windows.Forms.RadioButton()
        Me.radSeniors = New System.Windows.Forms.RadioButton()
        Me.radApplicants = New System.Windows.Forms.RadioButton()
        Me.radBYAP = New System.Windows.Forms.RadioButton()
        Me.radBPO = New System.Windows.Forms.RadioButton()
        Me.radOmoluabi = New System.Windows.Forms.RadioButton()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtagrdContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategories.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(816, 18)
        Me.Panel2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(743, 0)
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
        Me.txtName.Location = New System.Drawing.Point(314, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(444, 87)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(147, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(614, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 14
        '
        'dtagrdContact
        '
        Me.dtagrdContact.AllowUserToAddRows = False
        Me.dtagrdContact.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtagrdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtagrdContact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmName, Me.clmPhone, Me.clmEmail, Me.clmCategory})
        Me.dtagrdContact.Location = New System.Drawing.Point(220, 271)
        Me.dtagrdContact.Name = "dtagrdContact"
        Me.dtagrdContact.ReadOnly = True
        Me.dtagrdContact.RowHeadersWidth = 50
        Me.dtagrdContact.Size = New System.Drawing.Size(553, 190)
        Me.dtagrdContact.TabIndex = 16
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Location = New System.Drawing.Point(875, 470)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(108, 13)
        Me.Copyright.TabIndex = 0
        Me.Copyright.Text = "© William Nono 2018"
        '
        'chMembers
        '
        Me.chMembers.BackColor = System.Drawing.Color.Gainsboro
        Me.chMembers.BorderlineColor = System.Drawing.Color.Gainsboro
        ChartArea6.BackColor = System.Drawing.Color.Gainsboro
        ChartArea6.Name = "ChartArea1"
        Me.chMembers.ChartAreas.Add(ChartArea6)
        Legend6.BackColor = System.Drawing.Color.Gainsboro
        Legend6.Name = "Legend1"
        Me.chMembers.Legends.Add(Legend6)
        Me.chMembers.Location = New System.Drawing.Point(220, 143)
        Me.chMembers.Name = "chMembers"
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Series6.Legend = "Legend1"
        Series6.Name = "Members"
        Series6.ShadowColor = System.Drawing.Color.Silver
        Me.chMembers.Series.Add(Series6)
        Me.chMembers.Size = New System.Drawing.Size(536, 115)
        Me.chMembers.TabIndex = 17
        Me.chMembers.Text = "Chart1"
        '
        'grpCategories
        '
        Me.grpCategories.Controls.Add(Me.radOmoluabi)
        Me.grpCategories.Controls.Add(Me.radBPO)
        Me.grpCategories.Controls.Add(Me.radBYAP)
        Me.grpCategories.Controls.Add(Me.radApplicants)
        Me.grpCategories.Controls.Add(Me.radSeniors)
        Me.grpCategories.Controls.Add(Me.radAssociate)
        Me.grpCategories.Controls.Add(Me.radExec)
        Me.grpCategories.Controls.Add(Me.radSokoni)
        Me.grpCategories.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCategories.Location = New System.Drawing.Point(808, 57)
        Me.grpCategories.Name = "grpCategories"
        Me.grpCategories.Size = New System.Drawing.Size(145, 231)
        Me.grpCategories.TabIndex = 27
        Me.grpCategories.TabStop = False
        Me.grpCategories.Text = "Categories"
        '
        'radSokoni
        '
        Me.radSokoni.AutoSize = True
        Me.radSokoni.Location = New System.Drawing.Point(6, 21)
        Me.radSokoni.Name = "radSokoni"
        Me.radSokoni.Size = New System.Drawing.Size(66, 20)
        Me.radSokoni.TabIndex = 28
        Me.radSokoni.TabStop = True
        Me.radSokoni.Text = "Sokoni"
        Me.radSokoni.UseVisualStyleBackColor = True
        '
        'radExec
        '
        Me.radExec.AutoSize = True
        Me.radExec.Location = New System.Drawing.Point(6, 47)
        Me.radExec.Name = "radExec"
        Me.radExec.Size = New System.Drawing.Size(89, 20)
        Me.radExec.TabIndex = 29
        Me.radExec.TabStop = True
        Me.radExec.Text = "Executives"
        Me.radExec.UseVisualStyleBackColor = True
        '
        'radAssociate
        '
        Me.radAssociate.AutoSize = True
        Me.radAssociate.Location = New System.Drawing.Point(6, 73)
        Me.radAssociate.Name = "radAssociate"
        Me.radAssociate.Size = New System.Drawing.Size(114, 20)
        Me.radAssociate.TabIndex = 34
        Me.radAssociate.TabStop = True
        Me.radAssociate.Text = "Associate Staff"
        Me.radAssociate.UseVisualStyleBackColor = True
        '
        'radSeniors
        '
        Me.radSeniors.AutoSize = True
        Me.radSeniors.Location = New System.Drawing.Point(6, 99)
        Me.radSeniors.Name = "radSeniors"
        Me.radSeniors.Size = New System.Drawing.Size(70, 20)
        Me.radSeniors.TabIndex = 33
        Me.radSeniors.TabStop = True
        Me.radSeniors.Text = "Seniors"
        Me.radSeniors.UseVisualStyleBackColor = True
        '
        'radApplicants
        '
        Me.radApplicants.AutoSize = True
        Me.radApplicants.Location = New System.Drawing.Point(6, 125)
        Me.radApplicants.Name = "radApplicants"
        Me.radApplicants.Size = New System.Drawing.Size(87, 20)
        Me.radApplicants.TabIndex = 32
        Me.radApplicants.TabStop = True
        Me.radApplicants.Text = "Applicants"
        Me.radApplicants.UseVisualStyleBackColor = True
        '
        'radBYAP
        '
        Me.radBYAP.AutoSize = True
        Me.radBYAP.Location = New System.Drawing.Point(6, 151)
        Me.radBYAP.Name = "radBYAP"
        Me.radBYAP.Size = New System.Drawing.Size(61, 20)
        Me.radBYAP.TabIndex = 31
        Me.radBYAP.TabStop = True
        Me.radBYAP.Text = "BYAP"
        Me.radBYAP.UseVisualStyleBackColor = True
        '
        'radBPO
        '
        Me.radBPO.AutoSize = True
        Me.radBPO.Location = New System.Drawing.Point(6, 177)
        Me.radBPO.Name = "radBPO"
        Me.radBPO.Size = New System.Drawing.Size(54, 20)
        Me.radBPO.TabIndex = 30
        Me.radBPO.TabStop = True
        Me.radBPO.Text = "BPO"
        Me.radBPO.UseVisualStyleBackColor = True
        '
        'radOmoluabi
        '
        Me.radOmoluabi.AutoSize = True
        Me.radOmoluabi.Location = New System.Drawing.Point(6, 203)
        Me.radOmoluabi.Name = "radOmoluabi"
        Me.radOmoluabi.Size = New System.Drawing.Size(81, 20)
        Me.radOmoluabi.TabIndex = 35
        Me.radOmoluabi.TabStop = True
        Me.radOmoluabi.Text = "Omoluabi"
        Me.radOmoluabi.UseVisualStyleBackColor = True
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
        'clmCategory
        '
        Me.clmCategory.HeaderText = "Category"
        Me.clmCategory.Name = "clmCategory"
        Me.clmCategory.ReadOnly = True
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(983, 483)
        Me.Controls.Add(Me.grpCategories)
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
        Me.grpCategories.ResumeLayout(False)
        Me.grpCategories.PerformLayout()
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
    Friend WithEvents pnlDrag As System.Windows.Forms.Panel
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents chMembers As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents grpCategories As GroupBox
    Friend WithEvents radOmoluabi As RadioButton
    Friend WithEvents radBPO As RadioButton
    Friend WithEvents radBYAP As RadioButton
    Friend WithEvents radApplicants As RadioButton
    Friend WithEvents radSeniors As RadioButton
    Friend WithEvents radAssociate As RadioButton
    Friend WithEvents radExec As RadioButton
    Friend WithEvents radSokoni As RadioButton
    Friend WithEvents clmName As DataGridViewTextBoxColumn
    Friend WithEvents clmPhone As DataGridViewTextBoxColumn
    Friend WithEvents clmEmail As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
End Class
