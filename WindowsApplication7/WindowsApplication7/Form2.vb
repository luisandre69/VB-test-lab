Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case txtaluno1.Text
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                lblaluno1.Text = "Insuficiente"
            Case 10, 11, 12, 13
                lblaluno1.Text = "Suficiente"
            Case 14, 15, 16, 17
                lblaluno1.Text = "Bom"
            Case 18, 19, 20
                lblaluno1.Text = "Muito Bom"
        End Select
        Select Case txtaluno2.Text
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                lblaluno2.Text = "Insuficiente"
            Case 10, 11, 12, 13
                lblaluno2.Text = "Suficiente"
            Case 14, 15, 16, 17
                lblaluno2.Text = "Bom"
            Case 18, 19, 20
                lblaluno2.Text = "Muito Bom"
        End Select
        Select Case txtaluno3.Text
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                lblaluno3.Text = "Insuficiente"
            Case 10, 11, 12, 13
                lblaluno3.Text = "Suficiente"
            Case 14, 15, 16, 17
                lblaluno3.Text = "Bom"
            Case 18, 19, 20
                lblaluno3.Text = "Muito Bom"
        End Select
        Select Case txtaluno4.Text
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                lblaluno4.Text = "Insuficiente"
            Case 10, 11, 12, 13
                lblaluno4.Text = "Suficiente"
            Case 14, 15, 16, 17
                lblaluno4.Text = "Bom"
            Case 18, 19, 20
                lblaluno4.Text = "Muito Bom"
        End Select
        Select Case txtaluno5.Text
            Case 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                lblaluno5.Text = "Insuficiente"
            Case 10, 11, 12, 13
                lblaluno5.Text = "Suficiente"
            Case 14, 15, 16, 17
                lblaluno5.Text = "Bom"
            Case 18, 19, 20
                lblaluno5.Text = "Muito Bom"
        End Select
    End Sub
End Class
