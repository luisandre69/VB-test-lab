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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttitulo = New System.Windows.Forms.TextBox
        Me.txtautor = New System.Windows.Forms.TextBox
        Me.txtisbn = New System.Windows.Forms.TextBox
        Me.txtprecobase = New System.Windows.Forms.TextBox
        Me.txtprecofinal = New System.Windows.Forms.TextBox
        Me.btnprocessar = New System.Windows.Forms.Button
        Me.btnlimpar = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btninserir = New System.Windows.Forms.Button
        Me.btnalterar = New System.Windows.Forms.Button
        Me.btnremover = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcomissao = New System.Windows.Forms.TextBox
        Me.txtiva = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Autor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ISBN:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtprecofinal)
        Me.GroupBox1.Controls.Add(Me.txtprecobase)
        Me.GroupBox1.Controls.Add(Me.txtisbn)
        Me.GroupBox1.Controls.Add(Me.txtautor)
        Me.GroupBox1.Controls.Add(Me.txttitulo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 162)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Preço Base:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Preço Final:"
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(73, 15)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(184, 20)
        Me.txttitulo.TabIndex = 5
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(73, 41)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(184, 20)
        Me.txtautor.TabIndex = 6
        '
        'txtisbn
        '
        Me.txtisbn.Location = New System.Drawing.Point(73, 68)
        Me.txtisbn.Name = "txtisbn"
        Me.txtisbn.Size = New System.Drawing.Size(184, 20)
        Me.txtisbn.TabIndex = 7
        '
        'txtprecobase
        '
        Me.txtprecobase.Location = New System.Drawing.Point(73, 95)
        Me.txtprecobase.Name = "txtprecobase"
        Me.txtprecobase.Size = New System.Drawing.Size(100, 20)
        Me.txtprecobase.TabIndex = 8
        '
        'txtprecofinal
        '
        Me.txtprecofinal.Location = New System.Drawing.Point(73, 123)
        Me.txtprecofinal.Name = "txtprecofinal"
        Me.txtprecofinal.Size = New System.Drawing.Size(100, 20)
        Me.txtprecofinal.TabIndex = 9
        '
        'btnprocessar
        '
        Me.btnprocessar.Location = New System.Drawing.Point(21, 181)
        Me.btnprocessar.Name = "btnprocessar"
        Me.btnprocessar.Size = New System.Drawing.Size(75, 23)
        Me.btnprocessar.TabIndex = 4
        Me.btnprocessar.Text = "Processar"
        Me.btnprocessar.UseVisualStyleBackColor = True
        '
        'btnlimpar
        '
        Me.btnlimpar.Location = New System.Drawing.Point(21, 211)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpar.TabIndex = 5
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 25)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(282, 121)
        Me.ListBox1.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(325, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 162)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btninserir
        '
        Me.btninserir.Location = New System.Drawing.Point(332, 180)
        Me.btninserir.Name = "btninserir"
        Me.btninserir.Size = New System.Drawing.Size(75, 23)
        Me.btninserir.TabIndex = 8
        Me.btninserir.Text = "Inserir >>"
        Me.btninserir.UseVisualStyleBackColor = True
        '
        'btnalterar
        '
        Me.btnalterar.Location = New System.Drawing.Point(332, 211)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(75, 23)
        Me.btnalterar.TabIndex = 9
        Me.btnalterar.Text = "<< Alterar >>"
        Me.btnalterar.UseVisualStyleBackColor = True
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(447, 180)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(75, 23)
        Me.btnremover.TabIndex = 10
        Me.btnremover.Text = "Remover"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Comissão"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "IVA"
        '
        'txtcomissao
        '
        Me.txtcomissao.Location = New System.Drawing.Point(205, 178)
        Me.txtcomissao.Name = "txtcomissao"
        Me.txtcomissao.Size = New System.Drawing.Size(100, 20)
        Me.txtcomissao.TabIndex = 13
        '
        'txtiva
        '
        Me.txtiva.Location = New System.Drawing.Point(204, 208)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(100, 20)
        Me.txtiva.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 266)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txtcomissao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.btninserir)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btnprocessar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtprecofinal As System.Windows.Forms.TextBox
    Friend WithEvents txtprecobase As System.Windows.Forms.TextBox
    Friend WithEvents txtisbn As System.Windows.Forms.TextBox
    Friend WithEvents txtautor As System.Windows.Forms.TextBox
    Friend WithEvents txttitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnprocessar As System.Windows.Forms.Button
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btninserir As System.Windows.Forms.Button
    Friend WithEvents btnalterar As System.Windows.Forms.Button
    Friend WithEvents btnremover As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcomissao As System.Windows.Forms.TextBox
    Friend WithEvents txtiva As System.Windows.Forms.TextBox

End Class
