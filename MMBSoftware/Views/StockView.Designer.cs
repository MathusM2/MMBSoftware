namespace MMBSoftware.Views
{
    partial class StockView
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
            tabStockEdit = new TabControl();
            tabStockList = new TabPage();
            btnResetList = new Button();
            btnFilter = new Button();
            label9 = new Label();
            btnSearch = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label2 = new Label();
            txtSearchPd = new TextBox();
            dataGridStockList = new DataGridView();
            tabStockRegEdit = new TabPage();
            tabPdDetailTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            cbFieldTypeUnit = new ComboBox();
            label11 = new Label();
            txtFieldExpiryDate = new TextBox();
            label10 = new Label();
            txtFieldEntryDate = new TextBox();
            label8 = new Label();
            txtFieldQuantity = new TextBox();
            txtFieldId = new TextBox();
            label7 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            FieldPd_Id = new TextBox();
            label6 = new Label();
            FieldPd_Name = new TextBox();
            cbFieldProduct = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            btnDetailCancel = new Button();
            btnDetailSave = new Button();
            panel1.SuspendLayout();
            tabStockEdit.SuspendLayout();
            tabStockList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStockList).BeginInit();
            tabStockRegEdit.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 73);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 1;
            label1.Text = "ESTOQUE";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabStockEdit
            // 
            tabStockEdit.Controls.Add(tabStockList);
            tabStockEdit.Controls.Add(tabStockRegEdit);
            tabStockEdit.Dock = DockStyle.Fill;
            tabStockEdit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabStockEdit.Location = new Point(0, 73);
            tabStockEdit.Margin = new Padding(3, 2, 3, 2);
            tabStockEdit.Name = "tabStockEdit";
            tabStockEdit.SelectedIndex = 0;
            tabStockEdit.Size = new Size(968, 476);
            tabStockEdit.TabIndex = 1;
            // 
            // tabStockList
            // 
            tabStockList.BackColor = Color.WhiteSmoke;
            tabStockList.Controls.Add(btnResetList);
            tabStockList.Controls.Add(btnFilter);
            tabStockList.Controls.Add(label9);
            tabStockList.Controls.Add(btnSearch);
            tabStockList.Controls.Add(btnDel);
            tabStockList.Controls.Add(btnEdit);
            tabStockList.Controls.Add(btnAdd);
            tabStockList.Controls.Add(label2);
            tabStockList.Controls.Add(txtSearchPd);
            tabStockList.Controls.Add(dataGridStockList);
            tabStockList.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabStockList.Location = new Point(4, 28);
            tabStockList.Margin = new Padding(3, 2, 3, 2);
            tabStockList.Name = "tabStockList";
            tabStockList.Padding = new Padding(3, 2, 3, 2);
            tabStockList.Size = new Size(960, 444);
            tabStockList.TabIndex = 0;
            tabStockList.Text = "Lista do Estoque";
            // 
            // btnResetList
            // 
            btnResetList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetList.Location = new Point(639, 375);
            btnResetList.Margin = new Padding(3, 2, 3, 2);
            btnResetList.Name = "btnResetList";
            btnResetList.Size = new Size(31, 26);
            btnResetList.TabIndex = 16;
            btnResetList.Text = ">";
            btnResetList.UseVisualStyleBackColor = true;
            btnResetList.Click += btnResetList_Click;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilter.Location = new Point(702, 93);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(25, 21);
            btnFilter.TabIndex = 15;
            btnFilter.Text = ">";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += button1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(639, 92);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 14;
            label9.Text = "Filtros";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Calibri", 12F);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.BottomCenter;
            btnSearch.Location = new Point(639, 136);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 27);
            btnSearch.TabIndex = 12;
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
            btnDel.Location = new Point(273, 405);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(123, 27);
            btnDel.TabIndex = 11;
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
            btnEdit.Location = new Point(144, 405);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 27);
            btnEdit.TabIndex = 10;
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
            btnAdd.Location = new Point(16, 405);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 27);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(639, 34);
            label2.Name = "label2";
            label2.Size = new Size(158, 21);
            label2.TabIndex = 5;
            label2.Text = "Pesquisar no estoque";
            // 
            // txtSearchPd
            // 
            txtSearchPd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchPd.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPd.Location = new Point(639, 58);
            txtSearchPd.Margin = new Padding(3, 2, 3, 2);
            txtSearchPd.Name = "txtSearchPd";
            txtSearchPd.Size = new Size(230, 29);
            txtSearchPd.TabIndex = 3;
            // 
            // dataGridStockList
            // 
            dataGridStockList.AllowUserToAddRows = false;
            dataGridStockList.AllowUserToDeleteRows = false;
            dataGridStockList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridStockList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStockList.Location = new Point(16, 34);
            dataGridStockList.Margin = new Padding(3, 2, 3, 2);
            dataGridStockList.Name = "dataGridStockList";
            dataGridStockList.ReadOnly = true;
            dataGridStockList.RowHeadersWidth = 51;
            dataGridStockList.Size = new Size(618, 366);
            dataGridStockList.TabIndex = 2;
            // 
            // tabStockRegEdit
            // 
            tabStockRegEdit.Controls.Add(tabPdDetailTitle);
            tabStockRegEdit.Controls.Add(flowLayoutPanel1);
            tabStockRegEdit.Location = new Point(4, 28);
            tabStockRegEdit.Margin = new Padding(3, 2, 3, 2);
            tabStockRegEdit.Name = "tabStockRegEdit";
            tabStockRegEdit.Padding = new Padding(3, 2, 3, 2);
            tabStockRegEdit.Size = new Size(960, 444);
            tabStockRegEdit.TabIndex = 1;
            tabStockRegEdit.Text = "Produto em estoque";
            tabStockRegEdit.UseVisualStyleBackColor = true;
            // 
            // tabPdDetailTitle
            // 
            tabPdDetailTitle.AutoSize = true;
            tabPdDetailTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPdDetailTitle.Location = new Point(30, 11);
            tabPdDetailTitle.Name = "tabPdDetailTitle";
            tabPdDetailTitle.Size = new Size(108, 29);
            tabPdDetailTitle.TabIndex = 3;
            tabPdDetailTitle.Text = "Title here";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(7, 48);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 325);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbFieldTypeUnit);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtFieldExpiryDate);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtFieldEntryDate);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtFieldQuantity);
            panel2.Controls.Add(txtFieldId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 249);
            panel2.TabIndex = 1;
            // 
            // cbFieldTypeUnit
            // 
            cbFieldTypeUnit.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFieldTypeUnit.FormattingEnabled = true;
            cbFieldTypeUnit.Location = new Point(153, 92);
            cbFieldTypeUnit.Margin = new Padding(3, 2, 3, 2);
            cbFieldTypeUnit.Name = "cbFieldTypeUnit";
            cbFieldTypeUnit.Size = new Size(113, 29);
            cbFieldTypeUnit.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Ebrima", 12F);
            label11.Location = new Point(139, 69);
            label11.Name = "label11";
            label11.Size = new Size(123, 21);
            label11.TabIndex = 10;
            label11.Text = "Tipo de Unidade";
            // 
            // txtFieldExpiryDate
            // 
            txtFieldExpiryDate.Font = new Font("Ebrima", 12F);
            txtFieldExpiryDate.Location = new Point(20, 199);
            txtFieldExpiryDate.Margin = new Padding(3, 2, 3, 2);
            txtFieldExpiryDate.Name = "txtFieldExpiryDate";
            txtFieldExpiryDate.Size = new Size(134, 29);
            txtFieldExpiryDate.TabIndex = 9;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Ebrima", 12F);
            label10.Location = new Point(20, 175);
            label10.Name = "label10";
            label10.Size = new Size(125, 21);
            label10.TabIndex = 8;
            label10.Text = "Data de validade";
            // 
            // txtFieldEntryDate
            // 
            txtFieldEntryDate.Font = new Font("Ebrima", 12F);
            txtFieldEntryDate.Location = new Point(20, 144);
            txtFieldEntryDate.Margin = new Padding(3, 2, 3, 2);
            txtFieldEntryDate.Name = "txtFieldEntryDate";
            txtFieldEntryDate.Size = new Size(134, 29);
            txtFieldEntryDate.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 12F);
            label8.Location = new Point(20, 122);
            label8.Name = "label8";
            label8.Size = new Size(120, 21);
            label8.TabIndex = 5;
            label8.Text = "Data de entrada";
            // 
            // txtFieldQuantity
            // 
            txtFieldQuantity.Font = new Font("Ebrima", 12F);
            txtFieldQuantity.Location = new Point(20, 92);
            txtFieldQuantity.Margin = new Padding(3, 2, 3, 2);
            txtFieldQuantity.Name = "txtFieldQuantity";
            txtFieldQuantity.Size = new Size(106, 29);
            txtFieldQuantity.TabIndex = 6;
            // 
            // txtFieldId
            // 
            txtFieldId.Font = new Font("Ebrima", 12F);
            txtFieldId.Location = new Point(20, 40);
            txtFieldId.Margin = new Padding(3, 2, 3, 2);
            txtFieldId.Name = "txtFieldId";
            txtFieldId.ReadOnly = true;
            txtFieldId.Size = new Size(106, 29);
            txtFieldId.TabIndex = 2;
            txtFieldId.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 12F);
            label7.Location = new Point(20, 69);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 4;
            label7.Text = "Quantidade";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 12F);
            label3.Location = new Point(20, 17);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 1;
            label3.Text = "Código do Estoque";
            // 
            // panel3
            // 
            panel3.Controls.Add(FieldPd_Id);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(FieldPd_Name);
            panel3.Controls.Add(cbFieldProduct);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(296, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 236);
            panel3.TabIndex = 2;
            // 
            // FieldPd_Id
            // 
            FieldPd_Id.Font = new Font("Ebrima", 12F);
            FieldPd_Id.Location = new Point(25, 105);
            FieldPd_Id.Margin = new Padding(3, 2, 3, 2);
            FieldPd_Id.Name = "FieldPd_Id";
            FieldPd_Id.ReadOnly = true;
            FieldPd_Id.Size = new Size(226, 29);
            FieldPd_Id.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 12F);
            label6.Location = new Point(25, 82);
            label6.Name = "label6";
            label6.Size = new Size(142, 21);
            label6.TabIndex = 8;
            label6.Text = "Código do Produto";
            // 
            // FieldPd_Name
            // 
            FieldPd_Name.Font = new Font("Ebrima", 12F);
            FieldPd_Name.Location = new Point(25, 157);
            FieldPd_Name.Margin = new Padding(3, 2, 3, 2);
            FieldPd_Name.Name = "FieldPd_Name";
            FieldPd_Name.ReadOnly = true;
            FieldPd_Name.Size = new Size(226, 29);
            FieldPd_Name.TabIndex = 4;
            // 
            // cbFieldProduct
            // 
            cbFieldProduct.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFieldProduct.FormattingEnabled = true;
            cbFieldProduct.Location = new Point(25, 52);
            cbFieldProduct.Margin = new Padding(3, 2, 3, 2);
            cbFieldProduct.Name = "cbFieldProduct";
            cbFieldProduct.Size = new Size(228, 29);
            cbFieldProduct.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 12F);
            label5.Location = new Point(25, 29);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 3;
            label5.Text = "Produto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12F);
            label4.Location = new Point(25, 134);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 3;
            label4.Text = "Nome";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDetailCancel);
            panel5.Controls.Add(btnDetailSave);
            panel5.Location = new Point(3, 255);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 44);
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
            // StockView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 549);
            Controls.Add(tabStockEdit);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockView";
            Text = "StockView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabStockEdit.ResumeLayout(false);
            tabStockList.ResumeLayout(false);
            tabStockList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStockList).EndInit();
            tabStockRegEdit.ResumeLayout(false);
            tabStockRegEdit.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabStockEdit;
        private TabPage tabStockList;
        private TabPage tabStockRegEdit;
        private Label label1;
        private DataGridView dataGridStockList;
        private TextBox txtSearchPd;
        private Label label2;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnSearch;
        private Label tabPdDetailTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox FieldPd_Name;
        private Label label4;
        private TextBox txtFieldId;
        private Label label3;
        private Panel panel3;
        private ComboBox cbFieldProduct;
        private Label label5;
        private Panel panel5;
        private Button btnDetailCancel;
        private Button btnDetailSave;
        private TextBox txtFieldEntryDate;
        private TextBox txtFieldQuantity;
        private Label label8;
        private Label label7;
        private TextBox FieldPd_Id;
        private Label label6;
        private Label label9;
        private Button btnFilter;
        private TextBox txtFieldExpiryDate;
        private Label label10;
        private ComboBox cbFieldTypeUnit;
        private Label label11;
        private Button btnResetList;
    }
}