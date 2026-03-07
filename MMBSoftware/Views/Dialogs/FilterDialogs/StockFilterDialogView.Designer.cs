namespace MMBSoftware.Views.Dialogs
{
    partial class StockFilterDialogView
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
            label4 = new Label();
            clbFilterSituation = new CheckedListBox();
            btnConfirm = new Button();
            label1 = new Label();
            clbFilterExpiration = new CheckedListBox();
            label3 = new Label();
            clbFilterUnitType = new CheckedListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 11);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 2;
            label2.Text = "Filtrar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 56);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Situação";
            // 
            // clbFilterSituation
            // 
            clbFilterSituation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbFilterSituation.CheckOnClick = true;
            clbFilterSituation.FormattingEnabled = true;
            clbFilterSituation.HorizontalExtent = 1;
            clbFilterSituation.Items.AddRange(new object[] { "Estocado", "Sem Estoque" });
            clbFilterSituation.Location = new Point(25, 74);
            clbFilterSituation.Margin = new Padding(3, 2, 3, 2);
            clbFilterSituation.MultiColumn = true;
            clbFilterSituation.Name = "clbFilterSituation";
            clbFilterSituation.Size = new Size(270, 22);
            clbFilterSituation.TabIndex = 6;
            clbFilterSituation.ItemCheck += clbFilterSituation_ItemCheck;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Bottom;
            btnConfirm.Location = new Point(0, 253);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(335, 22);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 103);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 12;
            label1.Text = "Vencimento";
            // 
            // clbFilterExpiration
            // 
            clbFilterExpiration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbFilterExpiration.CheckOnClick = true;
            clbFilterExpiration.FormattingEnabled = true;
            clbFilterExpiration.HorizontalExtent = 1;
            clbFilterExpiration.Items.AddRange(new object[] { "Vencido", "A Vencer" });
            clbFilterExpiration.Location = new Point(25, 120);
            clbFilterExpiration.Margin = new Padding(3, 2, 3, 2);
            clbFilterExpiration.MultiColumn = true;
            clbFilterExpiration.Name = "clbFilterExpiration";
            clbFilterExpiration.Size = new Size(270, 22);
            clbFilterExpiration.TabIndex = 13;
            clbFilterExpiration.ItemCheck += clbFilterExpiration_ItemCheck;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo de Unidade";
            // 
            // clbFilterUnitType
            // 
            clbFilterUnitType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clbFilterUnitType.CheckOnClick = true;
            clbFilterUnitType.FormattingEnabled = true;
            clbFilterUnitType.HorizontalExtent = 1;
            clbFilterUnitType.Items.AddRange(new object[] { "Caixa", "Pacote", "Unidade" });
            clbFilterUnitType.Location = new Point(25, 166);
            clbFilterUnitType.Margin = new Padding(3, 2, 3, 2);
            clbFilterUnitType.MultiColumn = true;
            clbFilterUnitType.Name = "clbFilterUnitType";
            clbFilterUnitType.Size = new Size(108, 76);
            clbFilterUnitType.TabIndex = 16;
            clbFilterUnitType.ItemCheck += clbFilterUnitType_ItemCheck;
            // 
            // StockFilterDialogView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 275);
            Controls.Add(clbFilterUnitType);
            Controls.Add(label3);
            Controls.Add(clbFilterExpiration);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(clbFilterSituation);
            Controls.Add(label4);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockFilterDialogView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private CheckedListBox clbFilterSituation;
        private Button btnConfirm;
        private Label label1;
        private CheckedListBox clbFilterExpiration;
        private Label label3;
        private CheckedListBox clbFilterUnitType;
    }
}