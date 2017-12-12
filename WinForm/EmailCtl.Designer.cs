namespace WinForm
{
    partial class EmailCtl
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
            this._txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtRecipient = new System.Windows.Forms.TextBox();
            this._btnSent = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._txtText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtSubject
            // 
            this._txtSubject.Location = new System.Drawing.Point(80, 40);
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new System.Drawing.Size(100, 20);
            this._txtSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empfänger:";
            // 
            // _txtRecipient
            // 
            this._txtRecipient.Location = new System.Drawing.Point(80, 83);
            this._txtRecipient.Name = "_txtRecipient";
            this._txtRecipient.Size = new System.Drawing.Size(100, 20);
            this._txtRecipient.TabIndex = 3;
            // 
            // _btnSent
            // 
            this._btnSent.Location = new System.Drawing.Point(156, 267);
            this._btnSent.Name = "_btnSent";
            this._btnSent.Size = new System.Drawing.Size(75, 23);
            this._btnSent.TabIndex = 4;
            this._btnSent.Text = "Senden";
            this._btnSent.UseVisualStyleBackColor = true;
            this._btnSent.Click += new System.EventHandler(this._btnSent_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(237, 267);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Abbrechen";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _txtText
            // 
            this._txtText.Location = new System.Drawing.Point(80, 122);
            this._txtText.Multiline = true;
            this._txtText.Name = "_txtText";
            this._txtText.Size = new System.Drawing.Size(210, 107);
            this._txtText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text:";
            // 
            // EmailCtl
            // 
            this.AcceptButton = this._btnSent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtText);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSent);
            this.Controls.Add(this._txtRecipient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtSubject);
            this.Name = "EmailCtl";
            this.Text = "EmailCtl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtRecipient;
        private System.Windows.Forms.Button _btnSent;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.TextBox _txtText;
        private System.Windows.Forms.Label label3;
    }
}