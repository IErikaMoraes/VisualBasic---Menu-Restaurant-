Public Class LoginForm1

    Dim tentativas As Integer = 3


    ' TODO: Inserir c�digo para realizar autentica��o personalizada utilizando o nome de usu�rio e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de seguran�a personalizada pode ser anexada � entidade de seguran�a da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal � a implementa��o de IPrincipal usada para realizar a autentica��o. 
    ' Subsequentemente, My.User ir� retornar informa��es de identifica��o encapsuladas num objeto CustomPrincipal
    ' como nome de usu�rio, nome de exibi��o etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim N_txt_login As String
        Dim N_txt_pass As String
        Dim texto As String

        N_txt_login = txtBox1_login.Text
        N_txt_pass = txtBox2_password.Text


        If (N_txt_login <> "IEFP" Or N_txt_pass <> "programador") Then
            tentativas = tentativas - 1
            texto = " Dados incorretos." & vbLf & " Tente novamente." & vbLf & " Restam " & tentativas & " tentativas."
            MessageBox.Show(texto, "vb.net",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBox1_login.Clear()
            txtBox1_login.Focus()
            txtBox2_password.Clear()

            If tentativas = 0 Then
                End
            End If
        Else
            MessageBox.Show(" Login ou Password corretos," & vbLf & " Seja bem vindo(a)!.", "vb.net",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()
        End If

        'Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtBox1_login.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
