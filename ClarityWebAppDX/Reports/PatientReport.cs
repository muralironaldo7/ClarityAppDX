using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for PatientReport
/// </summary>
public class PatientReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLabel valFirstName;
    private XRLabel FirstName;
    private XRPictureBox PPGLogo;
    private XRLabel LastName;
    private XRLabel DOB;
    private XRLabel valLasttName;
    private XRLabel valDOB;
    private XRLine HeaderLine;
    private PageFooterBand PageFooter;
    private XRLine xrLine1;
    private XRLabel ReportDate;
    private XRPageInfo ReportDateVal;
    private XRPageInfo xrPageInfo1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public PatientReport()
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.valFirstName = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 133.3333F;
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
            this.valFirstName,
            this.FirstName,
            this.PPGLogo,
            this.LastName,
            this.DOB,
            this.valLasttName,
            this.valDOB,
            this.HeaderLine});
            this.ReportHeader.HeightF = 92.16669F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // valFirstName
            // 
            this.valFirstName.AutoWidth = true;
            this.valFirstName.CanShrink = true;
            this.valFirstName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.PatientFirstName")});
            this.valFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valFirstName.LocationFloat = new DevExpress.Utils.PointFloat(288.3332F, 20.33334F);
            this.valFirstName.Name = "valFirstName";
            this.valFirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valFirstName.SizeF = new System.Drawing.SizeF(123.3333F, 23F);
            this.valFirstName.StylePriority.UseFont = false;
            this.valFirstName.StylePriority.UseForeColor = false;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.FirstName.LocationFloat = new DevExpress.Utils.PointFloat(178.125F, 20.33334F);
            this.FirstName.Name = "FirstName";
            this.FirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.FirstName.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.FirstName.StylePriority.UseFont = false;
            this.FirstName.StylePriority.UseForeColor = false;
            this.FirstName.Text = "First Name:";
            // 
            // PPGLogo
            // 
            this.PPGLogo.ImageUrl = "C:\\Users\\mvenugopalan\\Desktop\\Personal\\Projects\\ClarityAppDX\\ClarityWebAppDX\\Imag" +
    "es\\logo.png";
            this.PPGLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.PPGLogo.Name = "PPGLogo";
            this.PPGLogo.SizeF = new System.Drawing.SizeF(148.9583F, 69.00002F);
            this.PPGLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.LastName.LocationFloat = new DevExpress.Utils.PointFloat(178.125F, 43.33334F);
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
            this.DOB.LocationFloat = new DevExpress.Utils.PointFloat(499.7917F, 20.33334F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.PatientLastName")});
            this.valLasttName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLasttName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valLasttName.LocationFloat = new DevExpress.Utils.PointFloat(288.3332F, 43.33334F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetailsReport.PatientDOB")});
            this.valDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valDOB.LocationFloat = new DevExpress.Utils.PointFloat(609.9999F, 20.33334F);
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
            this.HeaderLine.LocationFloat = new DevExpress.Utils.PointFloat(0F, 79.00003F);
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
            // PatientReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(11, 19, 14, 16);
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
