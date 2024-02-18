<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        cmd_sair = New Button()
        lbMenu = New Label()
        lbMenuDia = New Label()
        cmb_opcoesMenu = New ComboBox()
        img_feijoada = New PictureBox()
        img_pastel = New PictureBox()
        img_cozidopt = New PictureBox()
        img_bobo = New PictureBox()
        img_buracoHot = New PictureBox()
        img_sushi = New PictureBox()
        img_pizza = New PictureBox()
        lbValor = New Label()
        lbl_valor = New Label()
        cmd_toForm2 = New Button()
        txt_qtdd = New TextBox()
        Label1 = New Label()
        lbl_troco = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        cmd_add_pedido = New Button()
        cmd_pago = New Button()
        txt_pago = New TextBox()
        lbl_verficaNum_qtdd = New Label()
        lbl_verficaNum_pago = New Label()
        lbl_total = New Label()
        ListBox1 = New ListBox()
        lbl_media = New Label()
        lbl_mais_caros = New Label()
        CType(img_feijoada, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_pastel, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_cozidopt, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_bobo, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_buracoHot, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_sushi, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_pizza, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_sair
        ' 
        cmd_sair.BackColor = Color.LightCoral
        cmd_sair.Font = New Font("Jokerman", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        cmd_sair.Location = New Point(61, 798)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(75, 39)
        cmd_sair.TabIndex = 0
        cmd_sair.Text = "SAIR"
        cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' lbMenu
        ' 
        lbMenu.AutoSize = True
        lbMenu.BackColor = Color.Gainsboro
        lbMenu.Font = New Font("Jokerman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbMenu.ForeColor = Color.DarkMagenta
        lbMenu.Location = New Point(361, 518)
        lbMenu.Name = "lbMenu"
        lbMenu.Size = New Size(51, 22)
        lbMenu.TabIndex = 1
        lbMenu.Text = "Menu"
        ' 
        ' lbMenuDia
        ' 
        lbMenuDia.AutoSize = True
        lbMenuDia.BackColor = Color.Transparent
        lbMenuDia.Font = New Font("Jokerman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        lbMenuDia.ForeColor = Color.DarkMagenta
        lbMenuDia.Location = New Point(274, 99)
        lbMenuDia.Name = "lbMenuDia"
        lbMenuDia.Size = New Size(115, 43)
        lbMenuDia.TabIndex = 2
        lbMenuDia.Text = "MENU"
        ' 
        ' cmb_opcoesMenu
        ' 
        cmb_opcoesMenu.BackColor = Color.Thistle
        cmb_opcoesMenu.Font = New Font("Jokerman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cmb_opcoesMenu.ForeColor = SystemColors.ActiveCaptionText
        cmb_opcoesMenu.FormattingEnabled = True
        cmb_opcoesMenu.Location = New Point(65, 244)
        cmb_opcoesMenu.Name = "cmb_opcoesMenu"
        cmb_opcoesMenu.Size = New Size(150, 30)
        cmb_opcoesMenu.TabIndex = 3
        cmb_opcoesMenu.Text = "Escolha o dia"
        ' 
        ' img_feijoada
        ' 
        img_feijoada.BorderStyle = BorderStyle.Fixed3D
        img_feijoada.Image = CType(resources.GetObject("img_feijoada.Image"), Image)
        img_feijoada.Location = New Point(65, 473)
        img_feijoada.Name = "img_feijoada"
        img_feijoada.Size = New Size(282, 206)
        img_feijoada.SizeMode = PictureBoxSizeMode.StretchImage
        img_feijoada.TabIndex = 4
        img_feijoada.TabStop = False
        ' 
        ' img_pastel
        ' 
        img_pastel.BorderStyle = BorderStyle.Fixed3D
        img_pastel.Image = CType(resources.GetObject("img_pastel.Image"), Image)
        img_pastel.Location = New Point(68, 473)
        img_pastel.Name = "img_pastel"
        img_pastel.Size = New Size(279, 206)
        img_pastel.SizeMode = PictureBoxSizeMode.StretchImage
        img_pastel.TabIndex = 5
        img_pastel.TabStop = False
        ' 
        ' img_cozidopt
        ' 
        img_cozidopt.BorderStyle = BorderStyle.Fixed3D
        img_cozidopt.Image = CType(resources.GetObject("img_cozidopt.Image"), Image)
        img_cozidopt.Location = New Point(68, 473)
        img_cozidopt.Name = "img_cozidopt"
        img_cozidopt.Size = New Size(279, 206)
        img_cozidopt.SizeMode = PictureBoxSizeMode.StretchImage
        img_cozidopt.TabIndex = 6
        img_cozidopt.TabStop = False
        ' 
        ' img_bobo
        ' 
        img_bobo.BorderStyle = BorderStyle.Fixed3D
        img_bobo.Image = CType(resources.GetObject("img_bobo.Image"), Image)
        img_bobo.Location = New Point(66, 473)
        img_bobo.Name = "img_bobo"
        img_bobo.Size = New Size(279, 206)
        img_bobo.SizeMode = PictureBoxSizeMode.StretchImage
        img_bobo.TabIndex = 7
        img_bobo.TabStop = False
        ' 
        ' img_buracoHot
        ' 
        img_buracoHot.BorderStyle = BorderStyle.Fixed3D
        img_buracoHot.Image = CType(resources.GetObject("img_buracoHot.Image"), Image)
        img_buracoHot.Location = New Point(67, 473)
        img_buracoHot.Name = "img_buracoHot"
        img_buracoHot.Size = New Size(279, 206)
        img_buracoHot.SizeMode = PictureBoxSizeMode.StretchImage
        img_buracoHot.TabIndex = 8
        img_buracoHot.TabStop = False
        ' 
        ' img_sushi
        ' 
        img_sushi.BorderStyle = BorderStyle.Fixed3D
        img_sushi.Image = CType(resources.GetObject("img_sushi.Image"), Image)
        img_sushi.Location = New Point(68, 472)
        img_sushi.Name = "img_sushi"
        img_sushi.Size = New Size(279, 206)
        img_sushi.SizeMode = PictureBoxSizeMode.StretchImage
        img_sushi.TabIndex = 9
        img_sushi.TabStop = False
        ' 
        ' img_pizza
        ' 
        img_pizza.BorderStyle = BorderStyle.Fixed3D
        img_pizza.Image = CType(resources.GetObject("img_pizza.Image"), Image)
        img_pizza.Location = New Point(65, 473)
        img_pizza.Name = "img_pizza"
        img_pizza.Size = New Size(280, 206)
        img_pizza.SizeMode = PictureBoxSizeMode.StretchImage
        img_pizza.TabIndex = 10
        img_pizza.TabStop = False
        ' 
        ' lbValor
        ' 
        lbValor.AutoSize = True
        lbValor.Location = New Point(435, 145)
        lbValor.Name = "lbValor"
        lbValor.Size = New Size(0, 20)
        lbValor.TabIndex = 11
        ' 
        ' lbl_valor
        ' 
        lbl_valor.AutoSize = True
        lbl_valor.BackColor = Color.Gainsboro
        lbl_valor.Font = New Font("Jokerman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_valor.ForeColor = Color.DarkMagenta
        lbl_valor.Location = New Point(361, 480)
        lbl_valor.Name = "lbl_valor"
        lbl_valor.Size = New Size(50, 22)
        lbl_valor.TabIndex = 12
        lbl_valor.Text = "Valor"
        ' 
        ' cmd_toForm2
        ' 
        cmd_toForm2.BackColor = Color.Thistle
        cmd_toForm2.Font = New Font("Jokerman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmd_toForm2.Location = New Point(490, 798)
        cmd_toForm2.Name = "cmd_toForm2"
        cmd_toForm2.Size = New Size(104, 39)
        cmd_toForm2.TabIndex = 15
        cmd_toForm2.Text = "Pedido"
        cmd_toForm2.UseVisualStyleBackColor = False
        ' 
        ' txt_qtdd
        ' 
        txt_qtdd.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txt_qtdd.Location = New Point(391, 243)
        txt_qtdd.Name = "txt_qtdd"
        txt_qtdd.Size = New Size(50, 31)
        txt_qtdd.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Thistle
        Label1.Font = New Font("Kristen ITC", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(227, 250)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 18)
        Label1.TabIndex = 18
        Label1.Text = "Indique a quantidade"
        ' 
        ' lbl_troco
        ' 
        lbl_troco.AutoSize = True
        lbl_troco.BackColor = Color.Gainsboro
        lbl_troco.Font = New Font("Kristen ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_troco.Location = New Point(530, 417)
        lbl_troco.Name = "lbl_troco"
        lbl_troco.Size = New Size(65, 24)
        lbl_troco.TabIndex = 23
        lbl_troco.Text = "Troco"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Curlz MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(208, 723)
        Label3.Name = "Label3"
        Label3.Size = New Size(243, 49)
        Label3.TabIndex = 24
        Label3.Text = "Juá Restaurant"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Gainsboro
        Label5.Font = New Font("Jokerman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.DarkMagenta
        Label5.Location = New Point(66, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(255, 29)
        Label5.TabIndex = 26
        Label5.Text = "Faça seu pedido AQUI:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Gainsboro
        Label4.Font = New Font("Jokerman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.DarkMagenta
        Label4.Location = New Point(64, 437)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 29)
        Label4.TabIndex = 27
        Label4.Text = "Menu do Dia"
        ' 
        ' cmd_add_pedido
        ' 
        cmd_add_pedido.BackColor = Color.DarkMagenta
        cmd_add_pedido.Font = New Font("Jokerman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        cmd_add_pedido.ForeColor = Color.Orange
        cmd_add_pedido.Location = New Point(453, 239)
        cmd_add_pedido.Name = "cmd_add_pedido"
        cmd_add_pedido.Size = New Size(145, 42)
        cmd_add_pedido.TabIndex = 28
        cmd_add_pedido.Text = "Add ao Pedido"
        cmd_add_pedido.UseVisualStyleBackColor = False
        ' 
        ' cmd_pago
        ' 
        cmd_pago.BackColor = Color.Orange
        cmd_pago.Font = New Font("Jokerman", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        cmd_pago.ForeColor = Color.DarkMagenta
        cmd_pago.Location = New Point(476, 348)
        cmd_pago.Name = "cmd_pago"
        cmd_pago.Size = New Size(116, 50)
        cmd_pago.TabIndex = 30
        cmd_pago.Text = "Pago (€)"
        cmd_pago.UseVisualStyleBackColor = False
        ' 
        ' txt_pago
        ' 
        txt_pago.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txt_pago.Location = New Point(423, 365)
        txt_pago.Name = "txt_pago"
        txt_pago.Size = New Size(50, 31)
        txt_pago.TabIndex = 29
        ' 
        ' lbl_verficaNum_qtdd
        ' 
        lbl_verficaNum_qtdd.AutoSize = True
        lbl_verficaNum_qtdd.BackColor = Color.Transparent
        lbl_verficaNum_qtdd.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_verficaNum_qtdd.ForeColor = SystemColors.ButtonHighlight
        lbl_verficaNum_qtdd.Location = New Point(319, 276)
        lbl_verficaNum_qtdd.Name = "lbl_verficaNum_qtdd"
        lbl_verficaNum_qtdd.Size = New Size(23, 17)
        lbl_verficaNum_qtdd.TabIndex = 31
        lbl_verficaNum_qtdd.Text = "***"
        ' 
        ' lbl_verficaNum_pago
        ' 
        lbl_verficaNum_pago.AutoSize = True
        lbl_verficaNum_pago.BackColor = Color.Transparent
        lbl_verficaNum_pago.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_verficaNum_pago.ForeColor = SystemColors.ButtonHighlight
        lbl_verficaNum_pago.Location = New Point(394, 399)
        lbl_verficaNum_pago.Name = "lbl_verficaNum_pago"
        lbl_verficaNum_pago.Size = New Size(23, 17)
        lbl_verficaNum_pago.TabIndex = 32
        lbl_verficaNum_pago.Text = "***"
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Location = New Point(504, 292)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(50, 20)
        lbl_total.TabIndex = 34
        lbl_total.Text = "TOTAL"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(83, 303)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(222, 104)
        ListBox1.TabIndex = 35
        ' 
        ' lbl_media
        ' 
        lbl_media.AutoSize = True
        lbl_media.Location = New Point(348, 321)
        lbl_media.Name = "lbl_media"
        lbl_media.Size = New Size(51, 20)
        lbl_media.TabIndex = 36
        lbl_media.Text = "Média"
        ' 
        ' lbl_mais_caros
        ' 
        lbl_mais_caros.AutoSize = True
        lbl_mais_caros.Location = New Point(227, 437)
        lbl_mais_caros.Name = "lbl_mais_caros"
        lbl_mais_caros.Size = New Size(58, 20)
        lbl_mais_caros.TabIndex = 37
        lbl_mais_caros.Text = "+ caros"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(677, 934)
        Controls.Add(lbl_mais_caros)
        Controls.Add(lbl_media)
        Controls.Add(ListBox1)
        Controls.Add(lbl_total)
        Controls.Add(lbl_verficaNum_pago)
        Controls.Add(lbl_verficaNum_qtdd)
        Controls.Add(cmd_pago)
        Controls.Add(txt_pago)
        Controls.Add(cmd_add_pedido)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(lbl_troco)
        Controls.Add(Label1)
        Controls.Add(txt_qtdd)
        Controls.Add(cmd_toForm2)
        Controls.Add(lbl_valor)
        Controls.Add(lbValor)
        Controls.Add(img_pizza)
        Controls.Add(img_sushi)
        Controls.Add(img_buracoHot)
        Controls.Add(img_bobo)
        Controls.Add(img_cozidopt)
        Controls.Add(img_pastel)
        Controls.Add(img_feijoada)
        Controls.Add(cmb_opcoesMenu)
        Controls.Add(lbMenuDia)
        Controls.Add(lbMenu)
        Controls.Add(cmd_sair)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Restaurante Juá"
        CType(img_feijoada, ComponentModel.ISupportInitialize).EndInit()
        CType(img_pastel, ComponentModel.ISupportInitialize).EndInit()
        CType(img_cozidopt, ComponentModel.ISupportInitialize).EndInit()
        CType(img_bobo, ComponentModel.ISupportInitialize).EndInit()
        CType(img_buracoHot, ComponentModel.ISupportInitialize).EndInit()
        CType(img_sushi, ComponentModel.ISupportInitialize).EndInit()
        CType(img_pizza, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_sair As Button
    Friend WithEvents lbMenu As Label
    Friend WithEvents lbMenuDia As Label
    Friend WithEvents cmb_opcoesMenu As ComboBox
    Friend WithEvents img_feijoada As PictureBox
    Friend WithEvents img_pastel As PictureBox
    Friend WithEvents img_cozidopt As PictureBox
    Friend WithEvents img_bobo As PictureBox
    Friend WithEvents img_buracoHot As PictureBox
    Friend WithEvents img_sushi As PictureBox
    Friend WithEvents img_pizza As PictureBox
    Friend WithEvents lbValor As Label
    Friend WithEvents lbl_valor As Label
    Friend WithEvents lbl_pedido As Label
    Friend WithEvents cmd_toForm2 As Button
    Friend WithEvents txt_qtdd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_troco As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_add_pedido As Button
    Friend WithEvents cmd_pago As Button
    Friend WithEvents txt_pago As TextBox
    Friend WithEvents lbl_verficaNum_qtdd As Label
    Friend WithEvents lbl_verficaNum_pago As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lbl_media As Label
    Friend WithEvents lbl_mais_caros As Label
End Class
