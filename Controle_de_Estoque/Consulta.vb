﻿Imports MySql.Data.MySqlClient

Public Class Consulta

    Private Connection As MySqlConnection = New MySqlConnection
    Private Command As MySqlCommand
    Private Reader As MySqlDataReader

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=h438edJD9d3EKpo3oe3ijfD0"

        produtosDataGridView.Rows.Clear()

        Dim Query As String = "SELECT nome, preco, quantidade, codigo_de_barra, validade FROM produtos;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                Me.produtosDataGridView.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(2), Reader.GetValue(3), Reader.GetValue(4))
            End While

            Reader.Close()
            Connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        produtosDataGridView.ClearSelection()

        For Each Column As DataGridViewColumn In produtosDataGridView.Columns
            Column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        checkMinEstoque()

    End Sub

    Private Sub consultaTextBox_TextChanged(sender As Object, e As EventArgs) Handles consultaTextBox.TextChanged

        Dim index As Integer

        Select Case (True)
            Case nomeRadioButton.Checked
                index = 0
            Case PreçoRadioButton.Checked
                index = 1
            Case quantidadeRadioButton.Checked
                index = 2
            Case codigoRadioButton.Checked
                index = 3
        End Select

        If (consultaTextBox.Text.Trim = "") Then
            For Each row As DataGridViewRow In produtosDataGridView.Rows
                row.Visible = True
                row.Selected = False
            Next
        Else
            For Each row As DataGridViewRow In produtosDataGridView.Rows
                Dim searchLength As Integer = consultaTextBox.Text.Length

                If row.Cells(index).Value.ToString.Length < searchLength Then
                    row.Visible = False
                Else
                    Dim cellValueString As String = row.Cells(index).Value.ToString.Substring(0, (searchLength))

                    If (cellValueString.ToLower.Equals(consultaTextBox.Text.ToLower)) Then
                        row.Visible = True
                    Else
                        row.Visible = False
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub checkMinEstoque()

        For Each row As DataGridViewRow In produtosDataGridView.Rows

            Dim Query As String = "SELECT vencido, estoque_menor FROM produtos WHERE nome = @nome;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@nome", row.Cells(0).Value)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                While Reader.Read
                    If (Not IsDBNull(row.Cells(4).Value) And Not IsDBNull(row.Cells(2).Value)) Then
                        If (Reader.GetValue(0) = 1) Then
                            For Each cell As DataGridViewCell In row.Cells
                                cell.Style.ForeColor = Color.Red
                                cell.Style.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                            Next
                        ElseIf (Reader.GetValue(1) = 1) Then
                            For Each cell As DataGridViewCell In row.Cells
                                cell.Style.ForeColor = Color.Orange
                                cell.Style.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                            Next
                        Else
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
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

        Next

        produtosDataGridView.ClearSelection()

    End Sub

End Class