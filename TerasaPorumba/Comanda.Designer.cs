namespace TerasaPorumba
{
    partial class ComandaButton
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
            this.cantiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.adaugalaComandaButton = new System.Windows.Forms.Button();
            this.costTotalLabel = new System.Windows.Forms.Label();
            this.istoricComandaLabel = new System.Windows.Forms.Label();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.ComandaData1 = new System.Windows.Forms.DataGridView();
            this.stergeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComandaData1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantiTextBox
            // 
            this.cantiTextBox.Location = new System.Drawing.Point(182, 173);
            this.cantiTextBox.Multiline = true;
            this.cantiTextBox.Name = "cantiTextBox";
            this.cantiTextBox.Size = new System.Drawing.Size(245, 88);
            this.cantiTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "cantitatea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "X  id produs";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(618, 173);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(250, 91);
            this.idTextBox.TabIndex = 3;
            // 
            // adaugalaComandaButton
            // 
            this.adaugalaComandaButton.Location = new System.Drawing.Point(963, 173);
            this.adaugalaComandaButton.Name = "adaugalaComandaButton";
            this.adaugalaComandaButton.Size = new System.Drawing.Size(188, 108);
            this.adaugalaComandaButton.TabIndex = 4;
            this.adaugalaComandaButton.Text = "ADAUGA PE COMANDA";
            this.adaugalaComandaButton.UseVisualStyleBackColor = true;
            this.adaugalaComandaButton.Click += new System.EventHandler(this.adaugalaComandaButton_Click);
            // 
            // costTotalLabel
            // 
            this.costTotalLabel.AutoSize = true;
            this.costTotalLabel.Location = new System.Drawing.Point(530, 335);
            this.costTotalLabel.Name = "costTotalLabel";
            this.costTotalLabel.Size = new System.Drawing.Size(34, 41);
            this.costTotalLabel.TabIndex = 5;
            this.costTotalLabel.Text = "0";
            // 
            // istoricComandaLabel
            // 
            this.istoricComandaLabel.AutoSize = true;
            this.istoricComandaLabel.Location = new System.Drawing.Point(84, 347);
            this.istoricComandaLabel.Name = "istoricComandaLabel";
            this.istoricComandaLabel.Size = new System.Drawing.Size(98, 41);
            this.istoricComandaLabel.TabIndex = 6;
            this.istoricComandaLabel.Text = "Istoric";
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Location = new System.Drawing.Point(1207, 207);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(188, 58);
            this.finishOrderButton.TabIndex = 8;
            this.finishOrderButton.Text = "FinalizeazaComanda";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // ComandaData1
            // 
            this.ComandaData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComandaData1.Location = new System.Drawing.Point(806, 505);
            this.ComandaData1.Name = "ComandaData1";
            this.ComandaData1.RowHeadersWidth = 102;
            this.ComandaData1.RowTemplate.Height = 49;
            this.ComandaData1.Size = new System.Drawing.Size(976, 375);
            this.ComandaData1.TabIndex = 9;
            // 
            // stergeButton
            // 
            this.stergeButton.Location = new System.Drawing.Point(986, 323);
            this.stergeButton.Name = "stergeButton";
            this.stergeButton.Size = new System.Drawing.Size(188, 58);
            this.stergeButton.TabIndex = 10;
            this.stergeButton.Text = "StergeDinComanda";
            this.stergeButton.UseVisualStyleBackColor = true;
            this.stergeButton.Click += new System.EventHandler(this.stergeButton_Click);
            // 
            // ComandaButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 934);
            this.Controls.Add(this.stergeButton);
            this.Controls.Add(this.ComandaData1);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.istoricComandaLabel);
            this.Controls.Add(this.costTotalLabel);
            this.Controls.Add(this.adaugalaComandaButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantiTextBox);
            this.Name = "ComandaButton";
            ((System.ComponentModel.ISupportInitialize)(this.ComandaData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cantiTextBox;
        private Label label1;
        private Label label2;
        private TextBox idTextBox;
        private Button adaugalaComandaButton;
        private Label costTotalLabel;
        private Label istoricComandaLabel;
        private Button finishOrderButton;
        private DataGridView ComandaData1;
        private Button stergeButton;
    }
}