namespace Wordiscover
{
  partial class WordiscoverRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public WordiscoverRibbon()
      : base(Globals.Factory.GetRibbonFactory())
    {
      InitializeComponent();
    }

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
            this.Wordiscover = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnFind = this.Factory.CreateRibbonButton();
            this.showPane = this.Factory.CreateRibbonButton();
            this.buttonAbout = this.Factory.CreateRibbonButton();
            this.Wordiscover.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // Wordiscover
            // 
            this.Wordiscover.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Wordiscover.Groups.Add(this.group1);
            this.Wordiscover.Label = "Wordiscover";
            this.Wordiscover.Name = "Wordiscover";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnFind);
            this.group1.Items.Add(this.showPane);
            this.group1.Items.Add(this.buttonAbout);
            this.group1.Name = "group1";
            // 
            // btnFind
            // 
            this.btnFind.Label = "";
            this.btnFind.Name = "btnFind";
            // 
            // showPane
            // 
            this.showPane.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.showPane.Image = global::Wordiscover.Properties.Resources.icon_document;
            this.showPane.Label = "Show/Hide\r\nSearch\r\nPane";
            this.showPane.Name = "showPane";
            this.showPane.ShowImage = true;
            this.showPane.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.showPane_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAbout.Image = global::Wordiscover.Properties.Resources.icon_info;
            this.buttonAbout.Label = "About";
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.ShowImage = true;
            this.buttonAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonAbout_Click);
            // 
            // WordiscoverRibbon
            // 
            this.Name = "WordiscoverRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.Wordiscover);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.Wordiscover.ResumeLayout(false);
            this.Wordiscover.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

    }

    #endregion

    internal Microsoft.Office.Tools.Ribbon.RibbonTab Wordiscover;
    internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton btnFind;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton showPane;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAbout;
  }

  partial class ThisRibbonCollection
  {
    internal WordiscoverRibbon Ribbon
    {
      get { return this.GetRibbon<WordiscoverRibbon>(); }
    }
  }
}
