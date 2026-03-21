namespace MMBSoftware.Views
{
    partial class CustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabClientDetail = new TabPage();
            tabClientsDetailTitle = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel4 = new Panel();
            labelTxtClientId = new Label();
            txtClientEditId = new TextBox();
            labelTxtDefineLimitAccount = new Label();
            txtDefineLimitAccount = new MaskedTextBox();
            labelCbDefineStateAccount = new Label();
            cbDefineStateAccount = new ComboBox();
            labelTxtClientEditInfo = new Label();
            txtMaskedClientCpf = new MaskedTextBox();
            txtMaskedClientPhone = new MaskedTextBox();
            labelTxtClientCpf = new Label();
            txtClientEmail = new TextBox();
            labelTxtClientPhone = new Label();
            labelTxtClientEmail = new Label();
            txtClientName = new TextBox();
            labelTxtClientName = new Label();
            panel6 = new Panel();
            checkBoxClientHaveAdress = new CheckBox();
            txtClientAdressNumber = new TextBox();
            labelTxtClientEditAdressNumber = new Label();
            txtClientAdressStreet = new TextBox();
            labelTxtClientEditAdressStreet = new Label();
            labelTxtClientEditAdressDistrict = new Label();
            labelTxtClientEditAdressCity = new Label();
            txtClientAdressCity = new TextBox();
            label22 = new Label();
            txtClientAdressDistrict = new TextBox();
            panel7 = new Panel();
            checkBoxClientHaveAccount = new CheckBox();
            btnCancelEdit = new Button();
            btnSaveEdit = new Button();
            tabClientList = new TabPage();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            labelTitleTxtSearch = new Label();
            txtSearchPd = new TextBox();
            btnSearch = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridClients = new DataGridView();
            tabControl1 = new TabControl();
            tabClientAccount = new TabPage();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            tabClientDetail.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tabClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            tabControl1.SuspendLayout();
            tabClientAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 2;
            label1.Text = "CLIENTES";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabClientDetail
            // 
            tabClientDetail.Controls.Add(tabClientsDetailTitle);
            tabClientDetail.Controls.Add(flowLayoutPanel2);
            tabClientDetail.Location = new Point(4, 28);
            tabClientDetail.Margin = new Padding(3, 2, 3, 2);
            tabClientDetail.Name = "tabClientDetail";
            tabClientDetail.Size = new Size(998, 479);
            tabClientDetail.TabIndex = 2;
            tabClientDetail.Text = "Detalhes do Cliente";
            tabClientDetail.UseVisualStyleBackColor = true;
            // 
            // tabClientsDetailTitle
            // 
            tabClientsDetailTitle.AutoSize = true;
            tabClientsDetailTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabClientsDetailTitle.Location = new Point(25, 10);
            tabClientsDetailTitle.Name = "tabClientsDetailTitle";
            tabClientsDetailTitle.Size = new Size(126, 29);
            tabClientsDetailTitle.TabIndex = 12;
            tabClientsDetailTitle.Text = "Title here...";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Location = new Point(3, 47);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(953, 425);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelTxtClientId);
            panel4.Controls.Add(txtClientEditId);
            panel4.Controls.Add(labelTxtDefineLimitAccount);
            panel4.Controls.Add(txtDefineLimitAccount);
            panel4.Controls.Add(labelCbDefineStateAccount);
            panel4.Controls.Add(cbDefineStateAccount);
            panel4.Controls.Add(labelTxtClientEditInfo);
            panel4.Controls.Add(txtMaskedClientCpf);
            panel4.Controls.Add(txtMaskedClientPhone);
            panel4.Controls.Add(labelTxtClientCpf);
            panel4.Controls.Add(txtClientEmail);
            panel4.Controls.Add(labelTxtClientPhone);
            panel4.Controls.Add(labelTxtClientEmail);
            panel4.Controls.Add(txtClientName);
            panel4.Controls.Add(labelTxtClientName);
            panel4.Location = new Point(3, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 356);
            panel4.TabIndex = 1;
            // 
            // labelTxtClientId
            // 
            labelTxtClientId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientId.AutoSize = true;
            labelTxtClientId.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTxtClientId.Location = new Point(277, 53);
            labelTxtClientId.Name = "labelTxtClientId";
            labelTxtClientId.Size = new Size(96, 20);
            labelTxtClientId.TabIndex = 22;
            labelTxtClientId.Text = "ID do Cliente";
            // 
            // txtClientEditId
            // 
            txtClientEditId.Font = new Font("Ebrima", 12F);
            txtClientEditId.Location = new Point(266, 74);
            txtClientEditId.Margin = new Padding(3, 2, 3, 2);
            txtClientEditId.Name = "txtClientEditId";
            txtClientEditId.Size = new Size(116, 29);
            txtClientEditId.TabIndex = 21;
            // 
            // labelTxtDefineLimitAccount
            // 
            labelTxtDefineLimitAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtDefineLimitAccount.AutoSize = true;
            labelTxtDefineLimitAccount.Enabled = false;
            labelTxtDefineLimitAccount.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTxtDefineLimitAccount.Location = new Point(31, 318);
            labelTxtDefineLimitAccount.Name = "labelTxtDefineLimitAccount";
            labelTxtDefineLimitAccount.Size = new Size(206, 20);
            labelTxtDefineLimitAccount.TabIndex = 20;
            labelTxtDefineLimitAccount.Text = "Definir Limite da Conta/Fiado";
            // 
            // txtDefineLimitAccount
            // 
            txtDefineLimitAccount.Enabled = false;
            txtDefineLimitAccount.Location = new Point(239, 316);
            txtDefineLimitAccount.Margin = new Padding(3, 2, 3, 2);
            txtDefineLimitAccount.Name = "txtDefineLimitAccount";
            txtDefineLimitAccount.Size = new Size(143, 27);
            txtDefineLimitAccount.TabIndex = 19;
            // 
            // labelCbDefineStateAccount
            // 
            labelCbDefineStateAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCbDefineStateAccount.AutoSize = true;
            labelCbDefineStateAccount.Enabled = false;
            labelCbDefineStateAccount.Font = new Font("Ebrima", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCbDefineStateAccount.Location = new Point(34, 265);
            labelCbDefineStateAccount.Name = "labelCbDefineStateAccount";
            labelCbDefineStateAccount.Size = new Size(173, 20);
            labelCbDefineStateAccount.TabIndex = 13;
            labelCbDefineStateAccount.Text = "Situação da Conta/Fiado";
            // 
            // cbDefineStateAccount
            // 
            cbDefineStateAccount.Enabled = false;
            cbDefineStateAccount.FormattingEnabled = true;
            cbDefineStateAccount.Items.AddRange(new object[] { "Aberta", "Fechada" });
            cbDefineStateAccount.Location = new Point(26, 287);
            cbDefineStateAccount.Margin = new Padding(3, 2, 3, 2);
            cbDefineStateAccount.Name = "cbDefineStateAccount";
            cbDefineStateAccount.Size = new Size(158, 27);
            cbDefineStateAccount.TabIndex = 12;
            // 
            // labelTxtClientEditInfo
            // 
            labelTxtClientEditInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientEditInfo.AutoSize = true;
            labelTxtClientEditInfo.Font = new Font("Ebrima", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTxtClientEditInfo.Location = new Point(31, 30);
            labelTxtClientEditInfo.Name = "labelTxtClientEditInfo";
            labelTxtClientEditInfo.Size = new Size(192, 25);
            labelTxtClientEditInfo.TabIndex = 11;
            labelTxtClientEditInfo.Text = "Informações Pessoais";
            // 
            // txtMaskedClientCpf
            // 
            txtMaskedClientCpf.Location = new Point(199, 231);
            txtMaskedClientCpf.Margin = new Padding(3, 2, 3, 2);
            txtMaskedClientCpf.Name = "txtMaskedClientCpf";
            txtMaskedClientCpf.Size = new Size(168, 27);
            txtMaskedClientCpf.TabIndex = 10;
            // 
            // txtMaskedClientPhone
            // 
            txtMaskedClientPhone.Location = new Point(26, 231);
            txtMaskedClientPhone.Margin = new Padding(3, 2, 3, 2);
            txtMaskedClientPhone.Name = "txtMaskedClientPhone";
            txtMaskedClientPhone.Size = new Size(168, 27);
            txtMaskedClientPhone.TabIndex = 9;
            // 
            // labelTxtClientCpf
            // 
            labelTxtClientCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientCpf.AutoSize = true;
            labelTxtClientCpf.Font = new Font("Ebrima", 12F);
            labelTxtClientCpf.Location = new Point(210, 208);
            labelTxtClientCpf.Name = "labelTxtClientCpf";
            labelTxtClientCpf.Size = new Size(37, 21);
            labelTxtClientCpf.TabIndex = 8;
            labelTxtClientCpf.Text = "CPF";
            // 
            // txtClientEmail
            // 
            txtClientEmail.Font = new Font("Ebrima", 12F);
            txtClientEmail.Location = new Point(23, 157);
            txtClientEmail.Margin = new Padding(3, 2, 3, 2);
            txtClientEmail.Name = "txtClientEmail";
            txtClientEmail.Size = new Size(359, 29);
            txtClientEmail.TabIndex = 7;
            // 
            // labelTxtClientPhone
            // 
            labelTxtClientPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientPhone.AutoSize = true;
            labelTxtClientPhone.Font = new Font("Ebrima", 12F);
            labelTxtClientPhone.Location = new Point(37, 208);
            labelTxtClientPhone.Name = "labelTxtClientPhone";
            labelTxtClientPhone.Size = new Size(124, 21);
            labelTxtClientPhone.TabIndex = 3;
            labelTxtClientPhone.Text = "Telefone/Celular";
            // 
            // labelTxtClientEmail
            // 
            labelTxtClientEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientEmail.AutoSize = true;
            labelTxtClientEmail.Font = new Font("Ebrima", 12F);
            labelTxtClientEmail.Location = new Point(34, 134);
            labelTxtClientEmail.Name = "labelTxtClientEmail";
            labelTxtClientEmail.Size = new Size(48, 21);
            labelTxtClientEmail.TabIndex = 5;
            labelTxtClientEmail.Text = "Email";
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Ebrima", 12F);
            txtClientName.Location = new Point(23, 105);
            txtClientName.Margin = new Padding(3, 2, 3, 2);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(359, 29);
            txtClientName.TabIndex = 6;
            // 
            // labelTxtClientName
            // 
            labelTxtClientName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientName.AutoSize = true;
            labelTxtClientName.Font = new Font("Ebrima", 12F);
            labelTxtClientName.Location = new Point(31, 82);
            labelTxtClientName.Name = "labelTxtClientName";
            labelTxtClientName.Size = new Size(124, 21);
            labelTxtClientName.TabIndex = 4;
            labelTxtClientName.Text = "Nome do cliente";
            // 
            // panel6
            // 
            panel6.Controls.Add(checkBoxClientHaveAdress);
            panel6.Controls.Add(txtClientAdressNumber);
            panel6.Controls.Add(labelTxtClientEditAdressNumber);
            panel6.Controls.Add(txtClientAdressStreet);
            panel6.Controls.Add(labelTxtClientEditAdressStreet);
            panel6.Controls.Add(labelTxtClientEditAdressDistrict);
            panel6.Controls.Add(labelTxtClientEditAdressCity);
            panel6.Controls.Add(txtClientAdressCity);
            panel6.Controls.Add(label22);
            panel6.Controls.Add(txtClientAdressDistrict);
            panel6.Location = new Point(412, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(538, 356);
            panel6.TabIndex = 2;
            // 
            // checkBoxClientHaveAdress
            // 
            checkBoxClientHaveAdress.AutoSize = true;
            checkBoxClientHaveAdress.Location = new Point(25, 244);
            checkBoxClientHaveAdress.Margin = new Padding(3, 2, 3, 2);
            checkBoxClientHaveAdress.Name = "checkBoxClientHaveAdress";
            checkBoxClientHaveAdress.Size = new Size(164, 23);
            checkBoxClientHaveAdress.TabIndex = 18;
            checkBoxClientHaveAdress.Text = "Não possui endereço";
            checkBoxClientHaveAdress.UseVisualStyleBackColor = true;
            // 
            // txtClientAdressNumber
            // 
            txtClientAdressNumber.Font = new Font("Ebrima", 12F);
            txtClientAdressNumber.Location = new Point(25, 211);
            txtClientAdressNumber.Margin = new Padding(3, 2, 3, 2);
            txtClientAdressNumber.Name = "txtClientAdressNumber";
            txtClientAdressNumber.Size = new Size(109, 29);
            txtClientAdressNumber.TabIndex = 15;
            // 
            // labelTxtClientEditAdressNumber
            // 
            labelTxtClientEditAdressNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientEditAdressNumber.AutoSize = true;
            labelTxtClientEditAdressNumber.Font = new Font("Ebrima", 12F);
            labelTxtClientEditAdressNumber.Location = new Point(25, 188);
            labelTxtClientEditAdressNumber.Name = "labelTxtClientEditAdressNumber";
            labelTxtClientEditAdressNumber.Size = new Size(68, 21);
            labelTxtClientEditAdressNumber.TabIndex = 14;
            labelTxtClientEditAdressNumber.Text = "Número";
            // 
            // txtClientAdressStreet
            // 
            txtClientAdressStreet.Font = new Font("Ebrima", 12F);
            txtClientAdressStreet.Location = new Point(25, 157);
            txtClientAdressStreet.Margin = new Padding(3, 2, 3, 2);
            txtClientAdressStreet.Name = "txtClientAdressStreet";
            txtClientAdressStreet.Size = new Size(440, 29);
            txtClientAdressStreet.TabIndex = 13;
            // 
            // labelTxtClientEditAdressStreet
            // 
            labelTxtClientEditAdressStreet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientEditAdressStreet.AutoSize = true;
            labelTxtClientEditAdressStreet.Font = new Font("Ebrima", 12F);
            labelTxtClientEditAdressStreet.Location = new Point(25, 134);
            labelTxtClientEditAdressStreet.Name = "labelTxtClientEditAdressStreet";
            labelTxtClientEditAdressStreet.Size = new Size(99, 21);
            labelTxtClientEditAdressStreet.TabIndex = 12;
            labelTxtClientEditAdressStreet.Text = "Rua/Avenida";
            // 
            // labelTxtClientEditAdressDistrict
            // 
            labelTxtClientEditAdressDistrict.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientEditAdressDistrict.AutoSize = true;
            labelTxtClientEditAdressDistrict.Font = new Font("Ebrima", 12F);
            labelTxtClientEditAdressDistrict.Location = new Point(264, 82);
            labelTxtClientEditAdressDistrict.Name = "labelTxtClientEditAdressDistrict";
            labelTxtClientEditAdressDistrict.Size = new Size(52, 21);
            labelTxtClientEditAdressDistrict.TabIndex = 11;
            labelTxtClientEditAdressDistrict.Text = "Bairro";
            // 
            // labelTxtClientEditAdressCity
            // 
            labelTxtClientEditAdressCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTxtClientEditAdressCity.AutoSize = true;
            labelTxtClientEditAdressCity.Font = new Font("Ebrima", 12F);
            labelTxtClientEditAdressCity.Location = new Point(25, 82);
            labelTxtClientEditAdressCity.Name = "labelTxtClientEditAdressCity";
            labelTxtClientEditAdressCity.Size = new Size(58, 21);
            labelTxtClientEditAdressCity.TabIndex = 10;
            labelTxtClientEditAdressCity.Text = "Cidade";
            // 
            // txtClientAdressCity
            // 
            txtClientAdressCity.Font = new Font("Ebrima", 12F);
            txtClientAdressCity.Location = new Point(25, 105);
            txtClientAdressCity.Margin = new Padding(3, 2, 3, 2);
            txtClientAdressCity.Name = "txtClientAdressCity";
            txtClientAdressCity.Size = new Size(226, 29);
            txtClientAdressCity.TabIndex = 9;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Ebrima", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(87, 22);
            label22.Name = "label22";
            label22.Size = new Size(91, 25);
            label22.TabIndex = 8;
            label22.Text = "Endereço";
            // 
            // txtClientAdressDistrict
            // 
            txtClientAdressDistrict.Font = new Font("Ebrima", 12F);
            txtClientAdressDistrict.Location = new Point(264, 105);
            txtClientAdressDistrict.Margin = new Padding(3, 2, 3, 2);
            txtClientAdressDistrict.Name = "txtClientAdressDistrict";
            txtClientAdressDistrict.Size = new Size(201, 29);
            txtClientAdressDistrict.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Controls.Add(checkBoxClientHaveAccount);
            panel7.Controls.Add(btnCancelEdit);
            panel7.Controls.Add(btnSaveEdit);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(3, 362);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(376, 68);
            panel7.TabIndex = 2;
            // 
            // checkBoxClientHaveAccount
            // 
            checkBoxClientHaveAccount.AutoSize = true;
            checkBoxClientHaveAccount.Enabled = false;
            checkBoxClientHaveAccount.Location = new Point(20, 2);
            checkBoxClientHaveAccount.Margin = new Padding(3, 2, 3, 2);
            checkBoxClientHaveAccount.Name = "checkBoxClientHaveAccount";
            checkBoxClientHaveAccount.Size = new Size(203, 23);
            checkBoxClientHaveAccount.TabIndex = 23;
            checkBoxClientHaveAccount.Text = "Cliente possui Conta/Fiado";
            checkBoxClientHaveAccount.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Font = new Font("Ebrima", 12F);
            btnCancelEdit.Location = new Point(199, 26);
            btnCancelEdit.Margin = new Padding(3, 2, 3, 2);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(168, 29);
            btnCancelEdit.TabIndex = 2;
            btnCancelEdit.Text = "Cancelar";
            btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Font = new Font("Ebrima", 12F);
            btnSaveEdit.Location = new Point(20, 26);
            btnSaveEdit.Margin = new Padding(3, 2, 3, 2);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(168, 29);
            btnSaveEdit.TabIndex = 1;
            btnSaveEdit.Text = "Salvar";
            btnSaveEdit.UseVisualStyleBackColor = true;
            // 
            // tabClientList
            // 
            tabClientList.BackColor = SystemColors.Control;
            tabClientList.Controls.Add(label2);
            tabClientList.Controls.Add(checkedListBox1);
            tabClientList.Controls.Add(labelTitleTxtSearch);
            tabClientList.Controls.Add(txtSearchPd);
            tabClientList.Controls.Add(btnSearch);
            tabClientList.Controls.Add(btnDel);
            tabClientList.Controls.Add(btnEdit);
            tabClientList.Controls.Add(btnAdd);
            tabClientList.Controls.Add(dataGridClients);
            tabClientList.Location = new Point(4, 28);
            tabClientList.Margin = new Padding(3, 2, 3, 2);
            tabClientList.Name = "tabClientList";
            tabClientList.Padding = new Padding(3, 2, 3, 2);
            tabClientList.Size = new Size(998, 479);
            tabClientList.TabIndex = 0;
            tabClientList.Text = "Lista de Clientes";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(679, 96);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 12;
            label2.Text = "Filtros";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Ordem Alfabética", "Ordem Alfabética Reversa", "Por CPF", "Por Telefone", "Possui Conta", "Por Limite de Conta", "Por Quantia de Dívida" });
            checkedListBox1.Location = new Point(679, 119);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(245, 136);
            checkedListBox1.TabIndex = 11;
            // 
            // labelTitleTxtSearch
            // 
            labelTitleTxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTitleTxtSearch.AutoSize = true;
            labelTitleTxtSearch.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitleTxtSearch.Location = new Point(679, 34);
            labelTitleTxtSearch.Name = "labelTitleTxtSearch";
            labelTitleTxtSearch.Size = new Size(164, 21);
            labelTitleTxtSearch.TabIndex = 10;
            labelTitleTxtSearch.Text = "Pesquisar por Clientes";
            // 
            // txtSearchPd
            // 
            txtSearchPd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchPd.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPd.Location = new Point(679, 58);
            txtSearchPd.Margin = new Padding(3, 2, 3, 2);
            txtSearchPd.Name = "txtSearchPd";
            txtSearchPd.Size = new Size(245, 29);
            txtSearchPd.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Calibri", 12F);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.BottomCenter;
            btnSearch.Location = new Point(747, 282);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 27);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDel.BackColor = Color.Transparent;
            btnDel.Font = new Font("Calibri", 12F);
            btnDel.ForeColor = SystemColors.ControlText;
            btnDel.ImageAlign = ContentAlignment.BottomCenter;
            btnDel.Location = new Point(276, 426);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(123, 27);
            btnDel.TabIndex = 7;
            btnDel.Text = "Deletar";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Font = new Font("Calibri", 12F);
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.ImageAlign = ContentAlignment.BottomCenter;
            btnEdit.Location = new Point(148, 426);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 27);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Calibri", 12F);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.ImageAlign = ContentAlignment.BottomCenter;
            btnAdd.Location = new Point(19, 426);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 27);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridClients
            // 
            dataGridClients.AllowUserToAddRows = false;
            dataGridClients.AllowUserToDeleteRows = false;
            dataGridClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.Location = new Point(19, 35);
            dataGridClients.Margin = new Padding(3, 2, 3, 2);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.ReadOnly = true;
            dataGridClients.RowHeadersWidth = 51;
            dataGridClients.Size = new Size(654, 386);
            dataGridClients.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabClientList);
            tabControl1.Controls.Add(tabClientDetail);
            tabControl1.Controls.Add(tabClientAccount);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 67);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1006, 511);
            tabControl1.TabIndex = 4;
            // 
            // tabClientAccount
            // 
            tabClientAccount.Controls.Add(dataGridView1);
            tabClientAccount.Location = new Point(4, 28);
            tabClientAccount.Margin = new Padding(3, 2, 3, 2);
            tabClientAccount.Name = "tabClientAccount";
            tabClientAccount.Padding = new Padding(3, 2, 3, 2);
            tabClientAccount.Size = new Size(998, 479);
            tabClientAccount.TabIndex = 3;
            tabClientAccount.Text = "Lista de Contas";
            tabClientAccount.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 34);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(452, 422);
            dataGridView1.TabIndex = 0;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 578);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerView";
            Text = "CustomerView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabClientDetail.ResumeLayout(false);
            tabClientDetail.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tabClientList.ResumeLayout(false);
            tabClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            tabControl1.ResumeLayout(false);
            tabClientAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabPage tabClientDetail;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Label labelTxtClientId;
        private TextBox txtClientEditId;
        private Label labelTxtDefineLimitAccount;
        private MaskedTextBox txtDefineLimitAccount;
        private Label labelCbDefineStateAccount;
        private ComboBox cbDefineStateAccount;
        private Label labelTxtClientEditInfo;
        private MaskedTextBox txtMaskedClientCpf;
        private MaskedTextBox txtMaskedClientPhone;
        private Label labelTxtClientCpf;
        private TextBox txtClientEmail;
        private Label labelTxtClientPhone;
        private Label labelTxtClientEmail;
        private TextBox txtClientName;
        private Label labelTxtClientName;
        private Panel panel6;
        private CheckBox checkBoxClientHaveAdress;
        private TextBox txtClientAdressNumber;
        private Label labelTxtClientEditAdressNumber;
        private TextBox txtClientAdressStreet;
        private Label labelTxtClientEditAdressStreet;
        private Label labelTxtClientEditAdressDistrict;
        private Label labelTxtClientEditAdressCity;
        private TextBox txtClientAdressCity;
        private Label label22;
        private TextBox txtClientAdressDistrict;
        private Panel panel7;
        private CheckBox checkBoxClientHaveAccount;
        private Button btnCancelEdit;
        private Button btnSaveEdit;
        private TabPage tabClientList;
        private Label labelTitleTxtSearch;
        private TextBox txtSearchPd;
        private Button btnSearch;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridClients;
        private TabControl tabControl1;
        private Label tabClientsDetailTitle;
        private TabPage tabClientAccount;
        private DataGridView dataGridView1;
        private Label label2;
        private CheckedListBox checkedListBox1;
    }
}