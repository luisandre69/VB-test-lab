Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtaluno1.Text >= 9.5 Then
            lblaluno1.Text = "Aprovado"
        Else
            lblaluno1.Text = "Reprovado"
        End If
        If txtaluno2.Text >= 9.5 Then
            lblaluno2.Text = "Aprovado"
        Else
            lblaluno2.Text = "Reprovado"
        End If
        If txtaluno3.Text >= 9.5 Then
            lblaluno3.Text = "Aprovado"
        Else
            lblaluno3.Text = "Reprovado"
        End If
        If txtaluno4.Text >= 9.5 Then
            lblaluno4.Text = "Aprovado"
        Else
            lblaluno4.Text = "Reprovado"
        End If
        If txtaluno5.Text >= 9.5 Then
            lblaluno5.Text = "Aprovado"
        Else
            lblaluno5.Text = "Reprovado"
        End If
    End Sub
End Class
