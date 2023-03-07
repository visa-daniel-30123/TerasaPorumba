namespace TerasaPorumba
{
    partial class StergeProdus
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
            this.deleteProdButton = new System.Windows.Forms.Button();
            this.idIdentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteProdButton
            // 
            this.deleteProdButton.Location = new System.Drawing.Point(429, 173);
            this.deleteProdButton.Name = "deleteProdButton";
            this.deleteProdButton.Size = new System.Drawing.Size(188, 58);
            this.deleteProdButton.TabIndex = 0;
            this.deleteProdButton.Text = "Sterge";
            this.deleteProdButton.UseVisualStyleBackColor = true;
            this.deleteProdButton.Click += new System.EventHandler(this.deleteProdButton_Click);
            // 
            // idIdentTextBox
            // 
            this.idIdentTextBox.Location = new System.Drawing.Point(137, 166);
            this.idIdentTextBox.Multiline = true;
            this.idIdentTextBox.Name = "idIdentTextBox";
            this.idIdentTextBox.Size = new System.Drawing.Size(250, 65);
            this.idIdentTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti id ul produsului pe care doriti sa-l stergeti";
            // 
            // StergeProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idIdentTextBox);
            this.Controls.Add(this.deleteProdButton);
            this.Name = "StergeProdus";
            this.Text = "StergeProdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteProdButton;
        private TextBox idIdentTextBox;
        private Label label1;
    }
}