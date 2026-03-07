namespace MMBSoftware.Views
{
    partial class ProductView
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
            tabControl1 = new TabControl();
            tabListPd = new TabPage();
            label8 = new Label();
            checkedListBox1 = new CheckedListBox();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            label2 = new Label();
            txtSearchPd = new TextBox();
            dataGridViewProducts = new DataGridView();
            tabDetailPd = new TabPage();
            tabPdDetailTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            txtFieldName = new TextBox();
            label4 = new Label();
            txtFieldId = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            cbFieldCategory = new ComboBox();
            txtFieldPrice = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtFieldDescription = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            btnDetailCancel = new Button();
            btnDetailSave = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabListPd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabDetailPd.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 0;
            label1.Text = "PRODUTOS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabListPd);
            tabControl1.Controls.Add(tabDetailPd);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 67);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(936, 489);
            tabControl1.TabIndex = 1;
            // 
            // tabListPd
            // 
            tabListPd.BackColor = Color.WhiteSmoke;
            tabListPd.Controls.Add(label8);
            tabListPd.Controls.Add(checkedListBox1);
            tabListPd.Controls.Add(btnDel);
            tabListPd.Controls.Add(btnEdit);
            tabListPd.Controls.Add(btnAdd);
            tabListPd.Controls.Add(btnSearch);
            tabListPd.Controls.Add(label2);
            tabListPd.Controls.Add(txtSearchPd);
            tabListPd.Controls.Add(dataGridViewProducts);
            tabListPd.Location = new Point(4, 28);
            tabListPd.Margin = new Padding(3, 2, 3, 2);
            tabListPd.Name = "tabListPd";
            tabListPd.Padding = new Padding(3, 2, 3, 2);
            tabListPd.Size = new Size(928, 457);
            tabListPd.TabIndex = 0;
            tabListPd.Text = "Lista de Produtos";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(635, 99);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 13;
            label8.Text = "Filtros";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Ordem Alfabética", "Ordem Alfabética Reversa", "Por Maior Preço", "Por Menor Preço", "Por Categoria" });
            checkedListBox1.Location = new Point(635, 122);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(227, 92);
            checkedListBox1.TabIndex = 12;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDel.BackColor = Color.Transparent;
            btnDel.Font = new Font("Calibri", 12F);
            btnDel.ForeColor = SystemColors.ControlText;
            btnDel.ImageAlign = ContentAlignment.BottomCenter;
            btnDel.Location = new Point(274, 417);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(123, 27);
            btnDel.TabIndex = 6;
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
            btnEdit.Location = new Point(145, 417);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 27);
            btnEdit.TabIndex = 5;
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
            btnAdd.Location = new Point(17, 417);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 27);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Calibri", 12F);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.BottomCenter;
            btnSearch.Location = new Point(696, 243);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(635, 38);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar Produtos";
            // 
            // txtSearchPd
            // 
            txtSearchPd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchPd.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPd.Location = new Point(635, 61);
            txtSearchPd.Margin = new Padding(3, 2, 3, 2);
            txtSearchPd.Name = "txtSearchPd";
            txtSearchPd.Size = new Size(227, 29);
            txtSearchPd.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(17, 38);
            dataGridViewProducts.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(613, 375);
            dataGridViewProducts.TabIndex = 0;
            // 
            // tabDetailPd
            // 
            tabDetailPd.Controls.Add(tabPdDetailTitle);
            tabDetailPd.Controls.Add(flowLayoutPanel1);
            tabDetailPd.Location = new Point(4, 28);
            tabDetailPd.Margin = new Padding(3, 2, 3, 2);
            tabDetailPd.Name = "tabDetailPd";
            tabDetailPd.Padding = new Padding(3, 2, 3, 2);
            tabDetailPd.Size = new Size(928, 457);
            tabDetailPd.TabIndex = 1;
            tabDetailPd.Text = "Detalhes do Produto";
            tabDetailPd.UseVisualStyleBackColor = true;
            // 
            // tabPdDetailTitle
            // 
            tabPdDetailTitle.AutoSize = true;
            tabPdDetailTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPdDetailTitle.Location = new Point(23, 9);
            tabPdDetailTitle.Name = "tabPdDetailTitle";
            tabPdDetailTitle.Size = new Size(108, 29);
            tabPdDetailTitle.TabIndex = 1;
            tabPdDetailTitle.Text = "Title here";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(536, 340);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtFieldName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtFieldId);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 151);
            panel2.TabIndex = 1;
            // 
            // txtFieldName
            // 
            txtFieldName.Font = new Font("Ebrima", 12F);
            txtFieldName.Location = new Point(23, 106);
            txtFieldName.Margin = new Padding(3, 2, 3, 2);
            txtFieldName.Name = "txtFieldName";
            txtFieldName.Size = new Size(226, 29);
            txtFieldName.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12F);
            label4.Location = new Point(23, 83);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 3;
            label4.Text = "Nome";
            // 
            // txtFieldId
            // 
            txtFieldId.Font = new Font("Ebrima", 12F);
            txtFieldId.Location = new Point(23, 53);
            txtFieldId.Margin = new Padding(3, 2, 3, 2);
            txtFieldId.Name = "txtFieldId";
            txtFieldId.ReadOnly = true;
            txtFieldId.Size = new Size(110, 29);
            txtFieldId.TabIndex = 2;
            txtFieldId.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 12F);
            label3.Location = new Point(20, 30);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 1;
            label3.Text = "Produto ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbFieldCategory);
            panel3.Controls.Add(txtFieldPrice);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(271, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 151);
            panel3.TabIndex = 2;
            // 
            // cbFieldCategory
            // 
            cbFieldCategory.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFieldCategory.FormattingEnabled = true;
            cbFieldCategory.Location = new Point(17, 106);
            cbFieldCategory.Margin = new Padding(3, 2, 3, 2);
            cbFieldCategory.Name = "cbFieldCategory";
            cbFieldCategory.Size = new Size(227, 29);
            cbFieldCategory.TabIndex = 7;
            // 
            // txtFieldPrice
            // 
            txtFieldPrice.Font = new Font("Ebrima", 12F);
            txtFieldPrice.Location = new Point(17, 53);
            txtFieldPrice.Margin = new Padding(3, 2, 3, 2);
            txtFieldPrice.Name = "txtFieldPrice";
            txtFieldPrice.Size = new Size(110, 29);
            txtFieldPrice.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 12F);
            label6.Location = new Point(17, 30);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 5;
            label6.Text = "Preço";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 12F);
            label5.Location = new Point(17, 83);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 3;
            label5.Text = "Categoria";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtFieldDescription);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(3, 157);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(524, 111);
            panel4.TabIndex = 3;
            // 
            // txtFieldDescription
            // 
            txtFieldDescription.Font = new Font("Ebrima", 12F);
            txtFieldDescription.Location = new Point(23, 24);
            txtFieldDescription.Margin = new Padding(3, 2, 3, 2);
            txtFieldDescription.Multiline = true;
            txtFieldDescription.Name = "txtFieldDescription";
            txtFieldDescription.Size = new Size(489, 78);
            txtFieldDescription.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 12F);
            label7.Location = new Point(23, 1);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 7;
            label7.Text = "Descrição";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDetailCancel);
            panel5.Controls.Add(btnDetailSave);
            panel5.Location = new Point(3, 272);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(524, 44);
            panel5.TabIndex = 2;
            // 
            // btnDetailCancel
            // 
            btnDetailCancel.Font = new Font("Ebrima", 12F);
            btnDetailCancel.Location = new Point(214, 13);
            btnDetailCancel.Margin = new Padding(3, 2, 3, 2);
            btnDetailCancel.Name = "btnDetailCancel";
            btnDetailCancel.Size = new Size(168, 29);
            btnDetailCancel.TabIndex = 2;
            btnDetailCancel.Text = "Cancelar";
            btnDetailCancel.UseVisualStyleBackColor = true;
            // 
            // btnDetailSave
            // 
            btnDetailSave.Font = new Font("Ebrima", 12F);
            btnDetailSave.Location = new Point(20, 13);
            btnDetailSave.Margin = new Padding(3, 2, 3, 2);
            btnDetailSave.Name = "btnDetailSave";
            btnDetailSave.Size = new Size(168, 29);
            btnDetailSave.TabIndex = 1;
            btnDetailSave.Text = "Salvar";
            btnDetailSave.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 556);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabListPd.ResumeLayout(false);
            tabListPd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabDetailPd.ResumeLayout(false);
            tabDetailPd.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabListPd;
        private TabPage tabDetailPd;
        private Button btnSearch;
        private Label label2;
        private TextBox txtSearchPd;
        private DataGridView dataGridViewProducts;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox txtFieldName;
        private Label label4;
        private TextBox txtFieldId;
        private Label label3;
        private Panel panel3;
        private TextBox txtFieldPrice;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private TextBox txtFieldDescription;
        private Label label7;
        private Panel panel5;
        private Button btnDetailCancel;
        private Button btnDetailSave;
        private Label tabPdDetailTitle;
        private ComboBox cbFieldCategory;
        private CheckedListBox checkedListBox1;
        private Label label8;
    }
}