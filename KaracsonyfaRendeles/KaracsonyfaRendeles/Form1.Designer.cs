namespace KaracsonyfaRendeles
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonUj = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonFenyok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUj
            // 
            this.buttonUj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUj.ForeColor = System.Drawing.Color.White;
            this.buttonUj.Location = new System.Drawing.Point(12, 312);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(154, 65);
            this.buttonUj.TabIndex = 1;
            this.buttonUj.Text = "Új rendelés";
            this.buttonUj.UseVisualStyleBackColor = false;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTorles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTorles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTorles.ForeColor = System.Drawing.Color.White;
            this.buttonTorles.Location = new System.Drawing.Point(12, 538);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(154, 65);
            this.buttonTorles.TabIndex = 2;
            this.buttonTorles.Text = "Rendelés törlése";
            this.buttonTorles.UseVisualStyleBackColor = false;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonFenyok
            // 
            this.buttonFenyok.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFenyok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFenyok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFenyok.ForeColor = System.Drawing.Color.White;
            this.buttonFenyok.Location = new System.Drawing.Point(12, 232);
            this.buttonFenyok.Name = "buttonFenyok";
            this.buttonFenyok.Size = new System.Drawing.Size(154, 65);
            this.buttonFenyok.TabIndex = 3;
            this.buttonFenyok.Text = "Kínálatunk";
            this.buttonFenyok.UseVisualStyleBackColor = false;
            this.buttonFenyok.Click += new System.EventHandler(this.buttonFenyok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Karácsonyfa házhozszállítás";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(188, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 500);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 140);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1032, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFenyok);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonUj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonFenyok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

