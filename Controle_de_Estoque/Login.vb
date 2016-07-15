Imports MySql.Data.MySqlClient

Public Class Login

    Private Connection As MySqlConnection = New MySqlConnection
    Private Command As MySqlCommand
    Private Reader As MySqlDataReader

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=maoleio123"

        Dim Query As String = "SELECT userSalvo, passwordSalvo FROM login_salvos;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                userTextBox.Text = Reader.GetString(0)
                passwordTextBox.Text = Reader.GetString(1)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If passwordTextBox.Text.Trim <> "" Or userTextBox.Text.Trim <> "" Then

            rememberCheckBox.Checked = True

        End If

    End Sub

    Private Sub rememberCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles rememberCheckBox.CheckStateChanged

        If rememberCheckBox.Checked Then
            savedLogin(userTextBox.Text, passwordTextBox.Text)
        Else
            savedLogin("", "")
        End If

    End Sub

    Private Sub savedLogin(user As String, password As String)

        Dim Query As String = "UPDATE login_salvos SET userSalvo = @user, passwordSalvo = @password WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@user", user)
        Command.Parameters.AddWithValue("@password", password)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click

        Dim Query As String = "SELECT password, isAdmin, id FROM login WHERE user = @user;"
        Dim passwordBD As String = ""
        Dim isAdminBD As Boolean
        Dim userLoggedID As Integer
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@user", userTextBox.Text)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                passwordBD = Reader.GetString(0)
                isAdminBD = Reader.GetBoolean(1)
                userLoggedID = Reader.GetInt32(2)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Query = "UPDATE login SET userIsLogged = 1 WHERE id = @userID"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@userID", userLoggedID)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        If passwordBD = passwordTextBox.Text And isAdminBD Then

            registerDateLogged()
            Form_Admin.Show()
            Me.Hide()

        ElseIf passwordBD = passwordTextBox.Text And Not isAdminBD Then

            registerDateLogged()
            Me.Hide()
            Caixa.Show()

        Else
            MsgBox("Senha ou usuário incorreto")
        End If

    End Sub

    Private Sub registerDateLogged()

        Dim Query As String = "UPDATE login SET lastDateLogged = @date WHERE user = @user;"
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@date", Date.Now.ToString)
        Command.Parameters.AddWithValue("@user", userTextBox.Text)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub userTextBox_TextChanged(sender As Object, e As EventArgs) Handles userTextBox.TextChanged
        rememberCheckBox.Checked = False
    End Sub

    Private Sub passwordTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles passwordTextBox.MaskInputRejected
        rememberCheckBox.Checked = False
    End Sub

End Class