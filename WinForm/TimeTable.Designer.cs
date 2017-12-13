namespace WinForm
{
    partial class TimeTable
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
            this._lblEnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._comboStart = new System.Windows.Forms.ComboBox();
            this._comboEnd = new System.Windows.Forms.ComboBox();
            this._btnSearchConnection = new System.Windows.Forms.Button();
            this._pnlResult = new System.Windows.Forms.Panel();
            this._gridStationBoard = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._gridConnctions = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._radioConnections = new System.Windows.Forms.RadioButton();
            this._radioStationBoard = new System.Windows.Forms.RadioButton();
            this._date = new System.Windows.Forms.DateTimePicker();
            this._time = new System.Windows.Forms.DateTimePicker();
            this._groupBoxDateTime = new System.Windows.Forms.GroupBox();
            this._groupBoxEndStationCtls = new System.Windows.Forms.GroupBox();
            this._picBoxSwapStations = new System.Windows.Forms.PictureBox();
            this._picBoxOpenInBrowser = new System.Windows.Forms.PictureBox();
            this._picBoxSendMail = new System.Windows.Forms.PictureBox();
            this._infoCtl = new WinForm.Helpers.InfoCtl();
            this._pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridStationBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridConnctions)).BeginInit();
            this._groupBox.SuspendLayout();
            this._groupBoxDateTime.SuspendLayout();
            this._groupBoxEndStationCtls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxSwapStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxOpenInBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxSendMail)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblEnd
            // 
            this._lblEnd.AutoSize = true;
            this._lblEnd.Location = new System.Drawing.Point(62, 42);
            this._lblEnd.Name = "_lblEnd";
            this._lblEnd.Size = new System.Drawing.Size(24, 13);
            this._lblEnd.TabIndex = 0;
            this._lblEnd.Text = "Ziel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Start:";
            // 
            // _comboStart
            // 
            this._comboStart.FormattingEnabled = true;
            this._comboStart.Location = new System.Drawing.Point(70, 39);
            this._comboStart.Name = "_comboStart";
            this._comboStart.Size = new System.Drawing.Size(121, 21);
            this._comboStart.TabIndex = 1;
            this._comboStart.TextUpdate += new System.EventHandler(this._comboStart_TextUpdate);
            // 
            // _comboEnd
            // 
            this._comboEnd.FormattingEnabled = true;
            this._comboEnd.Location = new System.Drawing.Point(104, 39);
            this._comboEnd.Name = "_comboEnd";
            this._comboEnd.Size = new System.Drawing.Size(121, 21);
            this._comboEnd.TabIndex = 3;
            this._comboEnd.TextUpdate += new System.EventHandler(this._comboEnd_TextUpdate);
            // 
            // _btnSearchConnection
            // 
            this._btnSearchConnection.Location = new System.Drawing.Point(481, 39);
            this._btnSearchConnection.Name = "_btnSearchConnection";
            this._btnSearchConnection.Size = new System.Drawing.Size(75, 23);
            this._btnSearchConnection.TabIndex = 4;
            this._btnSearchConnection.Text = "Suchen";
            this._btnSearchConnection.UseVisualStyleBackColor = true;
            this._btnSearchConnection.Click += new System.EventHandler(this._btnSearchConnection_Click);
            // 
            // _pnlResult
            // 
            this._pnlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlResult.Controls.Add(this._gridStationBoard);
            this._pnlResult.Controls.Add(this._gridConnctions);
            this._pnlResult.Location = new System.Drawing.Point(16, 128);
            this._pnlResult.Name = "_pnlResult";
            this._pnlResult.Size = new System.Drawing.Size(1018, 445);
            this._pnlResult.TabIndex = 17;
            this._pnlResult.Resize += new System.EventHandler(this._pnlResult_Resize);
            // 
            // _gridStationBoard
            // 
            this._gridStationBoard.AllowUserToAddRows = false;
            this._gridStationBoard.AllowUserToDeleteRows = false;
            this._gridStationBoard.AllowUserToOrderColumns = true;
            this._gridStationBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Number,
            this.To,
            this.Departure,
            this.Operator,
            this.StationName});
            this._gridStationBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridStationBoard.Location = new System.Drawing.Point(0, 0);
            this._gridStationBoard.Name = "_gridStationBoard";
            this._gridStationBoard.ReadOnly = true;
            this._gridStationBoard.RowHeadersVisible = false;
            this._gridStationBoard.Size = new System.Drawing.Size(1018, 445);
            this._gridStationBoard.TabIndex = 102;
            // 
            // Category
            // 
            this.Category.HeaderText = "Kategorie";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Nummer";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "Nach";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrt";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Name";
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            // 
            // _gridConnctions
            // 
            this._gridConnctions.AllowUserToAddRows = false;
            this._gridConnctions.AllowUserToDeleteRows = false;
            this._gridConnctions.AllowUserToOrderColumns = true;
            this._gridConnctions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._gridConnctions.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this._gridConnctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridConnctions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Start,
            this.End,
            this.Duration,
            this.Platform,
            this.Arrival});
            this._gridConnctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridConnctions.Location = new System.Drawing.Point(0, 0);
            this._gridConnctions.Name = "_gridConnctions";
            this._gridConnctions.ReadOnly = true;
            this._gridConnctions.RowHeadersVisible = false;
            this._gridConnctions.Size = new System.Drawing.Size(1018, 445);
            this._gridConnctions.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // End
            // 
            this.End.HeaderText = "Ziel";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._radioConnections);
            this._groupBox.Controls.Add(this._radioStationBoard);
            this._groupBox.Location = new System.Drawing.Point(574, 17);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(227, 68);
            this._groupBox.TabIndex = 104;
            this._groupBox.TabStop = false;
            // 
            // _radioConnections
            // 
            this._radioConnections.AutoSize = true;
            this._radioConnections.Location = new System.Drawing.Point(18, 19);
            this._radioConnections.Name = "_radioConnections";
            this._radioConnections.Size = new System.Drawing.Size(89, 17);
            this._radioConnections.TabIndex = 1;
            this._radioConnections.TabStop = true;
            this._radioConnections.Text = "Routenplaner";
            this._radioConnections.UseVisualStyleBackColor = true;
            this._radioConnections.CheckedChanged += new System.EventHandler(this._radioConnections_CheckedChanged);
            // 
            // _radioStationBoard
            // 
            this._radioStationBoard.AutoSize = true;
            this._radioStationBoard.Location = new System.Drawing.Point(18, 42);
            this._radioStationBoard.Name = "_radioStationBoard";
            this._radioStationBoard.Size = new System.Drawing.Size(182, 17);
            this._radioStationBoard.TabIndex = 0;
            this._radioStationBoard.TabStop = true;
            this._radioStationBoard.Text = "mögliche Verbindungen anzeigen";
            this._radioStationBoard.UseVisualStyleBackColor = true;
            this._radioStationBoard.CheckedChanged += new System.EventHandler(this._radioStationBoard_CheckedChanged);
            // 
            // _date
            // 
            this._date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._date.Location = new System.Drawing.Point(11, 19);
            this._date.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this._date.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this._date.Name = "_date";
            this._date.Size = new System.Drawing.Size(94, 20);
            this._date.TabIndex = 105;
            // 
            // _time
            // 
            this._time.CustomFormat = "HH:mm";
            this._time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._time.Location = new System.Drawing.Point(111, 19);
            this._time.Name = "_time";
            this._time.ShowUpDown = true;
            this._time.Size = new System.Drawing.Size(70, 20);
            this._time.TabIndex = 106;
            // 
            // _groupBoxDateTime
            // 
            this._groupBoxDateTime.Controls.Add(this._time);
            this._groupBoxDateTime.Controls.Add(this._date);
            this._groupBoxDateTime.Location = new System.Drawing.Point(25, 64);
            this._groupBoxDateTime.Name = "_groupBoxDateTime";
            this._groupBoxDateTime.Size = new System.Drawing.Size(192, 58);
            this._groupBoxDateTime.TabIndex = 107;
            this._groupBoxDateTime.TabStop = false;
            // 
            // _groupBoxEndStationCtls
            // 
            this._groupBoxEndStationCtls.Controls.Add(this._picBoxSwapStations);
            this._groupBoxEndStationCtls.Controls.Add(this._lblEnd);
            this._groupBoxEndStationCtls.Controls.Add(this._comboEnd);
            this._groupBoxEndStationCtls.Location = new System.Drawing.Point(222, 0);
            this._groupBoxEndStationCtls.Name = "_groupBoxEndStationCtls";
            this._groupBoxEndStationCtls.Size = new System.Drawing.Size(231, 85);
            this._groupBoxEndStationCtls.TabIndex = 2;
            this._groupBoxEndStationCtls.TabStop = false;
            // 
            // _picBoxSwapStations
            // 
            this._picBoxSwapStations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picBoxSwapStations.Image = global::WinForm.Properties.Resources.Swap;
            this._picBoxSwapStations.Location = new System.Drawing.Point(6, 36);
            this._picBoxSwapStations.Name = "_picBoxSwapStations";
            this._picBoxSwapStations.Size = new System.Drawing.Size(26, 26);
            this._picBoxSwapStations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picBoxSwapStations.TabIndex = 102;
            this._picBoxSwapStations.TabStop = false;
            this._picBoxSwapStations.Click += new System.EventHandler(this._picBoxSwapStations_Click);
            this._picBoxSwapStations.MouseLeave += new System.EventHandler(this._picBoxSwapStations_MouseLeave);
            this._picBoxSwapStations.MouseHover += new System.EventHandler(this._picBoxSwapStations_MouseHover);
            // 
            // _picBoxOpenInBrowser
            // 
            this._picBoxOpenInBrowser.Image = global::WinForm.Properties.Resources.gMaps;
            this._picBoxOpenInBrowser.Location = new System.Drawing.Point(951, 88);
            this._picBoxOpenInBrowser.Name = "_picBoxOpenInBrowser";
            this._picBoxOpenInBrowser.Size = new System.Drawing.Size(37, 34);
            this._picBoxOpenInBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picBoxOpenInBrowser.TabIndex = 108;
            this._picBoxOpenInBrowser.TabStop = false;
            this._picBoxOpenInBrowser.Click += new System.EventHandler(this._picBoxOpenInBrowser_Click);
            this._picBoxOpenInBrowser.MouseLeave += new System.EventHandler(this._picBoxOpenInBrowser_MouseLeave);
            this._picBoxOpenInBrowser.MouseHover += new System.EventHandler(this._picBoxOpenInBrowser_MouseHover);
            // 
            // _picBoxSendMail
            // 
            this._picBoxSendMail.BackColor = System.Drawing.Color.White;
            this._picBoxSendMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picBoxSendMail.Image = global::WinForm.Properties.Resources.email;
            this._picBoxSendMail.Location = new System.Drawing.Point(994, 88);
            this._picBoxSendMail.Name = "_picBoxSendMail";
            this._picBoxSendMail.Size = new System.Drawing.Size(37, 34);
            this._picBoxSendMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picBoxSendMail.TabIndex = 102;
            this._picBoxSendMail.TabStop = false;
            this._picBoxSendMail.Click += new System.EventHandler(this._picBoxSendMail_Click);
            this._picBoxSendMail.MouseLeave += new System.EventHandler(this._picBoxSendMail_MouseLeave);
            this._picBoxSendMail.MouseHover += new System.EventHandler(this._picBoxSendMail_MouseHover);
            // 
            // _infoCtl
            // 
            this._infoCtl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._infoCtl.InfoType = WinForm.Helpers.InfoType.Info;
            this._infoCtl.LabelText = "Info";
            this._infoCtl.Location = new System.Drawing.Point(0, 584);
            this._infoCtl.Name = "_infoCtl";
            this._infoCtl.Size = new System.Drawing.Size(1064, 65);
            this._infoCtl.TabIndex = 103;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 649);
            this.Controls.Add(this._picBoxOpenInBrowser);
            this.Controls.Add(this._groupBoxEndStationCtls);
            this.Controls.Add(this._groupBoxDateTime);
            this.Controls.Add(this._groupBox);
            this.Controls.Add(this._infoCtl);
            this.Controls.Add(this._picBoxSendMail);
            this.Controls.Add(this._pnlResult);
            this.Controls.Add(this._btnSearchConnection);
            this.Controls.Add(this._comboStart);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(880, 405);
            this.Name = "TimeTable";
            this.Text = "TimeTable";
            this._pnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridStationBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gridConnctions)).EndInit();
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this._groupBoxDateTime.ResumeLayout(false);
            this._groupBoxEndStationCtls.ResumeLayout(false);
            this._groupBoxEndStationCtls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxSwapStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxOpenInBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxSendMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _comboStart;
        private System.Windows.Forms.ComboBox _comboEnd;
        private System.Windows.Forms.Button _btnSearchConnection;
        private System.Windows.Forms.Panel _pnlResult;
        private System.Windows.Forms.DataGridView _gridConnctions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.PictureBox _picBoxSwapStations;
        private System.Windows.Forms.PictureBox _picBoxSendMail;
        private Helpers.InfoCtl _infoCtl;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.RadioButton _radioConnections;
        private System.Windows.Forms.RadioButton _radioStationBoard;
        private System.Windows.Forms.DataGridView _gridStationBoard;
        private System.Windows.Forms.DateTimePicker _date;
        private System.Windows.Forms.DateTimePicker _time;
        private System.Windows.Forms.GroupBox _groupBoxDateTime;
        private System.Windows.Forms.GroupBox _groupBoxEndStationCtls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.PictureBox _picBoxOpenInBrowser;
    }
}

