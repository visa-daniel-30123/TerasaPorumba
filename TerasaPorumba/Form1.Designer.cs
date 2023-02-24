namespace TerasaPorumba
{
    partial class Form1
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
            this.readButton = new System.Windows.Forms.Button();
            this.afisLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(868, 395);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(188, 58);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Incarca Meniu";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // afisLabel
            // 
            this.afisLabel.AutoSize = true;
            this.afisLabel.Location = new System.Drawing.Point(406, 171);
            this.afisLabel.Name = "afisLabel";
            this.afisLabel.Size = new System.Drawing.Size(97, 41);
            this.afisLabel.TabIndex = 1;
            this.afisLabel.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(186, 296);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(300, 224);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 817);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.afisLabel);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button readButton;
        private Label afisLabel;
        private CheckedListBox checkedListBox1;
    }
}