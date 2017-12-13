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
using WinForm.Helpers;
using WinForm.Properties;

namespace WinForm
{
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();

            Transport = new Transport();
            InitControls();
        }

        private Transport Transport { get; set; }

        private void InitControls()
        {
            _comboStart.DisplayMember = "name";
            _comboEnd.DisplayMember = "name";
            ChangeVisibleState();
            _radioStationBoard.Checked = true;
        }

        /// <summary>
        /// StartCombo und EndCombo validieren
        /// </summary>
        /// <returns></returns>
        private bool DoValidateCombos()
        {
            if (_comboStart.SelectedItem == null || string.IsNullOrEmpty(_comboStart.Text))
            {
                _infoCtl.LabelText = "Wählen Sie bitte eine gültige Startstation \n ";
                _infoCtl.InfoType = InfoType.Warning;
                _comboStart.Focus();
                return false;
            }
            if (_radioConnections.Checked && (_comboEnd.SelectedItem == null || string.IsNullOrEmpty(_comboEnd.Text)))
            {
                _infoCtl.LabelText = "Wählen Sie bitte eine gültige Zielstation";
                _infoCtl.InfoType = InfoType.Warning;
                _comboEnd.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Elemente von DropDown aktualisieren
        /// </summary>
        /// <param name="box"></param>
        /// <param name="dropDown"></param>
        private void FillComboDataSource(ComboBox box,bool dropDown=true)
        {
            var inputText = box?.Text;
            if (!string.IsNullOrWhiteSpace(inputText))
            {
                box.DataSource = Transport.GetStations(inputText).StationList.FindAll(e=>!string.IsNullOrEmpty(e.Id));

                box.Text = inputText;
                box.DroppedDown = dropDown;
                box.SelectionStart = inputText.Length;
            }
        }

        /// <summary>
        /// Verbindungen zwichen Stationen finden
        /// </summary>
        private void FindConnections()
        {
            if (_comboStart.SelectedItem == null || _comboEnd.SelectedItem == null) //Für sicherheit
                return;
            _gridConnctions.Rows.Clear();
            _gridConnctions.Refresh();

            var connections = Transport.GetConnections(_comboStart.Text, _comboEnd.Text,
                Converter.DateToString(_date.Value), Converter.TimeToString(_time.Value)).ConnectionList;

            foreach (var connection in connections)
            {
                var row = _gridConnctions.Rows.Add();
                _gridConnctions.Rows[row].Cells[nameof(Start)].Value = connection.From.Station.Name;
                _gridConnctions.Rows[row].Cells[nameof(End)].Value = connection.To.Station.Name;
                _gridConnctions.Rows[row].Cells[nameof(Duration)].Value = // TODO: in Converter??
                    connection.Duration.Substring(3, 2) + " h " + connection.Duration.Substring(6, 2) + " min";
                _gridConnctions.Rows[row].Cells[nameof(Platform)].Value = connection.To.Platform;
                _gridConnctions.Rows[row].Cells[nameof(Arrival)].Value =Convert.ToDateTime(connection.To.Arrival).ToShortDateString()+" " +Convert.ToDateTime(connection.To.Arrival).ToShortTimeString();// connection.To.Arrival;
            }
        }
        /// <summary>
        /// _gridStationBoard befüllen
        /// </summary>
        private void GetStationBoard()
        {
            _gridStationBoard.Rows.Clear();
            _gridStationBoard.Refresh();
            var stationBoard = Transport.GetStationBoard((_comboStart.SelectedItem as Station)?.Name,
                (_comboStart.SelectedItem as Station)?.Id, Converter.DateToString(_date.Value)+ Converter.TimeToString(_time.Value)).Entries;
            foreach (var station in stationBoard)
            {
                var row = _gridStationBoard.Rows.Add();
                _gridStationBoard.Rows[row].Cells[nameof(Category)].Value = station.Category;
                _gridStationBoard.Rows[row].Cells[nameof(Number)].Value = station.Number;
                _gridStationBoard.Rows[row].Cells[nameof(To)].Value = station.To;
                _gridStationBoard.Rows[row].Cells[nameof(Departure)].Value = station.Stop.Departure.ToShortTimeString();
                _gridStationBoard.Rows[row].Cells[nameof(Operator)].Value = station.Operator;
                _gridStationBoard.Rows[row].Cells[nameof(StationName)].Value = station.Name;
            }
        }


        /// <summary>
        /// Usecase Change
        /// </summary>
        private void ChangeVisibleState()
        {
            _infoCtl.LabelText = _radioConnections.Checked
                ? "Wählen Bitte eine Startstation und ein Ziel Station dann drücken Sie 'Suchen' um die Verbindungen anzuzeigen! "
                : "Wählen Sie bitte eine Station, für welche Sie mögliche Verbindungen anzeigen wollen";

            _gridConnctions.Visible = _radioConnections.Checked;
            _gridStationBoard.Visible = !_gridConnctions.Visible;
            _groupBoxEndStationCtls.Visible = _gridConnctions.Visible;
        }

        #region Events
        private void _btnSearchConnection_Click(object sender, EventArgs e)
        {
            if (!DoValidateCombos()) return;
            //
            var cursor = Cursor.Current;//in dem Fall das nich default ist
            Cursor.Current=Cursors.WaitCursor;

            if (_radioConnections.Checked)
                FindConnections();
            else
                GetStationBoard();

            Cursor.Current=cursor;
        }
        private void _picBoxSwapStations_Click(object sender, EventArgs e)
        {
            var start = _comboStart.Text;
            _comboStart.Text = _comboEnd.Text;
            _comboEnd.Text = start;

            FillComboDataSource(_comboStart,false);
            FillComboDataSource(_comboEnd,false);
            var startItem = _comboStart.SelectedItem;
            _comboStart.SelectedItem = _comboEnd.SelectedItem;
            _comboEnd.SelectedItem = startItem;
        }
        private void _picBoxSendMail_Click(object sender, EventArgs e)
        {
            var grid = _radioConnections.Checked ? _gridConnctions : _gridStationBoard;
            if (grid.RowCount < 1)
            {
                _infoCtl.InfoType = InfoType.Warning;
                _infoCtl.LabelText = "Keine Elemente in der Tabelle gefunden. Bitte eine gültige Station auswählen und noch ein Mal versuchen";
                return;
            }

            var email=new EmailCtl();
            var result= email.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Helper.SendGridContentViaMAil(grid,new MailModel(email.Body,email.Recipient,email.Subject));
        }
        private void _picBoxOpenInBrowser_Click(object sender, EventArgs e)
        {
            if (_radioConnections.Checked)
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/dir/" + (_comboStart.SelectedItem as Station)?.Name.Replace(" ", "+")+"/"+(_comboEnd.SelectedItem as Station)?.Name.Replace(" ", "+"));
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.google.ch/maps/place/"+(_comboStart.SelectedItem as Station)?.Name.Replace(" ","+"));
            }
        }

        private void _comboStart_TextUpdate(object sender, EventArgs e) => FillComboDataSource(sender as ComboBox);
        private void _comboEnd_TextUpdate(object sender, EventArgs e) => FillComboDataSource(sender as ComboBox);

        private void _radioStationBoard_CheckedChanged(object sender, EventArgs e) => ChangeVisibleState();
        private void _radioConnections_CheckedChanged(object sender, EventArgs e) => ChangeVisibleState();

        /// <summary>
        /// _picBoxSendMail neue positionieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pnlResult_Resize(object sender, EventArgs e)
        {
            _picBoxSendMail.Location =
                new Point(_pnlResult.Location.X + _pnlResult.Size.Width - _picBoxSendMail.Size.Width,_picBoxSendMail.Location.Y);
            _picBoxOpenInBrowser.Location =
                new Point(_pnlResult.Location.X + _pnlResult.Size.Width - _picBoxSendMail.Size.Width- _picBoxOpenInBrowser.Size.Width-6, _picBoxOpenInBrowser.Location.Y);
        }

        private void _picBoxSendMail_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox) sender).BorderStyle = BorderStyle.Fixed3D;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(((PictureBox)sender), "Resultaten mit Outlook senden");
        }
        private void _picBoxSendMail_MouseLeave(object sender, EventArgs e) =>((PictureBox) sender).BorderStyle = BorderStyle.FixedSingle;

        private void _picBoxSwapStations_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox) sender).BorderStyle = BorderStyle.Fixed3D;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(((PictureBox)sender), "Ausgangsort und Reiseziel vertauschen");
        }
        private void _picBoxSwapStations_MouseLeave(object sender, EventArgs e) =>((PictureBox) sender).BorderStyle = BorderStyle.FixedSingle;

        private void _picBoxOpenInBrowser_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(((PictureBox)sender), "In Browser öffnen");
        }
        private void _picBoxOpenInBrowser_MouseLeave(object sender, EventArgs e) => ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
       #endregion
    }
}
