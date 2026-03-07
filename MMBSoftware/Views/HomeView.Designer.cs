namespace MMBSoftware.Views
{
    partial class HomeView
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(457, 25);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 0;
            label1.Text = "Olá User";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 87);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(150, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 597);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16F, FontStyle.Bold);
            label5.Location = new Point(340, 366);
            label5.Name = "label5";
            label5.Size = new Size(195, 33);
            label5.TabIndex = 4;
            label5.Text = "Painel de Avisos";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Location = new Point(608, 445);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 141);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 12);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 2;
            label4.Text = "Avisos de Esstoque";
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Location = new Point(315, 445);
            panel6.Name = "panel6";
            panel6.Size = new Size(258, 141);
            panel6.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 12);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Avisos de Contas";
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(20, 445);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 141);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 12);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Boletos Atrasados";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 597);
            panel3.TabIndex = 0;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeView";
            Text = "HomeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}