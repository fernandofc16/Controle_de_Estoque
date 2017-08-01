<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forma_de_Pagamento
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
        Me.formaPagamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.formaPagamentoOKButton = New System.Windows.Forms.Button()
        Me.valorPagoLabel = New System.Windows.Forms.Label()
        Me.valorPagoTextBox = New System.Windows.Forms.TextBox()
        Me.trocoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'formaPagamentoComboBox
        '
        Me.formaPagamentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.formaPagamentoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formaPagamentoComboBox.FormattingEnabled = True
        Me.formaPagamentoComboBox.Location = New System.Drawing.Point(47, 63)
        Me.formaPagamentoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.formaPagamentoComboBox.Name = "formaPagamentoComboBox"
        Me.formaPagamentoComboBox.Size = New System.Drawing.Size(297, 33)
        Me.formaPagamentoComboBox.TabIndex = 1000008
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 29)
        Me.Label1.TabIndex = 1000009
        Me.Label1.Text = "Forma de Pagamento:"
        '
        'formaPagamentoOKButton
        '
        Me.formaPagamentoOKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formaPagamentoOKButton.Location = New System.Drawing.Point(47, 105)
        Me.formaPagamentoOKButton.Margin = New System.Windows.Forms.Padding(4)
        Me.formaPagamentoOKButton.Name = "formaPagamentoOKButton"
        Me.formaPagamentoOKButton.Size = New System.Drawing.Size(299, 33)
        Me.formaPagamentoOKButton.TabIndex = 1
        Me.formaPagamentoOKButton.Text = "OK"
        Me.formaPagamentoOKButton.UseVisualStyleBackColor = True
        '
        'valorPagoLabel
        '
        Me.valorPagoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valorPagoLabel.AutoSize = True
        Me.valorPagoLabel.Enabled = False
        Me.valorPagoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorPagoLabel.Location = New System.Drawing.Point(40, 162)
        Me.valorPagoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.valorPagoLabel.Name = "valorPagoLabel"
        Me.valorPagoLabel.Size = New System.Drawing.Size(156, 29)
        Me.valorPagoLabel.TabIndex = 1000011
        Me.valorPagoLabel.Text = "Valor Pago:"
        '
        'valorPagoTextBox
        '
        Me.valorPagoTextBox.Enabled = False
        Me.valorPagoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorPagoTextBox.Location = New System.Drawing.Point(47, 197)
        Me.valorPagoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.valorPagoTextBox.Name = "valorPagoTextBox"
        Me.valorPagoTextBox.Size = New System.Drawing.Size(297, 36)
        Me.valorPagoTextBox.TabIndex = 1000012
        '
        'trocoTextBox
        '
        Me.trocoTextBox.Enabled = False
        Me.trocoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trocoTextBox.Location = New System.Drawing.Point(47, 272)
        Me.trocoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.trocoTextBox.Name = "trocoTextBox"
        Me.trocoTextBox.Size = New System.Drawing.Size(297, 36)
        Me.trocoTextBox.TabIndex = 1000014
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 238)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 29)
        Me.Label2.TabIndex = 1000013
        Me.Label2.Text = "Troco:"
        '
        'Forma_de_Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(392, 163)
        Me.Controls.Add(Me.trocoTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.valorPagoTextBox)
        Me.Controls.Add(Me.valorPagoLabel)
        Me.Controls.Add(Me.formaPagamentoOKButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.formaPagamentoComboBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Forma_de_Pagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents formaPagamentoComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents formaPagamentoOKButton As Button
    Friend WithEvents valorPagoLabel As Label
    Friend WithEvents valorPagoTextBox As TextBox
    Friend WithEvents trocoTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
