<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiado_Employee
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
        Me.assinaturaDigitalTextBox = New System.Windows.Forms.TextBox()
        Me.valorPagoLabel = New System.Windows.Forms.Label()
        Me.employeeFiadoOKButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.employeeFiadoComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'assinaturaDigitalTextBox
        '
        Me.assinaturaDigitalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assinaturaDigitalTextBox.Location = New System.Drawing.Point(30, 126)
        Me.assinaturaDigitalTextBox.Name = "assinaturaDigitalTextBox"
        Me.assinaturaDigitalTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.assinaturaDigitalTextBox.Size = New System.Drawing.Size(224, 30)
        Me.assinaturaDigitalTextBox.TabIndex = 0
        '
        'valorPagoLabel
        '
        Me.valorPagoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valorPagoLabel.AutoSize = True
        Me.valorPagoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorPagoLabel.Location = New System.Drawing.Point(25, 98)
        Me.valorPagoLabel.Name = "valorPagoLabel"
        Me.valorPagoLabel.Size = New System.Drawing.Size(188, 25)
        Me.valorPagoLabel.TabIndex = 1000016
        Me.valorPagoLabel.Text = "Assinatura Digital:"
        '
        'employeeFiadoOKButton
        '
        Me.employeeFiadoOKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeFiadoOKButton.Location = New System.Drawing.Point(30, 191)
        Me.employeeFiadoOKButton.Name = "employeeFiadoOKButton"
        Me.employeeFiadoOKButton.Size = New System.Drawing.Size(224, 27)
        Me.employeeFiadoOKButton.TabIndex = 1
        Me.employeeFiadoOKButton.Text = "OK"
        Me.employeeFiadoOKButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 1000014
        Me.Label1.Text = "Funcionário:"
        '
        'employeeFiadoComboBox
        '
        Me.employeeFiadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.employeeFiadoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeFiadoComboBox.FormattingEnabled = True
        Me.employeeFiadoComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.employeeFiadoComboBox.Location = New System.Drawing.Point(30, 47)
        Me.employeeFiadoComboBox.Name = "employeeFiadoComboBox"
        Me.employeeFiadoComboBox.Size = New System.Drawing.Size(224, 28)
        Me.employeeFiadoComboBox.TabIndex = 1000013
        '
        'Fiado_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 241)
        Me.Controls.Add(Me.assinaturaDigitalTextBox)
        Me.Controls.Add(Me.valorPagoLabel)
        Me.Controls.Add(Me.employeeFiadoOKButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.employeeFiadoComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Fiado_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiado_Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents assinaturaDigitalTextBox As TextBox
    Friend WithEvents valorPagoLabel As Label
    Friend WithEvents employeeFiadoOKButton As Button
    Friend WithEvents Label1 As Label
    Private WithEvents employeeFiadoComboBox As ComboBox
End Class
