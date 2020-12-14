namespace KaracsonyfaRendeles
{
    partial class UserControl1
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
            this.comboBoxLuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxLuc
            // 
            this.comboBoxLuc.FormattingEnabled = true;
            this.comboBoxLuc.Location = new System.Drawing.Point(41, 53);
            this.comboBoxLuc.Name = "comboBoxLuc";
            this.comboBoxLuc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLuc.TabIndex = 0;
            this.comboBoxLuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLuc_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.comboBoxLuc);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(546, 336);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLuc;
    }
}
