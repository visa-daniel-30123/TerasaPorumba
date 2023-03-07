namespace TerasaPorumba
{
    partial class AdaugaProdus
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.ncantitateUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ncantitateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(273, 70);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(380, 70);
            this.idTextBox.TabIndex = 0;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(273, 150);
            this.denumireTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(380, 70);
            this.denumireTextBox.TabIndex = 1;
            // 
            // pretTextBox
            // 
            this.pretTextBox.Location = new System.Drawing.Point(273, 241);
            this.pretTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(380, 70);
            this.pretTextBox.TabIndex = 2;
            // 
            // ncantitateUpDown
            // 
            this.ncantitateUpDown.Location = new System.Drawing.Point(273, 332);
            this.ncantitateUpDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ncantitateUpDown.Name = "ncantitateUpDown";
            this.ncantitateUpDown.Size = new System.Drawing.Size(181, 70);
            this.ncantitateUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantitate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 87);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdaugaProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 62F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ncantitateUpDown);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(this.idTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdaugaProdus";
            this.Text = "AdaugaProdus";
            ((System.ComponentModel.ISupportInitialize)(this.ncantitateUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idTextBox;
        private TextBox denumireTextBox;
        private TextBox pretTextBox;
        private NumericUpDown ncantitateUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}