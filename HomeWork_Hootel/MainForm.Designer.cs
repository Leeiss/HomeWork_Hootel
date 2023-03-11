using System.Globalization;

namespace HomeWork_Hotel
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this._time = new System.Windows.Forms.PictureBox();
            this.searching = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.TextBox();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.discharged_status = new System.Windows.Forms.RadioButton();
            this.reserved_status = new System.Windows.Forms.RadioButton();
            this.busy_status = new System.Windows.Forms.RadioButton();
            this.free_status = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Tabel = new System.Windows.Forms.DataGridView();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.room = new System.Windows.Forms.Label();
            this.closer = new System.Windows.Forms.GroupBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.button_info = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Label();
            this.status_ = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.statuus = new System.Windows.Forms.Label();
            this.GetInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._time);
            this.groupBox1.Controls.Add(this.searching);
            this.groupBox1.Controls.Add(this.menu);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1659, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::HomeWork_Hootel.Properties.Resources.поиск;
            this.button1.Location = new System.Drawing.Point(1497, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _time
            // 
            this._time.Image = global::HomeWork_Hootel.Properties.Resources.clock_with_white_face_icon_icons_com_72804;
            this._time.Location = new System.Drawing.Point(496, 34);
            this._time.Name = "_time";
            this._time.Size = new System.Drawing.Size(39, 38);
            this._time.TabIndex = 5;
            this._time.TabStop = false;
            // 
            // searching
            // 
            this.searching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searching.Font = new System.Drawing.Font("XO Courser", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searching.Location = new System.Drawing.Point(810, 35);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(726, 38);
            this.searching.TabIndex = 3;
            this.searching.Text = "Поиск по таблице";
            this.searching.Click += new System.EventHandler(this.Clear);
            // 
            // menu
            // 
            this.menu.Image = global::HomeWork_Hootel.Properties.Resources.menu_icon_icons_com_69631__1_;
            this.menu.Location = new System.Drawing.Point(0, 17);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(153, 73);
            this.menu.TabIndex = 1;
            this.menu.TabStop = false;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("XO Courser", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(201, 34);
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(334, 38);
            this.time.TabIndex = 2;
            this.time.TabStop = false;
            this.time.Text = " 05 : 37 : 44 AM";
            // 
            // Full_name
            // 
            this.Full_name.Frozen = true;
            this.Full_name.HeaderText = "ФИО";
            this.Full_name.MinimumWidth = 10;
            this.Full_name.Name = "Full_name";
            this.Full_name.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 96);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.status);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1659, 964);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.discharged_status);
            this.groupBox2.Controls.Add(this.reserved_status);
            this.groupBox2.Controls.Add(this.busy_status);
            this.groupBox2.Controls.Add(this.free_status);
            this.groupBox2.Location = new System.Drawing.Point(10, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 268);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // discharged_status
            // 
            this.discharged_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discharged_status.AutoSize = true;
            this.discharged_status.BackColor = System.Drawing.Color.Gainsboro;
            this.discharged_status.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discharged_status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.discharged_status.Location = new System.Drawing.Point(6, 207);
            this.discharged_status.Name = "discharged_status";
            this.discharged_status.Size = new System.Drawing.Size(223, 36);
            this.discharged_status.TabIndex = 11;
            this.discharged_status.TabStop = true;
            this.discharged_status.Text = "Выписывается";
            this.discharged_status.UseVisualStyleBackColor = false;
            this.discharged_status.CheckedChanged += new System.EventHandler(this.discharged_status_CheckedChanged_1);
            // 
            // reserved_status
            // 
            this.reserved_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reserved_status.AutoSize = true;
            this.reserved_status.BackColor = System.Drawing.Color.Gainsboro;
            this.reserved_status.Font = new System.Drawing.Font("Segoe UI Historic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reserved_status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reserved_status.Location = new System.Drawing.Point(6, 19);
            this.reserved_status.Name = "reserved_status";
            this.reserved_status.Size = new System.Drawing.Size(253, 34);
            this.reserved_status.TabIndex = 4;
            this.reserved_status.TabStop = true;
            this.reserved_status.Text = "Зарезервировано";
            this.reserved_status.UseVisualStyleBackColor = false;
            this.reserved_status.CheckedChanged += new System.EventHandler(this.reserved_status_CheckedChanged);
            // 
            // busy_status
            // 
            this.busy_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busy_status.AutoSize = true;
            this.busy_status.BackColor = System.Drawing.Color.Gainsboro;
            this.busy_status.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busy_status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.busy_status.Location = new System.Drawing.Point(6, 147);
            this.busy_status.Name = "busy_status";
            this.busy_status.Size = new System.Drawing.Size(130, 36);
            this.busy_status.TabIndex = 6;
            this.busy_status.TabStop = true;
            this.busy_status.Text = "Занято";
            this.busy_status.UseVisualStyleBackColor = false;
            this.busy_status.CheckedChanged += new System.EventHandler(this.busy_status_CheckedChanged_1);
            // 
            // free_status
            // 
            this.free_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.free_status.AutoSize = true;
            this.free_status.BackColor = System.Drawing.Color.Gainsboro;
            this.free_status.Font = new System.Drawing.Font("Segoe UI Historic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.free_status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.free_status.Location = new System.Drawing.Point(6, 84);
            this.free_status.Name = "free_status";
            this.free_status.Size = new System.Drawing.Size(160, 34);
            this.free_status.TabIndex = 5;
            this.free_status.TabStop = true;
            this.free_status.Text = "Свободно";
            this.free_status.UseVisualStyleBackColor = false;
            this.free_status.CheckedChanged += new System.EventHandler(this.free_status_CheckedChanged_1);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Gainsboro;
            this.status.Font = new System.Drawing.Font("XO Courser", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.SlateBlue;
            this.status.Location = new System.Drawing.Point(10, 20);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(143, 40);
            this.status.TabIndex = 53;
            this.status.Text = "Статус";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.Tabel);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.Controls.Add(this.GetInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1316, 964);
            this.splitContainer2.SplitterDistance = 779;
            this.splitContainer2.TabIndex = 0;
            // 
            // Tabel
            // 
            this.Tabel.AllowUserToAddRows = false;
            this.Tabel.AllowUserToDeleteRows = false;
            this.Tabel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Tabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("XO Courser", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Tabel.ColumnHeadersHeight = 46;
            this.Tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._name,
            this._room,
            this.rooom,
            this._date1,
            this._date2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabel.DefaultCellStyle = dataGridViewCellStyle10;
            this.Tabel.Location = new System.Drawing.Point(-54, 81);
            this.Tabel.Name = "Tabel";
            this.Tabel.ReadOnly = true;
            this.Tabel.RowHeadersWidth = 82;
            this.Tabel.RowTemplate.Height = 41;
            this.Tabel.Size = new System.Drawing.Size(1364, 908);
            this.Tabel.TabIndex = 56;
            this.Tabel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabel_CellContentClick);
            // 
            // _name
            // 
            this._name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._name.HeaderText = "ФИО";
            this._name.MinimumWidth = 10;
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.Width = 107;
            // 
            // _room
            // 
            this._room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._room.HeaderText = "Статус";
            this._room.MinimumWidth = 10;
            this._room.Name = "_room";
            this._room.ReadOnly = true;
            this._room.Width = 155;
            // 
            // rooom
            // 
            this.rooom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rooom.HeaderText = "Номер";
            this.rooom.MinimumWidth = 10;
            this.rooom.Name = "rooom";
            this.rooom.ReadOnly = true;
            this.rooom.Width = 139;
            // 
            // _date1
            // 
            this._date1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._date1.HeaderText = "Дата заезда";
            this._date1.MinimumWidth = 10;
            this._date1.Name = "_date1";
            this._date1.ReadOnly = true;
            this._date1.Width = 235;
            // 
            // _date2
            // 
            this._date2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._date2.HeaderText = "Дата выезда";
            this._date2.MinimumWidth = 10;
            this._date2.Name = "_date2";
            this._date2.ReadOnly = true;
            this._date2.Width = 235;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("XO Courser", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 40);
            this.label5.TabIndex = 55;
            this.label5.Text = "Список гостей";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.room);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.closer);
            this.splitContainer4.Panel2.Controls.Add(this.image);
            this.splitContainer4.Panel2.Controls.Add(this.name);
            this.splitContainer4.Panel2.Controls.Add(this.button_info);
            this.splitContainer4.Panel2.Controls.Add(this.check);
            this.splitContainer4.Panel2.Controls.Add(this.status_);
            this.splitContainer4.Panel2.Controls.Add(this.exit);
            this.splitContainer4.Panel2.Controls.Add(this.date1);
            this.splitContainer4.Panel2.Controls.Add(this.date2);
            this.splitContainer4.Panel2.Controls.Add(this.statuus);
            this.splitContainer4.Size = new System.Drawing.Size(533, 964);
            this.splitContainer4.SplitterDistance = 75;
            this.splitContainer4.TabIndex = 89;
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.BackColor = System.Drawing.Color.Gainsboro;
            this.room.Font = new System.Drawing.Font("XO Courser", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.room.ForeColor = System.Drawing.Color.SlateBlue;
            this.room.Location = new System.Drawing.Point(23, 20);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(164, 40);
            this.room.TabIndex = 79;
            this.room.Text = "Номер №";
            // 
            // closer
            // 
            this.closer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closer.Location = new System.Drawing.Point(0, 0);
            this.closer.Name = "closer";
            this.closer.Size = new System.Drawing.Size(533, 885);
            this.closer.TabIndex = 57;
            this.closer.TabStop = false;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Location = new System.Drawing.Point(46, 66);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(446, 293);
            this.image.TabIndex = 80;
            this.image.TabStop = false;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Gainsboro;
            this.name.Font = new System.Drawing.Font("XO Courser", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(23, 478);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 30);
            this.name.TabIndex = 57;
            this.name.Text = "-";
            // 
            // button_info
            // 
            this.button_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_info.BackColor = System.Drawing.Color.Gainsboro;
            this.button_info.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_info.ForeColor = System.Drawing.Color.Black;
            this.button_info.Location = new System.Drawing.Point(268, 827);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(253, 46);
            this.button_info.TabIndex = 88;
            this.button_info.Text = "Просмотр карточки";
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("XO Courser", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.check.ForeColor = System.Drawing.Color.SlateBlue;
            this.check.Location = new System.Drawing.Point(388, 571);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(23, 23);
            this.check.TabIndex = 87;
            this.check.Text = "-";
            // 
            // status_
            // 
            this.status_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_.AutoSize = true;
            this.status_.Font = new System.Drawing.Font("XO Courser", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.status_.ForeColor = System.Drawing.Color.SlateBlue;
            this.status_.Location = new System.Drawing.Point(300, 422);
            this.status_.Name = "status_";
            this.status_.Size = new System.Drawing.Size(26, 28);
            this.status_.TabIndex = 82;
            this.status_.Text = "-";
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("XO Courser", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.SlateBlue;
            this.exit.Location = new System.Drawing.Point(388, 631);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(23, 23);
            this.exit.TabIndex = 86;
            this.exit.Text = "-";
            // 
            // date1
            // 
            this.date1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.date1.AutoSize = true;
            this.date1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date1.Font = new System.Drawing.Font("XO Courser", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date1.Location = new System.Drawing.Point(23, 565);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(191, 32);
            this.date1.TabIndex = 84;
            this.date1.Text = "Дата заезда";
            // 
            // date2
            // 
            this.date2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.date2.AutoSize = true;
            this.date2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date2.Font = new System.Drawing.Font("XO Courser", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date2.Location = new System.Drawing.Point(23, 631);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(191, 32);
            this.date2.TabIndex = 85;
            this.date2.Text = "Дата выезда";
            // 
            // statuus
            // 
            this.statuus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statuus.AutoSize = true;
            this.statuus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statuus.Font = new System.Drawing.Font("XO Courser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statuus.Location = new System.Drawing.Point(23, 415);
            this.statuus.Name = "statuus";
            this.statuus.Size = new System.Drawing.Size(131, 38);
            this.statuus.TabIndex = 81;
            this.statuus.Text = "Cтатус";
            // 
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.GetInfo.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetInfo.Location = new System.Drawing.Point(142, 873);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(259, 46);
            this.GetInfo.TabIndex = 88;
            this.GetInfo.Text = "Просмотр карточки";
            this.GetInfo.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1659, 1060);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Гости отеля";
            this.Activated += new System.EventHandler(this.Activate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabel)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private GroupBox groupBox1;
        private PictureBox menu;
        private TextBox time;
        private RichTextBox searching;
        private PictureBox _time;
        private DataGridViewTextBoxColumn Full_name;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
        private RadioButton discharged_status;
        private RadioButton reserved_status;
        private RadioButton busy_status;
        private RadioButton free_status;
        private Label status;
        private Label label5;
        private DataGridView Tabel;
        private Label check;
        private Label room;
        private Label exit;
        private Label statuus;
        private Label date2;
        private Label status_;
        private PictureBox image;
        private Label date1;
        private Button button1;
        private Button GetInfo;
        private SplitContainer splitContainer3;
        private GroupBox closer;
        private SplitContainer splitContainer4;
        private Button button_info;
        private DataGridViewTextBoxColumn _name;
        private DataGridViewTextBoxColumn _room;
        private DataGridViewTextBoxColumn rooom;
        private DataGridViewTextBoxColumn _date1;
        private DataGridViewTextBoxColumn _date2;
        private Label name;
    }
}