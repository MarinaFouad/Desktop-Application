namespace Project
{
    partial class AdminForm
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
            panel1 = new Panel();
            close = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TeacherBtn = new Button();
            StudentBtn = new Button();
            TrackBtn = new Button();
            tabControl1 = new TabControl();
            TeacherTab = new TabPage();
            TcomboSearch = new ComboBox();
            TtotalBill = new Label();
            label23 = new Label();
            groupBox3 = new GroupBox();
            button5 = new Button();
            label22 = new Label();
            label21 = new Label();
            Tmax = new TextBox();
            Tmin = new TextBox();
            label20 = new Label();
            label12 = new Label();
            Tfilter = new ComboBox();
            Tearning = new ComboBox();
            label13 = new Label();
            TbillBtn = new Button();
            label18 = new Label();
            Tbill = new TextBox();
            groupBox2 = new GroupBox();
            TeditBtn = new Button();
            TaddBtn = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            TuserName = new TextBox();
            Taddress = new TextBox();
            Tphone = new TextBox();
            Tname = new TextBox();
            TresetBtn = new Button();
            TsearchBtn = new Button();
            Tsearch = new TextBox();
            Tdata = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            label19 = new Label();
            StudentTab = new TabPage();
            StudentComboSearch = new ComboBox();
            StudentTotalBill = new Label();
            label28 = new Label();
            groupBox4 = new GroupBox();
            label26 = new Label();
            button6 = new Button();
            label25 = new Label();
            label24 = new Label();
            StudentMax = new TextBox();
            StudentMin = new TextBox();
            label4 = new Label();
            label11 = new Label();
            StudentFilter = new ComboBox();
            billCombo = new ComboBox();
            StudentBill = new Button();
            label9 = new Label();
            BillText = new TextBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            StudentUserName = new TextBox();
            EditStudent = new Button();
            AddStudent = new Button();
            StudentName = new TextBox();
            label8 = new Label();
            StudentPhone = new TextBox();
            label5 = new Label();
            StudentAddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            StudentReset = new Button();
            StudentSearch = new Button();
            StudentSearchBar = new TextBox();
            StudentGrid = new DataGridView();
            panel4 = new Panel();
            label27 = new Label();
            TrackTab = new TabPage();
            TrackNumbers = new Label();
            groupBox5 = new GroupBox();
            label3 = new Label();
            button4 = new Button();
            trackName = new TextBox();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            searchTrack = new TextBox();
            TrackData = new DataGridView();
            panel5 = new Panel();
            label29 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            TeacherTab.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tdata).BeginInit();
            panel3.SuspendLayout();
            StudentTab.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentGrid).BeginInit();
            panel4.SuspendLayout();
            TrackTab.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackData).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 27);
            panel1.TabIndex = 0;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Location = new Point(962, 7);
            close.Name = "close";
            close.Size = new Size(14, 15);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 7);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 1;
            label1.Text = "Admin Panel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.HotTrack;
            flowLayoutPanel1.Controls.Add(TeacherBtn);
            flowLayoutPanel1.Controls.Add(StudentBtn);
            flowLayoutPanel1.Controls.Add(TrackBtn);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 673);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // TeacherBtn
            // 
            TeacherBtn.BackColor = SystemColors.HotTrack;
            TeacherBtn.Cursor = Cursors.Hand;
            TeacherBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TeacherBtn.ForeColor = Color.White;
            TeacherBtn.Location = new Point(3, 3);
            TeacherBtn.Name = "TeacherBtn";
            TeacherBtn.Size = new Size(198, 52);
            TeacherBtn.TabIndex = 3;
            TeacherBtn.Text = "Teacher";
            TeacherBtn.UseVisualStyleBackColor = false;
            TeacherBtn.Click += TeacherBtn_Click;
            // 
            // StudentBtn
            // 
            StudentBtn.BackColor = SystemColors.HotTrack;
            StudentBtn.Cursor = Cursors.Hand;
            StudentBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            StudentBtn.ForeColor = Color.White;
            StudentBtn.Location = new Point(3, 61);
            StudentBtn.Name = "StudentBtn";
            StudentBtn.Size = new Size(198, 52);
            StudentBtn.TabIndex = 2;
            StudentBtn.Text = "Student";
            StudentBtn.UseVisualStyleBackColor = false;
            StudentBtn.Click += StudentBtn_Click;
            // 
            // TrackBtn
            // 
            TrackBtn.BackColor = SystemColors.HotTrack;
            TrackBtn.Cursor = Cursors.Hand;
            TrackBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TrackBtn.ForeColor = Color.White;
            TrackBtn.Location = new Point(3, 119);
            TrackBtn.Name = "TrackBtn";
            TrackBtn.Size = new Size(198, 52);
            TrackBtn.TabIndex = 3;
            TrackBtn.Text = "Track";
            TrackBtn.UseVisualStyleBackColor = false;
            TrackBtn.Click += TrackBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TeacherTab);
            tabControl1.Controls.Add(StudentTab);
            tabControl1.Controls.Add(TrackTab);
            tabControl1.Location = new Point(187, -8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(813, 687);
            tabControl1.TabIndex = 2;
            // 
            // TeacherTab
            // 
            TeacherTab.BackColor = Color.White;
            TeacherTab.Controls.Add(TcomboSearch);
            TeacherTab.Controls.Add(TtotalBill);
            TeacherTab.Controls.Add(label23);
            TeacherTab.Controls.Add(groupBox3);
            TeacherTab.Controls.Add(TbillBtn);
            TeacherTab.Controls.Add(label18);
            TeacherTab.Controls.Add(Tbill);
            TeacherTab.Controls.Add(groupBox2);
            TeacherTab.Controls.Add(TresetBtn);
            TeacherTab.Controls.Add(TsearchBtn);
            TeacherTab.Controls.Add(Tsearch);
            TeacherTab.Controls.Add(Tdata);
            TeacherTab.Controls.Add(panel2);
            TeacherTab.Controls.Add(panel3);
            TeacherTab.Location = new Point(4, 24);
            TeacherTab.Name = "TeacherTab";
            TeacherTab.Padding = new Padding(3);
            TeacherTab.Size = new Size(805, 659);
            TeacherTab.TabIndex = 0;
            TeacherTab.Text = "Teacher";
            TeacherTab.Click += TeacherTab_Click;
            // 
            // TcomboSearch
            // 
            TcomboSearch.FormattingEnabled = true;
            TcomboSearch.Location = new Point(591, 121);
            TcomboSearch.Name = "TcomboSearch";
            TcomboSearch.Size = new Size(85, 23);
            TcomboSearch.TabIndex = 20;
            // 
            // TtotalBill
            // 
            TtotalBill.AutoSize = true;
            TtotalBill.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            TtotalBill.Location = new Point(692, 505);
            TtotalBill.Name = "TtotalBill";
            TtotalBill.Size = new Size(42, 20);
            TtotalBill.TabIndex = 18;
            TtotalBill.Text = "0 L.E";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label23.Location = new Point(560, 505);
            label23.Name = "label23";
            label23.Size = new Size(131, 20);
            label23.TabIndex = 17;
            label23.Text = "All Teacher Bill = ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(Tmax);
            groupBox3.Controls.Add(Tmin);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(Tfilter);
            groupBox3.Controls.Add(Tearning);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(26, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(377, 207);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filters";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.ForeColor = Color.White;
            button5.Location = new Point(322, 140);
            button5.Name = "button5";
            button5.Size = new Size(40, 23);
            button5.TabIndex = 14;
            button5.Text = "OK";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(216, 143);
            label22.Name = "label22";
            label22.Size = new Size(31, 15);
            label22.TabIndex = 13;
            label22.Text = "Max";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(128, 144);
            label21.Name = "label21";
            label21.Size = new Size(28, 15);
            label21.TabIndex = 12;
            label21.Text = "Min";
            // 
            // Tmax
            // 
            Tmax.Location = new Point(253, 140);
            Tmax.Name = "Tmax";
            Tmax.Size = new Size(48, 23);
            Tmax.TabIndex = 11;
            // 
            // Tmin
            // 
            Tmin.Location = new Point(162, 140);
            Tmin.Name = "Tmin";
            Tmin.Size = new Size(48, 23);
            Tmin.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(11, 144);
            label20.Name = "label20";
            label20.Size = new Size(101, 20);
            label20.TabIndex = 9;
            label20.Text = "Bill By Range";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(11, 39);
            label12.Name = "label12";
            label12.Size = new Size(116, 20);
            label12.TabIndex = 7;
            label12.Text = "Filter by course";
            // 
            // Tfilter
            // 
            Tfilter.FormattingEnabled = true;
            Tfilter.Location = new Point(190, 36);
            Tfilter.Name = "Tfilter";
            Tfilter.Size = new Size(121, 23);
            Tfilter.TabIndex = 5;
            // 
            // Tearning
            // 
            Tearning.FormattingEnabled = true;
            Tearning.Location = new Point(190, 84);
            Tearning.Name = "Tearning";
            Tearning.Size = new Size(121, 23);
            Tearning.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(11, 87);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 8;
            label13.Text = "Filter by bill";
            // 
            // TbillBtn
            // 
            TbillBtn.BackColor = SystemColors.HotTrack;
            TbillBtn.ForeColor = Color.White;
            TbillBtn.Location = new Point(663, 569);
            TbillBtn.Name = "TbillBtn";
            TbillBtn.Size = new Size(75, 23);
            TbillBtn.TabIndex = 14;
            TbillBtn.Text = "Pay";
            TbillBtn.UseVisualStyleBackColor = false;
            TbillBtn.Click += TbillBtn_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(432, 568);
            label18.Name = "label18";
            label18.Size = new Size(31, 20);
            label18.TabIndex = 13;
            label18.Text = "Bill";
            // 
            // Tbill
            // 
            Tbill.Location = new Point(514, 569);
            Tbill.Name = "Tbill";
            Tbill.Size = new Size(100, 23);
            Tbill.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TeditBtn);
            groupBox2.Controls.Add(TaddBtn);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(TuserName);
            groupBox2.Controls.Add(Taddress);
            groupBox2.Controls.Add(Tphone);
            groupBox2.Controls.Add(Tname);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(26, 343);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 245);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add and Edit";
            // 
            // TeditBtn
            // 
            TeditBtn.BackColor = SystemColors.HotTrack;
            TeditBtn.ForeColor = Color.White;
            TeditBtn.Location = new Point(182, 205);
            TeditBtn.Name = "TeditBtn";
            TeditBtn.Size = new Size(75, 23);
            TeditBtn.TabIndex = 14;
            TeditBtn.Text = "Edit";
            TeditBtn.UseVisualStyleBackColor = false;
            TeditBtn.Click += TeditBtn_Click;
            // 
            // TaddBtn
            // 
            TaddBtn.BackColor = SystemColors.HotTrack;
            TaddBtn.ForeColor = Color.White;
            TaddBtn.Location = new Point(68, 205);
            TaddBtn.Name = "TaddBtn";
            TaddBtn.Size = new Size(75, 23);
            TaddBtn.TabIndex = 13;
            TaddBtn.Text = "Add";
            TaddBtn.UseVisualStyleBackColor = false;
            TaddBtn.Click += TaddBtn_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(6, 165);
            label17.Name = "label17";
            label17.Size = new Size(87, 20);
            label17.TabIndex = 12;
            label17.Text = "User Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(6, 117);
            label16.Name = "label16";
            label16.Size = new Size(66, 20);
            label16.TabIndex = 11;
            label16.Text = "Address";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(6, 76);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 10;
            label15.Text = "Phone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(6, 32);
            label14.Name = "label14";
            label14.Size = new Size(51, 20);
            label14.TabIndex = 9;
            label14.Text = "Name";
            // 
            // TuserName
            // 
            TuserName.Location = new Point(182, 162);
            TuserName.Name = "TuserName";
            TuserName.Size = new Size(129, 23);
            TuserName.TabIndex = 3;
            // 
            // Taddress
            // 
            Taddress.Location = new Point(182, 114);
            Taddress.Name = "Taddress";
            Taddress.Size = new Size(129, 23);
            Taddress.TabIndex = 2;
            // 
            // Tphone
            // 
            Tphone.Location = new Point(182, 73);
            Tphone.Name = "Tphone";
            Tphone.Size = new Size(129, 23);
            Tphone.TabIndex = 1;
            // 
            // Tname
            // 
            Tname.Location = new Point(182, 29);
            Tname.Name = "Tname";
            Tname.Size = new Size(129, 23);
            Tname.TabIndex = 0;
            // 
            // TresetBtn
            // 
            TresetBtn.BackColor = SystemColors.HotTrack;
            TresetBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TresetBtn.ForeColor = Color.White;
            TresetBtn.Location = new Point(432, 497);
            TresetBtn.Name = "TresetBtn";
            TresetBtn.Size = new Size(102, 37);
            TresetBtn.TabIndex = 4;
            TresetBtn.Text = "Reset Table";
            TresetBtn.UseVisualStyleBackColor = false;
            TresetBtn.Click += TresetBtn_Click;
            // 
            // TsearchBtn
            // 
            TsearchBtn.BackColor = SystemColors.HotTrack;
            TsearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TsearchBtn.ForeColor = Color.White;
            TsearchBtn.Location = new Point(705, 120);
            TsearchBtn.Name = "TsearchBtn";
            TsearchBtn.Size = new Size(57, 23);
            TsearchBtn.TabIndex = 3;
            TsearchBtn.Text = "Search";
            TsearchBtn.UseVisualStyleBackColor = false;
            TsearchBtn.Click += TsearchBtn_Click;
            // 
            // Tsearch
            // 
            Tsearch.Location = new Point(432, 121);
            Tsearch.Name = "Tsearch";
            Tsearch.Size = new Size(153, 23);
            Tsearch.TabIndex = 2;
            // 
            // Tdata
            // 
            Tdata.BackgroundColor = Color.White;
            Tdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tdata.Location = new Point(432, 168);
            Tdata.Name = "Tdata";
            Tdata.Size = new Size(329, 306);
            Tdata.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(3, -24);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 25);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(label19);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 70);
            panel3.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(254, 11);
            label19.Name = "label19";
            label19.Size = new Size(247, 47);
            label19.TabIndex = 15;
            label19.Text = "Teacher Panle";
            // 
            // StudentTab
            // 
            StudentTab.BackColor = Color.White;
            StudentTab.Controls.Add(StudentComboSearch);
            StudentTab.Controls.Add(StudentTotalBill);
            StudentTab.Controls.Add(label28);
            StudentTab.Controls.Add(groupBox4);
            StudentTab.Controls.Add(StudentBill);
            StudentTab.Controls.Add(label9);
            StudentTab.Controls.Add(BillText);
            StudentTab.Controls.Add(groupBox1);
            StudentTab.Controls.Add(label7);
            StudentTab.Controls.Add(StudentReset);
            StudentTab.Controls.Add(StudentSearch);
            StudentTab.Controls.Add(StudentSearchBar);
            StudentTab.Controls.Add(StudentGrid);
            StudentTab.Controls.Add(panel4);
            StudentTab.Location = new Point(4, 24);
            StudentTab.Name = "StudentTab";
            StudentTab.Padding = new Padding(3);
            StudentTab.Size = new Size(805, 659);
            StudentTab.TabIndex = 1;
            StudentTab.Text = "Student";
            // 
            // StudentComboSearch
            // 
            StudentComboSearch.FormattingEnabled = true;
            StudentComboSearch.Location = new Point(603, 163);
            StudentComboSearch.Name = "StudentComboSearch";
            StudentComboSearch.Size = new Size(85, 23);
            StudentComboSearch.TabIndex = 24;
            // 
            // StudentTotalBill
            // 
            StudentTotalBill.AutoSize = true;
            StudentTotalBill.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentTotalBill.Location = new Point(684, 513);
            StudentTotalBill.Name = "StudentTotalBill";
            StudentTotalBill.Size = new Size(69, 20);
            StudentTotalBill.TabIndex = 22;
            StudentTotalBill.Text = "4000 L.E";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(532, 513);
            label28.Name = "label28";
            label28.Size = new Size(139, 20);
            label28.TabIndex = 21;
            label28.Text = "All Students Bill = ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(StudentMax);
            groupBox4.Controls.Add(StudentMin);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(StudentFilter);
            groupBox4.Controls.Add(billCombo);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(35, 124);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(341, 211);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filters";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(7, 141);
            label26.Name = "label26";
            label26.Size = new Size(96, 20);
            label26.TabIndex = 23;
            label26.Text = "Bill by range";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(292, 142);
            button6.Name = "button6";
            button6.Size = new Size(35, 23);
            button6.TabIndex = 20;
            button6.Text = "OK";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(197, 146);
            label25.Name = "label25";
            label25.Size = new Size(31, 15);
            label25.TabIndex = 22;
            label25.Text = "Max";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(109, 147);
            label24.Name = "label24";
            label24.Size = new Size(28, 15);
            label24.TabIndex = 21;
            label24.Text = "Min";
            // 
            // StudentMax
            // 
            StudentMax.Location = new Point(234, 139);
            StudentMax.Name = "StudentMax";
            StudentMax.Size = new Size(48, 27);
            StudentMax.TabIndex = 20;
            // 
            // StudentMin
            // 
            StudentMin.Location = new Point(143, 138);
            StudentMin.Name = "StudentMin";
            StudentMin.Size = new Size(48, 27);
            StudentMin.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 38);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Filter by course";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(5, 69);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 18;
            label11.Text = "Filter by bill";
            // 
            // StudentFilter
            // 
            StudentFilter.FormattingEnabled = true;
            StudentFilter.Location = new Point(166, 33);
            StudentFilter.Name = "StudentFilter";
            StudentFilter.Size = new Size(121, 28);
            StudentFilter.TabIndex = 5;
            // 
            // billCombo
            // 
            billCombo.FormattingEnabled = true;
            billCombo.Location = new Point(166, 69);
            billCombo.Name = "billCombo";
            billCombo.Size = new Size(121, 28);
            billCombo.TabIndex = 17;
            // 
            // StudentBill
            // 
            StudentBill.BackColor = SystemColors.HotTrack;
            StudentBill.ForeColor = Color.White;
            StudentBill.Location = new Point(678, 571);
            StudentBill.Name = "StudentBill";
            StudentBill.Size = new Size(75, 23);
            StudentBill.TabIndex = 16;
            StudentBill.Text = "Pay";
            StudentBill.UseVisualStyleBackColor = false;
            StudentBill.Click += StudentBill_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(431, 575);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 15;
            label9.Text = "Bill";
            // 
            // BillText
            // 
            BillText.Location = new Point(515, 572);
            BillText.Name = "BillText";
            BillText.Size = new Size(100, 23);
            BillText.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(StudentUserName);
            groupBox1.Controls.Add(EditStudent);
            groupBox1.Controls.Add(AddStudent);
            groupBox1.Controls.Add(StudentName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(StudentPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(StudentAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 341);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 269);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add and Edit";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(43, 169);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 16;
            label10.Text = "User Name";
            // 
            // StudentUserName
            // 
            StudentUserName.Location = new Point(166, 169);
            StudentUserName.Name = "StudentUserName";
            StudentUserName.Size = new Size(121, 23);
            StudentUserName.TabIndex = 15;
            // 
            // EditStudent
            // 
            EditStudent.BackColor = SystemColors.HotTrack;
            EditStudent.ForeColor = Color.White;
            EditStudent.Location = new Point(191, 214);
            EditStudent.Name = "EditStudent";
            EditStudent.Size = new Size(75, 23);
            EditStudent.TabIndex = 14;
            EditStudent.Text = "Edit";
            EditStudent.UseVisualStyleBackColor = false;
            EditStudent.Click += EditStudent_Click;
            // 
            // AddStudent
            // 
            AddStudent.BackColor = SystemColors.HotTrack;
            AddStudent.ForeColor = Color.White;
            AddStudent.Location = new Point(34, 214);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(75, 23);
            AddStudent.TabIndex = 13;
            AddStudent.Text = "Add";
            AddStudent.UseVisualStyleBackColor = false;
            AddStudent.Click += AddStudent_Click;
            // 
            // StudentName
            // 
            StudentName.Location = new Point(166, 33);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(123, 23);
            StudentName.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 121);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 12;
            label8.Text = "Phone";
            // 
            // StudentPhone
            // 
            StudentPhone.Location = new Point(166, 121);
            StudentPhone.Name = "StudentPhone";
            StudentPhone.Size = new Size(121, 23);
            StudentPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 38);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 7;
            label5.Text = "Name";
            // 
            // StudentAddress
            // 
            StudentAddress.Location = new Point(166, 75);
            StudentAddress.Name = "StudentAddress";
            StudentAddress.Size = new Size(123, 23);
            StudentAddress.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(44, 78);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 281);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 11;
            // 
            // StudentReset
            // 
            StudentReset.BackColor = SystemColors.HotTrack;
            StudentReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentReset.ForeColor = Color.White;
            StudentReset.Location = new Point(431, 496);
            StudentReset.Name = "StudentReset";
            StudentReset.Size = new Size(75, 46);
            StudentReset.TabIndex = 3;
            StudentReset.Text = "Reset";
            StudentReset.UseVisualStyleBackColor = false;
            StudentReset.Click += StudentReset_Click;
            // 
            // StudentSearch
            // 
            StudentSearch.BackColor = SystemColors.HotTrack;
            StudentSearch.ForeColor = Color.White;
            StudentSearch.Location = new Point(703, 162);
            StudentSearch.Name = "StudentSearch";
            StudentSearch.Size = new Size(75, 23);
            StudentSearch.TabIndex = 2;
            StudentSearch.Text = "Search";
            StudentSearch.UseVisualStyleBackColor = false;
            StudentSearch.Click += StudentSearch_Click;
            // 
            // StudentSearchBar
            // 
            StudentSearchBar.Location = new Point(431, 163);
            StudentSearchBar.Name = "StudentSearchBar";
            StudentSearchBar.Size = new Size(153, 23);
            StudentSearchBar.TabIndex = 1;
            // 
            // StudentGrid
            // 
            StudentGrid.BackgroundColor = Color.White;
            StudentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGrid.Location = new Point(431, 216);
            StudentGrid.Name = "StudentGrid";
            StudentGrid.Size = new Size(347, 262);
            StudentGrid.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Controls.Add(label27);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 70);
            panel4.TabIndex = 23;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = SystemColors.HotTrack;
            label27.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.White;
            label27.Location = new Point(245, 10);
            label27.Name = "label27";
            label27.Size = new Size(250, 47);
            label27.TabIndex = 20;
            label27.Text = "Student Panle";
            // 
            // TrackTab
            // 
            TrackTab.BackColor = Color.White;
            TrackTab.Controls.Add(TrackNumbers);
            TrackTab.Controls.Add(groupBox5);
            TrackTab.Controls.Add(label2);
            TrackTab.Controls.Add(button2);
            TrackTab.Controls.Add(button1);
            TrackTab.Controls.Add(searchTrack);
            TrackTab.Controls.Add(TrackData);
            TrackTab.Controls.Add(panel5);
            TrackTab.Location = new Point(4, 24);
            TrackTab.Name = "TrackTab";
            TrackTab.Padding = new Padding(3);
            TrackTab.Size = new Size(805, 659);
            TrackTab.TabIndex = 2;
            TrackTab.Text = "Track";
            // 
            // TrackNumbers
            // 
            TrackNumbers.AutoSize = true;
            TrackNumbers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrackNumbers.Location = new Point(549, 498);
            TrackNumbers.Name = "TrackNumbers";
            TrackNumbers.Size = new Size(133, 20);
            TrackNumbers.TabIndex = 11;
            TrackNumbers.Text = "You have 4 Tracks";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(trackName);
            groupBox5.Controls.Add(button3);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(39, 259);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(314, 203);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Add and Edit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 77);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 6;
            label3.Text = "Track Name";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.ForeColor = Color.White;
            button4.Location = new Point(226, 135);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // trackName
            // 
            trackName.Location = new Point(119, 74);
            trackName.Multiline = true;
            trackName.Name = "trackName";
            trackName.Size = new Size(182, 29);
            trackName.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.ForeColor = Color.White;
            button3.Location = new Point(119, 135);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 31);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(410, 486);
            button2.Name = "button2";
            button2.Size = new Size(96, 45);
            button2.TabIndex = 3;
            button2.Text = "Reset Table";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.Location = new Point(662, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // searchTrack
            // 
            searchTrack.Location = new Point(410, 129);
            searchTrack.Name = "searchTrack";
            searchTrack.Size = new Size(195, 23);
            searchTrack.TabIndex = 1;
            // 
            // TrackData
            // 
            TrackData.BackgroundColor = Color.White;
            TrackData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TrackData.Location = new Point(410, 176);
            TrackData.Name = "TrackData";
            TrackData.Size = new Size(327, 286);
            TrackData.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Controls.Add(label29);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(799, 70);
            panel5.TabIndex = 12;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = SystemColors.HotTrack;
            label29.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.White;
            label29.Location = new Point(262, 11);
            label29.Name = "label29";
            label29.Size = new Size(208, 47);
            label29.TabIndex = 10;
            label29.Text = "Track Panle";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            TeacherTab.ResumeLayout(false);
            TeacherTab.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tdata).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            StudentTab.ResumeLayout(false);
            StudentTab.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentGrid).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            TrackTab.ResumeLayout(false);
            TrackTab.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackData).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button TeacherBtn;
        private Button StudentBtn;
        private Button TrackBtn;
        private TabControl tabControl1;
        private TabPage TeacherTab;
        private TabPage StudentTab;
        private TabPage TrackTab;
        private Panel panel2;
        private Label close;
        private Label label3;
        private TextBox trackName;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox searchTrack;
        private DataGridView TrackData;
        private Button button4;
        private Button button3;
        private Label label4;
        private Button StudentReset;
        private Button StudentSearch;
        private TextBox StudentSearchBar;
        private DataGridView StudentGrid;
        private Label label5;
        private TextBox StudentPhone;
        private ComboBox StudentFilter;
        private GroupBox groupBox1;
        private Button EditStudent;
        private Button AddStudent;
        private TextBox StudentName;
        private Label label8;
        private TextBox StudentAddress;
        private Label label6;
        private Label label7;
        private Button StudentBill;
        private Label label9;
        private TextBox BillText;
        private Label label10;
        private TextBox StudentUserName;
        private Label label11;
        private ComboBox billCombo;
        private DataGridView Tdata;
        private Button TresetBtn;
        private Button TsearchBtn;
        private TextBox Tsearch;
        private Label label13;
        private Label label12;
        private ComboBox Tearning;
        private ComboBox Tfilter;
        private GroupBox groupBox2;
        private TextBox Tbill;
        private Button TeditBtn;
        private Button TaddBtn;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox TuserName;
        private TextBox Taddress;
        private TextBox Tphone;
        private TextBox Tname;
        private Button TbillBtn;
        private Label label18;
        private Label label19;
        private GroupBox groupBox3;
        private Label label20;
        private Button button5;
        private Label label22;
        private Label label21;
        private TextBox Tmax;
        private TextBox Tmin;
        private Label TtotalBill;
        private Label label23;
        private GroupBox groupBox4;
        private Label label24;
        private TextBox StudentMax;
        private TextBox StudentMin;
        private Label label25;
        private Label label27;
        private Label label26;
        private Button button6;
        private Label StudentTotalBill;
        private Label label28;
        private Label TrackNumbers;
        private Label label29;
        private GroupBox groupBox5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ComboBox TcomboSearch;
        private ComboBox StudentComboSearch;
    }
}