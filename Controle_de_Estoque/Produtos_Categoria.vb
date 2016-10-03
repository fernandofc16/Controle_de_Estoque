Imports MySql.Data.MySqlClient

Public Class Produtos_Categoria

    Private Command As MySqlCommand
    Private Connection As New MySqlConnection
    Private Reader As MySqlDataReader
    Public buttonClickedCategorie As Button

    Private Sub Produtos_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        While (produtosCategoriaFlowLayoutPanel.Controls.Count > 0)
            produtosCategoriaFlowLayoutPanel.Controls.Clear()
        End While

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=h438edJD9d3EKpo3oe3ijfD0"

        Dim itensInCategoria As Integer = 0
        Dim onlyName As String = ""
        Dim quantidade As Integer = 0
        Dim Query As String = "SELECT COUNT(nome), nome FROM produtos JOIN categoria_produtos ON categoria_produtos.produto = produtos.id WHERE categoria = @nameCategoria;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nameCategoria", Caixa.buttonCategoria)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                itensInCategoria = Reader.GetValue(0)
                onlyName = Reader.GetValue(1).ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Select Case itensInCategoria
            Case Is <= 3
                Me.Size = New Size(380, 175)
            Case 4 To 6
                Me.Size = New Size(380, 175 + 130)
            Case 7 To 9
                Me.Size = New Size(380, 175 + 265)
            Case Is >= 10
                Me.Size = New Size(400, 175 + 265)
        End Select

        If (itensInCategoria = 1) Then

            Dim acabouProduto As Boolean
            Query = "SELECT nome, preco, image, quantidade FROM produtos WHERE nome = @nomeButton"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@nomeButton", onlyName)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader

                While Reader.Read
                    If Reader.GetValue(3) IsNot DBNull.Value Then
                        acabouProduto = Caixa.addProdutosToListQuant(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(3))
                    Else
                        Caixa.addProdutosToList(Reader.GetValue(0), Reader.GetValue(1))
                    End If
                    If acabouProduto Then
                        buttonClickedCategorie.Enabled = False
                    End If
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

            Me.Dispose()

        ElseIf (itensInCategoria < 1) Then

            Me.Dispose()

        End If

        Dim indexButton = 1
        Query = "SELECT nome, image, quantidade, validade FROM produtos JOIN categoria_produtos ON categoria_produtos.produto = produtos.id WHERE categoria = @nameCategoria;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nameCategoria", Caixa.buttonCategoria)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read()

                Dim button = New Button()
                button.Font = New Font("Microsoft Sans Serif", 8.5!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                button.ForeColor = SystemColors.Desktop
                button.Name = Reader.GetValue(0)
                button.Size = New Size(115, 125)
                button.TabStop = False
                button.UseVisualStyleBackColor = True
                button.Text = Reader.GetValue(0)
                button.TextAlign = ContentAlignment.BottomCenter
                button.Image = resizeImage(Byte2Image(Reader.GetValue(1)))
                button.ImageAlign = ContentAlignment.TopCenter
                produtosCategoriaFlowLayoutPanel.Controls.Add(button)
                If Reader.GetValue(2) IsNot DBNull.Value Then
                    If Reader.GetValue(2).Equals(0) Then
                        button.Enabled = False
                    ElseIf Reader.GetValue(2) - Caixa.checkQuantidadeDoProdutoNaListaDeCompra(Reader.GetValue(0)) = 0 Then
                        button.Enabled = False
                    ElseIf CDate(Reader.GetValue(3) & " 00:00:00") < Now() Then
                        button.Enabled = False
                    End If
                End If

                AddHandler button.Click, AddressOf Button_Click

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim btn As Button = CType(sender, Button)
        Dim acabouProduto As Boolean = acabouProduto
        Dim Query = "SELECT nome, preco, image, quantidade FROM produtos WHERE nome = @nomeButton"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nomeButton", btn.Name)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                If Reader.GetValue(3) IsNot DBNull.Value Then
                    acabouProduto = Caixa.addProdutosToListQuant(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(3))
                Else
                    Caixa.addProdutosToList(Reader.GetValue(0), Reader.GetValue(1))
                End If

                If acabouProduto Then
                    btn.Enabled = False
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

    End Sub

    Private Function resizeImage(imageToResize As Image) As Image

        Dim bm_source As New Bitmap(imageToResize)
        Dim bm_dest As New Bitmap(115, 90)
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

End Class