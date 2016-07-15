<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Caixa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
            If isAdmin <> True Then
                Login.Dispose()
            End If
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caixa))
        Me.codigoTextBox = New System.Windows.Forms.TextBox()
        Me.CaixaCodigoBarra = New System.Windows.Forms.Label()
        Me.CaixaQuantidade = New System.Windows.Forms.Label()
        Me.produtosListView = New System.Windows.Forms.ListView()
        Me.Produto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Preço = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantidadeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.finalizarButton = New System.Windows.Forms.Button()
        Me.resetarButton = New System.Windows.Forms.Button()
        Me.valorTotalTextBox = New System.Windows.Forms.TextBox()
        Me.CaixaValorTotal = New System.Windows.Forms.Label()
        Me.CaixaFecharButton = New System.Windows.Forms.Button()
        Me.CaixaConsultaButton = New System.Windows.Forms.Button()
        Me.CaixaCancelButton = New System.Windows.Forms.Button()
        Me.userLoggedLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.logoEmpresaPictureBox = New System.Windows.Forms.PictureBox()
        Me.retiradaCaixaButton = New System.Windows.Forms.Button()
        CType(Me.quantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoEmpresaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'codigoTextBox
        '
        Me.codigoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoTextBox.Location = New System.Drawing.Point(567, 26)
        Me.codigoTextBox.Name = "codigoTextBox"
        Me.codigoTextBox.Size = New System.Drawing.Size(358, 26)
        Me.codigoTextBox.TabIndex = 0
        '
        'CaixaCodigoBarra
        '
        Me.CaixaCodigoBarra.AutoSize = True
        Me.CaixaCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaCodigoBarra.Location = New System.Drawing.Point(563, 3)
        Me.CaixaCodigoBarra.Name = "CaixaCodigoBarra"
        Me.CaixaCodigoBarra.Size = New System.Drawing.Size(136, 20)
        Me.CaixaCodigoBarra.TabIndex = 1
        Me.CaixaCodigoBarra.Text = "Código de Barras:"
        '
        'CaixaQuantidade
        '
        Me.CaixaQuantidade.AutoSize = True
        Me.CaixaQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaQuantidade.Location = New System.Drawing.Point(927, 3)
        Me.CaixaQuantidade.Name = "CaixaQuantidade"
        Me.CaixaQuantidade.Size = New System.Drawing.Size(96, 20)
        Me.CaixaQuantidade.TabIndex = 3
        Me.CaixaQuantidade.Text = "Quantidade:"
        '
        'produtosListView
        '
        Me.produtosListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.produtosListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Produto, Me.Preço, Me.Quantidade})
        Me.produtosListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtosListView.FullRowSelect = True
        Me.produtosListView.GridLines = True
        Me.produtosListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.produtosListView.Location = New System.Drawing.Point(567, 58)
        Me.produtosListView.Name = "produtosListView"
        Me.produtosListView.Size = New System.Drawing.Size(456, 642)
        Me.produtosListView.TabIndex = 4
        Me.produtosListView.TabStop = False
        Me.produtosListView.UseCompatibleStateImageBehavior = False
        Me.produtosListView.View = System.Windows.Forms.View.Details
        '
        'Produto
        '
        Me.Produto.Text = "Produto:"
        Me.Produto.Width = 315
        '
        'Preço
        '
        Me.Preço.Text = "Preço:"
        Me.Preço.Width = 70
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quant:"
        Me.Quantidade.Width = 70
        '
        'quantidadeNumericUpDown
        '
        Me.quantidadeNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantidadeNumericUpDown.Location = New System.Drawing.Point(931, 26)
        Me.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown"
        Me.quantidadeNumericUpDown.Size = New System.Drawing.Size(92, 26)
        Me.quantidadeNumericUpDown.TabIndex = 6
        '
        'finalizarButton
        '
        Me.finalizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalizarButton.Location = New System.Drawing.Point(12, 58)
        Me.finalizarButton.Name = "finalizarButton"
        Me.finalizarButton.Size = New System.Drawing.Size(85, 113)
        Me.finalizarButton.TabIndex = 1000000
        Me.finalizarButton.TabStop = False
        Me.finalizarButton.Tag = "21"
        Me.finalizarButton.Text = "Finalizar Compra F[1]"
        Me.finalizarButton.UseVisualStyleBackColor = True
        '
        'resetarButton
        '
        Me.resetarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetarButton.Location = New System.Drawing.Point(12, 534)
        Me.resetarButton.Name = "resetarButton"
        Me.resetarButton.Size = New System.Drawing.Size(85, 113)
        Me.resetarButton.TabIndex = 1000001
        Me.resetarButton.TabStop = False
        Me.resetarButton.Tag = "24"
        Me.resetarButton.Text = "Resetar F[11]"
        Me.resetarButton.UseVisualStyleBackColor = True
        '
        'valorTotalTextBox
        '
        Me.valorTotalTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.valorTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorTotalTextBox.Location = New System.Drawing.Point(810, 706)
        Me.valorTotalTextBox.Name = "valorTotalTextBox"
        Me.valorTotalTextBox.ReadOnly = True
        Me.valorTotalTextBox.Size = New System.Drawing.Size(205, 53)
        Me.valorTotalTextBox.TabIndex = 1000002
        Me.valorTotalTextBox.TabStop = False
        Me.valorTotalTextBox.Text = "R$ 0,00"
        Me.valorTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CaixaValorTotal
        '
        Me.CaixaValorTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaixaValorTotal.AutoSize = True
        Me.CaixaValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaValorTotal.Location = New System.Drawing.Point(567, 709)
        Me.CaixaValorTotal.Name = "CaixaValorTotal"
        Me.CaixaValorTotal.Size = New System.Drawing.Size(237, 46)
        Me.CaixaValorTotal.TabIndex = 1000005
        Me.CaixaValorTotal.Text = "Valor Total:"
        '
        'CaixaFecharButton
        '
        Me.CaixaFecharButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaFecharButton.Location = New System.Drawing.Point(12, 653)
        Me.CaixaFecharButton.Name = "CaixaFecharButton"
        Me.CaixaFecharButton.Size = New System.Drawing.Size(85, 113)
        Me.CaixaFecharButton.TabIndex = 1000008
        Me.CaixaFecharButton.TabStop = False
        Me.CaixaFecharButton.Tag = "25"
        Me.CaixaFecharButton.Text = "Fechar Caixa F[12]"
        Me.CaixaFecharButton.UseVisualStyleBackColor = True
        '
        'CaixaConsultaButton
        '
        Me.CaixaConsultaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaConsultaButton.Location = New System.Drawing.Point(12, 177)
        Me.CaixaConsultaButton.Name = "CaixaConsultaButton"
        Me.CaixaConsultaButton.Size = New System.Drawing.Size(85, 113)
        Me.CaixaConsultaButton.TabIndex = 1000009
        Me.CaixaConsultaButton.TabStop = False
        Me.CaixaConsultaButton.Tag = "22"
        Me.CaixaConsultaButton.Text = "Consulta F[2]"
        Me.CaixaConsultaButton.UseVisualStyleBackColor = True
        '
        'CaixaCancelButton
        '
        Me.CaixaCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaixaCancelButton.Location = New System.Drawing.Point(12, 296)
        Me.CaixaCancelButton.Name = "CaixaCancelButton"
        Me.CaixaCancelButton.Size = New System.Drawing.Size(85, 113)
        Me.CaixaCancelButton.TabIndex = 1000010
        Me.CaixaCancelButton.TabStop = False
        Me.CaixaCancelButton.Tag = "23"
        Me.CaixaCancelButton.Text = "Cancelar Produto F[3]"
        Me.CaixaCancelButton.UseVisualStyleBackColor = True
        '
        'userLoggedLabel
        '
        Me.userLoggedLabel.AutoSize = True
        Me.userLoggedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLoggedLabel.Location = New System.Drawing.Point(6, 9)
        Me.userLoggedLabel.Name = "userLoggedLabel"
        Me.userLoggedLabel.Size = New System.Drawing.Size(228, 31)
        Me.userLoggedLabel.TabIndex = 1000012
        Me.userLoggedLabel.Text = "Usuário Logado:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(103, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 140)
        Me.Button1.TabIndex = 1000013
        Me.Button1.TabStop = False
        Me.Button1.Tag = "0"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(335, 330)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 140)
        Me.Button3.TabIndex = 1000015
        Me.Button3.TabStop = False
        Me.Button3.Tag = "2"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(451, 330)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 140)
        Me.Button4.TabIndex = 1000016
        Me.Button4.TabStop = False
        Me.Button4.Tag = "3"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(103, 476)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 140)
        Me.Button5.TabIndex = 1000017
        Me.Button5.TabStop = False
        Me.Button5.Tag = "4"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(219, 476)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 140)
        Me.Button6.TabIndex = 1000020
        Me.Button6.TabStop = False
        Me.Button6.Tag = "5"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(335, 476)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 140)
        Me.Button7.TabIndex = 1000019
        Me.Button7.TabStop = False
        Me.Button7.Tag = "6"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(451, 476)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 140)
        Me.Button8.TabIndex = 1000018
        Me.Button8.TabStop = False
        Me.Button8.Tag = "7"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(219, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 140)
        Me.Button2.TabIndex = 1000025
        Me.Button2.TabStop = False
        Me.Button2.Tag = "1"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(103, 622)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 140)
        Me.Button9.TabIndex = 1000024
        Me.Button9.TabStop = False
        Me.Button9.Tag = "8"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(219, 622)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 140)
        Me.Button10.TabIndex = 1000023
        Me.Button10.TabStop = False
        Me.Button10.Tag = "9"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button11.Location = New System.Drawing.Point(335, 622)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(110, 140)
        Me.Button11.TabIndex = 1000022
        Me.Button11.TabStop = False
        Me.Button11.Tag = "10"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button12.Location = New System.Drawing.Point(451, 622)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(110, 140)
        Me.Button12.TabIndex = 999999
        Me.Button12.TabStop = False
        Me.Button12.Tag = "11"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button12.UseVisualStyleBackColor = True
        '
        'logoEmpresaPictureBox
        '
        Me.logoEmpresaPictureBox.Location = New System.Drawing.Point(105, 58)
        Me.logoEmpresaPictureBox.Name = "logoEmpresaPictureBox"
        Me.logoEmpresaPictureBox.Size = New System.Drawing.Size(456, 261)
        Me.logoEmpresaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoEmpresaPictureBox.TabIndex = 1000021
        Me.logoEmpresaPictureBox.TabStop = False
        '
        'retiradaCaixaButton
        '
        Me.retiradaCaixaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retiradaCaixaButton.Location = New System.Drawing.Point(12, 415)
        Me.retiradaCaixaButton.Name = "retiradaCaixaButton"
        Me.retiradaCaixaButton.Size = New System.Drawing.Size(85, 113)
        Me.retiradaCaixaButton.TabIndex = 1000026
        Me.retiradaCaixaButton.TabStop = False
        Me.retiradaCaixaButton.Tag = "24"
        Me.retiradaCaixaButton.Text = "Retirada F[4]"
        Me.retiradaCaixaButton.UseVisualStyleBackColor = True
        '
        'Caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.retiradaCaixaButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.logoEmpresaPictureBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.userLoggedLabel)
        Me.Controls.Add(Me.CaixaCancelButton)
        Me.Controls.Add(Me.CaixaConsultaButton)
        Me.Controls.Add(Me.CaixaFecharButton)
        Me.Controls.Add(Me.CaixaValorTotal)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.valorTotalTextBox)
        Me.Controls.Add(Me.resetarButton)
        Me.Controls.Add(Me.finalizarButton)
        Me.Controls.Add(Me.quantidadeNumericUpDown)
        Me.Controls.Add(Me.produtosListView)
        Me.Controls.Add(Me.codigoTextBox)
        Me.Controls.Add(Me.CaixaQuantidade)
        Me.Controls.Add(Me.CaixaCodigoBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Caixa"
        Me.Text = "4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.quantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoEmpresaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codigoTextBox As TextBox
    Friend WithEvents CaixaCodigoBarra As Label
    Friend WithEvents CaixaQuantidade As Label
    Friend WithEvents produtosListView As ListView
    Friend WithEvents Produto As ColumnHeader
    Friend WithEvents Preço As ColumnHeader
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents Button12 As Button
    Friend WithEvents quantidadeNumericUpDown As NumericUpDown
    Friend WithEvents finalizarButton As Button
    Friend WithEvents resetarButton As Button
    Friend WithEvents valorTotalTextBox As TextBox
    Friend WithEvents CaixaValorTotal As Label
    Friend WithEvents CaixaFecharButton As Button
    Friend WithEvents CaixaConsultaButton As Button
    Friend WithEvents CaixaCancelButton As Button
    Friend WithEvents userLoggedLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents logoEmpresaPictureBox As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents retiradaCaixaButton As Button
End Class
