using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for QuestionnaireResponse
/// </summary>
public class QuestionnaireResponse : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRPictureBox PPGLogo;
    private XRLabel DOB;
    private XRLabel LastName;
    private XRLabel FirstName;
    private XRLabel valDOB;
    private XRLabel valLasttName;
    private XRLabel valFirstName;
    private XRLabel RiskCategory;
    private XRLabel valRiskCategory;
    private XRLabel Score;
    private XRLabel valScore;
    private XRLabel TestDate;
    private XRLabel valTestDate;
    private XRLine HeaderLine;
    private PageFooterBand PageFooter;
    private XRLabel ReportDate;
    private XRPageInfo xrPageInfo1;
    private GroupHeaderBand GroupHeader1;
    private XRLabel Testname;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRPageInfo ReportDateVal;
    private FormattingRule ModerateRule;
    private FormattingRule HighRisk;
    private FormattingRule LowRisk;
    private DevExpress.XtraReports.Parameters.Parameter PQID;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public QuestionnaireResponse()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionnaireResponse));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.HeaderLine = new DevExpress.XtraReports.UI.XRLine();
            this.RiskCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.ModerateRule = new DevExpress.XtraReports.UI.FormattingRule();
            this.HighRisk = new DevExpress.XtraReports.UI.FormattingRule();
            this.LowRisk = new DevExpress.XtraReports.UI.FormattingRule();
            this.valRiskCategory = new DevExpress.XtraReports.UI.XRLabel();
            this.Score = new DevExpress.XtraReports.UI.XRLabel();
            this.valScore = new DevExpress.XtraReports.UI.XRLabel();
            this.TestDate = new DevExpress.XtraReports.UI.XRLabel();
            this.valTestDate = new DevExpress.XtraReports.UI.XRLabel();
            this.valDOB = new DevExpress.XtraReports.UI.XRLabel();
            this.valLasttName = new DevExpress.XtraReports.UI.XRLabel();
            this.DOB = new DevExpress.XtraReports.UI.XRLabel();
            this.LastName = new DevExpress.XtraReports.UI.XRLabel();
            this.PPGLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.FirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.valFirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportDateVal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.PatientResponses = new DevExpress.XtraReports.UI.XRLabel();
            this.Testname = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.AnswerVal = new DevExpress.XtraReports.UI.XRLabel();
            this.QuestionVal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.@PQID = new DevExpress.XtraReports.Parameters.Parameter();
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
            this.TopMargin.HeightF = 26F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 34F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.HeaderLine,
            this.RiskCategory,
            this.valRiskCategory,
            this.Score,
            this.valScore,
            this.TestDate,
            this.valTestDate,
            this.valDOB,
            this.valLasttName,
            this.DOB,
            this.LastName,
            this.PPGLogo,
            this.FirstName,
            this.valFirstName});
            this.PageHeader.HeightF = 103.5F;
            this.PageHeader.Name = "PageHeader";
            // 
            // HeaderLine
            // 
            this.HeaderLine.BorderWidth = 1F;
            this.HeaderLine.LineWidth = 2;
            this.HeaderLine.LocationFloat = new DevExpress.Utils.PointFloat(0F, 90.33335F);
            this.HeaderLine.Name = "HeaderLine";
            this.HeaderLine.SizeF = new System.Drawing.SizeF(802F, 13.16666F);
            this.HeaderLine.StylePriority.UseBorderWidth = false;
            // 
            // RiskCategory
            // 
            this.RiskCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiskCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.RiskCategory.FormattingRules.Add(this.ModerateRule);
            this.RiskCategory.FormattingRules.Add(this.HighRisk);
            this.RiskCategory.FormattingRules.Add(this.LowRisk);
            this.RiskCategory.LocationFloat = new DevExpress.Utils.PointFloat(560.7915F, 67.33335F);
            this.RiskCategory.Name = "RiskCategory";
            this.RiskCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.RiskCategory.SizeF = new System.Drawing.SizeF(122.2917F, 23F);
            this.RiskCategory.StylePriority.UseFont = false;
            this.RiskCategory.StylePriority.UseForeColor = false;
            this.RiskCategory.StylePriority.UseTextAlignment = false;
            this.RiskCategory.Text = "Risk Category:";
            this.RiskCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ModerateRule
            // 
            this.ModerateRule.Condition = "[RiskCategory]=\'Medium\'";
            this.ModerateRule.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.ModerateRule.Name = "ModerateRule";
            // 
            // HighRisk
            // 
            this.HighRisk.Condition = "[RiskCategory]=\'High\'";
            this.HighRisk.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.HighRisk.Name = "HighRisk";
            // 
            // LowRisk
            // 
            this.LowRisk.Condition = "[RiskCategory]=\'Low\'";
            this.LowRisk.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.LowRisk.Name = "LowRisk";
            // 
            // valRiskCategory
            // 
            this.valRiskCategory.AutoWidth = true;
            this.valRiskCategory.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.RiskCategory")});
            this.valRiskCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valRiskCategory.ForeColor = System.Drawing.Color.Black;
            this.valRiskCategory.FormattingRules.Add(this.ModerateRule);
            this.valRiskCategory.FormattingRules.Add(this.HighRisk);
            this.valRiskCategory.FormattingRules.Add(this.LowRisk);
            this.valRiskCategory.LocationFloat = new DevExpress.Utils.PointFloat(683.0833F, 67.33335F);
            this.valRiskCategory.Name = "valRiskCategory";
            this.valRiskCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.valRiskCategory.SizeF = new System.Drawing.SizeF(118.9167F, 23F);
            this.valRiskCategory.StylePriority.UseFont = false;
            this.valRiskCategory.StylePriority.UseForeColor = false;
            this.valRiskCategory.StylePriority.UsePadding = false;
            this.valRiskCategory.StylePriority.UseTextAlignment = false;
            this.valRiskCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.Score.LocationFloat = new DevExpress.Utils.PointFloat(560.7915F, 44.33333F);
            this.Score.Name = "Score";
            this.Score.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Score.SizeF = new System.Drawing.SizeF(122.2919F, 23F);
            this.Score.StylePriority.UseFont = false;
            this.Score.StylePriority.UseForeColor = false;
            this.Score.Text = "Score:";
            // 
            // valScore
            // 
            this.valScore.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.Score")});
            this.valScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valScore.LocationFloat = new DevExpress.Utils.PointFloat(683.0833F, 44.33334F);
            this.valScore.Name = "valScore";
            this.valScore.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valScore.SizeF = new System.Drawing.SizeF(118.9167F, 23F);
            this.valScore.StylePriority.UseFont = false;
            this.valScore.StylePriority.UseForeColor = false;
            this.valScore.StylePriority.UseTextAlignment = false;
            this.valScore.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TestDate
            // 
            this.TestDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.TestDate.LocationFloat = new DevExpress.Utils.PointFloat(560.7914F, 21.33335F);
            this.TestDate.Name = "TestDate";
            this.TestDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TestDate.SizeF = new System.Drawing.SizeF(122.2918F, 23F);
            this.TestDate.StylePriority.UseFont = false;
            this.TestDate.StylePriority.UseForeColor = false;
            this.TestDate.Text = "Test Date:";
            // 
            // valTestDate
            // 
            this.valTestDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.TestDate")});
            this.valTestDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTestDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valTestDate.LocationFloat = new DevExpress.Utils.PointFloat(683.0833F, 21.33334F);
            this.valTestDate.Name = "valTestDate";
            this.valTestDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valTestDate.SizeF = new System.Drawing.SizeF(118.9167F, 23F);
            this.valTestDate.StylePriority.UseFont = false;
            this.valTestDate.StylePriority.UseForeColor = false;
            this.valTestDate.StylePriority.UseTextAlignment = false;
            this.valTestDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // valDOB
            // 
            this.valDOB.AutoWidth = true;
            this.valDOB.CanShrink = true;
            this.valDOB.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.PatientDOB")});
            this.valDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valDOB.LocationFloat = new DevExpress.Utils.PointFloat(325.7083F, 67.33335F);
            this.valDOB.Name = "valDOB";
            this.valDOB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valDOB.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valDOB.StylePriority.UseFont = false;
            this.valDOB.StylePriority.UseForeColor = false;
            // 
            // valLasttName
            // 
            this.valLasttName.AutoWidth = true;
            this.valLasttName.CanShrink = true;
            this.valLasttName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.PatientLastName")});
            this.valLasttName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLasttName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valLasttName.LocationFloat = new DevExpress.Utils.PointFloat(325.7083F, 44.33333F);
            this.valLasttName.Name = "valLasttName";
            this.valLasttName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valLasttName.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valLasttName.StylePriority.UseFont = false;
            this.valLasttName.StylePriority.UseForeColor = false;
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.DOB.LocationFloat = new DevExpress.Utils.PointFloat(215.5F, 67.33335F);
            this.DOB.Name = "DOB";
            this.DOB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.DOB.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.DOB.StylePriority.UseFont = false;
            this.DOB.StylePriority.UseForeColor = false;
            this.DOB.Text = "Date of Birth:";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.LastName.LocationFloat = new DevExpress.Utils.PointFloat(215.5F, 44.33333F);
            this.LastName.Name = "LastName";
            this.LastName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LastName.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.LastName.StylePriority.UseFont = false;
            this.LastName.StylePriority.UseForeColor = false;
            this.LastName.Text = "Last Name:";
            // 
            // PPGLogo
            // 
            this.PPGLogo.Image = ((System.Drawing.Image)(resources.GetObject("PPGLogo.Image")));
            this.PPGLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.33334F);
            this.PPGLogo.Name = "PPGLogo";
            this.PPGLogo.SizeF = new System.Drawing.SizeF(198.75F, 59.16667F);
            this.PPGLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.FirstName.LocationFloat = new DevExpress.Utils.PointFloat(215.5F, 21.33335F);
            this.FirstName.Name = "FirstName";
            this.FirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.FirstName.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.FirstName.StylePriority.UseFont = false;
            this.FirstName.StylePriority.UseForeColor = false;
            this.FirstName.Text = "First Name:";
            // 
            // valFirstName
            // 
            this.valFirstName.AutoWidth = true;
            this.valFirstName.CanShrink = true;
            this.valFirstName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.PatientFirstName")});
            this.valFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valFirstName.LocationFloat = new DevExpress.Utils.PointFloat(325.7083F, 21.33335F);
            this.valFirstName.Name = "valFirstName";
            this.valFirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valFirstName.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valFirstName.StylePriority.UseFont = false;
            this.valFirstName.StylePriority.UseForeColor = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ReportDate,
            this.xrPageInfo1,
            this.ReportDateVal});
            this.PageFooter.HeightF = 36.66669F;
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportDate
            // 
            this.ReportDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.ReportDate.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportDate.SizeF = new System.Drawing.SizeF(99.16666F, 23F);
            this.ReportDate.StylePriority.UseFont = false;
            this.ReportDate.StylePriority.UseForeColor = false;
            this.ReportDate.Text = "Report Date";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.xrPageInfo1.Format = "Page {0}/{0}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(692F, 10F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            // 
            // ReportDateVal
            // 
            this.ReportDateVal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDateVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.ReportDateVal.Format = "{0:MMMM d, yyyy h:mm tt}";
            this.ReportDateVal.LocationFloat = new DevExpress.Utils.PointFloat(109.1667F, 10F);
            this.ReportDateVal.Name = "ReportDateVal";
            this.ReportDateVal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportDateVal.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.ReportDateVal.SizeF = new System.Drawing.SizeF(205.6667F, 23F);
            this.ReportDateVal.StylePriority.UseFont = false;
            this.ReportDateVal.StylePriority.UseForeColor = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PatientResponses,
            this.Testname});
            this.GroupHeader1.HeightF = 75.83334F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // PatientResponses
            // 
            this.PatientResponses.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientResponses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.PatientResponses.LocationFloat = new DevExpress.Utils.PointFloat(215.5F, 32.33335F);
            this.PatientResponses.Name = "PatientResponses";
            this.PatientResponses.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PatientResponses.SizeF = new System.Drawing.SizeF(371F, 29.66667F);
            this.PatientResponses.StylePriority.UseFont = false;
            this.PatientResponses.StylePriority.UseForeColor = false;
            this.PatientResponses.StylePriority.UseTextAlignment = false;
            this.PatientResponses.Text = "Patient Response";
            this.PatientResponses.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Testname
            // 
            this.Testname.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.QuestionnaireName")});
            this.Testname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.Testname.LocationFloat = new DevExpress.Utils.PointFloat(217.5F, 2.666677F);
            this.Testname.Name = "Testname";
            this.Testname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Testname.SizeF = new System.Drawing.SizeF(371F, 29.66667F);
            this.Testname.StylePriority.UseFont = false;
            this.Testname.StylePriority.UseForeColor = false;
            this.Testname.StylePriority.UseTextAlignment = false;
            this.Testname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "spGetPatientQuestionnaireDetailsReport";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.AnswerVal,
            this.QuestionVal,
            this.xrLine1});
            this.Detail1.HeightF = 79.16666F;
            this.Detail1.Name = "Detail1";
            // 
            // AnswerVal
            // 
            this.AnswerVal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientQuestionnaireDetailsReport.AnswerText")});
            this.AnswerVal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.AnswerVal.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99998F);
            this.AnswerVal.Name = "AnswerVal";
            this.AnswerVal.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 5, 0, 100F);
            this.AnswerVal.SizeF = new System.Drawing.SizeF(802F, 32.16665F);
            this.AnswerVal.StylePriority.UseFont = false;
            this.AnswerVal.StylePriority.UseForeColor = false;
            this.AnswerVal.StylePriority.UsePadding = false;
            // 
            // QuestionVal
            // 
            this.QuestionVal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientQuestionnaireDetailsReport.QuestionText")});
            this.QuestionVal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionVal.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.QuestionVal.Name = "QuestionVal";
            this.QuestionVal.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 10, 100F);
            this.QuestionVal.SizeF = new System.Drawing.SizeF(802F, 23F);
            this.QuestionVal.StylePriority.UseFont = false;
            this.QuestionVal.StylePriority.UsePadding = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55.16663F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(802F, 23F);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ClarityDB_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "spGetPatientQuestionnaireDetailsReport";
            queryParameter1.Name = "@ParamPQID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.@PQID]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "spGetPatientQuestionnaireDetailsReport";
            storedProcQuery2.Name = "spGetPatientDetailsReport";
            queryParameter2.Name = "@ParamPQID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.@PQID]", typeof(int));
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "spGetPatientDetailsReport";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // @PQID
            // 
            this.@PQID.Description = "PQID";
            this.@PQID.Name = "@PQID";
            this.@PQID.Type = typeof(int);
            this.@PQID.ValueInfo = "0";
            this.@PQID.Visible = false;
            // 
            // QuestionnaireResponse
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "spGetPatientDetailsReport";
            this.DataSource = this.sqlDataSource1;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.ModerateRule,
            this.HighRisk,
            this.LowRisk});
            this.Margins = new System.Drawing.Printing.Margins(25, 23, 26, 34);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.@PQID});
            this.RequestParameters = false;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void lblReportName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
    }
    private XRLabel PatientResponses;
    private XRLabel AnswerVal;
    private XRLabel QuestionVal;
    private XRLine xrLine1;
}
