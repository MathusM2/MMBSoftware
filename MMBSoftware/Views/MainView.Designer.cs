
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
            label3 = new Label();
            btnUser = new Button();
            btnSidebar = new Button();
            label1 = new Label();
            sideBarPanel = new Panel();
            sbBtnLeave = new Button();
            sbBtnClients = new Button();
            sbBtnProduct = new Button();
            sbBtnStock = new Button();
            sbBtnHome = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            sideBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 235, 108);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnSidebar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 72);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label3.Location = new Point(748, 23);
            label3.Name = "label3";
            label3.Size = new Size(248, 35);
            label3.TabIndex = 4;
            label3.Text = "Mini Mercado Brasil";
            // 
            // btnUser
            // 
            btnUser.Cursor = Cursors.Hand;
            btnUser.Dock = DockStyle.Right;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.Location = new Point(1033, 0);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(66, 72);
            btnUser.TabIndex = 19;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnSidebar
            // 
            btnSidebar.Cursor = Cursors.Hand;
            btnSidebar.FlatAppearance.BorderSize = 0;
            btnSidebar.FlatStyle = FlatStyle.Flat;
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.Location = new Point(12, 20);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(40, 37);
            btnSidebar.TabIndex = 18;
            btnSidebar.UseVisualStyleBackColor = true;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(6, 0, 19);
            label1.Location = new Point(58, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.FromArgb(202, 255, 202);
            sideBarPanel.Controls.Add(sbBtnLeave);
            sideBarPanel.Controls.Add(sbBtnClients);
            sideBarPanel.Controls.Add(sbBtnProduct);
            sideBarPanel.Controls.Add(sbBtnStock);
            sideBarPanel.Controls.Add(sbBtnHome);
            sideBarPanel.Controls.Add(panel3);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Location = new Point(0, 72);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(190, 567);
            sideBarPanel.TabIndex = 2;
            // 
            // sbBtnLeave
            // 
            sbBtnLeave.BackColor = Color.FromArgb(202, 255, 202);
            sbBtnLeave.Cursor = Cursors.Hand;
            sbBtnLeave.Dock = DockStyle.Bottom;
            sbBtnLeave.FlatAppearance.BorderSize = 0;
            sbBtnLeave.FlatStyle = FlatStyle.Flat;
            sbBtnLeave.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbBtnLeave.ForeColor = Color.FromArgb(6, 0, 19);
            sbBtnLeave.Image = (Image)resources.GetObject("sbBtnLeave.Image");
            sbBtnLeave.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnLeave.Location = new Point(0, 514);
            sbBtnLeave.Name = "sbBtnLeave";
            sbBtnLeave.Size = new Size(190, 53);
            sbBtnLeave.TabIndex = 17;
            sbBtnLeave.Text = "Sair";
            sbBtnLeave.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnLeave.UseVisualStyleBackColor = false;
            // 
            // sbBtnClients
            // 
            sbBtnClients.Cursor = Cursors.Hand;
            sbBtnClients.Dock = DockStyle.Top;
            sbBtnClients.FlatAppearance.BorderSize = 0;
            sbBtnClients.FlatStyle = FlatStyle.Flat;
            sbBtnClients.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbBtnClients.ForeColor = Color.FromArgb(6, 0, 19);
            sbBtnClients.Image = (Image)resources.GetObject("sbBtnClients.Image");
            sbBtnClients.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnClients.Location = new Point(0, 244);
            sbBtnClients.Name = "sbBtnClients";
            sbBtnClients.Size = new Size(190, 53);
            sbBtnClients.TabIndex = 16;
            sbBtnClients.Text = "Clientes";
            sbBtnClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnClients.UseVisualStyleBackColor = true;
            // 
            // sbBtnProduct
            // 
            sbBtnProduct.Cursor = Cursors.Hand;
            sbBtnProduct.Dock = DockStyle.Top;
            sbBtnProduct.FlatAppearance.BorderSize = 0;
            sbBtnProduct.FlatStyle = FlatStyle.Flat;
            sbBtnProduct.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbBtnProduct.ForeColor = Color.FromArgb(6, 0, 19);
            sbBtnProduct.Image = (Image)resources.GetObject("sbBtnProduct.Image");
            sbBtnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnProduct.Location = new Point(0, 191);
            sbBtnProduct.Name = "sbBtnProduct";
            sbBtnProduct.Size = new Size(190, 53);
            sbBtnProduct.TabIndex = 15;
            sbBtnProduct.Text = "Produtos";
            sbBtnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnProduct.UseVisualStyleBackColor = true;
            // 
            // sbBtnStock
            // 
            sbBtnStock.Cursor = Cursors.Hand;
            sbBtnStock.Dock = DockStyle.Top;
            sbBtnStock.FlatAppearance.BorderColor = SystemColors.Control;
            sbBtnStock.FlatAppearance.BorderSize = 0;
            sbBtnStock.FlatStyle = FlatStyle.Flat;
            sbBtnStock.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbBtnStock.ForeColor = Color.FromArgb(6, 0, 19);
            sbBtnStock.Image = (Image)resources.GetObject("sbBtnStock.Image");
            sbBtnStock.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnStock.Location = new Point(0, 138);
            sbBtnStock.Name = "sbBtnStock";
            sbBtnStock.Size = new Size(190, 53);
            sbBtnStock.TabIndex = 14;
            sbBtnStock.Text = "Estoque";
            sbBtnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnStock.UseVisualStyleBackColor = true;
            // 
            // sbBtnHome
            // 
            sbBtnHome.Cursor = Cursors.Hand;
            sbBtnHome.Dock = DockStyle.Top;
            sbBtnHome.FlatAppearance.BorderColor = SystemColors.Control;
            sbBtnHome.FlatAppearance.BorderSize = 0;
            sbBtnHome.FlatStyle = FlatStyle.Flat;
            sbBtnHome.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sbBtnHome.ForeColor = Color.FromArgb(6, 0, 19);
            sbBtnHome.Image = (Image)resources.GetObject("sbBtnHome.Image");
            sbBtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            sbBtnHome.Location = new Point(0, 85);
            sbBtnHome.Name = "sbBtnHome";
            sbBtnHome.Size = new Size(190, 53);
            sbBtnHome.TabIndex = 13;
            sbBtnHome.Text = "Home";
            sbBtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            sbBtnHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 85);
            panel3.TabIndex = 1;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 639);
            Controls.Add(sideBarPanel);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MMB Software";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sideBarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel sideBarPanel;
        private Panel panel3;
        private Button sbBtnHome;
        private Button sbBtnClients;
        private Button sbBtnProduct;
        private Button sbBtnStock;
        private Button sbBtnLeave;
        private Button btnSidebar;
        private Button btnUser;
        private Label label3;
    }
}
