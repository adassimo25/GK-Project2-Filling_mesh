namespace Project2_Filling_mesh
{
    partial class ProjectForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelObjectColor = new System.Windows.Forms.Label();
            this.ocTextureLoad = new System.Windows.Forms.Button();
            this.objectColorConstant = new System.Windows.Forms.RadioButton();
            this.objectColorTexture = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.meshVisible = new System.Windows.Forms.CheckBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutFactorsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarKS = new System.Windows.Forms.TrackBar();
            this.trackBarKD = new System.Windows.Forms.TrackBar();
            this.labelKS = new System.Windows.Forms.Label();
            this.labKD = new System.Windows.Forms.Label();
            this.labM = new System.Windows.Forms.Label();
            this.trackBarM = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelWave = new System.Windows.Forms.TableLayoutPanel();
            this.normalVectorWave = new System.Windows.Forms.RadioButton();
            this.trackBarWave = new System.Windows.Forms.TrackBar();
            this.nvTextureLoad = new System.Windows.Forms.Button();
            this.normalVectorConstant = new System.Windows.Forms.RadioButton();
            this.normalVectorTexture = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lightVersorSpiral = new System.Windows.Forms.RadioButton();
            this.lightVersorConstant = new System.Windows.Forms.RadioButton();
            this.labelLightVersor = new System.Windows.Forms.Label();
            this.labelLightColor = new System.Windows.Forms.Label();
            this.labelLightColorText = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fillingInterpolation = new System.Windows.Forms.RadioButton();
            this.fillingPrecision = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dynamicRefresh = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutFactorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarM)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanelWave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWave)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1178, 776);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(153, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1022, 770);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 770);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelObjectColor);
            this.groupBox5.Controls.Add(this.ocTextureLoad);
            this.groupBox5.Controls.Add(this.objectColorConstant);
            this.groupBox5.Controls.Add(this.objectColorTexture);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox5.Location = new System.Drawing.Point(3, 501);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 105);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Object color";
            // 
            // labelObjectColor
            // 
            this.labelObjectColor.AutoSize = true;
            this.labelObjectColor.BackColor = System.Drawing.Color.White;
            this.labelObjectColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelObjectColor.Location = new System.Drawing.Point(98, 78);
            this.labelObjectColor.MaximumSize = new System.Drawing.Size(25, 25);
            this.labelObjectColor.MinimumSize = new System.Drawing.Size(25, 25);
            this.labelObjectColor.Name = "labelObjectColor";
            this.labelObjectColor.Size = new System.Drawing.Size(25, 25);
            this.labelObjectColor.TabIndex = 3;
            this.labelObjectColor.Click += new System.EventHandler(this.labelObjectColor_Click);
            // 
            // ocTextureLoad
            // 
            this.ocTextureLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ocTextureLoad.Location = new System.Drawing.Point(60, 49);
            this.ocTextureLoad.Name = "ocTextureLoad";
            this.ocTextureLoad.Size = new System.Drawing.Size(75, 23);
            this.ocTextureLoad.TabIndex = 2;
            this.ocTextureLoad.TabStop = false;
            this.ocTextureLoad.Text = "Load";
            this.ocTextureLoad.UseVisualStyleBackColor = true;
            this.ocTextureLoad.Click += new System.EventHandler(this.ocTextureLoad_Click);
            // 
            // objectColorConstant
            // 
            this.objectColorConstant.AutoSize = true;
            this.objectColorConstant.Location = new System.Drawing.Point(9, 78);
            this.objectColorConstant.Name = "objectColorConstant";
            this.objectColorConstant.Size = new System.Drawing.Size(83, 21);
            this.objectColorConstant.TabIndex = 1;
            this.objectColorConstant.Text = "constant";
            this.objectColorConstant.UseVisualStyleBackColor = true;
            // 
            // objectColorTexture
            // 
            this.objectColorTexture.AutoSize = true;
            this.objectColorTexture.Checked = true;
            this.objectColorTexture.Location = new System.Drawing.Point(9, 22);
            this.objectColorTexture.Name = "objectColorTexture";
            this.objectColorTexture.Size = new System.Drawing.Size(72, 21);
            this.objectColorTexture.TabIndex = 0;
            this.objectColorTexture.TabStop = true;
            this.objectColorTexture.Text = "texture";
            this.objectColorTexture.UseVisualStyleBackColor = true;
            this.objectColorTexture.CheckedChanged += new System.EventHandler(this.objectColorTexture_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.meshVisible);
            this.groupBox1.Controls.Add(this.labelN);
            this.groupBox1.Controls.Add(this.labelM);
            this.groupBox1.Controls.Add(this.numericUpDownM);
            this.groupBox1.Controls.Add(this.numericUpDownN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesh";
            // 
            // meshVisible
            // 
            this.meshVisible.AutoSize = true;
            this.meshVisible.Checked = true;
            this.meshVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.meshVisible.Location = new System.Drawing.Point(9, 81);
            this.meshVisible.Name = "meshVisible";
            this.meshVisible.Size = new System.Drawing.Size(73, 21);
            this.meshVisible.TabIndex = 8;
            this.meshVisible.Text = " visible";
            this.meshVisible.UseVisualStyleBackColor = true;
            this.meshVisible.CheckedChanged += new System.EventHandler(this.meshVisible_CheckedChanged);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(21, 56);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(22, 17);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "N:";
            this.labelN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(21, 27);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(23, 17);
            this.labelM.TabIndex = 6;
            this.labelM.Text = "M:";
            this.labelM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownM.Location = new System.Drawing.Point(49, 22);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(74, 26);
            this.numericUpDownM.TabIndex = 5;
            this.numericUpDownM.TabStop = false;
            this.numericUpDownM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.numericUpDownM_ValueChanged);
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownN.Location = new System.Drawing.Point(49, 51);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(74, 26);
            this.numericUpDownN.TabIndex = 4;
            this.numericUpDownN.TabStop = false;
            this.numericUpDownN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutFactorsPanel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(3, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factors";
            // 
            // tableLayoutFactorsPanel
            // 
            this.tableLayoutFactorsPanel.ColumnCount = 2;
            this.tableLayoutFactorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutFactorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutFactorsPanel.Controls.Add(this.trackBarKS, 1, 0);
            this.tableLayoutFactorsPanel.Controls.Add(this.trackBarKD, 1, 1);
            this.tableLayoutFactorsPanel.Controls.Add(this.labelKS, 0, 0);
            this.tableLayoutFactorsPanel.Controls.Add(this.labKD, 0, 1);
            this.tableLayoutFactorsPanel.Controls.Add(this.labM, 0, 2);
            this.tableLayoutFactorsPanel.Controls.Add(this.trackBarM, 1, 2);
            this.tableLayoutFactorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFactorsPanel.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutFactorsPanel.Name = "tableLayoutFactorsPanel";
            this.tableLayoutFactorsPanel.RowCount = 3;
            this.tableLayoutFactorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutFactorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutFactorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutFactorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFactorsPanel.Size = new System.Drawing.Size(132, 91);
            this.tableLayoutFactorsPanel.TabIndex = 0;
            // 
            // trackBarKS
            // 
            this.trackBarKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarKS.Location = new System.Drawing.Point(33, 3);
            this.trackBarKS.Maximum = 1000;
            this.trackBarKS.Name = "trackBarKS";
            this.trackBarKS.Size = new System.Drawing.Size(104, 24);
            this.trackBarKS.TabIndex = 0;
            this.trackBarKS.TabStop = false;
            this.trackBarKS.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarKS.Value = 500;
            this.trackBarKS.Scroll += new System.EventHandler(this.trackBarKS_Scroll);
            // 
            // trackBarKD
            // 
            this.trackBarKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarKD.Location = new System.Drawing.Point(33, 33);
            this.trackBarKD.Maximum = 1000;
            this.trackBarKD.Name = "trackBarKD";
            this.trackBarKD.Size = new System.Drawing.Size(104, 24);
            this.trackBarKD.TabIndex = 1;
            this.trackBarKD.TabStop = false;
            this.trackBarKD.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarKD.Value = 750;
            this.trackBarKD.Scroll += new System.EventHandler(this.trackBarKD_Scroll);
            // 
            // labelKS
            // 
            this.labelKS.AutoSize = true;
            this.labelKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelKS.Location = new System.Drawing.Point(3, 0);
            this.labelKS.Name = "labelKS";
            this.labelKS.Size = new System.Drawing.Size(24, 30);
            this.labelKS.TabIndex = 3;
            this.labelKS.Text = "k{s}";
            this.labelKS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labKD
            // 
            this.labKD.AutoSize = true;
            this.labKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labKD.Location = new System.Drawing.Point(3, 30);
            this.labKD.Name = "labKD";
            this.labKD.Size = new System.Drawing.Size(24, 30);
            this.labKD.TabIndex = 4;
            this.labKD.Text = "k{d}";
            this.labKD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labM
            // 
            this.labM.AutoSize = true;
            this.labM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labM.Location = new System.Drawing.Point(3, 60);
            this.labM.Name = "labM";
            this.labM.Size = new System.Drawing.Size(24, 31);
            this.labM.TabIndex = 5;
            this.labM.Text = "m";
            this.labM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarM
            // 
            this.trackBarM.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarM.Location = new System.Drawing.Point(33, 63);
            this.trackBarM.Maximum = 100;
            this.trackBarM.Minimum = 1;
            this.trackBarM.Name = "trackBarM";
            this.trackBarM.Size = new System.Drawing.Size(104, 25);
            this.trackBarM.TabIndex = 6;
            this.trackBarM.TabStop = false;
            this.trackBarM.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarM.Value = 25;
            this.trackBarM.Scroll += new System.EventHandler(this.trackBarM_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanelWave);
            this.groupBox3.Controls.Add(this.nvTextureLoad);
            this.groupBox3.Controls.Add(this.normalVectorConstant);
            this.groupBox3.Controls.Add(this.normalVectorTexture);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox3.Location = new System.Drawing.Point(3, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Normal vector";
            // 
            // tableLayoutPanelWave
            // 
            this.tableLayoutPanelWave.ColumnCount = 1;
            this.tableLayoutPanelWave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelWave.Controls.Add(this.normalVectorWave, 0, 0);
            this.tableLayoutPanelWave.Controls.Add(this.trackBarWave, 0, 1);
            this.tableLayoutPanelWave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelWave.Location = new System.Drawing.Point(3, 97);
            this.tableLayoutPanelWave.Name = "tableLayoutPanelWave";
            this.tableLayoutPanelWave.RowCount = 2;
            this.tableLayoutPanelWave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelWave.Size = new System.Drawing.Size(132, 51);
            this.tableLayoutPanelWave.TabIndex = 5;
            // 
            // normalVectorWave
            // 
            this.normalVectorWave.AutoSize = true;
            this.normalVectorWave.Location = new System.Drawing.Point(3, 3);
            this.normalVectorWave.Name = "normalVectorWave";
            this.normalVectorWave.Size = new System.Drawing.Size(61, 19);
            this.normalVectorWave.TabIndex = 3;
            this.normalVectorWave.TabStop = true;
            this.normalVectorWave.Text = "wave";
            this.normalVectorWave.UseVisualStyleBackColor = true;
            this.normalVectorWave.CheckedChanged += new System.EventHandler(this.normalVectorWave_CheckedChanged);
            // 
            // trackBarWave
            // 
            this.trackBarWave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarWave.Location = new System.Drawing.Point(3, 28);
            this.trackBarWave.Maximum = 100;
            this.trackBarWave.Minimum = 1;
            this.trackBarWave.Name = "trackBarWave";
            this.trackBarWave.Size = new System.Drawing.Size(126, 20);
            this.trackBarWave.TabIndex = 4;
            this.trackBarWave.TabStop = false;
            this.trackBarWave.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarWave.Value = 5;
            this.trackBarWave.Scroll += new System.EventHandler(this.trackBarWave_Scroll);
            // 
            // nvTextureLoad
            // 
            this.nvTextureLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nvTextureLoad.Location = new System.Drawing.Point(63, 49);
            this.nvTextureLoad.Name = "nvTextureLoad";
            this.nvTextureLoad.Size = new System.Drawing.Size(75, 23);
            this.nvTextureLoad.TabIndex = 2;
            this.nvTextureLoad.TabStop = false;
            this.nvTextureLoad.Text = "Load";
            this.nvTextureLoad.UseVisualStyleBackColor = true;
            this.nvTextureLoad.Click += new System.EventHandler(this.nvTextureLoad_Click);
            // 
            // normalVectorConstant
            // 
            this.normalVectorConstant.AutoSize = true;
            this.normalVectorConstant.Location = new System.Drawing.Point(6, 73);
            this.normalVectorConstant.Name = "normalVectorConstant";
            this.normalVectorConstant.Size = new System.Drawing.Size(83, 21);
            this.normalVectorConstant.TabIndex = 1;
            this.normalVectorConstant.Text = "constant";
            this.normalVectorConstant.UseVisualStyleBackColor = true;
            this.normalVectorConstant.CheckedChanged += new System.EventHandler(this.normalVectorConstant_CheckedChanged);
            // 
            // normalVectorTexture
            // 
            this.normalVectorTexture.AutoSize = true;
            this.normalVectorTexture.Checked = true;
            this.normalVectorTexture.Location = new System.Drawing.Point(6, 22);
            this.normalVectorTexture.Name = "normalVectorTexture";
            this.normalVectorTexture.Size = new System.Drawing.Size(72, 21);
            this.normalVectorTexture.TabIndex = 0;
            this.normalVectorTexture.TabStop = true;
            this.normalVectorTexture.Text = "texture";
            this.normalVectorTexture.UseVisualStyleBackColor = true;
            this.normalVectorTexture.CheckedChanged += new System.EventHandler(this.normalVectorTexture_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lightVersorSpiral);
            this.groupBox4.Controls.Add(this.lightVersorConstant);
            this.groupBox4.Controls.Add(this.labelLightVersor);
            this.groupBox4.Controls.Add(this.labelLightColor);
            this.groupBox4.Controls.Add(this.labelLightColorText);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox4.Location = new System.Drawing.Point(3, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Light";
            // 
            // lightVersorSpiral
            // 
            this.lightVersorSpiral.AutoSize = true;
            this.lightVersorSpiral.Location = new System.Drawing.Point(46, 81);
            this.lightVersorSpiral.Name = "lightVersorSpiral";
            this.lightVersorSpiral.Size = new System.Drawing.Size(63, 21);
            this.lightVersorSpiral.TabIndex = 5;
            this.lightVersorSpiral.Text = "spiral";
            this.lightVersorSpiral.UseVisualStyleBackColor = true;
            // 
            // lightVersorConstant
            // 
            this.lightVersorConstant.AutoSize = true;
            this.lightVersorConstant.Checked = true;
            this.lightVersorConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lightVersorConstant.Location = new System.Drawing.Point(46, 60);
            this.lightVersorConstant.Name = "lightVersorConstant";
            this.lightVersorConstant.Size = new System.Drawing.Size(83, 21);
            this.lightVersorConstant.TabIndex = 4;
            this.lightVersorConstant.TabStop = true;
            this.lightVersorConstant.Text = "constant";
            this.lightVersorConstant.UseVisualStyleBackColor = true;
            this.lightVersorConstant.CheckedChanged += new System.EventHandler(this.lightVersorConstant_CheckedChanged);
            // 
            // labelLightVersor
            // 
            this.labelLightVersor.AutoSize = true;
            this.labelLightVersor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelLightVersor.Location = new System.Drawing.Point(9, 43);
            this.labelLightVersor.Name = "labelLightVersor";
            this.labelLightVersor.Size = new System.Drawing.Size(45, 15);
            this.labelLightVersor.TabIndex = 3;
            this.labelLightVersor.Text = "Versor:";
            // 
            // labelLightColor
            // 
            this.labelLightColor.AutoSize = true;
            this.labelLightColor.BackColor = System.Drawing.Color.White;
            this.labelLightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLightColor.Location = new System.Drawing.Point(72, 19);
            this.labelLightColor.MaximumSize = new System.Drawing.Size(25, 25);
            this.labelLightColor.MinimumSize = new System.Drawing.Size(25, 25);
            this.labelLightColor.Name = "labelLightColor";
            this.labelLightColor.Size = new System.Drawing.Size(25, 25);
            this.labelLightColor.TabIndex = 2;
            this.labelLightColor.Click += new System.EventHandler(this.labelLightColor_Click);
            // 
            // labelLightColorText
            // 
            this.labelLightColorText.AutoSize = true;
            this.labelLightColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelLightColorText.Location = new System.Drawing.Point(9, 19);
            this.labelLightColorText.Name = "labelLightColorText";
            this.labelLightColorText.Size = new System.Drawing.Size(39, 15);
            this.labelLightColorText.TabIndex = 0;
            this.labelLightColorText.Text = "Color:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fillingInterpolation);
            this.groupBox6.Controls.Add(this.fillingPrecision);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox6.Location = new System.Drawing.Point(3, 612);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 72);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filling";
            // 
            // fillingInterpolation
            // 
            this.fillingInterpolation.AutoSize = true;
            this.fillingInterpolation.Location = new System.Drawing.Point(6, 49);
            this.fillingInterpolation.Name = "fillingInterpolation";
            this.fillingInterpolation.Size = new System.Drawing.Size(107, 21);
            this.fillingInterpolation.TabIndex = 1;
            this.fillingInterpolation.Text = "interpolation";
            this.fillingInterpolation.UseVisualStyleBackColor = true;
            // 
            // fillingPrecision
            // 
            this.fillingPrecision.AutoSize = true;
            this.fillingPrecision.Checked = true;
            this.fillingPrecision.Location = new System.Drawing.Point(6, 22);
            this.fillingPrecision.Name = "fillingPrecision";
            this.fillingPrecision.Size = new System.Drawing.Size(86, 21);
            this.fillingPrecision.TabIndex = 0;
            this.fillingPrecision.TabStop = true;
            this.fillingPrecision.Text = "precision";
            this.fillingPrecision.UseVisualStyleBackColor = true;
            this.fillingPrecision.CheckedChanged += new System.EventHandler(this.fillingPrecision_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dynamicRefresh);
            this.groupBox7.Controls.Add(this.buttonRefresh);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox7.Location = new System.Drawing.Point(3, 690);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(138, 77);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Refreshing";
            // 
            // dynamicRefresh
            // 
            this.dynamicRefresh.AutoSize = true;
            this.dynamicRefresh.Location = new System.Drawing.Point(9, 22);
            this.dynamicRefresh.Name = "dynamicRefresh";
            this.dynamicRefresh.Size = new System.Drawing.Size(82, 21);
            this.dynamicRefresh.TabIndex = 6;
            this.dynamicRefresh.Text = "dynamic";
            this.dynamicRefresh.UseVisualStyleBackColor = true;
            this.dynamicRefresh.CheckedChanged += new System.EventHandler(this.dynamicRefresh_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonRefresh.Location = new System.Drawing.Point(51, 47);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 26);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1178, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 804);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filling mesh";
            this.Resize += new System.EventHandler(this.ProjectForm_Resize);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutFactorsPanel.ResumeLayout(false);
            this.tableLayoutFactorsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanelWave.ResumeLayout(false);
            this.tableLayoutPanelWave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWave)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFactorsPanel;
        private System.Windows.Forms.TrackBar trackBarKS;
        private System.Windows.Forms.TrackBar trackBarKD;
        private System.Windows.Forms.TrackBar trackBarM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelKS;
        private System.Windows.Forms.Label labKD;
        private System.Windows.Forms.Label labM;
        private System.Windows.Forms.RadioButton normalVectorConstant;
        private System.Windows.Forms.RadioButton normalVectorTexture;
        private System.Windows.Forms.Button nvTextureLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton lightVersorSpiral;
        private System.Windows.Forms.RadioButton lightVersorConstant;
        private System.Windows.Forms.Label labelLightVersor;
        private System.Windows.Forms.Label labelLightColor;
        private System.Windows.Forms.Label labelLightColorText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelObjectColor;
        private System.Windows.Forms.Button ocTextureLoad;
        private System.Windows.Forms.RadioButton objectColorConstant;
        private System.Windows.Forms.RadioButton objectColorTexture;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton fillingInterpolation;
        private System.Windows.Forms.RadioButton fillingPrecision;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox meshVisible;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox dynamicRefresh;
        private System.Windows.Forms.TrackBar trackBarWave;
        private System.Windows.Forms.RadioButton normalVectorWave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWave;
    }
}

