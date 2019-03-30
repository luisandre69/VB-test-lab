Imports System.Data.SqlClient

Public Class Form1
    Function GetIngrediente(ByVal lvNomeIngrediente As String) As Integer
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT codingrediente FROM Ingredientes " & _
                          "WHERE NomeIngrediente='" & lvNomeIngrediente & "'"
        cmd.Connection = conn

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
                    Return CInt(reader("CodIngrediente"))
                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Function
    Function UserExists(ByVal pTelefone As String) As Boolean
        Dim ReturnValue As Boolean
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Nome FROM Clientes WHERE Telefone='" & Me.txttelefone.Text & "'"
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
                    ReturnValue = True
                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        Return ReturnValue
    End Function
    Dim tamanho As String
    Dim DadosPedidos As String
    Dim CustoTamanho(2) As Single
    Dim TamanhoPizza(2) As RadioButton
    Dim IngredientesCusto(11) As Single
    Dim Ingredientes(11) As CheckBox


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        If MsgBox("Fechar programa?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdatapedido.Text = Now()
        Ingredientes(0) = chkqueijo : IngredientesCusto(0) = CType(txtqueijo.Text, Single)
        Ingredientes(1) = chkcogumelos : IngredientesCusto(1) = CType(txtcogumelos.Text, Single)
        Ingredientes(2) = chkazeitonas : IngredientesCusto(2) = CType(txtazeitonas.Text, Single)
        Ingredientes(3) = chkcebola : IngredientesCusto(3) = CType(txtcebola.Text, Single)
        Ingredientes(4) = chkpimentao : IngredientesCusto(4) = CType(txtpimentao.Text, Single)
        Ingredientes(5) = chktomate : IngredientesCusto(5) = CType(txttomate.Text, Single)
        Ingredientes(6) = chkpepperoni : IngredientesCusto(6) = CType(txtpepperoni.Text, Single)
        Ingredientes(7) = chkcababreza : IngredientesCusto(7) = CType(txtcalabreza.Text, Single)
        Ingredientes(8) = chkovo : IngredientesCusto(8) = CType(txtovo.Text, Single)
        Ingredientes(9) = chkpresunto : IngredientesCusto(9) = CType(txtpresunto.Text, Single)
        Ingredientes(10) = chkcamarao : IngredientesCusto(10) = CType(txtcamarao.Text, Single)
        Ingredientes(11) = chkanchovas : IngredientesCusto(11) = CType(txtanchovas.Text, Single)

        TamanhoPizza(0) = rdbpequena : CustoTamanho(0) = CType(txtpequena.Text, Single)
        TamanhoPizza(1) = rdbmedia : CustoTamanho(1) = CType(txtmedia.Text, Single)
        TamanhoPizza(2) = rdbgrande : CustoTamanho(2) = CType(txtgrande.Text, Single)

    End Sub

    Private Sub btncriarpizza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncriarpizza.Click
        Dim tamanho As Integer
        Dim preco As Integer = 1

        For i = 0 To TamanhoPizza.Length - 1
            If TamanhoPizza(i).Checked Then
                tamanho = i + 1
                'mensagem &= TamanhoPizza(i).Text & vbCrLf
                Select Case TamanhoPizza(i).Text
                    Case "Pequena"
                        tamanho = 1
                    Case "Média"
                        tamanho = 2
                    Case "Grande"
                        tamanho = 3
                End Select
                preco += CustoTamanho(i)
            End If
        Next

        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO Pedidos (CodCliente,CodPizza,PrecoTotal,Entregar,Borda,Obs,DataPedido)" & _
        "VALUES('" & Me.txtcodcliente.Text & "'," & tamanho & "," & preco & ",'" & IIf(Me.chkentregar.Checked, 1, 0) & "','" & IIf(Me.chkborda.Checked, 1, 0) & "','" & Me.txtobservacaoencomenda.Text & "','" & Format(Now, "yyyy-MM-dd hh:mm:ss") & "'); SELECT SCOPE_IDENTITY();"
        '" & Me.txtcodcliente.Text & "','" & tamanho & "','" & 
        cmd.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        Dim companyNameParam As New SqlParameter("@companyName", "a%")
        cmd.Parameters.Add(companyNameParam)

        Dim rowCount As Integer
        Dim previousConnectionState As ConnectionState
        previousConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            rowCount = cmd.ExecuteScalar()

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        For i = 0 To Ingredientes.Length - 1
            If Ingredientes(i).Checked Then
                conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO PedidosDetalhes (CodPedido,CodIngrediente) " & _
                                  "VALUES(" & rowCount & "," & GetIngrediente(Ingredientes(i).Text) & ")"

                cmd.Connection = conn
                ' Create a SqlParameter for each parameter in the stored procedure.

                previousConnectionState = conn.State
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If

                    cmd.ExecuteNonQuery()

                    'If rowCount > 0 Then
                    '    MsgBox("Registo criado com sucesso")
                    'End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    If previousConnectionState = ConnectionState.Closed Then
                        conn.Close()
                    End If
                End Try
            End If
            'preco += ingredientescusto(i)
        Next



        'Dim i As Integer
        'Dim mensagem As String
        'Dim total As Single

        'Dim tamanho As Integer

        'mensagem &= "Tamanho" & vbCrLf
        'For i = 0 To TamanhoPizza.Length - 1
        '    If TamanhoPizza(i).Checked Then
        '        'mensagem &= TamanhoPizza(i).Text & vbCrLf
        '        Select Case TamanhoPizza(i).Text
        '            Case "Pequena"
        '                tamanho = 1
        '            Case "Média"
        '                tamanho = 2
        '            Case "Grande"
        '                tamanho = 3
        '        End Select
        '        total += CustoTamanho(i)
        '    End If
        '    'MsgBox(Ingredientes(i).Name & " -- " & Ingredientes(i).Checked)
        'Next

        'mensagem &= "Ingredientes" & vbCrLf
        'For i = 0 To Ingredientes.Length - 1
        '    If Ingredientes(i).Checked Then
        '        mensagem &= Ingredientes(i).Text & vbCrLf
        '        total += IngredientesCusto(i)
        '    End If
        '    'MsgBox(Ingredientes(i).Name & " -- " & Ingredientes(i).Checked)
        'Next

        'mensagem &= "EntregarBorda" & vbCrLf
        'If chkentregar.Checked Then
        '    total += txtentregar.Text
        '    mensagem &= "Entregar" & vbCrLf
        'Else
        '    mensagem &= "" & vbCrLf
        'End If

        'If chkborda.Checked Then
        '    total += txtborda.Text
        '    mensagem &= "Borda" & vbCrLf
        'Else
        '    mensagem &= "" & vbCrLf
        'End If

        'If Me.txtobservacaoencomenda.Text = " " Then
        '    mensagem &= Me.txtobservacaoencomenda.Text & vbCrLf
        'End If

        'If chkdesconto.Checked = True Then
        '    total += (total * Me.txtencargos.Text) - total
        '    mensagem &= "Desconto" & vbCrLf
        'End If

        'If total > 0 Then 'Verifica se existem ingredientes selecionados ou outras checkbox, se existirem mostra uma msgbox com a lista dos ingredientes selecionados
        '    MsgBox(mensagem & vbCrLf & "Total:" & total)

        'Dim conta As String = CInt(Replace(My.Computer.FileSystem.ReadAllText("C:\Pizzaria\pizzaria.ini"), "C", Space(0))) + 1
        'If MsgBox("Pretende gravar pedido?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then 'Pergunta se pretende gravar o pedido
        '    If Not My.Computer.FileSystem.DirectoryExists("C:\Pizzaria\Pedidos\" & Me.txttelefone.Text) Then 'Se o directorio não existir ele cria um
        '        My.Computer.FileSystem.CreateDirectory("C:\Pizzaria\Pedidos\" & Me.txttelefone.Text) 'Criação do directório
        '    End If
        '    'Select Case conta
        '    'Case 0 To 9
        '    'My.Computer.FileSystem.WriteAllText("C:\Pizzaria\Pedidos\" & Me.txttelefone.Text & "\C00" & conta & ".txt", mensagem, False)
        '    'My.Computer.FileSystem.WriteAllText("C:\Pizzaria\pizzaria.ini", conta, False)
        '    'Case 10 To 50
        '    'My.Computer.FileSystem.WriteAllText("C:\Pizzaria\Pedidos\" & Me.txttelefone.Text & "\C0" & conta & ".txt", mensagem, False)
        '    'My.Computer.FileSystem.WriteAllText("C:\Pizzaria\pizzaria.ini", conta, False)
        '    'End Select
        '    conta = "C" & Microsoft.VisualBasic.Right("00" & conta, 4)
        '    My.Computer.FileSystem.WriteAllText("C:\Pizzaria\Pedidos\" & Me.txttelefone.Text & "\" & conta & ".txt", mensagem, False)
        '    My.Computer.FileSystem.WriteAllText("C:\Pizzaria\pizzaria.ini", conta, False)
        'Else
        '    MsgBox("O pedido não foi gravado")
        'End If
        'Else
        '    MsgBox("Pedido não aceite, escolha os ingredientes!", MsgBoxStyle.Critical)
        'End If

    End Sub

    Private Sub btnprocurarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocurarcliente.Click
        'Try
        '    Dim DadosClientes As String = My.Computer.FileSystem.ReadAllText("C:\Pizzaria\Clientes\" & Me.txttelefone.Text & ".txt")

        '    Me.txtnome.Text = Split(DadosClientes, vbCrLf)(1)
        '    Me.txtapelido.Text = Split(DadosClientes, vbCrLf)(2)
        '    Me.txtmorada.Text = Split(DadosClientes, vbCrLf)(3)
        '    Dim codpostal As String = Split(DadosClientes, vbCrLf)(4)
        '    Me.txtpostal.Text = Split(codpostal, Space(1))(0)
        '    Me.txtlocalidade.Text = Split(codpostal, Space(1))(1)
        '    Me.txtobservaçõescliente.Text = Split(DadosClientes, vbCrLf)(5)
        '    Me.txtencargos.Text = Split(DadosClientes, vbCrLf)(6)
        '    Me.txtsigla.Text = sigla(txtlocalidade.Text)
        'Catch ex As Exception
        '    Me.txttelefone.Text = Space(0)
        '    MsgBox("O ficheiro não foi encontrado")
        'End Try

        'Dim conn As New SqlConnection()
        'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Pizza.mdf;Integrated Security=True;User Instance=True"
        Dim conn As New SqlConnection()
        conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Clientes WHERE telefone='" & Me.txttelefone.Text & "'"
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
                    Me.txtcodcliente.Text = reader("CodCliente")
                    Me.txtnome.Text = reader("Nome")
                    Me.txtmorada.Text = reader("Morada")
                    Me.txtapelido.Text = reader("Apelido")
                    Me.txtlocalidade.Text = reader("Localidade")
                    Me.txtpostal.Text = reader("CodPostal")
                    Me.txtobservaçõescliente.Text = reader("Obs")
                    Me.txtsigla.Text = sigla(Me.txtlocalidade.Text)
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        'Dim StrFile As String
        'If Me.txttelefone.Text = "" Or Me.txtnome.Text = "" Or Me.txtapelido.Text = "" Or Me.txtmorada.Text = "" Or Me.txtpostal.Text = "" Or Me.txtobservaçõescliente.Text = "" Then
        '    MsgBox("Preencha todos os campos")
        'Else
        '    If MsgBox("Pretende gravar os dados do cliente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        StrFile = "C003" & vbCrLf & _
        '                txtnome.Text & vbCrLf & _
        '                txtapelido.Text & vbCrLf & _
        '                txtmorada.Text & vbCrLf & _
        '                txtpostal.Text & Space(1) & txtlocalidade.Text & vbCrLf & _
        '                txtobservaçõescliente.Text & vbCrLf & _
        '                txtencargos.Text
        '        My.Computer.FileSystem.WriteAllText("C:\Pizzaria\Clientes\" & Me.txttelefone.Text & ".txt", StrFile, False)
        '    End If
        'End If
        'Dim conn As New SqlConnection()
        'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\pizza.mdf;Integrated Security=True;User Instance=True"
        If UserExists(Me.txttelefone.Text) = False Then
            Dim conn As New SqlConnection()
            conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"


            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Clientes (Nome,Apelido,Morada,CodPostal,Localidade,Obs,Telefone)" & _
                              "VALUES ('" & Me.txtnome.Text & "' , '" & Me.txtapelido.Text & "' , '" & Me.txtmorada.Text & "' , '" & Me.txtpostal.Text & "' , '" & Me.txtlocalidade.Text & "' , '" & Me.txtobservaçõescliente.Text & "' , '" & Me.txttelefone.Text & "')"

            cmd.Connection = conn
            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim companyNameParam As New SqlParameter("@companyName", "a%")
            cmd.Parameters.Add(companyNameParam)

            Dim rowCount As Integer
            Dim previousConnectionState As ConnectionState
            previousConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                rowCount = cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try
        Else
            If MsgBox("Já existe um cliente com o mesmo número de telefone, quer actualizar os dados?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim conn As New SqlConnection()
                conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

                Dim cmd As New SqlCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE Clientes SET Nome='" & Me.txtnome.Text & "' , Apelido='" & Me.txtapelido.Text & "' , Morada='" & Me.txtmorada.Text & "' , Localidade='" & Me.txtlocalidade.Text & "' , CodPostal='" & Me.txtpostal.Text & "' WHERE Telefone='" & Me.txttelefone.Text & "'"
                cmd.Connection = conn
                ' Create a SqlParameter for each parameter in the stored procedure.
                Dim companyNameParam As New SqlParameter("@companyName", "a%")
                cmd.Parameters.Add(companyNameParam)

                Dim rowCount As Integer
                Dim previousConnectionState As ConnectionState
                previousConnectionState = conn.State
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    rowCount = cmd.ExecuteNonQuery()

                Finally
                    If previousConnectionState = ConnectionState.Closed Then
                        conn.Close()
                    End If
                End Try
            End If
        End If

    End Sub

    Function sigla(ByVal plocalidade As String) As String
        Select Case plocalidade
            Case "Funchal"
                Return "Fx"
            Case "Lisboa"
                Return "Lx"
            Case "Porto"
                Return "Opo"
            Case "Porto Santo"
                Return "Pxo"
        End Select

    End Function

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        If MsgBox("Pretende apagar todos os campos?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.txtnome.Text = " "
            Me.txtapelido.Text = " "
            Me.txtmorada.Text = " "
            Me.txtsigla.Text = " "
            Me.txtlocalidade.Text = " "
            Me.txtpostal.Text = " "
            Me.txtobservaçõescliente.Text = " "
            Me.chkdesconto.Checked = False
        End If
    End Sub

    Private Sub btnverpedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverpedidos.Click
        'If Me.txttelefone.Text = Space(0) Then
        '    MsgBox("Não preencheu o campo telefone", MsgBoxStyle.Critical)
        'Else
        '    If Not My.Computer.FileSystem.DirectoryExists("C:\Pizzaria\Pedidos\" & Me.txttelefone.Text) Then
        '        MsgBox("Este cliente não tem pedidos", MsgBoxStyle.Critical)
        '    Else
        '        pedidos.Show()
        '    End If
        'End If
        pedidos.Show()
    End Sub

    Private Sub btnencerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnencerrar.Click
        Limpar()
    End Sub

    Sub Limpar()
        chkanchovas.Checked = False
        chkazeitonas.Checked = False
        chkborda.Checked = False
        chkcababreza.Checked = False
        chkcamarao.Checked = False
        chkcebola.Checked = False
        chkcogumelos.Checked = False
        chkentregar.Checked = False
        chkovo.Checked = False
        chkpepperoni.Checked = False
        chkpimentao.Checked = False
        chkpresunto.Checked = False
        chkqueijo.Checked = False
        chktomate.Checked = False
        rdbpequena.Checked = False
        rdbmedia.Checked = False
        rdbgrande.Checked = False
    End Sub

    Private Sub chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkanchovas.CheckedChanged, chkazeitonas.CheckedChanged, chkborda.CheckedChanged, chkcababreza.CheckedChanged, chkcamarao.CheckedChanged, chkcebola.CheckedChanged, chkcogumelos.CheckedChanged, chkentregar.CheckedChanged, chkovo.CheckedChanged, chkpepperoni.CheckedChanged, chkpimentao.CheckedChanged, chkpresunto.CheckedChanged, chkqueijo.CheckedChanged, chktomate.CheckedChanged
        Dim ctr1 As Double
        Me.TextBox1.Text = ""
        For Each ctr As Control In Me.grpingredientes.Controls
            If TypeOf ctr Is CheckBox Then
                If CType(ctr, CheckBox).Checked = True Then
                    Me.TextBox1.Text &= ctr.Text & vbCrLf
                End If
            End If
        Next
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If MsgBox("Deseja apagar os dados deste cliente?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim conn As New SqlConnection()
            conn.ConnectionString = "Data Source=10.0.0.120\Teste;Initial Catalog=Pizza;Persist Security Info=True;User ID=sa;password=1.admin"

            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Clientes WHERE Telefone='" & Me.txttelefone.Text & "'"
            cmd.Connection = conn
            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim companyNameParam As New SqlParameter("@companyName", "a%")
            cmd.Parameters.Add(companyNameParam)

            Dim rowCount As Integer
            Dim previousConnectionState As ConnectionState
            previousConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                rowCount = cmd.ExecuteNonQuery()

            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try
            Form1_Load(Nothing, Nothing)
        End If
    End Sub
End Class