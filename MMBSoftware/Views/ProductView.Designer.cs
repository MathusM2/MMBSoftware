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
            txtFieldPrice = new TextBox();
            label6 = new Label();
            txtFieldCategory = new TextBox();
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
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
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
            tabControl1.Location = new Point(0, 89);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1029, 601);
            tabControl1.TabIndex = 1;
            // 
            // tabListPd
            // 
            tabListPd.BackColor = Color.WhiteSmoke;
            tabListPd.Controls.Add(btnDel);
            tabListPd.Controls.Add(btnEdit);
            tabListPd.Controls.Add(btnAdd);
            tabListPd.Controls.Add(btnSearch);
            tabListPd.Controls.Add(label2);
            tabListPd.Controls.Add(txtSearchPd);
            tabListPd.Controls.Add(dataGridViewProducts);
            tabListPd.Location = new Point(4, 33);
            tabListPd.Name = "tabListPd";
            tabListPd.Padding = new Padding(3);
            tabListPd.Size = new Size(1021, 564);
            tabListPd.TabIndex = 0;
            tabListPd.Text = "Lista de Produtos";
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel.BackColor = Color.Transparent;
            btnDel.Font = new Font("Calibri", 12F);
            btnDel.ForeColor = SystemColors.ControlText;
            btnDel.ImageAlign = ContentAlignment.BottomCenter;
            btnDel.Location = new Point(861, 194);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(141, 36);
            btnDel.TabIndex = 6;
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
            btnEdit.Location = new Point(861, 152);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 36);
            btnEdit.TabIndex = 5;
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
            btnAdd.Location = new Point(861, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 36);
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
            btnSearch.Location = new Point(731, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Pesquisar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 27);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar Produtos";
            // 
            // txtSearchPd
            // 
            txtSearchPd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchPd.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPd.Location = new Point(19, 58);
            txtSearchPd.Name = "txtSearchPd";
            txtSearchPd.Size = new Size(706, 35);
            txtSearchPd.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(19, 110);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(836, 433);
            dataGridViewProducts.TabIndex = 0;
            // 
            // tabDetailPd
            // 
            tabDetailPd.Controls.Add(tabPdDetailTitle);
            tabDetailPd.Controls.Add(flowLayoutPanel1);
            tabDetailPd.Location = new Point(4, 33);
            tabDetailPd.Name = "tabDetailPd";
            tabDetailPd.Padding = new Padding(3);
            tabDetailPd.Size = new Size(1021, 564);
            tabDetailPd.TabIndex = 1;
            tabDetailPd.Text = "Detalhes do Produto";
            tabDetailPd.UseVisualStyleBackColor = true;
            // 
            // tabPdDetailTitle
            // 
            tabPdDetailTitle.AutoSize = true;
            tabPdDetailTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPdDetailTitle.Location = new Point(26, 12);
            tabPdDetailTitle.Name = "tabPdDetailTitle";
            tabPdDetailTitle.Size = new Size(135, 37);
            tabPdDetailTitle.TabIndex = 1;
            tabPdDetailTitle.Text = "Title here";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(0, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(613, 454);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtFieldName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtFieldId);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 201);
            panel2.TabIndex = 1;
            // 
            // txtFieldName
            // 
            txtFieldName.Font = new Font("Ebrima", 12F);
            txtFieldName.Location = new Point(26, 142);
            txtFieldName.Name = "txtFieldName";
            txtFieldName.Size = new Size(258, 35);
            txtFieldName.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12F);
            label4.Location = new Point(26, 111);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 3;
            label4.Text = "Nome";
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
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 12F);
            label3.Location = new Point(23, 40);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 1;
            label3.Text = "Produto ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtFieldPrice);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtFieldCategory);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(308, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 201);
            panel3.TabIndex = 2;
            // 
            // txtFieldPrice
            // 
            txtFieldPrice.Font = new Font("Ebrima", 12F);
            txtFieldPrice.Location = new Point(19, 71);
            txtFieldPrice.Name = "txtFieldPrice";
            txtFieldPrice.Size = new Size(125, 35);
            txtFieldPrice.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 12F);
            label6.Location = new Point(19, 40);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 5;
            label6.Text = "Preço";
            // 
            // txtFieldCategory
            // 
            txtFieldCategory.Font = new Font("Ebrima", 12F);
            txtFieldCategory.Location = new Point(19, 142);
            txtFieldCategory.Name = "txtFieldCategory";
            txtFieldCategory.Size = new Size(260, 35);
            txtFieldCategory.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 12F);
            label5.Location = new Point(19, 111);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 3;
            label5.Text = "Categoria";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtFieldDescription);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(3, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(599, 148);
            panel4.TabIndex = 3;
            // 
            // txtFieldDescription
            // 
            txtFieldDescription.Font = new Font("Ebrima", 12F);
            txtFieldDescription.Location = new Point(26, 32);
            txtFieldDescription.Multiline = true;
            txtFieldDescription.Name = "txtFieldDescription";
            txtFieldDescription.Size = new Size(558, 102);
            txtFieldDescription.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 12F);
            label7.Location = new Point(26, 1);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 7;
            label7.Text = "Descrição";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDetailCancel);
            panel5.Controls.Add(btnDetailSave);
            panel5.Location = new Point(3, 364);
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
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
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
        private TextBox txtFieldCategory;
        private Label label5;
        private Panel panel4;
        private TextBox txtFieldDescription;
        private Label label7;
        private Panel panel5;
        private Button btnDetailCancel;
        private Button btnDetailSave;
        private Label tabPdDetailTitle;
    }
}