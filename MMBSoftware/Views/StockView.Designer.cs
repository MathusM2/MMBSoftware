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
            tabControl1 = new TabControl();
            tabStockList = new TabPage();
            btnSearch = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label2 = new Label();
            txtSearchPd = new TextBox();
            dataGridStockList = new DataGridView();
            tabStockProduct = new TabPage();
            tabPdDetailTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            txtFieldDate = new TextBox();
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
            tabControl1.SuspendLayout();
            tabStockList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStockList).BeginInit();
            tabStockProduct.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 1;
            label1.Text = "ESTOQUE";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStockList);
            tabControl1.Controls.Add(tabStockProduct);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1029, 579);
            tabControl1.TabIndex = 1;
            // 
            // tabStockList
            // 
            tabStockList.BackColor = Color.WhiteSmoke;
            tabStockList.Controls.Add(btnSearch);
            tabStockList.Controls.Add(btnDel);
            tabStockList.Controls.Add(btnEdit);
            tabStockList.Controls.Add(btnAdd);
            tabStockList.Controls.Add(label2);
            tabStockList.Controls.Add(txtSearchPd);
            tabStockList.Controls.Add(dataGridStockList);
            tabStockList.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabStockList.Location = new Point(4, 33);
            tabStockList.Name = "tabStockList";
            tabStockList.Padding = new Padding(3);
            tabStockList.Size = new Size(1021, 542);
            tabStockList.TabIndex = 0;
            tabStockList.Text = "Lista do Estoque";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Calibri", 12F);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.ImageAlign = ContentAlignment.BottomCenter;
            btnSearch.Location = new Point(712, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 36);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel.BackColor = Color.Transparent;
            btnDel.Font = new Font("Calibri", 12F);
            btnDel.ForeColor = SystemColors.ControlText;
            btnDel.ImageAlign = ContentAlignment.BottomCenter;
            btnDel.Location = new Point(842, 189);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(141, 36);
            btnDel.TabIndex = 11;
            btnDel.Text = "Deletar";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Font = new Font("Calibri", 12F);
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.ImageAlign = ContentAlignment.BottomCenter;
            btnEdit.Location = new Point(842, 147);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 36);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Calibri", 12F);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.ImageAlign = ContentAlignment.BottomCenter;
            btnAdd.Location = new Point(842, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 36);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(197, 28);
            label2.TabIndex = 5;
            label2.Text = "Pesquisar no estoque";
            // 
            // txtSearchPd
            // 
            txtSearchPd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchPd.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPd.Location = new Point(18, 60);
            txtSearchPd.Name = "txtSearchPd";
            txtSearchPd.Size = new Size(688, 35);
            txtSearchPd.TabIndex = 3;
            // 
            // dataGridStockList
            // 
            dataGridStockList.AllowUserToAddRows = false;
            dataGridStockList.AllowUserToDeleteRows = false;
            dataGridStockList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridStockList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridStockList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStockList.Location = new Point(18, 105);
            dataGridStockList.Name = "dataGridStockList";
            dataGridStockList.RowHeadersWidth = 51;
            dataGridStockList.Size = new Size(818, 421);
            dataGridStockList.TabIndex = 2;
            // 
            // tabStockProduct
            // 
            tabStockProduct.Controls.Add(tabPdDetailTitle);
            tabStockProduct.Controls.Add(flowLayoutPanel1);
            tabStockProduct.Location = new Point(4, 33);
            tabStockProduct.Name = "tabStockProduct";
            tabStockProduct.Padding = new Padding(3);
            tabStockProduct.Size = new Size(1089, 542);
            tabStockProduct.TabIndex = 1;
            tabStockProduct.Text = "Produto em estoque";
            tabStockProduct.UseVisualStyleBackColor = true;
            // 
            // tabPdDetailTitle
            // 
            tabPdDetailTitle.AutoSize = true;
            tabPdDetailTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPdDetailTitle.Location = new Point(34, 15);
            tabPdDetailTitle.Name = "tabPdDetailTitle";
            tabPdDetailTitle.Size = new Size(135, 37);
            tabPdDetailTitle.TabIndex = 3;
            tabPdDetailTitle.Text = "Title here";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(8, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(613, 433);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtFieldDate);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtFieldQuantity);
            panel2.Controls.Add(txtFieldId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 314);
            panel2.TabIndex = 1;
            // 
            // txtFieldDate
            // 
            txtFieldDate.Font = new Font("Ebrima", 12F);
            txtFieldDate.Location = new Point(23, 209);
            txtFieldDate.Name = "txtFieldDate";
            txtFieldDate.Size = new Size(152, 35);
            txtFieldDate.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 12F);
            label8.Location = new Point(23, 178);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 5;
            label8.Text = "Data de entrada";
            // 
            // txtFieldQuantity
            // 
            txtFieldQuantity.Font = new Font("Ebrima", 12F);
            txtFieldQuantity.Location = new Point(26, 140);
            txtFieldQuantity.Name = "txtFieldQuantity";
            txtFieldQuantity.Size = new Size(107, 35);
            txtFieldQuantity.TabIndex = 6;
            // 
            // txtFieldId
            // 
            txtFieldId.Font = new Font("Ebrima", 12F);
            txtFieldId.Location = new Point(26, 71);
            txtFieldId.Name = "txtFieldId";
            txtFieldId.ReadOnly = true;
            txtFieldId.Size = new Size(125, 35);
            txtFieldId.TabIndex = 2;
            txtFieldId.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 12F);
            label7.Location = new Point(23, 109);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 4;
            label7.Text = "Quantidade";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 12F);
            label3.Location = new Point(23, 40);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 1;
            label3.Text = "ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(FieldPd_Id);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(FieldPd_Name);
            panel3.Controls.Add(cbFieldProduct);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(308, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 314);
            panel3.TabIndex = 2;
            // 
            // FieldPd_Id
            // 
            FieldPd_Id.Font = new Font("Ebrima", 12F);
            FieldPd_Id.Location = new Point(29, 140);
            FieldPd_Id.Name = "FieldPd_Id";
            FieldPd_Id.ReadOnly = true;
            FieldPd_Id.Size = new Size(258, 35);
            FieldPd_Id.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 12F);
            label6.Location = new Point(29, 109);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 8;
            label6.Text = "Produto ID";
            // 
            // FieldPd_Name
            // 
            FieldPd_Name.Font = new Font("Ebrima", 12F);
            FieldPd_Name.Location = new Point(29, 209);
            FieldPd_Name.Name = "FieldPd_Name";
            FieldPd_Name.ReadOnly = true;
            FieldPd_Name.Size = new Size(258, 35);
            FieldPd_Name.TabIndex = 4;
            // 
            // cbFieldProduct
            // 
            cbFieldProduct.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFieldProduct.FormattingEnabled = true;
            cbFieldProduct.Location = new Point(29, 70);
            cbFieldProduct.Name = "cbFieldProduct";
            cbFieldProduct.Size = new Size(260, 36);
            cbFieldProduct.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 12F);
            label5.Location = new Point(29, 40);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 3;
            label5.Text = "Produto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12F);
            label4.Location = new Point(29, 178);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 3;
            label4.Text = "Nome";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDetailCancel);
            panel5.Controls.Add(btnDetailSave);
            panel5.Location = new Point(3, 323);
            panel5.Name = "panel5";
            panel5.Size = new Size(599, 59);
            panel5.TabIndex = 2;
            // 
            // btnDetailCancel
            // 
            btnDetailCancel.Font = new Font("Ebrima", 12F);
            btnDetailCancel.Location = new Point(244, 17);
            btnDetailCancel.Name = "btnDetailCancel";
            btnDetailCancel.Size = new Size(192, 39);
            btnDetailCancel.TabIndex = 2;
            btnDetailCancel.Text = "Cancelar";
            btnDetailCancel.UseVisualStyleBackColor = true;
            // 
            // btnDetailSave
            // 
            btnDetailSave.Font = new Font("Ebrima", 12F);
            btnDetailSave.Location = new Point(23, 17);
            btnDetailSave.Name = "btnDetailSave";
            btnDetailSave.Size = new Size(192, 39);
            btnDetailSave.TabIndex = 1;
            btnDetailSave.Text = "Salvar";
            btnDetailSave.UseVisualStyleBackColor = true;
            // 
            // StockView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 676);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "StockView";
            Text = "StockView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabStockList.ResumeLayout(false);
            tabStockList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStockList).EndInit();
            tabStockProduct.ResumeLayout(false);
            tabStockProduct.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabStockList;
        private TabPage tabStockProduct;
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
        private TextBox txtFieldDate;
        private TextBox txtFieldQuantity;
        private Label label8;
        private Label label7;
        private TextBox FieldPd_Id;
        private Label label6;
    }
}