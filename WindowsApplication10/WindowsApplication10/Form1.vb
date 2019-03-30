Public Class Form1

    Private Sub cmbfuncoestexto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfuncoestexto.SelectedIndexChanged
        Me.btnprocessar.Text = Me.cmbfuncoestexto.Text
        Select Case cmbfuncoestexto.Text
            Case "Len"
                Me.txttexto2.Visible = False
        End Select

    End Sub

    Private Sub btnprocessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocessar.Click
        Select Case Me.btnprocessar.Text
            Case "StrComp" 'Compara as duas frases para verificar se existem diferenças'
                Me.txtresultado.Text = StrComp(Me.txttexto1.Text, Me.txttexto2.Text)
            Case "Len" 'Indica quantos caracteres tem a frase'
                Me.txtresultado.Text = Len(Me.txttexto1.Text)
            Case "InStr" '
                Me.txtresultado.Text = InStr(Me.txttexto1.Text, Me.txttexto2.Text)
            Case "InStrRev"
                Me.txtresultado.Text = InStrRev(Me.txttexto1.Text, Me.txttexto2.Text)
            Case "GetChar" 'Indica o caracter que está na posição 3'
                Me.txtresultado.Text = GetChar(Me.txttexto1.Text, 3)
            Case "Mid"
                Me.txtresultado.Text = Mid(Me.txttexto1.Text, 5)
            Case "Left" 'Indica os 3 primeiros caracteres da esquerda para a direita'
                Me.txtresultado.Text = Microsoft.VisualBasic.Left(Me.txttexto1.Text, 3)
            Case "Right" 'Indica os 3 primeiros caracteres da direita para a esquerda'
                Me.txtresultado.Text = Microsoft.VisualBasic.Right(Me.txttexto1.Text, 3)
            Case "LTrim" 'Retira o espaço que está a esquerda'
                Me.txtresultado.Text = LTrim(Me.txttexto1.Text)
            Case "RTrim" 'Retira  o espaço que está a direita'
                Me.txtresultado.Text = RTrim(Me.txttexto1.Text)
            Case "Trim" 'Retira o espaço dos dois lados'
                Me.txtresultado.Text = Trim(Me.txttexto1.Text)
            Case "LCase" 'Mete todos os caracteres em letra minisculas'
                Me.txtresultado.Text = LCase(Me.txttexto1.Text)
            Case "UCase" 'Mete todos os caracteres em letra maisculas'
                Me.txtresultado.Text = UCase(Me.txttexto1.Text)
            Case "StrConv" 'Tem várias opções, neste caso converte a frase toda para letras maisculas'
                Me.txtresultado.Text = StrConv(Me.txttexto1.Text, VbStrConv.Uppercase)
            Case "StrReverse" 'Devolve a frase toda ao contrário'
                Me.txtresultado.Text = StrReverse(Me.txttexto1.Text)
            Case "RSet"
                Me.txtresultado.Text = RSet(Me.txttexto1.Text, 2)
            Case "LSet"
                Me.txtresultado.Text = LSet(Me.txttexto1.Text, 5)
            Case "Replace" 'Substitui a palavra que queremos por Magno'
                Me.txtresultado.Text = Microsoft.VisualBasic.Replace(Me.txttexto1.Text, Me.txttexto2.Text, "Magno")
            Case "Space" 'Dá neste caso 1 espaço'
                Me.txtresultado.Text = Space(Me.txttexto1.Text)
            Case "StrDup" 'Repete o numero de vezes de uma letra que queremos'
                Me.txtresultado.Text = StrDup(CInt(Me.txttexto1.Text), Me.txttexto2.Text)
        End Select

    End Sub
End Class
