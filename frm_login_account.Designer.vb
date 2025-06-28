<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login_account
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
        btn_exit = New Button()
        lbl_developed = New Label()
        lbl_by = New Label()
        lbl_ikmalthaufanmahdi = New Label()
        lbl_welcome = New Label()
        txt_password = New TextBox()
        txt_username = New TextBox()
        lbl_password = New Label()
        lbl_username = New Label()
        btn_clear = New Button()
        btn_register = New Button()
        btn_login = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        lbl_workplace = New Label()
        lbl_gasussgo = New Label()
        chk_showpass = New CheckBox()
        lbl_for = New Label()
        lbl_forgotpass = New Label()
        lbl_2024 = New Label()
        SuspendLayout()
        ' 
        ' btn_exit
        ' 
        btn_exit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_exit.BackColor = Color.White
        btn_exit.Cursor = Cursors.Hand
        btn_exit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_exit.ForeColor = Color.Red
        btn_exit.Location = New Point(526, -5)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(27, 30)
        btn_exit.TabIndex = 91
        btn_exit.Text = "X"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' lbl_developed
        ' 
        lbl_developed.AutoSize = True
        lbl_developed.BackColor = Color.Transparent
        lbl_developed.Font = New Font("Calibri", 9F, FontStyle.Bold)
        lbl_developed.ForeColor = Color.White
        lbl_developed.Location = New Point(181, 668)
        lbl_developed.Name = "lbl_developed"
        lbl_developed.Size = New Size(60, 14)
        lbl_developed.TabIndex = 90
        lbl_developed.Text = "Developed"
        ' 
        ' lbl_by
        ' 
        lbl_by.AutoSize = True
        lbl_by.BackColor = Color.Transparent
        lbl_by.Font = New Font("Calibri", 9F, FontStyle.Bold)
        lbl_by.ForeColor = Color.White
        lbl_by.Location = New Point(237, 668)
        lbl_by.Name = "lbl_by"
        lbl_by.Size = New Size(19, 14)
        lbl_by.TabIndex = 89
        lbl_by.Text = "by"
        ' 
        ' lbl_ikmalthaufanmahdi
        ' 
        lbl_ikmalthaufanmahdi.AutoSize = True
        lbl_ikmalthaufanmahdi.BackColor = Color.Transparent
        lbl_ikmalthaufanmahdi.Font = New Font("Calibri", 9F, FontStyle.Bold)
        lbl_ikmalthaufanmahdi.ForeColor = Color.White
        lbl_ikmalthaufanmahdi.Location = New Point(252, 668)
        lbl_ikmalthaufanmahdi.Name = "lbl_ikmalthaufanmahdi"
        lbl_ikmalthaufanmahdi.Size = New Size(112, 14)
        lbl_ikmalthaufanmahdi.TabIndex = 88
        lbl_ikmalthaufanmahdi.Text = "Ikmal Thaufan Mahdi"
        ' 
        ' lbl_welcome
        ' 
        lbl_welcome.AutoSize = True
        lbl_welcome.Font = New Font("Agency FB", 50.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_welcome.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        lbl_welcome.Location = New Point(80, 121)
        lbl_welcome.Name = "lbl_welcome"
        lbl_welcome.Size = New Size(389, 80)
        lbl_welcome.TabIndex = 87
        lbl_welcome.Text = "Welcome Back !"
        ' 
        ' txt_password
        ' 
        txt_password.Cursor = Cursors.IBeam
        txt_password.Font = New Font("Calibri", 12F)
        txt_password.Location = New Point(180, 385)
        txt_password.MaxLength = 50
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(318, 27)
        txt_password.TabIndex = 84
        txt_password.UseSystemPasswordChar = True
        txt_password.WordWrap = False
        ' 
        ' txt_username
        ' 
        txt_username.Cursor = Cursors.IBeam
        txt_username.Font = New Font("Calibri", 12F)
        txt_username.ForeColor = SystemColors.WindowText
        txt_username.Location = New Point(180, 325)
        txt_username.MaxLength = 50
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(318, 27)
        txt_username.TabIndex = 83
        txt_username.WordWrap = False
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold)
        lbl_password.ForeColor = Color.LightYellow
        lbl_password.Location = New Point(29, 381)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(127, 31)
        lbl_password.TabIndex = 77
        lbl_password.Text = "Password"
        ' 
        ' lbl_username
        ' 
        lbl_username.AutoSize = True
        lbl_username.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold)
        lbl_username.ForeColor = Color.LightYellow
        lbl_username.Location = New Point(29, 321)
        lbl_username.Name = "lbl_username"
        lbl_username.Size = New Size(132, 31)
        lbl_username.TabIndex = 73
        lbl_username.Text = "Username"
        ' 
        ' btn_clear
        ' 
        btn_clear.Cursor = Cursors.Hand
        btn_clear.Location = New Point(46, 532)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(452, 40)
        btn_clear.TabIndex = 71
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' btn_register
        ' 
        btn_register.Cursor = Cursors.Hand
        btn_register.Location = New Point(46, 575)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(225, 34)
        btn_register.TabIndex = 70
        btn_register.Text = "Register For New Account"
        btn_register.UseVisualStyleBackColor = True
        ' 
        ' btn_login
        ' 
        btn_login.Cursor = Cursors.Hand
        btn_login.Location = New Point(273, 575)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(225, 34)
        btn_login.TabIndex = 69
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
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
        lbl_workplace.TabIndex = 68
        lbl_workplace.Text = "Workplace"
        ' 
        ' lbl_gasussgo
        ' 
        lbl_gasussgo.AutoSize = True
        lbl_gasussgo.Font = New Font("Niagara Engraved", 35.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_gasussgo.ForeColor = Color.Violet
        lbl_gasussgo.Location = New Point(2, 2)
        lbl_gasussgo.Name = "lbl_gasussgo"
        lbl_gasussgo.Size = New Size(127, 50)
        lbl_gasussgo.TabIndex = 67
        lbl_gasussgo.Text = "Gasussgo"
        ' 
        ' chk_showpass
        ' 
        chk_showpass.AutoSize = True
        chk_showpass.Cursor = Cursors.Hand
        chk_showpass.ForeColor = Color.LightYellow
        chk_showpass.Location = New Point(184, 416)
        chk_showpass.Name = "chk_showpass"
        chk_showpass.Size = New Size(111, 19)
        chk_showpass.TabIndex = 86
        chk_showpass.Text = "Show Password "
        chk_showpass.UseVisualStyleBackColor = True
        ' 
        ' lbl_for
        ' 
        lbl_for.AutoSize = True
        lbl_for.Font = New Font("Agency FB", 30.25F, FontStyle.Bold)
        lbl_for.Location = New Point(122, 189)
        lbl_for.Margin = New Padding(0)
        lbl_for.Name = "lbl_for"
        lbl_for.Size = New Size(301, 50)
        lbl_for.TabIndex = 92
        lbl_for.Text = "For Daily Workspace"
        ' 
        ' lbl_forgotpass
        ' 
        lbl_forgotpass.AutoSize = True
        lbl_forgotpass.Cursor = Cursors.Hand
        lbl_forgotpass.Font = New Font("Calibri", 10F)
        lbl_forgotpass.ForeColor = Color.White
        lbl_forgotpass.Location = New Point(362, 417)
        lbl_forgotpass.Name = "lbl_forgotpass"
        lbl_forgotpass.Size = New Size(136, 17)
        lbl_forgotpass.TabIndex = 93
        lbl_forgotpass.Text = "forgot your password ?"
        ' 
        ' lbl_2024
        ' 
        lbl_2024.AutoSize = True
        lbl_2024.Font = New Font("Calibri", 8F, FontStyle.Bold)
        lbl_2024.ForeColor = Color.White
        lbl_2024.Location = New Point(263, 682)
        lbl_2024.Name = "lbl_2024"
        lbl_2024.Size = New Size(31, 13)
        lbl_2024.TabIndex = 94
        lbl_2024.Text = "2024"
        ' 
        ' frm_login_account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(114), CByte(149))
        ClientSize = New Size(550, 700)
        Controls.Add(lbl_2024)
        Controls.Add(lbl_forgotpass)
        Controls.Add(lbl_for)
        Controls.Add(btn_exit)
        Controls.Add(lbl_developed)
        Controls.Add(lbl_by)
        Controls.Add(lbl_ikmalthaufanmahdi)
        Controls.Add(lbl_welcome)
        Controls.Add(chk_showpass)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(lbl_password)
        Controls.Add(lbl_username)
        Controls.Add(btn_clear)
        Controls.Add(btn_register)
        Controls.Add(btn_login)
        Controls.Add(lbl_workplace)
        Controls.Add(lbl_gasussgo)
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_login_account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Account Gasussgo Workplace Limited"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_developed As Label
    Friend WithEvents lbl_by As Label
    Friend WithEvents lbl_ikmalthaufanmahdi As Label
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_workplace As Label
    Friend WithEvents lbl_gasussgo As Label
    Friend WithEvents chk_showpass As CheckBox
    Friend WithEvents lbl_for As Label
    Friend WithEvents lbl_forgotpass As Label
    Friend WithEvents lbl_2024 As Label

End Class
