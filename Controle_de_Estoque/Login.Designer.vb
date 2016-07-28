<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.userLabel = New System.Windows.Forms.Label()
        Me.userTextBox = New System.Windows.Forms.TextBox()
        Me.passwordUser = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.rememberCheckBox = New System.Windows.Forms.CheckBox()
        Me.passwordTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.BackColor = System.Drawing.Color.Transparent
        Me.userLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.Location = New System.Drawing.Point(9, 13)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(61, 17)
        Me.userLabel.TabIndex = 0
        Me.userLabel.Text = "Usuário:"
        '
        'userTextBox
        '
        Me.userTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTextBox.Location = New System.Drawing.Point(12, 33)
        Me.userTextBox.Name = "userTextBox"
        Me.userTextBox.Size = New System.Drawing.Size(256, 23)
        Me.userTextBox.TabIndex = 1
        '
        'passwordUser
        '
        Me.passwordUser.AutoSize = True
        Me.passwordUser.BackColor = System.Drawing.Color.Transparent
        Me.passwordUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordUser.Location = New System.Drawing.Point(9, 69)
        Me.passwordUser.Name = "passwordUser"
        Me.passwordUser.Size = New System.Drawing.Size(53, 17)
        Me.passwordUser.TabIndex = 2
        Me.passwordUser.Text = "Senha:"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(12, 138)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(94, 23)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'rememberCheckBox
        '
        Me.rememberCheckBox.AutoSize = True
        Me.rememberCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.rememberCheckBox.Location = New System.Drawing.Point(175, 142)
        Me.rememberCheckBox.Name = "rememberCheckBox"
        Me.rememberCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.rememberCheckBox.TabIndex = 4
        Me.rememberCheckBox.TabStop = False
        Me.rememberCheckBox.Text = "Lembrar Login"
        Me.rememberCheckBox.UseVisualStyleBackColor = False
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.Location = New System.Drawing.Point(12, 89)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(256, 23)
        Me.passwordTextBox.TabIndex = 2
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Controle_de_Estoque.My.Resources.Resources.login_background
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.userTextBox)
        Me.Controls.Add(Me.rememberCheckBox)
        Me.Controls.Add(Me.passwordUser)
        Me.Controls.Add(Me.okButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userLabel As Label
    Friend WithEvents userTextBox As TextBox
    Friend WithEvents passwordUser As Label
    Friend WithEvents okButton As Button
    Friend WithEvents rememberCheckBox As CheckBox
    Friend WithEvents passwordTextBox As MaskedTextBox
End Class
