partial class XtraReport1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.components = new System.ComponentModel.Container();
        DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
        this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
        this.xrLabel2,
        this.xrPictureBox1,
        this.xrLabel1,
        this.xrLine1});
        this.Detail.HeightF = 102F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel2
        // 
        this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
        this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Italic);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 50.08332F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(398.9583F, 52.00002F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.Text = "xrLabel2";
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")});
        this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(398.9583F, 2.083333F);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.SizeF = new System.Drawing.SizeF(251.0416F, 100F);
        this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
        // 
        // xrLabel1
        // 
        this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")});
        this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 26F);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 2.083333F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(398.9583F, 48F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.Text = "xrLabel1";
        // 
        // xrLine1
        // 
        this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrLine1.Name = "xrLine1";
        this.xrLine1.SizeF = new System.Drawing.SizeF(648.9583F, 2.083332F);
        // 
        // TopMargin
        // 
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // DetailReport
        // 
        this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
        this.Detail1});
        this.DetailReport.DataMember = "Products";
        this.DetailReport.DataSource = this.objectDataSource1;
        this.DetailReport.Level = 0;
        this.DetailReport.Name = "DetailReport";
        // 
        // Detail1
        // 
        this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
        this.xrTable1});
        this.Detail1.HeightF = 25F;
        this.Detail1.Name = "Detail1";
        // 
        // xrTable1
        // 
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
        this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
        this.xrTableCell1,
        this.xrTableCell2,
        this.xrTableCell3});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 11.5D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Text = "xrTableCell1";
        this.xrTableCell1.Weight = 0.2857142857142857D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Text = "xrTableCell2";
        this.xrTableCell2.Weight = 0.2857142857142857D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsOnOrder]")});
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "xrTableCell3";
        this.xrTableCell3.Weight = 0.2857142857142857D;
        // 
        // objectDataSource1
        // 
        this.objectDataSource1.Constructor = objectConstructorInfo1;
        this.objectDataSource1.DataMember = "Categories";
        this.objectDataSource1.DataSource = typeof(T264297.NorthwindModel);
        this.objectDataSource1.Name = "objectDataSource1";
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
        this.Detail,
        this.TopMargin,
        this.BottomMargin,
        this.DetailReport});
        this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
        this.objectDataSource1});
        this.DataSource = this.objectDataSource1;
        this.Version = "22.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    private DevExpress.XtraReports.UI.XRLine xrLine1;
}
