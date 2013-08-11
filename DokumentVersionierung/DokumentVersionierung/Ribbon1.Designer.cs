namespace DokumentVersionierung
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für Designerunterstützung -
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tabHNU = this.Factory.CreateRibbonTab();
            this.groupVersionierung = this.Factory.CreateRibbonGroup();
            this.buttonRaiseRev = this.Factory.CreateRibbonButton();
            this.buttonRaiseVer = this.Factory.CreateRibbonButton();
            this.buttonRaiseBuild = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tabHNU.SuspendLayout();
            this.groupVersionierung.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // tabHNU
            // 
            this.tabHNU.Groups.Add(this.groupVersionierung);
            this.tabHNU.Label = "HNU";
            this.tabHNU.Name = "tabHNU";
            // 
            // groupVersionierung
            // 
            this.groupVersionierung.Items.Add(this.buttonRaiseRev);
            this.groupVersionierung.Items.Add(this.buttonRaiseVer);
            this.groupVersionierung.Items.Add(this.buttonRaiseBuild);
            this.groupVersionierung.Items.Add(this.button4);
            this.groupVersionierung.Label = "Versionierung";
            this.groupVersionierung.Name = "groupVersionierung";
            // 
            // buttonRaiseRev
            // 
            this.buttonRaiseRev.Image = global::DokumentVersionierung.Properties.Resources.Flag_greenHS;
            this.buttonRaiseRev.Label = "Erhöhe Revision";
            this.buttonRaiseRev.Name = "buttonRaiseRev";
            this.buttonRaiseRev.ShowImage = true;
            this.buttonRaiseRev.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRaiseRev_Click);
            // 
            // buttonRaiseVer
            // 
            this.buttonRaiseVer.Image = global::DokumentVersionierung.Properties.Resources.Flag_blueHS;
            this.buttonRaiseVer.Label = "Erhöhe Version";
            this.buttonRaiseVer.Name = "buttonRaiseVer";
            this.buttonRaiseVer.ShowImage = true;
            this.buttonRaiseVer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRaiseVer_Click);
            // 
            // buttonRaiseBuild
            // 
            this.buttonRaiseBuild.Image = global::DokumentVersionierung.Properties.Resources.Flag_redHS;
            this.buttonRaiseBuild.Label = "Erhöhe Build";
            this.buttonRaiseBuild.Name = "buttonRaiseBuild";
            this.buttonRaiseBuild.ShowImage = true;
            this.buttonRaiseBuild.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRaiseBuild_Click);
            // 
            // button4
            // 
            this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button4.Image = global::DokumentVersionierung.Properties.Resources._023_Tip_128x128_72;
            this.button4.Label = "Dokument Info";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabHNU);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabHNU.ResumeLayout(false);
            this.tabHNU.PerformLayout();
            this.groupVersionierung.ResumeLayout(false);
            this.groupVersionierung.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabHNU;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupVersionierung;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRaiseRev;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRaiseVer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRaiseBuild;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
