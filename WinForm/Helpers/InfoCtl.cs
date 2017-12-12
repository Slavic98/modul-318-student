using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Properties;

namespace WinForm.Helpers
{
    public enum InfoType
    {
        Error, Info, Warning, 
    }
    public partial class InfoCtl : UserControl
    {
        public InfoCtl()
        {
            InitializeComponent();
        }

        private InfoType _infoType;
        public InfoType InfoType
        {
            get => _infoType;
            set
            {
                _infoType = value;
                switch (_infoType)
                {
                    case InfoType.Error:
                        _picBox.Image = Resources.error;
                        break;
                    case InfoType.Info:
                        _picBox.Image = Resources.info;
                        break;
                    case InfoType.Warning:
                        _picBox.Image = Resources.warning;
                        break;
                }
            }
        }
        public string LabelText 
        {
            get => _lblText.Text;
            set => _lblText.Text = value;
        }


    }
}
