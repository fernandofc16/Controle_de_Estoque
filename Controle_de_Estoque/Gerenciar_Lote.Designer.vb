<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerenciar_Lote
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
        Me.gerenciarLoteProdutoPictureBox = New System.Windows.Forms.PictureBox()
        Me.gerenciarLoteProdutoNomeLabel = New System.Windows.Forms.Label()
        Me.gerenciarLoteLotesComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gerenciarLoteQuantidadeProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gerenciarLoteValidadeProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gerenciarLoteAdicionarLoteButton = New System.Windows.Forms.Button()
        Me.isLoteCadLabel = New System.Windows.Forms.Label()
        Me.gerenciarLoteCadastrarLoteButton = New System.Windows.Forms.Button()
        Me.removerLoteButton = New System.Windows.Forms.Button()
        CType(Me.gerenciarLoteProdutoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gerenciarLoteProdutoPictureBox
        '
        Me.gerenciarLoteProdutoPictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_produto_photo
        Me.gerenciarLoteProdutoPictureBox.Location = New System.Drawing.Point(35, 62)
        Me.gerenciarLoteProdutoPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gerenciarLoteProdutoPictureBox.Name = "gerenciarLoteProdutoPictureBox"
        Me.gerenciarLoteProdutoPictureBox.Size = New System.Drawing.Size(162, 169)
        Me.gerenciarLoteProdutoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gerenciarLoteProdutoPictureBox.TabIndex = 51
        Me.gerenciarLoteProdutoPictureBox.TabStop = False
        '
        'gerenciarLoteProdutoNomeLabel
        '
        Me.gerenciarLoteProdutoNomeLabel.AutoSize = True
        Me.gerenciarLoteProdutoNomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerenciarLoteProdutoNomeLabel.Location = New System.Drawing.Point(30, 22)
        Me.gerenciarLoteProdutoNomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gerenciarLoteProdutoNomeLabel.Name = "gerenciarLoteProdutoNomeLabel"
        Me.gerenciarLoteProdutoNomeLabel.Size = New System.Drawing.Size(137, 25)
        Me.gerenciarLoteProdutoNomeLabel.TabIndex = 52
        Me.gerenciarLoteProdutoNomeLabel.Text = "Nome Produto"
        '
        'gerenciarLoteLotesComboBox
        '
        Me.gerenciarLoteLotesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gerenciarLoteLotesComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerenciarLoteLotesComboBox.FormattingEnabled = True
        Me.gerenciarLoteLotesComboBox.Location = New System.Drawing.Point(265, 102)
        Me.gerenciarLoteLotesComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gerenciarLoteLotesComboBox.Name = "gerenciarLoteLotesComboBox"
        Me.gerenciarLoteLotesComboBox.Size = New System.Drawing.Size(118, 33)
        Me.gerenciarLoteLotesComboBox.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Lotes:"
        '
        'gerenciarLoteQuantidadeProdTextBox
        '
        Me.gerenciarLoteQuantidadeProdTextBox.Enabled = False
        Me.gerenciarLoteQuantidadeProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerenciarLoteQuantidadeProdTextBox.Location = New System.Drawing.Point(265, 184)
        Me.gerenciarLoteQuantidadeProdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gerenciarLoteQuantidadeProdTextBox.Name = "gerenciarLoteQuantidadeProdTextBox"
        Me.gerenciarLoteQuantidadeProdTextBox.Size = New System.Drawing.Size(118, 30)
        Me.gerenciarLoteQuantidadeProdTextBox.TabIndex = 55
        Me.gerenciarLoteQuantidadeProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(260, 155)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 25)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Quantidade:"
        '
        'gerenciarLoteValidadeProdTextBox
        '
        Me.gerenciarLoteValidadeProdTextBox.Enabled = False
        Me.gerenciarLoteValidadeProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerenciarLoteValidadeProdTextBox.Location = New System.Drawing.Point(440, 184)
        Me.gerenciarLoteValidadeProdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gerenciarLoteValidadeProdTextBox.Name = "gerenciarLoteValidadeProdTextBox"
        Me.gerenciarLoteValidadeProdTextBox.Size = New System.Drawing.Size(249, 30)
        Me.gerenciarLoteValidadeProdTextBox.TabIndex = 57
        Me.gerenciarLoteValidadeProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(435, 155)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(168, 25)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Data de Validade:"
        '
        'gerenciarLoteAdicionarLoteButton
        '
        Me.gerenciarLoteAdicionarLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerenciarLoteAdicionarLoteButton.Location = New System.Drawing.Point(485, 102)
        Me.gerenciarLoteAdicionarLoteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gerenciarLoteAdicionarLoteButton.Name = "gerenciarLoteAdicionarLoteButton"
        Me.gerenciarLoteAdicionarLoteButton.Size = New System.Drawing.Size(205, 35)
        Me.gerenciarLoteAdicionarLoteButton.TabIndex = 59
        Me.gerenciarLoteAdicionarLoteButton.Text = "Adicionar Novo Lote"
        Me.gerenciarLoteAdicionarLoteButton.UseVisualStyleBackColor = True
        '
        'isLoteCadLabel
        '
        Me.isLoteCadLabel.AutoSize = True
        Me.isLoteCadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isLoteCadLabel.Location = New System.Drawing.Point(356, 22)
        Me.isLoteCadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.isLoteCadLabel.Name = "isLoteCadLabel"
        Me.isLoteCadLabel.Size = New System.Drawing.Size(241, 29)
        Me.isLoteCadLabel.TabIndex = 126
        Me.isLoteCadLabel.Text = "Lote Não Cadastrado"
        '
        'gerenciarLoteCadastrarLoteButton
        '
        Me.gerenciarLoteCadastrarLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerenciarLoteCadastrarLoteButton.Location = New System.Drawing.Point(265, 245)
        Me.gerenciarLoteCadastrarLoteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gerenciarLoteCadastrarLoteButton.Name = "gerenciarLoteCadastrarLoteButton"
        Me.gerenciarLoteCadastrarLoteButton.Size = New System.Drawing.Size(155, 38)
        Me.gerenciarLoteCadastrarLoteButton.TabIndex = 131
        Me.gerenciarLoteCadastrarLoteButton.Text = "Cadastrar Lote"
        Me.gerenciarLoteCadastrarLoteButton.UseVisualStyleBackColor = True
        '
        'removerLoteButton
        '
        Me.removerLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerLoteButton.Location = New System.Drawing.Point(535, 245)
        Me.removerLoteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.removerLoteButton.Name = "removerLoteButton"
        Me.removerLoteButton.Size = New System.Drawing.Size(155, 38)
        Me.removerLoteButton.TabIndex = 132
        Me.removerLoteButton.Text = "Remover Lote"
        Me.removerLoteButton.UseVisualStyleBackColor = True
        '
        'Gerenciar_Lote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(720, 309)
        Me.Controls.Add(Me.removerLoteButton)
        Me.Controls.Add(Me.gerenciarLoteCadastrarLoteButton)
        Me.Controls.Add(Me.isLoteCadLabel)
        Me.Controls.Add(Me.gerenciarLoteAdicionarLoteButton)
        Me.Controls.Add(Me.gerenciarLoteValidadeProdTextBox)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.gerenciarLoteQuantidadeProdTextBox)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gerenciarLoteLotesComboBox)
        Me.Controls.Add(Me.gerenciarLoteProdutoNomeLabel)
        Me.Controls.Add(Me.gerenciarLoteProdutoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gerenciar_Lote"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Lotes"
        Me.TopMost = True
        CType(Me.gerenciarLoteProdutoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gerenciarLoteProdutoPictureBox As PictureBox
    Friend WithEvents gerenciarLoteProdutoNomeLabel As Label
    Friend WithEvents gerenciarLoteLotesComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gerenciarLoteQuantidadeProdTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gerenciarLoteValidadeProdTextBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents gerenciarLoteAdicionarLoteButton As Button
    Friend WithEvents isLoteCadLabel As Label
    Friend WithEvents gerenciarLoteCadastrarLoteButton As Button
    Friend WithEvents removerLoteButton As Button
End Class
