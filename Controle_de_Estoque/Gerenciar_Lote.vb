Imports MySql.Data.MySqlClient

Public Class Gerenciar_Lote

    Private Command As MySqlCommand
    Private Connection As New MySqlConnection
    Private Reader As MySqlDataReader
    Public id_produto As Integer = 0

    Private Sub Gerenciar_Lote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=h438edJD9d3EKpo3oe3ijfD0"

        Dim nomeProd As String = ""
        Dim Query As String = "SELECT nome, quantidade, validade, image FROM produtos WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                nomeProd = Reader.GetValue(0)
                gerenciarLoteProdutoNomeLabel.Text = Reader.GetValue(0)
                If Reader.GetValue(1) IsNot DBNull.Value Then
                    gerenciarLoteQuantidadeProdTextBox.Text = Reader.GetValue(1)
                Else
                    gerenciarLoteQuantidadeProdTextBox.Text = ""
                End If
                If Reader.GetValue(2) IsNot DBNull.Value Then
                    gerenciarLoteValidadeProdTextBox.Text = Reader.GetValue(2)
                Else
                    gerenciarLoteValidadeProdTextBox.Text = ""
                End If
                gerenciarLoteProdutoPictureBox.Image = Byte2Image(Reader.GetValue(3))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        gerenciarLoteLotesComboBox.Items.Clear()

        Query = "SELECT COUNT(*) FROM produtos_lotes WHERE produtos_fk = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                Dim quantidade As Integer = Reader.GetValue(0)
                Dim loteNum As Integer = 1
                While (quantidade <> 0)
                    gerenciarLoteLotesComboBox.Items.Add(loteNum)
                    loteNum += 1
                    quantidade -= 1
                End While
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
            If gerenciarLoteLotesComboBox.Items.Count > 0 Then
                gerenciarLoteLotesComboBox.SelectedIndex = 0
            End If
        End Try

        gerenciarLoteAdicionarLoteButton.Enabled = True

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

    Private Sub gerenciarLoteLotesComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles gerenciarLoteLotesComboBox.SelectedValueChanged

        updateLoteComboBox()

    End Sub

    Private Sub updateLoteComboBox()

        Dim Query As String = "SELECT quantidade, validade FROM produtos_lotes WHERE lote_number = @lote AND produtos_fk = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@lote", gerenciarLoteLotesComboBox.SelectedItem)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            Dim temAlgo As Boolean = False
            While Reader.Read
                If Reader.GetValue(0) IsNot DBNull.Value Then
                    gerenciarLoteQuantidadeProdTextBox.Text = Reader.GetValue(0)
                Else
                    gerenciarLoteQuantidadeProdTextBox.Text = ""
                End If
                If Reader.GetValue(1) IsNot DBNull.Value Then
                    gerenciarLoteValidadeProdTextBox.Text = Reader.GetValue(1)
                Else
                    gerenciarLoteValidadeProdTextBox.Text = ""
                End If
                temAlgo = True
            End While

            If Not temAlgo Then
                isLoteCadLabel.Text = "Lote Não Cadastrado"
                isLoteCadLabel.ForeColor = Color.Red
                gerenciarLoteQuantidadeProdTextBox.Text = ""
                gerenciarLoteValidadeProdTextBox.Text = ""
                gerenciarLoteQuantidadeProdTextBox.Enabled = True
                gerenciarLoteValidadeProdTextBox.Enabled = True
                gerenciarLoteCadastrarLoteButton.Enabled = True
                removerLoteButton.Enabled = False
            Else
                isLoteCadLabel.Text = "Lote Cadastrado"
                isLoteCadLabel.ForeColor = Color.Green
                gerenciarLoteQuantidadeProdTextBox.Enabled = False
                gerenciarLoteValidadeProdTextBox.Enabled = False
                gerenciarLoteCadastrarLoteButton.Enabled = False
                removerLoteButton.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub gerenciarLoteAdicionarLoteButton_Click(sender As Object, e As EventArgs) Handles gerenciarLoteAdicionarLoteButton.Click

        Dim quantMaxLote As Integer = gerenciarLoteLotesComboBox.Items.Count
        gerenciarLoteLotesComboBox.Items.Add(quantMaxLote + 1)
        gerenciarLoteLotesComboBox.SelectedIndex = quantMaxLote
        gerenciarLoteAdicionarLoteButton.Enabled = False

    End Sub

    Private Sub gerenciarLoteCadastrarLoteButton_Click(sender As Object, e As EventArgs) Handles gerenciarLoteCadastrarLoteButton.Click

        If CStr(gerenciarLoteLotesComboBox.SelectedItem) = "" Then
            MsgBox("Nenhum lote selecionado")
            Exit Sub
        End If

        If gerenciarLoteValidadeProdTextBox.Text.Trim = "" Then
            MsgBox("O campo validade não pode estar vazio")
            Exit Sub
        End If

        Try
            Dim Dataaaa As Date = CDate(gerenciarLoteValidadeProdTextBox.Text & " 00:00:00")
        Catch ex As Exception
            MsgBox("Formato ou data inválido no campo de validade." & vbNewLine & "Por favor utilize o formato a seguir: dd/MM/yyyy")
            Exit Sub
        End Try

        If gerenciarLoteQuantidadeProdTextBox.Text.Trim = "" Then
            MsgBox("O campo quantidade não pode estar vazio")
            Exit Sub
        End If

        Dim Query As String = "INSERT INTO produtos_lotes VALUES(NULL, @id, @lote_number, @validade, @quantidade);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)
        Command.Parameters.AddWithValue("@lote_number", gerenciarLoteLotesComboBox.SelectedItem)
        Command.Parameters.AddWithValue("@validade", gerenciarLoteValidadeProdTextBox.Text)
        Command.Parameters.AddWithValue("@quantidade", gerenciarLoteQuantidadeProdTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim quantidadeArmazenada As Integer = 0
        Query = "SELECT quantidade FROM produtos WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                quantidadeArmazenada = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If gerenciarLoteLotesComboBox.SelectedItem.Equals(1) Then
            Query = "UPDATE produtos SET quantidade = @newQuantidade, validade = @validade WHERE id = @id;"
        Else
            Query = "UPDATE produtos SET quantidade = @newQuantidade WHERE id = @id;"
        End If

        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)
        Command.Parameters.AddWithValue("@newQuantidade", quantidadeArmazenada + CInt(gerenciarLoteQuantidadeProdTextBox.Text))

        If gerenciarLoteLotesComboBox.SelectedItem.Equals(1) Then
            Command.Parameters.AddWithValue("@validade", gerenciarLoteValidadeProdTextBox.Text)
        Else
            Command.Parameters.AddWithValue("@validade", DBNull.Value)
        End If

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        isLoteCadLabel.Text = "Lote Cadastrado"
        isLoteCadLabel.ForeColor = Color.Green
        gerenciarLoteQuantidadeProdTextBox.Enabled = False
        gerenciarLoteValidadeProdTextBox.Enabled = False
        gerenciarLoteCadastrarLoteButton.Enabled = False
        removerLoteButton.Enabled = True
        gerenciarLoteAdicionarLoteButton.Enabled = True

        Form_Admin.requestProdutos()

    End Sub

    Private Sub removerLoteButton_Click(sender As Object, e As EventArgs) Handles removerLoteButton.Click

        Dim loteNumber As Integer = gerenciarLoteLotesComboBox.SelectedItem

        Dim quantidadeProduto As Integer = 0
        Dim Query As String = "SELECT quantidade FROM produtos WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                quantidadeProduto = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim quantidadeProdutoLote As Integer = 0
        Query = "SELECT quantidade FROM produtos_lotes WHERE produtos_fk = @id AND lote_number = @lote_number;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)
        Command.Parameters.AddWithValue("@lote_number", gerenciarLoteLotesComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                quantidadeProdutoLote = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim newQuantidade As Integer = quantidadeProduto - quantidadeProdutoLote
        Query = "UPDATE produtos SET quantidade = @newQuantidade WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)
        Command.Parameters.AddWithValue("@newQuantidade", newQuantidade)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "DELETE FROM produtos_lotes WHERE produtos_fk = @id AND lote_number = @lote_number;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)
        Command.Parameters.AddWithValue("@lote_number", gerenciarLoteLotesComboBox.SelectedItem)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim count As Integer = 0
        Query = "SELECT COUNT(*) FROM produtos_lotes WHERE produtos_fk = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                count = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim arrayLoteNumbers As New ArrayList
        Query = "SELECT lote_number FROM produtos_lotes WHERE produtos_fk = @id ORDER BY lote_number ASC;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                arrayLoteNumbers.Add(Reader.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim loteNewNumber As Integer = 1
        While count <> 0
            Query = "UPDATE produtos_lotes SET lote_number = @new_lote_number WHERE produtos_fk = @id AND lote_number = @lote_number;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@id", id_produto)
            Command.Parameters.AddWithValue("@new_lote_number", loteNewNumber)
            Command.Parameters.AddWithValue("@lote_number", arrayLoteNumbers(loteNewNumber - 1))

            Try
                Connection.Open()
                Command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

            loteNewNumber += 1
            count -= 1
        End While

        Dim validade As String = ""
        Query = "SELECT validade FROM produtos_lotes WHERE produtos_fk = @id AND lote_number = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            While Reader.Read
                validade = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "UPDATE produtos SET validade = @validade WHERE id = @id;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@id", id_produto)
        Command.Parameters.AddWithValue("@validade", validade)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        gerenciarLoteLotesComboBox.Items.RemoveAt(loteNewNumber - 1)
        updateLoteComboBox()
        If gerenciarLoteLotesComboBox.Items.Count <> 0 Then
            gerenciarLoteLotesComboBox.SelectedIndex = 0
        Else
            gerenciarLoteCadastrarLoteButton.Enabled = False
            gerenciarLoteValidadeProdTextBox.Enabled = False
            gerenciarLoteQuantidadeProdTextBox.Enabled = False
        End If
        Form_Admin.requestProdutos()

    End Sub

    Private Sub gerenciarLoteValidadeProdTextBox_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles gerenciarLoteValidadeProdTextBox.KeyPress
        validateDate(gerenciarLoteValidadeProdTextBox, e)
    End Sub

    Private Sub validateDate(ByVal textBox As TextBox, ByVal e As KeyPressEventArgs)

        If Asc(e.KeyChar) = Keys.Back Then

            If textBox.Text.Length <> 0 Then
                Dim charsValidade As Char() = textBox.Text.ToString.ToCharArray()

                If charsValidade(textBox.Text.Length - 1) = "/" Then
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1)
                End If

                textBox.SelectionStart = textBox.Text.Length

            End If

        ElseIf Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then

            If textBox.Text.Length < 10 Then

                Select Case textBox.Text.Length
                    Case 2
                        textBox.Text += "/"
                        textBox.SelectionStart = textBox.Text.Length
                    Case 5
                        textBox.Text += "/"
                        textBox.SelectionStart = textBox.Text.Length
                End Select

            Else
                e.KeyChar = ""
            End If

        Else
            e.KeyChar = ""
        End If

    End Sub

End Class