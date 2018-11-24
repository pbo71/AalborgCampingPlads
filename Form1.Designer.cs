namespace WindowsFormsAalborgCamping
{
	partial class Form1
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelTentPlace = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelSmallCabin = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelBigCabin = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelLuxuryCabin = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelAdults = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelKids = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCheckIn = new System.Windows.Forms.Button();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.groupBoxFamilie = new System.Windows.Forms.GroupBox();
			this.txtBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxAnimal = new System.Windows.Forms.CheckBox();
			this.numericUpDownKids = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAdult = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.labelAntalVokse = new System.Windows.Forms.Label();
			this.groupBoxCabinTent = new System.Windows.Forms.GroupBox();
			this.numericUpDownTent = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownLuxuryCabin = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownBigCabin = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSmallCabin = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.radioBtnLuxuryCabin = new System.Windows.Forms.RadioButton();
			this.radioBtnBigCabin = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.radioBtnSmallCabin = new System.Windows.Forms.RadioButton();
			this.radioBtnTentPlace = new System.Windows.Forms.RadioButton();
			this.btnAsk = new System.Windows.Forms.Button();
			this.btnStatus = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBoxFamilie.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownKids)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdult)).BeginInit();
			this.groupBoxCabinTent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLuxuryCabin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBigCabin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmallCabin)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTentPlace,
            this.toolStripStatusLabelSmallCabin,
            this.toolStripStatusLabelBigCabin,
            this.toolStripStatusLabelLuxuryCabin,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelAdults,
            this.toolStripStatusLabelKids});
			this.statusStrip1.Location = new System.Drawing.Point(0, 452);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelTentPlace
			// 
			this.toolStripStatusLabelTentPlace.Name = "toolStripStatusLabelTentPlace";
			this.toolStripStatusLabelTentPlace.Size = new System.Drawing.Size(129, 17);
			this.toolStripStatusLabelTentPlace.Text = "Antal Ledige teltplader:";
			// 
			// toolStripStatusLabelSmallCabin
			// 
			this.toolStripStatusLabelSmallCabin.Name = "toolStripStatusLabelSmallCabin";
			this.toolStripStatusLabelSmallCabin.Size = new System.Drawing.Size(132, 17);
			this.toolStripStatusLabelSmallCabin.Text = "Antal ledige små hytter:";
			// 
			// toolStripStatusLabelBigCabin
			// 
			this.toolStripStatusLabelBigCabin.Name = "toolStripStatusLabelBigCabin";
			this.toolStripStatusLabelBigCabin.Size = new System.Drawing.Size(136, 17);
			this.toolStripStatusLabelBigCabin.Text = "Antal ledige store hytter:";
			// 
			// toolStripStatusLabelLuxuryCabin
			// 
			this.toolStripStatusLabelLuxuryCabin.Name = "toolStripStatusLabelLuxuryCabin";
			this.toolStripStatusLabelLuxuryCabin.Size = new System.Drawing.Size(143, 17);
			this.toolStripStatusLabelLuxuryCabin.Text = "Antal ledige luksus hytter:";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabelAdults
			// 
			this.toolStripStatusLabelAdults.Name = "toolStripStatusLabelAdults";
			this.toolStripStatusLabelAdults.Size = new System.Drawing.Size(78, 17);
			this.toolStripStatusLabelAdults.Text = "Antal voksne:";
			// 
			// toolStripStatusLabelKids
			// 
			this.toolStripStatusLabelKids.Name = "toolStripStatusLabelKids";
			this.toolStripStatusLabelKids.Size = new System.Drawing.Size(66, 17);
			this.toolStripStatusLabelKids.Text = "Antal Børn:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// omToolStripMenuItem
			// 
			this.omToolStripMenuItem.Name = "omToolStripMenuItem";
			this.omToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			this.omToolStripMenuItem.Text = "Om";
			this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
			// 
			// btnCheckIn
			// 
			this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckIn.Location = new System.Drawing.Point(16, 311);
			this.btnCheckIn.Name = "btnCheckIn";
			this.btnCheckIn.Size = new System.Drawing.Size(128, 46);
			this.btnCheckIn.TabIndex = 3;
			this.btnCheckIn.Text = "Tilføj reservation";
			this.btnCheckIn.UseVisualStyleBackColor = true;
			this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckOut.Location = new System.Drawing.Point(150, 311);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(127, 46);
			this.btnCheckOut.TabIndex = 14;
			this.btnCheckOut.Text = "Annullere reservation";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
			// 
			// groupBoxFamilie
			// 
			this.groupBoxFamilie.Controls.Add(this.txtBoxName);
			this.groupBoxFamilie.Controls.Add(this.label1);
			this.groupBoxFamilie.Controls.Add(this.checkBoxAnimal);
			this.groupBoxFamilie.Controls.Add(this.numericUpDownKids);
			this.groupBoxFamilie.Controls.Add(this.numericUpDownAdult);
			this.groupBoxFamilie.Controls.Add(this.label2);
			this.groupBoxFamilie.Controls.Add(this.labelAntalVokse);
			this.groupBoxFamilie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxFamilie.Location = new System.Drawing.Point(16, 16);
			this.groupBoxFamilie.Name = "groupBoxFamilie";
			this.groupBoxFamilie.Size = new System.Drawing.Size(396, 97);
			this.groupBoxFamilie.TabIndex = 3;
			this.groupBoxFamilie.TabStop = false;
			this.groupBoxFamilie.Text = "Familie";
			// 
			// txtBoxName
			// 
			this.txtBoxName.Location = new System.Drawing.Point(54, 20);
			this.txtBoxName.Name = "txtBoxName";
			this.txtBoxName.Size = new System.Drawing.Size(336, 21);
			this.txtBoxName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Navn";
			// 
			// checkBoxAnimal
			// 
			this.checkBoxAnimal.AutoSize = true;
			this.checkBoxAnimal.Location = new System.Drawing.Point(311, 55);
			this.checkBoxAnimal.Name = "checkBoxAnimal";
			this.checkBoxAnimal.Size = new System.Drawing.Size(70, 19);
			this.checkBoxAnimal.TabIndex = 4;
			this.checkBoxAnimal.Text = "Husdyr";
			this.checkBoxAnimal.UseVisualStyleBackColor = true;
			// 
			// numericUpDownKids
			// 
			this.numericUpDownKids.Location = new System.Drawing.Point(239, 55);
			this.numericUpDownKids.Name = "numericUpDownKids";
			this.numericUpDownKids.Size = new System.Drawing.Size(53, 21);
			this.numericUpDownKids.TabIndex = 3;
			// 
			// numericUpDownAdult
			// 
			this.numericUpDownAdult.Location = new System.Drawing.Point(101, 55);
			this.numericUpDownAdult.Name = "numericUpDownAdult";
			this.numericUpDownAdult.Size = new System.Drawing.Size(53, 21);
			this.numericUpDownAdult.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Antal Børn";
			// 
			// labelAntalVokse
			// 
			this.labelAntalVokse.AutoSize = true;
			this.labelAntalVokse.Location = new System.Drawing.Point(6, 57);
			this.labelAntalVokse.Name = "labelAntalVokse";
			this.labelAntalVokse.Size = new System.Drawing.Size(89, 15);
			this.labelAntalVokse.TabIndex = 0;
			this.labelAntalVokse.Text = "Antal Voksne";
			// 
			// groupBoxCabinTent
			// 
			this.groupBoxCabinTent.Controls.Add(this.numericUpDownTent);
			this.groupBoxCabinTent.Controls.Add(this.numericUpDownLuxuryCabin);
			this.groupBoxCabinTent.Controls.Add(this.numericUpDownBigCabin);
			this.groupBoxCabinTent.Controls.Add(this.numericUpDownSmallCabin);
			this.groupBoxCabinTent.Controls.Add(this.label6);
			this.groupBoxCabinTent.Controls.Add(this.label5);
			this.groupBoxCabinTent.Controls.Add(this.label4);
			this.groupBoxCabinTent.Controls.Add(this.radioBtnLuxuryCabin);
			this.groupBoxCabinTent.Controls.Add(this.radioBtnBigCabin);
			this.groupBoxCabinTent.Controls.Add(this.label3);
			this.groupBoxCabinTent.Controls.Add(this.radioBtnSmallCabin);
			this.groupBoxCabinTent.Controls.Add(this.radioBtnTentPlace);
			this.groupBoxCabinTent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxCabinTent.Location = new System.Drawing.Point(16, 119);
			this.groupBoxCabinTent.Name = "groupBoxCabinTent";
			this.groupBoxCabinTent.Size = new System.Drawing.Size(396, 163);
			this.groupBoxCabinTent.TabIndex = 5;
			this.groupBoxCabinTent.TabStop = false;
			this.groupBoxCabinTent.Text = "Hytte / Teltplads";
			// 
			// numericUpDownTent
			// 
			this.numericUpDownTent.Location = new System.Drawing.Point(125, 37);
			this.numericUpDownTent.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numericUpDownTent.Name = "numericUpDownTent";
			this.numericUpDownTent.Size = new System.Drawing.Size(53, 21);
			this.numericUpDownTent.TabIndex = 6;
			this.numericUpDownTent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownLuxuryCabin
			// 
			this.numericUpDownLuxuryCabin.Enabled = false;
			this.numericUpDownLuxuryCabin.Location = new System.Drawing.Point(125, 116);
			this.numericUpDownLuxuryCabin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownLuxuryCabin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownLuxuryCabin.Name = "numericUpDownLuxuryCabin";
			this.numericUpDownLuxuryCabin.Size = new System.Drawing.Size(53, 21);
			this.numericUpDownLuxuryCabin.TabIndex = 12;
			this.numericUpDownLuxuryCabin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownBigCabin
			// 
			this.numericUpDownBigCabin.Enabled = false;
			this.numericUpDownBigCabin.Location = new System.Drawing.Point(125, 93);
			this.numericUpDownBigCabin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDownBigCabin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownBigCabin.Name = "numericUpDownBigCabin";
			this.numericUpDownBigCabin.Size = new System.Drawing.Size(53, 21);
			this.numericUpDownBigCabin.TabIndex = 10;
			this.numericUpDownBigCabin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownSmallCabin
			// 
			this.numericUpDownSmallCabin.Enabled = false;
			this.numericUpDownSmallCabin.Location = new System.Drawing.Point(125, 69);
			this.numericUpDownSmallCabin.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numericUpDownSmallCabin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownSmallCabin.Name = "numericUpDownSmallCabin";
			this.numericUpDownSmallCabin.Size = new System.Drawing.Size(53, 21);
			this.numericUpDownSmallCabin.TabIndex = 8;
			this.numericUpDownSmallCabin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(184, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Hytte nummer 1 eller 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(184, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 15);
			this.label5.TabIndex = 13;
			this.label5.Text = "Hytte nummer 1-5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(184, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "Hytte nummer 1-8";
			// 
			// radioBtnLuxuryCabin
			// 
			this.radioBtnLuxuryCabin.AutoSize = true;
			this.radioBtnLuxuryCabin.Location = new System.Drawing.Point(12, 116);
			this.radioBtnLuxuryCabin.Name = "radioBtnLuxuryCabin";
			this.radioBtnLuxuryCabin.Size = new System.Drawing.Size(104, 19);
			this.radioBtnLuxuryCabin.TabIndex = 11;
			this.radioBtnLuxuryCabin.Text = "Luksus hytte";
			this.radioBtnLuxuryCabin.UseVisualStyleBackColor = true;
			this.radioBtnLuxuryCabin.Click += new System.EventHandler(this.radioBtnLuxuryCabin_Click);
			// 
			// radioBtnBigCabin
			// 
			this.radioBtnBigCabin.AutoSize = true;
			this.radioBtnBigCabin.Location = new System.Drawing.Point(12, 93);
			this.radioBtnBigCabin.Name = "radioBtnBigCabin";
			this.radioBtnBigCabin.Size = new System.Drawing.Size(85, 19);
			this.radioBtnBigCabin.TabIndex = 9;
			this.radioBtnBigCabin.Text = "Stor hytte";
			this.radioBtnBigCabin.UseVisualStyleBackColor = true;
			this.radioBtnBigCabin.Click += new System.EventHandler(this.radioBtnBigCabin_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(184, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Plads nummer 1 - 130";
			// 
			// radioBtnSmallCabin
			// 
			this.radioBtnSmallCabin.AutoSize = true;
			this.radioBtnSmallCabin.Location = new System.Drawing.Point(12, 69);
			this.radioBtnSmallCabin.Name = "radioBtnSmallCabin";
			this.radioBtnSmallCabin.Size = new System.Drawing.Size(91, 19);
			this.radioBtnSmallCabin.TabIndex = 7;
			this.radioBtnSmallCabin.Text = "Lille hytte ";
			this.radioBtnSmallCabin.UseVisualStyleBackColor = true;
			this.radioBtnSmallCabin.Click += new System.EventHandler(this.radioBtnSmallCabin_Click);
			// 
			// radioBtnTentPlace
			// 
			this.radioBtnTentPlace.AutoSize = true;
			this.radioBtnTentPlace.Checked = true;
			this.radioBtnTentPlace.Location = new System.Drawing.Point(12, 37);
			this.radioBtnTentPlace.Name = "radioBtnTentPlace";
			this.radioBtnTentPlace.Size = new System.Drawing.Size(89, 19);
			this.radioBtnTentPlace.TabIndex = 5;
			this.radioBtnTentPlace.TabStop = true;
			this.radioBtnTentPlace.Text = "Telt Plads";
			this.radioBtnTentPlace.UseVisualStyleBackColor = true;
			this.radioBtnTentPlace.Click += new System.EventHandler(this.radioBtnTentPlace_Click);
			// 
			// btnAsk
			// 
			this.btnAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsk.Location = new System.Drawing.Point(285, 311);
			this.btnAsk.Name = "btnAsk";
			this.btnAsk.Size = new System.Drawing.Size(127, 46);
			this.btnAsk.TabIndex = 15;
			this.btnAsk.Text = "Forespørgelse på plads / hytte";
			this.btnAsk.UseVisualStyleBackColor = true;
			this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
			// 
			// btnStatus
			// 
			this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatus.Location = new System.Drawing.Point(654, 311);
			this.btnStatus.Name = "btnStatus";
			this.btnStatus.Size = new System.Drawing.Size(115, 46);
			this.btnStatus.TabIndex = 16;
			this.btnStatus.Text = "Vis alle reservationer";
			this.btnStatus.UseVisualStyleBackColor = true;
			this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 40);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1025, 406);
			this.tabControl1.TabIndex = 17;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.groupBoxFamilie);
			this.tabPage1.Controls.Add(this.btnStatus);
			this.tabPage1.Controls.Add(this.btnCheckIn);
			this.tabPage1.Controls.Add(this.btnAsk);
			this.tabPage1.Controls.Add(this.btnCheckOut);
			this.tabPage1.Controls.Add(this.groupBoxCabinTent);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1017, 380);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Reservation";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(418, 31);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(580, 251);
			this.listView1.TabIndex = 18;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1017, 380);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "KasseApperat";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 474);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Aalborg Campingplads";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxFamilie.ResumeLayout(false);
			this.groupBoxFamilie.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownKids)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdult)).EndInit();
			this.groupBoxCabinTent.ResumeLayout(false);
			this.groupBoxCabinTent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLuxuryCabin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBigCabin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmallCabin)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
		private System.Windows.Forms.Button btnCheckIn;
		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.GroupBox groupBoxFamilie;
		private System.Windows.Forms.NumericUpDown numericUpDownAdult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAntalVokse;
		private System.Windows.Forms.GroupBox groupBoxCabinTent;
		private System.Windows.Forms.TextBox txtBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxAnimal;
		private System.Windows.Forms.NumericUpDown numericUpDownKids;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioBtnLuxuryCabin;
		private System.Windows.Forms.RadioButton radioBtnBigCabin;
		private System.Windows.Forms.RadioButton radioBtnSmallCabin;
		private System.Windows.Forms.RadioButton radioBtnTentPlace;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTentPlace;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSmallCabin;
		private System.Windows.Forms.Button btnAsk;
		private System.Windows.Forms.Button btnStatus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownTent;
		private System.Windows.Forms.NumericUpDown numericUpDownLuxuryCabin;
		private System.Windows.Forms.NumericUpDown numericUpDownBigCabin;
		private System.Windows.Forms.NumericUpDown numericUpDownSmallCabin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBigCabin;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLuxuryCabin;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAdults;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelKids;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView listView1;
	}
}

