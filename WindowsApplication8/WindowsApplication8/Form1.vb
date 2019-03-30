Public Class Form1

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        Me.txtautor.Text = Space(1)
        Me.txtisbn.Text = Space(1)
        Me.txtprecobase.Text = Space(1)
        Me.txtprecofinal.Text = Space(1)
        Me.txttitulo.Text = Space(1)
    End Sub

    Private Sub btnprocessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocessar.Click
        'Dim Comissao As Double'
        'Dim IVA As Double'
        'Comissao = 0.05'
        'IVA = 1.15'
        Me.txtprecofinal.Text = Me.txtprecobase.Text + (Me.txtprecobase.Text * CDbl(Me.txtcomissao.Text)) * CDbl(Me.txtiva.Text)
    End Sub

    Private Sub btninserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninserir.Click
        Me.ListBox1.Items.Add(Me.txttitulo.Text)

    End Sub

    Private Sub btnremover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremover.Click
        Me.ListBox1.Items.Remove(Me.ListBox1.Text)
    End Sub
End Class
