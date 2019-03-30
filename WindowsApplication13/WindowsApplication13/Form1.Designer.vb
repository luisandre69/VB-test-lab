<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpdatapedido = New System.Windows.Forms.GroupBox
        Me.txtdatapedido = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grpdadoscliente = New System.Windows.Forms.GroupBox
        Me.btneliminar = New System.Windows.Forms.Button
        Me.txtcodcliente = New System.Windows.Forms.TextBox
        Me.chkdesconto = New System.Windows.Forms.CheckBox
        Me.txtencargos = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnsalvar = New System.Windows.Forms.Button
        Me.txtobservaçõescliente = New System.Windows.Forms.TextBox
        Me.txtlocalidade = New System.Windows.Forms.TextBox
        Me.txtsigla = New System.Windows.Forms.TextBox
        Me.txtpostal = New System.Windows.Forms.TextBox
        Me.txtmorada = New System.Windows.Forms.TextBox
        Me.txtapelido = New System.Windows.Forms.TextBox
        Me.txtnome = New System.Windows.Forms.TextBox
        Me.btnprocurarcliente = New System.Windows.Forms.Button
        Me.txttelefone = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.grptamanho = New System.Windows.Forms.GroupBox
        Me.txtgrande = New System.Windows.Forms.TextBox
        Me.txtmedia = New System.Windows.Forms.TextBox
        Me.txtpequena = New System.Windows.Forms.TextBox
        Me.rdbgrande = New System.Windows.Forms.RadioButton
        Me.rdbmedia = New System.Windows.Forms.RadioButton
        Me.rdbpequena = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpentrega = New System.Windows.Forms.GroupBox
        Me.txtborda = New System.Windows.Forms.TextBox
        Me.txtentregar = New System.Windows.Forms.TextBox
        Me.chkborda = New System.Windows.Forms.CheckBox
        Me.chkentregar = New System.Windows.Forms.CheckBox
        Me.grpingredientes = New System.Windows.Forms.GroupBox
        Me.txtanchovas = New System.Windows.Forms.TextBox
        Me.txtcamarao = New System.Windows.Forms.TextBox
        Me.txtpresunto = New System.Windows.Forms.TextBox
        Me.txtovo = New System.Windows.Forms.TextBox
        Me.txtcalabreza = New System.Windows.Forms.TextBox
        Me.txtpepperoni = New System.Windows.Forms.TextBox
        Me.txttomate = New System.Windows.Forms.TextBox
        Me.txtpimentao = New System.Windows.Forms.TextBox
        Me.txtcebola = New System.Windows.Forms.TextBox
        Me.txtazeitonas = New System.Windows.Forms.TextBox
        Me.txtcogumelos = New System.Windows.Forms.TextBox
        Me.txtqueijo = New System.Windows.Forms.TextBox
        Me.chkanchovas = New System.Windows.Forms.CheckBox
        Me.chkcamarao = New System.Windows.Forms.CheckBox
        Me.chkpresunto = New System.Windows.Forms.CheckBox
        Me.chkovo = New System.Windows.Forms.CheckBox
        Me.chkcababreza = New System.Windows.Forms.CheckBox
        Me.chkpepperoni = New System.Windows.Forms.CheckBox
        Me.chktomate = New System.Windows.Forms.CheckBox
        Me.chkpimentao = New System.Windows.Forms.CheckBox
        Me.chkcebola = New System.Windows.Forms.CheckBox
        Me.chkazeitonas = New System.Windows.Forms.CheckBox
        Me.chkcogumelos = New System.Windows.Forms.CheckBox
        Me.chkqueijo = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtobservacaoencomenda = New System.Windows.Forms.TextBox
        Me.btncriarpizza = New System.Windows.Forms.Button
        Me.btnencerrar = New System.Windows.Forms.Button
        Me.btnverpedidos = New System.Windows.Forms.Button
        Me.btnsair = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.grpdatapedido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdadoscliente.SuspendLayout()
        Me.grptamanho.SuspendLayout()
        Me.grpentrega.SuspendLayout()
        Me.grpingredientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpdatapedido
        '
        Me.grpdatapedido.Controls.Add(Me.txtdatapedido)
        Me.grpdatapedido.Controls.Add(Me.Label1)
        Me.grpdatapedido.Location = New System.Drawing.Point(12, 12)
        Me.grpdatapedido.Name = "grpdatapedido"
        Me.grpdatapedido.Size = New System.Drawing.Size(216, 41)
        Me.grpdatapedido.TabIndex = 0
        Me.grpdatapedido.TabStop = False
        '
        'txtdatapedido
        '
        Me.txtdatapedido.Location = New System.Drawing.Point(96, 14)
        Me.txtdatapedido.Name = "txtdatapedido"
        Me.txtdatapedido.Size = New System.Drawing.Size(100, 20)
        Me.txtdatapedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data de Pedido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication13.My.Resources.Resources.pizza
        Me.PictureBox1.Location = New System.Drawing.Point(244, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 51)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grpdadoscliente
        '
        Me.grpdadoscliente.Controls.Add(Me.btneliminar)
        Me.grpdadoscliente.Controls.Add(Me.txtcodcliente)
        Me.grpdadoscliente.Controls.Add(Me.chkdesconto)
        Me.grpdadoscliente.Controls.Add(Me.txtencargos)
        Me.grpdadoscliente.Controls.Add(Me.Label5)
        Me.grpdadoscliente.Controls.Add(Me.btncancelar)
        Me.grpdadoscliente.Controls.Add(Me.btnsalvar)
        Me.grpdadoscliente.Controls.Add(Me.txtobservaçõescliente)
        Me.grpdadoscliente.Controls.Add(Me.txtlocalidade)
        Me.grpdadoscliente.Controls.Add(Me.txtsigla)
        Me.grpdadoscliente.Controls.Add(Me.txtpostal)
        Me.grpdadoscliente.Controls.Add(Me.txtmorada)
        Me.grpdadoscliente.Controls.Add(Me.txtapelido)
        Me.grpdadoscliente.Controls.Add(Me.txtnome)
        Me.grpdadoscliente.Controls.Add(Me.btnprocurarcliente)
        Me.grpdadoscliente.Controls.Add(Me.txttelefone)
        Me.grpdadoscliente.Controls.Add(Me.Label4)
        Me.grpdadoscliente.Location = New System.Drawing.Point(12, 70)
        Me.grpdadoscliente.Name = "grpdadoscliente"
        Me.grpdadoscliente.Size = New System.Drawing.Size(283, 245)
        Me.grpdadoscliente.TabIndex = 2
        Me.grpdadoscliente.TabStop = False
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(87, 157)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 37)
        Me.btneliminar.TabIndex = 16
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(249, 164)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(27, 20)
        Me.txtcodcliente.TabIndex = 15
        Me.txtcodcliente.Text = "0"
        Me.txtcodcliente.Visible = False
        '
        'chkdesconto
        '
        Me.chkdesconto.AutoSize = True
        Me.chkdesconto.Location = New System.Drawing.Point(55, 222)
        Me.chkdesconto.Name = "chkdesconto"
        Me.chkdesconto.Size = New System.Drawing.Size(167, 17)
        Me.chkdesconto.TabIndex = 14
        Me.chkdesconto.Text = "Conceder Desconto no Preço"
        Me.chkdesconto.UseVisualStyleBackColor = True
        '
        'txtencargos
        '
        Me.txtencargos.Location = New System.Drawing.Point(125, 198)
        Me.txtencargos.Name = "txtencargos"
        Me.txtencargos.Size = New System.Drawing.Size(47, 20)
        Me.txtencargos.TabIndex = 13
        Me.txtencargos.Text = "5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Encargos(%)"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(168, 157)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 38)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(10, 157)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(75, 38)
        Me.btnsalvar.TabIndex = 10
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'txtobservaçõescliente
        '
        Me.txtobservaçõescliente.Location = New System.Drawing.Point(10, 108)
        Me.txtobservaçõescliente.Multiline = True
        Me.txtobservaçõescliente.Name = "txtobservaçõescliente"
        Me.txtobservaçõescliente.Size = New System.Drawing.Size(256, 43)
        Me.txtobservaçõescliente.TabIndex = 9
        '
        'txtlocalidade
        '
        Me.txtlocalidade.Location = New System.Drawing.Point(190, 83)
        Me.txtlocalidade.Name = "txtlocalidade"
        Me.txtlocalidade.Size = New System.Drawing.Size(76, 20)
        Me.txtlocalidade.TabIndex = 8
        '
        'txtsigla
        '
        Me.txtsigla.Location = New System.Drawing.Point(113, 83)
        Me.txtsigla.Name = "txtsigla"
        Me.txtsigla.Size = New System.Drawing.Size(71, 20)
        Me.txtsigla.TabIndex = 7
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(10, 83)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(97, 20)
        Me.txtpostal.TabIndex = 6
        '
        'txtmorada
        '
        Me.txtmorada.Location = New System.Drawing.Point(10, 60)
        Me.txtmorada.Name = "txtmorada"
        Me.txtmorada.Size = New System.Drawing.Size(256, 20)
        Me.txtmorada.TabIndex = 5
        '
        'txtapelido
        '
        Me.txtapelido.Location = New System.Drawing.Point(103, 36)
        Me.txtapelido.Name = "txtapelido"
        Me.txtapelido.Size = New System.Drawing.Size(163, 20)
        Me.txtapelido.TabIndex = 4
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(10, 36)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(87, 20)
        Me.txtnome.TabIndex = 3
        '
        'btnprocurarcliente
        '
        Me.btnprocurarcliente.Location = New System.Drawing.Point(168, 10)
        Me.btnprocurarcliente.Name = "btnprocurarcliente"
        Me.btnprocurarcliente.Size = New System.Drawing.Size(98, 23)
        Me.btnprocurarcliente.TabIndex = 2
        Me.btnprocurarcliente.Text = "Procurar Cliente"
        Me.btnprocurarcliente.UseVisualStyleBackColor = True
        '
        'txttelefone
        '
        Me.txttelefone.Location = New System.Drawing.Point(62, 12)
        Me.txttelefone.Name = "txttelefone"
        Me.txttelefone.Size = New System.Drawing.Size(100, 20)
        Me.txttelefone.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefone"
        '
        'grptamanho
        '
        Me.grptamanho.Controls.Add(Me.txtgrande)
        Me.grptamanho.Controls.Add(Me.txtmedia)
        Me.grptamanho.Controls.Add(Me.txtpequena)
        Me.grptamanho.Controls.Add(Me.rdbgrande)
        Me.grptamanho.Controls.Add(Me.rdbmedia)
        Me.grptamanho.Controls.Add(Me.rdbpequena)
        Me.grptamanho.Location = New System.Drawing.Point(321, 70)
        Me.grptamanho.Name = "grptamanho"
        Me.grptamanho.Size = New System.Drawing.Size(151, 100)
        Me.grptamanho.TabIndex = 3
        Me.grptamanho.TabStop = False
        Me.grptamanho.Text = "Tamanho"
        '
        'txtgrande
        '
        Me.txtgrande.Location = New System.Drawing.Point(81, 66)
        Me.txtgrande.Name = "txtgrande"
        Me.txtgrande.Size = New System.Drawing.Size(57, 20)
        Me.txtgrande.TabIndex = 5
        Me.txtgrande.Text = "21,00"
        '
        'txtmedia
        '
        Me.txtmedia.Location = New System.Drawing.Point(81, 43)
        Me.txtmedia.Name = "txtmedia"
        Me.txtmedia.Size = New System.Drawing.Size(57, 20)
        Me.txtmedia.TabIndex = 4
        Me.txtmedia.Text = "18,00"
        '
        'txtpequena
        '
        Me.txtpequena.Location = New System.Drawing.Point(81, 19)
        Me.txtpequena.Name = "txtpequena"
        Me.txtpequena.Size = New System.Drawing.Size(57, 20)
        Me.txtpequena.TabIndex = 3
        Me.txtpequena.Text = "14,00"
        '
        'rdbgrande
        '
        Me.rdbgrande.AutoSize = True
        Me.rdbgrande.Location = New System.Drawing.Point(6, 67)
        Me.rdbgrande.Name = "rdbgrande"
        Me.rdbgrande.Size = New System.Drawing.Size(60, 17)
        Me.rdbgrande.TabIndex = 2
        Me.rdbgrande.TabStop = True
        Me.rdbgrande.Text = "Grande"
        Me.rdbgrande.UseVisualStyleBackColor = True
        '
        'rdbmedia
        '
        Me.rdbmedia.AutoSize = True
        Me.rdbmedia.Location = New System.Drawing.Point(6, 44)
        Me.rdbmedia.Name = "rdbmedia"
        Me.rdbmedia.Size = New System.Drawing.Size(54, 17)
        Me.rdbmedia.TabIndex = 1
        Me.rdbmedia.TabStop = True
        Me.rdbmedia.Text = "Média"
        Me.rdbmedia.UseVisualStyleBackColor = True
        '
        'rdbpequena
        '
        Me.rdbpequena.AutoSize = True
        Me.rdbpequena.Location = New System.Drawing.Point(6, 20)
        Me.rdbpequena.Name = "rdbpequena"
        Me.rdbpequena.Size = New System.Drawing.Size(68, 17)
        Me.rdbpequena.TabIndex = 0
        Me.rdbpequena.TabStop = True
        Me.rdbpequena.Text = "Pequena"
        Me.rdbpequena.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pizzaria Mama Mia"
        '
        'grpentrega
        '
        Me.grpentrega.Controls.Add(Me.txtborda)
        Me.grpentrega.Controls.Add(Me.txtentregar)
        Me.grpentrega.Controls.Add(Me.chkborda)
        Me.grpentrega.Controls.Add(Me.chkentregar)
        Me.grpentrega.Location = New System.Drawing.Point(321, 176)
        Me.grpentrega.Name = "grpentrega"
        Me.grpentrega.Size = New System.Drawing.Size(151, 62)
        Me.grpentrega.TabIndex = 5
        Me.grpentrega.TabStop = False
        '
        'txtborda
        '
        Me.txtborda.Location = New System.Drawing.Point(81, 36)
        Me.txtborda.Name = "txtborda"
        Me.txtborda.Size = New System.Drawing.Size(57, 20)
        Me.txtborda.TabIndex = 3
        Me.txtborda.Text = "2,00"
        '
        'txtentregar
        '
        Me.txtentregar.Location = New System.Drawing.Point(81, 10)
        Me.txtentregar.Name = "txtentregar"
        Me.txtentregar.Size = New System.Drawing.Size(57, 20)
        Me.txtentregar.TabIndex = 2
        Me.txtentregar.Text = "2,00"
        '
        'chkborda
        '
        Me.chkborda.AutoSize = True
        Me.chkborda.Location = New System.Drawing.Point(7, 35)
        Me.chkborda.Name = "chkborda"
        Me.chkborda.Size = New System.Drawing.Size(54, 17)
        Me.chkborda.TabIndex = 1
        Me.chkborda.Text = "Borda"
        Me.chkborda.UseVisualStyleBackColor = True
        '
        'chkentregar
        '
        Me.chkentregar.AutoSize = True
        Me.chkentregar.Location = New System.Drawing.Point(7, 12)
        Me.chkentregar.Name = "chkentregar"
        Me.chkentregar.Size = New System.Drawing.Size(66, 17)
        Me.chkentregar.TabIndex = 0
        Me.chkentregar.Text = "Entregar"
        Me.chkentregar.UseVisualStyleBackColor = True
        '
        'grpingredientes
        '
        Me.grpingredientes.Controls.Add(Me.txtanchovas)
        Me.grpingredientes.Controls.Add(Me.txtcamarao)
        Me.grpingredientes.Controls.Add(Me.txtpresunto)
        Me.grpingredientes.Controls.Add(Me.txtovo)
        Me.grpingredientes.Controls.Add(Me.txtcalabreza)
        Me.grpingredientes.Controls.Add(Me.txtpepperoni)
        Me.grpingredientes.Controls.Add(Me.txttomate)
        Me.grpingredientes.Controls.Add(Me.txtpimentao)
        Me.grpingredientes.Controls.Add(Me.txtcebola)
        Me.grpingredientes.Controls.Add(Me.txtazeitonas)
        Me.grpingredientes.Controls.Add(Me.txtcogumelos)
        Me.grpingredientes.Controls.Add(Me.txtqueijo)
        Me.grpingredientes.Controls.Add(Me.chkanchovas)
        Me.grpingredientes.Controls.Add(Me.chkcamarao)
        Me.grpingredientes.Controls.Add(Me.chkpresunto)
        Me.grpingredientes.Controls.Add(Me.chkovo)
        Me.grpingredientes.Controls.Add(Me.chkcababreza)
        Me.grpingredientes.Controls.Add(Me.chkpepperoni)
        Me.grpingredientes.Controls.Add(Me.chktomate)
        Me.grpingredientes.Controls.Add(Me.chkpimentao)
        Me.grpingredientes.Controls.Add(Me.chkcebola)
        Me.grpingredientes.Controls.Add(Me.chkazeitonas)
        Me.grpingredientes.Controls.Add(Me.chkcogumelos)
        Me.grpingredientes.Controls.Add(Me.chkqueijo)
        Me.grpingredientes.Location = New System.Drawing.Point(478, 70)
        Me.grpingredientes.Name = "grpingredientes"
        Me.grpingredientes.Size = New System.Drawing.Size(302, 168)
        Me.grpingredientes.TabIndex = 6
        Me.grpingredientes.TabStop = False
        Me.grpingredientes.Text = "Ingredientes"
        '
        'txtanchovas
        '
        Me.txtanchovas.Location = New System.Drawing.Point(249, 137)
        Me.txtanchovas.Name = "txtanchovas"
        Me.txtanchovas.Size = New System.Drawing.Size(30, 20)
        Me.txtanchovas.TabIndex = 24
        Me.txtanchovas.Text = "1,00"
        '
        'txtcamarao
        '
        Me.txtcamarao.Location = New System.Drawing.Point(249, 115)
        Me.txtcamarao.Name = "txtcamarao"
        Me.txtcamarao.Size = New System.Drawing.Size(30, 20)
        Me.txtcamarao.TabIndex = 23
        Me.txtcamarao.Text = "1,00"
        '
        'txtpresunto
        '
        Me.txtpresunto.Location = New System.Drawing.Point(249, 93)
        Me.txtpresunto.Name = "txtpresunto"
        Me.txtpresunto.Size = New System.Drawing.Size(30, 20)
        Me.txtpresunto.TabIndex = 22
        Me.txtpresunto.Text = "1,00"
        '
        'txtovo
        '
        Me.txtovo.Location = New System.Drawing.Point(249, 71)
        Me.txtovo.Name = "txtovo"
        Me.txtovo.Size = New System.Drawing.Size(30, 20)
        Me.txtovo.TabIndex = 21
        Me.txtovo.Text = "1,00"
        '
        'txtcalabreza
        '
        Me.txtcalabreza.Location = New System.Drawing.Point(249, 49)
        Me.txtcalabreza.Name = "txtcalabreza"
        Me.txtcalabreza.Size = New System.Drawing.Size(30, 20)
        Me.txtcalabreza.TabIndex = 20
        Me.txtcalabreza.Text = "1,00"
        '
        'txtpepperoni
        '
        Me.txtpepperoni.Location = New System.Drawing.Point(249, 27)
        Me.txtpepperoni.Name = "txtpepperoni"
        Me.txtpepperoni.Size = New System.Drawing.Size(30, 20)
        Me.txtpepperoni.TabIndex = 19
        Me.txtpepperoni.Text = "1,00"
        '
        'txttomate
        '
        Me.txttomate.Location = New System.Drawing.Point(119, 139)
        Me.txttomate.Name = "txttomate"
        Me.txttomate.Size = New System.Drawing.Size(30, 20)
        Me.txttomate.TabIndex = 17
        Me.txttomate.Text = "0,50"
        '
        'txtpimentao
        '
        Me.txtpimentao.Location = New System.Drawing.Point(119, 116)
        Me.txtpimentao.Name = "txtpimentao"
        Me.txtpimentao.Size = New System.Drawing.Size(30, 20)
        Me.txtpimentao.TabIndex = 16
        Me.txtpimentao.Text = "0,50"
        '
        'txtcebola
        '
        Me.txtcebola.Location = New System.Drawing.Point(119, 93)
        Me.txtcebola.Name = "txtcebola"
        Me.txtcebola.Size = New System.Drawing.Size(30, 20)
        Me.txtcebola.TabIndex = 15
        Me.txtcebola.Text = "0,50"
        '
        'txtazeitonas
        '
        Me.txtazeitonas.Location = New System.Drawing.Point(119, 70)
        Me.txtazeitonas.Name = "txtazeitonas"
        Me.txtazeitonas.Size = New System.Drawing.Size(30, 20)
        Me.txtazeitonas.TabIndex = 14
        Me.txtazeitonas.Text = "0,50"
        '
        'txtcogumelos
        '
        Me.txtcogumelos.Location = New System.Drawing.Point(119, 47)
        Me.txtcogumelos.Name = "txtcogumelos"
        Me.txtcogumelos.Size = New System.Drawing.Size(30, 20)
        Me.txtcogumelos.TabIndex = 13
        Me.txtcogumelos.Text = "0,50"
        '
        'txtqueijo
        '
        Me.txtqueijo.Location = New System.Drawing.Point(119, 24)
        Me.txtqueijo.Name = "txtqueijo"
        Me.txtqueijo.Size = New System.Drawing.Size(30, 20)
        Me.txtqueijo.TabIndex = 12
        Me.txtqueijo.Text = "0,50"
        '
        'chkanchovas
        '
        Me.chkanchovas.AutoSize = True
        Me.chkanchovas.Location = New System.Drawing.Point(170, 141)
        Me.chkanchovas.Name = "chkanchovas"
        Me.chkanchovas.Size = New System.Drawing.Size(74, 17)
        Me.chkanchovas.TabIndex = 11
        Me.chkanchovas.Text = "Anchovas"
        Me.chkanchovas.UseVisualStyleBackColor = True
        '
        'chkcamarao
        '
        Me.chkcamarao.AutoSize = True
        Me.chkcamarao.Location = New System.Drawing.Point(170, 118)
        Me.chkcamarao.Name = "chkcamarao"
        Me.chkcamarao.Size = New System.Drawing.Size(68, 17)
        Me.chkcamarao.TabIndex = 10
        Me.chkcamarao.Text = "Camarão"
        Me.chkcamarao.UseVisualStyleBackColor = True
        '
        'chkpresunto
        '
        Me.chkpresunto.AutoSize = True
        Me.chkpresunto.Location = New System.Drawing.Point(170, 95)
        Me.chkpresunto.Name = "chkpresunto"
        Me.chkpresunto.Size = New System.Drawing.Size(68, 17)
        Me.chkpresunto.TabIndex = 9
        Me.chkpresunto.Text = "Presunto"
        Me.chkpresunto.UseVisualStyleBackColor = True
        '
        'chkovo
        '
        Me.chkovo.AutoSize = True
        Me.chkovo.Location = New System.Drawing.Point(170, 72)
        Me.chkovo.Name = "chkovo"
        Me.chkovo.Size = New System.Drawing.Size(46, 17)
        Me.chkovo.TabIndex = 8
        Me.chkovo.Text = "Ovo"
        Me.chkovo.UseVisualStyleBackColor = True
        '
        'chkcababreza
        '
        Me.chkcababreza.AutoSize = True
        Me.chkcababreza.Location = New System.Drawing.Point(170, 49)
        Me.chkcababreza.Name = "chkcababreza"
        Me.chkcababreza.Size = New System.Drawing.Size(73, 17)
        Me.chkcababreza.TabIndex = 7
        Me.chkcababreza.Text = "Calabreza"
        Me.chkcababreza.UseVisualStyleBackColor = True
        '
        'chkpepperoni
        '
        Me.chkpepperoni.AutoSize = True
        Me.chkpepperoni.Location = New System.Drawing.Point(170, 26)
        Me.chkpepperoni.Name = "chkpepperoni"
        Me.chkpepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkpepperoni.TabIndex = 6
        Me.chkpepperoni.Text = "Pepperoni"
        Me.chkpepperoni.UseVisualStyleBackColor = True
        '
        'chktomate
        '
        Me.chktomate.AutoSize = True
        Me.chktomate.Location = New System.Drawing.Point(15, 144)
        Me.chktomate.Name = "chktomate"
        Me.chktomate.Size = New System.Drawing.Size(62, 17)
        Me.chktomate.TabIndex = 5
        Me.chktomate.Text = "Tomate"
        Me.chktomate.UseVisualStyleBackColor = True
        '
        'chkpimentao
        '
        Me.chkpimentao.AutoSize = True
        Me.chkpimentao.Location = New System.Drawing.Point(15, 121)
        Me.chkpimentao.Name = "chkpimentao"
        Me.chkpimentao.Size = New System.Drawing.Size(101, 17)
        Me.chkpimentao.TabIndex = 4
        Me.chkpimentao.Text = "Pimentão Verde"
        Me.chkpimentao.UseVisualStyleBackColor = True
        '
        'chkcebola
        '
        Me.chkcebola.AutoSize = True
        Me.chkcebola.Location = New System.Drawing.Point(15, 98)
        Me.chkcebola.Name = "chkcebola"
        Me.chkcebola.Size = New System.Drawing.Size(59, 17)
        Me.chkcebola.TabIndex = 3
        Me.chkcebola.Text = "Cebola"
        Me.chkcebola.UseVisualStyleBackColor = True
        '
        'chkazeitonas
        '
        Me.chkazeitonas.AutoSize = True
        Me.chkazeitonas.Location = New System.Drawing.Point(15, 75)
        Me.chkazeitonas.Name = "chkazeitonas"
        Me.chkazeitonas.Size = New System.Drawing.Size(105, 17)
        Me.chkazeitonas.TabIndex = 2
        Me.chkazeitonas.Text = "Azeitonas Pretas"
        Me.chkazeitonas.UseVisualStyleBackColor = True
        '
        'chkcogumelos
        '
        Me.chkcogumelos.AutoSize = True
        Me.chkcogumelos.Location = New System.Drawing.Point(15, 52)
        Me.chkcogumelos.Name = "chkcogumelos"
        Me.chkcogumelos.Size = New System.Drawing.Size(78, 17)
        Me.chkcogumelos.TabIndex = 1
        Me.chkcogumelos.Text = "Cogumelos"
        Me.chkcogumelos.UseVisualStyleBackColor = True
        '
        'chkqueijo
        '
        Me.chkqueijo.AutoSize = True
        Me.chkqueijo.Location = New System.Drawing.Point(15, 29)
        Me.chkqueijo.Name = "chkqueijo"
        Me.chkqueijo.Size = New System.Drawing.Size(83, 17)
        Me.chkqueijo.TabIndex = 0
        Me.chkqueijo.Text = "Queijo Extra"
        Me.chkqueijo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Observação:"
        '
        'txtobservacaoencomenda
        '
        Me.txtobservacaoencomenda.Location = New System.Drawing.Point(321, 254)
        Me.txtobservacaoencomenda.Multiline = True
        Me.txtobservacaoencomenda.Name = "txtobservacaoencomenda"
        Me.txtobservacaoencomenda.Size = New System.Drawing.Size(459, 31)
        Me.txtobservacaoencomenda.TabIndex = 8
        '
        'btncriarpizza
        '
        Me.btncriarpizza.Location = New System.Drawing.Point(321, 292)
        Me.btncriarpizza.Name = "btncriarpizza"
        Me.btncriarpizza.Size = New System.Drawing.Size(75, 23)
        Me.btncriarpizza.TabIndex = 9
        Me.btncriarpizza.Text = "Criar Pizza"
        Me.btncriarpizza.UseVisualStyleBackColor = True
        '
        'btnencerrar
        '
        Me.btnencerrar.Location = New System.Drawing.Point(402, 292)
        Me.btnencerrar.Name = "btnencerrar"
        Me.btnencerrar.Size = New System.Drawing.Size(111, 23)
        Me.btnencerrar.TabIndex = 10
        Me.btnencerrar.Text = "Limpar"
        Me.btnencerrar.UseVisualStyleBackColor = True
        '
        'btnverpedidos
        '
        Me.btnverpedidos.Location = New System.Drawing.Point(519, 292)
        Me.btnverpedidos.Name = "btnverpedidos"
        Me.btnverpedidos.Size = New System.Drawing.Size(75, 23)
        Me.btnverpedidos.TabIndex = 11
        Me.btnverpedidos.Text = "Ver Pedidos"
        Me.btnverpedidos.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(705, 292)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(75, 23)
        Me.btnsair.TabIndex = 12
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(792, 80)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 204)
        Me.TextBox1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(904, 320)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btnverpedidos)
        Me.Controls.Add(Me.btnencerrar)
        Me.Controls.Add(Me.btncriarpizza)
        Me.Controls.Add(Me.txtobservacaoencomenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpingredientes)
        Me.Controls.Add(Me.grpentrega)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grptamanho)
        Me.Controls.Add(Me.grpdadoscliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpdatapedido)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpdatapedido.ResumeLayout(False)
        Me.grpdatapedido.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdadoscliente.ResumeLayout(False)
        Me.grpdadoscliente.PerformLayout()
        Me.grptamanho.ResumeLayout(False)
        Me.grptamanho.PerformLayout()
        Me.grpentrega.ResumeLayout(False)
        Me.grpentrega.PerformLayout()
        Me.grpingredientes.ResumeLayout(False)
        Me.grpingredientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpdatapedido As System.Windows.Forms.GroupBox
    Friend WithEvents txtdatapedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpdadoscliente As System.Windows.Forms.GroupBox
    Friend WithEvents grptamanho As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbmedia As System.Windows.Forms.RadioButton
    Friend WithEvents rdbpequena As System.Windows.Forms.RadioButton
    Friend WithEvents grpentrega As System.Windows.Forms.GroupBox
    Friend WithEvents grpingredientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtobservacaoencomenda As System.Windows.Forms.TextBox
    Friend WithEvents txtgrande As System.Windows.Forms.TextBox
    Friend WithEvents txtmedia As System.Windows.Forms.TextBox
    Friend WithEvents txtpequena As System.Windows.Forms.TextBox
    Friend WithEvents rdbgrande As System.Windows.Forms.RadioButton
    Friend WithEvents txtborda As System.Windows.Forms.TextBox
    Friend WithEvents txtentregar As System.Windows.Forms.TextBox
    Friend WithEvents chkborda As System.Windows.Forms.CheckBox
    Friend WithEvents chkentregar As System.Windows.Forms.CheckBox
    Friend WithEvents chkpepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chktomate As System.Windows.Forms.CheckBox
    Friend WithEvents chkpimentao As System.Windows.Forms.CheckBox
    Friend WithEvents chkcebola As System.Windows.Forms.CheckBox
    Friend WithEvents chkazeitonas As System.Windows.Forms.CheckBox
    Friend WithEvents chkcogumelos As System.Windows.Forms.CheckBox
    Friend WithEvents chkqueijo As System.Windows.Forms.CheckBox
    Friend WithEvents txttomate As System.Windows.Forms.TextBox
    Friend WithEvents txtpimentao As System.Windows.Forms.TextBox
    Friend WithEvents txtcebola As System.Windows.Forms.TextBox
    Friend WithEvents txtazeitonas As System.Windows.Forms.TextBox
    Friend WithEvents txtcogumelos As System.Windows.Forms.TextBox
    Friend WithEvents txtqueijo As System.Windows.Forms.TextBox
    Friend WithEvents chkanchovas As System.Windows.Forms.CheckBox
    Friend WithEvents chkcamarao As System.Windows.Forms.CheckBox
    Friend WithEvents chkpresunto As System.Windows.Forms.CheckBox
    Friend WithEvents chkovo As System.Windows.Forms.CheckBox
    Friend WithEvents chkcababreza As System.Windows.Forms.CheckBox
    Friend WithEvents txtanchovas As System.Windows.Forms.TextBox
    Friend WithEvents txtcamarao As System.Windows.Forms.TextBox
    Friend WithEvents txtpresunto As System.Windows.Forms.TextBox
    Friend WithEvents txtovo As System.Windows.Forms.TextBox
    Friend WithEvents txtcalabreza As System.Windows.Forms.TextBox
    Friend WithEvents txtpepperoni As System.Windows.Forms.TextBox
    Friend WithEvents btncriarpizza As System.Windows.Forms.Button
    Friend WithEvents txtapelido As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents btnprocurarcliente As System.Windows.Forms.Button
    Friend WithEvents txttelefone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnencerrar As System.Windows.Forms.Button
    Friend WithEvents btnverpedidos As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents txtobservaçõescliente As System.Windows.Forms.TextBox
    Friend WithEvents txtlocalidade As System.Windows.Forms.TextBox
    Friend WithEvents txtsigla As System.Windows.Forms.TextBox
    Friend WithEvents txtpostal As System.Windows.Forms.TextBox
    Friend WithEvents txtmorada As System.Windows.Forms.TextBox
    Friend WithEvents chkdesconto As System.Windows.Forms.CheckBox
    Friend WithEvents txtencargos As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button

End Class
