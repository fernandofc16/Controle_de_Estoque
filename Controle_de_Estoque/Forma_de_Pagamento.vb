Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Forma_de_Pagamento

    Private Connection As New MySqlConnection
    Private Command As MySqlCommand
    Private Reader As MySqlDataReader
    Public fechou As Boolean = False

    Private Sub Forma_de_Pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=h438edJD9d3EKpo3oe3ijfD0"
        requestComboBoxFormasDePagamento()
        Me.Size = New Size(410, 210)

    End Sub

    Private Sub Forma_de_Pagamento_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        fechou = True
    End Sub

    Private Sub requestComboBoxFormasDePagamento()
        formaPagamentoComboBox.Items.Clear()

        Dim Query As String = "SELECT forma_de_pagamento FROM formas_de_pagamento;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read
                formaPagamentoComboBox.Items.Add(Reader.GetValue(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If formaPagamentoComboBox.Items.Count = 0 Then
            formaPagamentoComboBox.Items.Add("NULL")
        End If

        formaPagamentoComboBox.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles formaPagamentoOKButton.Click
        finalizarEscolhaPagamento()
    End Sub

    Private Sub formaPagamentoComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles formaPagamentoComboBox.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                finalizarEscolhaPagamento()
        End Select

    End Sub

    Private Sub finalizarEscolhaPagamento()
        If formaPagamentoComboBox.SelectedItem = "Fiado" Then
            Fiado_Employee.ShowDialog()
            Me.Visible = False
        End If
        Caixa.formaDePagamentoSelecionado = formaPagamentoComboBox.SelectedItem
        Me.Dispose()
    End Sub

    Private Sub formaPagamentoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formaPagamentoComboBox.SelectedIndexChanged
        If formaPagamentoComboBox.SelectedItem = "Dinheiro" Then
            Me.Size = New Size(410, 370)
            valorPagoLabel.Enabled = True
            valorPagoTextBox.Enabled = True
        Else
            Me.Size = New Size(410, 210)
            valorPagoLabel.Enabled = False
            valorPagoTextBox.Enabled = False
        End If
    End Sub

    Private Sub valorPagoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valorPagoTextBox.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,]").IsMatch(e.KeyChar)
    End Sub

    Private Sub valorPagoTextBox_TextChanged(sender As Object, e As EventArgs) Handles valorPagoTextBox.TextChanged

        If (valorPagoTextBox.Text.Trim <> "") Then

            valorPagoTextBox.SelectionStart = valorPagoTextBox.Text.Length
            Dim cleanString As String = valorPagoTextBox.Text.ToString.Replace(",", "")
            Dim cleanString2 As String = cleanString.Replace("R$", "")

            Dim parsed As Double = Double.Parse(cleanString2.Trim)
            Dim stringFormatted As String = FormatCurrency(parsed / 100)
            valorPagoTextBox.Text = stringFormatted

        End If

        Dim troco As Double = 0
        Try
            If valorPagoTextBox.Text.Replace("R$", "").Trim <> "" Then
                troco = CDbl(valorPagoTextBox.Text.Replace("R$", "").Trim) - Caixa.valorTotal
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If troco > 0 Then
            trocoTextBox.Text = Format(troco, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")
        Else
            trocoTextBox.Text = "R$ 0,00"
        End If

    End Sub

End Class