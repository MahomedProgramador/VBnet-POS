Imports Microsoft.Data.SqlClient

Public Class Form1
    Dim Total As Double
    Dim ligacao As New SqlConnection
    Dim comando As New SqlCommand

    Sub Desabilitar()
        gb_cafetaria.Enabled = False
        gb_pastelaria.Enabled = False
        gb_bebidas.Enabled = False
        btn_remover.Enabled = False
        btn_mais.Enabled = False
        btn_menos.Enabled = False
        btn_pagamento.Enabled = False
        btn_imprimir.Enabled = False
        btn_novo.Enabled = True
        lbl_pedido.ResetText()
        lst_descricao.Items.Clear()
        lst_qtd.Items.Clear()
        lst_prec.Items.Clear()
        lst_total.Items.Clear()
        pic_preview.Image = Nothing
        Total = 0
        txt_total.ResetText()
        txt_numerario.ResetText()
        txt_troco.ResetText()
    End Sub

    Sub DesabilitarNew()
        gb_cafetaria.Enabled = False
        gb_pastelaria.Enabled = False
        gb_bebidas.Enabled = False
        btn_remover.Enabled = False
        btn_mais.Enabled = False
        btn_menos.Enabled = False
        btn_pagamento.Enabled = False
        btn_imprimir.Enabled = False
        btn_novo.Enabled = True
        pic_preview.Image = Nothing
    End Sub

    Sub Habilitar()
        gb_cafetaria.Enabled = True
        gb_pastelaria.Enabled = True
        gb_bebidas.Enabled = True

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ligacao.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" &
           System.AppDomain.CurrentDomain.BaseDirectory &
           "db_pos.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            ligacao.Open()
        Catch ex As Exception
            MsgBox("Erro")
        End Try

        Desabilitar()
    End Sub

    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        If (btn_novo.Text = "Novo Pedido") Then
            btn_novo.Text = "Cancelar"
            btn_novo.ForeColor = Color.Red
            lbl_pedido.Text = DateTime.Now.ToString("yyyyMMdd.hh.ss")

            Habilitar()
        Else
            btn_novo.Text = "Novo Pedido"
            btn_novo.ForeColor = Color.Green
            Desabilitar()
        End If
    End Sub



    Sub Adicionar_Produto(Imagem As PictureBox, Nome As String, Preco As Double)
        Dim Posicao, Qtd As Integer
        Dim TPreco As Double
        Posicao = lst_descricao.FindString(Nome)
        If (Posicao >= 0) Then
            lst_qtd.SetSelected(Posicao, True)
            Qtd = lst_qtd.Items.Item(Posicao) + 1
            TPreco = Qtd * Preco
            'Escrever a quantidade e preço nas listas
            lst_qtd.Items.Item(Posicao) = Qtd
            lst_total.Items.Item(Posicao) = FormatCurrency(TPreco)
            Total += Preco
            txt_total.Text = FormatCurrency(Total)
        Else
            lst_descricao.Items.Add(Nome)
            lst_qtd.Items.Add(1)
            lst_prec.Items.Add(FormatCurrency(Preco))
            lst_total.Items.Add(FormatCurrency(Preco))
            pic_preview.Image = Imagem.Image
            Total += Preco
            txt_total.Text = FormatCurrency(Total)
            btn_remover.Enabled = True
            btn_mais.Enabled = True
            btn_menos.Enabled = True
            btn_pagamento.Enabled = True
        End If
    End Sub
    Private Sub pic_cafe_Click(sender As Object, e As EventArgs) Handles pic_cafe.Click
        Adicionar_Produto(pic_cafe, "Café", 0.8)
    End Sub

    Private Sub lst_descricao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_descricao.SelectedIndexChanged
        lst_qtd.SelectedIndex = lst_descricao.SelectedIndex
        lst_prec.SelectedIndex = lst_descricao.SelectedIndex
        lst_total.SelectedIndex = lst_descricao.SelectedIndex
    End Sub

    Private Sub lst_qtd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_qtd.SelectedIndexChanged
        lst_descricao.SelectedIndex = lst_qtd.SelectedIndex
        lst_prec.SelectedIndex = lst_qtd.SelectedIndex
        lst_total.SelectedIndex = lst_qtd.SelectedIndex
    End Sub

    Private Sub lst_prec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_prec.SelectedIndexChanged
        lst_descricao.SelectedIndex = lst_prec.SelectedIndex
        lst_qtd.SelectedIndex = lst_prec.SelectedIndex
        lst_total.SelectedIndex = lst_prec.SelectedIndex
    End Sub

    Private Sub lst_total_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_total.SelectedIndexChanged
        lst_descricao.SelectedIndex = lst_total.SelectedIndex
        lst_qtd.SelectedIndex = lst_total.SelectedIndex
        lst_descricao.SelectedIndex = lst_total.SelectedIndex
    End Sub

    Private Sub pic_meia_leite_Click(sender As Object, e As EventArgs) Handles pic_meia_leite.Click
        Adicionar_Produto(pic_meia_leite, "Meia de leite", 1.5)
    End Sub

    Private Sub pic_descafeinado_Click(sender As Object, e As EventArgs) Handles pic_descafeinado.Click
        Adicionar_Produto(pic_descafeinado, "Descafeínado", 0.8)
    End Sub

    Private Sub pic_galao_Click(sender As Object, e As EventArgs) Handles pic_galao.Click
        Adicionar_Produto(pic_galao, "Galão", 1)
    End Sub

    Private Sub pic_garoto_Click(sender As Object, e As EventArgs) Handles pic_garoto.Click
        Adicionar_Produto(pic_garoto, "Garoto", 0.8)
    End Sub

    Private Sub pic_pingado_Click(sender As Object, e As EventArgs) Handles pic_pingado.Click
        Adicionar_Produto(pic_pingado, "Pingado", 0.8)
    End Sub

    Private Sub pic_doces_Click(sender As Object, e As EventArgs) Handles pic_doces.Click
        Adicionar_Produto(pic_doces, "Doces", 1.5)
    End Sub

    Private Sub pic_salgados_Click(sender As Object, e As EventArgs) Handles pic_salgados.Click
        Adicionar_Produto(pic_salgados, "Salgados", 1.5)
    End Sub

    Private Sub pic_sandes_Click(sender As Object, e As EventArgs) Handles pic_sandes.Click
        Adicionar_Produto(pic_sandes, "Sandes", 2)
    End Sub

    Private Sub pic_torrada_Click(sender As Object, e As EventArgs) Handles pic_torrada.Click
        Adicionar_Produto(pic_torrada, "Torrada", 1.8)
    End Sub

    Private Sub pic_mista_Click(sender As Object, e As EventArgs) Handles pic_mista.Click
        Adicionar_Produto(pic_mista, "Tosta", 1.5)
    End Sub

    Private Sub pic_agua_Click(sender As Object, e As EventArgs) Handles pic_agua.Click
        Adicionar_Produto(pic_agua, "Pingado", 1)
    End Sub

    Private Sub sem_gas_Click(sender As Object, e As EventArgs) Handles pic_sem_gas.Click
        Adicionar_Produto(pic_sem_gas, "Bebida sem gás", 1.5)
    End Sub

    Private Sub pic_naturais_Click(sender As Object, e As EventArgs) Handles pic_naturais.Click
        Adicionar_Produto(pic_naturais, "Sumo natural", 2.5)
    End Sub

    Private Sub pic_com_gas_Click(sender As Object, e As EventArgs) Handles pic_com_gas.Click
        Adicionar_Produto(pic_com_gas, "Bebida com gás", 1.5)
    End Sub

    Private Sub btn_mais_Click(sender As Object, e As EventArgs) Handles btn_mais.Click
        Dim Posicao, Qtd As Integer
        Dim Tpreco As Double
        Posicao = lst_qtd.SelectedIndex
        If (Posicao >= 0) Then
            Tpreco = lst_prec.Items.Item(Posicao)
            Qtd = lst_qtd.Items.Item(Posicao) + 1
            lst_qtd.Items.Item(Posicao) = Qtd
            lst_total.Items.Item(Posicao) = FormatCurrency(Qtd * Tpreco)
            Total += Tpreco
            txt_total.Text = FormatCurrency(Total)
        Else
            MsgBox("Não existem itens seleccionados.", MsgBoxStyle.Critical, "Atenção !!!")
        End If
    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        Dim Posicao, Qtd As Integer
        Dim Tpreco As Double
        Posicao = lst_qtd.SelectedIndex
        If (Posicao >= 0) Then
            Tpreco = lst_prec.Items.Item(Posicao)
            Qtd = lst_qtd.Items.Item(Posicao) - 1
            lst_qtd.Items.Item(Posicao) = Qtd
            lst_total.Items.Item(Posicao) = FormatCurrency(Qtd * Tpreco)
            Total -= Tpreco
            txt_total.Text = FormatCurrency(Total)
            If (Qtd = 0) Then
                lst_descricao.Items.RemoveAt(Posicao)
                lst_qtd.Items.RemoveAt(Posicao)
                lst_prec.Items.RemoveAt(Posicao)
                lst_total.Items.RemoveAt(Posicao)

            End If
            Limpa()
        Else
            MsgBox("Não existem itens seleccionados.", MsgBoxStyle.Critical, "Atenção !!!")

        End If
    End Sub

    Private Sub btn_remover_Click(sender As Object, e As EventArgs) Handles btn_remover.Click
        If (lst_descricao.SelectedIndex < 0) Then
            MsgBox("Não existem artigos seleccionados", MsgBoxStyle.Information, "Atenção !")
            Exit Sub
        End If

        Dim Posicao As Integer
        Dim Preco As Double
        Dim Resposta As String

        Posicao = lst_descricao.SelectedIndex
        Preco = lst_total.Items.Item(Posicao)

        Resposta = MsgBox("Confirma eliminar o artigo?",
                          MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar artigo")
        If (Resposta = vbYes) Then
            lst_descricao.Items.RemoveAt(Posicao)
            lst_qtd.Items.RemoveAt(Posicao)
            lst_prec.Items.RemoveAt(Posicao)
            lst_total.Items.RemoveAt(Posicao)
            Total -= Preco
            txt_total.Text = FormatCurrency(Total)
        End If
        Limpa()

    End Sub

    Sub Limpa()
        If (lst_descricao.Items.Count = 0) Then
            btn_remover.Enabled = False
            btn_mais.Enabled = False
            btn_menos.Enabled = False
            btn_pagamento.Enabled = False
            txt_total.ResetText()
        Else
            lst_descricao.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_pagamento_Click(sender As Object, e As EventArgs) Handles btn_pagamento.Click

        Dim Valor As String
        Do
            Valor = InputBox("Digite o valor entregue")
        Loop Until IsNumeric(Valor) AndAlso Val(Valor) > 0


        If (Valor < Total) Then
            MsgBox("Valor insuficiente", MsgBoxStyle.Critical, "Atenção !!")
            Exit Sub
        End If
        txt_numerario.Text = FormatCurrency(Valor)
        txt_troco.Text = FormatCurrency(Valor - Total)
        DesabilitarNew()
        btn_imprimir.Enabled = True
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Titulo As New Font("Verdana", 16, FontStyle.Bold)
        Dim Titulo1 As New Font("Verdana", 10, FontStyle.Regular)
        Dim Titulo2 As New Font("Verdana", 8, FontStyle.Regular)

        e.Graphics.DrawString("Café do Bairro, LDA.", Titulo, Brushes.Blue, 50, 50)
        e.Graphics.DrawString("Rua das pretas Nº 28", Titulo1, Brushes.Black, 50, 75)
        e.Graphics.DrawString("1150-020 Lisboa", Titulo1, Brushes.Blue, 50, 90)
        e.Graphics.DrawString("Email: cafedobairro@gmail.com", Titulo1, Brushes.Blue, 50, 105)
        ' criar o cabeçalho das colunas
        e.Graphics.DrawString("Descrição", Titulo2, Brushes.Black, 50, 130)
        e.Graphics.DrawString("Qtd.", Titulo2, Brushes.Black, 150, 130)
        e.Graphics.DrawString("Preço", Titulo2, Brushes.Black, 200, 130)
        e.Graphics.DrawString("Total", Titulo2, Brushes.Black, 250, 130)
        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, 145, 300, 145)

        Dim y As Integer = 160
        For i = 0 To lst_descricao.Items.Count - 1
            e.Graphics.DrawString(lst_descricao.Items(i), Titulo2, Brushes.Black, 50, y)
            e.Graphics.DrawString(lst_qtd.Items(i), Titulo2, Brushes.Black, 150, y)
            e.Graphics.DrawString(lst_prec.Items(i), Titulo2, Brushes.Black, 200, y)
            e.Graphics.DrawString(lst_total.Items(i), Titulo2, Brushes.Black, 250, y)
            y += 20
        Next
        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, y, 300, y)
        e.Graphics.DrawString("Total:" & txt_total.Text, Titulo2, Brushes.Black, 50, y + 20)
        e.Graphics.DrawString("Numerário:" & txt_numerario.Text, Titulo2, Brushes.Black, 50, y + 40)
        e.Graphics.DrawString("Troco:" & txt_troco.Text, Titulo2, Brushes.Black, 50, y + 60)

        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, y + 80, 300, y + 80)
        e.Graphics.DrawString("Obrigado, Volte sempre.:", Titulo2, Brushes.Black, 50, y + 100)


    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        PrintPreviewDialog1.ShowDialog()

        ' Registar os dados
        Try
            Dim sql As String
            sql = "INSERT INTO pedidos (pedido, total) VALUES (@p, @t)"
            comando = New SqlCommand(sql, ligacao)
            comando.Parameters.AddWithValue("@p", lbl_pedido.Text)
            comando.Parameters.AddWithValue("@t", Total)
            comando.ExecuteNonQuery()

            'Guardar o detalhe
            For i = 0 To lst_descricao.Items.Count - 1
                sql = "INSERT INTO detalhe (pedido, descricao, qtd, preco) VALUES (@p, @d, @q, @t)"
                comando = New SqlCommand(sql, ligacao)
                comando.Parameters.AddWithValue("@p", lbl_pedido.Text)
                comando.Parameters.AddWithValue("@d", lst_descricao.Items(i))
                comando.Parameters.AddWithValue("@q", lst_qtd.Items(i))
                comando.Parameters.AddWithValue("@t", CDbl(lst_prec.Items(i)))
                comando.ExecuteNonQuery()
            Next
            MsgBox("O pedido foi registado.", MsgBoxStyle.Information, "Guardar pedido")
            Desabilitar()
        Catch ex As Exception
            MsgBox("Erro ao registar o pedido.", MsgBoxStyle.Critical, "Guardar pedido")
        End Try

    End Sub
End Class
