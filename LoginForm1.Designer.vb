<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents txtBox1_login As TextBox
    Friend WithEvents txtBox2_password As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        LogoPictureBox = New PictureBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        txtBox1_login = New TextBox()
        txtBox2_password = New TextBox()
        OK = New Button()
        Cancel = New Button()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(0, 0)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(165, 193)
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(172, 24)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&Nome de Usuário"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(172, 81)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Senha"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBox1_login
        ' 
        txtBox1_login.Location = New Point(174, 44)
        txtBox1_login.Name = "txtBox1_login"
        txtBox1_login.Size = New Size(220, 27)
        txtBox1_login.TabIndex = 1
        ' 
        ' txtBox2_password
        ' 
        txtBox2_password.Location = New Point(174, 101)
        txtBox2_password.Name = "txtBox2_password"
        txtBox2_password.PasswordChar = "*"c
        txtBox2_password.Size = New Size(220, 27)
        txtBox2_password.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(197, 161)
        OK.Name = "OK"
        OK.Size = New Size(97, 32)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(300, 161)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 32)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancelar"
        ' 
        ' LoginForm1
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(405, 206)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(txtBox2_password)
        Controls.Add(txtBox1_login)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login - Restaurante Juá"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
