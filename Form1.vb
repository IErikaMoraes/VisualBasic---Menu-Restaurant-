Imports System.Diagnostics.CodeAnalysis
Imports System.Windows.Markup

Public Class Form1

    Dim total_pedido As Integer
    Dim media_pedido As Double
    Dim cont_pedido As Double = 0
    Dim preco_do_prato As Integer
    Dim max(2) As Integer

    Sub diaSemana()
        cmb_opcoesMenu.Items.Add("Feijoada Brasileira")
        cmb_opcoesMenu.Items.Add("Pastel Brasileiro")
        cmb_opcoesMenu.Items.Add("Cozido à Portuguesa")
        cmb_opcoesMenu.Items.Add("Bobó de camarão")
        cmb_opcoesMenu.Items.Add("Buraco Quente")
        cmb_opcoesMenu.Items.Add("Sushi")
        cmb_opcoesMenu.Items.Add("Pizza à Brasileira")
    End Sub


    Sub verificaDia()
        If cmb_opcoesMenu.SelectedItem = "Feijoada Brasileira" Then
            lbMenu.Text = "cozido a base de feijão" & vbCrLf & "preto, cortes de carnes" & vbCrLf & "variadas de porco, acompanha:" & vbCrLf & "torresmo, couve reforgada," & vbCrLf & "banana frita, farofa."
            img_feijoada.Visible = True
            img_pastel.Visible = False
            img_cozidopt.Visible = False
            img_bobo.Visible = False
            img_buracoHot.Visible = False
            img_sushi.Visible = False
            img_pizza.Visible = False
            lbl_valor.Text = "30€ - Alto (ref: prato abaixo de 20€)"
        End If

        If cmb_opcoesMenu.SelectedItem = "Pastel Brasileiro" Then
            lbMenu.Text = "massa fina e seca," & vbCrLf & "frita na hora." & vbCrLf & "Sabor: BRASIL."
            img_feijoada.Visible = False
            img_pastel.Visible = True
            img_cozidopt.Visible = False
            img_bobo.Visible = False
            img_buracoHot.Visible = False
            img_sushi.Visible = False
            img_pizza.Visible = False
            lbl_valor.Text = "8€ - Baixo (ref: prato abaixo de 15€)"
        End If

        If cmb_opcoesMenu.SelectedItem = "Cozido à Portuguesa" Then
            lbMenu.Text = "cozido de carnes variadas," & vbCrLf & "como: carne de porco, " & vbCrLf & "vitela, frango e enchidos," & vbCrLf & "cozinhados com legumes," & vbCrLf & "como batatas, cenouras" & vbCrLf & "e repolho."
            img_feijoada.Visible = False
            img_pastel.Visible = False
            img_cozidopt.Visible = True
            img_bobo.Visible = False
            img_buracoHot.Visible = False
            img_sushi.Visible = False
            img_pizza.Visible = False
            lbl_valor.Text = "15€ - Médio (ref: prato abaixo de 15€)"
        End If

        If cmb_opcoesMenu.SelectedItem = "Bobó de camarão" Then
            lbMenu.Text = "cozido de frutos do mar" & vbCrLf & "à base de leite de coco" & vbCrLf & "e óleo de dendê."
            img_feijoada.Visible = False
            img_pastel.Visible = False
            img_cozidopt.Visible = False
            img_bobo.Visible = True
            img_buracoHot.Visible = False
            img_sushi.Visible = False
            img_pizza.Visible = False
            lbl_valor.Text = "18€ - Médio (ref: prato abaixo de 15€)"
        End If

        If cmb_opcoesMenu.SelectedItem = "Buraco Quente" Then
            lbMenu.Text = "carne picada com molho" & vbCrLf & "de tomate, muitas ervas," & vbCrLf & "em pão crocante, maionese," & vbCrLf & "picante e pimentos verdes."
            img_feijoada.Visible = False
            img_pastel.Visible = False
            img_cozidopt.Visible = False
            img_bobo.Visible = False
            img_buracoHot.Visible = True
            img_sushi.Visible = False
            img_pizza.Visible = False
            lbl_valor.Text = "6€ - Baixo (ref: prato abaixo de 15€)"
        End If

        If cmb_opcoesMenu.SelectedItem = "Sushi" Then
            lbMenu.Text = "os melhores cortes e" & vbCrLf & "mais frescos materiais," & vbCrLf & "as peças mais delicadas " & vbCrLf & "e saborosas."
            img_feijoada.Visible = False
            img_pastel.Visible = False
            img_cozidopt.Visible = False
            img_bobo.Visible = False
            img_buracoHot.Visible = False
            img_sushi.Visible = True
            img_pizza.Visible = False
            lbl_valor.Text = "25€ - Médio (ref: prato abaixo de 15€)"
        End If

        If cmb_opcoesMenu.SelectedItem = "Pizza à Brasileira" Then
            lbMenu.Text = "sabores clássicos:" & vbCrLf & " *Frango com Catupiry," & vbCrLf & " *Calabresa Acebolada," & vbCrLf & " *Portuguesa," & vbCrLf & " *Chocolate preto e Morango."
            img_feijoada.Visible = False
            img_pastel.Visible = False
            img_cozidopt.Visible = False
            img_bobo.Visible = False
            img_buracoHot.Visible = False
            img_sushi.Visible = False
            img_pizza.Visible = True
            lbl_valor.Text = "33€ - Alto (ref: prato abaixo de 15€)"
        End If

    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        diaSemana()
        MessageBox.Show("RESTAURANTE JUÁ, Bem vindo(a)!", "pt.net",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmb_opcoesMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_opcoesMenu.SelectedIndexChanged
        verificaDia()
    End Sub

    Private Sub txt_qtdd_TextChanged(sender As Object, e As EventArgs) Handles txt_qtdd.TextChanged


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_add_pedido.Click
        Dim n As Integer
        n = Val(txt_qtdd.Text)

        Dim N_txt As String
        Dim n1 As Long

        N_txt = Me.txt_qtdd.Text

        If IsNumeric(N_txt) Then
            MessageBox.Show("Quantidade de pratos digitada", "Valida campo prato")
            n1 = Val(N_txt)

            cont_pedido = cont_pedido + Val(txt_qtdd.Text)

            If cmb_opcoesMenu.SelectedItem = "Feijoada Brasileira" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 30) & "€")
                total_pedido = total_pedido + (30 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 30

            ElseIf cmb_opcoesMenu.SelectedItem = "Pastel Brasileiro" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 8) & "€")
                total_pedido = total_pedido + (8 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 8

            ElseIf cmb_opcoesMenu.SelectedItem = "Cozido à Portuguesa" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 15) & "€")
                total_pedido = total_pedido + (15 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 15

            ElseIf cmb_opcoesMenu.SelectedItem = "Bobó de camarão" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 18) & "€")
                total_pedido = total_pedido + (18 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 18

            ElseIf cmb_opcoesMenu.SelectedItem = "Buraco Quente" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 6) & "€")
                total_pedido = total_pedido + (6 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 6

            ElseIf cmb_opcoesMenu.SelectedItem = "Sushi" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 25) & "€")
                total_pedido = total_pedido + (25 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 25

            ElseIf cmb_opcoesMenu.SelectedItem = "Pizza à Brasileira" Then
                ListBox1.Items.Add(cmb_opcoesMenu.SelectedItem & " - " & txt_qtdd.Text & "x" & " - " & (Val(txt_qtdd.Text) * 33) & "€")
                total_pedido = total_pedido + (33 * Val(txt_qtdd.Text))
                lbl_total.Text = total_pedido & "€"
                preco_do_prato = 33
            End If

            Dim preco As Integer = preco_do_prato

            If preco > max(0) Then
                max(2) = max(1)
                max(1) = max(0)
                max(0) = preco
            ElseIf preco > max(1) Then
                max(2) = max(1)
                max(1) = preco
            ElseIf preco > max(2) Then
                max(2) = preco
            End If

            txt_qtdd.Clear()
            txt_qtdd.Focus()

        ElseIf N_txt = "" Then

        ElseIf MessageBox.Show("Digite um valor numérico pf, Atenção!") Then
            txt_qtdd.Focus()
            txt_qtdd.Clear()
        End If

    End Sub

    Private Sub cmd_pago_Click(sender As Object, e As EventArgs) Handles cmd_pago.Click
        Dim troco As Integer
        Dim pago As Integer = Val(txt_pago.Text)
        Dim total As Integer = Val(lbl_total.Text)

        troco = pago - total
        lbl_troco.Text = troco & "€"

        If pago < total Then
            MessageBox.Show("Valor insuficiente", "vb.net")
            txt_pago.Clear()
            txt_pago.Focus()
            lbl_troco.Text = ""
        End If

        If troco >= 0 Then
            lbl_troco.Text = troco & "€ à devolver"
            lbl_media.Text = "O valor médio dos pratos é de " & (total_pedido / cont_pedido).ToString("F2") & "€."
            lbl_mais_caros.Text = "os 3 mais caros são: " & max(0) & ", " & max(1) & ", " & max(2) & "."
        End If
    End Sub

    Private Sub cmd_toForm2_Click(sender As Object, e As EventArgs) Handles cmd_toForm2.Click
        ListBox1.Items.Clear()
        lbl_total.Text = ""
        lbl_media.Text = ""
        lbl_troco.Text = ""
        lbl_mais_caros.Text = ""
        total_pedido = 0
        cont_pedido = 0
        media_pedido = 0
        max(0) = 0
        max(1) = 0
        max(2) = 0
        txt_pago.Text = 0
    End Sub
End Class
