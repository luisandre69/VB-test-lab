Public Class Form1

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        Me.txtnomecompleto.Text = Me.cmbtitulo.Text & Me.txtnome.Text & Space(1) & Me.txtapelido.Text
        Me.txtidade.Text = DateDiff(DateInterval.Year, CDate(Me.DateTimePicker1.Text), Now())
        Select Case Me.cmbgenero.Text
            Case "Masculino"
                Panel1.BackColor = Color.Blue
            Case "Feminino"
                Panel1.BackColor = Color.Pink
            Case ""
                Panel1.BackColor = Color.Gray
        End Select

        Select Case Me.lstcargo.Text
            Case "Presidente"
                Me.txtordenado.Text = "5000€/mês"
                Me.txtordenado.BackColor = Color.Gold
            Case "Administrador"
                Me.txtordenado.Text = "3500€/mês"
                Me.txtordenado.BackColor = Color.Silver
            Case "Gestor de Projectos"
                Me.txtordenado.Text = "2000€/mês"
                Me.txtordenado.BackColor = Color.Red
            Case "Programador Sénior"
                Me.txtordenado.Text = "1200€/mês"
                Me.txtordenado.BackColor = Color.LightBlue
            Case "Programador Júnior"
                Me.txtordenado.Text = "800€/mês"
                Me.txtordenado.BackColor = Color.Yellow
        End Select


    End Sub
End Class
