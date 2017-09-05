using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for PatientReport
/// </summary>
public class ConsolidatedReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLabel FirstName;
    private XRPictureBox PPGLogo;
    private XRLabel LastName;
    private XRLabel DOB;
    private XRLabel valLasttName;
    private XRLabel valDOB;
    private XRLine HeaderLine;
    private PageFooterBand PageFooter;
    private XRLabel ReportDate;
    private XRPageInfo ReportDateVal;
    private XRPageInfo xrPageInfo1;
    private XRLabel valFirstName;
    private XRLabel Heading;
    private XRChart xrChart1;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell QuestionCell;
    private XRTableCell AnswerCell;
    private ClarityWebAppDX.ClarityDBSet clarityDBSet1;
    private DevExpress.XtraReports.Parameters.Parameter PatientID;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public ConsolidatedReport()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidatedReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.FirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.PPGLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.LastName = new DevExpress.XtraReports.UI.XRLabel();
            this.DOB = new DevExpress.XtraReports.UI.XRLabel();
            this.valLasttName = new DevExpress.XtraReports.UI.XRLabel();
            this.valDOB = new DevExpress.XtraReports.UI.XRLabel();
            this.HeaderLine = new DevExpress.XtraReports.UI.XRLine();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportDate = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportDateVal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.valFirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.Heading = new DevExpress.XtraReports.UI.XRLabel();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.QuestionCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.AnswerCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.clarityDBSet1 = new ClarityWebAppDX.ClarityDBSet();
            this.@PatientID = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Heading2 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.valQuestionnarieName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTestDate = new DevExpress.XtraReports.UI.XRLabel();
            this.varTestDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lblScore = new DevExpress.XtraReports.UI.XRLabel();
            this.valScore = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRiskCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.valRiskCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clarityDBSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 14F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 15.625F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Heading2,
            this.valFirstName,
            this.FirstName,
            this.PPGLogo,
            this.LastName,
            this.DOB,
            this.valLasttName,
            this.valDOB,
            this.HeaderLine,
            this.Heading,
            this.xrChart1});
            this.ReportHeader.HeightF = 369.5001F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.FirstName.LocationFloat = new DevExpress.Utils.PointFloat(176.4583F, 46.00003F);
            this.FirstName.Name = "FirstName";
            this.FirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.FirstName.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.FirstName.StylePriority.UseFont = false;
            this.FirstName.StylePriority.UseForeColor = false;
            this.FirstName.Text = "First Name:";
            // 
            // PPGLogo
            // 
            this.PPGLogo.ImageUrl = "C:\\Users\\BumbleB\\Source\\Repos\\ClarityAppDX\\ClarityWebAppDX\\Images\\logo.png";
            this.PPGLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.PPGLogo.Name = "PPGLogo";
            this.PPGLogo.SizeF = new System.Drawing.SizeF(148.9583F, 69.00002F);
            this.PPGLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.LastName.LocationFloat = new DevExpress.Utils.PointFloat(176.4583F, 69.00002F);
            this.LastName.Name = "LastName";
            this.LastName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LastName.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.LastName.StylePriority.UseFont = false;
            this.LastName.StylePriority.UseForeColor = false;
            this.LastName.Text = "Last Name:";
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.DOB.LocationFloat = new DevExpress.Utils.PointFloat(532.5416F, 46.00003F);
            this.DOB.Name = "DOB";
            this.DOB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.DOB.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.DOB.StylePriority.UseFont = false;
            this.DOB.StylePriority.UseForeColor = false;
            this.DOB.Text = "Date of Birth:";
            // 
            // valLasttName
            // 
            this.valLasttName.AutoWidth = true;
            this.valLasttName.CanShrink = true;
            this.valLasttName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetails.PatientLastName")});
            this.valLasttName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLasttName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valLasttName.LocationFloat = new DevExpress.Utils.PointFloat(286.6665F, 69.00002F);
            this.valLasttName.Name = "valLasttName";
            this.valLasttName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valLasttName.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valLasttName.StylePriority.UseFont = false;
            this.valLasttName.StylePriority.UseForeColor = false;
            // 
            // valDOB
            // 
            this.valDOB.AutoWidth = true;
            this.valDOB.CanShrink = true;
            this.valDOB.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetails.FormattedDOB")});
            this.valDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valDOB.LocationFloat = new DevExpress.Utils.PointFloat(642.7498F, 46.00003F);
            this.valDOB.Name = "valDOB";
            this.valDOB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valDOB.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valDOB.StylePriority.UseFont = false;
            this.valDOB.StylePriority.UseForeColor = false;
            // 
            // HeaderLine
            // 
            this.HeaderLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.HeaderLine.BorderWidth = 1F;
            this.HeaderLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.HeaderLine.LineWidth = 2;
            this.HeaderLine.LocationFloat = new DevExpress.Utils.PointFloat(0F, 92.33337F);
            this.HeaderLine.Name = "HeaderLine";
            this.HeaderLine.SizeF = new System.Drawing.SizeF(820F, 13.16666F);
            this.HeaderLine.StylePriority.UseBorderColor = false;
            this.HeaderLine.StylePriority.UseBorderWidth = false;
            this.HeaderLine.StylePriority.UseForeColor = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.ReportDate,
            this.ReportDateVal,
            this.xrPageInfo1});
            this.PageFooter.HeightF = 37.5F;
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportDate
            // 
            this.ReportDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.ReportDate.LocationFloat = new DevExpress.Utils.PointFloat(11.04164F, 13.16666F);
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportDate.SizeF = new System.Drawing.SizeF(99.16666F, 23F);
            this.ReportDate.StylePriority.UseFont = false;
            this.ReportDate.StylePriority.UseForeColor = false;
            this.ReportDate.Text = "Report Date";
            // 
            // ReportDateVal
            // 
            this.ReportDateVal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.ReportDateVal.Format = "{0:MMMM d, yyyy h:mm tt}";
            this.ReportDateVal.LocationFloat = new DevExpress.Utils.PointFloat(110.2084F, 13.16666F);
            this.ReportDateVal.Name = "ReportDateVal";
            this.ReportDateVal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportDateVal.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.ReportDateVal.SizeF = new System.Drawing.SizeF(205.6667F, 23F);
            this.ReportDateVal.StylePriority.UseFont = false;
            this.ReportDateVal.StylePriority.UseForeColor = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.xrPageInfo1.Format = "Page {0}/{0}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(742.2917F, 13.16666F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(67.70831F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            // 
            // valFirstName
            // 
            this.valFirstName.AutoWidth = true;
            this.valFirstName.CanShrink = true;
            this.valFirstName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetails.PatientFirstName")});
            this.valFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valFirstName.LocationFloat = new DevExpress.Utils.PointFloat(286.6665F, 46.00003F);
            this.valFirstName.Name = "valFirstName";
            this.valFirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valFirstName.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valFirstName.StylePriority.UseFont = false;
            this.valFirstName.StylePriority.UseForeColor = false;
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.Heading.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Heading.Name = "Heading";
            this.Heading.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.Heading.SizeF = new System.Drawing.SizeF(819.9999F, 23F);
            this.Heading.StylePriority.UseFont = false;
            this.Heading.StylePriority.UseForeColor = false;
            this.Heading.StylePriority.UseTextAlignment = false;
            this.Heading.Text = "Patient Summary";
            this.Heading.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart1.DataMember = "spGetPatientConsolidatedQuestionnaireList";
            this.xrChart1.DataSource = this.sqlDataSource1;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(21.49999F, 139.5F);
            this.xrChart1.Name = "xrChart1";
            this.xrChart1.PaletteName = "Metro";
            series1.ArgumentDataMember = "QuestionnaireName";
            series1.ColorDataMember = "RiskCategory";
            sideBySideBarSeriesLabel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LegendName = "Default Legend";
            series1.Name = "Series 1";
            series1.ShowInLegend = false;
            series1.ValueDataMembersSerializable = "Score";
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart1.SeriesTemplate.ArgumentDataMember = "QuestionnaireName";
            this.xrChart1.SeriesTemplate.ColorDataMember = "RiskCategory";
            this.xrChart1.SeriesTemplate.ValueDataMembersSerializable = "Score";
            this.xrChart1.SizeF = new System.Drawing.SizeF(774.9999F, 200F);
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1,
            this.GroupFooter1});
            this.DetailReport.DataMember = "spGetPatientConsolidatedQuestionnaireList";
            this.DetailReport.DataSource = this.sqlDataSource1;
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
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(819.9999F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.QuestionCell,
            this.AnswerCell});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // QuestionCell
            // 
            this.QuestionCell.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.QuestionCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedQuestionnaireList.QuestionText")});
            this.QuestionCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.QuestionCell.Name = "QuestionCell";
            this.QuestionCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.QuestionCell.StylePriority.UseBorders = false;
            this.QuestionCell.StylePriority.UseFont = false;
            this.QuestionCell.StylePriority.UseForeColor = false;
            this.QuestionCell.StylePriority.UsePadding = false;
            this.QuestionCell.Weight = 1.9483231668852394D;
            // 
            // AnswerCell
            // 
            this.AnswerCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.AnswerCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedQuestionnaireList.AnswerText")});
            this.AnswerCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.AnswerCell.Name = "AnswerCell";
            this.AnswerCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.AnswerCell.StylePriority.UseBorders = false;
            this.AnswerCell.StylePriority.UseFont = false;
            this.AnswerCell.StylePriority.UseForeColor = false;
            this.AnswerCell.StylePriority.UsePadding = false;
            this.AnswerCell.Weight = 1.0516768331147606D;
            // 
            // clarityDBSet1
            // 
            this.clarityDBSet1.DataSetName = "ClarityDBSet";
            this.clarityDBSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // @PatientID
            // 
            this.@PatientID.Description = "Patient ID";
            this.@PatientID.Name = "@PatientID";
            this.@PatientID.Type = typeof(int);
            this.@PatientID.ValueInfo = "0";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ClarityDB_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "spGetPatientDetails";
            queryParameter1.Name = "@ParamPatientID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.@PatientID]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "spGetPatientDetails";
            storedProcQuery2.Name = "spGetPatientConsolidatedQuestionnaireList";
            queryParameter2.Name = "@ParamPatientID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.@PatientID]", typeof(int));
            queryParameter3.Name = "@ParamHistoryList";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("True", typeof(bool));
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.StoredProcName = "spGetPatientConsolidatedQuestionnaireList";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Heading2
            // 
            this.Heading2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.Heading2.LocationFloat = new DevExpress.Utils.PointFloat(8.900961E-05F, 105.5F);
            this.Heading2.Name = "Heading2";
            this.Heading2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Heading2.SizeF = new System.Drawing.SizeF(819.9999F, 23F);
            this.Heading2.StylePriority.UseFont = false;
            this.Heading2.StylePriority.UseForeColor = false;
            this.Heading2.StylePriority.UseTextAlignment = false;
            this.Heading2.Text = "Test Results Summary";
            this.Heading2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.lblRiskCategory,
            this.valRiskCategory,
            this.lblScore,
            this.valScore,
            this.lblTestDate,
            this.varTestDate,
            this.valQuestionnarieName});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("QuestionnaireName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 93.33334F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // valQuestionnarieName
            // 
            this.valQuestionnarieName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.valQuestionnarieName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedQuestionnaireList.QuestionnaireName")});
            this.valQuestionnarieName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valQuestionnarieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.valQuestionnarieName.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 0.583333F);
            this.valQuestionnarieName.Name = "valQuestionnarieName";
            this.valQuestionnarieName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valQuestionnarieName.SizeF = new System.Drawing.SizeF(819.9999F, 23F);
            this.valQuestionnarieName.StylePriority.UseBorders = false;
            this.valQuestionnarieName.StylePriority.UseFont = false;
            this.valQuestionnarieName.StylePriority.UseForeColor = false;
            this.valQuestionnarieName.StylePriority.UseTextAlignment = false;
            this.valQuestionnarieName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTestDate
            // 
            this.lblTestDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.lblTestDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 36.16667F);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTestDate.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.lblTestDate.StylePriority.UseFont = false;
            this.lblTestDate.StylePriority.UseForeColor = false;
            this.lblTestDate.Text = "Test Date:";
            // 
            // varTestDate
            // 
            this.varTestDate.AutoWidth = true;
            this.varTestDate.CanShrink = true;
            this.varTestDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedQuestionnaireList.CompletedDate")});
            this.varTestDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varTestDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.varTestDate.LocationFloat = new DevExpress.Utils.PointFloat(110.2082F, 36.16667F);
            this.varTestDate.Name = "varTestDate";
            this.varTestDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.varTestDate.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.varTestDate.StylePriority.UseFont = false;
            this.varTestDate.StylePriority.UseForeColor = false;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.lblScore.LocationFloat = new DevExpress.Utils.PointFloat(286.6665F, 36.16667F);
            this.lblScore.Name = "lblScore";
            this.lblScore.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblScore.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.lblScore.StylePriority.UseFont = false;
            this.lblScore.StylePriority.UseForeColor = false;
            this.lblScore.Text = "Score:";
            // 
            // valScore
            // 
            this.valScore.AutoWidth = true;
            this.valScore.CanShrink = true;
            this.valScore.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedQuestionnaireList.Score")});
            this.valScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valScore.LocationFloat = new DevExpress.Utils.PointFloat(396.8746F, 36.16667F);
            this.valScore.Name = "valScore";
            this.valScore.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valScore.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valScore.StylePriority.UseFont = false;
            this.valScore.StylePriority.UseForeColor = false;
            // 
            // lblRiskCategory
            // 
            this.lblRiskCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.lblRiskCategory.LocationFloat = new DevExpress.Utils.PointFloat(579.7917F, 36.16667F);
            this.lblRiskCategory.Name = "lblRiskCategory";
            this.lblRiskCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRiskCategory.SizeF = new System.Drawing.SizeF(116.8749F, 23F);
            this.lblRiskCategory.StylePriority.UseFont = false;
            this.lblRiskCategory.StylePriority.UseForeColor = false;
            this.lblRiskCategory.Text = "Risk Category:";
            // 
            // valRiskCategory
            // 
            this.valRiskCategory.AutoWidth = true;
            this.valRiskCategory.CanShrink = true;
            this.valRiskCategory.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedQuestionnaireList.RiskCategory")});
            this.valRiskCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valRiskCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valRiskCategory.LocationFloat = new DevExpress.Utils.PointFloat(696.6666F, 36.16667F);
            this.valRiskCategory.Name = "valRiskCategory";
            this.valRiskCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valRiskCategory.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valRiskCategory.StylePriority.UseFont = false;
            this.valRiskCategory.StylePriority.UseForeColor = false;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 68.33334F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(819.9999F, 25F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseBorders = false;
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Question";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 1.9483231668852394D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Answer";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 1.0516768331147606D;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.xrLine1.BorderWidth = 1F;
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(820F, 13.16666F);
            this.xrLine1.StylePriority.UseBorderColor = false;
            this.xrLine1.StylePriority.UseBorderWidth = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2});
            this.GroupFooter1.HeightF = 23.83331F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.RepeatEveryPage = true;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(8.900961E-05F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(819.9999F, 2.99998F);
            // 
            // ConsolidatedReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageFooter,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "spGetPatientDetails";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(11, 19, 14, 16);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.@PatientID});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clarityDBSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRLabel Heading2;
    private GroupHeaderBand GroupHeader1;
    private XRLabel valQuestionnarieName;
    private XRLabel lblTestDate;
    private XRLabel varTestDate;
    private XRLabel lblScore;
    private XRLabel valScore;
    private XRLabel lblRiskCategory;
    private XRLabel valRiskCategory;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRLine xrLine1;
    private GroupFooterBand GroupFooter1;
    private XRLine xrLine2;
}
