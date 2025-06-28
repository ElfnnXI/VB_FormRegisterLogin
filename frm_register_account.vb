Public Class frm_register_account
    Private Sub btn_have_Click(sender As Object, e As EventArgs) Handles btn_have.Click
        'Program membuka form login
        Me.Hide()
        Dim login As New frm_login_account
        login.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        'Menutup form program ini
        Me.Close()
    End Sub

    Private Sub frm_register_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mengunakan sistem hide password saat form di load pertama kalinya
        txt_password.UseSystemPasswordChar = True

    End Sub

    Private Sub chk_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles chk_showpass.CheckedChanged
        'Program untuk hide/unhide password pada txt password dan txt confirm
        If chk_showpass.Checked Then
            txt_password.UseSystemPasswordChar = False
            txt_confirm.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
            txt_confirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        'Program memnghapus konten pada textbox
        txt_name.Text = ""
        txt_sex.Text = ""
        txt_birth.Text = ""
        txt_email.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        txt_confirm.Text = ""
    End Sub
End Class