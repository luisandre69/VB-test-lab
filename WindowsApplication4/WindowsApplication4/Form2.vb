Public Class Form2

    Private Sub txtoperador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoperador.SelectedIndexChanged

    End Sub

    Private Sub txtresultado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtresultado.TextChanged


    End Sub

    Private Sub btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        Dim Valor1 As Double
        Dim Valor2 As Double
        Dim Operador As String
        Dim Resultado As Double

        Valor1 = CDbl(Me.txtvalor1.Text)
        Valor2 = CDbl(Me.txtvalor2.Text)

        Operador = Me.txtoperador.Text

        Select Case Operador
            Case "+"
                Resultado = Valor1 + Valor2
            Case "-"
                Resultado = Valor1 - Valor2
            Case "*"
                Resultado = Valor1 * Valor2
            Case "/"
                Resultado = Valor1 / Valor2
        End Select
        Me.txtresultado.Text = Resultado

    End Sub
End Class