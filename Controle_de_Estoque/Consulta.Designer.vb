﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.produtosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Código_de_Barra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Validade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.consultaTextBox = New System.Windows.Forms.TextBox()
        Me.nomeRadioButton = New System.Windows.Forms.RadioButton()
        Me.codigoRadioButton = New System.Windows.Forms.RadioButton()
        Me.quantidadeRadioButton = New System.Windows.Forms.RadioButton()
        Me.PreçoRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.produtosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'produtosDataGridView
        '
        Me.produtosDataGridView.AllowUserToAddRows = False
        Me.produtosDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.produtosDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.produtosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Preço, Me.Quantidade, Me.Código_de_Barra, Me.Data_Validade})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.produtosDataGridView.DefaultCellStyle = DataGridViewCellStyle20
        Me.produtosDataGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtosDataGridView.Location = New System.Drawing.Point(3, 122)
        Me.produtosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.produtosDataGridView.Name = "produtosDataGridView"
        Me.produtosDataGridView.ReadOnly = True
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.produtosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.produtosDataGridView.Size = New System.Drawing.Size(906, 773)
        Me.produtosDataGridView.TabIndex = 0
        Me.produtosDataGridView.TabStop = False
        '
        'Nome
        '
        Me.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nome.FillWeight = 40.0!
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Preço
        '
        Me.Preço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Preço.FillWeight = 15.0!
        Me.Preço.HeaderText = "Preço"
        Me.Preço.Name = "Preço"
        Me.Preço.ReadOnly = True
        '
        'Quantidade
        '
        Me.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantidade.FillWeight = 15.0!
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        '
        'Código_de_Barra
        '
        Me.Código_de_Barra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Código_de_Barra.FillWeight = 20.0!
        Me.Código_de_Barra.HeaderText = "Código_de_Barra"
        Me.Código_de_Barra.Name = "Código_de_Barra"
        Me.Código_de_Barra.ReadOnly = True
        '
        'Data_Validade
        '
        Me.Data_Validade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Data_Validade.FillWeight = 15.0!
        Me.Data_Validade.HeaderText = "Data Validade"
        Me.Data_Validade.Name = "Data_Validade"
        Me.Data_Validade.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pesquisar"
        '
        'consultaTextBox
        '
        Me.consultaTextBox.Location = New System.Drawing.Point(114, 20)
        Me.consultaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.consultaTextBox.Name = "consultaTextBox"
        Me.consultaTextBox.Size = New System.Drawing.Size(415, 22)
        Me.consultaTextBox.TabIndex = 0
        '
        'nomeRadioButton
        '
        Me.nomeRadioButton.AutoSize = True
        Me.nomeRadioButton.Checked = True
        Me.nomeRadioButton.Location = New System.Drawing.Point(114, 56)
        Me.nomeRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.nomeRadioButton.Name = "nomeRadioButton"
        Me.nomeRadioButton.Size = New System.Drawing.Size(66, 21)
        Me.nomeRadioButton.TabIndex = 3
        Me.nomeRadioButton.TabStop = True
        Me.nomeRadioButton.Text = "Nome"
        Me.nomeRadioButton.UseVisualStyleBackColor = True
        '
        'codigoRadioButton
        '
        Me.codigoRadioButton.AutoSize = True
        Me.codigoRadioButton.Location = New System.Drawing.Point(205, 84)
        Me.codigoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.codigoRadioButton.Name = "codigoRadioButton"
        Me.codigoRadioButton.Size = New System.Drawing.Size(132, 21)
        Me.codigoRadioButton.TabIndex = 4
        Me.codigoRadioButton.Text = "Código de Barra"
        Me.codigoRadioButton.UseVisualStyleBackColor = True
        '
        'quantidadeRadioButton
        '
        Me.quantidadeRadioButton.AutoSize = True
        Me.quantidadeRadioButton.Location = New System.Drawing.Point(205, 56)
        Me.quantidadeRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.quantidadeRadioButton.Name = "quantidadeRadioButton"
        Me.quantidadeRadioButton.Size = New System.Drawing.Size(103, 21)
        Me.quantidadeRadioButton.TabIndex = 5
        Me.quantidadeRadioButton.Text = "Quantidade"
        Me.quantidadeRadioButton.UseVisualStyleBackColor = True
        '
        'PreçoRadioButton
        '
        Me.PreçoRadioButton.AutoSize = True
        Me.PreçoRadioButton.Location = New System.Drawing.Point(114, 84)
        Me.PreçoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PreçoRadioButton.Name = "PreçoRadioButton"
        Me.PreçoRadioButton.Size = New System.Drawing.Size(66, 21)
        Me.PreçoRadioButton.TabIndex = 6
        Me.PreçoRadioButton.Text = "Preço"
        Me.PreçoRadioButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(683, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Produtos Vencidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(683, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Produtos com Baixo Estoque"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(683, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Produtos OK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(561, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Legenda:"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(912, 653)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PreçoRadioButton)
        Me.Controls.Add(Me.quantidadeRadioButton)
        Me.Controls.Add(Me.codigoRadioButton)
        Me.Controls.Add(Me.nomeRadioButton)
        Me.Controls.Add(Me.consultaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.produtosDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.produtosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents produtosDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents consultaTextBox As TextBox
    Friend WithEvents nomeRadioButton As RadioButton
    Friend WithEvents codigoRadioButton As RadioButton
    Friend WithEvents quantidadeRadioButton As RadioButton
    Friend WithEvents PreçoRadioButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Preço As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Código_de_Barra As DataGridViewTextBoxColumn
    Friend WithEvents Data_Validade As DataGridViewTextBoxColumn
End Class
