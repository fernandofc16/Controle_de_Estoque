<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            atualizarInfoAdmin()
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonLogOff = New System.Windows.Forms.Button()
        Me.logoEmpresaPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.removerFormaDePagamentoButton = New System.Windows.Forms.Button()
        Me.adicionarFormaDePagamentoButton = New System.Windows.Forms.Button()
        Me.formasDePagamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resumoRelatorioRadioButton = New System.Windows.Forms.RadioButton()
        Me.completoRelatorioRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.nomeAdminTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SMTPHostComboBox = New System.Windows.Forms.ComboBox()
        Me.showPasswordAdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.userAdminTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.senhaAdminTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.emailSystemTextBox = New System.Windows.Forms.TextBox()
        Me.openCaixaButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.adicionarLoteButton = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dataAttProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.validadeProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cleanAllProdButton = New System.Windows.Forms.Button()
        Me.dataCadastroProdRadioButton = New System.Windows.Forms.RadioButton()
        Me.quantidadeProdRadioButton = New System.Windows.Forms.RadioButton()
        Me.codigoBarraProdRadioButton = New System.Windows.Forms.RadioButton()
        Me.estoqueMinProdRadioButton = New System.Windows.Forms.RadioButton()
        Me.preçoProdRadioButton = New System.Windows.Forms.RadioButton()
        Me.nomesProdRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.searchProdTextBox = New System.Windows.Forms.TextBox()
        Me.idProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.updateProdButton = New System.Windows.Forms.Button()
        Me.removeProdButton = New System.Windows.Forms.Button()
        Me.registerProdButton = New System.Windows.Forms.Button()
        Me.quantidadeProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.codigoBarraProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.estoqueMinProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.preçoProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nomeProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.produtosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDProdutos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preços = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estoque_min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo_barra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_validade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Att = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produtoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.idEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cleanEmployeeButton = New System.Windows.Forms.Button()
        Me.telefoneCelularEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.telefoneResidencialEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.endereçoEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cpfEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.rgEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.nomeEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.employeeInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nomes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Endereço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel_Residencial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel_Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoEmployeePictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.datasRadioButton = New System.Windows.Forms.RadioButton()
        Me.nomesRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.searchReportTextBox = New System.Windows.Forms.TextBox()
        Me.removerButton = New System.Windows.Forms.Button()
        Me.reportAccessDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_report = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datas_Fechado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas_Fechado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.imageProdCatPictureBox = New System.Windows.Forms.PictureBox()
        Me.limparCategoriasButton = New System.Windows.Forms.Button()
        Me.atualizarCategoriaButton = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.utilizarNomeCategoriaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.removerCategoriasButton = New System.Windows.Forms.Button()
        Me.removerProdutoCategoriaButton = New System.Windows.Forms.Button()
        Me.categoriaTypeTextBox = New System.Windows.Forms.TextBox()
        Me.adicionarCategoriaButton = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.produtosCategoriasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Produtos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adicionarProdutoCategoriaButton = New System.Windows.Forms.Button()
        Me.produtosButtonsCaixaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.categoriaButtonsCaixaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.categoriaPictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.assinaturaDigitalRemoverButton = New System.Windows.Forms.Button()
        Me.assinaturaDigitalCadastroButton = New System.Windows.Forms.Button()
        Me.userEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.passwordEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.atualizarFuncCadButton = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.removerCompraFiadoButton = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.valorTotalCompraFiadoTextBox = New System.Windows.Forms.TextBox()
        Me.funcionarioFiadoBoolCadastradoLabel = New System.Windows.Forms.Label()
        Me.removerFuncCadButton = New System.Windows.Forms.Button()
        Me.cadastrarFuncCadButton = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.datasComprasFiadoComboBox = New System.Windows.Forms.ComboBox()
        Me.produtosEQuantidadesFiadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProdutosFiadoFunc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadesFiadoFunc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.assinaturaDigitalEmployeeTextBox = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.funcionariosCadComboBox = New System.Windows.Forms.ComboBox()
        Me.imageFuncCadPictureBox = New System.Windows.Forms.PictureBox()
        Me.selecionarImagemOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.logoEmpresaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.produtosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produtoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.employeeInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoEmployeePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.reportAccessDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.imageProdCatPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produtosCategoriasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categoriaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.produtosEQuantidadesFiadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageFuncCadPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 735)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonLogOff)
        Me.TabPage1.Controls.Add(Me.logoEmpresaPictureBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.removerFormaDePagamentoButton)
        Me.TabPage1.Controls.Add(Me.adicionarFormaDePagamentoButton)
        Me.TabPage1.Controls.Add(Me.formasDePagamentoComboBox)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.resumoRelatorioRadioButton)
        Me.TabPage1.Controls.Add(Me.completoRelatorioRadioButton)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label44)
        Me.TabPage1.Controls.Add(Me.nomeAdminTextBox)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.SMTPHostComboBox)
        Me.TabPage1.Controls.Add(Me.showPasswordAdminCheckBox)
        Me.TabPage1.Controls.Add(Me.userAdminTextBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.senhaAdminTextBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.emailSystemTextBox)
        Me.TabPage1.Controls.Add(Me.openCaixaButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1004, 709)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonLogOff
        '
        Me.ButtonLogOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogOff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonLogOff.Image = Global.Controle_de_Estoque.My.Resources.Resources.Icone_logoff
        Me.ButtonLogOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonLogOff.Location = New System.Drawing.Point(793, 414)
        Me.ButtonLogOff.Name = "ButtonLogOff"
        Me.ButtonLogOff.Size = New System.Drawing.Size(200, 281)
        Me.ButtonLogOff.TabIndex = 1000023
        Me.ButtonLogOff.Text = "Sair"
        Me.ButtonLogOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonLogOff.UseVisualStyleBackColor = True
        '
        'logoEmpresaPictureBox
        '
        Me.logoEmpresaPictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_produto_photo
        Me.logoEmpresaPictureBox.Location = New System.Drawing.Point(35, 395)
        Me.logoEmpresaPictureBox.Name = "logoEmpresaPictureBox"
        Me.logoEmpresaPictureBox.Size = New System.Drawing.Size(470, 300)
        Me.logoEmpresaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoEmpresaPictureBox.TabIndex = 1000022
        Me.logoEmpresaPictureBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(511, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 24)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Configuração do Relatório:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(511, 74)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(274, 20)
        Me.Label34.TabIndex = 178
        Me.Label34.Text = "Formas de Pagamentos Adicionados:"
        '
        'removerFormaDePagamentoButton
        '
        Me.removerFormaDePagamentoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerFormaDePagamentoButton.Location = New System.Drawing.Point(691, 147)
        Me.removerFormaDePagamentoButton.Name = "removerFormaDePagamentoButton"
        Me.removerFormaDePagamentoButton.Size = New System.Drawing.Size(100, 30)
        Me.removerFormaDePagamentoButton.TabIndex = 176
        Me.removerFormaDePagamentoButton.Text = "Remover"
        Me.removerFormaDePagamentoButton.UseVisualStyleBackColor = True
        '
        'adicionarFormaDePagamentoButton
        '
        Me.adicionarFormaDePagamentoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adicionarFormaDePagamentoButton.Location = New System.Drawing.Point(515, 147)
        Me.adicionarFormaDePagamentoButton.Name = "adicionarFormaDePagamentoButton"
        Me.adicionarFormaDePagamentoButton.Size = New System.Drawing.Size(100, 30)
        Me.adicionarFormaDePagamentoButton.TabIndex = 175
        Me.adicionarFormaDePagamentoButton.Text = "Adicionar"
        Me.adicionarFormaDePagamentoButton.UseVisualStyleBackColor = True
        '
        'formasDePagamentoComboBox
        '
        Me.formasDePagamentoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formasDePagamentoComboBox.FormattingEnabled = True
        Me.formasDePagamentoComboBox.Items.AddRange(New Object() {"Dinheiro", "NULL"})
        Me.formasDePagamentoComboBox.Location = New System.Drawing.Point(515, 97)
        Me.formasDePagamentoComboBox.Name = "formasDePagamentoComboBox"
        Me.formasDePagamentoComboBox.Size = New System.Drawing.Size(276, 28)
        Me.formasDePagamentoComboBox.TabIndex = 174
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(511, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(260, 24)
        Me.Label33.TabIndex = 173
        Me.Label33.Text = "Configurações de Pagamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(513, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Opções de Relatório:"
        '
        'resumoRelatorioRadioButton
        '
        Me.resumoRelatorioRadioButton.AutoSize = True
        Me.resumoRelatorioRadioButton.Location = New System.Drawing.Point(680, 350)
        Me.resumoRelatorioRadioButton.Name = "resumoRelatorioRadioButton"
        Me.resumoRelatorioRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.resumoRelatorioRadioButton.TabIndex = 171
        Me.resumoRelatorioRadioButton.Text = "Resumido"
        Me.resumoRelatorioRadioButton.UseVisualStyleBackColor = True
        '
        'completoRelatorioRadioButton
        '
        Me.completoRelatorioRadioButton.AutoSize = True
        Me.completoRelatorioRadioButton.Checked = True
        Me.completoRelatorioRadioButton.Location = New System.Drawing.Point(680, 327)
        Me.completoRelatorioRadioButton.Name = "completoRelatorioRadioButton"
        Me.completoRelatorioRadioButton.Size = New System.Drawing.Size(74, 17)
        Me.completoRelatorioRadioButton.TabIndex = 170
        Me.completoRelatorioRadioButton.TabStop = True
        Me.completoRelatorioRadioButton.Text = "Detalhado"
        Me.completoRelatorioRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 24)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Logo do Estabelecimento:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(511, 258)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(52, 20)
        Me.Label44.TabIndex = 136
        Me.Label44.Text = "Email:"
        '
        'nomeAdminTextBox
        '
        Me.nomeAdminTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeAdminTextBox.Location = New System.Drawing.Point(33, 99)
        Me.nomeAdminTextBox.Name = "nomeAdminTextBox"
        Me.nomeAdminTextBox.Size = New System.Drawing.Size(276, 26)
        Me.nomeAdminTextBox.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 20)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Nome do Administrador:"
        '
        'SMTPHostComboBox
        '
        Me.SMTPHostComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SMTPHostComboBox.FormattingEnabled = True
        Me.SMTPHostComboBox.Items.AddRange(New Object() {"@globomail.com", "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com.br", "@bol.com.br"})
        Me.SMTPHostComboBox.Location = New System.Drawing.Point(796, 281)
        Me.SMTPHostComboBox.Name = "SMTPHostComboBox"
        Me.SMTPHostComboBox.Size = New System.Drawing.Size(166, 28)
        Me.SMTPHostComboBox.TabIndex = 5
        Me.SMTPHostComboBox.Text = "@outlook.com"
        '
        'showPasswordAdminCheckBox
        '
        Me.showPasswordAdminCheckBox.AutoSize = True
        Me.showPasswordAdminCheckBox.Location = New System.Drawing.Point(216, 262)
        Me.showPasswordAdminCheckBox.Name = "showPasswordAdminCheckBox"
        Me.showPasswordAdminCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.showPasswordAdminCheckBox.TabIndex = 131
        Me.showPasswordAdminCheckBox.TabStop = False
        Me.showPasswordAdminCheckBox.Text = "Mostrar senha"
        Me.showPasswordAdminCheckBox.UseVisualStyleBackColor = True
        '
        'userAdminTextBox
        '
        Me.userAdminTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userAdminTextBox.Location = New System.Drawing.Point(33, 163)
        Me.userAdminTextBox.Name = "userAdminTextBox"
        Me.userAdminTextBox.Size = New System.Drawing.Size(276, 26)
        Me.userAdminTextBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 20)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Usuário do Administrador:"
        '
        'senhaAdminTextBox
        '
        Me.senhaAdminTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.senhaAdminTextBox.Location = New System.Drawing.Point(33, 231)
        Me.senhaAdminTextBox.Name = "senhaAdminTextBox"
        Me.senhaAdminTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.senhaAdminTextBox.Size = New System.Drawing.Size(276, 26)
        Me.senhaAdminTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Senha do Administrador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 24)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Informações do Administrador"
        '
        'emailSystemTextBox
        '
        Me.emailSystemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailSystemTextBox.Location = New System.Drawing.Point(515, 281)
        Me.emailSystemTextBox.Name = "emailSystemTextBox"
        Me.emailSystemTextBox.Size = New System.Drawing.Size(276, 26)
        Me.emailSystemTextBox.TabIndex = 4
        '
        'openCaixaButton
        '
        Me.openCaixaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openCaixaButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.openCaixaButton.Image = Global.Controle_de_Estoque.My.Resources.Resources.caixa_abrir2
        Me.openCaixaButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.openCaixaButton.Location = New System.Drawing.Point(571, 414)
        Me.openCaixaButton.Name = "openCaixaButton"
        Me.openCaixaButton.Size = New System.Drawing.Size(200, 281)
        Me.openCaixaButton.TabIndex = 9
        Me.openCaixaButton.Text = "Abrir Caixa"
        Me.openCaixaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.openCaixaButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.adicionarLoteButton)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.dataAttProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.validadeProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cleanAllProdButton)
        Me.TabPage2.Controls.Add(Me.dataCadastroProdRadioButton)
        Me.TabPage2.Controls.Add(Me.quantidadeProdRadioButton)
        Me.TabPage2.Controls.Add(Me.codigoBarraProdRadioButton)
        Me.TabPage2.Controls.Add(Me.estoqueMinProdRadioButton)
        Me.TabPage2.Controls.Add(Me.preçoProdRadioButton)
        Me.TabPage2.Controls.Add(Me.nomesProdRadioButton)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.searchProdTextBox)
        Me.TabPage2.Controls.Add(Me.idProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.updateProdButton)
        Me.TabPage2.Controls.Add(Me.removeProdButton)
        Me.TabPage2.Controls.Add(Me.registerProdButton)
        Me.TabPage2.Controls.Add(Me.quantidadeProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.codigoBarraProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.estoqueMinProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.preçoProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.nomeProdTextBox)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.produtosDataGridView)
        Me.TabPage2.Controls.Add(Me.produtoPictureBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1004, 709)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Controle de Estoque"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'adicionarLoteButton
        '
        Me.adicionarLoteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adicionarLoteButton.Location = New System.Drawing.Point(572, 68)
        Me.adicionarLoteButton.Name = "adicionarLoteButton"
        Me.adicionarLoteButton.Size = New System.Drawing.Size(115, 30)
        Me.adicionarLoteButton.TabIndex = 52
        Me.adicionarLoteButton.TabStop = False
        Me.adicionarLoteButton.Text = "Gerenciar Lote"
        Me.adicionarLoteButton.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 3)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 20)
        Me.Label32.TabIndex = 51
        Me.Label32.Text = "Imagem:"
        '
        'dataAttProdTextBox
        '
        Me.dataAttProdTextBox.Enabled = False
        Me.dataAttProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataAttProdTextBox.Location = New System.Drawing.Point(354, 25)
        Me.dataAttProdTextBox.Name = "dataAttProdTextBox"
        Me.dataAttProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.dataAttProdTextBox.TabIndex = 49
        Me.dataAttProdTextBox.TabStop = False
        Me.dataAttProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(350, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(157, 20)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Data de Atualização:"
        '
        'validadeProdTextBox
        '
        Me.validadeProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validadeProdTextBox.Location = New System.Drawing.Point(354, 186)
        Me.validadeProdTextBox.Name = "validadeProdTextBox"
        Me.validadeProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.validadeProdTextBox.TabIndex = 6
        Me.validadeProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(350, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 20)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Data de Validade:"
        '
        'cleanAllProdButton
        '
        Me.cleanAllProdButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cleanAllProdButton.Location = New System.Drawing.Point(572, 176)
        Me.cleanAllProdButton.Name = "cleanAllProdButton"
        Me.cleanAllProdButton.Size = New System.Drawing.Size(115, 30)
        Me.cleanAllProdButton.TabIndex = 45
        Me.cleanAllProdButton.TabStop = False
        Me.cleanAllProdButton.Text = "Limpar"
        Me.cleanAllProdButton.UseVisualStyleBackColor = True
        '
        'dataCadastroProdRadioButton
        '
        Me.dataCadastroProdRadioButton.AutoSize = True
        Me.dataCadastroProdRadioButton.Location = New System.Drawing.Point(892, 163)
        Me.dataCadastroProdRadioButton.Name = "dataCadastroProdRadioButton"
        Me.dataCadastroProdRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.dataCadastroProdRadioButton.TabIndex = 44
        Me.dataCadastroProdRadioButton.Text = "Data Validade"
        Me.dataCadastroProdRadioButton.UseVisualStyleBackColor = True
        '
        'quantidadeProdRadioButton
        '
        Me.quantidadeProdRadioButton.AutoSize = True
        Me.quantidadeProdRadioButton.Location = New System.Drawing.Point(712, 163)
        Me.quantidadeProdRadioButton.Name = "quantidadeProdRadioButton"
        Me.quantidadeProdRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.quantidadeProdRadioButton.TabIndex = 43
        Me.quantidadeProdRadioButton.Text = "Quantidade"
        Me.quantidadeProdRadioButton.UseVisualStyleBackColor = True
        '
        'codigoBarraProdRadioButton
        '
        Me.codigoBarraProdRadioButton.AutoSize = True
        Me.codigoBarraProdRadioButton.Location = New System.Drawing.Point(803, 163)
        Me.codigoBarraProdRadioButton.Name = "codigoBarraProdRadioButton"
        Me.codigoBarraProdRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.codigoBarraProdRadioButton.TabIndex = 42
        Me.codigoBarraProdRadioButton.Text = "Cód Barra"
        Me.codigoBarraProdRadioButton.UseVisualStyleBackColor = True
        '
        'estoqueMinProdRadioButton
        '
        Me.estoqueMinProdRadioButton.AutoSize = True
        Me.estoqueMinProdRadioButton.Location = New System.Drawing.Point(892, 140)
        Me.estoqueMinProdRadioButton.Name = "estoqueMinProdRadioButton"
        Me.estoqueMinProdRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.estoqueMinProdRadioButton.TabIndex = 41
        Me.estoqueMinProdRadioButton.Text = "Estoque Min"
        Me.estoqueMinProdRadioButton.UseVisualStyleBackColor = True
        '
        'preçoProdRadioButton
        '
        Me.preçoProdRadioButton.AutoSize = True
        Me.preçoProdRadioButton.Location = New System.Drawing.Point(803, 140)
        Me.preçoProdRadioButton.Name = "preçoProdRadioButton"
        Me.preçoProdRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.preçoProdRadioButton.TabIndex = 40
        Me.preçoProdRadioButton.Text = "Preços"
        Me.preçoProdRadioButton.UseVisualStyleBackColor = True
        '
        'nomesProdRadioButton
        '
        Me.nomesProdRadioButton.AutoSize = True
        Me.nomesProdRadioButton.Checked = True
        Me.nomesProdRadioButton.Location = New System.Drawing.Point(712, 140)
        Me.nomesProdRadioButton.Name = "nomesProdRadioButton"
        Me.nomesProdRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.nomesProdRadioButton.TabIndex = 39
        Me.nomesProdRadioButton.TabStop = True
        Me.nomesProdRadioButton.Text = "Nomes"
        Me.nomesProdRadioButton.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(708, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 20)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Pesquisar:"
        '
        'searchProdTextBox
        '
        Me.searchProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchProdTextBox.Location = New System.Drawing.Point(712, 105)
        Me.searchProdTextBox.Name = "searchProdTextBox"
        Me.searchProdTextBox.Size = New System.Drawing.Size(264, 26)
        Me.searchProdTextBox.TabIndex = 37
        Me.searchProdTextBox.TabStop = False
        '
        'idProdTextBox
        '
        Me.idProdTextBox.Enabled = False
        Me.idProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idProdTextBox.Location = New System.Drawing.Point(147, 25)
        Me.idProdTextBox.Name = "idProdTextBox"
        Me.idProdTextBox.Size = New System.Drawing.Size(105, 26)
        Me.idProdTextBox.TabIndex = 36
        Me.idProdTextBox.TabStop = False
        Me.idProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(143, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 20)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "ID:"
        '
        'updateProdButton
        '
        Me.updateProdButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateProdButton.Location = New System.Drawing.Point(572, 104)
        Me.updateProdButton.Name = "updateProdButton"
        Me.updateProdButton.Size = New System.Drawing.Size(115, 30)
        Me.updateProdButton.TabIndex = 34
        Me.updateProdButton.TabStop = False
        Me.updateProdButton.Text = "Atualizar"
        Me.updateProdButton.UseVisualStyleBackColor = True
        '
        'removeProdButton
        '
        Me.removeProdButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeProdButton.Location = New System.Drawing.Point(572, 140)
        Me.removeProdButton.Name = "removeProdButton"
        Me.removeProdButton.Size = New System.Drawing.Size(115, 30)
        Me.removeProdButton.TabIndex = 33
        Me.removeProdButton.TabStop = False
        Me.removeProdButton.Text = "Remover"
        Me.removeProdButton.UseVisualStyleBackColor = True
        '
        'registerProdButton
        '
        Me.registerProdButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerProdButton.Location = New System.Drawing.Point(572, 32)
        Me.registerProdButton.Name = "registerProdButton"
        Me.registerProdButton.Size = New System.Drawing.Size(115, 30)
        Me.registerProdButton.TabIndex = 32
        Me.registerProdButton.TabStop = False
        Me.registerProdButton.Text = "Registrar"
        Me.registerProdButton.UseVisualStyleBackColor = True
        '
        'quantidadeProdTextBox
        '
        Me.quantidadeProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantidadeProdTextBox.Location = New System.Drawing.Point(354, 132)
        Me.quantidadeProdTextBox.Name = "quantidadeProdTextBox"
        Me.quantidadeProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.quantidadeProdTextBox.TabIndex = 5
        Me.quantidadeProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(350, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 20)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Quantidade:"
        '
        'codigoBarraProdTextBox
        '
        Me.codigoBarraProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoBarraProdTextBox.Location = New System.Drawing.Point(354, 80)
        Me.codigoBarraProdTextBox.Name = "codigoBarraProdTextBox"
        Me.codigoBarraProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.codigoBarraProdTextBox.TabIndex = 4
        Me.codigoBarraProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(350, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 20)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Código de Barra:"
        '
        'estoqueMinProdTextBox
        '
        Me.estoqueMinProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estoqueMinProdTextBox.Location = New System.Drawing.Point(147, 132)
        Me.estoqueMinProdTextBox.Name = "estoqueMinProdTextBox"
        Me.estoqueMinProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.estoqueMinProdTextBox.TabIndex = 3
        Me.estoqueMinProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(143, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Estoque Mínimo"
        '
        'preçoProdTextBox
        '
        Me.preçoProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preçoProdTextBox.Location = New System.Drawing.Point(147, 186)
        Me.preçoProdTextBox.Name = "preçoProdTextBox"
        Me.preçoProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.preçoProdTextBox.TabIndex = 2
        Me.preçoProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(143, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Preço:"
        '
        'nomeProdTextBox
        '
        Me.nomeProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeProdTextBox.Location = New System.Drawing.Point(147, 80)
        Me.nomeProdTextBox.Name = "nomeProdTextBox"
        Me.nomeProdTextBox.Size = New System.Drawing.Size(200, 26)
        Me.nomeProdTextBox.TabIndex = 1
        Me.nomeProdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(143, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Nome:"
        '
        'produtosDataGridView
        '
        Me.produtosDataGridView.AllowUserToAddRows = False
        Me.produtosDataGridView.AllowUserToDeleteRows = False
        Me.produtosDataGridView.AllowUserToResizeColumns = False
        Me.produtosDataGridView.AllowUserToResizeRows = False
        Me.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.produtosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProdutos, Me.DataGridViewTextBoxColumn3, Me.Preços, Me.Estoque_min, Me.Codigo_barra, Me.Quantidade, Me.Data_validade, Me.Data_Att})
        Me.produtosDataGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtosDataGridView.Location = New System.Drawing.Point(-4, 222)
        Me.produtosDataGridView.Name = "produtosDataGridView"
        Me.produtosDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.produtosDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.produtosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.produtosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.produtosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.produtosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.produtosDataGridView.Size = New System.Drawing.Size(1006, 486)
        Me.produtosDataGridView.TabIndex = 13
        Me.produtosDataGridView.TabStop = False
        '
        'IDProdutos
        '
        Me.IDProdutos.HeaderText = "ID"
        Me.IDProdutos.Name = "IDProdutos"
        Me.IDProdutos.ReadOnly = True
        Me.IDProdutos.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 260
        '
        'Preços
        '
        Me.Preços.HeaderText = "Preço"
        Me.Preços.Name = "Preços"
        Me.Preços.ReadOnly = True
        Me.Preços.Width = 90
        '
        'Estoque_min
        '
        Me.Estoque_min.HeaderText = "Estoque Mínimo"
        Me.Estoque_min.Name = "Estoque_min"
        Me.Estoque_min.ReadOnly = True
        Me.Estoque_min.Width = 65
        '
        'Codigo_barra
        '
        Me.Codigo_barra.HeaderText = "Código de Barra"
        Me.Codigo_barra.Name = "Codigo_barra"
        Me.Codigo_barra.ReadOnly = True
        Me.Codigo_barra.Width = 210
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        Me.Quantidade.Width = 85
        '
        'Data_validade
        '
        Me.Data_validade.HeaderText = "Data Validade"
        Me.Data_validade.Name = "Data_validade"
        Me.Data_validade.ReadOnly = True
        Me.Data_validade.Width = 95
        '
        'Data_Att
        '
        Me.Data_Att.HeaderText = "Data Atualização"
        Me.Data_Att.Name = "Data_Att"
        Me.Data_Att.ReadOnly = True
        Me.Data_Att.Width = 95
        '
        'produtoPictureBox
        '
        Me.produtoPictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_produto_photo
        Me.produtoPictureBox.Location = New System.Drawing.Point(6, 45)
        Me.produtoPictureBox.Name = "produtoPictureBox"
        Me.produtoPictureBox.Size = New System.Drawing.Size(130, 135)
        Me.produtoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.produtoPictureBox.TabIndex = 50
        Me.produtoPictureBox.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.idEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.cleanEmployeeButton)
        Me.TabPage3.Controls.Add(Me.telefoneCelularEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.telefoneResidencialEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.endereçoEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.cpfEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.rgEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.nomeEmployeeTextBox)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.updateButton)
        Me.TabPage3.Controls.Add(Me.deleteButton)
        Me.TabPage3.Controls.Add(Me.registerButton)
        Me.TabPage3.Controls.Add(Me.employeeInfoDataGridView)
        Me.TabPage3.Controls.Add(Me.fotoEmployeePictureBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1004, 709)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gerenciar Funcionários"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'idEmployeeTextBox
        '
        Me.idEmployeeTextBox.Enabled = False
        Me.idEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idEmployeeTextBox.Location = New System.Drawing.Point(339, 37)
        Me.idEmployeeTextBox.Name = "idEmployeeTextBox"
        Me.idEmployeeTextBox.Size = New System.Drawing.Size(125, 26)
        Me.idEmployeeTextBox.TabIndex = 38
        Me.idEmployeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(335, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "ID:"
        '
        'cleanEmployeeButton
        '
        Me.cleanEmployeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cleanEmployeeButton.Location = New System.Drawing.Point(170, 240)
        Me.cleanEmployeeButton.Name = "cleanEmployeeButton"
        Me.cleanEmployeeButton.Size = New System.Drawing.Size(140, 30)
        Me.cleanEmployeeButton.TabIndex = 36
        Me.cleanEmployeeButton.TabStop = False
        Me.cleanEmployeeButton.Text = "Limpar"
        Me.cleanEmployeeButton.UseVisualStyleBackColor = True
        '
        'telefoneCelularEmployeeTextBox
        '
        Me.telefoneCelularEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefoneCelularEmployeeTextBox.Location = New System.Drawing.Point(340, 234)
        Me.telefoneCelularEmployeeTextBox.Name = "telefoneCelularEmployeeTextBox"
        Me.telefoneCelularEmployeeTextBox.Size = New System.Drawing.Size(292, 26)
        Me.telefoneCelularEmployeeTextBox.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(336, 211)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 20)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Telefone Celular:"
        '
        'telefoneResidencialEmployeeTextBox
        '
        Me.telefoneResidencialEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefoneResidencialEmployeeTextBox.Location = New System.Drawing.Point(339, 169)
        Me.telefoneResidencialEmployeeTextBox.Name = "telefoneResidencialEmployeeTextBox"
        Me.telefoneResidencialEmployeeTextBox.Size = New System.Drawing.Size(292, 26)
        Me.telefoneResidencialEmployeeTextBox.TabIndex = 5
        '
        'endereçoEmployeeTextBox
        '
        Me.endereçoEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endereçoEmployeeTextBox.Location = New System.Drawing.Point(18, 169)
        Me.endereçoEmployeeTextBox.Name = "endereçoEmployeeTextBox"
        Me.endereçoEmployeeTextBox.Size = New System.Drawing.Size(292, 26)
        Me.endereçoEmployeeTextBox.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(335, 146)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(161, 20)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Telefone Residencial:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(14, 146)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 20)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Endereço:"
        '
        'cpfEmployeeTextBox
        '
        Me.cpfEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpfEmployeeTextBox.Location = New System.Drawing.Point(339, 104)
        Me.cpfEmployeeTextBox.Name = "cpfEmployeeTextBox"
        Me.cpfEmployeeTextBox.Size = New System.Drawing.Size(292, 26)
        Me.cpfEmployeeTextBox.TabIndex = 3
        '
        'rgEmployeeTextBox
        '
        Me.rgEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgEmployeeTextBox.Location = New System.Drawing.Point(18, 104)
        Me.rgEmployeeTextBox.Name = "rgEmployeeTextBox"
        Me.rgEmployeeTextBox.Size = New System.Drawing.Size(292, 26)
        Me.rgEmployeeTextBox.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(335, 81)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 20)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "CPF:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 20)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "RG:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(715, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 20)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Foto:"
        '
        'nomeEmployeeTextBox
        '
        Me.nomeEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeEmployeeTextBox.Location = New System.Drawing.Point(18, 37)
        Me.nomeEmployeeTextBox.Name = "nomeEmployeeTextBox"
        Me.nomeEmployeeTextBox.Size = New System.Drawing.Size(292, 26)
        Me.nomeEmployeeTextBox.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Nome:"
        '
        'updateButton
        '
        Me.updateButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.updateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.Location = New System.Drawing.Point(170, 207)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(140, 30)
        Me.updateButton.TabIndex = 19
        Me.updateButton.TabStop = False
        Me.updateButton.Text = "Atualizar"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(18, 240)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(140, 30)
        Me.deleteButton.TabIndex = 18
        Me.deleteButton.TabStop = False
        Me.deleteButton.Text = "Deletar"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'registerButton
        '
        Me.registerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerButton.Location = New System.Drawing.Point(18, 207)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(140, 30)
        Me.registerButton.TabIndex = 17
        Me.registerButton.TabStop = False
        Me.registerButton.Text = "Registrar"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'employeeInfoDataGridView
        '
        Me.employeeInfoDataGridView.AllowUserToAddRows = False
        Me.employeeInfoDataGridView.AllowUserToDeleteRows = False
        Me.employeeInfoDataGridView.AllowUserToResizeColumns = False
        Me.employeeInfoDataGridView.AllowUserToResizeRows = False
        Me.employeeInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_employee, Me.Nomes, Me.RG, Me.CPF, Me.Endereço, Me.Tel_Residencial, Me.Tel_Celular})
        Me.employeeInfoDataGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeInfoDataGridView.Location = New System.Drawing.Point(-4, 281)
        Me.employeeInfoDataGridView.MultiSelect = False
        Me.employeeInfoDataGridView.Name = "employeeInfoDataGridView"
        Me.employeeInfoDataGridView.ReadOnly = True
        Me.employeeInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.employeeInfoDataGridView.Size = New System.Drawing.Size(1006, 423)
        Me.employeeInfoDataGridView.TabIndex = 12
        Me.employeeInfoDataGridView.TabStop = False
        '
        'ID_employee
        '
        Me.ID_employee.HeaderText = "ID"
        Me.ID_employee.Name = "ID_employee"
        Me.ID_employee.ReadOnly = True
        Me.ID_employee.Width = 50
        '
        'Nomes
        '
        Me.Nomes.HeaderText = "Nome"
        Me.Nomes.Name = "Nomes"
        Me.Nomes.ReadOnly = True
        Me.Nomes.Width = 250
        '
        'RG
        '
        Me.RG.HeaderText = "RG"
        Me.RG.Name = "RG"
        Me.RG.ReadOnly = True
        Me.RG.Width = 90
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Endereço
        '
        Me.Endereço.HeaderText = "Endereço"
        Me.Endereço.Name = "Endereço"
        Me.Endereço.ReadOnly = True
        Me.Endereço.Width = 250
        '
        'Tel_Residencial
        '
        Me.Tel_Residencial.HeaderText = "Tel. Residencial"
        Me.Tel_Residencial.Name = "Tel_Residencial"
        Me.Tel_Residencial.ReadOnly = True
        Me.Tel_Residencial.Width = 110
        '
        'Tel_Celular
        '
        Me.Tel_Celular.HeaderText = "Tel. Celular"
        Me.Tel_Celular.Name = "Tel_Celular"
        Me.Tel_Celular.ReadOnly = True
        Me.Tel_Celular.Width = 110
        '
        'fotoEmployeePictureBox
        '
        Me.fotoEmployeePictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_profile_photo
        Me.fotoEmployeePictureBox.Location = New System.Drawing.Point(719, 31)
        Me.fotoEmployeePictureBox.Name = "fotoEmployeePictureBox"
        Me.fotoEmployeePictureBox.Size = New System.Drawing.Size(230, 230)
        Me.fotoEmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoEmployeePictureBox.TabIndex = 35
        Me.fotoEmployeePictureBox.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.datasRadioButton)
        Me.TabPage4.Controls.Add(Me.nomesRadioButton)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.searchReportTextBox)
        Me.TabPage4.Controls.Add(Me.removerButton)
        Me.TabPage4.Controls.Add(Me.reportAccessDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1004, 709)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Relatório Login"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'datasRadioButton
        '
        Me.datasRadioButton.AutoSize = True
        Me.datasRadioButton.Location = New System.Drawing.Point(594, 651)
        Me.datasRadioButton.Name = "datasRadioButton"
        Me.datasRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.datasRadioButton.TabIndex = 12
        Me.datasRadioButton.Text = "Datas Aberto"
        Me.datasRadioButton.UseVisualStyleBackColor = True
        '
        'nomesRadioButton
        '
        Me.nomesRadioButton.AutoSize = True
        Me.nomesRadioButton.Checked = True
        Me.nomesRadioButton.Location = New System.Drawing.Point(594, 628)
        Me.nomesRadioButton.Name = "nomesRadioButton"
        Me.nomesRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.nomesRadioButton.TabIndex = 11
        Me.nomesRadioButton.TabStop = True
        Me.nomesRadioButton.Text = "Nomes"
        Me.nomesRadioButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(71, 640)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Pesquisar:"
        '
        'searchReportTextBox
        '
        Me.searchReportTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReportTextBox.Location = New System.Drawing.Point(160, 637)
        Me.searchReportTextBox.Name = "searchReportTextBox"
        Me.searchReportTextBox.Size = New System.Drawing.Size(417, 26)
        Me.searchReportTextBox.TabIndex = 9
        '
        'removerButton
        '
        Me.removerButton.Location = New System.Drawing.Point(763, 638)
        Me.removerButton.Name = "removerButton"
        Me.removerButton.Size = New System.Drawing.Size(113, 26)
        Me.removerButton.TabIndex = 8
        Me.removerButton.Text = "Remover"
        Me.removerButton.UseVisualStyleBackColor = True
        '
        'reportAccessDataGridView
        '
        Me.reportAccessDataGridView.AllowUserToAddRows = False
        Me.reportAccessDataGridView.AllowUserToDeleteRows = False
        Me.reportAccessDataGridView.AllowUserToResizeColumns = False
        Me.reportAccessDataGridView.AllowUserToResizeRows = False
        Me.reportAccessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportAccessDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_report, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Horas, Me.Datas_Fechado, Me.Horas_Fechado})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reportAccessDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.reportAccessDataGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportAccessDataGridView.Location = New System.Drawing.Point(-4, 0)
        Me.reportAccessDataGridView.Name = "reportAccessDataGridView"
        Me.reportAccessDataGridView.ReadOnly = True
        Me.reportAccessDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportAccessDataGridView.Size = New System.Drawing.Size(1006, 602)
        Me.reportAccessDataGridView.TabIndex = 7
        Me.reportAccessDataGridView.TabStop = False
        '
        'ID_report
        '
        Me.ID_report.HeaderText = "ID"
        Me.ID_report.Name = "ID_report"
        Me.ID_report.ReadOnly = True
        Me.ID_report.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nomes"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 255
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Datas Aberto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 165
        '
        'Horas
        '
        Me.Horas.HeaderText = "Horas Aberto"
        Me.Horas.Name = "Horas"
        Me.Horas.ReadOnly = True
        Me.Horas.Width = 155
        '
        'Datas_Fechado
        '
        Me.Datas_Fechado.HeaderText = "Datas Fechado"
        Me.Datas_Fechado.Name = "Datas_Fechado"
        Me.Datas_Fechado.ReadOnly = True
        Me.Datas_Fechado.Width = 165
        '
        'Horas_Fechado
        '
        Me.Horas_Fechado.HeaderText = "Horas Fechado"
        Me.Horas_Fechado.Name = "Horas_Fechado"
        Me.Horas_Fechado.ReadOnly = True
        Me.Horas_Fechado.Width = 155
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.imageProdCatPictureBox)
        Me.TabPage5.Controls.Add(Me.limparCategoriasButton)
        Me.TabPage5.Controls.Add(Me.atualizarCategoriaButton)
        Me.TabPage5.Controls.Add(Me.Label31)
        Me.TabPage5.Controls.Add(Me.Label30)
        Me.TabPage5.Controls.Add(Me.utilizarNomeCategoriaCheckBox)
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.removerCategoriasButton)
        Me.TabPage5.Controls.Add(Me.removerProdutoCategoriaButton)
        Me.TabPage5.Controls.Add(Me.categoriaTypeTextBox)
        Me.TabPage5.Controls.Add(Me.adicionarCategoriaButton)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.produtosCategoriasDataGridView)
        Me.TabPage5.Controls.Add(Me.adicionarProdutoCategoriaButton)
        Me.TabPage5.Controls.Add(Me.produtosButtonsCaixaComboBox)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.categoriaButtonsCaixaComboBox)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.categoriaPictureBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1004, 709)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Caixa Categorias"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'imageProdCatPictureBox
        '
        Me.imageProdCatPictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_produto_photo
        Me.imageProdCatPictureBox.Location = New System.Drawing.Point(822, 526)
        Me.imageProdCatPictureBox.Name = "imageProdCatPictureBox"
        Me.imageProdCatPictureBox.Size = New System.Drawing.Size(130, 130)
        Me.imageProdCatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageProdCatPictureBox.TabIndex = 24
        Me.imageProdCatPictureBox.TabStop = False
        '
        'limparCategoriasButton
        '
        Me.limparCategoriasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limparCategoriasButton.Location = New System.Drawing.Point(654, 325)
        Me.limparCategoriasButton.Name = "limparCategoriasButton"
        Me.limparCategoriasButton.Size = New System.Drawing.Size(135, 28)
        Me.limparCategoriasButton.TabIndex = 23
        Me.limparCategoriasButton.TabStop = False
        Me.limparCategoriasButton.Text = "Limpar"
        Me.limparCategoriasButton.UseVisualStyleBackColor = True
        '
        'atualizarCategoriaButton
        '
        Me.atualizarCategoriaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atualizarCategoriaButton.Location = New System.Drawing.Point(505, 325)
        Me.atualizarCategoriaButton.Name = "atualizarCategoriaButton"
        Me.atualizarCategoriaButton.Size = New System.Drawing.Size(135, 28)
        Me.atualizarCategoriaButton.TabIndex = 22
        Me.atualizarCategoriaButton.TabStop = False
        Me.atualizarCategoriaButton.Text = "Atualizar"
        Me.atualizarCategoriaButton.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(600, 429)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(275, 24)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "Adicionar Produtos à Categoria:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(808, 91)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 24)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "Imagem:"
        '
        'utilizarNomeCategoriaCheckBox
        '
        Me.utilizarNomeCategoriaCheckBox.AutoSize = True
        Me.utilizarNomeCategoriaCheckBox.Location = New System.Drawing.Point(708, 236)
        Me.utilizarNomeCategoriaCheckBox.Name = "utilizarNomeCategoriaCheckBox"
        Me.utilizarNomeCategoriaCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.utilizarNomeCategoriaCheckBox.TabIndex = 16
        Me.utilizarNomeCategoriaCheckBox.TabStop = False
        Me.utilizarNomeCategoriaCheckBox.Text = "Utilizar Nome"
        Me.utilizarNomeCategoriaCheckBox.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(501, 177)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(67, 24)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Nome:"
        '
        'removerCategoriasButton
        '
        Me.removerCategoriasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerCategoriasButton.Location = New System.Drawing.Point(654, 291)
        Me.removerCategoriasButton.Name = "removerCategoriasButton"
        Me.removerCategoriasButton.Size = New System.Drawing.Size(135, 28)
        Me.removerCategoriasButton.TabIndex = 14
        Me.removerCategoriasButton.TabStop = False
        Me.removerCategoriasButton.Text = "Remover"
        Me.removerCategoriasButton.UseVisualStyleBackColor = True
        '
        'removerProdutoCategoriaButton
        '
        Me.removerProdutoCategoriaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerProdutoCategoriaButton.Location = New System.Drawing.Point(696, 586)
        Me.removerProdutoCategoriaButton.Name = "removerProdutoCategoriaButton"
        Me.removerProdutoCategoriaButton.Size = New System.Drawing.Size(100, 70)
        Me.removerProdutoCategoriaButton.TabIndex = 13
        Me.removerProdutoCategoriaButton.TabStop = False
        Me.removerProdutoCategoriaButton.Text = "Remover Produto"
        Me.removerProdutoCategoriaButton.UseVisualStyleBackColor = True
        '
        'categoriaTypeTextBox
        '
        Me.categoriaTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoriaTypeTextBox.Location = New System.Drawing.Point(505, 204)
        Me.categoriaTypeTextBox.Name = "categoriaTypeTextBox"
        Me.categoriaTypeTextBox.Size = New System.Drawing.Size(284, 26)
        Me.categoriaTypeTextBox.TabIndex = 3
        '
        'adicionarCategoriaButton
        '
        Me.adicionarCategoriaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adicionarCategoriaButton.Location = New System.Drawing.Point(505, 291)
        Me.adicionarCategoriaButton.Name = "adicionarCategoriaButton"
        Me.adicionarCategoriaButton.Size = New System.Drawing.Size(135, 28)
        Me.adicionarCategoriaButton.TabIndex = 11
        Me.adicionarCategoriaButton.TabStop = False
        Me.adicionarCategoriaButton.Text = "Adicionar"
        Me.adicionarCategoriaButton.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(657, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(156, 24)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Categorias Caixa:"
        '
        'produtosCategoriasDataGridView
        '
        Me.produtosCategoriasDataGridView.AllowUserToAddRows = False
        Me.produtosCategoriasDataGridView.AllowUserToDeleteRows = False
        Me.produtosCategoriasDataGridView.AllowUserToResizeColumns = False
        Me.produtosCategoriasDataGridView.AllowUserToResizeRows = False
        Me.produtosCategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.produtosCategoriasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Produtos})
        Me.produtosCategoriasDataGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtosCategoriasDataGridView.Location = New System.Drawing.Point(-4, 6)
        Me.produtosCategoriasDataGridView.Name = "produtosCategoriasDataGridView"
        Me.produtosCategoriasDataGridView.ReadOnly = True
        Me.produtosCategoriasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.produtosCategoriasDataGridView.Size = New System.Drawing.Size(485, 698)
        Me.produtosCategoriasDataGridView.TabIndex = 8
        Me.produtosCategoriasDataGridView.TabStop = False
        '
        'Produtos
        '
        Me.Produtos.HeaderText = "Produtos"
        Me.Produtos.Name = "Produtos"
        Me.Produtos.ReadOnly = True
        Me.Produtos.Width = 440
        '
        'adicionarProdutoCategoriaButton
        '
        Me.adicionarProdutoCategoriaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adicionarProdutoCategoriaButton.Location = New System.Drawing.Point(512, 586)
        Me.adicionarProdutoCategoriaButton.Name = "adicionarProdutoCategoriaButton"
        Me.adicionarProdutoCategoriaButton.Size = New System.Drawing.Size(100, 70)
        Me.adicionarProdutoCategoriaButton.TabIndex = 4
        Me.adicionarProdutoCategoriaButton.TabStop = False
        Me.adicionarProdutoCategoriaButton.Text = "Adicionar Produto"
        Me.adicionarProdutoCategoriaButton.UseVisualStyleBackColor = True
        '
        'produtosButtonsCaixaComboBox
        '
        Me.produtosButtonsCaixaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.produtosButtonsCaixaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtosButtonsCaixaComboBox.FormattingEnabled = True
        Me.produtosButtonsCaixaComboBox.Location = New System.Drawing.Point(512, 531)
        Me.produtosButtonsCaixaComboBox.Name = "produtosButtonsCaixaComboBox"
        Me.produtosButtonsCaixaComboBox.Size = New System.Drawing.Size(284, 28)
        Me.produtosButtonsCaixaComboBox.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(508, 504)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Produtos:"
        '
        'categoriaButtonsCaixaComboBox
        '
        Me.categoriaButtonsCaixaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoriaButtonsCaixaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoriaButtonsCaixaComboBox.FormattingEnabled = True
        Me.categoriaButtonsCaixaComboBox.Location = New System.Drawing.Point(503, 117)
        Me.categoriaButtonsCaixaComboBox.Name = "categoriaButtonsCaixaComboBox"
        Me.categoriaButtonsCaixaComboBox.Size = New System.Drawing.Size(284, 28)
        Me.categoriaButtonsCaixaComboBox.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(499, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Selecionar Categoria:"
        '
        'categoriaPictureBox
        '
        Me.categoriaPictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_produto_photo
        Me.categoriaPictureBox.Location = New System.Drawing.Point(812, 132)
        Me.categoriaPictureBox.Name = "categoriaPictureBox"
        Me.categoriaPictureBox.Size = New System.Drawing.Size(170, 170)
        Me.categoriaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.categoriaPictureBox.TabIndex = 20
        Me.categoriaPictureBox.TabStop = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label42)
        Me.TabPage6.Controls.Add(Me.assinaturaDigitalRemoverButton)
        Me.TabPage6.Controls.Add(Me.assinaturaDigitalCadastroButton)
        Me.TabPage6.Controls.Add(Me.userEmployeeTextBox)
        Me.TabPage6.Controls.Add(Me.passwordEmployeeTextBox)
        Me.TabPage6.Controls.Add(Me.atualizarFuncCadButton)
        Me.TabPage6.Controls.Add(Me.Label41)
        Me.TabPage6.Controls.Add(Me.Label38)
        Me.TabPage6.Controls.Add(Me.removerCompraFiadoButton)
        Me.TabPage6.Controls.Add(Me.Label40)
        Me.TabPage6.Controls.Add(Me.valorTotalCompraFiadoTextBox)
        Me.TabPage6.Controls.Add(Me.funcionarioFiadoBoolCadastradoLabel)
        Me.TabPage6.Controls.Add(Me.removerFuncCadButton)
        Me.TabPage6.Controls.Add(Me.cadastrarFuncCadButton)
        Me.TabPage6.Controls.Add(Me.Label39)
        Me.TabPage6.Controls.Add(Me.Label37)
        Me.TabPage6.Controls.Add(Me.datasComprasFiadoComboBox)
        Me.TabPage6.Controls.Add(Me.produtosEQuantidadesFiadoDataGridView)
        Me.TabPage6.Controls.Add(Me.assinaturaDigitalEmployeeTextBox)
        Me.TabPage6.Controls.Add(Me.Label36)
        Me.TabPage6.Controls.Add(Me.funcionariosCadComboBox)
        Me.TabPage6.Controls.Add(Me.imageFuncCadPictureBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1004, 709)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Cadastro de Funcionários"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(99, 515)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(237, 24)
        Me.Label42.TabIndex = 39
        Me.Label42.Text = "Cadastro Usuário do Caixa:"
        '
        'assinaturaDigitalRemoverButton
        '
        Me.assinaturaDigitalRemoverButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assinaturaDigitalRemoverButton.Location = New System.Drawing.Point(336, 443)
        Me.assinaturaDigitalRemoverButton.Name = "assinaturaDigitalRemoverButton"
        Me.assinaturaDigitalRemoverButton.Size = New System.Drawing.Size(95, 28)
        Me.assinaturaDigitalRemoverButton.TabIndex = 38
        Me.assinaturaDigitalRemoverButton.TabStop = False
        Me.assinaturaDigitalRemoverButton.Text = "Remover"
        Me.assinaturaDigitalRemoverButton.UseVisualStyleBackColor = True
        '
        'assinaturaDigitalCadastroButton
        '
        Me.assinaturaDigitalCadastroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assinaturaDigitalCadastroButton.Location = New System.Drawing.Point(336, 409)
        Me.assinaturaDigitalCadastroButton.Name = "assinaturaDigitalCadastroButton"
        Me.assinaturaDigitalCadastroButton.Size = New System.Drawing.Size(95, 28)
        Me.assinaturaDigitalCadastroButton.TabIndex = 37
        Me.assinaturaDigitalCadastroButton.TabStop = False
        Me.assinaturaDigitalCadastroButton.Text = "Cadastrar"
        Me.assinaturaDigitalCadastroButton.UseVisualStyleBackColor = True
        '
        'userEmployeeTextBox
        '
        Me.userEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userEmployeeTextBox.Location = New System.Drawing.Point(24, 586)
        Me.userEmployeeTextBox.Name = "userEmployeeTextBox"
        Me.userEmployeeTextBox.Size = New System.Drawing.Size(293, 26)
        Me.userEmployeeTextBox.TabIndex = 0
        Me.userEmployeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordEmployeeTextBox
        '
        Me.passwordEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordEmployeeTextBox.Location = New System.Drawing.Point(24, 640)
        Me.passwordEmployeeTextBox.Name = "passwordEmployeeTextBox"
        Me.passwordEmployeeTextBox.Size = New System.Drawing.Size(293, 26)
        Me.passwordEmployeeTextBox.TabIndex = 1
        Me.passwordEmployeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'atualizarFuncCadButton
        '
        Me.atualizarFuncCadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atualizarFuncCadButton.Location = New System.Drawing.Point(336, 611)
        Me.atualizarFuncCadButton.Name = "atualizarFuncCadButton"
        Me.atualizarFuncCadButton.Size = New System.Drawing.Size(95, 28)
        Me.atualizarFuncCadButton.TabIndex = 4
        Me.atualizarFuncCadButton.TabStop = False
        Me.atualizarFuncCadButton.Text = "Atualizar"
        Me.atualizarFuncCadButton.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(20, 615)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(70, 24)
        Me.Label41.TabIndex = 28
        Me.Label41.Text = "Senha:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(20, 559)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 24)
        Me.Label38.TabIndex = 26
        Me.Label38.Text = "Usuário:"
        '
        'removerCompraFiadoButton
        '
        Me.removerCompraFiadoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerCompraFiadoButton.Location = New System.Drawing.Point(871, 70)
        Me.removerCompraFiadoButton.Name = "removerCompraFiadoButton"
        Me.removerCompraFiadoButton.Size = New System.Drawing.Size(105, 70)
        Me.removerCompraFiadoButton.TabIndex = 24
        Me.removerCompraFiadoButton.TabStop = False
        Me.removerCompraFiadoButton.Text = "Remover Compra"
        Me.removerCompraFiadoButton.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(512, 102)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(203, 24)
        Me.Label40.TabIndex = 23
        Me.Label40.Text = "Valor Total da Compra:"
        '
        'valorTotalCompraFiadoTextBox
        '
        Me.valorTotalCompraFiadoTextBox.Enabled = False
        Me.valorTotalCompraFiadoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorTotalCompraFiadoTextBox.Location = New System.Drawing.Point(516, 129)
        Me.valorTotalCompraFiadoTextBox.Name = "valorTotalCompraFiadoTextBox"
        Me.valorTotalCompraFiadoTextBox.Size = New System.Drawing.Size(331, 26)
        Me.valorTotalCompraFiadoTextBox.TabIndex = 22
        Me.valorTotalCompraFiadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'funcionarioFiadoBoolCadastradoLabel
        '
        Me.funcionarioFiadoBoolCadastradoLabel.AutoSize = True
        Me.funcionarioFiadoBoolCadastradoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.funcionarioFiadoBoolCadastradoLabel.Location = New System.Drawing.Point(102, 14)
        Me.funcionarioFiadoBoolCadastradoLabel.Name = "funcionarioFiadoBoolCadastradoLabel"
        Me.funcionarioFiadoBoolCadastradoLabel.Size = New System.Drawing.Size(215, 24)
        Me.funcionarioFiadoBoolCadastradoLabel.TabIndex = 21
        Me.funcionarioFiadoBoolCadastradoLabel.Text = "     Funcionário Cadastro"
        '
        'removerFuncCadButton
        '
        Me.removerFuncCadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerFuncCadButton.Location = New System.Drawing.Point(336, 645)
        Me.removerFuncCadButton.Name = "removerFuncCadButton"
        Me.removerFuncCadButton.Size = New System.Drawing.Size(95, 28)
        Me.removerFuncCadButton.TabIndex = 5
        Me.removerFuncCadButton.TabStop = False
        Me.removerFuncCadButton.Text = "Remover"
        Me.removerFuncCadButton.UseVisualStyleBackColor = True
        '
        'cadastrarFuncCadButton
        '
        Me.cadastrarFuncCadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadastrarFuncCadButton.Location = New System.Drawing.Point(336, 577)
        Me.cadastrarFuncCadButton.Name = "cadastrarFuncCadButton"
        Me.cadastrarFuncCadButton.Size = New System.Drawing.Size(95, 28)
        Me.cadastrarFuncCadButton.TabIndex = 3
        Me.cadastrarFuncCadButton.TabStop = False
        Me.cadastrarFuncCadButton.Text = "Cadastrar"
        Me.cadastrarFuncCadButton.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(20, 398)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(157, 24)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Assinatura Digital:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(512, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(222, 24)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Datas de Compras Fiado:"
        '
        'datasComprasFiadoComboBox
        '
        Me.datasComprasFiadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.datasComprasFiadoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datasComprasFiadoComboBox.FormattingEnabled = True
        Me.datasComprasFiadoComboBox.Location = New System.Drawing.Point(516, 51)
        Me.datasComprasFiadoComboBox.Name = "datasComprasFiadoComboBox"
        Me.datasComprasFiadoComboBox.Size = New System.Drawing.Size(331, 28)
        Me.datasComprasFiadoComboBox.TabIndex = 15
        '
        'produtosEQuantidadesFiadoDataGridView
        '
        Me.produtosEQuantidadesFiadoDataGridView.AllowUserToAddRows = False
        Me.produtosEQuantidadesFiadoDataGridView.AllowUserToDeleteRows = False
        Me.produtosEQuantidadesFiadoDataGridView.AllowUserToResizeColumns = False
        Me.produtosEQuantidadesFiadoDataGridView.AllowUserToResizeRows = False
        Me.produtosEQuantidadesFiadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.produtosEQuantidadesFiadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdutosFiadoFunc, Me.QuantidadesFiadoFunc})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.produtosEQuantidadesFiadoDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.produtosEQuantidadesFiadoDataGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtosEQuantidadesFiadoDataGridView.Location = New System.Drawing.Point(478, 179)
        Me.produtosEQuantidadesFiadoDataGridView.MultiSelect = False
        Me.produtosEQuantidadesFiadoDataGridView.Name = "produtosEQuantidadesFiadoDataGridView"
        Me.produtosEQuantidadesFiadoDataGridView.ReadOnly = True
        Me.produtosEQuantidadesFiadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.produtosEQuantidadesFiadoDataGridView.Size = New System.Drawing.Size(526, 530)
        Me.produtosEQuantidadesFiadoDataGridView.TabIndex = 13
        Me.produtosEQuantidadesFiadoDataGridView.TabStop = False
        '
        'ProdutosFiadoFunc
        '
        Me.ProdutosFiadoFunc.HeaderText = "Produtos"
        Me.ProdutosFiadoFunc.Name = "ProdutosFiadoFunc"
        Me.ProdutosFiadoFunc.ReadOnly = True
        Me.ProdutosFiadoFunc.Width = 315
        '
        'QuantidadesFiadoFunc
        '
        Me.QuantidadesFiadoFunc.HeaderText = "Quantidades"
        Me.QuantidadesFiadoFunc.Name = "QuantidadesFiadoFunc"
        Me.QuantidadesFiadoFunc.ReadOnly = True
        Me.QuantidadesFiadoFunc.Width = 150
        '
        'assinaturaDigitalEmployeeTextBox
        '
        Me.assinaturaDigitalEmployeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assinaturaDigitalEmployeeTextBox.Location = New System.Drawing.Point(24, 425)
        Me.assinaturaDigitalEmployeeTextBox.MaxLength = 6
        Me.assinaturaDigitalEmployeeTextBox.Name = "assinaturaDigitalEmployeeTextBox"
        Me.assinaturaDigitalEmployeeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.assinaturaDigitalEmployeeTextBox.Size = New System.Drawing.Size(293, 26)
        Me.assinaturaDigitalEmployeeTextBox.TabIndex = 2
        Me.assinaturaDigitalEmployeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(20, 311)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(211, 24)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "Selecionar Funcionário:"
        '
        'funcionariosCadComboBox
        '
        Me.funcionariosCadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.funcionariosCadComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.funcionariosCadComboBox.FormattingEnabled = True
        Me.funcionariosCadComboBox.Location = New System.Drawing.Point(24, 338)
        Me.funcionariosCadComboBox.Name = "funcionariosCadComboBox"
        Me.funcionariosCadComboBox.Size = New System.Drawing.Size(407, 28)
        Me.funcionariosCadComboBox.TabIndex = 2
        '
        'imageFuncCadPictureBox
        '
        Me.imageFuncCadPictureBox.Image = Global.Controle_de_Estoque.My.Resources.Resources.default_profile_photo
        Me.imageFuncCadPictureBox.Location = New System.Drawing.Point(106, 51)
        Me.imageFuncCadPictureBox.Name = "imageFuncCadPictureBox"
        Me.imageFuncCadPictureBox.Size = New System.Drawing.Size(230, 230)
        Me.imageFuncCadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageFuncCadPictureBox.TabIndex = 36
        Me.imageFuncCadPictureBox.TabStop = False
        '
        'selecionarImagemOpenFileDialog
        '
        Me.selecionarImagemOpenFileDialog.FileName = "OpenFileDialog1"
        Me.selecionarImagemOpenFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *gif) | *.jpg; *.jpeg; *.jpe; *" &
    ".jfif; *.png;  *gif"
        Me.selecionarImagemOpenFileDialog.InitialDirectory = "C:\"
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.logoEmpresaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.produtosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produtoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.employeeInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoEmployeePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.reportAccessDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.imageProdCatPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produtosCategoriasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categoriaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.produtosEQuantidadesFiadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageFuncCadPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents openCaixaButton As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents produtosDataGridView As DataGridView
    Friend WithEvents nomeEmployeeTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents registerButton As Button
    Friend WithEvents employeeInfoDataGridView As DataGridView
    Friend WithEvents datasRadioButton As RadioButton
    Friend WithEvents nomesRadioButton As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents searchReportTextBox As TextBox
    Friend WithEvents removerButton As Button
    Friend WithEvents reportAccessDataGridView As DataGridView
    Friend WithEvents updateProdButton As Button
    Friend WithEvents removeProdButton As Button
    Friend WithEvents registerProdButton As Button
    Friend WithEvents quantidadeProdTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents codigoBarraProdTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents estoqueMinProdTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents preçoProdTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents nomeProdTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents idProdTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dataCadastroProdRadioButton As RadioButton
    Friend WithEvents quantidadeProdRadioButton As RadioButton
    Friend WithEvents codigoBarraProdRadioButton As RadioButton
    Friend WithEvents estoqueMinProdRadioButton As RadioButton
    Friend WithEvents preçoProdRadioButton As RadioButton
    Friend WithEvents nomesProdRadioButton As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents searchProdTextBox As TextBox
    Friend WithEvents selecionarImagemOpenFileDialog As OpenFileDialog
    Friend WithEvents nomeAdminTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SMTPHostComboBox As ComboBox
    Friend WithEvents showPasswordAdminCheckBox As CheckBox
    Friend WithEvents userAdminTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents senhaAdminTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents emailSystemTextBox As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents resumoRelatorioRadioButton As RadioButton
    Friend WithEvents completoRelatorioRadioButton As RadioButton
    Friend WithEvents cleanAllProdButton As Button
    Friend WithEvents dataAttProdTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents validadeProdTextBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cpfEmployeeTextBox As TextBox
    Friend WithEvents rgEmployeeTextBox As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents telefoneCelularEmployeeTextBox As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents telefoneResidencialEmployeeTextBox As TextBox
    Friend WithEvents endereçoEmployeeTextBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents fotoEmployeePictureBox As PictureBox
    Friend WithEvents cleanEmployeeButton As Button
    Friend WithEvents ID_employee As DataGridViewTextBoxColumn
    Friend WithEvents Nomes As DataGridViewTextBoxColumn
    Friend WithEvents RG As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Endereço As DataGridViewTextBoxColumn
    Friend WithEvents Tel_Residencial As DataGridViewTextBoxColumn
    Friend WithEvents Tel_Celular As DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents categoriaTypeTextBox As TextBox
    Friend WithEvents adicionarCategoriaButton As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents produtosCategoriasDataGridView As DataGridView
    Friend WithEvents adicionarProdutoCategoriaButton As Button
    Friend WithEvents produtosButtonsCaixaComboBox As ComboBox
    Friend WithEvents categoriaButtonsCaixaComboBox As ComboBox
    Friend WithEvents removerCategoriasButton As Button
    Friend WithEvents removerProdutoCategoriaButton As Button
    Friend WithEvents idEmployeeTextBox As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents utilizarNomeCategoriaCheckBox As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents categoriaPictureBox As PictureBox
    Friend WithEvents limparCategoriasButton As Button
    Friend WithEvents atualizarCategoriaButton As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents produtoPictureBox As PictureBox
    Friend WithEvents Label32 As Label
    Friend WithEvents removerFormaDePagamentoButton As Button
    Friend WithEvents adicionarFormaDePagamentoButton As Button
    Friend WithEvents formasDePagamentoComboBox As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents removerCompraFiadoButton As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents valorTotalCompraFiadoTextBox As TextBox
    Friend WithEvents funcionarioFiadoBoolCadastradoLabel As Label
    Friend WithEvents removerFuncCadButton As Button
    Friend WithEvents cadastrarFuncCadButton As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents datasComprasFiadoComboBox As ComboBox
    Friend WithEvents produtosEQuantidadesFiadoDataGridView As DataGridView
    Friend WithEvents assinaturaDigitalEmployeeTextBox As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents funcionariosCadComboBox As ComboBox
    Friend WithEvents atualizarFuncCadButton As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents userEmployeeTextBox As TextBox
    Friend WithEvents passwordEmployeeTextBox As TextBox
    Friend WithEvents assinaturaDigitalRemoverButton As Button
    Friend WithEvents assinaturaDigitalCadastroButton As Button
    Friend WithEvents imageFuncCadPictureBox As PictureBox
    Friend WithEvents IDProdutos As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Preços As DataGridViewTextBoxColumn
    Friend WithEvents Estoque_min As DataGridViewTextBoxColumn
    Friend WithEvents Codigo_barra As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Data_validade As DataGridViewTextBoxColumn
    Friend WithEvents Data_Att As DataGridViewTextBoxColumn
    Friend WithEvents ID_report As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Horas As DataGridViewTextBoxColumn
    Friend WithEvents Datas_Fechado As DataGridViewTextBoxColumn
    Friend WithEvents Horas_Fechado As DataGridViewTextBoxColumn
    Friend WithEvents ProdutosFiadoFunc As DataGridViewTextBoxColumn
    Friend WithEvents QuantidadesFiadoFunc As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents adicionarLoteButton As Button
    Friend WithEvents logoEmpresaPictureBox As PictureBox
    Friend WithEvents Produtos As DataGridViewTextBoxColumn
    Friend WithEvents Label42 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonLogOff As Button
    Friend WithEvents imageProdCatPictureBox As PictureBox
End Class
