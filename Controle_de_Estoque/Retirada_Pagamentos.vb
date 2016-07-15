Imports MySql.Data.MySqlClient

Public Class Retirada_Pagamentos

    Private Connection As MySqlConnection = New MySqlConnection
    Private Command As MySqlCommand
    Public funcRetirada As String = ""

    Private Sub Retirada_Pagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=maoleio123"
        dataRetiradaTextBox.Text = Format(Now(), "dd/MM/yyyy")
        horaRetiradaTextBox.Text = Format(Now(), "HH:mm") & " hrs"
        funcRetiradaTextBox.Text = funcRetirada

    End Sub

    Private Sub retiradaCancelButton_Click(sender As Object, e As EventArgs) Handles retiradaCancelButton.Click
        Me.Dispose()
    End Sub

    Private Sub retiradaOKButton_Click(sender As Object, e As EventArgs) Handles retiradaOKButton.Click

        If descricaoRetiradaTextBox.Text.Trim = "" Then
            MsgBox("ERRO", "O campo da descrição da retirada não pode estar vazio.")
            Exit Sub
        End If

        If valorRetiradaTextBox.Text.Trim = "" Then
            MsgBox("ERRO", "O campo do valor da retirada não pode estar vazio.")
            Exit Sub
        End If

        Dim Query As String = "INSERT INTO retiradas VALUES(NULL, @descricao, @valor, @funcionario, @data, @hora);"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@descricao", descricaoRetiradaTextBox.Text)
        Command.Parameters.AddWithValue("@valor", valorRetiradaTextBox.Text)
        Command.Parameters.AddWithValue("@funcionario", funcRetiradaTextBox.Text)
        Command.Parameters.AddWithValue("@data", dataRetiradaTextBox.Text)
        Command.Parameters.AddWithValue("@hora", horaRetiradaTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        Me.Dispose()

    End Sub

End Class