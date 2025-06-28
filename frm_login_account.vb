Public Class frm_login_account
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        'Program membuka form register akun  
        Me.Hide()
        Dim register As New frm_register_account
        register.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        'Menutup form program ini
        Me.Close()
    End Sub

    Private Sub frm_login_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mengunakan sistem hide password saat form di load pertama kalinya
        txt_password.UseSystemPasswordChar = True
    End Sub

    Private Sub chk_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles chk_showpass.CheckedChanged
        'Program untuk hide/unhide password pada txt password
        If chk_showpass.Checked Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        'Program memnghapus konten pada textbox
        txt_username.Text = ""
        txt_password.Text = ""
    End Sub

    Private Sub lbl_forgotpass_Click(sender As Object, e As EventArgs) Handles lbl_forgotpass.Click
        ' Program untuk RESET password yang lupa
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Program untuk membuka form login dengan mengunakan password

        'Jika password dan username yang dimasukan kosong
        If txt_username.Text = "" Then
            MsgBox("Input Correct Username Now", MsgBoxStyle.Exclamation, "Oowh no..?!")
        ElseIf txt_password.Text = "" Then
            MsgBox("Input Correct Password Now", MsgBoxStyle.Exclamation, "Oowh no..?!")
        Else
            'Jika password dan username yang dimasukan benar
            If txt_username.Text = "admin" And txt_password.Text = "user" Then

                Dim menu As New frm_home
                menu.Show()
                Me.Hide()
            Else
                'Jika password dan username salah
                MsgBox("Your Username Or Password Incorrect", MsgBoxStyle.Critical, "Who Are You...?!")
                txt_username.Text = ""
                txt_password.Text = ""
            End If
        End If
    End Sub
End Class
