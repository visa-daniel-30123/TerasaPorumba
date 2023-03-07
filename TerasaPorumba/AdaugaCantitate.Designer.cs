namespace TerasaPorumba
{
    partial class AdaugaCantitate
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
            this.idBoxCantitate = new System.Windows.Forms.TextBox();
            this.cantidCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adaugaCantiButton = new System.Windows.Forms.Button();
            this.scadeCantButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idBoxCantitate
            // 
            this.idBoxCantitate.Location = new System.Drawing.Point(279, 88);
            this.idBoxCantitate.Multiline = true;
            this.idBoxCantitate.Name = "idBoxCantitate";
            this.idBoxCantitate.Size = new System.Drawing.Size(250, 61);
            this.idBoxCantitate.TabIndex = 0;
            // 
            // cantidCantitate
            // 
            this.cantidCantitate.Location = new System.Drawing.Point(279, 196);
            this.cantidCantitate.Multiline = true;
            this.cantidCantitate.Name = "cantidCantitate";
            this.cantidCantitate.Size = new System.Drawing.Size(250, 79);
            this.cantidCantitate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "CANTITATEA";
            // 
            // adaugaCantiButton
            // 
            this.adaugaCantiButton.Location = new System.Drawing.Point(639, 81);
            this.adaugaCantiButton.Name = "adaugaCantiButton";
            this.adaugaCantiButton.Size = new System.Drawing.Size(188, 95);
            this.adaugaCantiButton.TabIndex = 4;
            this.adaugaCantiButton.Text = "ADAUGA";
            this.adaugaCantiButton.UseVisualStyleBackColor = true;
            this.adaugaCantiButton.Click += new System.EventHandler(this.adaugaCantiButton_Click);
            // 
            // scadeCantButton
            // 
            this.scadeCantButton.Location = new System.Drawing.Point(639, 254);
            this.scadeCantButton.Name = "scadeCantButton";
            this.scadeCantButton.Size = new System.Drawing.Size(188, 104);
            this.scadeCantButton.TabIndex = 5;
            this.scadeCantButton.Text = "Scade Produs";
            this.scadeCantButton.UseVisualStyleBackColor = true;
            this.scadeCantButton.Click += new System.EventHandler(this.scadeCantButton_Click);
            // 
            // AdaugaCantitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 487);
            this.Controls.Add(this.scadeCantButton);
            this.Controls.Add(this.adaugaCantiButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidCantitate);
            this.Controls.Add(this.idBoxCantitate);
            this.Name = "AdaugaCantitate";
            this.Text = "AdaugaCantitate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idBoxCantitate;
        private TextBox cantidCantitate;
        private Label label1;
        private Label label2;
        private Button adaugaCantiButton;
        private Button scadeCantButton;
    }
}