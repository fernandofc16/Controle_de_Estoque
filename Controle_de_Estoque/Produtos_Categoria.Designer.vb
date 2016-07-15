<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos_Categoria
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
        Me.produtosCategoriaFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'produtosCategoriaFlowLayoutPanel
        '
        Me.produtosCategoriaFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.produtosCategoriaFlowLayoutPanel.AutoScroll = True
        Me.produtosCategoriaFlowLayoutPanel.Location = New System.Drawing.Point(1, 1)
        Me.produtosCategoriaFlowLayoutPanel.Name = "produtosCategoriaFlowLayoutPanel"
        Me.produtosCategoriaFlowLayoutPanel.Size = New System.Drawing.Size(383, 130)
        Me.produtosCategoriaFlowLayoutPanel.TabIndex = 0
        '
        'Produtos_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 131)
        Me.Controls.Add(Me.produtosCategoriaFlowLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Produtos_Categoria"
        Me.Text = "Produtos_Categoria"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents produtosCategoriaFlowLayoutPanel As FlowLayoutPanel
End Class
