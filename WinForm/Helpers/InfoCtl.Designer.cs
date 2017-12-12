namespace WinForm.Helpers
{
    partial class InfoCtl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this._picBox = new System.Windows.Forms.PictureBox();
            this._lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _picBox
            // 
            this._picBox.Location = new System.Drawing.Point(16, 16);
            this._picBox.Margin = new System.Windows.Forms.Padding(4);
            this._picBox.Name = "_picBox";
            this._picBox.Size = new System.Drawing.Size(36, 36);
            this._picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picBox.TabIndex = 0;
            this._picBox.TabStop = false;
            // 
            // _lblText
            // 
            this._lblText.AutoSize = true;
            this._lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblText.Location = new System.Drawing.Point(58, 28);
            this._lblText.Name = "_lblText";
            this._lblText.Size = new System.Drawing.Size(45, 16);
            this._lblText.TabIndex = 1;
            this._lblText.Text = "label1";
            // 
            // InfoCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblText);
            this.Controls.Add(this._picBox);
            this.Name = "InfoCtl";
            this.Size = new System.Drawing.Size(647, 68);
            ((System.ComponentModel.ISupportInitialize)(this._picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picBox;
        private System.Windows.Forms.Label _lblText;
    }
}
