namespace MMBSoftware.Views.Dialogs
{
    partial class ProductFilterDialogView
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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 22);
            label2.Name = "label2";
            label2.Size = new Size(98, 41);
            label2.TabIndex = 2;
            label2.Text = "Filtrar";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 385);
            button1.Name = "button1";
            button1.Size = new Size(383, 29);
            button1.TabIndex = 11;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 119);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ordem Alfabética (A-Z)", "Ordem Alfabética (Z-A)", "Por Preço (Maior)", "Por Preço(Menor)", "Por Categoria (A-Z)", "Por Categoria (Z-A)" });
            comboBox1.Location = new Point(38, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 63);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 16;
            label8.Text = "Ordenações";
            // 
            // ProductFilterDialogView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 414);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "ProductFilterDialogView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label8;
    }
}