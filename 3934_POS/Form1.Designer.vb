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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        gb_cafetaria = New GroupBox()
        pic_pingado = New PictureBox()
        pic_garoto = New PictureBox()
        pic_galao = New PictureBox()
        pic_descafeinado = New PictureBox()
        pic_meia_leite = New PictureBox()
        pic_cafe = New PictureBox()
        gb_pastelaria = New GroupBox()
        pic_mista = New PictureBox()
        pic_torrada = New PictureBox()
        pic_sandes = New PictureBox()
        pic_salgados = New PictureBox()
        pic_doces = New PictureBox()
        gb_bebidas = New GroupBox()
        pic_naturais = New PictureBox()
        pic_sem_gas = New PictureBox()
        pic_com_gas = New PictureBox()
        pic_agua = New PictureBox()
        pic_preview = New PictureBox()
        lst_descricao = New ListBox()
        lst_qtd = New ListBox()
        lst_prec = New ListBox()
        lst_total = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbl_pedido = New Label()
        btn_novo = New Button()
        btn_remover = New Button()
        btn_mais = New Button()
        btn_menos = New Button()
        btn_pagamento = New Button()
        btn_imprimir = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txt_total = New TextBox()
        txt_numerario = New TextBox()
        txt_troco = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        gb_cafetaria.SuspendLayout()
        CType(pic_pingado, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_garoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_galao, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_descafeinado, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_meia_leite, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_cafe, ComponentModel.ISupportInitialize).BeginInit()
        gb_pastelaria.SuspendLayout()
        CType(pic_mista, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_torrada, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_sandes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_salgados, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_doces, ComponentModel.ISupportInitialize).BeginInit()
        gb_bebidas.SuspendLayout()
        CType(pic_naturais, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_sem_gas, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_com_gas, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_agua, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_preview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gb_cafetaria
        ' 
        gb_cafetaria.Controls.Add(pic_pingado)
        gb_cafetaria.Controls.Add(pic_garoto)
        gb_cafetaria.Controls.Add(pic_galao)
        gb_cafetaria.Controls.Add(pic_descafeinado)
        gb_cafetaria.Controls.Add(pic_meia_leite)
        gb_cafetaria.Controls.Add(pic_cafe)
        gb_cafetaria.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gb_cafetaria.ForeColor = Color.Green
        gb_cafetaria.Location = New Point(23, 24)
        gb_cafetaria.Name = "gb_cafetaria"
        gb_cafetaria.Size = New Size(655, 377)
        gb_cafetaria.TabIndex = 0
        gb_cafetaria.TabStop = False
        gb_cafetaria.Text = "Cafetaria"
        ' 
        ' pic_pingado
        ' 
        pic_pingado.Image = CType(resources.GetObject("pic_pingado.Image"), Image)
        pic_pingado.Location = New Point(439, 206)
        pic_pingado.Name = "pic_pingado"
        pic_pingado.Size = New Size(197, 146)
        pic_pingado.SizeMode = PictureBoxSizeMode.StretchImage
        pic_pingado.TabIndex = 5
        pic_pingado.TabStop = False
        ' 
        ' pic_garoto
        ' 
        pic_garoto.Image = CType(resources.GetObject("pic_garoto.Image"), Image)
        pic_garoto.Location = New Point(236, 206)
        pic_garoto.Name = "pic_garoto"
        pic_garoto.Size = New Size(197, 146)
        pic_garoto.SizeMode = PictureBoxSizeMode.StretchImage
        pic_garoto.TabIndex = 4
        pic_garoto.TabStop = False
        ' 
        ' pic_galao
        ' 
        pic_galao.Image = CType(resources.GetObject("pic_galao.Image"), Image)
        pic_galao.Location = New Point(21, 206)
        pic_galao.Name = "pic_galao"
        pic_galao.Size = New Size(197, 146)
        pic_galao.SizeMode = PictureBoxSizeMode.StretchImage
        pic_galao.TabIndex = 3
        pic_galao.TabStop = False
        ' 
        ' pic_descafeinado
        ' 
        pic_descafeinado.Image = CType(resources.GetObject("pic_descafeinado.Image"), Image)
        pic_descafeinado.Location = New Point(439, 30)
        pic_descafeinado.Name = "pic_descafeinado"
        pic_descafeinado.Size = New Size(197, 146)
        pic_descafeinado.SizeMode = PictureBoxSizeMode.StretchImage
        pic_descafeinado.TabIndex = 2
        pic_descafeinado.TabStop = False
        ' 
        ' pic_meia_leite
        ' 
        pic_meia_leite.Image = CType(resources.GetObject("pic_meia_leite.Image"), Image)
        pic_meia_leite.Location = New Point(236, 30)
        pic_meia_leite.Name = "pic_meia_leite"
        pic_meia_leite.Size = New Size(197, 146)
        pic_meia_leite.SizeMode = PictureBoxSizeMode.StretchImage
        pic_meia_leite.TabIndex = 1
        pic_meia_leite.TabStop = False
        ' 
        ' pic_cafe
        ' 
        pic_cafe.Image = CType(resources.GetObject("pic_cafe.Image"), Image)
        pic_cafe.Location = New Point(21, 30)
        pic_cafe.Name = "pic_cafe"
        pic_cafe.Size = New Size(197, 146)
        pic_cafe.SizeMode = PictureBoxSizeMode.StretchImage
        pic_cafe.TabIndex = 0
        pic_cafe.TabStop = False
        ' 
        ' gb_pastelaria
        ' 
        gb_pastelaria.Controls.Add(pic_mista)
        gb_pastelaria.Controls.Add(pic_torrada)
        gb_pastelaria.Controls.Add(pic_sandes)
        gb_pastelaria.Controls.Add(pic_salgados)
        gb_pastelaria.Controls.Add(pic_doces)
        gb_pastelaria.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gb_pastelaria.ForeColor = Color.Green
        gb_pastelaria.Location = New Point(23, 407)
        gb_pastelaria.Name = "gb_pastelaria"
        gb_pastelaria.Size = New Size(655, 377)
        gb_pastelaria.TabIndex = 1
        gb_pastelaria.TabStop = False
        gb_pastelaria.Text = "Pastelaria"
        ' 
        ' pic_mista
        ' 
        pic_mista.Image = CType(resources.GetObject("pic_mista.Image"), Image)
        pic_mista.Location = New Point(236, 206)
        pic_mista.Name = "pic_mista"
        pic_mista.Size = New Size(197, 146)
        pic_mista.SizeMode = PictureBoxSizeMode.StretchImage
        pic_mista.TabIndex = 4
        pic_mista.TabStop = False
        ' 
        ' pic_torrada
        ' 
        pic_torrada.Image = CType(resources.GetObject("pic_torrada.Image"), Image)
        pic_torrada.Location = New Point(21, 206)
        pic_torrada.Name = "pic_torrada"
        pic_torrada.Size = New Size(197, 146)
        pic_torrada.SizeMode = PictureBoxSizeMode.StretchImage
        pic_torrada.TabIndex = 3
        pic_torrada.TabStop = False
        ' 
        ' pic_sandes
        ' 
        pic_sandes.Image = CType(resources.GetObject("pic_sandes.Image"), Image)
        pic_sandes.Location = New Point(439, 30)
        pic_sandes.Name = "pic_sandes"
        pic_sandes.Size = New Size(197, 146)
        pic_sandes.SizeMode = PictureBoxSizeMode.StretchImage
        pic_sandes.TabIndex = 2
        pic_sandes.TabStop = False
        ' 
        ' pic_salgados
        ' 
        pic_salgados.Image = CType(resources.GetObject("pic_salgados.Image"), Image)
        pic_salgados.Location = New Point(236, 30)
        pic_salgados.Name = "pic_salgados"
        pic_salgados.Size = New Size(197, 146)
        pic_salgados.SizeMode = PictureBoxSizeMode.StretchImage
        pic_salgados.TabIndex = 1
        pic_salgados.TabStop = False
        ' 
        ' pic_doces
        ' 
        pic_doces.Image = CType(resources.GetObject("pic_doces.Image"), Image)
        pic_doces.Location = New Point(21, 30)
        pic_doces.Name = "pic_doces"
        pic_doces.Size = New Size(197, 146)
        pic_doces.SizeMode = PictureBoxSizeMode.StretchImage
        pic_doces.TabIndex = 0
        pic_doces.TabStop = False
        ' 
        ' gb_bebidas
        ' 
        gb_bebidas.Controls.Add(pic_naturais)
        gb_bebidas.Controls.Add(pic_sem_gas)
        gb_bebidas.Controls.Add(pic_com_gas)
        gb_bebidas.Controls.Add(pic_agua)
        gb_bebidas.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gb_bebidas.ForeColor = Color.Green
        gb_bebidas.Location = New Point(23, 808)
        gb_bebidas.Name = "gb_bebidas"
        gb_bebidas.Size = New Size(655, 377)
        gb_bebidas.TabIndex = 2
        gb_bebidas.TabStop = False
        gb_bebidas.Text = "Bebidas"
        ' 
        ' pic_naturais
        ' 
        pic_naturais.Image = CType(resources.GetObject("pic_naturais.Image"), Image)
        pic_naturais.Location = New Point(439, 30)
        pic_naturais.Name = "pic_naturais"
        pic_naturais.Size = New Size(197, 146)
        pic_naturais.SizeMode = PictureBoxSizeMode.StretchImage
        pic_naturais.TabIndex = 1
        pic_naturais.TabStop = False
        ' 
        ' pic_sem_gas
        ' 
        pic_sem_gas.Image = CType(resources.GetObject("pic_sem_gas.Image"), Image)
        pic_sem_gas.Location = New Point(236, 30)
        pic_sem_gas.Name = "pic_sem_gas"
        pic_sem_gas.Size = New Size(197, 146)
        pic_sem_gas.SizeMode = PictureBoxSizeMode.StretchImage
        pic_sem_gas.TabIndex = 1
        pic_sem_gas.TabStop = False
        ' 
        ' pic_com_gas
        ' 
        pic_com_gas.Image = CType(resources.GetObject("pic_com_gas.Image"), Image)
        pic_com_gas.Location = New Point(33, 201)
        pic_com_gas.Name = "pic_com_gas"
        pic_com_gas.Size = New Size(197, 146)
        pic_com_gas.SizeMode = PictureBoxSizeMode.StretchImage
        pic_com_gas.TabIndex = 0
        pic_com_gas.TabStop = False
        ' 
        ' pic_agua
        ' 
        pic_agua.Image = CType(resources.GetObject("pic_agua.Image"), Image)
        pic_agua.Location = New Point(33, 30)
        pic_agua.Name = "pic_agua"
        pic_agua.Size = New Size(197, 146)
        pic_agua.SizeMode = PictureBoxSizeMode.StretchImage
        pic_agua.TabIndex = 0
        pic_agua.TabStop = False
        ' 
        ' pic_preview
        ' 
        pic_preview.Location = New Point(696, 32)
        pic_preview.Name = "pic_preview"
        pic_preview.Size = New Size(455, 369)
        pic_preview.SizeMode = PictureBoxSizeMode.StretchImage
        pic_preview.TabIndex = 3
        pic_preview.TabStop = False
        ' 
        ' lst_descricao
        ' 
        lst_descricao.FormattingEnabled = True
        lst_descricao.ItemHeight = 25
        lst_descricao.Location = New Point(1181, 81)
        lst_descricao.Name = "lst_descricao"
        lst_descricao.Size = New Size(200, 779)
        lst_descricao.TabIndex = 4
        ' 
        ' lst_qtd
        ' 
        lst_qtd.FormattingEnabled = True
        lst_qtd.ItemHeight = 25
        lst_qtd.Location = New Point(1387, 81)
        lst_qtd.Name = "lst_qtd"
        lst_qtd.RightToLeft = RightToLeft.No
        lst_qtd.Size = New Size(86, 779)
        lst_qtd.TabIndex = 5
        ' 
        ' lst_prec
        ' 
        lst_prec.FormattingEnabled = True
        lst_prec.ItemHeight = 25
        lst_prec.Location = New Point(1479, 81)
        lst_prec.Name = "lst_prec"
        lst_prec.RightToLeft = RightToLeft.Yes
        lst_prec.Size = New Size(86, 779)
        lst_prec.TabIndex = 6
        ' 
        ' lst_total
        ' 
        lst_total.FormattingEnabled = True
        lst_total.ItemHeight = 25
        lst_total.Location = New Point(1571, 81)
        lst_total.Name = "lst_total"
        lst_total.RightToLeft = RightToLeft.Yes
        lst_total.Size = New Size(86, 779)
        lst_total.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1186, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 8
        Label1.Text = "Descrição"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1487, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 9
        Label2.Text = "Preço"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1387, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 25)
        Label3.TabIndex = 10
        Label3.Text = "Qtd."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1586, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 25)
        Label4.TabIndex = 11
        Label4.Text = "Total"
        ' 
        ' lbl_pedido
        ' 
        lbl_pedido.BorderStyle = BorderStyle.FixedSingle
        lbl_pedido.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_pedido.Location = New Point(1186, 10)
        lbl_pedido.Name = "lbl_pedido"
        lbl_pedido.Size = New Size(471, 43)
        lbl_pedido.TabIndex = 12
        lbl_pedido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_novo
        ' 
        btn_novo.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_novo.Location = New Point(690, 437)
        btn_novo.Name = "btn_novo"
        btn_novo.Size = New Size(461, 94)
        btn_novo.TabIndex = 13
        btn_novo.Text = "Novo Pedido"
        btn_novo.UseVisualStyleBackColor = True
        ' 
        ' btn_remover
        ' 
        btn_remover.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_remover.Location = New Point(690, 564)
        btn_remover.Name = "btn_remover"
        btn_remover.Size = New Size(461, 94)
        btn_remover.TabIndex = 14
        btn_remover.Text = "Remover Artigo"
        btn_remover.UseVisualStyleBackColor = True
        ' 
        ' btn_mais
        ' 
        btn_mais.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_mais.Location = New Point(696, 677)
        btn_mais.Name = "btn_mais"
        btn_mais.Size = New Size(150, 94)
        btn_mais.TabIndex = 15
        btn_mais.Text = "+"
        btn_mais.UseVisualStyleBackColor = True
        ' 
        ' btn_menos
        ' 
        btn_menos.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_menos.Location = New Point(959, 677)
        btn_menos.Name = "btn_menos"
        btn_menos.Size = New Size(144, 94)
        btn_menos.TabIndex = 16
        btn_menos.Text = "-"
        btn_menos.UseVisualStyleBackColor = True
        ' 
        ' btn_pagamento
        ' 
        btn_pagamento.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_pagamento.Location = New Point(690, 838)
        btn_pagamento.Name = "btn_pagamento"
        btn_pagamento.Size = New Size(461, 94)
        btn_pagamento.TabIndex = 14
        btn_pagamento.Text = "Pagamento"
        btn_pagamento.UseVisualStyleBackColor = True
        ' 
        ' btn_imprimir
        ' 
        btn_imprimir.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_imprimir.Location = New Point(690, 970)
        btn_imprimir.Name = "btn_imprimir"
        btn_imprimir.Size = New Size(461, 94)
        btn_imprimir.TabIndex = 14
        btn_imprimir.Text = "Imprimir"
        btn_imprimir.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1221, 907)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 25)
        Label5.TabIndex = 8
        Label5.Text = "Total:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(1221, 963)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 25)
        Label6.TabIndex = 8
        Label6.Text = "Numerário:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(1221, 1009)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 25)
        Label7.TabIndex = 8
        Label7.Text = "Troco:"
        ' 
        ' txt_total
        ' 
        txt_total.Location = New Point(1345, 904)
        txt_total.Name = "txt_total"
        txt_total.ReadOnly = True
        txt_total.Size = New Size(233, 31)
        txt_total.TabIndex = 17
        txt_total.TextAlign = HorizontalAlignment.Right
        ' 
        ' txt_numerario
        ' 
        txt_numerario.Location = New Point(1345, 960)
        txt_numerario.Name = "txt_numerario"
        txt_numerario.ReadOnly = True
        txt_numerario.Size = New Size(233, 31)
        txt_numerario.TabIndex = 17
        txt_numerario.TextAlign = HorizontalAlignment.Right
        ' 
        ' txt_troco
        ' 
        txt_troco.Location = New Point(1345, 1006)
        txt_troco.Name = "txt_troco"
        txt_troco.ReadOnly = True
        txt_troco.Size = New Size(233, 31)
        txt_troco.TabIndex = 17
        txt_troco.TextAlign = HorizontalAlignment.Right
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1704, 1050)
        Controls.Add(txt_troco)
        Controls.Add(txt_numerario)
        Controls.Add(txt_total)
        Controls.Add(btn_menos)
        Controls.Add(btn_mais)
        Controls.Add(btn_imprimir)
        Controls.Add(btn_pagamento)
        Controls.Add(btn_remover)
        Controls.Add(btn_novo)
        Controls.Add(lbl_pedido)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(lst_total)
        Controls.Add(lst_prec)
        Controls.Add(lst_qtd)
        Controls.Add(lst_descricao)
        Controls.Add(pic_preview)
        Controls.Add(gb_bebidas)
        Controls.Add(gb_pastelaria)
        Controls.Add(gb_cafetaria)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS"
        gb_cafetaria.ResumeLayout(False)
        CType(pic_pingado, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_garoto, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_galao, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_descafeinado, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_meia_leite, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_cafe, ComponentModel.ISupportInitialize).EndInit()
        gb_pastelaria.ResumeLayout(False)
        CType(pic_mista, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_torrada, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_sandes, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_salgados, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_doces, ComponentModel.ISupportInitialize).EndInit()
        gb_bebidas.ResumeLayout(False)
        CType(pic_naturais, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_sem_gas, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_com_gas, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_agua, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_preview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gb_cafetaria As GroupBox
    Friend WithEvents pic_pingado As PictureBox
    Friend WithEvents pic_garoto As PictureBox
    Friend WithEvents pic_galao As PictureBox
    Friend WithEvents pic_descafeinado As PictureBox
    Friend WithEvents pic_meia_leite As PictureBox
    Friend WithEvents pic_cafe As PictureBox
    Friend WithEvents gb_pastelaria As GroupBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents pic_mista As PictureBox
    Friend WithEvents pic_torrada As PictureBox
    Friend WithEvents pic_sandes As PictureBox
    Friend WithEvents pic_salgados As PictureBox
    Friend WithEvents pic_doces As PictureBox
    Friend WithEvents gb_bebidas As GroupBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents pic_agua As PictureBox
    Friend WithEvents pic_preview As PictureBox
    Friend WithEvents lst_descricao As ListBox
    Friend WithEvents lst_qtd As ListBox
    Friend WithEvents lst_prec As ListBox
    Friend WithEvents lst_total As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_pedido As Label
    Friend WithEvents btn_novo As Button
    Friend WithEvents btn_remover As Button
    Friend WithEvents btn_mais As Button
    Friend WithEvents btn_menos As Button
    Friend WithEvents btn_pagamento As Button
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_numerario As TextBox
    Friend WithEvents txt_troco As TextBox
    Friend WithEvents pic_naturais As PictureBox
    Friend WithEvents pic_sem_gas As PictureBox
    Friend WithEvents pic_com_gas As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
