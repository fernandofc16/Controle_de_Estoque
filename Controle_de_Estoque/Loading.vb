Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Net.Mail
Imports System.IO

Public Class Loading

    Private Connection As MySqlConnection = New MySqlConnection
    Private Command As MySqlCommand
    Private Reader As MySqlDataReader

    Private pdfDoc As New Document
    Private pdfWriter As PdfWriter
    Private email As New MailMessage()

    Private emailLogin, emailType As String
    Private directoryFile As String
    Private erroText As String

    Private messageSent As Boolean = False
    Private erroOcurr As Boolean = False

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectionString = "Server=localhost;Database=controle_de_estoque;Uid=root;Pwd=h438edJD9d3EKpo3oe3ijfD0"
        ProgressBar1.Maximum = 150
        Timer1.Interval = 10
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (ProgressBar1.Value < 149) Then
            ProgressBar1.Increment(1)
        End If

        If (ProgressBar1.Value = 149 And messageSent) Then
            ProgressBar1.Increment(1)
            Timer1.Stop()
            Me.Dispose()
        End If

        If (erroOcurr) Then
            Timer1.Stop()
            MsgBox("Erro ao tentar enviar relatório" & vbNewLine & erroText)
            Me.Dispose()
            Form_Admin.Show()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        createPDF()

    End Sub

    Private Sub createPDF()

        Dim criouNovoPDF As Boolean = False
        Dim numeroFile As Integer = 1
        While Not criouNovoPDF

            directoryFile = "C:/PDFsFiles/Relatório_dia_" & Date.Now.ToString("dd_MM_yyyy") & "_" & numeroFile & ".pdf"

            Try

                If My.Computer.FileSystem.DirectoryExists("C:/PDFsFiles/") Then
                Else
                    My.Computer.FileSystem.CreateDirectory("C:/PDFsFiles/")
                End If

                If My.Computer.FileSystem.FileExists(directoryFile) Then
                    numeroFile += 1
                Else
                    criouNovoPDF = True
                End If

            Catch ex As Exception

                erroText = ex.Message
                erroOcurr = True
                Exit Sub

            End Try

        End While

        pdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(directoryFile, FileMode.Create))
        pdfWriter.ViewerPreferences = PdfWriter.PageLayoutTwoColumnLeft

        Dim Query As String = "SELECT report_option FROM report_option WHERE id = 1;"
        Command = New MySqlCommand(Query, Connection)
        Dim Report_Option As Integer

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read()
                Report_Option = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Select Case Report_Option
            Case 0
                buscarRelatorioResumidoSQL()
            Case 1
                buscarRelatorioCompletoSQL()
        End Select

    End Sub

    Private Sub buscarRelatorioResumidoSQL()
        Dim Query As String = "SELECT nome FROM produtos;"
        Dim ArrayProdutos As ArrayList = New ArrayList
        Dim ArrayQuantidades As ArrayList = New ArrayList

        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                ArrayProdutos.Add(Reader.GetValue(0).ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        For Each produto As String In ArrayProdutos

            Query = "SELECT SUM(vendas.quantidades) FROM faturamentos
                                                    JOIN vendas ON id_faturamentos = faturamentos.id
                                                    WHERE produtos = @produto AND fiado_reported != 1;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@produto", produto)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader()

                ArrayQuantidades.Add(0)

                While Reader.Read()
                    If Reader.GetValue(0) IsNot DBNull.Value Then
                        ArrayQuantidades(ArrayProdutos.IndexOf(produto)) += Reader.GetValue(0)
                    End If
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

        Next

        pdfDoc.Open()
        pdfDoc.Add(New Paragraph("Relatório Resumido do Restaurante - Dia " & Date.Now.ToString("dd/MM/yyyy")))

        pdfDoc.Add(New Paragraph(" "))
        pdfDoc.Add(New Paragraph(" "))

        Dim list As New List(List.UNORDERED)
        list.IndentationLeft = 30.0F
        list.Add(New ListItem(" Produtos vendidos: "))

        Dim indexProd As Integer = 0
        For Each produto As String In ArrayProdutos

            list.Add("       x" & ArrayQuantidades(indexProd) & " " & produto)
            indexProd += 1

        Next

        pdfDoc.Add(list)
        pdfDoc.Add(New Paragraph(" "))

        Dim valorTotal As Double = 0
        Query = "SELECT SUM(valores) FROM faturamentos WHERE fiado_reported != 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                If Reader.GetValue(0) IsNot DBNull.Value Then
                    valorTotal = Reader.GetValue(0)
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()

            If valorTotal <> 0 Then
                pdfDoc.Add(New Paragraph("Faturamento Total: " & Format(valorTotal, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")))
            Else
                pdfDoc.Add(New Paragraph("Faturamento Total: R$ 0,00"))
            End If

        End Try

        Dim ArrayFormasPagamento As New ArrayList

        Query = "SELECT forma_de_pagamento FROM formas_de_pagamento;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                ArrayFormasPagamento.Add(Reader.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        For Each pagamento As String In ArrayFormasPagamento

            Dim valorTotalPagamento As Double = 0
            Query = "SELECT valores FROM faturamentos WHERE forma_pagamento = @forma_pagamento AND fiado_reported != 1;"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@forma_pagamento", pagamento)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                While Reader.Read
                    If Reader.GetValue(0) IsNot DBNull.Value Then
                        valorTotalPagamento += Reader.GetValue(0)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

            If valorTotalPagamento <> 0 Then
                pdfDoc.Add(New Paragraph("Faturamento Total em " & pagamento & ": " & Format(valorTotalPagamento, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")))
            Else
                pdfDoc.Add(New Paragraph("Faturamento Total em " & pagamento & ": " & "R$ 0,00"))
            End If

        Next

        retiradasRelatorio()
        checkItensVencidosAndEstoqueMin()
        pdfDoc.Close()
        enviarEmail(directoryFile)

    End Sub

    Private Sub checkItensVencidosAndEstoqueMin()
        Dim itensVencidos As Integer = 0
        Dim Query As String = "SELECT COUNT(nome) FROM produtos WHERE vencido = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                itensVencidos = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If itensVencidos > 0 Then
            Query = "SELECT nome FROM produtos WHERE vencido = 1;"
            Command = New MySqlCommand(Query, Connection)

            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" Produtos vencidos: "))
            Dim listVencidos As New List(List.UNORDERED)
            listVencidos.IndentationLeft = 30.0F

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                While Reader.Read
                    listVencidos.Add(Reader.GetValue(0))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                pdfDoc.Add(listVencidos)
                Reader.Close()
                Connection.Close()
            End Try
        End If

        Dim itensEstoqueMin As Integer = 0
        Query = "SELECT COUNT(nome) FROM produtos WHERE estoque_menor = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                itensEstoqueMin = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If itensEstoqueMin > 0 Then
            Query = "SELECT nome FROM produtos WHERE estoque_menor = 1;"
            Command = New MySqlCommand(Query, Connection)

            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" Produtos com estoque mínimo: "))
            Dim listEstoqueMin As New List(List.UNORDERED)
            listEstoqueMin.IndentationLeft = 30.0F

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                While Reader.Read
                    listEstoqueMin.Add(Reader.GetValue(0))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                pdfDoc.Add(listEstoqueMin)
                Reader.Close()
                Connection.Close()
            End Try
        End If

        Query = "UPDATE faturamentos SET fiado_reported = 1 WHERE fiado_reported = 0 AND forma_pagamento = 'Fiado'"
        Command = New MySqlCommand(Query, Connection)
        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

        pdfDoc.Close()
        pdfWriter.Dispose()
    End Sub

    Private Sub buscarRelatorioCompletoSQL()

        Dim Query As String = "SELECT vendas.id_faturamentos, vendas.produtos, vendas.quantidades, faturamentos.valores, faturamentos.datas, faturamentos.horas, faturamentos.forma_pagamento, faturamentos.employee_sold
                               FROM faturamentos
                               JOIN vendas ON id_faturamentos = faturamentos.id
                               WHERE faturamentos.fiado_reported != 1;"
        Command = New MySqlCommand(Query, Connection)
        Dim idPorVenda, quantidade As Integer
        Dim produtos, valores, formaDePagamento As String
        Dim valorTotal As Double = 0
        Dim data As String = ""
        Dim hora As String = ""
        Dim employeeSold = ""

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()
            pdfDoc.Open()

            pdfDoc.Add(New Paragraph("Relatório Detalhado do Restaurante - Dia " & Date.Now.ToString("dd/MM/yyyy")))

            While Reader.Read()

                If (idPorVenda <> Reader.GetInt32(0)) Then

                    pdfDoc.Add(New Paragraph(" "))
                    pdfDoc.Add(New Paragraph(" "))
                    idPorVenda = Reader.GetInt32(0)
                    produtos = Reader.GetString(1)
                    quantidade = Reader.GetInt32(2)
                    valores = Reader.GetValue(3)
                    data = Reader.GetValue(4)
                    hora = Reader.GetValue(5)
                    formaDePagamento = Reader.GetValue(6)
                    employeeSold = Reader.GetValue(7)

                    If valores <> 0 Then
                        pdfDoc.Add(New Paragraph("Funcionário que efetivou a venda: " & employeeSold))
                        pdfDoc.Add(New Paragraph("Data: " & data & "  Hora: " & hora))
                        pdfDoc.Add(New Paragraph("Forma de Pagamento: " & formaDePagamento & "   Valor da venda: " & Format(CDbl(valores), "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")))
                    Else
                        pdfDoc.Add(New Paragraph("Funcionário que efetivou a venda: " & employeeSold))
                        pdfDoc.Add(New Paragraph("Data: " & data & "  Hora: " & hora))
                        pdfDoc.Add(New Paragraph("Forma de Pagamento: " & formaDePagamento & "   Valor da venda: R$ 0,00"))
                    End If

                    pdfDoc.Add(New Paragraph("Produtos: " & "x" & quantidade & "   " & produtos))
                    valorTotal += valores

                Else

                    produtos = Reader.GetString(1)
                    quantidade = Reader.GetInt32(2)
                    pdfDoc.Add(New Paragraph("                " & "x" & quantidade & "   " & produtos))

                End If

            End While

            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Faturamento Total: R$" & valorTotal))

        Catch ex As Exception
            erroText = ex.Message
            erroOcurr = True
            Exit Sub
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Dim ArrayFormasPagamento As New ArrayList

        Query = "SELECT forma_de_pagamento FROM formas_de_pagamento;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                ArrayFormasPagamento.Add(Reader.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        For Each pagamento As String In ArrayFormasPagamento

            Dim valorTotalPagamento As Double = 0
            Query = "SELECT valores FROM faturamentos WHERE forma_pagamento = @forma_pagamento AND fiado_reported != 1"
            Command = New MySqlCommand(Query, Connection)
            Command.Parameters.AddWithValue("@forma_pagamento", pagamento)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                While Reader.Read
                    valorTotalPagamento += Reader.GetValue(0)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try

            If valorTotalPagamento <> 0 Then
                pdfDoc.Add(New Paragraph("Faturamento Total em " & pagamento & ": " & Format(valorTotalPagamento, "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")))
            Else
                pdfDoc.Add(New Paragraph("Faturamento Total em " & pagamento & ": " & "R$ 0,00"))
            End If

        Next

        retiradasRelatorio()
        checkItensVencidosAndEstoqueMin()
        pdfDoc.Close()
        enviarEmail(directoryFile)

    End Sub

    Private Sub enviarEmail(directoryOfArchiveToSend As String)

        Dim Query As String = "SELECT email, emailType FROM login where isAdmin = true;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader()

            While Reader.Read()
                emailLogin = Reader.GetValue(0).ToString
                emailType = Reader.GetValue(1).ToString
            End While

        Catch ex As Exception

            Reader.Close()
            Connection.Close()
            erroText = ex.Message
            erroOcurr = True
            Exit Sub
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        Try
            Dim servidorSMTP As New SmtpClient()
            Dim BodyEmail As String = ""

            If emailType = "@globomail.com" Then
                servidorSMTP.Host = "smtp.globo.com "
            ElseIf emailType = "@outlook.com" Or emailType = "@hotmail.com" Then
                servidorSMTP.Host = "smtp-mail.outlook.com"
            ElseIf emailType = "@yahoo.com.br" Then
                servidorSMTP.Host = "smtp.mail.yahoo.com.br"
            ElseIf emailType = "@bol.com.br" Then
                servidorSMTP.Host = "smtps.bol.com.br"
            End If

            servidorSMTP.Host = "smtps.bol.com.br"
            servidorSMTP.Credentials = New Net.NetworkCredential("automatico-relatario@bol.com.br", "maoleio123") '(emailLogin & emailType, emailPassword)
            servidorSMTP.Port = 587
            servidorSMTP.EnableSsl = True

            email = New MailMessage
            email.From = New MailAddress("automatico-relatario@bol.com.br")
            email.To.Add(emailLogin & emailType)
            email.Subject = "Relatório Automático - Dia:  " + Date.Now.ToString("dd/MM/yyyy")
            email.Attachments.Add(New Attachment(directoryOfArchiveToSend))
            servidorSMTP.Send(email)

        Catch ex As Exception

            email.Dispose()
            erroText = ex.Message
            erroOcurr = True
            Exit Sub

        End Try

        messageSent = True

        Query = "DELETE FROM faturamentos WHERE isDel = 1;"
        Command = New MySqlCommand(Query, Connection)

        Try

            Connection.Open()
            Command.ExecuteNonQuery()

        Catch ex As Exception

            Connection.Close()
            erroText = ex.Message
            erroOcurr = True
            Exit Sub
        Finally
            Connection.Close()
        End Try

        Query = "TRUNCATE TABLE retiradas;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection.Close()
        End Try

    End Sub

    Private Sub retiradasRelatorio()
        Dim quant As Integer = 0
        Dim Query As String = "SELECT COUNT(*) FROM retiradas;"
        Command = New MySqlCommand(Query, Connection)

        Try
            Connection.Open()
            Reader = Command.ExecuteReader
            While Reader.Read
                quant = Reader.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Reader.Close()
            Connection.Close()
        End Try

        If quant <> 0 Then
            Query = "SELECT * FROM retiradas;"
            Command = New MySqlCommand(Query, Connection)

            Try
                Connection.Open()
                Reader = Command.ExecuteReader
                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph(" "))
                pdfDoc.Add(New Paragraph("Retiradas / Pagamentos:"))
                pdfDoc.Add(New Paragraph(" "))
                While Reader.Read
                    pdfDoc.Add(New Paragraph("Descrição: " & CStr(Reader.GetValue(1))))
                    pdfDoc.Add(New Paragraph("Valor Retirado: " & Format(CDbl(Reader.GetString(2)), "R$ ###,###.00;R$ ###,###.#0;R$ ###,###.##;")))
                    pdfDoc.Add(New Paragraph("Funcionário que retirou: " & CStr(Reader.GetValue(3))))
                    pdfDoc.Add(New Paragraph("Data: " & CStr(Reader.GetValue(4)) & "    Hora: " & CStr(Reader.GetValue(5))))
                    pdfDoc.Add(New Paragraph(" "))
                    pdfDoc.Add(New Paragraph(" "))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Reader.Close()
                Connection.Close()
            End Try
        End If

    End Sub

End Class