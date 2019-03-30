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
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtnome = New System.Windows.Forms.TextBox
        Me.txtapelido = New System.Windows.Forms.TextBox
        Me.lstcargo = New System.Windows.Forms.ListBox
        Me.cmbtitulo = New System.Windows.Forms.ComboBox
        Me.cmbgenero = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtordenado = New System.Windows.Forms.TextBox
        Me.txtidade = New System.Windows.Forms.TextBox
        Me.txtnomecompleto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Location = New System.Drawing.Point(158, 128)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(190, 23)
        Me.btnconfirmar.TabIndex = 0
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apelido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data de Nascimento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Género:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(357, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cargo:"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(64, 29)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(100, 20)
        Me.txtnome.TabIndex = 7
        '
        'txtapelido
        '
        Me.txtapelido.Location = New System.Drawing.Point(64, 53)
        Me.txtapelido.Name = "txtapelido"
        Me.txtapelido.Size = New System.Drawing.Size(100, 20)
        Me.txtapelido.TabIndex = 8
        '
        'lstcargo
        '
        Me.lstcargo.FormattingEnabled = True
        Me.lstcargo.Items.AddRange(New Object() {"Presidente", "Administrador", "Gestor de Projectos", "Programador Sénior", "Programador Júnior"})
        Me.lstcargo.Location = New System.Drawing.Point(401, 53)
        Me.lstcargo.Name = "lstcargo"
        Me.lstcargo.Size = New System.Drawing.Size(145, 82)
        Me.lstcargo.TabIndex = 9
        '
        'cmbtitulo
        '
        Me.cmbtitulo.FormattingEnabled = True
        Me.cmbtitulo.Items.AddRange(New Object() {"Sr.", "Sra.", "Eng.", "Dr.", "Prof."})
        Me.cmbtitulo.Location = New System.Drawing.Point(64, 6)
        Me.cmbtitulo.Name = "cmbtitulo"
        Me.cmbtitulo.Size = New System.Drawing.Size(121, 21)
        Me.cmbtitulo.TabIndex = 10
        '
        'cmbgenero
        '
        Me.cmbgenero.FormattingEnabled = True
        Me.cmbgenero.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cmbgenero.Location = New System.Drawing.Point(401, 29)
        Me.cmbgenero.Name = "cmbgenero"
        Me.cmbgenero.Size = New System.Drawing.Size(121, 21)
        Me.cmbgenero.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(402, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(90, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.txtordenado)
        Me.Panel1.Controls.Add(Me.txtidade)
        Me.Panel1.Controls.Add(Me.txtnomecompleto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.label7)
        Me.Panel1.Location = New System.Drawing.Point(15, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 100)
        Me.Panel1.TabIndex = 14
        '
        'txtordenado
        '
        Me.txtordenado.Location = New System.Drawing.Point(70, 63)
        Me.txtordenado.Name = "txtordenado"
        Me.txtordenado.Size = New System.Drawing.Size(100, 20)
        Me.txtordenado.TabIndex = 5
        '
        'txtidade
        '
        Me.txtidade.Location = New System.Drawing.Point(70, 35)
        Me.txtidade.Name = "txtidade"
        Me.txtidade.Size = New System.Drawing.Size(100, 20)
        Me.txtidade.TabIndex = 4
        '
        'txtnomecompleto
        '
        Me.txtnomecompleto.Location = New System.Drawing.Point(103, 9)
        Me.txtnomecompleto.Name = "txtnomecompleto"
        Me.txtnomecompleto.Size = New System.Drawing.Size(474, 20)
        Me.txtnomecompleto.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Ordenado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Idade:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 12)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(85, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Nome Completo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(631, 295)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbgenero)
        Me.Controls.Add(Me.cmbtitulo)
        Me.Controls.Add(Me.lstcargo)
        Me.Controls.Add(Me.txtapelido)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Name = "Form1"
        Me.Text = "1º Teste BP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtapelido As System.Windows.Forms.TextBox
    Friend WithEvents lstcargo As System.Windows.Forms.ListBox
    Friend WithEvents cmbtitulo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgenero As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtordenado As System.Windows.Forms.TextBox
    Friend WithEvents txtidade As System.Windows.Forms.TextBox
    Friend WithEvents txtnomecompleto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
