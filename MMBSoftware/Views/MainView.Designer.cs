
namespace MMBSoftware
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            sbBtnLeave = new Button();
            sbBtnClients = new Button();
            sbBtnProduct = new Button();
            sbBtnStock = new Button();
            sbBtnHome = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(82, 21);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 255, 255);
            panel2.Controls.Add(sbBtnLeave);
            panel2.Controls.Add(sbBtnClients);
            panel2.Controls.Add(sbBtnProduct);
            panel2.Controls.Add(sbBtnStock);
            panel2.Controls.Add(sbBtnHome);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 567);
            panel2.TabIndex = 2;
            // 
            // sbBtnLeave
            // 
            sbBtnLeave.Cursor = Cursors.Hand;
            sbBtnLeave.Dock = DockStyle.Bottom;
            sbBtnLeave.FlatStyle = FlatStyle.Flat;
            sbBtnLeave.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbBtnLeave.Image = (Image)resources.GetObject("sbBtnLeave.Image");
            sbBtnLeave.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnLeave.Location = new Point(0, 514);
            sbBtnLeave.Name = "sbBtnLeave";
            sbBtnLeave.Size = new Size(190, 53);
            sbBtnLeave.TabIndex = 17;
            sbBtnLeave.Text = "Sair";
            sbBtnLeave.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnLeave.UseVisualStyleBackColor = true;
            // 
            // sbBtnClients
            // 
            sbBtnClients.Cursor = Cursors.Hand;
            sbBtnClients.Dock = DockStyle.Top;
            sbBtnClients.FlatStyle = FlatStyle.Flat;
            sbBtnClients.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbBtnClients.Image = (Image)resources.GetObject("sbBtnClients.Image");
            sbBtnClients.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnClients.Location = new Point(0, 284);
            sbBtnClients.Name = "sbBtnClients";
            sbBtnClients.Size = new Size(190, 53);
            sbBtnClients.TabIndex = 16;
            sbBtnClients.Text = "Clients";
            sbBtnClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnClients.UseVisualStyleBackColor = true;
            // 
            // sbBtnProduct
            // 
            sbBtnProduct.Cursor = Cursors.Hand;
            sbBtnProduct.Dock = DockStyle.Top;
            sbBtnProduct.FlatStyle = FlatStyle.Flat;
            sbBtnProduct.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbBtnProduct.Image = (Image)resources.GetObject("sbBtnProduct.Image");
            sbBtnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnProduct.Location = new Point(0, 231);
            sbBtnProduct.Name = "sbBtnProduct";
            sbBtnProduct.Size = new Size(190, 53);
            sbBtnProduct.TabIndex = 15;
            sbBtnProduct.Text = "Products";
            sbBtnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnProduct.UseVisualStyleBackColor = true;
            // 
            // sbBtnStock
            // 
            sbBtnStock.Cursor = Cursors.Hand;
            sbBtnStock.Dock = DockStyle.Top;
            sbBtnStock.FlatStyle = FlatStyle.Flat;
            sbBtnStock.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbBtnStock.Image = (Image)resources.GetObject("sbBtnStock.Image");
            sbBtnStock.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnStock.Location = new Point(0, 178);
            sbBtnStock.Name = "sbBtnStock";
            sbBtnStock.Size = new Size(190, 53);
            sbBtnStock.TabIndex = 14;
            sbBtnStock.Text = "Stock";
            sbBtnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnStock.UseVisualStyleBackColor = true;
            // 
            // sbBtnHome
            // 
            sbBtnHome.Cursor = Cursors.Hand;
            sbBtnHome.Dock = DockStyle.Top;
            sbBtnHome.FlatStyle = FlatStyle.Flat;
            sbBtnHome.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbBtnHome.Image = (Image)resources.GetObject("sbBtnHome.Image");
            sbBtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnHome.Location = new Point(0, 125);
            sbBtnHome.Name = "sbBtnHome";
            sbBtnHome.Size = new Size(190, 53);
            sbBtnHome.TabIndex = 13;
            sbBtnHome.Text = "Home";
            sbBtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 125);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 68);
            label2.Name = "label2";
            label2.Size = new Size(123, 35);
            label2.TabIndex = 3;
            label2.Text = "Text Here";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 639);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MMB Software";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button sbBtnHome;
        private Button sbBtnClients;
        private Button sbBtnProduct;
        private Button sbBtnStock;
        private Button sbBtnLeave;
    }
}
