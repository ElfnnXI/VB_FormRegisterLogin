<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_register_account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbl_gasussgo = New Label()
        lbl_workplace = New Label()
        btn_exit = New Button()
        lbl_developed = New Label()
        lbl_by = New Label()
        lbl_ikmalthaufanmahdi = New Label()
        lbl_lets = New Label()
        chk_showpass = New CheckBox()
        txt_confirm = New TextBox()
        txt_password = New TextBox()
        lbl_confirm = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txt_name = New TextBox()
        txt_birth = New TextBox()
        lbl_name = New Label()
        txt_username = New TextBox()
        lbl_birth = New Label()
        lbl_password = New Label()
        lbl_username = New Label()
        btn_clear = New Button()
        btn_have = New Button()
        btn_create = New Button()
        lbl_sex = New Label()
        txt_sex = New TextBox()
        lbl_email = New Label()
        txt_email = New TextBox()
        lbl_gasussgo_w = New Label()
        lbl_for = New Label()
        lbl_2024 = New Label()
        SuspendLayout()
        ' 
        ' lbl_gasussgo
        ' 
        lbl_gasussgo.AutoSize = True
        lbl_gasussgo.Font = New Font("Niagara Engraved", 35.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_gasussgo.ForeColor = Color.Violet
        lbl_gasussgo.Location = New Point(2, 2)
        lbl_gasussgo.Name = "lbl_gasussgo"
        lbl_gasussgo.Size = New Size(127, 50)
        lbl_gasussgo.TabIndex = 0
        lbl_gasussgo.Text = "Gasussgo"
        ' 
        ' lbl_workplace
        ' 
        lbl_workplace.AutoSize = True
        lbl_workplace.BackColor = Color.Transparent
        lbl_workplace.Font = New Font("Niagara Engraved", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_workplace.ForeColor = Color.White
        lbl_workplace.Location = New Point(22, 43)
        lbl_workplace.Name = "lbl_workplace"
        lbl_workplace.Size = New Size(62, 22)
        lbl_workplace.TabIndex = 1
        lbl_workplace.Text = "Workplace"
        ' 
        ' btn_exit
        ' 
        btn_exit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_exit.BackColor = Color.White
        btn_exit.Cursor = Cursors.Hand
        btn_exit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_exit.ForeColor = Color.Red
        btn_exit.Location = New Point(525, -4)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(27, 30)
        btn_exit.TabIndex = 66
        btn_exit.Text = "X"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' lbl_developed
        ' 
        lbl_developed.AutoSize = True
        lbl_developed.BackColor = Color.Transparent
        lbl_developed.Font = New Font("Calibri", 9F, FontStyle.Bold)
        lbl_developed.ForeColor = Color.White
        lbl_developed.Location = New Point(182, 667)
        lbl_developed.Name = "lbl_developed"
        lbl_developed.Size = New Size(60, 14)
        lbl_developed.TabIndex = 63
        lbl_developed.Text = "Developed"
        ' 
        ' lbl_by
        ' 
        lbl_by.AutoSize = True
        lbl_by.BackColor = Color.Transparent
        lbl_by.Font = New Font("Calibri", 9F, FontStyle.Bold)
        lbl_by.ForeColor = Color.White
        lbl_by.Location = New Point(238, 667)
        lbl_by.Name = "lbl_by"
        lbl_by.Size = New Size(19, 14)
        lbl_by.TabIndex = 62
        lbl_by.Text = "by"
        ' 
        ' lbl_ikmalthaufanmahdi
        ' 
        lbl_ikmalthaufanmahdi.AutoSize = True
        lbl_ikmalthaufanmahdi.BackColor = Color.Transparent
        lbl_ikmalthaufanmahdi.Font = New Font("Calibri", 9F, FontStyle.Bold)
        lbl_ikmalthaufanmahdi.ForeColor = Color.White
        lbl_ikmalthaufanmahdi.Location = New Point(253, 667)
        lbl_ikmalthaufanmahdi.Name = "lbl_ikmalthaufanmahdi"
        lbl_ikmalthaufanmahdi.Size = New Size(112, 14)
        lbl_ikmalthaufanmahdi.TabIndex = 61
        lbl_ikmalthaufanmahdi.Text = "Ikmal Thaufan Mahdi"
        ' 
        ' lbl_lets
        ' 
        lbl_lets.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_lets.AutoSize = True
        lbl_lets.Font = New Font("Agency FB", 40.25F, FontStyle.Bold)
        lbl_lets.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        lbl_lets.Location = New Point(162, 94)
        lbl_lets.Name = "lbl_lets"
        lbl_lets.Size = New Size(216, 64)
        lbl_lets.TabIndex = 60
        lbl_lets.Text = "Let's Start"
        ' 
        ' chk_showpass
        ' 
        chk_showpass.AutoSize = True
        chk_showpass.Cursor = Cursors.Hand
        chk_showpass.ForeColor = Color.LightYellow
        chk_showpass.Location = New Point(225, 502)
        chk_showpass.Name = "chk_showpass"
        chk_showpass.Size = New Size(111, 19)
        chk_showpass.TabIndex = 59
        chk_showpass.Text = "Show Password "
        chk_showpass.UseVisualStyleBackColor = True
        ' 
        ' txt_confirm
        ' 
        txt_confirm.Cursor = Cursors.IBeam
        txt_confirm.Font = New Font("Calibri", 12F)
        txt_confirm.Location = New Point(216, 470)
        txt_confirm.MaxLength = 50
        txt_confirm.Name = "txt_confirm"
        txt_confirm.Size = New Size(300, 27)
        txt_confirm.TabIndex = 58
        txt_confirm.UseSystemPasswordChar = True
        txt_confirm.WordWrap = False
        ' 
        ' txt_password
        ' 
        txt_password.Cursor = Cursors.IBeam
        txt_password.Font = New Font("Calibri", 12F)
        txt_password.Location = New Point(216, 437)
        txt_password.MaxLength = 50
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(300, 27)
        txt_password.TabIndex = 57
        txt_password.UseSystemPasswordChar = True
        txt_password.WordWrap = False
        ' 
        ' lbl_confirm
        ' 
        lbl_confirm.AutoSize = True
        lbl_confirm.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_confirm.ForeColor = Color.LightYellow
        lbl_confirm.Location = New Point(25, 478)
        lbl_confirm.Name = "lbl_confirm"
        lbl_confirm.Size = New Size(130, 19)
        lbl_confirm.TabIndex = 53
        lbl_confirm.Text = "Confirm Password"
        ' 
        ' txt_name
        ' 
        txt_name.Cursor = Cursors.IBeam
        txt_name.Font = New Font("Calibri", 12F)
        txt_name.ForeColor = SystemColors.WindowText
        txt_name.Location = New Point(216, 272)
        txt_name.MaxLength = 50
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(300, 27)
        txt_name.TabIndex = 54
        txt_name.WordWrap = False
        ' 
        ' txt_birth
        ' 
        txt_birth.Cursor = Cursors.IBeam
        txt_birth.Font = New Font("Calibri", 12F)
        txt_birth.ForeColor = SystemColors.WindowText
        txt_birth.Location = New Point(216, 338)
        txt_birth.MaxLength = 50
        txt_birth.Name = "txt_birth"
        txt_birth.Size = New Size(300, 27)
        txt_birth.TabIndex = 55
        txt_birth.WordWrap = False
        ' 
        ' lbl_name
        ' 
        lbl_name.AutoSize = True
        lbl_name.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_name.ForeColor = Color.LightYellow
        lbl_name.Location = New Point(25, 277)
        lbl_name.Name = "lbl_name"
        lbl_name.Size = New Size(78, 19)
        lbl_name.TabIndex = 51
        lbl_name.Text = "Full Name"
        ' 
        ' txt_username
        ' 
        txt_username.Cursor = Cursors.IBeam
        txt_username.Font = New Font("Calibri", 12F)
        txt_username.ForeColor = SystemColors.WindowText
        txt_username.Location = New Point(216, 371)
        txt_username.MaxLength = 50
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(300, 27)
        txt_username.TabIndex = 56
        txt_username.WordWrap = False
        ' 
        ' lbl_birth
        ' 
        lbl_birth.AutoSize = True
        lbl_birth.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_birth.ForeColor = Color.LightYellow
        lbl_birth.Location = New Point(25, 343)
        lbl_birth.Name = "lbl_birth"
        lbl_birth.Size = New Size(97, 19)
        lbl_birth.TabIndex = 50
        lbl_birth.Text = "Date of Birth"
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_password.ForeColor = Color.LightYellow
        lbl_password.Location = New Point(25, 440)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(72, 19)
        lbl_password.TabIndex = 52
        lbl_password.Text = "Password"
        ' 
        ' lbl_username
        ' 
        lbl_username.AutoSize = True
        lbl_username.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_username.ForeColor = Color.LightYellow
        lbl_username.Location = New Point(25, 374)
        lbl_username.Name = "lbl_username"
        lbl_username.Size = New Size(168, 19)
        lbl_username.TabIndex = 49
        lbl_username.Text = "Username New Account"
        ' 
        ' btn_clear
        ' 
        btn_clear.Cursor = Cursors.Hand
        btn_clear.Location = New Point(48, 567)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(452, 40)
        btn_clear.TabIndex = 48
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' btn_have
        ' 
        btn_have.Cursor = Cursors.Hand
        btn_have.Location = New Point(48, 610)
        btn_have.Name = "btn_have"
        btn_have.Size = New Size(225, 34)
        btn_have.TabIndex = 47
        btn_have.Text = "I Have Account"
        btn_have.UseVisualStyleBackColor = True
        ' 
        ' btn_create
        ' 
        btn_create.Cursor = Cursors.Hand
        btn_create.Location = New Point(275, 610)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(225, 34)
        btn_create.TabIndex = 46
        btn_create.Text = "Create Account "
        btn_create.UseVisualStyleBackColor = True
        ' 
        ' lbl_sex
        ' 
        lbl_sex.AutoSize = True
        lbl_sex.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_sex.ForeColor = Color.LightYellow
        lbl_sex.Location = New Point(25, 310)
        lbl_sex.Name = "lbl_sex"
        lbl_sex.Size = New Size(34, 19)
        lbl_sex.TabIndex = 50
        lbl_sex.Text = "Sex"
        ' 
        ' txt_sex
        ' 
        txt_sex.Cursor = Cursors.IBeam
        txt_sex.Font = New Font("Calibri", 12F)
        txt_sex.ForeColor = SystemColors.WindowText
        txt_sex.Location = New Point(216, 305)
        txt_sex.MaxLength = 50
        txt_sex.Name = "txt_sex"
        txt_sex.Size = New Size(300, 27)
        txt_sex.TabIndex = 55
        txt_sex.WordWrap = False
        ' 
        ' lbl_email
        ' 
        lbl_email.AutoSize = True
        lbl_email.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_email.ForeColor = Color.LightYellow
        lbl_email.Location = New Point(25, 407)
        lbl_email.Name = "lbl_email"
        lbl_email.Size = New Size(105, 19)
        lbl_email.TabIndex = 49
        lbl_email.Text = "Email Address"
        ' 
        ' txt_email
        ' 
        txt_email.Cursor = Cursors.IBeam
        txt_email.Font = New Font("Calibri", 12F)
        txt_email.ForeColor = SystemColors.WindowText
        txt_email.Location = New Point(216, 404)
        txt_email.MaxLength = 50
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(300, 27)
        txt_email.TabIndex = 56
        txt_email.WordWrap = False
        ' 
        ' lbl_gasussgo_w
        ' 
        lbl_gasussgo_w.AutoSize = True
        lbl_gasussgo_w.Font = New Font("Agency FB", 25.25F, FontStyle.Bold)
        lbl_gasussgo_w.Location = New Point(145, 183)
        lbl_gasussgo_w.Name = "lbl_gasussgo_w"
        lbl_gasussgo_w.Size = New Size(247, 41)
        lbl_gasussgo_w.TabIndex = 67
        lbl_gasussgo_w.Text = "Gasussgo Workplace"
        ' 
        ' lbl_for
        ' 
        lbl_for.AutoSize = True
        lbl_for.Font = New Font("Agency FB", 15.25F, FontStyle.Bold)
        lbl_for.ForeColor = Color.White
        lbl_for.Location = New Point(254, 157)
        lbl_for.Name = "lbl_for"
        lbl_for.Size = New Size(31, 25)
        lbl_for.TabIndex = 68
        lbl_for.Text = "For"
        ' 
        ' lbl_2024
        ' 
        lbl_2024.AutoSize = True
        lbl_2024.Font = New Font("Calibri", 8F, FontStyle.Bold)
        lbl_2024.ForeColor = Color.White
        lbl_2024.Location = New Point(264, 681)
        lbl_2024.Name = "lbl_2024"
        lbl_2024.Size = New Size(31, 13)
        lbl_2024.TabIndex = 69
        lbl_2024.Text = "2024"
        ' 
        ' frm_register_account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(114), CByte(149))
        ClientSize = New Size(550, 700)
        Controls.Add(lbl_2024)
        Controls.Add(lbl_for)
        Controls.Add(lbl_gasussgo_w)
        Controls.Add(btn_exit)
        Controls.Add(lbl_developed)
        Controls.Add(lbl_by)
        Controls.Add(lbl_ikmalthaufanmahdi)
        Controls.Add(lbl_lets)
        Controls.Add(chk_showpass)
        Controls.Add(txt_confirm)
        Controls.Add(txt_password)
        Controls.Add(lbl_confirm)
        Controls.Add(txt_name)
        Controls.Add(txt_sex)
        Controls.Add(txt_birth)
        Controls.Add(lbl_name)
        Controls.Add(lbl_sex)
        Controls.Add(txt_email)
        Controls.Add(txt_username)
        Controls.Add(lbl_birth)
        Controls.Add(lbl_email)
        Controls.Add(lbl_password)
        Controls.Add(lbl_username)
        Controls.Add(btn_clear)
        Controls.Add(btn_have)
        Controls.Add(btn_create)
        Controls.Add(lbl_workplace)
        Controls.Add(lbl_gasussgo)
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_register_account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register Account Gasussgo Workplace Limited"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_gasussgo As Label
    Friend WithEvents lbl_workplace As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_developed As Label
    Friend WithEvents lbl_by As Label
    Friend WithEvents lbl_ikmalthaufanmahdi As Label
    Friend WithEvents lbl_lets As Label
    Friend WithEvents chk_showpass As CheckBox
    Friend WithEvents txt_confirm As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_confirm As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_birth As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_birth As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_have As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents lbl_sex As Label
    Friend WithEvents txt_sex As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_gasussgo_w As Label
    Friend WithEvents lbl_for As Label
    Friend WithEvents lbl_2024 As Label
End Class
