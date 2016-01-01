namespace Wordiscover
{
    partial class FindPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbSearchKey = new System.Windows.Forms.TextBox();
            this.listResults = new System.Windows.Forms.ListView();
            this.copyStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyRow = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowNum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllNums = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finderFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelResultsComponents = new System.Windows.Forms.Panel();
            this.splitterResults = new System.Windows.Forms.SplitContainer();
            this.labelResults = new System.Windows.Forms.Label();
            this.panelProxComponents = new System.Windows.Forms.Panel();
            this.splitterProximity = new System.Windows.Forms.SplitContainer();
            this.tbProxKey = new System.Windows.Forms.TextBox();
            this.cbNot = new System.Windows.Forms.CheckBox();
            this.progressBarPara = new System.Windows.Forms.ProgressBar();
            this.numericParagraphs = new System.Windows.Forms.NumericUpDown();
            this.cbInterpara = new System.Windows.Forms.CheckBox();
            this.numericWithin = new System.Windows.Forms.NumericUpDown();
            this.cbProximity = new System.Windows.Forms.CheckBox();
            this.cbCaseProxKey = new System.Windows.Forms.CheckBox();
            this.labelProximity = new System.Windows.Forms.Label();
            this.panelFindAll = new System.Windows.Forms.Panel();
            this.panelFindComponents = new System.Windows.Forms.Panel();
            this.splitterFind = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbCaseSearchKey = new System.Windows.Forms.CheckBox();
            this.panelFindLabel = new System.Windows.Forms.Panel();
            this.buttonFindOpenClose = new System.Windows.Forms.Button();
            this.labelFind = new System.Windows.Forms.Label();
            this.panelProximityAll = new System.Windows.Forms.Panel();
            this.panelProximityLabel = new System.Windows.Forms.Panel();
            this.buttonProxOpenClose = new System.Windows.Forms.Button();
            this.panelResultsAll = new System.Windows.Forms.Panel();
            this.panelResultsLabel = new System.Windows.Forms.Panel();
            this.buttonResultsOpenClose = new System.Windows.Forms.Button();
            this.fontDialogFind = new System.Windows.Forms.FontDialog();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelReplaceAll = new System.Windows.Forms.Panel();
            this.panelReplaceLabel = new System.Windows.Forms.Panel();
            this.buttonReplaceOpenClose = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.panelReplaceComponents = new System.Windows.Forms.Panel();
            this.splitResults = new System.Windows.Forms.SplitContainer();
            this.tbReplaceKey = new System.Windows.Forms.TextBox();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.copyStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelResultsComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterResults)).BeginInit();
            this.splitterResults.Panel1.SuspendLayout();
            this.splitterResults.Panel2.SuspendLayout();
            this.splitterResults.SuspendLayout();
            this.panelProxComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterProximity)).BeginInit();
            this.splitterProximity.Panel1.SuspendLayout();
            this.splitterProximity.Panel2.SuspendLayout();
            this.splitterProximity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericParagraphs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWithin)).BeginInit();
            this.panelFindAll.SuspendLayout();
            this.panelFindComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterFind)).BeginInit();
            this.splitterFind.Panel1.SuspendLayout();
            this.splitterFind.Panel2.SuspendLayout();
            this.splitterFind.SuspendLayout();
            this.panelFindLabel.SuspendLayout();
            this.panelProximityAll.SuspendLayout();
            this.panelProximityLabel.SuspendLayout();
            this.panelResultsAll.SuspendLayout();
            this.panelResultsLabel.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.panelReplaceAll.SuspendLayout();
            this.panelReplaceLabel.SuspendLayout();
            this.panelReplaceComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitResults)).BeginInit();
            this.splitResults.Panel1.SuspendLayout();
            this.splitResults.Panel2.SuspendLayout();
            this.splitResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnScrollUp
            // 
            this._btnScrollUp.Location = new System.Drawing.Point(0, 24);
            this._btnScrollUp.Size = new System.Drawing.Size(206, 12);
            // 
            // _btnScrollDown
            // 
            this._btnScrollDown.Location = new System.Drawing.Point(0, 912);
            this._btnScrollDown.Size = new System.Drawing.Size(206, 12);
            // 
            // tbSearchKey
            // 
            this.tbSearchKey.AllowDrop = true;
            this.tbSearchKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchKey.Location = new System.Drawing.Point(0, 0);
            this.tbSearchKey.Multiline = true;
            this.tbSearchKey.Name = "tbSearchKey";
            this.tbSearchKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSearchKey.Size = new System.Drawing.Size(206, 78);
            this.tbSearchKey.TabIndex = 0;
            // 
            // listResults
            // 
            this.listResults.ContextMenuStrip = this.copyStrip;
            this.listResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResults.FullRowSelect = true;
            this.listResults.HideSelection = false;
            this.listResults.Location = new System.Drawing.Point(0, 0);
            this.listResults.MultiSelect = false;
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(206, 268);
            this.listResults.TabIndex = 1;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.SelectedIndexChanged += new System.EventHandler(this.listResults_SelectedIndexChanged);
            // 
            // copyStrip
            // 
            this.copyStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRow,
            this.copyRowNum,
            this.toolStripSeparator1,
            this.copyAll,
            this.copyAllNums});
            this.copyStrip.Name = "copyStrip";
            this.copyStrip.Size = new System.Drawing.Size(173, 98);
            this.copyStrip.Text = "Copy";
            // 
            // copyRow
            // 
            this.copyRow.Name = "copyRow";
            this.copyRow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyRow.Size = new System.Drawing.Size(172, 22);
            this.copyRow.Text = "Copy Row";
            this.copyRow.Click += new System.EventHandler(this.copyRow_Click);
            // 
            // copyRowNum
            // 
            this.copyRowNum.Name = "copyRowNum";
            this.copyRowNum.Size = new System.Drawing.Size(172, 22);
            this.copyRowNum.Text = "Copy Row w/Num";
            this.copyRowNum.Click += new System.EventHandler(this.copyRowNum_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // copyAll
            // 
            this.copyAll.Name = "copyAll";
            this.copyAll.Size = new System.Drawing.Size(172, 22);
            this.copyAll.Text = "Copy All";
            this.copyAll.Click += new System.EventHandler(this.copyAll_Click);
            // 
            // copyAllNums
            // 
            this.copyAllNums.Name = "copyAllNums";
            this.copyAllNums.Size = new System.Drawing.Size(172, 22);
            this.copyAllNums.Text = "Copy All w/Nums";
            this.copyAllNums.Click += new System.EventHandler(this.copyAllNums_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(133, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(52, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(188, 6);
            this.progressBar.TabIndex = 3;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(0, 12);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(69, 17);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "timerLabel";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.BackColor = System.Drawing.Color.Transparent;
            this.labelPercent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercent.Location = new System.Drawing.Point(149, 12);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(40, 17);
            this.labelPercent.TabIndex = 5;
            this.labelPercent.Text = "100%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(206, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finderFontToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // finderFontToolStripMenuItem
            // 
            this.finderFontToolStripMenuItem.Name = "finderFontToolStripMenuItem";
            this.finderFontToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.finderFontToolStripMenuItem.Text = "Fonts...";
            this.finderFontToolStripMenuItem.Click += new System.EventHandler(this.finderFontToolStripMenuItem_Click);
            // 
            // panelResultsComponents
            // 
            this.panelResultsComponents.AutoSize = true;
            this.panelResultsComponents.Controls.Add(this.splitterResults);
            this.panelResultsComponents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultsComponents.Location = new System.Drawing.Point(0, 20);
            this.panelResultsComponents.Name = "panelResultsComponents";
            this.panelResultsComponents.Size = new System.Drawing.Size(206, 320);
            this.panelResultsComponents.TabIndex = 2;
            // 
            // splitterResults
            // 
            this.splitterResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterResults.Location = new System.Drawing.Point(0, 0);
            this.splitterResults.MinimumSize = new System.Drawing.Size(188, 320);
            this.splitterResults.Name = "splitterResults";
            this.splitterResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitterResults.Panel1
            // 
            this.splitterResults.Panel1.Controls.Add(this.listResults);
            // 
            // splitterResults.Panel2
            // 
            this.splitterResults.Panel2.Controls.Add(this.labelTimer);
            this.splitterResults.Panel2.Controls.Add(this.labelPercent);
            this.splitterResults.Panel2.Controls.Add(this.progressBar);
            this.splitterResults.Size = new System.Drawing.Size(206, 320);
            this.splitterResults.SplitterDistance = 268;
            this.splitterResults.TabIndex = 1;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelResults.Location = new System.Drawing.Point(6, -3);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(60, 21);
            this.labelResults.TabIndex = 2;
            this.labelResults.Text = "Results";
            this.labelResults.Click += new System.EventHandler(this.labelResults_Click);
            // 
            // panelProxComponents
            // 
            this.panelProxComponents.AutoSize = true;
            this.panelProxComponents.Controls.Add(this.splitterProximity);
            this.panelProxComponents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProxComponents.Location = new System.Drawing.Point(0, 16);
            this.panelProxComponents.MinimumSize = new System.Drawing.Size(197, 134);
            this.panelProxComponents.Name = "panelProxComponents";
            this.panelProxComponents.Size = new System.Drawing.Size(206, 134);
            this.panelProxComponents.TabIndex = 2;
            // 
            // splitterProximity
            // 
            this.splitterProximity.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterProximity.Location = new System.Drawing.Point(0, 0);
            this.splitterProximity.Name = "splitterProximity";
            this.splitterProximity.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitterProximity.Panel1
            // 
            this.splitterProximity.Panel1.Controls.Add(this.tbProxKey);
            // 
            // splitterProximity.Panel2
            // 
            this.splitterProximity.Panel2.Controls.Add(this.cbNot);
            this.splitterProximity.Panel2.Controls.Add(this.progressBarPara);
            this.splitterProximity.Panel2.Controls.Add(this.numericParagraphs);
            this.splitterProximity.Panel2.Controls.Add(this.cbInterpara);
            this.splitterProximity.Panel2.Controls.Add(this.numericWithin);
            this.splitterProximity.Panel2.Controls.Add(this.cbProximity);
            this.splitterProximity.Panel2.Controls.Add(this.cbCaseProxKey);
            this.splitterProximity.Size = new System.Drawing.Size(206, 128);
            this.splitterProximity.SplitterDistance = 64;
            this.splitterProximity.TabIndex = 1;
            // 
            // tbProxKey
            // 
            this.tbProxKey.AllowDrop = true;
            this.tbProxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProxKey.Location = new System.Drawing.Point(0, 0);
            this.tbProxKey.Multiline = true;
            this.tbProxKey.Name = "tbProxKey";
            this.tbProxKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProxKey.Size = new System.Drawing.Size(206, 64);
            this.tbProxKey.TabIndex = 0;
            // 
            // cbNot
            // 
            this.cbNot.AutoSize = true;
            this.cbNot.Location = new System.Drawing.Point(113, 40);
            this.cbNot.Name = "cbNot";
            this.cbNot.Size = new System.Drawing.Size(80, 17);
            this.cbNot.TabIndex = 6;
            this.cbNot.Text = "Logical Not";
            this.cbNot.UseVisualStyleBackColor = true;
            // 
            // progressBarPara
            // 
            this.progressBarPara.Location = new System.Drawing.Point(155, 26);
            this.progressBarPara.Name = "progressBarPara";
            this.progressBarPara.Size = new System.Drawing.Size(29, 10);
            this.progressBarPara.TabIndex = 6;
            this.progressBarPara.Visible = false;
            // 
            // numericParagraphs
            // 
            this.numericParagraphs.Location = new System.Drawing.Point(5, 20);
            this.numericParagraphs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericParagraphs.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericParagraphs.Name = "numericParagraphs";
            this.numericParagraphs.Size = new System.Drawing.Size(33, 20);
            this.numericParagraphs.TabIndex = 3;
            this.numericParagraphs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericParagraphs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbInterpara
            // 
            this.cbInterpara.AutoSize = true;
            this.cbInterpara.Location = new System.Drawing.Point(38, 21);
            this.cbInterpara.Name = "cbInterpara";
            this.cbInterpara.Size = new System.Drawing.Size(121, 17);
            this.cbInterpara.TabIndex = 2;
            this.cbInterpara.Text = "Paragraph proximity ";
            this.cbInterpara.UseVisualStyleBackColor = true;
            // 
            // numericWithin
            // 
            this.numericWithin.Location = new System.Drawing.Point(5, 0);
            this.numericWithin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericWithin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWithin.Name = "numericWithin";
            this.numericWithin.Size = new System.Drawing.Size(33, 20);
            this.numericWithin.TabIndex = 1;
            this.numericWithin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericWithin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbProximity
            // 
            this.cbProximity.AutoSize = true;
            this.cbProximity.Location = new System.Drawing.Point(38, 3);
            this.cbProximity.Name = "cbProximity";
            this.cbProximity.Size = new System.Drawing.Size(119, 17);
            this.cbProximity.TabIndex = 0;
            this.cbProximity.Text = "Word proximity        ";
            this.cbProximity.UseVisualStyleBackColor = true;
            this.cbProximity.CheckedChanged += new System.EventHandler(this.cbProximity_CheckedChanged);
            // 
            // cbCaseProxKey
            // 
            this.cbCaseProxKey.AutoSize = true;
            this.cbCaseProxKey.Location = new System.Drawing.Point(7, 40);
            this.cbCaseProxKey.Name = "cbCaseProxKey";
            this.cbCaseProxKey.Size = new System.Drawing.Size(96, 17);
            this.cbCaseProxKey.TabIndex = 5;
            this.cbCaseProxKey.Text = "Case Sensitive";
            this.cbCaseProxKey.UseVisualStyleBackColor = true;
            // 
            // labelProximity
            // 
            this.labelProximity.AutoSize = true;
            this.labelProximity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProximity.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelProximity.Location = new System.Drawing.Point(6, -3);
            this.labelProximity.Name = "labelProximity";
            this.labelProximity.Size = new System.Drawing.Size(76, 21);
            this.labelProximity.TabIndex = 2;
            this.labelProximity.Text = "Proximity";
            this.labelProximity.Click += new System.EventHandler(this.labelProximity_Click);
            // 
            // panelFindAll
            // 
            this.panelFindAll.AutoSize = true;
            this.panelFindAll.Controls.Add(this.panelFindComponents);
            this.panelFindAll.Controls.Add(this.panelFindLabel);
            this.panelFindAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFindAll.Location = new System.Drawing.Point(0, 0);
            this.panelFindAll.Name = "panelFindAll";
            this.panelFindAll.Size = new System.Drawing.Size(206, 139);
            this.panelFindAll.TabIndex = 1;
            // 
            // panelFindComponents
            // 
            this.panelFindComponents.AutoSize = true;
            this.panelFindComponents.Controls.Add(this.splitterFind);
            this.panelFindComponents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFindComponents.Location = new System.Drawing.Point(0, 16);
            this.panelFindComponents.MinimumSize = new System.Drawing.Size(200, 123);
            this.panelFindComponents.Name = "panelFindComponents";
            this.panelFindComponents.Size = new System.Drawing.Size(206, 123);
            this.panelFindComponents.TabIndex = 1;
            // 
            // splitterFind
            // 
            this.splitterFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterFind.Location = new System.Drawing.Point(0, 0);
            this.splitterFind.Name = "splitterFind";
            this.splitterFind.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitterFind.Panel1
            // 
            this.splitterFind.Panel1.Controls.Add(this.tbSearchKey);
            // 
            // splitterFind.Panel2
            // 
            this.splitterFind.Panel2.Controls.Add(this.btnClear);
            this.splitterFind.Panel2.Controls.Add(this.cbCaseSearchKey);
            this.splitterFind.Panel2.Controls.Add(this.btnFind);
            this.splitterFind.Size = new System.Drawing.Size(206, 123);
            this.splitterFind.SplitterDistance = 78;
            this.splitterFind.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(87, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // cbCaseSearchKey
            // 
            this.cbCaseSearchKey.AutoSize = true;
            this.cbCaseSearchKey.Location = new System.Drawing.Point(3, 3);
            this.cbCaseSearchKey.Name = "cbCaseSearchKey";
            this.cbCaseSearchKey.Size = new System.Drawing.Size(69, 30);
            this.cbCaseSearchKey.TabIndex = 0;
            this.cbCaseSearchKey.Text = "Case \r\nSensitive\r\n";
            this.cbCaseSearchKey.UseVisualStyleBackColor = true;
            // 
            // panelFindLabel
            // 
            this.panelFindLabel.Controls.Add(this.buttonFindOpenClose);
            this.panelFindLabel.Controls.Add(this.labelFind);
            this.panelFindLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFindLabel.Location = new System.Drawing.Point(0, 0);
            this.panelFindLabel.Name = "panelFindLabel";
            this.panelFindLabel.Size = new System.Drawing.Size(206, 16);
            this.panelFindLabel.TabIndex = 15;
            // 
            // buttonFindOpenClose
            // 
            this.buttonFindOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindOpenClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFindOpenClose.Image = global::Wordiscover.Properties.Resources.arrowOpen;
            this.buttonFindOpenClose.Location = new System.Drawing.Point(0, -2);
            this.buttonFindOpenClose.Name = "buttonFindOpenClose";
            this.buttonFindOpenClose.Size = new System.Drawing.Size(10, 20);
            this.buttonFindOpenClose.TabIndex = 13;
            this.buttonFindOpenClose.UseVisualStyleBackColor = true;
            this.buttonFindOpenClose.Click += new System.EventHandler(this.buttonFindOpenClose_Click);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelFind.Location = new System.Drawing.Point(6, -3);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(40, 21);
            this.labelFind.TabIndex = 12;
            this.labelFind.Text = "Find";
            this.labelFind.Click += new System.EventHandler(this.labelFind_Click);
            // 
            // panelProximityAll
            // 
            this.panelProximityAll.AutoSize = true;
            this.panelProximityAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelProximityAll.Controls.Add(this.panelProximityLabel);
            this.panelProximityAll.Controls.Add(this.panelProxComponents);
            this.panelProximityAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProximityAll.Location = new System.Drawing.Point(0, 261);
            this.panelProximityAll.Name = "panelProximityAll";
            this.panelProximityAll.Size = new System.Drawing.Size(206, 150);
            this.panelProximityAll.TabIndex = 3;
            // 
            // panelProximityLabel
            // 
            this.panelProximityLabel.Controls.Add(this.buttonProxOpenClose);
            this.panelProximityLabel.Controls.Add(this.labelProximity);
            this.panelProximityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProximityLabel.Location = new System.Drawing.Point(0, 0);
            this.panelProximityLabel.Name = "panelProximityLabel";
            this.panelProximityLabel.Size = new System.Drawing.Size(206, 16);
            this.panelProximityLabel.TabIndex = 1;
            // 
            // buttonProxOpenClose
            // 
            this.buttonProxOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProxOpenClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonProxOpenClose.Image = global::Wordiscover.Properties.Resources.arrowClosed;
            this.buttonProxOpenClose.Location = new System.Drawing.Point(0, -2);
            this.buttonProxOpenClose.Name = "buttonProxOpenClose";
            this.buttonProxOpenClose.Size = new System.Drawing.Size(10, 20);
            this.buttonProxOpenClose.TabIndex = 1;
            this.buttonProxOpenClose.UseVisualStyleBackColor = true;
            this.buttonProxOpenClose.Click += new System.EventHandler(this.buttonProximityOpenClose_Click);
            // 
            // panelResultsAll
            // 
            this.panelResultsAll.AutoSize = true;
            this.panelResultsAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResultsAll.Controls.Add(this.panelResultsLabel);
            this.panelResultsAll.Controls.Add(this.panelResultsComponents);
            this.panelResultsAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultsAll.Location = new System.Drawing.Point(0, 411);
            this.panelResultsAll.Name = "panelResultsAll";
            this.panelResultsAll.Size = new System.Drawing.Size(206, 340);
            this.panelResultsAll.TabIndex = 4;
            // 
            // panelResultsLabel
            // 
            this.panelResultsLabel.Controls.Add(this.buttonResultsOpenClose);
            this.panelResultsLabel.Controls.Add(this.labelResults);
            this.panelResultsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultsLabel.Location = new System.Drawing.Point(0, 0);
            this.panelResultsLabel.Name = "panelResultsLabel";
            this.panelResultsLabel.Size = new System.Drawing.Size(206, 20);
            this.panelResultsLabel.TabIndex = 1;
            // 
            // buttonResultsOpenClose
            // 
            this.buttonResultsOpenClose.FlatAppearance.BorderSize = 0;
            this.buttonResultsOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResultsOpenClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonResultsOpenClose.Image = global::Wordiscover.Properties.Resources.arrowOpen;
            this.buttonResultsOpenClose.Location = new System.Drawing.Point(0, -2);
            this.buttonResultsOpenClose.Name = "buttonResultsOpenClose";
            this.buttonResultsOpenClose.Size = new System.Drawing.Size(10, 20);
            this.buttonResultsOpenClose.TabIndex = 1;
            this.buttonResultsOpenClose.UseVisualStyleBackColor = true;
            this.buttonResultsOpenClose.Click += new System.EventHandler(this.buttonResultsOpenClose_Click);
            // 
            // panelAll
            // 
            this.panelAll.AutoSize = true;
            this.panelAll.Controls.Add(this.panelResultsAll);
            this.panelAll.Controls.Add(this.panelProximityAll);
            this.panelAll.Controls.Add(this.panelReplaceAll);
            this.panelAll.Controls.Add(this.panelFindAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 24);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(206, 900);
            this.panelAll.TabIndex = 1;
            // 
            // panelReplaceAll
            // 
            this.panelReplaceAll.AutoSize = true;
            this.panelReplaceAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelReplaceAll.Controls.Add(this.panelReplaceLabel);
            this.panelReplaceAll.Controls.Add(this.panelReplaceComponents);
            this.panelReplaceAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReplaceAll.Location = new System.Drawing.Point(0, 139);
            this.panelReplaceAll.Name = "panelReplaceAll";
            this.panelReplaceAll.Size = new System.Drawing.Size(206, 122);
            this.panelReplaceAll.TabIndex = 2;
            // 
            // panelReplaceLabel
            // 
            this.panelReplaceLabel.Controls.Add(this.buttonReplaceOpenClose);
            this.panelReplaceLabel.Controls.Add(this.labelReplace);
            this.panelReplaceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReplaceLabel.Location = new System.Drawing.Point(0, 0);
            this.panelReplaceLabel.Name = "panelReplaceLabel";
            this.panelReplaceLabel.Size = new System.Drawing.Size(206, 16);
            this.panelReplaceLabel.TabIndex = 1;
            // 
            // buttonReplaceOpenClose
            // 
            this.buttonReplaceOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplaceOpenClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonReplaceOpenClose.Image = global::Wordiscover.Properties.Resources.arrowClosed;
            this.buttonReplaceOpenClose.Location = new System.Drawing.Point(0, -2);
            this.buttonReplaceOpenClose.Name = "buttonReplaceOpenClose";
            this.buttonReplaceOpenClose.Size = new System.Drawing.Size(10, 20);
            this.buttonReplaceOpenClose.TabIndex = 1;
            this.buttonReplaceOpenClose.UseVisualStyleBackColor = true;
            this.buttonReplaceOpenClose.Click += new System.EventHandler(this.buttonReplaceOpenClose_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplace.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelReplace.Location = new System.Drawing.Point(6, -3);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(64, 21);
            this.labelReplace.TabIndex = 2;
            this.labelReplace.Text = "Replace";
            this.labelReplace.Click += new System.EventHandler(this.labelReplace_Click);
            // 
            // panelReplaceComponents
            // 
            this.panelReplaceComponents.AutoSize = true;
            this.panelReplaceComponents.Controls.Add(this.splitResults);
            this.panelReplaceComponents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReplaceComponents.Location = new System.Drawing.Point(0, 16);
            this.panelReplaceComponents.MinimumSize = new System.Drawing.Size(206, 106);
            this.panelReplaceComponents.Name = "panelReplaceComponents";
            this.panelReplaceComponents.Size = new System.Drawing.Size(206, 106);
            this.panelReplaceComponents.TabIndex = 2;
            // 
            // splitResults
            // 
            this.splitResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitResults.Location = new System.Drawing.Point(0, 0);
            this.splitResults.Name = "splitResults";
            this.splitResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitResults.Panel1
            // 
            this.splitResults.Panel1.Controls.Add(this.tbReplaceKey);
            // 
            // splitResults.Panel2
            // 
            this.splitResults.Panel2.Controls.Add(this.buttonReplaceAll);
            this.splitResults.Panel2.Controls.Add(this.buttonReplace);
            this.splitResults.Size = new System.Drawing.Size(206, 106);
            this.splitResults.SplitterDistance = 53;
            this.splitResults.TabIndex = 1;
            // 
            // tbReplaceKey
            // 
            this.tbReplaceKey.AllowDrop = true;
            this.tbReplaceKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReplaceKey.Location = new System.Drawing.Point(0, 0);
            this.tbReplaceKey.Multiline = true;
            this.tbReplaceKey.Name = "tbReplaceKey";
            this.tbReplaceKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReplaceKey.Size = new System.Drawing.Size(206, 53);
            this.tbReplaceKey.TabIndex = 0;
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.Location = new System.Drawing.Point(93, 3);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Size = new System.Drawing.Size(76, 23);
            this.buttonReplaceAll.TabIndex = 2;
            this.buttonReplaceAll.Text = "Replace All";
            this.buttonReplaceAll.UseVisualStyleBackColor = true;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(23, 3);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(64, 23);
            this.buttonReplace.TabIndex = 1;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // FindPane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FindPane";
            this.Size = new System.Drawing.Size(206, 924);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindPane_KeyDown);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panelAll, 0);
            this.Controls.SetChildIndex(this._btnScrollUp, 0);
            this.Controls.SetChildIndex(this._btnScrollDown, 0);
            this.copyStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelResultsComponents.ResumeLayout(false);
            this.splitterResults.Panel1.ResumeLayout(false);
            this.splitterResults.Panel2.ResumeLayout(false);
            this.splitterResults.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterResults)).EndInit();
            this.splitterResults.ResumeLayout(false);
            this.panelProxComponents.ResumeLayout(false);
            this.splitterProximity.Panel1.ResumeLayout(false);
            this.splitterProximity.Panel1.PerformLayout();
            this.splitterProximity.Panel2.ResumeLayout(false);
            this.splitterProximity.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterProximity)).EndInit();
            this.splitterProximity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericParagraphs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWithin)).EndInit();
            this.panelFindAll.ResumeLayout(false);
            this.panelFindAll.PerformLayout();
            this.panelFindComponents.ResumeLayout(false);
            this.splitterFind.Panel1.ResumeLayout(false);
            this.splitterFind.Panel1.PerformLayout();
            this.splitterFind.Panel2.ResumeLayout(false);
            this.splitterFind.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterFind)).EndInit();
            this.splitterFind.ResumeLayout(false);
            this.panelFindLabel.ResumeLayout(false);
            this.panelFindLabel.PerformLayout();
            this.panelProximityAll.ResumeLayout(false);
            this.panelProximityAll.PerformLayout();
            this.panelProximityLabel.ResumeLayout(false);
            this.panelProximityLabel.PerformLayout();
            this.panelResultsAll.ResumeLayout(false);
            this.panelResultsAll.PerformLayout();
            this.panelResultsLabel.ResumeLayout(false);
            this.panelResultsLabel.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.panelReplaceAll.ResumeLayout(false);
            this.panelReplaceAll.PerformLayout();
            this.panelReplaceLabel.ResumeLayout(false);
            this.panelReplaceLabel.PerformLayout();
            this.panelReplaceComponents.ResumeLayout(false);
            this.splitResults.Panel1.ResumeLayout(false);
            this.splitResults.Panel1.PerformLayout();
            this.splitResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitResults)).EndInit();
            this.splitResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchKey;
        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelResultsComponents;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Panel panelProxComponents;
        private System.Windows.Forms.Label labelProximity;
        private System.Windows.Forms.Panel panelFindAll;
        private System.Windows.Forms.Panel panelProximityAll;
        private System.Windows.Forms.Panel panelResultsAll;
        private System.Windows.Forms.Button buttonProxOpenClose;
        private System.Windows.Forms.Panel panelProximityLabel;
        private System.Windows.Forms.TextBox tbProxKey;
        private System.Windows.Forms.CheckBox cbProximity;
        private System.Windows.Forms.Panel panelResultsLabel;
        private System.Windows.Forms.Button buttonResultsOpenClose;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finderFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialogFind;
        private System.Windows.Forms.CheckBox cbCaseSearchKey;
        private System.Windows.Forms.CheckBox cbCaseProxKey;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip copyStrip;
        private System.Windows.Forms.ToolStripMenuItem copyRow;
        private System.Windows.Forms.ToolStripMenuItem copyAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyRowNum;
        private System.Windows.Forms.ToolStripMenuItem copyAllNums;
        private System.Windows.Forms.SplitContainer splitterFind;
        private System.Windows.Forms.SplitContainer splitterResults;
        private System.Windows.Forms.SplitContainer splitterProximity;
        private System.Windows.Forms.NumericUpDown numericWithin;
        private System.Windows.Forms.Panel panelFindLabel;
        private System.Windows.Forms.Button buttonFindOpenClose;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Panel panelFindComponents;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelReplaceAll;
        private System.Windows.Forms.Panel panelReplaceLabel;
        private System.Windows.Forms.Button buttonReplaceOpenClose;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.Panel panelReplaceComponents;
        private System.Windows.Forms.SplitContainer splitResults;
        private System.Windows.Forms.TextBox tbReplaceKey;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.CheckBox cbInterpara;
        private System.Windows.Forms.NumericUpDown numericParagraphs;
        private System.Windows.Forms.CheckBox cbNot;
        private System.Windows.Forms.ProgressBar progressBarPara;
    }
}