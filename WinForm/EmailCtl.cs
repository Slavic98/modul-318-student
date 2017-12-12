using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class EmailCtl : Form
    {
        public EmailCtl()
        {
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }

        private void _btnSent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_txtRecipient.Text))
            {
                Recipient = _txtRecipient.Text;
                Subject = _txtSubject.Text;
                Body = _txtText.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Um einem Email zu senden, müssen Sie eine Emailadresse eingeben!","Empfängeradresse nicht gesetzt",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                _txtRecipient.Focus();
            }

        }

        public string Subject { get; private set; }
        public string Recipient { get; private set; }
        public string Body { get; set; }
    }
}
