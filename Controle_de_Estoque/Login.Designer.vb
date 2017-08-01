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
        Me.userLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userLabel.AutoSize = True
        Me.userLabel.BackColor = System.Drawing.Color.Transparent
        Me.userLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.Location = New System.Drawing.Point(12, 16)
        Me.userLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(72, 20)
        Me.userLabel.TabIndex = 0
        Me.userLabel.Text = "Usuário:"
        '
        'userTextBox
        '
        Me.userTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTextBox.Location = New System.Drawing.Point(16, 41)
        Me.userTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.userTextBox.Name = "userTextBox"
        Me.userTextBox.Size = New System.Drawing.Size(340, 26)
        Me.userTextBox.TabIndex = 1
        '
        'passwordUser
        '
        Me.passwordUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordUser.AutoSize = True
        Me.passwordUser.BackColor = System.Drawing.Color.Transparent
        Me.passwordUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordUser.Location = New System.Drawing.Point(12, 85)
        Me.passwordUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passwordUser.Name = "passwordUser"
        Me.passwordUser.Size = New System.Drawing.Size(61, 20)
        Me.passwordUser.TabIndex = 2
        Me.passwordUser.Text = "Senha:"
        '
        'okButton
        '
        Me.okButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.Location = New System.Drawing.Point(16, 170)
        Me.okButton.Margin = New System.Windows.Forms.Padding(4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(125, 28)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'rememberCheckBox
        '
        Me.rememberCheckBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rememberCheckBox.AutoSize = True
        Me.rememberCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.rememberCheckBox.Location = New System.Drawing.Point(233, 175)
        Me.rememberCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.rememberCheckBox.Name = "rememberCheckBox"
        Me.rememberCheckBox.Size = New System.Drawing.Size(122, 21)
        Me.rememberCheckBox.TabIndex = 4
        Me.rememberCheckBox.TabStop = False
        Me.rememberCheckBox.Text = "Lembrar Login"
        Me.rememberCheckBox.UseVisualStyleBackColor = False
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.Location = New System.Drawing.Point(16, 110)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(340, 26)
        Me.passwordTextBox.TabIndex = 2
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Controle_de_Estoque.My.Resources.Resources.login_background
        Me.ClientSize = New System.Drawing.Size(379, 223)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.userTextBox)
        Me.Controls.Add(Me.rememberCheckBox)
        Me.Controls.Add(Me.passwordUser)
        Me.Controls.Add(Me.okButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
