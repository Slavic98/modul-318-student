namespace WinForm
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._comboStart = new System.Windows.Forms.ComboBox();
            this._comboEnd = new System.Windows.Forms.ComboBox();
            this._btnChangeStartAndEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ziel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // _comboStart
            // 
            this._comboStart.FormattingEnabled = true;
            this._comboStart.Location = new System.Drawing.Point(52, 36);
            this._comboStart.Name = "_comboStart";
            this._comboStart.Size = new System.Drawing.Size(121, 21);
            this._comboStart.TabIndex = 3;
            this._comboStart.TextUpdate += new System.EventHandler(this._comboStart_TextUpdate);
            // 
            // _comboEnd
            // 
            this._comboEnd.FormattingEnabled = true;
            this._comboEnd.Location = new System.Drawing.Point(355, 36);
            this._comboEnd.Name = "_comboEnd";
            this._comboEnd.Size = new System.Drawing.Size(121, 21);
            this._comboEnd.TabIndex = 4;
            this._comboEnd.TextUpdate += new System.EventHandler(this._comboEnd_TextUpdate);
            // 
            // _btnChangeStartAndEnd
            // 
            this._btnChangeStartAndEnd.Location = new System.Drawing.Point(206, 34);
            this._btnChangeStartAndEnd.Name = "_btnChangeStartAndEnd";
            this._btnChangeStartAndEnd.Size = new System.Drawing.Size(75, 23);
            this._btnChangeStartAndEnd.TabIndex = 5;
            this._btnChangeStartAndEnd.Text = " ";
            this._btnChangeStartAndEnd.UseVisualStyleBackColor = true;
            this._btnChangeStartAndEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 381);
            this.Controls.Add(this._btnChangeStartAndEnd);
            this.Controls.Add(this._comboEnd);
            this.Controls.Add(this._comboStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _comboStart;
        private System.Windows.Forms.ComboBox _comboEnd;
        private System.Windows.Forms.Button _btnChangeStartAndEnd;
    }
}

