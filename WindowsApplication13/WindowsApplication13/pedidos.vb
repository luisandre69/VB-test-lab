Imports System.Data.SqlClient

Public Class pedidos
    Private Sub pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If My.Computer.FileSystem.DirectoryExists("C:\Pizzaria\Pedidos\" & Form1.txttelefone.Text) Then

        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT CodPedido, DataPedido FROM Pedidos LEFT JOIN Clientes ON Clientes.codCliente=Pedidos.codCliente WHERE Clientes.telefone ='" & Form1.txttelefone.Text & "'"
        cmd.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        Dim companyNameParam As New SqlParameter("@companyName", "a%")
        cmd.Parameters.Add(companyNameParam)
        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read
                    ' Process SprocResults datareader here.
                    With Me.ListView1.Items.Add(reader("CodPedido"))
                        .SubItems.Add(reader("DataPedido"))
                    End With
                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


        'Else
        'MsgBox("Directório não existe", MsgBoxStyle.Exclamation)
        'End If
    End Sub
    Sub Tamanho_pizza()
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT CodPizza,Entregar,Borda FROM Pedidos " & _
                          "WHERE CodPedido =" & Me.ListView1.SelectedItems(0).Text & ""
        cmd.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        Dim companyNameParam As New SqlParameter("@companyName", "a%")
        cmd.Parameters.Add(companyNameParam)
        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read
                    Select Case reader("CodPizza")
                        Case "1"
                            Form1.rdbpequena.Checked = True
                        Case "2"
                            Form1.rdbmedia.Checked = True
                        Case "3"
                            Form1.rdbgrande.Checked = True
                    End Select

                    If CInt(reader("Entregar")) = 1 Then
                        Form1.chkentregar.Checked = True
                    End If
                    If CInt(reader("Borda")) = 1 Then
                        Form1.chkborda.Checked = True
                    End If

                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Sub Nome_ingrediente()
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NomeIngrediente FROM PedidosDetalhes LEFT JOIN Ingredientes ON PedidosDetalhes.codIngrediente=Ingredientes.codIngrediente WHERE CodPedido =" & Me.ListView1.SelectedItems(0).Text & ""
        cmd.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        Dim companyNameParam As New SqlParameter("@companyName", "a%")
        cmd.Parameters.Add(companyNameParam)
        Dim reader As SqlDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read

                    Select Case reader("NomeIngrediente")
                        Case "Anchovas"
                            Form1.chkanchovas.Checked = True
                        Case "Azeitonas Pretas"
                            Form1.chkazeitonas.Checked = True
                        Case "Calabreza"
                            Form1.chkcababreza.Checked = True
                        Case "Camarão"
                            Form1.chkcamarao.Checked = True
                        Case "Cebola"
                            Form1.chkcebola.Checked = True
                        Case "Cogumelos"
                            Form1.chkcogumelos.Checked = True
                        Case "Ovo"
                            Form1.chkovo.Checked = True
                        Case "Pepperoni"
                            Form1.chkpepperoni.Checked = True
                        Case "Pimentão Verde"
                            Form1.chkpimentao.Checked = True
                        Case "Presunto"
                            Form1.chkpresunto.Checked = True
                        Case "Queijo Extra"
                            Form1.chkqueijo.Checked = True
                        Case "Tomate"
                            Form1.chktomate.Checked = True
                    End Select

                    'If CInt(reader("Entregar")) = 1 Then
                    '    Form1.chkentregar.Checked = True
                    'End If
                    'If CInt(reader("Borda")) = 1 Then
                    '    Form1.chkborda.Checked = True
                    'End If

                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Form1.Limpar()
        Tamanho_pizza()
        Nome_ingrediente()

        'Dim caminho As String = "C:\Pizzaria\Pedidos\" & Form1.txttelefone.Text & "\" & Me.ListView1.SelectedItems(0).Text & ".txt"
        'Dim texto() As String = Split(My.Computer.FileSystem.ReadAllText(caminho), vbCrLf)
        'Dim i As Double
        'Form1.Limpar()
        'Select Case texto(1)
        '    Case "Pequena"
        '        Form1.rdbpequena.Checked = True
        '    Case "Média"
        '        Form1.rdbmedia.Checked = True
        '    Case "Grande"
        '        Form1.rdbgrande.Checked = True
        'End Select
        'While Not texto(i) = "EntregarBorda"
        '    Select Case texto(i)
        '        Case "Anchovas"
        '            Form1.chkanchovas.Checked = True
        '        Case "Azeitonas Pretas"
        '            Form1.chkazeitonas.Checked = True
        '        Case "Calabreza"
        '            Form1.chkcababreza.Checked = True
        '        Case "Camarão"
        '            Form1.chkcamarao.Checked = True
        '        Case "Cebola"
        '            Form1.chkcebola.Checked = True
        '        Case "Cogumelo"
        '            Form1.chkcogumelos.Checked = True
        '        Case "Ovo"
        '            Form1.chkovo.Checked = True
        '        Case "Pepperoni"
        '            Form1.chkpepperoni.Checked = True
        '        Case "Pimentão Verde"
        '            Form1.chkpimentao.Checked = True
        '        Case "Presunto"
        '            Form1.chkpresunto.Checked = True
        '        Case "Queijo Extra"
        '            Form1.chkqueijo.Checked = True
        '        Case "Tomate"
        '            Form1.chktomate.Checked = True
        '    End Select
        '    i = i + 1
        'End While
        'If texto(i + 1) = "Entregar" Then
        '    Form1.chkentregar.Checked = True
        'End If
        'If texto(i + 2) = "Borda" Then
        '    Form1.chkborda.Checked = True
        'End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.TextBox1.Text = " "
            Dim conn As New SqlConnection()
            conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT NomeIngrediente FROM PedidosDetalhes LEFT JOIN Ingredientes ON PedidosDetalhes.codIngrediente=Ingredientes.codIngrediente WHERE CodPedido =" & Me.ListView1.SelectedItems(0).Text & ""
            cmd.Connection = conn
            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim companyNameParam As New SqlParameter("@companyName", "a%")
            cmd.Parameters.Add(companyNameParam)
            Dim reader As SqlDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                reader = cmd.ExecuteReader()
                Using reader
                    While reader.Read
                        ' Process SprocResults datareader here.
                        Me.TextBox1.Text &= reader("NomeIngrediente") & vbCrLf
                        'With Me.ListView1.Items.Add(reader("CodPedido"))
                        '    .SubItems.Add(reader("DataPedido"))
                        'End With
                    End While
                End Using
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try

            'Dim caminho As String = "C:\Pizzaria\Pedidos\" & Form1.txttelefone.Text & "\" & Me.ListView1.SelectedItems(0).Text & ".txt"
            'Me.TextBox1.Text = My.Computer.FileSystem.ReadAllText(caminho)
        End If
    End Sub
End Class