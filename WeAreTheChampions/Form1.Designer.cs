
namespace WeAreTheChampions
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTeam1Name = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTeam1Score = new System.Windows.Forms.Label();
            this.lblTeam2Name = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTeam2Score = new System.Windows.Forms.Label();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnUpdateMatch = new System.Windows.Forms.Button();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpColors = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.lviColors = new System.Windows.Forms.ListView();
            this.tpPlayers = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbTransfer = new System.Windows.Forms.GroupBox();
            this.btnCancelTransfer = new System.Windows.Forms.Button();
            this.btnPlayerTransferSave = new System.Windows.Forms.Button();
            this.cboPlayerTransferTeam = new System.Windows.Forms.ComboBox();
            this.btnPlayerTransfer = new System.Windows.Forms.Button();
            this.txtSelectedPlayerTeam = new System.Windows.Forms.TextBox();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.txtSelectedPlayerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWillAddPlayerName = new System.Windows.Forms.TextBox();
            this.cboWillAddTeams = new System.Windows.Forms.ComboBox();
            this.txtWillAddPlayerPhotoPath = new System.Windows.Forms.TextBox();
            this.tpTeams = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvAwayMatches = new System.Windows.Forms.DataGridView();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvHomeMatches = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.lstTeamPlayers = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.lviWillAddTeamColors = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lviTeamColors = new System.Windows.Forms.ListView();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.pboFutbolArea = new System.Windows.Forms.PictureBox();
            this.pboSelectedPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.pboWillAddPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.pboTeamPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpMatches.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.tpColors.SuspendLayout();
            this.tpPlayers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbTransfer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpTeams.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayMatches)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeMatches)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFutbolArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedPlayerPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboWillAddPlayerPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboTeamPlayerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMatches);
            this.tabControl1.Controls.Add(this.tpColors);
            this.tabControl1.Controls.Add(this.tpPlayers);
            this.tabControl1.Controls.Add(this.tpTeams);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMatches
            // 
            this.tpMatches.Controls.Add(this.chkHide);
            this.tpMatches.Controls.Add(this.gbResult);
            this.tpMatches.Controls.Add(this.btnDeleteMatch);
            this.tpMatches.Controls.Add(this.btnUpdateMatch);
            this.tpMatches.Controls.Add(this.btnNewMatch);
            this.tpMatches.Controls.Add(this.dgvMatches);
            this.tpMatches.Location = new System.Drawing.Point(4, 22);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatches.Size = new System.Drawing.Size(961, 489);
            this.tpMatches.TabIndex = 0;
            this.tpMatches.Text = "Karşılaşmalar";
            this.tpMatches.UseVisualStyleBackColor = true;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.BackColor = System.Drawing.Color.Gray;
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Controls.Add(this.label11);
            this.gbResult.Controls.Add(this.pboFutbolArea);
            this.gbResult.Controls.Add(this.lblTeam1Name);
            this.gbResult.Controls.Add(this.label12);
            this.gbResult.Controls.Add(this.lblTeam1Score);
            this.gbResult.Controls.Add(this.lblTeam2Name);
            this.gbResult.Controls.Add(this.label14);
            this.gbResult.Controls.Add(this.lblTeam2Score);
            this.gbResult.Location = new System.Drawing.Point(90, 7);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(732, 238);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(245, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 26);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Sonuç:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(592, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 26);
            this.label11.TabIndex = 5;
            this.label11.Text = "Takım 2";
            // 
            // lblTeam1Name
            // 
            this.lblTeam1Name.AutoSize = true;
            this.lblTeam1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam1Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTeam1Name.Location = new System.Drawing.Point(12, 120);
            this.lblTeam1Name.Name = "lblTeam1Name";
            this.lblTeam1Name.Size = new System.Drawing.Size(83, 24);
            this.lblTeam1Name.TabIndex = 5;
            this.lblTeam1Name.Text = "Takım 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(44, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 26);
            this.label12.TabIndex = 5;
            this.label12.Text = "Takım 1";
            // 
            // lblTeam1Score
            // 
            this.lblTeam1Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTeam1Score.AutoSize = true;
            this.lblTeam1Score.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam1Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTeam1Score.Location = new System.Drawing.Point(328, 42);
            this.lblTeam1Score.Name = "lblTeam1Score";
            this.lblTeam1Score.Size = new System.Drawing.Size(21, 24);
            this.lblTeam1Score.TabIndex = 5;
            this.lblTeam1Score.Text = "0";
            // 
            // lblTeam2Name
            // 
            this.lblTeam2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeam2Name.AutoSize = true;
            this.lblTeam2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam2Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTeam2Name.Location = new System.Drawing.Point(593, 120);
            this.lblTeam2Name.Name = "lblTeam2Name";
            this.lblTeam2Name.Size = new System.Drawing.Size(83, 24);
            this.lblTeam2Name.TabIndex = 5;
            this.lblTeam2Name.Text = "Takım 2";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(355, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "-";
            // 
            // lblTeam2Score
            // 
            this.lblTeam2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTeam2Score.AutoSize = true;
            this.lblTeam2Score.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeam2Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTeam2Score.Location = new System.Drawing.Point(378, 42);
            this.lblTeam2Score.Name = "lblTeam2Score";
            this.lblTeam2Score.Size = new System.Drawing.Size(21, 24);
            this.lblTeam2Score.TabIndex = 5;
            this.lblTeam2Score.Text = "0";
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteMatch.Location = new System.Drawing.Point(103, 458);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMatch.TabIndex = 3;
            this.btnDeleteMatch.Text = "Seciliyi Sil";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // btnUpdateMatch
            // 
            this.btnUpdateMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateMatch.Location = new System.Drawing.Point(8, 458);
            this.btnUpdateMatch.Name = "btnUpdateMatch";
            this.btnUpdateMatch.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateMatch.TabIndex = 2;
            this.btnUpdateMatch.Text = "Seciliyi Düzenle";
            this.btnUpdateMatch.UseVisualStyleBackColor = true;
            this.btnUpdateMatch.Click += new System.EventHandler(this.btnUpdateMatch_Click);
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMatch.Location = new System.Drawing.Point(847, 7);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(108, 23);
            this.btnNewMatch.TabIndex = 1;
            this.btnNewMatch.Text = "+ Yeni Karsilasma";
            this.btnNewMatch.UseVisualStyleBackColor = true;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvMatches.Location = new System.Drawing.Point(8, 262);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(945, 190);
            this.dgvMatches.TabIndex = 0;
            this.dgvMatches.SelectionChanged += new System.EventHandler(this.dgvMatches_SelectionChanged);
            this.dgvMatches.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMatches_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Team1";
            this.Column1.HeaderText = "Takim";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Team2";
            this.Column2.HeaderText = "Takim";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Score1";
            this.Column4.HeaderText = "Home";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Result";
            this.Column5.HeaderText = "Sonuc";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Score2";
            this.Column6.HeaderText = "Away";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatchTime";
            this.Column3.HeaderText = "Tarih";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Team2Id";
            this.Column8.HeaderText = "Team2Id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Team1Id";
            this.Column9.HeaderText = "Team1Id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // tpColors
            // 
            this.tpColors.Controls.Add(this.label1);
            this.tpColors.Controls.Add(this.btnDeleteColor);
            this.tpColors.Controls.Add(this.btnAddColor);
            this.tpColors.Controls.Add(this.lviColors);
            this.tpColors.Location = new System.Drawing.Point(4, 22);
            this.tpColors.Name = "tpColors";
            this.tpColors.Padding = new System.Windows.Forms.Padding(3);
            this.tpColors.Size = new System.Drawing.Size(961, 489);
            this.tpColors.TabIndex = 1;
            this.tpColors.Text = "Renkler";
            this.tpColors.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Renk düzenlemek için seçili renge çift tıklayınız..";
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteColor.Location = new System.Drawing.Point(878, 35);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(74, 23);
            this.btnDeleteColor.TabIndex = 4;
            this.btnDeleteColor.Text = "Renk Sil";
            this.btnDeleteColor.UseVisualStyleBackColor = true;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddColor.Location = new System.Drawing.Point(878, 6);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(75, 23);
            this.btnAddColor.TabIndex = 1;
            this.btnAddColor.Text = "Renk Ekle";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // lviColors
            // 
            this.lviColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviColors.HideSelection = false;
            this.lviColors.Location = new System.Drawing.Point(8, 6);
            this.lviColors.Name = "lviColors";
            this.lviColors.Size = new System.Drawing.Size(864, 457);
            this.lviColors.TabIndex = 0;
            this.lviColors.UseCompatibleStateImageBehavior = false;
            this.lviColors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviColors_MouseDoubleClick);
            // 
            // tpPlayers
            // 
            this.tpPlayers.Controls.Add(this.groupBox3);
            this.tpPlayers.Controls.Add(this.groupBox2);
            this.tpPlayers.Controls.Add(this.groupBox1);
            this.tpPlayers.Location = new System.Drawing.Point(4, 22);
            this.tpPlayers.Name = "tpPlayers";
            this.tpPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlayers.Size = new System.Drawing.Size(961, 489);
            this.tpPlayers.TabIndex = 2;
            this.tpPlayers.Text = "Oyuncular";
            this.tpPlayers.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstPlayers);
            this.groupBox3.Controls.Add(this.cboTeams);
            this.groupBox3.Location = new System.Drawing.Point(9, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 465);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oyuncular";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Oyuncu düzenlemek için seçili oyuncuya çift tıklayınız..";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Takımlar:";
            // 
            // lstPlayers
            // 
            this.lstPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(6, 47);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(538, 381);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            this.lstPlayers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPlayers_MouseDoubleClick);
            // 
            // cboTeams
            // 
            this.cboTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(423, 19);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 2;
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gbTransfer);
            this.groupBox2.Controls.Add(this.btnPlayerTransfer);
            this.groupBox2.Controls.Add(this.txtSelectedPlayerTeam);
            this.groupBox2.Controls.Add(this.btnDeletePlayer);
            this.groupBox2.Controls.Add(this.txtSelectedPlayerName);
            this.groupBox2.Controls.Add(this.pboSelectedPlayerPhoto);
            this.groupBox2.Location = new System.Drawing.Point(565, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncu Bilgileri";
            // 
            // gbTransfer
            // 
            this.gbTransfer.Controls.Add(this.btnCancelTransfer);
            this.gbTransfer.Controls.Add(this.btnPlayerTransferSave);
            this.gbTransfer.Controls.Add(this.cboPlayerTransferTeam);
            this.gbTransfer.Location = new System.Drawing.Point(141, 74);
            this.gbTransfer.Name = "gbTransfer";
            this.gbTransfer.Size = new System.Drawing.Size(241, 83);
            this.gbTransfer.TabIndex = 6;
            this.gbTransfer.TabStop = false;
            this.gbTransfer.Text = "Transfer";
            this.gbTransfer.Visible = false;
            // 
            // btnCancelTransfer
            // 
            this.btnCancelTransfer.Location = new System.Drawing.Point(100, 56);
            this.btnCancelTransfer.Name = "btnCancelTransfer";
            this.btnCancelTransfer.Size = new System.Drawing.Size(49, 21);
            this.btnCancelTransfer.TabIndex = 7;
            this.btnCancelTransfer.Text = "İptal";
            this.btnCancelTransfer.UseVisualStyleBackColor = true;
            this.btnCancelTransfer.Click += new System.EventHandler(this.btnCancelTransfer_Click);
            // 
            // btnPlayerTransferSave
            // 
            this.btnPlayerTransferSave.Location = new System.Drawing.Point(155, 56);
            this.btnPlayerTransferSave.Name = "btnPlayerTransferSave";
            this.btnPlayerTransferSave.Size = new System.Drawing.Size(80, 21);
            this.btnPlayerTransferSave.TabIndex = 6;
            this.btnPlayerTransferSave.Text = "Transfer Et";
            this.btnPlayerTransferSave.UseVisualStyleBackColor = true;
            this.btnPlayerTransferSave.Click += new System.EventHandler(this.btnPlayerTransferSave_Click);
            // 
            // cboPlayerTransferTeam
            // 
            this.cboPlayerTransferTeam.FormattingEnabled = true;
            this.cboPlayerTransferTeam.Location = new System.Drawing.Point(6, 19);
            this.cboPlayerTransferTeam.Name = "cboPlayerTransferTeam";
            this.cboPlayerTransferTeam.Size = new System.Drawing.Size(230, 21);
            this.cboPlayerTransferTeam.TabIndex = 5;
            // 
            // btnPlayerTransfer
            // 
            this.btnPlayerTransfer.Location = new System.Drawing.Point(263, 163);
            this.btnPlayerTransfer.Name = "btnPlayerTransfer";
            this.btnPlayerTransfer.Size = new System.Drawing.Size(119, 23);
            this.btnPlayerTransfer.TabIndex = 0;
            this.btnPlayerTransfer.Text = "Oyuncuyu Transfer Et";
            this.btnPlayerTransfer.UseVisualStyleBackColor = true;
            this.btnPlayerTransfer.Click += new System.EventHandler(this.btnPlayerTransfer_Click);
            // 
            // txtSelectedPlayerTeam
            // 
            this.txtSelectedPlayerTeam.Enabled = false;
            this.txtSelectedPlayerTeam.Location = new System.Drawing.Point(138, 47);
            this.txtSelectedPlayerTeam.Name = "txtSelectedPlayerTeam";
            this.txtSelectedPlayerTeam.Size = new System.Drawing.Size(244, 20);
            this.txtSelectedPlayerTeam.TabIndex = 4;
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(138, 163);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(88, 23);
            this.btnDeletePlayer.TabIndex = 3;
            this.btnDeletePlayer.Text = "Oyuncuyu Sil";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // txtSelectedPlayerName
            // 
            this.txtSelectedPlayerName.Enabled = false;
            this.txtSelectedPlayerName.Location = new System.Drawing.Point(138, 20);
            this.txtSelectedPlayerName.Name = "txtSelectedPlayerName";
            this.txtSelectedPlayerName.Size = new System.Drawing.Size(244, 20);
            this.txtSelectedPlayerName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddPhoto);
            this.groupBox1.Controls.Add(this.btnAddPlayer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWillAddPlayerName);
            this.groupBox1.Controls.Add(this.cboWillAddTeams);
            this.groupBox1.Controls.Add(this.txtWillAddPlayerPhotoPath);
            this.groupBox1.Controls.Add(this.pboWillAddPlayerPhoto);
            this.groupBox1.Location = new System.Drawing.Point(565, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu Oluştur";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(335, 17);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(42, 23);
            this.btnAddPhoto.TabIndex = 5;
            this.btnAddPhoto.Text = "Yükle";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(279, 165);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(103, 23);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Oyuncuyu Oluştur";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eklenilecek Takım:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oyuncu Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fotoğraf Link:";
            // 
            // txtWillAddPlayerName
            // 
            this.txtWillAddPlayerName.Location = new System.Drawing.Point(241, 46);
            this.txtWillAddPlayerName.Name = "txtWillAddPlayerName";
            this.txtWillAddPlayerName.Size = new System.Drawing.Size(136, 20);
            this.txtWillAddPlayerName.TabIndex = 2;
            // 
            // cboWillAddTeams
            // 
            this.cboWillAddTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWillAddTeams.FormattingEnabled = true;
            this.cboWillAddTeams.Location = new System.Drawing.Point(241, 72);
            this.cboWillAddTeams.Name = "cboWillAddTeams";
            this.cboWillAddTeams.Size = new System.Drawing.Size(136, 21);
            this.cboWillAddTeams.TabIndex = 2;
            // 
            // txtWillAddPlayerPhotoPath
            // 
            this.txtWillAddPlayerPhotoPath.Location = new System.Drawing.Point(241, 20);
            this.txtWillAddPlayerPhotoPath.Name = "txtWillAddPlayerPhotoPath";
            this.txtWillAddPlayerPhotoPath.Size = new System.Drawing.Size(88, 20);
            this.txtWillAddPlayerPhotoPath.TabIndex = 0;
            // 
            // tpTeams
            // 
            this.tpTeams.Controls.Add(this.groupBox8);
            this.tpTeams.Controls.Add(this.groupBox7);
            this.tpTeams.Controls.Add(this.groupBox6);
            this.tpTeams.Controls.Add(this.groupBox5);
            this.tpTeams.Controls.Add(this.groupBox4);
            this.tpTeams.Location = new System.Drawing.Point(4, 22);
            this.tpTeams.Name = "tpTeams";
            this.tpTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeams.Size = new System.Drawing.Size(961, 489);
            this.tpTeams.TabIndex = 3;
            this.tpTeams.Text = "Takımlar";
            this.tpTeams.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.dgvAwayMatches);
            this.groupBox8.Location = new System.Drawing.Point(698, 203);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(255, 188);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Deplasman Maçları";
            // 
            // dgvAwayMatches
            // 
            this.dgvAwayMatches.AllowUserToAddRows = false;
            this.dgvAwayMatches.AllowUserToDeleteRows = false;
            this.dgvAwayMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAwayMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAwayMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwayMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27});
            this.dgvAwayMatches.Location = new System.Drawing.Point(6, 19);
            this.dgvAwayMatches.Name = "dgvAwayMatches";
            this.dgvAwayMatches.ReadOnly = true;
            this.dgvAwayMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAwayMatches.Size = new System.Drawing.Size(243, 163);
            this.dgvAwayMatches.TabIndex = 0;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "Id";
            this.Column19.HeaderText = "Id";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "MatchTime";
            this.Column20.HeaderText = "MatchTime";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "Score1";
            this.Column21.HeaderText = "Score1";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Visible = false;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "Score2";
            this.Column22.HeaderText = "Score2";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "Result";
            this.Column23.HeaderText = "Result";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Visible = false;
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "Team1Id";
            this.Column24.HeaderText = "Team1Id";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Visible = false;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "Team1";
            this.Column25.HeaderText = "Team1";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            // 
            // Column26
            // 
            this.Column26.DataPropertyName = "Team2Id";
            this.Column26.HeaderText = "Team2Id";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Visible = false;
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "Team2";
            this.Column27.HeaderText = "Team2";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgvHomeMatches);
            this.groupBox7.Location = new System.Drawing.Point(698, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 191);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ev Sahibi Maçları";
            // 
            // dgvHomeMatches
            // 
            this.dgvHomeMatches.AllowUserToAddRows = false;
            this.dgvHomeMatches.AllowUserToDeleteRows = false;
            this.dgvHomeMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHomeMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHomeMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dgvHomeMatches.Location = new System.Drawing.Point(6, 19);
            this.dgvHomeMatches.Name = "dgvHomeMatches";
            this.dgvHomeMatches.ReadOnly = true;
            this.dgvHomeMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomeMatches.Size = new System.Drawing.Size(243, 163);
            this.dgvHomeMatches.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Id";
            this.Column10.HeaderText = "Id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MatchTime";
            this.Column11.HeaderText = "MatchTime";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Score1";
            this.Column12.HeaderText = "Score1";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Score2";
            this.Column13.HeaderText = "Score2";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Result";
            this.Column14.HeaderText = "Result";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Team1Id";
            this.Column15.HeaderText = "Team1Id";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Team1";
            this.Column16.HeaderText = "Team1";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Team2Id";
            this.Column17.HeaderText = "Team2Id";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "Team2";
            this.Column18.HeaderText = "Team2";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.btnRemovePlayer);
            this.groupBox6.Controls.Add(this.pboTeamPlayerPhoto);
            this.groupBox6.Controls.Add(this.lstTeamPlayers);
            this.groupBox6.Location = new System.Drawing.Point(9, 200);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(274, 280);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Oyuncuları";
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemovePlayer.Location = new System.Drawing.Point(155, 233);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(113, 36);
            this.btnRemovePlayer.TabIndex = 2;
            this.btnRemovePlayer.Text = "Oyuncuyu Çıkar";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // lstTeamPlayers
            // 
            this.lstTeamPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeamPlayers.FormattingEnabled = true;
            this.lstTeamPlayers.Location = new System.Drawing.Point(7, 20);
            this.lstTeamPlayers.Name = "lstTeamPlayers";
            this.lstTeamPlayers.Size = new System.Drawing.Size(142, 238);
            this.lstTeamPlayers.TabIndex = 0;
            this.lstTeamPlayers.SelectedIndexChanged += new System.EventHandler(this.lstTeamPlayers_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCreateTeam);
            this.groupBox5.Controls.Add(this.lviWillAddTeamColors);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTeamName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(9, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 188);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Takım Oluşturma";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(9, 160);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(101, 23);
            this.btnCreateTeam.TabIndex = 4;
            this.btnCreateTeam.Text = "Takım Oluştur";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // lviWillAddTeamColors
            // 
            this.lviWillAddTeamColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviWillAddTeamColors.HideSelection = false;
            this.lviWillAddTeamColors.Location = new System.Drawing.Point(9, 64);
            this.lviWillAddTeamColors.Name = "lviWillAddTeamColors";
            this.lviWillAddTeamColors.Size = new System.Drawing.Size(259, 90);
            this.lviWillAddTeamColors.TabIndex = 3;
            this.lviWillAddTeamColors.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Renkler: Eklemek istediğiniz renkleri seçiniz.";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(69, 19);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(199, 20);
            this.txtTeamName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Takım Adı:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnUpdateTeam);
            this.groupBox4.Controls.Add(this.btnDeleteTeam);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lviTeamColors);
            this.groupBox4.Controls.Add(this.lstTeams);
            this.groupBox4.Location = new System.Drawing.Point(289, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 474);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Takımlar";
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateTeam.Location = new System.Drawing.Point(88, 445);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(93, 23);
            this.btnUpdateTeam.TabIndex = 4;
            this.btnUpdateTeam.Text = "Takım Düzenle";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTeam.Location = new System.Drawing.Point(7, 445);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTeam.TabIndex = 3;
            this.btnDeleteTeam.Text = "Takım Sil";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Renkleri:";
            // 
            // lviTeamColors
            // 
            this.lviTeamColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviTeamColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviTeamColors.HideSelection = false;
            this.lviTeamColors.Location = new System.Drawing.Point(205, 38);
            this.lviTeamColors.Name = "lviTeamColors";
            this.lviTeamColors.Size = new System.Drawing.Size(189, 388);
            this.lviTeamColors.TabIndex = 1;
            this.lviTeamColors.UseCompatibleStateImageBehavior = false;
            // 
            // lstTeams
            // 
            this.lstTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(7, 19);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(192, 407);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // chkHide
            // 
            this.chkHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHide.AutoSize = true;
            this.chkHide.Location = new System.Drawing.Point(818, 458);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(135, 17);
            this.chkHide.TabIndex = 7;
            this.chkHide.Text = "Oynanmış Maçları Gizle";
            this.chkHide.UseVisualStyleBackColor = true;
            this.chkHide.CheckedChanged += new System.EventHandler(this.chkHide_CheckedChanged);
            // 
            // pboFutbolArea
            // 
            this.pboFutbolArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pboFutbolArea.Image = global::WeAreTheChampions.Properties.Resources.futbolarea;
            this.pboFutbolArea.Location = new System.Drawing.Point(146, 83);
            this.pboFutbolArea.Name = "pboFutbolArea";
            this.pboFutbolArea.Size = new System.Drawing.Size(440, 145);
            this.pboFutbolArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFutbolArea.TabIndex = 4;
            this.pboFutbolArea.TabStop = false;
            // 
            // pboSelectedPlayerPhoto
            // 
            this.pboSelectedPlayerPhoto.Location = new System.Drawing.Point(7, 19);
            this.pboSelectedPlayerPhoto.Name = "pboSelectedPlayerPhoto";
            this.pboSelectedPlayerPhoto.Size = new System.Drawing.Size(125, 167);
            this.pboSelectedPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboSelectedPlayerPhoto.TabIndex = 1;
            this.pboSelectedPlayerPhoto.TabStop = false;
            // 
            // pboWillAddPlayerPhoto
            // 
            this.pboWillAddPlayerPhoto.Image = global::WeAreTheChampions.Properties.Resources.anonim;
            this.pboWillAddPlayerPhoto.Location = new System.Drawing.Point(7, 19);
            this.pboWillAddPlayerPhoto.Name = "pboWillAddPlayerPhoto";
            this.pboWillAddPlayerPhoto.Size = new System.Drawing.Size(125, 169);
            this.pboWillAddPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboWillAddPlayerPhoto.TabIndex = 1;
            this.pboWillAddPlayerPhoto.TabStop = false;
            // 
            // pboTeamPlayerPhoto
            // 
            this.pboTeamPlayerPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboTeamPlayerPhoto.Location = new System.Drawing.Point(155, 20);
            this.pboTeamPlayerPhoto.Name = "pboTeamPlayerPhoto";
            this.pboTeamPlayerPhoto.Size = new System.Drawing.Size(113, 118);
            this.pboTeamPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboTeamPlayerPhoto.TabIndex = 1;
            this.pboTeamPlayerPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "We Are The Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            this.tpMatches.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.tpColors.ResumeLayout(false);
            this.tpColors.PerformLayout();
            this.tpPlayers.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbTransfer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpTeams.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayMatches)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeMatches)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFutbolArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSelectedPlayerPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboWillAddPlayerPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboTeamPlayerPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.TabPage tpColors;
        private System.Windows.Forms.TabPage tpPlayers;
        private System.Windows.Forms.TabPage tpTeams;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.Button btnUpdateMatch;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.ListView lviColors;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlayerTransfer;
        private System.Windows.Forms.TextBox txtSelectedPlayerName;
        private System.Windows.Forms.PictureBox pboSelectedPlayerPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWillAddPlayerName;
        private System.Windows.Forms.ComboBox cboWillAddTeams;
        private System.Windows.Forms.TextBox txtWillAddPlayerPhotoPath;
        private System.Windows.Forms.PictureBox pboWillAddPlayerPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.TextBox txtSelectedPlayerTeam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.PictureBox pboTeamPlayerPhoto;
        private System.Windows.Forms.ListBox lstTeamPlayers;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lviTeamColors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lviWillAddTeamColors;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.DataGridView dgvAwayMatches;
        private System.Windows.Forms.DataGridView dgvHomeMatches;
        private System.Windows.Forms.ComboBox cboPlayerTransferTeam;
        private System.Windows.Forms.GroupBox gbTransfer;
        private System.Windows.Forms.Button btnPlayerTransferSave;
        private System.Windows.Forms.Button btnCancelTransfer;
        private System.Windows.Forms.PictureBox pboFutbolArea;
        private System.Windows.Forms.Label lblTeam1Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTeam2Name;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTeam2Score;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTeam1Score;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.CheckBox chkHide;
    }
}

