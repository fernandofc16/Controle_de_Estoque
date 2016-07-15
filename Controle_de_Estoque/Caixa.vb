Option Strict On
Imports MySql.Data.MySqlClient

Public Class Caixa

    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = 1366 ' Initial Width
    Dim IH As Integer = 768 ' Initial Height

    Private Connection As MySqlConnection = New MySqlConnection
    Private Command As MySqlCommand
    Private Reader As MySqlDataReader

    Private ProdutosArray As ArrayList = New ArrayList
    Private PreçosArray As ArrayList = New ArrayList
    Private QuantidadesArray As ArrayList = New ArrayList
    Private ProdutosTotais As ArrayList = New ArrayList
    Private QuantidadesTotais As ArrayList = New ArrayList

    Private i As ListViewItem
    Private index As Integer = 0

    Public id_employee As Integer
    Public userLogged As String
    Public valorTotal As Double = 0
    Public isAdmin As Boolean = False
    Public userLoggedID As Integer
    Public buttonCategoria As String = ""
    Public formaDePagamentoSelecionado As String = "NULL"
    Public FiadoResult As Boolean = False

    Private Sub Caixa_Employee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=maoleio123"

        IW = Me.Width
        IH = Me.Height

        getUserLogged()
        carregarLogoEmpresa()
        userLoggedLabel.Text += " " & userLogged
        ButtonsCategoriasSelect()
        addHandlerToButtons()
        reportAccess("ABERTO")

    End Sub

    Private Sub Caixa_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        getUserLogged()

    End Sub

    Private Sub Caixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If Me.codigoTextBox.Focused = False Then
            codigoTextBox.Focus()
            codigoTextBox.Text = e.KeyChar.ToString
            codigoTextBox.SelectionStart = codigoTextBox.Text.Length
            e.Handled = True
        End If

    End Sub

    Private Sub Caixa_Employee_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize

        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height
        Dim arrayButtons As Array = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12}

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        Select Case (Me.Width)
            Case 1920
                Me.Produto.Width = 450
                Me.Preço.Width = 197
                Me.Quantidade.Width = 190
                userLoggedLabel.Font = New Font("Microsoft Sans Serif", 30.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                finalizarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaConsultaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCancelButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaFecharButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                resetarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                retiradaCaixaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaValorTotal.Font = New Font("Microsoft Sans Serif", 55.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                valorTotalTextBox.Font = New Font("Microsoft Sans Serif", 55.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCodigoBarra.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaQuantidade.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                codigoTextBox.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                quantidadeNumericUpDown.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                produtosListView.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each button As Button In arrayButtons
                    button.Font = New Font("Microsoft Sans Serif", 14.5!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            Case 1680
                Me.Produto.Width = 370
                Me.Preço.Width = 185
                Me.Quantidade.Width = 185
                userLoggedLabel.Font = New Font("Microsoft Sans Serif", 30.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                finalizarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaConsultaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCancelButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaFecharButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                retiradaCaixaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                resetarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaValorTotal.Font = New Font("Microsoft Sans Serif", 47.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                valorTotalTextBox.Font = New Font("Microsoft Sans Serif", 47.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCodigoBarra.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaQuantidade.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                codigoTextBox.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                quantidadeNumericUpDown.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                produtosListView.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each button As Button In arrayButtons
                    button.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            Case 1600
                Me.Produto.Width = 350
                Me.Preço.Width = 180
                Me.Quantidade.Width = 180
                userLoggedLabel.Font = New Font("Microsoft Sans Serif", 30.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                finalizarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaConsultaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCancelButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                retiradaCaixaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaFecharButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                resetarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaValorTotal.Font = New Font("Microsoft Sans Serif", 47.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                valorTotalTextBox.Font = New Font("Microsoft Sans Serif", 47.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCodigoBarra.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaQuantidade.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                codigoTextBox.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                quantidadeNumericUpDown.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                produtosListView.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each button As Button In arrayButtons
                    button.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            Case 1440
                Me.Produto.Width = 330
                Me.Preço.Width = 170
                Me.Quantidade.Width = 170
                userLoggedLabel.Font = New Font("Microsoft Sans Serif", 28.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                finalizarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaConsultaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCancelButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                retiradaCaixaButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaFecharButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                resetarButton.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaValorTotal.Font = New Font("Microsoft Sans Serif", 45.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                valorTotalTextBox.Font = New Font("Microsoft Sans Serif", 45.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCodigoBarra.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaQuantidade.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                codigoTextBox.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                quantidadeNumericUpDown.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                produtosListView.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each button As Button In arrayButtons
                    button.Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            Case 1366
                Me.Produto.Width = 300
                Me.Preço.Width = 150
                Me.Quantidade.Width = 150
                userLoggedLabel.Font = New Font("Microsoft Sans Serif", 25.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                finalizarButton.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaConsultaButton.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCancelButton.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                retiradaCaixaButton.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaFecharButton.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                resetarButton.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaValorTotal.Font = New Font("Microsoft Sans Serif", 40.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                valorTotalTextBox.Font = New Font("Microsoft Sans Serif", 40.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCodigoBarra.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaQuantidade.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                codigoTextBox.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                quantidadeNumericUpDown.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                produtosListView.Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each button As Button In arrayButtons
                    button.Font = New Font("Microsoft Sans Serif", 11.5!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            Case 1280
                Me.Produto.Width = 285
                Me.Preço.Width = 135
                Me.Quantidade.Width = 135
                userLoggedLabel.Font = New Font("Microsoft Sans Serif", 23.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                finalizarButton.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaConsultaButton.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCancelButton.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                retiradaCaixaButton.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaFecharButton.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                resetarButton.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaValorTotal.Font = New Font("Microsoft Sans Serif", 35.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                valorTotalTextBox.Font = New Font("Microsoft Sans Serif", 35.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaCodigoBarra.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                CaixaQuantidade.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                codigoTextBox.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                quantidadeNumericUpDown.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                produtosListView.Font = New Font("Microsoft Sans Serif", 13.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each button As Button In arrayButtons
                    button.Font = New Font("Microsoft Sans Serif", 10.5!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            Case 1024
                Me.Produto.Width = 250
                Me.Preço.Width = 100
                Me.Quantidade.Width = 100
        End Select

        CW = Me.Width
        CH = Me.Height

    End Sub

    Private Sub Caixa_Employee_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Closed

        reportAccess("FECHADO")
        setUserDislogged()
        Form_Admin.Show()

    End Sub

    Private Sub Caixa_Employee_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F1
                Forma_de_Pagamento.ShowDialog()
                finalizarCompra()
            Case Keys.F12
                Loading.ShowDialog()
                Dispose()
            Case Keys.F11
                reset()
            Case Keys.F2
                Consulta.ShowDialog()
            Case Keys.F3
                cancelItem()

        End Select

    End Sub

    Private Sub getUserLogged()

        Dim Query As String = "SELECT id, nomeUser, isAdmin FROM login WHERE userIsLogged = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                userLoggedID = CInt(Reader.GetValue(0))
                userLogged = Reader.GetValue(1).ToString
                isAdmin = Reader.GetBoolean(2)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub setUserDislogged()

        If Not isAdmin Then
            Dim Query As String = "UPDATE login SET userIsLogged = 0 WHERE userIsLogged = 1;"
            Command = New MySqlCommand(Query, Connection)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                Connection.Close()
            End Try
        End If

    End Sub

    Private Sub carregarLogoEmpresa()

        Dim Query As String = "SELECT image_logo FROM logo_empresa WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                logoEmpresaPictureBox.Image = resizeImage(logoEmpresaPictureBox.Width, logoEmpresaPictureBox.Height, Byte2Image(CType(Reader.GetValue(0), Byte())))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub UpdateListView()

        produtosListView.Items.Clear()

        produtosListView.BeginUpdate()
        index = 0

        For Each Produto As String In ProdutosArray
            i = produtosListView.Items.Add(Produto)
            i.SubItems.Add(Format(CDec(PreçosArray.Item(index)), "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##"))
            i.SubItems.Add("x" & QuantidadesArray.Item(index).ToString)
            index += 1
        Next

        produtosListView.Update()
        produtosListView.EndUpdate()

    End Sub

    Private Sub reportAccess(condition As String)

        Dim Query As String = ""

        Select Case condition
            Case "ABERTO"
                Query = "INSERT INTO report_access VALUES(NULL, @userLogged, @dateTime, @hourTime, NULL, NULL);"
            Case "FECHADO"
                Query = "UPDATE report_access SET userLogged = @userLogged, data_fechado = @dateTime, hora_fechado = @hourTime WHERE id = LAST_INSERT_ID();"
        End Select

        Command = New MySqlCommand(Query, Connection)

        If userLogged = "" Then
            Command.Parameters.AddWithValue("@userLogged", "Administrador")
        Else
            Command.Parameters.AddWithValue("@userLogged", userLogged)
        End If

        Command.Parameters.AddWithValue("@dateTime", Date.Now.ToString("dd/MM/yyyy"))
        Command.Parameters.AddWithValue("@hourTime", Date.Now.ToString("HH:mm:ss"))

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub codigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles codigoTextBox.TextChanged

        If codigoTextBox.Text.Trim <> "" Then
            Dim Query As String = "SELECT nome, preco, quantidade, validade FROM produtos WHERE codigo_de_barra = @codigo;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@codigo", codigoTextBox.Text)

            If (quantidadeNumericUpDown.Value = 0) Then
                quantidadeNumericUpDown.Value = 1
            End If

            Try
                Connection.Open()
                Reader = Command.ExecuteReader()

                While Reader.Read()

                    If Reader.GetValue(2).Equals(0) Then
                        MsgBox("Produto Esgotado")
                        codigoTextBox.Text = ""
                        Exit Sub
                    End If

                    If CDate(Reader.GetString(3) & " 00:00:00") <= Now() Then
                        MsgBox("Produto com prazo de validade vencido")
                        codigoTextBox.Text = ""
                        Exit Sub
                    End If

                    If ProdutosArray.Contains(Reader.GetString(0)) Then
                        QuantidadesArray.Item(ProdutosArray.IndexOf(Reader.GetString(0))) = CInt(QuantidadesArray.Item(ProdutosArray.IndexOf(Reader.GetString(0)))) + quantidadeNumericUpDown.Value
                        codigoTextBox.SelectAll()
                    Else
                        ProdutosArray.Add(Reader.GetString(0))
                        PreçosArray.Add(Reader.GetString(1))
                        QuantidadesArray.Add(quantidadeNumericUpDown.Value)
                        codigoTextBox.SelectAll()
                    End If
                End While

            Catch ex As MySqlException
                MsgBox(ex.Message)
                Exit Sub
            Finally
                Reader.Close()
                Connection.Close()
                quantidadeNumericUpDown.Value = 0
                UpdateListView()
                UpdateTotal()
            End Try
        End If

    End Sub

    Private Sub finalizarButton_Click(sender As Object, e As EventArgs) Handles finalizarButton.Click

        Forma_de_Pagamento.ShowDialog()
        finalizarCompra()

    End Sub

    Private Sub finalizarCompra()

        If Forma_de_Pagamento.fechou Then
            Exit Sub
        End If

        If formaDePagamentoSelecionado = "Fiado" And Not FiadoResult Then
            Exit Sub
        Else
            FiadoResult = False
        End If

        Dim Query As String = "INSERT INTO faturamentos VALUES(NULL, @valor, @date, @hour, @isDel, @forma_de_pagamento, @pk_employee, 0, @employee_sold);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@valor", CDbl(Replace(valorTotalTextBox.Text, "R$ ", "")))
        Command.Parameters.AddWithValue("@date", Date.Now.ToString("dd/MM/yyyy"))
        Command.Parameters.AddWithValue("@hour", Date.Now.ToString("HH:mm:ss"))
        Command.Parameters.AddWithValue("@employee_sold", userLogged)
        If formaDePagamentoSelecionado = "Fiado" Then
            Command.Parameters.AddWithValue("@isDel", 0)
        Else
            Command.Parameters.AddWithValue("@isDel", 1)
        End If
        Command.Parameters.AddWithValue("@forma_de_pagamento", formaDePagamentoSelecionado)
        If formaDePagamentoSelecionado = "Fiado" Then
            Command.Parameters.AddWithValue("@pk_employee", id_employee)
        Else
            Command.Parameters.AddWithValue("@pk_employee", DBNull.Value)
        End If

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        index = 0
        Dim lastInsertID As Integer = 0
        Query = "SELECT LAST_INSERT_ID();"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                lastInsertID = CInt(Reader.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        For Each produto As String In ProdutosArray

            Query = "INSERT INTO vendas VALUES(NULL, @produto, @quantidade, @idFat);"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@produto", produto.ToString)
            Command.Parameters.AddWithValue("@quantidade", QuantidadesArray.Item(index).ToString)
            Command.Parameters.AddWithValue("@idFat", lastInsertID)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                Connection.Close()
            End Try

            If QuantidadesArray.Item(index).ToString.Trim <> "" Then

                Dim idProduct As String = ""
                Dim quantidade As String = ""
                Query = "SELECT id, quantidade FROM produtos WHERE nome = @nome;"
                Command = New MySqlCommand(Query, Connection)
                Command.Parameters.AddWithValue("@nome", produto)

                Try
                    Connection.Open()
                    Reader = Command.ExecuteReader
                    While Reader.Read
                        idProduct = CStr(Reader.GetValue(0))
                        If Reader.GetValue(1) IsNot DBNull.Value Then
                            quantidade = CStr(Reader.GetValue(1))
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Reader.Close()
                    Connection.Close()
                End Try

                If quantidade.Trim <> "" Then

                    Dim quantidadeDoProdutoVendido As Integer = CInt(QuantidadesArray.Item(index))

                    While quantidadeDoProdutoVendido <> 0
                        Dim quantidadeLote1 As Integer = 0
                        Query = "SELECT quantidade FROM produtos_lotes WHERE produtos_fk = @id AND lote_number = 1;"
                        Command = New MySqlCommand(Query, Connection)
                        Command.Parameters.AddWithValue("@id", idProduct)

                        Try
                            Connection.Open()
                            Reader = Command.ExecuteReader
                            While Reader.Read
                                If Reader.GetValue(0) IsNot DBNull.Value Then
                                    If Reader.GetValue(0).ToString.Trim <> "" Then
                                        quantidadeLote1 = CInt(Reader.GetValue(0))
                                    End If
                                End If
                            End While
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        Finally
                            Connection.Close()
                        End Try

                        If quantidadeDoProdutoVendido <= quantidadeLote1 Then
                            quantidadeLote1 -= quantidadeDoProdutoVendido
                            quantidadeDoProdutoVendido = 0
                        Else
                            quantidadeDoProdutoVendido -= quantidadeLote1
                            quantidadeLote1 = 0
                        End If

                        Query = "UPDATE produtos_lotes SET quantidade = @newQuant WHERE produtos_fk = @id AND lote_number = 1;"
                        Command = New MySqlCommand(Query, Connection)
                        Command.Parameters.AddWithValue("@newQuant", quantidadeLote1)
                        Command.Parameters.AddWithValue("@id", idProduct)

                        Try
                            Connection.Open()
                            Command.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            Connection.Close()
                        End Try

                        checkLoteQuantTrocaSePrecisar(idProduct)

                    End While

                End If

            End If

                index += 1

        Next

        reset()

    End Sub

    Private Sub reset()

        produtosListView.Items.Clear()
        quantidadeNumericUpDown.Value = 0
        codigoTextBox.Text = ""
        valorTotalTextBox.Text = "R$ 0,00"
        ProdutosArray.Clear()
        QuantidadesArray.Clear()
        PreçosArray.Clear()

    End Sub

    Private Sub resetarButton_Click(sender As Object, e As EventArgs) Handles resetarButton.Click
        reset()
    End Sub

    Private Sub UpdateTotal()

        Dim total As Double = 0
        index = 0

        For Each Preço As Double In PreçosArray

            total += Preço * CInt(QuantidadesArray.Item(index))
            index += 1

        Next

        If total <> 0 Then
            valorTotalTextBox.Text = Format(total, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")
        Else
            valorTotalTextBox.Text = "R$ 0,00"
        End If

        valorTotal = total

    End Sub

    Private Sub fecharButton_Click_1(sender As Object, e As EventArgs) Handles CaixaFecharButton.Click

        reportAccess("FECHADO")
        Loading.ShowDialog()
        Me.Dispose()
        setUserDislogged()
        Form_Admin.Show()

    End Sub

    Private Sub consultaButton_Click_1(sender As Object, e As EventArgs) Handles CaixaConsultaButton.Click
        Consulta.ShowDialog()
    End Sub

    Private Sub cancelItem()
        If (ProdutosArray.Count <> 0) Then
            If (CInt(QuantidadesArray(QuantidadesArray.Count - 1)) > 1) Then
                QuantidadesArray(QuantidadesArray.Count - 1) = CInt(QuantidadesArray(QuantidadesArray.Count - 1)) - 1
                UpdateListView()
                UpdateTotal()
            Else
                ProdutosArray.RemoveAt(ProdutosArray.Count - 1)
                PreçosArray.RemoveAt(PreçosArray.Count - 1)
                QuantidadesArray.RemoveAt(QuantidadesArray.Count - 1)
                UpdateListView()
                UpdateTotal()
            End If
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles CaixaCancelButton.Click
        cancelItem()
    End Sub

    Private Function resizeImage(width As Integer, heigth As Integer, imageToResize As Image) As Image

        Dim bm_source As New Bitmap(imageToResize)
        Dim bm_dest As New Bitmap(width, heigth)
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
        gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1)

        Return bm_dest

    End Function

    Private Function Byte2Image(ByVal byteArr() As Byte) As Image

        Using ImageStream As New IO.MemoryStream(byteArr)
            Dim newImage As Image
            Try
                If byteArr.GetUpperBound(0) > 0 Then
                    newImage = Image.FromStream(ImageStream)
                Else
                    newImage = Nothing
                End If
            Catch ex As Exception
                newImage = Nothing
            End Try
            Return newImage
        End Using

    End Function

    Private Sub ButtonsCategoriasSelect()

        Dim arrayCategorias As ArrayList = New ArrayList
        Dim texto As String = ""
        Dim Query As String = "SELECT nome_categoria, useName, image_categoria FROM categorias_combo_box;"
        Dim arrayButtons() As Button = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, Button11, Button12}
        Command = New MySqlCommand(Query, Connection)
        Dim indexButton = 0

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            Dim index = 0
            While Reader.Read()
                If Reader.GetBoolean(1) Then
                    arrayButtons(index).Text = Reader.GetValue(0).ToString
                    arrayButtons(index).Image = resizeImage(arrayButtons(index).Width, arrayButtons(index).Height - 30, Byte2Image(CType(Reader.GetValue(2), Byte())))
                Else
                    arrayButtons(index).Image = resizeImage(arrayButtons(index).Width, arrayButtons(index).Height, Byte2Image(CType(Reader.GetValue(2), Byte())))
                End If
                arrayCategorias.Add(Reader.GetValue(0).ToString)
                index += 1
            End While

            If index <> 12 Then
                While index <> 12
                    arrayButtons(index).Enabled = False
                    index += 1
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim indexCat As Integer = 0
        For Each categoria As String In arrayCategorias

            Dim numeroProdutosNaCategoria As Integer = 0
            Query = "SELECT COUNT(*) FROM categoria_produtos WHERE categoria = @cat GROUP BY categoria;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@cat", categoria)
            Try
                Connection.Open()
                Reader = Command.ExecuteReader()

                While Reader.Read()
                    If Reader.GetValue(0) IsNot DBNull.Value Then
                        numeroProdutosNaCategoria = CInt(Reader.GetValue(0))
                    Else
                        numeroProdutosNaCategoria = 0
                    End If
                End While

                If numeroProdutosNaCategoria.Equals(0) Then
                    arrayButtons(indexCat).Enabled = False
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

            If numeroProdutosNaCategoria = 1 Then

                Query = "SELECT produtos.quantidade, produtos.validade FROM categoria_produtos JOIN produtos ON id = produto WHERE categoria = @cat;"
                Command = New MySqlCommand(Query, Connection)
                Command.Parameters.AddWithValue("@cat", categoria)

                Try
                    Connection.Open()
                    Reader = Command.ExecuteReader()

                    While Reader.Read()
                        If Reader.GetValue(0).Equals(0) Then
                            arrayButtons(indexCat).Enabled = False
                        ElseIf Reader.GetString(1) <> "" Then
                            If CDate(Reader.GetString(1) & " 00:00:00") < Now() Then
                                arrayButtons(indexCat).Enabled = False
                            End If
                        End If
                    End While

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Reader.Close()
                    Connection.Close()
                End Try

            End If

            numeroProdutosNaCategoria = 0
            indexCat += 1
        Next

    End Sub

    Private Sub buttonCategoriaSelected(ByVal buttonNumber As Integer, ByVal btn As Button)

        Dim arrayListCategories As New ArrayList
        Dim Query As String = "SELECT nome_categoria FROM categorias_combo_box;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()

                arrayListCategories.Add(Reader.GetValue(0))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        buttonCategoria = arrayListCategories.Item(buttonNumber).ToString
        Produtos_Categoria.buttonClickedCategorie = btn
        Produtos_Categoria.ShowDialog()

    End Sub

    Private Sub addHandlerToButtons()

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is Button And CInt(ctl.Tag) <20 Then
                AddHandler ctl.Click, AddressOf Button_Click
            End If
        Next

    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim btn As Button = CType(sender, Button)
        buttonCategoriaSelected(CInt(btn.Tag), btn)

    End Sub

    Public Function addProdutosToListQuant(ByVal nome As String, ByVal preço As String, ByVal quantidadeEstoque As Integer) As Boolean

        Dim ret As Boolean = False
        If ProdutosArray.Contains(nome) Then
            If quantidadeEstoque - (CInt(QuantidadesArray.Item(ProdutosArray.IndexOf(nome))) + 1) = 0 Then
                ret = True
            End If
            QuantidadesArray.Item(ProdutosArray.IndexOf(nome)) = CInt(QuantidadesArray.Item(ProdutosArray.IndexOf(nome))) + 1
        Else
            If quantidadeEstoque - 1 = 0 Then
                ret = True
            End If
            ProdutosArray.Add(nome)
            PreçosArray.Add(preço)
            QuantidadesArray.Add(1)
        End If

        UpdateListView()
        UpdateTotal()
        Return ret

    End Function

    Public Sub addProdutosToList(ByVal nome As String, ByVal preço As String)

        If ProdutosArray.Contains(nome) Then
            QuantidadesArray.Item(ProdutosArray.IndexOf(nome)) = CInt(QuantidadesArray.Item(ProdutosArray.IndexOf(nome))) + 1
        Else
            ProdutosArray.Add(nome)
            PreçosArray.Add(preço)
            QuantidadesArray.Add(1)
        End If

        UpdateListView()
        UpdateTotal()

    End Sub

    Public Function checkQuantidadeDoProdutoNaListaDeCompra(ByVal produto As String) As Integer

        If (ProdutosArray.Contains(produto)) Then
            Return CInt(QuantidadesArray(ProdutosArray.IndexOf(produto)))
        Else
            Return 0
        End If

    End Function

    Private Sub checkLoteQuantTrocaSePrecisar(ByVal idProduto As String)

        Dim quantidade As Integer = 0
        Dim Query As String = "SELECT quantidade FROM produtos_lotes WHERE lote_number = 1 AND produtos_fk = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", idProduto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                If Reader.GetValue(0) IsNot DBNull.Value Then
                    quantidade = CInt(Reader.GetValue(0))
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If quantidade.Equals(0) Then

            Dim count As Integer = 0
            Query = "SELECT COUNT(*) FROM produtos_lotes WHERE produtos_fk = @id;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", idProduto)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader()
                While Reader.Read
                    count = CInt(Reader.GetValue(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

            Dim loteNumber As Integer = 1
            While count <> 0

                Query = "UPDATE produtos_lotes SET lote_number = @number WHERE produtos_fk = @id AND lote_number = @oldLote;"
                Command = New MySqlCommand(Query, Connection)
                Command.Parameters.AddWithValue("@oldLote", loteNumber + 1)
                Command.Parameters.AddWithValue("@number", loteNumber)
                Command.Parameters.AddWithValue("@id", idProduto)

                Try
                    Connection.Open()
                    Command.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Connection.Close()
                End Try

                loteNumber += 1
                count -= 1

            End While

            Query = "DELETE FROM produtos_lotes WHERE produtos_fk = @id AND quantidade = 0;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", idProduto)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try

        End If

        Dim quantidadeTotalDoProduto As Integer = 0
        Query = "SELECT SUM(quantidade) FROM produtos_lotes WHERE produtos_fk = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", idProduto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                If Reader.GetValue(0) IsNot DBNull.Value Then
                    quantidadeTotalDoProduto = CInt(Reader.GetValue(0))
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Dim validadeLote1 As String = ""
        Query = "SELECT validade FROM produtos_lotes WHERE produtos_fk = @id AND lote_number = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", idProduto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                validadeLote1 = CStr(Reader.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Query = "UPDATE produtos SET quantidade = @quantidade, validade = @validade WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@validade", validadeLote1)
        Command.Parameters.AddWithValue("@quantidade", quantidadeTotalDoProduto)
        Command.Parameters.AddWithValue("@id", idProduto)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles retiradaCaixaButton.Click
        Retirada_Pagamentos.funcRetirada = userLogged
        Retirada_Pagamentos.ShowDialog()
    End Sub

End Class
