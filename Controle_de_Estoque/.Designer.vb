<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retirada_Pagamentos
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
        Me.descricaoRetiradaTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.funcRetiradaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataRetiradaTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.horaRetiradaTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.valorRetiradaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.retiradaOKButton = New System.Windows.Forms.Button()
        Me.retiradaCancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'descricaoRetiradaTextBox
        '
        Me.descricaoRetiradaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descricaoRetiradaTextBox.Location = New System.Drawing.Point(31, 40)
        Me.descricaoRetiradaTextBox.Name = "descricaoRetiradaTextBox"
        Me.descricaoRetiradaTextBox.Size = New System.Drawing.Size(512, 26)
        Me.descricaoRetiradaTextBox.TabIndex = 136
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 20)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Descrição da Retirada:"
        '
        'funcRetiradaTextBox
        '
        Me.funcRetiradaTextBox.Enabled = False
        Me.funcRetiradaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.funcRetiradaTextBox.Location = New System.Drawing.Point(33, 112)
        Me.funcRetiradaTextBox.Name = "funcRetiradaTextBox"
        Me.funcRetiradaTextBox.Size = New System.Drawing.Size(303, 26)
        Me.funcRetiradaTextBox.TabIndex = 138
        Me.funcRetiradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Funcionário:"
        '
        'dataRetiradaTextBox
        '
        Me.dataRetiradaTextBox.Enabled = False
        Me.dataRetiradaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataRetiradaTextBox.Location = New System.Drawing.Point(342, 112)
        Me.dataRetiradaTextBox.Name = "dataRetiradaTextBox"
        Me.dataRetiradaTextBox.Size = New System.Drawing.Size(201, 26)
        Me.dataRetiradaTextBox.TabIndex = 140
        Me.dataRetiradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Data:"
        '
        'horaRetiradaTextBox
        '
        Me.horaRetiradaTextBox.Enabled = False
        Me.horaRetiradaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaRetiradaTextBox.Location = New System.Drawing.Point(342, 173)
        Me.horaRetiradaTextBox.Name = "horaRetiradaTextBox"
        Me.horaRetiradaTextBox.Size = New System.Drawing.Size(201, 26)
        Me.horaRetiradaTextBox.TabIndex = 142
        Me.horaRetiradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Hora:"
        '
        'valorRetiradaTextBox
        '
        Me.valorRetiradaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorRetiradaTextBox.Location = New System.Drawing.Point(33, 173)
        Me.valorRetiradaTextBox.Name = "valorRetiradaTextBox"
        Me.valorRetiradaTextBox.Size = New System.Drawing.Size(303, 26)
        Me.valorRetiradaTextBox.TabIndex = 144
        Me.valorRetiradaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Valor da Retirada:"
        '
        'retiradaOKButton
        '
        Me.retiradaOKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retiradaOKButton.Location = New System.Drawing.Point(33, 213)
        Me.retiradaOKButton.Name = "retiradaOKButton"
        Me.retiradaOKButton.Size = New System.Drawing.Size(201, 30)
        Me.retiradaOKButton.TabIndex = 146
        Me.retiradaOKButton.Text = "OK"
        Me.retiradaOKButton.UseVisualStyleBackColor = True
        '
        'retiradaCancelButton
        '
        Me.retiradaCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retiradaCancelButton.Location = New System.Drawing.Point(342, 213)
        Me.retiradaCancelButton.Name = "retiradaCancelButton"
        Me.retiradaCancelButton.Size = New System.Drawing.Size(201, 30)
        Me.retiradaCancelButton.TabIndex = 147
        Me.retiradaCancelButton.Text = "Cancelar"
        Me.retiradaCancelButton.UseVisualStyleBackColor = True
        '
        'Retirada_Pagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 271)
        Me.Controls.Add(Me.retiradaCancelButton)
        Me.Controls.Add(Me.retiradaOKButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.valorRetiradaTextBox)
        Me.Controls.Add(Me.horaRetiradaTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dataRetiradaTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.funcRetiradaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.descricaoRetiradaTextBox)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Retirada_Pagamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirada / Pagamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descricaoRetiradaTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents funcRetiradaTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dataRetiradaTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents horaRetiradaTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents valorRetiradaTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents retiradaOKButton As Button
    Friend WithEvents retiradaCancelButton As Button
End Class
