Public Class Form1
    Dim contar As Integer
    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click

        If Me.txtutilizador.Text = "admin" And Me.txtpalavrapasse.Text = "admin" Then
            Dim frm3 As New Form3
            frm3.Show()
        Else
            contar = contar + 1
            If contar = 3 Then
                Dim frm2 As New Form2
                frm2.Show()
            End If
        End If
    End Sub
End Class
