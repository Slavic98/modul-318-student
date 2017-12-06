using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Transport=new Transport();
            _comboStart.DisplayMember = "name";
            _comboEnd.DisplayMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var start = _comboStart.Text;
            _comboStart.Text = _comboEnd.Text;
            _comboEnd.Text = start;
        }

        private void _comboStart_TextUpdate(object sender, EventArgs e)
        {
            FillComboDataSource(sender as ComboBox);
        }

        private void FillComboDataSource(ComboBox box)
        {
            var inputText = (box)?.Text;
            if (inputText != null)
            {
                box.DataSource = Transport.GetStations(inputText).StationList;
                box.SelectionStart = inputText.Length;
                box.Text = inputText;

                box.DroppedDown = inputText.Length>0;
               
            }
        }

        public Transport Transport { get; set; }

        private void _comboEnd_TextUpdate(object sender, EventArgs e)
        {
            FillComboDataSource(sender as ComboBox);
        }
    }
}
