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
            this.components = new System.ComponentModel.Container();
            this.readButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.adaugamargaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(1790, 86);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(188, 210);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "COMANDA Client";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1851, 1038);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "NOUA ZI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1887, 957);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1249, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(342, 166);
            this.button3.TabIndex = 6;
            this.button3.Text = "Adauga produs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 1098);
            this.dataGridView1.TabIndex = 7;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "produse";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1249, 408);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(350, 163);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Sterge Produs";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // adaugamargaButton
            // 
            this.adaugamargaButton.Location = new System.Drawing.Point(1249, 232);
            this.adaugamargaButton.Name = "adaugamargaButton";
            this.adaugamargaButton.Size = new System.Drawing.Size(342, 160);
            this.adaugamargaButton.TabIndex = 10;
            this.adaugamargaButton.Text = "AdaugaMarfa";
            this.adaugamargaButton.UseVisualStyleBackColor = true;
            this.adaugamargaButton.Click += new System.EventHandler(this.adaugamargaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2131, 1192);
            this.Controls.Add(this.adaugamargaButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Meniu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button readButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn denumireProdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private BindingSource produseBindingSource;
        private Button deleteButton;
        private Button adaugamargaButton;
    }
}