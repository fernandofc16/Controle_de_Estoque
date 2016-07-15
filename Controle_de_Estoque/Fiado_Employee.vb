Imports MySql.Data.MySqlClient

Public Class Fiado_Employee

    Private Connection As New MySqlConnection
    Private Command As MySqlCommand
    Private Reader As MySqlDataReader

    Private Sub Fiado_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=maoleio123"
        requestEmployeeFiadoComboBox()

    End Sub

    Private Sub Fiado_Employee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub requestEmployeeFiadoComboBox()

        Dim Query As String = "SELECT Name FROM employee WHERE assinatura_digital IS NOT NULL;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader

            While Reader.Read
                employeeFiadoComboBox.Items.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If employeeFiadoComboBox.Items.Count <= 0 Then
            employeeFiadoComboBox.Items.Add("Nenhum Funcionário Cadastrado")
        End If

        employeeFiadoComboBox.SelectedIndex = 0

    End Sub

    Private Sub employeeFiadoOKButton_Click(sender As Object, e As EventArgs) Handles employeeFiadoOKButton.Click

        Dim Query As String = "SELECT assinatura_digital FROM employee WHERE Name = @nome;"
        Dim assinaturaDigital As String = ""
        Command = New MySqlCommand(Query, Connection)
        Command.Parameters.AddWithValue("@nome", employeeFiadoComboBox.SelectedItem)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                assinaturaDigital = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If assinaturaDigital = assinaturaDigitalTextBox.Text.Trim Then
            Query = "SELECT id FROM employee WHERE Name = @nome;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@nome", employeeFiadoComboBox.SelectedItem)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                While Reader.Read
                    Caixa.id_employee = Reader.GetValue(0)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try
            Caixa.FiadoResult = True
            Me.Dispose()
        Else
            MsgBox("Assinatura Inválida")
            assinaturaDigitalTextBox.Text = ""
        End If

    End Sub

    Private Sub assinaturaDigitalTextBox_TextChanged(sender As Object, e As EventArgs) Handles assinaturaDigitalTextBox.TextChanged
        If assinaturaDigitalTextBox.Text.Count = 6 Then
            employeeFiadoOKButton.Focus()
        End If
    End Sub

End Class