Imports MySql.Data.MySqlClient

Public Class Form_Admin

    Private Command As MySqlCommand
    Private Connection As New MySqlConnection
    Private Reader, Reader2 As MySqlDataReader
    Private emailLogin As String
    Private rowIndex As Integer
    Private produtoFromCategoriaSelected As String
    Private mstream As IO.MemoryStream = New IO.MemoryStream
    Private idEmployee As Integer
    Private employeeFiadoSelected As Integer = 0
    Private categoriaSelected As Integer = 0
    Public userLogged As String

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=maoleio123"

        requestFormasDePgamentosComboBox()
        requestProdutosComboBox()
        requestCategoriasComboBox()
        requestProdutos()
        buscarInfosConfigs()
        buscarEmployeeInfos()
        requestReportUsers()
        funcionariosCadastradosSistemaFiadoEComboBoxFunc()

        For Each Column As DataGridViewColumn In produtosDataGridView.Columns
            Column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each Column As DataGridViewColumn In employeeInfoDataGridView.Columns
            Column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each Column As DataGridViewColumn In reportAccessDataGridView.Columns
            Column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each Column As DataGridViewColumn In produtosCategoriasDataGridView.Columns
            Column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each Column As DataGridViewColumn In produtosEQuantidadesFiadoDataGridView.Columns
            Column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Private Sub Form_Admin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed

        setUserDislogged()
        atualizarInfoAdmin()
        Login.Dispose()

    End Sub

    Private Sub Form_Admin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        requestProdutos()
        requestReportUsers()
        funcionariosCadastradosSistemaFiadoEComboBoxFunc()
    End Sub

    Private Sub setUserDislogged()

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

    End Sub

    Private Sub buscarUsuariosConfig()

        Dim Query As String = "SELECT nomeUser, user, password, lastDateLogged, id FROM login WHERE isAdmin = 0;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                Me.employeeInfoDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(2), Reader.GetValue(3), Reader.GetValue(4))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        employeeInfoDataGridView.ClearSelection()

    End Sub

    Private Sub buscarInfosConfigs()

        Dim Query As String = "SELECT nomeUser, user, password, email, emailType FROM login WHERE isAdmin = true;"
        Command = New MySqlCommand(Query, Connection)

        Try

            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()

                nomeAdminTextBox.Text = Reader.GetString(0)
                userAdminTextBox.Text = Reader.GetString(1)
                senhaAdminTextBox.Text = Reader.GetString(2)
                emailSystemTextBox.Text = Reader.GetValue(3).ToString
                SMTPHostComboBox.SelectedItem = Reader.GetValue(4).ToString

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "SELECT report_option FROM report_option WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                Select Case Reader.GetInt32(0)
                    Case 1
                        completoRelatorioRadioButton.Checked = True
                    Case 0
                        resumoRelatorioRadioButton.Checked = True
                End Select
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "SELECT image_logo FROM logo_empresa WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                logoEmpresaPictureBox.Image = Byte2Image(CType(Reader.GetValue(0), Byte()))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub requestReportUsers()

        reportAccessDataGridView.Rows.Clear()

        Dim Query As String = "SELECT * FROM controle_de_estoque.report_access;"
        Command = New MySqlCommand(Query, Connection)

        Try

            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                Me.reportAccessDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(2), Reader.GetValue(3), Reader.GetValue(4), Reader.GetValue(5))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub atualizarInfoAdmin()

        Dim Query As String = "UPDATE login SET nomeUser = @NewnomeUser, user = @NewUser, password = @NewPassword, email = @NewEmail, emailType = @NewemailType WHERE isAdmin = true;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@NewnomeUser", nomeAdminTextBox.Text)
        Command.Parameters.AddWithValue("@NewUser", userAdminTextBox.Text)
        Command.Parameters.AddWithValue("@NewPassword", senhaAdminTextBox.Text)
        Command.Parameters.AddWithValue("@NewEmail", emailSystemTextBox.Text)
        Command.Parameters.AddWithValue("@NewemailType", SMTPHostComboBox.SelectedItem.ToString)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub showPasswordAdminCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles showPasswordAdminCheckBox.CheckedChanged

        If showPasswordAdminCheckBox.Checked Then
            senhaAdminTextBox.PasswordChar = ""
        Else
            senhaAdminTextBox.PasswordChar = "*"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles openCaixaButton.Click

        Me.Hide()
        Caixa.isAdmin = True
        Caixa.Show()

    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click

        Dim Query As String = "INSERT INTO employee VALUES(NULL, @nome, @rg, @cpf, @address, @telefone, @celular, @foto, NULL);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", nomeEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@rg", rgEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@cpf", cpfEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@address", endereçoEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@telefone", telefoneResidencialEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@celular", telefoneCelularEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@foto", parseImageBox_Image_To_ByteArray(fotoEmployeePictureBox))

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()
        limparCamposFuncionarioCad()
        employeeInfoDataGridView.Rows.Clear()
        buscarEmployeeInfos()

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim Query As String = "DELETE FROM employee WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("id", idEmployeeTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Catch exOnUpdate As MySqlException
            MsgBox("Antes de deletar o funcionário elimine as compras pendentes do mesmo.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        Dim count As Integer = 0
        Query = "SELECT COUNT(nomeUser) FROM login WHERE id_employee = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("id", idEmployeeTextBox.Text)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                count = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        If count > 0 Then
            Query = "DELETE FROM login WHERE id_employee = @id"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("id", idEmployeeTextBox.Text)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
        End If

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()
        limparCamposFuncionarioCad()
        employeeInfoDataGridView.Rows.Clear()
        buscarEmployeeInfos()

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click


        Dim Query As String = "UPDATE employee SET Name = @nome, RG = @rg, CPF = @cpf, Address = @address, Telefone = @telefone, Celular = @celular, Foto = @foto WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", nomeEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@rg", rgEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@cpf", cpfEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@address", endereçoEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@telefone", telefoneResidencialEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@celular", telefoneCelularEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@foto", parseImageBox_Image_To_ByteArray(fotoEmployeePictureBox))
        Command.Parameters.AddWithValue("id", idEmployeeTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        limparCamposFuncionarioCad()
        employeeInfoDataGridView.Rows.Clear()
        buscarEmployeeInfos()

    End Sub

    Private Sub cleanEmployeeButton_Click(sender As Object, e As EventArgs) Handles cleanEmployeeButton.Click
        limparCamposFuncionarioCad()
    End Sub

    Private Sub buscarEmployeeInfos()

        Dim Query As String = "SELECT id, Name, RG, CPF, Address, Telefone, Celular FROM employee;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read

                employeeInfoDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(2), Reader.GetValue(3), Reader.GetValue(4), Reader.GetValue(5), Reader.GetValue(6))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub limparCamposFuncionarioCad()

        employeeInfoDataGridView.ClearSelection()
        idEmployeeTextBox.Text = ""
        nomeEmployeeTextBox.Text = ""
        rgEmployeeTextBox.Text = ""
        cpfEmployeeTextBox.Text = ""
        endereçoEmployeeTextBox.Text = ""
        telefoneResidencialEmployeeTextBox.Text = ""
        telefoneCelularEmployeeTextBox.Text = ""
        fotoEmployeePictureBox.Image = My.Resources.ResourceManager.GetObject("default_profile_photo")

    End Sub

    Private Sub employeeInfoDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles employeeInfoDataGridView.CellMouseClick

        If (e.RowIndex >= 0) Then
            idEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(0).Value
            nomeEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(1).Value
            rgEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(2).Value
            cpfEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(3).Value
            endereçoEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(4).Value
            telefoneResidencialEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(5).Value
            telefoneCelularEmployeeTextBox.Text = employeeInfoDataGridView.Rows(e.RowIndex).Cells(6).Value

            Dim Query As String = "SELECT foto FROM employee WHERE id = @id;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", employeeInfoDataGridView.Rows(e.RowIndex).Cells(0).Value)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader()
                While Reader.Read
                    fotoEmployeePictureBox.Image = Byte2Image(Reader.GetValue(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Reader.Close()
                Connection.Close()
            End Try
        End If

    End Sub

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

    Private Sub removerButton_Click(sender As Object, e As EventArgs) Handles removerButton.Click

        For Each row As DataGridViewRow In reportAccessDataGridView.Rows

            If (row.Selected = True) Then
                Dim Query As String = "DELETE FROM report_access WHERE id = @id;"
                Command = New MySqlCommand(Query, Connection)
                Command.Parameters.AddWithValue("@id", row.Cells(0).Value)

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

        Next

        reportAccessDataGridView.Rows.Clear()
        requestReportUsers()

    End Sub

    Private Sub searchReportTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchReportTextBox.TextChanged

        Dim index As Integer

        Select Case (True)
            Case nomesRadioButton.Checked
                index = 1
            Case datasRadioButton.Checked
                index = 2
        End Select

        reportAccessDataGridView.ClearSelection()

        For Each row As DataGridViewRow In reportAccessDataGridView.Rows
            If (row.Cells(index).Value.ToString = searchReportTextBox.Text) Then
                row.Selected = True
                searchReportTextBox.SelectAll()
            End If
        Next

    End Sub

    Public Sub requestProdutos()

        produtosDataGridView.Rows.Clear()

        Dim arrayIds As New ArrayList
        Dim Query As String = "SELECT * FROM produtos;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read

                arrayIds.Add(Reader.GetValue(0))
                produtosDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Format(CDbl(Reader.GetValue(2)), "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;"), Reader.GetValue(3), Reader.GetValue(4), Reader.GetValue(5), Reader.GetValue(6), Reader.GetValue(7))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        checkMinEstoque()

    End Sub

    Private Sub registerProdButton_Click(sender As Object, e As EventArgs) Handles registerProdButton.Click

        If nomeProdTextBox.Text.Trim = "" Then
            MsgBox("O campo 'nome' do produto não pode estar vazio")
            Exit Sub
        End If

        If preçoProdTextBox.Text.Trim = "" Then
            MsgBox("O campo 'preço' do produto não pode estar vazio")
            Exit Sub
        End If

        Try
            Dim Dataaaa As Date = CDate(validadeProdTextBox.Text & " 00:00:00")
        Catch ex As Exception
            MsgBox("Formato ou data inválido no campo de validade." & vbNewLine & "Por favor utilize o formato a seguir: dd/MM/yyyy")
            Exit Sub
        End Try

        Dim Query As String = "INSERT INTO produtos VALUES(NULL, @nome, @preço, @estoque_min, @codigo_barra, @quantidade, @dataValidade, @data_att, @image, 0, 0, 0);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", nomeProdTextBox.Text)

        If preçoProdTextBox.Text.Trim <> "" Then
            Command.Parameters.AddWithValue("@preço", preçoProdTextBox.Text.Replace("R$", "").Trim)
        Else
            Command.Parameters.AddWithValue("@preço", "0,00")
        End If

        If estoqueMinProdTextBox.Text.Trim <> "" Then
            Command.Parameters.AddWithValue("@estoque_min", estoqueMinProdTextBox.Text)
        Else
            Command.Parameters.AddWithValue("@estoque_min", DBNull.Value)
        End If

        Command.Parameters.AddWithValue("@codigo_barra", codigoBarraProdTextBox.Text)

        If quantidadeProdTextBox.Text.Trim <> "" Then
            Command.Parameters.AddWithValue("@quantidade", quantidadeProdTextBox.Text)
        Else
            Command.Parameters.AddWithValue("@quantidade", DBNull.Value)
        End If

        Command.Parameters.AddWithValue("@dataValidade", validadeProdTextBox.Text)
        Command.Parameters.AddWithValue("@data_att", Format(Now(), "dd/MM/yyyy"))
        Command.Parameters.AddWithValue("@image", parseImageBox_Image_To_ByteArray(produtoPictureBox))

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        If quantidadeProdTextBox.Text.Trim <> "" And validadeProdTextBox.Text.Trim <> "" Then
            Query = "INSERT INTO produtos_lotes VALUES (NULL, LAST_INSERT_ID(), 1, @validade, @quantidade)"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@validade", validadeProdTextBox.Text)
            If quantidadeProdTextBox.Text.Trim <> "" Then
                Command.Parameters.AddWithValue("@quantidade", quantidadeProdTextBox.Text)
            Else
                Command.Parameters.AddWithValue("@quantidade", DBNull.Value)
            End If

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
        End If

        cleanProdText()
        produtosDataGridView.Rows.Clear()
        requestProdutos()
        requestProdutosComboBox()

    End Sub

    Private Sub updateProdButton_Click(sender As Object, e As EventArgs) Handles updateProdButton.Click

        If nomeProdTextBox.Text.Trim = "" Then
            MsgBox("O campo 'nome' do produto não pode estar vazio")
            Exit Sub
        End If

        If preçoProdTextBox.Text.Trim = "" Then
            MsgBox("O campo 'preço' do produto não pode estar vazio")
            Exit Sub
        End If

        Dim Query As String = "UPDATE produtos SET nome = @nome, preco = @preço, estoque_minimo = @estoque_min, codigo_de_barra = @codigoBarra, validade = @dataValidade, data_att = @data_att, image = @image WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", nomeProdTextBox.Text)
        Command.Parameters.AddWithValue("@preço", preçoProdTextBox.Text.Replace("R$", "").Trim)
        Command.Parameters.AddWithValue("@codigoBarra", codigoBarraProdTextBox.Text)
        Command.Parameters.AddWithValue("@id", idProdTextBox.Text)

        If estoqueMinProdTextBox.Text.Trim <> "" Then
            Command.Parameters.AddWithValue("@estoque_min", estoqueMinProdTextBox.Text)
        Else
            Command.Parameters.AddWithValue("@estoque_min", DBNull.Value)
        End If

        Command.Parameters.AddWithValue("@dataValidade", validadeProdTextBox.Text)
        Command.Parameters.AddWithValue("@data_att", Format(Now(), "dd/MM/yyyy"))
        Command.Parameters.AddWithValue("@image", parseImageBox_Image_To_ByteArray(produtoPictureBox))

        Try
            Connection.Open()
            Command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        Finally
            Connection.Close()
        End Try

        Query = "UPDATE produtos_lotes SET validade = @validade, quantidade = @quantidade WHERE produtos_fk = @id AND lote_number = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@validade", validadeProdTextBox.Text)
        If quantidadeProdTextBox.Text.Trim <> "" Then
            Command.Parameters.AddWithValue("@quantidade", quantidadeProdTextBox.Text)
        Else
            Command.Parameters.AddWithValue("@quantidade", DBNull.Value)
        End If
        Command.Parameters.AddWithValue("@id", idProdTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        cleanProdText()
        produtosDataGridView.Rows.Clear()
        requestProdutos()
        requestProdutosComboBox()

    End Sub

    Private Sub removeProdButton_Click(sender As Object, e As EventArgs) Handles removeProdButton.Click

        Dim result As Integer = MessageBox.Show("Você irá deletar todo o cadastro do produto e seus respectivos lotes." & vbNewLine & "Deseja continuar?", "Remover Produto", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim Query As String = "DELETE FROM produtos_lotes WHERE produtos_fk = @id;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", idProdTextBox.Text)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                Connection.Close()
            End Try

            Query = "DELETE FROM produtos WHERE id = @id;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", idProdTextBox.Text)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                Connection.Close()
            End Try

            cleanProdText()
            produtosDataGridView.Rows.Clear()
            requestProdutos()
            requestProdutosComboBox()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cleanAllProdButton_Click(sender As Object, e As EventArgs) Handles cleanAllProdButton.Click
        cleanProdText()
    End Sub

    Private Sub cleanProdText()

        produtosDataGridView.ClearSelection()
        idProdTextBox.Text = ""
        nomeProdTextBox.Text = ""
        preçoProdTextBox.Text = ""
        estoqueMinProdTextBox.Text = ""
        codigoBarraProdTextBox.Text = ""
        quantidadeProdTextBox.Text = ""
        validadeProdTextBox.Text = ""
        dataAttProdTextBox.Text = ""
        produtoPictureBox.Image = My.Resources.ResourceManager.GetObject("default_produto_photo")
        quantidadeProdTextBox.Enabled = True
        validadeProdTextBox.Enabled = True

    End Sub

    Private Sub produtosDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles produtosDataGridView.CellMouseClick

        If (e.RowIndex >= 0) Then
            idProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
            nomeProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            preçoProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString
            estoqueMinProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            codigoBarraProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(4).Value.ToString
            quantidadeProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(5).Value.ToString
            validadeProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(6).Value.ToString
            dataAttProdTextBox.Text = produtosDataGridView.Rows(e.RowIndex).Cells(7).Value.ToString
            quantidadeProdTextBox.Enabled = False
            validadeProdTextBox.Enabled = False

            Dim Query As String = "SELECT image FROM produtos WHERE id = @id;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", produtosDataGridView.Rows(e.RowIndex).Cells(0).Value)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader()
                While Reader.Read
                    produtoPictureBox.Image = Byte2Image(Reader.GetValue(0))
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

        End If

    End Sub

    Private Sub checkMinEstoque()

        For Each row As DataGridViewRow In produtosDataGridView.Rows
            Dim Query As String = ""
            If (Not IsDBNull(row.Cells(5).Value) And Not IsDBNull(row.Cells(3).Value)) Then
                If (CDate(row.Cells(6).Value & " 00:00:00") < Now()) Then

                    Query = "UPDATE produtos SET vencido = 1, estoque_menor = 0 WHERE id = @id;"
                    Command = New MySqlCommand(Query, Connection)
                    Command.Parameters.AddWithValue("@id", row.Cells(0).Value)
                    Try
                        Connection.Open()
                        Command.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        Connection.Close()
                    End Try

                    For Each cell As DataGridViewCell In row.Cells

                        cell.Style.ForeColor = Color.Red
                        cell.Style.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

                    Next

                ElseIf (row.Cells(5).Value <= row.Cells(3).Value) Then

                    Query = "UPDATE produtos SET estoque_menor = 1, vencido = 0 WHERE id = @id;"
                    Command = New MySqlCommand(Query, Connection)
                    Command.Parameters.AddWithValue("@id", row.Cells(0).Value)
                    Try
                        Connection.Open()
                        Command.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        Connection.Close()
                    End Try

                    For Each cell As DataGridViewCell In row.Cells
                        cell.Style.ForeColor = Color.Orange
                        cell.Style.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

                    Next

                Else

                    Query = "UPDATE produtos SET vencido = 0, estoque_menor = 0 WHERE id = @id;"
                    Command = New MySqlCommand(Query, Connection)
                    Command.Parameters.AddWithValue("@id", row.Cells(0).Value)
                    Try
                        Connection.Open()
                        Command.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        Connection.Close()
                    End Try

                    For Each cell As DataGridViewCell In row.Cells

                        cell.Style.ForeColor = Color.Green
                        cell.Style.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

                    Next

                End If

            Else
                For Each cell As DataGridViewCell In row.Cells

                    cell.Style.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

                Next
            End If

        Next

        produtosDataGridView.ClearSelection()

    End Sub

    Private Sub searchProdTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchProdTextBox.TextChanged

        searchProd()

    End Sub

    Private Sub searchProd()

        Dim index As Integer

        Select Case (True)
            Case nomesProdRadioButton.Checked
                index = 1
            Case preçoProdRadioButton.Checked
                index = 2
            Case estoqueMinProdRadioButton.Checked
                index = 3
            Case codigoBarraProdRadioButton.Checked
                index = 4
            Case quantidadeProdRadioButton.Checked
                index = 5
            Case dataCadastroProdRadioButton.Checked
                index = 6
        End Select

        produtosDataGridView.ClearSelection()

        For Each row As DataGridViewRow In produtosDataGridView.Rows
            If (row.Cells(index).Value.ToString = searchProdTextBox.Text) Then
                row.Selected = True
                searchProdTextBox.SelectAll()
            End If
        Next

    End Sub

    Private Sub updateRelatorioType(Report_Option As Integer)

        Dim Query As String = "UPDATE report_option SET report_option = @option WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@option", Report_Option)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub fotoEmployeePictureBox_Click(sender As Object, e As EventArgs) Handles fotoEmployeePictureBox.Click

        If selecionarImagemOpenFileDialog.ShowDialog() = DialogResult.OK Then
            fotoEmployeePictureBox.Image = resizeImage(Image.FromFile(selecionarImagemOpenFileDialog.FileName))
        End If

    End Sub

    Private Sub adicionarCategoriaButton_Click(sender As Object, e As EventArgs) Handles adicionarCategoriaButton.Click

        Dim Query As String = "SELECT COUNT(*) FROM categorias_combo_box;"
        Dim categoriasNumber As Integer = 0
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            Reader.Read()
            categoriasNumber = Reader.GetInt32(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If categoriasNumber = 12 Then
            MsgBox("Não é possível adicionar mais que 12 categorias")
            categoriaTypeTextBox.Text = ""
        Else
            Query = "INSERT INTO categorias_combo_box VALUES(NULL, @categoriaName, @useName, @image);"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@categoriaName", categoriaTypeTextBox.Text)
            Command.Parameters.AddWithValue("@useName", utilizarNomeCategoriaCheckBox.Checked)
            Command.Parameters.AddWithValue("@image", parseImageBox_Image_To_ByteArray(categoriaPictureBox))

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try

            limparCategoriasCampos()
            categoriaButtonsCaixaComboBox.Items.Clear()
            requestCategoriasComboBox()
        End If

    End Sub

    Private Sub atualizarCategoriaButton_Click(sender As Object, e As EventArgs) Handles atualizarCategoriaButton.Click

        Dim produtosNaCategoria As Integer = 0
        Dim Query As String = "SELECT COUNT(nome) FROM produtos JOIN categoria_produtos ON categoria_produtos.produto = produtos.id WHERE categoria = @nameCategoria;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nameCategoria", categoriaButtonsCaixaComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                produtosNaCategoria = Reader.GetValue(0)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If produtosNaCategoria > 0 Then
            MsgBox("Antes de atualizar a categoria: " & categoriaButtonsCaixaComboBox.SelectedItem & ", retire todos os produtos a ela acoplados.")
            Exit Sub
        End If

        Dim id As Integer = 0
        Query = "SELECT id FROM categorias_combo_box WHERE nome_categoria = @nome"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", categoriaButtonsCaixaComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read()
                id = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Query = "UPDATE categorias_combo_box SET nome_categoria = @newName, useName = @useName, image_categoria = @image WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@newName", categoriaTypeTextBox.Text)
        Command.Parameters.AddWithValue("@useName", utilizarNomeCategoriaCheckBox.Checked)
        Command.Parameters.AddWithValue("@image", parseImageBox_Image_To_ByteArray(categoriaPictureBox))
        Command.Parameters.AddWithValue("@id", id)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        limparCategoriasCampos()
        categoriaButtonsCaixaComboBox.Items.Clear()
        requestCategoriasComboBox()

    End Sub

    Private Sub removerCategoriasButton_Click(sender As Object, e As EventArgs) Handles removerCategoriasButton.Click

        If categoriaButtonsCaixaComboBox.Items.Count.Equals(0) Then
            limparCategoriasCampos()
            Exit Sub
        End If

        Dim produtosNaCategoria As Integer = 0
        Dim Query As String = "SELECT COUNT(nome) FROM produtos JOIN categoria_produtos ON categoria_produtos.produto = produtos.id WHERE categoria = @nameCategoria;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nameCategoria", categoriaButtonsCaixaComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                produtosNaCategoria = Reader.GetValue(0)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If produtosNaCategoria > 0 Then
            MsgBox("Antes de remover a categoria: " & categoriaButtonsCaixaComboBox.SelectedItem & ", retire todos os produtos a ela acoplados.")
            Exit Sub
        End If

        categoriaSelected = 0
        Query = "DELETE FROM categorias_combo_box WHERE nome_categoria = @categoriaName;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@categoriaName", categoriaTypeTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Query = "DELETE FROM categoria_produtos WHERE categoria = @categoria;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@categoria", categoriaTypeTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        limparCategoriasCampos()
        categoriaButtonsCaixaComboBox.Items.Clear()
        requestCategoriasComboBox()

    End Sub

    Private Sub categoriaPictureBox_Click(sender As Object, e As EventArgs) Handles categoriaPictureBox.Click

        If selecionarImagemOpenFileDialog.ShowDialog() = DialogResult.OK Then
            categoriaPictureBox.Image = resizeImage(Image.FromFile(selecionarImagemOpenFileDialog.FileName))
        End If

    End Sub

    Private Sub limparCategoriasButton_Click(sender As Object, e As EventArgs) Handles limparCategoriasButton.Click
        limparCategoriasCampos()
    End Sub

    Private Sub limparCategoriasCampos()

        categoriaButtonsCaixaComboBox.Text = ""
        produtosButtonsCaixaComboBox.Text = ""
        categoriaTypeTextBox.Text = ""
        utilizarNomeCategoriaCheckBox.Checked = False
        categoriaPictureBox.Image = My.Resources.ResourceManager.GetObject("default_categoria_image")
        produtosCategoriasDataGridView.Rows.Clear()

    End Sub

    Private Sub categoriaButtonsCaixaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoriaButtonsCaixaComboBox.SelectedIndexChanged

        categoriaSelected = categoriaButtonsCaixaComboBox.SelectedIndex
        categoriaTypeTextBox.Text = categoriaButtonsCaixaComboBox.SelectedItem

        Dim Query As String = "SELECT useName, image_categoria FROM categorias_combo_box WHERE nome_categoria = @nome;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", categoriaButtonsCaixaComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                Select Case Reader.GetValue(0)
                    Case 0
                        utilizarNomeCategoriaCheckBox.Checked = False
                    Case 1
                        utilizarNomeCategoriaCheckBox.Checked = True
                End Select

                categoriaPictureBox.Image = Byte2Image(Reader.GetValue(1))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        produtosCategoriasDataGridView.Rows.Clear()
        requestProdutosCategoriasDataGridView()

    End Sub

    Private Sub requestCategoriasComboBox()

        Dim Query As String = "SELECT nome_categoria FROM categorias_combo_box;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                categoriaButtonsCaixaComboBox.Items.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If categoriaButtonsCaixaComboBox.Items.Count <> 0 Then
            categoriaButtonsCaixaComboBox.SelectedIndex = categoriaSelected
        End If

    End Sub

    Private Sub requestProdutosComboBox()

        produtosButtonsCaixaComboBox.Items.Clear()

        Dim Query As String = "SELECT nome FROM produtos WHERE produto_utilizado_combobox = 0;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                produtosButtonsCaixaComboBox.Items.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If produtosButtonsCaixaComboBox.Items.Count <> 0 Then
            produtosButtonsCaixaComboBox.SelectedIndex = 0
            adicionarProdutoCategoriaButton.Enabled = True
        Else
            adicionarProdutoCategoriaButton.Enabled = False
        End If

    End Sub

    Private Sub requestProdutosCategoriasDataGridView()

        Dim Query As String = "SELECT nome FROM produtos JOIN categoria_produtos ON categoria_produtos.produto = produtos.id WHERE categoria = @nameCategoria;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nameCategoria", categoriaButtonsCaixaComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                produtosCategoriasDataGridView.Rows.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        produtosCategoriasDataGridView.ClearSelection()
        produtoFromCategoriaSelected = "NULL"

        If produtosButtonsCaixaComboBox.Items.Count <> 0 Then
            adicionarProdutoCategoriaButton.Enabled = True
        Else
            adicionarProdutoCategoriaButton.Enabled = False
        End If

        If produtosCategoriasDataGridView.Rows.Count <> 0 Then
            removerProdutoCategoriaButton.Enabled = True
        Else
            removerProdutoCategoriaButton.Enabled = False
        End If

    End Sub

    Private Sub adicionarProdutoCategoriaButton_Click(sender As Object, e As EventArgs) Handles adicionarProdutoCategoriaButton.Click

        Dim Query As String = "SELECT id FROM produtos WHERE nome = @nomeProd"
        Dim id As Integer = 0
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nomeProd", produtosButtonsCaixaComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                id = Reader.GetInt32(0)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "INSERT INTO categoria_produtos VALUES(@categoriaName, @produto_fk);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@categoriaName", categoriaButtonsCaixaComboBox.SelectedItem)
        Command.Parameters.AddWithValue("@produto_fk", id)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Query = "UPDATE produtos SET produto_utilizado_combobox = 1 WHERE id = @id"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        produtosCategoriasDataGridView.Rows.Clear()
        requestProdutosCategoriasDataGridView()
        requestProdutosComboBox()

        If produtosButtonsCaixaComboBox.Items.Count = 0 Then
            adicionarProdutoCategoriaButton.Enabled = False
        End If

    End Sub

    Private Function parseImageBox_Image_To_ByteArray(ByVal picturebox As PictureBox) As Byte()

        Dim arrayImage() As Byte = {}
        Try
            Dim converter As New ImageConverter
            arrayImage = converter.ConvertTo(picturebox.Image, GetType(Byte()))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return arrayImage

    End Function

    Private Sub produtoPictureBox_Click(sender As Object, e As EventArgs) Handles produtoPictureBox.Click

        If selecionarImagemOpenFileDialog.ShowDialog() = DialogResult.OK Then
            produtoPictureBox.Image = resizeImage(Image.FromFile(selecionarImagemOpenFileDialog.FileName))
        End If

    End Sub

    Private Sub produtosCategoriasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles produtosCategoriasDataGridView.CellMouseClick
        If (e.RowIndex >= 0) Then
            produtoFromCategoriaSelected = produtosCategoriasDataGridView.Rows(e.RowIndex).Cells(0).Value
        End If

    End Sub

    Private Sub removerProdutoCategoriaButton_Click(sender As Object, e As EventArgs) Handles removerProdutoCategoriaButton.Click

        Dim Query As String = "SELECT id FROM produtos WHERE nome = @nomeProd;"
        Dim id As Integer = 0
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nomeProd", produtoFromCategoriaSelected)
        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                id = Reader.GetInt32(0)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "DELETE FROM categoria_produtos WHERE produto = @produto_fk;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@produto_fk", id)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Query = "UPDATE produtos SET produto_utilizado_combobox = 0 WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        produtosCategoriasDataGridView.Rows.Clear()
        requestProdutosCategoriasDataGridView()
        requestProdutosComboBox()

        If produtosButtonsCaixaComboBox.Items.Count <> 0 Then
            adicionarProdutoCategoriaButton.Enabled = True
        End If

    End Sub

    Private Function resizeImage(imageToResize As Image) As Image

        Dim bm_source As New Bitmap(imageToResize)
        Dim bm_dest As New Bitmap(500, 500)
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
        gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1)

        Return bm_dest

    End Function

    Private Sub adicionarFormaDePagamentoButton_Click(sender As Object, e As EventArgs) Handles adicionarFormaDePagamentoButton.Click

        Dim Query As String = "INSERT INTO formas_de_pagamento VALUES(NULL, @forma_de_pagamento);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@forma_de_pagamento", formasDePagamentoTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        requestFormasDePgamentosComboBox()
        formasDePagamentoTextBox.Text = ""

    End Sub

    Private Sub removerFormaDePagamentoButton_Click(sender As Object, e As EventArgs) Handles removerFormaDePagamentoButton.Click

        If formasDePagamentoComboBox.SelectedItem = "Dinheiro" Or formasDePagamentoComboBox.SelectedItem = "Fiado" Then
            MsgBox("Não é possível excluir a forma de pagamento selecionada: " & formasDePagamentoComboBox.SelectedItem)
            Exit Sub
        End If

        If formasDePagamentoComboBox.SelectedItem <> "NULL" Then

            Dim Query As String = "DELETE FROM formas_de_pagamento WHERE forma_de_pagamento = @forma_de_pagamento;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@forma_de_pagamento", formasDePagamentoTextBox.Text)

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try

        End If

        requestFormasDePgamentosComboBox()
        formasDePagamentoTextBox.Text = ""

    End Sub

    Private Sub formasDePagamentoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formasDePagamentoComboBox.SelectedIndexChanged
        If formasDePagamentoComboBox.SelectedItem <> "NULL" Then
            formasDePagamentoTextBox.Text = formasDePagamentoComboBox.SelectedItem
        End If
    End Sub

    Private Sub requestFormasDePgamentosComboBox()

        formasDePagamentoComboBox.Items.Clear()

        Dim Query As String = "SELECT forma_de_pagamento FROM formas_de_pagamento;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                formasDePagamentoComboBox.Items.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If formasDePagamentoComboBox.Items.Count <= 0 Then
            formasDePagamentoComboBox.Items.Add("NULL")
        End If
        If formasDePagamentoComboBox.Items.Count <> 0 Then
            formasDePagamentoComboBox.SelectedIndex = 0
        End If

    End Sub

    Private Sub completoRelatorioRadioButton_Click(sender As Object, e As EventArgs) Handles completoRelatorioRadioButton.Click
        If completoRelatorioRadioButton.Checked Then
            reportOptionChanged(1)
        End If
    End Sub

    Private Sub resumoRelatorioRadioButton_Click(sender As Object, e As EventArgs) Handles resumoRelatorioRadioButton.Click
        If resumoRelatorioRadioButton.Checked Then
            reportOptionChanged(0)
        End If
    End Sub

    Private Sub reportOptionChanged(ByVal optionReport As Integer)

        Dim Query As String = "UPDATE report_option SET report_option = @option WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@option", optionReport)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub funcionariosCadastradosSistemaFiadoEComboBoxFunc()

        funcionariosCadComboBox.Items.Clear()

        Dim Query As String = "SELECT Name FROM employee;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                funcionariosCadComboBox.Items.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If funcionariosCadComboBox.Items.Count <= 0 Then
            funcionariosCadComboBox.Items.Add("Nenhum Funcionário Cadastrado")
        End If

        If funcionariosCadComboBox.Items.Count <> employeeFiadoSelected + 1 Then
            funcionariosCadComboBox.SelectedIndex = 0
        Else
            funcionariosCadComboBox.SelectedIndex = employeeFiadoSelected
        End If

        Query = "SELECT user, password FROM login WHERE nomeUser = @nome;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                If Reader.GetValue(0) IsNot DBNull.Value Then
                    If Reader.GetValue(0).Trim.Equals("") Then
                        userEmployeeTextBox.Text = ""
                    Else
                        userEmployeeTextBox.Text = Reader.GetValue(0)
                    End If
                Else
                    userEmployeeTextBox.Text = ""
                End If

                If Reader.GetValue(1) IsNot DBNull.Value Then
                    If Reader.GetValue(1).Trim.Equals("") Then
                        passwordEmployeeTextBox.Text = ""
                    Else
                        passwordEmployeeTextBox.Text = Reader.GetValue(1)
                    End If
                Else
                    passwordEmployeeTextBox.Text = ""
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub funcionariosFiadoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles funcionariosCadComboBox.SelectedValueChanged
        funcionariosFiadoComboBox_SelectedValueChanged()
        employeeFiadoSelected = funcionariosCadComboBox.SelectedIndex
    End Sub

    Private Sub funcionariosFiadoComboBox_SelectedValueChanged()

        If funcionariosCadComboBox.SelectedItem.Equals("Nenhum Funcionário Cadastrado") Then
            assinaturaDigitalEmployeeTextBox.Text = ""
            assinaturaDigitalEmployeeTextBox.Enabled = False
            assinaturaDigitalCadastroButton.Enabled = False
            assinaturaDigitalRemoverButton.Enabled = False
            cadastrarFuncCadButton.Enabled = False
            atualizarFuncCadButton.Enabled = False
            removerFuncCadButton.Enabled = False
            userEmployeeTextBox.Enabled = False
            passwordEmployeeTextBox.Enabled = False
            Exit Sub
        End If

        Dim Query As String = "SELECT assinatura_digital, id, Foto FROM employee WHERE Name = @nome;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                imageFuncCadPictureBox.Image = Byte2Image(Reader.GetValue(2))
                idEmployee = Reader.GetValue(1)
                If Reader.GetValue(0) IsNot DBNull.Value Then
                    assinaturaDigitalEmployeeTextBox.Text = Reader.GetValue(0)
                    assinaturaDigitalEmployeeTextBox.Enabled = False
                    funcionarioFiadoBoolCadastradoLabel.Text = "  Funcionário Cadastrado"
                    funcionarioFiadoBoolCadastradoLabel.ForeColor = Color.Green
                    assinaturaDigitalCadastroButton.Enabled = False
                    assinaturaDigitalRemoverButton.Enabled = True
                Else
                    assinaturaDigitalEmployeeTextBox.Enabled = True
                    assinaturaDigitalEmployeeTextBox.Text = ""
                    funcionarioFiadoBoolCadastradoLabel.Text = "Funcionário Não Cadastrado"
                    funcionarioFiadoBoolCadastradoLabel.ForeColor = Color.Red
                    assinaturaDigitalCadastroButton.Enabled = True
                    assinaturaDigitalRemoverButton.Enabled = False
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        datasComprasFiadoComboBox.Items.Clear()

        Query = "SELECT datas FROM faturamentos WHERE pk_employee = @id GROUP BY datas;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", idEmployee)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                datasComprasFiadoComboBox.Items.Add("                              " & Reader.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If datasComprasFiadoComboBox.Items.Count <= 0 Then
            datasComprasFiadoComboBox.Items.Add("            Nenhuma Compra Registrada")
        ElseIf datasComprasFiadoComboBox.Items.Count > 1 Then
            datasComprasFiadoComboBox.Items.Add("                       Todas as Compras")
        End If

        datasComprasFiadoComboBox.SelectedIndex = 0

        Query = "SELECT user, password, COUNT(nomeUser) FROM login WHERE nomeUser = @nome;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read()
                If Reader.GetValue(2) > 0 Then
                    cadastrarFuncCadButton.Enabled = False
                    atualizarFuncCadButton.Enabled = True
                    removerFuncCadButton.Enabled = True
                    If Reader.GetValue(0) IsNot DBNull.Value Then
                        If Reader.GetValue(0).Trim.Equals("") Then
                            userEmployeeTextBox.Text = ""
                        Else
                            userEmployeeTextBox.Text = Reader.GetValue(0)
                        End If
                    Else
                        userEmployeeTextBox.Text = ""
                    End If

                    If Reader.GetValue(1) IsNot DBNull.Value Then
                        If Reader.GetValue(1).Trim.Equals("") Then
                            passwordEmployeeTextBox.Text = ""
                        Else
                            passwordEmployeeTextBox.Text = Reader.GetValue(1)
                        End If
                    Else
                        passwordEmployeeTextBox.Text = ""
                    End If
                Else
                    passwordEmployeeTextBox.Text = ""
                    userEmployeeTextBox.Text = ""
                    cadastrarFuncCadButton.Enabled = True
                    atualizarFuncCadButton.Enabled = False
                    removerFuncCadButton.Enabled = False
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub cadastrarAssinaturaFuncFiadoButton_Click(sender As Object, e As EventArgs) Handles cadastrarFuncCadButton.Click

        Dim idEmployeeCad As Integer = 0
        Dim Query As String = "SELECT id FROM employee WHERE Name = @nome;"
        Command = New MySqlCommand(Query, Connection)

        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem.ToString)
        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                idEmployeeCad = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "INSERT INTO login VALUES(NULL, @nome, @user, @password, 0, NULL, NULL, NULL, 0, @id_employee);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem.ToString)
        Command.Parameters.AddWithValue("@user", userEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@password", passwordEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("id_employee", idEmployeeCad)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()
        funcionariosFiadoComboBox_SelectedValueChanged()

    End Sub

    Private Sub atualizarFuncCadButton_Click(sender As Object, e As EventArgs) Handles atualizarFuncCadButton.Click

        Dim Query As String = "UPDATE login SET user = @user, password = @password WHERE nomeUser = @nome"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@user", userEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@password", passwordEmployeeTextBox.Text)
        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()
        funcionariosFiadoComboBox_SelectedValueChanged()

    End Sub

    Private Sub assinaturaDigitalCadastroButton_Click(sender As Object, e As EventArgs) Handles assinaturaDigitalCadastroButton.Click

        If assinaturaDigitalEmployeeTextBox.Text.Trim.Count <> 6 Then
            MsgBox("A Assinatura Digital deve ter 6 caracteres")
            Exit Sub
        End If

        Dim Query As String = "UPDATE employee SET assinatura_digital = @assinaturaDigital WHERE Name = @nome"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@assinaturaDigital", assinaturaDigitalEmployeeTextBox.Text.Trim)
        Command.Parameters.AddWithValue("@nome", funcionariosCadComboBox.SelectedItem)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()

    End Sub

    Private Sub assinaturaDigitalRemoverButton_Click(sender As Object, e As EventArgs) Handles assinaturaDigitalRemoverButton.Click

        If datasComprasFiadoComboBox.SelectedItem.Trim <> "Nenhuma Compra Registrada" Then
            MsgBox("Elimine as compras pendentes antes de remover o cadastro do funcionário " & funcionariosCadComboBox.SelectedItem)
            Exit Sub
        End If

        Dim Query As String = "UPDATE employee SET assinatura_digital = @ass WHERE id = @id_employee"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id_employee", idEmployee)
        Command.Parameters.AddWithValue("@ass", DBNull.Value)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()

    End Sub

    Private Sub datasComprasFiadoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles datasComprasFiadoComboBox.SelectedValueChanged

        If datasComprasFiadoComboBox.SelectedItem.Trim = "Nenhuma Compra Registrada" Then
            valorTotalCompraFiadoTextBox.Text = "R$ 0,00"
            produtosEQuantidadesFiadoDataGridView.Rows.Clear()
            Exit Sub
        End If

        produtosEQuantidadesFiadoDataGridView.Rows.Clear()

        If datasComprasFiadoComboBox.SelectedItem.Trim = "Todas as Compras" Then
            todasAsComprasFunc()
            Exit Sub
        End If

        Dim Query As String = "SELECT vendas.produtos, SUM(vendas.quantidades)
                               FROM faturamentos 	
                               JOIN vendas ON id_faturamentos = faturamentos.id
                               WHERE pk_employee = @id_employee And datas = @data
                               GROUP BY vendas.produtos;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id_employee", idEmployee)
        Command.Parameters.AddWithValue("@data", datasComprasFiadoComboBox.SelectedItem.Trim)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                produtosEQuantidadesFiadoDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "SELECT valores FROM faturamentos WHERE pk_employee = @id_employee And datas = @data"
        Dim valorTotalData As Double = 0
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id_employee", idEmployee)
        Command.Parameters.AddWithValue("@data", datasComprasFiadoComboBox.SelectedItem.Trim)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                valorTotalData += Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        valorTotalCompraFiadoTextBox.Text = Format(valorTotalData, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")

    End Sub

    Private Sub todasAsComprasFunc()
        Dim Query As String = "SELECT vendas.produtos, SUM(vendas.quantidades)
                               FROM faturamentos 	
                               JOIN vendas ON id_faturamentos = faturamentos.id
                               WHERE pk_employee = @id_employee
                               GROUP BY vendas.produtos;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id_employee", idEmployee)
        Command.Parameters.AddWithValue("@data", datasComprasFiadoComboBox.SelectedItem.Trim)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                produtosEQuantidadesFiadoDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "SELECT valores FROM faturamentos WHERE pk_employee = @id_employee"
        Dim valorTotalData As Double = 0
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id_employee", idEmployee)
        Command.Parameters.AddWithValue("@data", datasComprasFiadoComboBox.SelectedItem.Trim)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                valorTotalData += Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        valorTotalCompraFiadoTextBox.Text = Format(valorTotalData, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")
    End Sub

    Private Sub removerAssinaturaFuncFiadoButton_Click(sender As Object, e As EventArgs) Handles removerFuncCadButton.Click

        Dim Query As String = "DELETE FROM login WHERE nomeUser = @nome"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("nome", funcionariosCadComboBox.SelectedItem)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        funcionariosCadastradosSistemaFiadoEComboBoxFunc()

    End Sub

    Private Sub removerCompraFiadoButton_Click(sender As Object, e As EventArgs) Handles removerCompraFiadoButton.Click
        If datasComprasFiadoComboBox.SelectedItem.Trim.Equals("Todas as Compras") Then
            Command = New MySqlCommand("DELETE FROM faturamentos WHERE forma_pagamento = 'Fiado' AND pk_employee = @employee_id;", Connection)
            Command.Parameters.AddWithValue("@employee_id", idEmployee)
            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connection.Close()
            End Try
            funcionariosCadastradosSistemaFiadoEComboBoxFunc()
            Exit Sub
        End If

        Dim Query As String = "DELETE FROM faturamentos WHERE forma_pagamento = 'Fiado' AND datas = @data AND pk_employee = @employee_id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@data", datasComprasFiadoComboBox.SelectedItem.Trim)
        Command.Parameters.AddWithValue("@employee_id", idEmployee)
        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try
        funcionariosCadastradosSistemaFiadoEComboBoxFunc()
    End Sub

    Private Sub adicionarLoteButton_Click(sender As Object, e As EventArgs) Handles adicionarLoteButton.Click
        If idProdTextBox.Text.Trim = "" Then
            Exit Sub
        Else
            Gerenciar_Lote.id_produto = idProdTextBox.Text.Trim
            Gerenciar_Lote.ShowDialog()
        End If
    End Sub

    Private Sub atualizarLoteProdutos()

        Dim Query As String = "SELECT * FROM produtos;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                produtosDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Format(CDbl(Reader.GetValue(2)), "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;"), Reader.GetValue(3), Reader.GetValue(4), Reader.GetValue(5), Reader.GetValue(6), Reader.GetValue(7))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub ButtonLogOff_Click(sender As Object, e As EventArgs) Handles ButtonLogOff.Click

        Login.Show()
        Me.Dispose()

    End Sub

    Private Sub logoEmpresaPictureBox_Click(sender As Object, e As EventArgs) Handles logoEmpresaPictureBox.Click
        If selecionarImagemOpenFileDialog.ShowDialog = DialogResult.OK Then
            logoEmpresaPictureBox.Image = Image.FromFile(selecionarImagemOpenFileDialog.FileName)
        Else
            Exit Sub
        End If

        Dim Query As String = "UPDATE logo_empresa SET image_logo = @image WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@image", parseImageBox_Image_To_ByteArray(logoEmpresaPictureBox))

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try
    End Sub

End Class