namespace KaracsonyfaRendeles
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.megse = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // megse
            // 
            this.megse.BackColor = System.Drawing.SystemColors.WindowText;
            this.megse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megse.ForeColor = System.Drawing.Color.White;
            this.megse.Location = new System.Drawing.Point(615, 270);
            this.megse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.megse.Name = "megse";
            this.megse.Size = new System.Drawing.Size(113, 50);
            this.megse.TabIndex = 40;
            this.megse.Text = "Mégse";
            this.megse.UseVisualStyleBackColor = false;
            this.megse.Click += new System.EventHandler(this.megse_Click);
            // 
            // torles
            // 
            this.torles.BackColor = System.Drawing.SystemColors.WindowText;
            this.torles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torles.ForeColor = System.Drawing.Color.White;
            this.torles.Location = new System.Drawing.Point(449, 270);
            this.torles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(160, 50);
            this.torles.TabIndex = 41;
            this.torles.Text = "Rendelés törlése";
            this.torles.UseVisualStyleBackColor = false;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Név:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(61, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(61, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 327);
            this.listBox1.TabIndex = 44;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(258, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Rendelésed adatai:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 138);
            this.dataGridView1.TabIndex = 46;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.megse);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(773, 416);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button megse;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
