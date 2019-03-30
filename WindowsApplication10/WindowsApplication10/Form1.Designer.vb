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
        Me.cmbfuncoestexto = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttexto1 = New System.Windows.Forms.TextBox
        Me.txttexto2 = New System.Windows.Forms.TextBox
        Me.btnprocessar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtresultado = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Funções de Texto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Texto1:"
        '
        'cmbfuncoestexto
        '
        Me.cmbfuncoestexto.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmbfuncoestexto.FormattingEnabled = True
        Me.cmbfuncoestexto.Items.AddRange(New Object() {"StrComp", "Len", "InStr", "InStrRev", "GetChar", "Mid", "Left", "Right", "LTrim", "RTrim", "Trim", "LCase", "UCase", "StrConv", "StrReverse", "RSet", "LSet", "Replace", "Space", "StrDup"})
        Me.cmbfuncoestexto.Location = New System.Drawing.Point(108, 29)
        Me.cmbfuncoestexto.Name = "cmbfuncoestexto"
        Me.cmbfuncoestexto.Size = New System.Drawing.Size(243, 21)
        Me.cmbfuncoestexto.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtresultado)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnprocessar)
        Me.Panel1.Controls.Add(Me.txttexto2)
        Me.Panel1.Controls.Add(Me.txttexto1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 178)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Texto2:"
        '
        'txttexto1
        '
        Me.txttexto1.BackColor = System.Drawing.Color.Orange
        Me.txttexto1.Location = New System.Drawing.Point(83, 20)
        Me.txttexto1.Name = "txttexto1"
        Me.txttexto1.Size = New System.Drawing.Size(266, 20)
        Me.txttexto1.TabIndex = 3
        Me.txttexto1.Text = "Conheça o novo portal da APEL - APELNANET.COM"
        '
        'txttexto2
        '
        Me.txttexto2.BackColor = System.Drawing.Color.Orange
        Me.txttexto2.Location = New System.Drawing.Point(83, 65)
        Me.txttexto2.Name = "txttexto2"
        Me.txttexto2.Size = New System.Drawing.Size(266, 20)
        Me.txttexto2.TabIndex = 4
        Me.txttexto2.Text = "CONHEÇA o novo portal da APEL - apelnanet.com"
        '
        'btnprocessar
        '
        Me.btnprocessar.BackColor = System.Drawing.Color.OliveDrab
        Me.btnprocessar.Location = New System.Drawing.Point(142, 117)
        Me.btnprocessar.Name = "btnprocessar"
        Me.btnprocessar.Size = New System.Drawing.Size(132, 23)
        Me.btnprocessar.TabIndex = 5
        Me.btnprocessar.Text = "Processar"
        Me.btnprocessar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Resultado:"
        '
        'txtresultado
        '
        Me.txtresultado.BackColor = System.Drawing.Color.Orange
        Me.txtresultado.Location = New System.Drawing.Point(108, 146)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(241, 20)
        Me.txtresultado.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Legenda1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Legenda2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(410, 277)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbfuncoestexto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbfuncoestexto As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txttexto2 As System.Windows.Forms.TextBox
    Friend WithEvents txttexto1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtresultado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnprocessar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
