namespace ClarityWebAppDX.Reports
{
    partial class TestSummaryReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSummaryReport));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Heading = new DevExpress.XtraReports.UI.XRLabel();
            this.PPGLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.FirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.LastName = new DevExpress.XtraReports.UI.XRLabel();
            this.DOB = new DevExpress.XtraReports.UI.XRLabel();
            this.valFirstName = new DevExpress.XtraReports.UI.XRLabel();
            this.valLasttName = new DevExpress.XtraReports.UI.XRLabel();
            this.valDOB = new DevExpress.XtraReports.UI.XRLabel();
            this.HeaderLine = new DevExpress.XtraReports.UI.XRLine();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Testname = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.QuestionCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.AnswerCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.@PatientID = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 20F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.HeaderLine,
            this.valFirstName,
            this.valLasttName,
            this.valDOB,
            this.FirstName,
            this.LastName,
            this.DOB,
            this.PPGLogo,
            this.Heading});
            this.ReportHeader.HeightF = 113.3333F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // Heading
            // 
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.Heading.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Heading.Name = "Heading";
            this.Heading.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Heading.SizeF = new System.Drawing.SizeF(819.9999F, 23F);
            this.Heading.StylePriority.UseFont = false;
            this.Heading.StylePriority.UseForeColor = false;
            this.Heading.StylePriority.UseTextAlignment = false;
            this.Heading.Text = "Patient Summary";
            this.Heading.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PPGLogo
            // 
            this.PPGLogo.Image = ((System.Drawing.Image)(resources.GetObject("PPGLogo.Image")));
            this.PPGLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30.1667F);
            this.PPGLogo.Name = "PPGLogo";
            this.PPGLogo.SizeF = new System.Drawing.SizeF(198.75F, 59.16667F);
            this.PPGLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.FirstName.LocationFloat = new DevExpress.Utils.PointFloat(486.5625F, 30.1667F);
            this.FirstName.Name = "FirstName";
            this.FirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.FirstName.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.FirstName.StylePriority.UseFont = false;
            this.FirstName.StylePriority.UseForeColor = false;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.LastName.LocationFloat = new DevExpress.Utils.PointFloat(486.5625F, 53.16668F);
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
            this.DOB.LocationFloat = new DevExpress.Utils.PointFloat(486.5625F, 76.16669F);
            this.DOB.Name = "DOB";
            this.DOB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.DOB.SizeF = new System.Drawing.SizeF(110.2083F, 23F);
            this.DOB.StylePriority.UseFont = false;
            this.DOB.StylePriority.UseForeColor = false;
            this.DOB.Text = "Date of Birth:";
            // 
            // valFirstName
            // 
            this.valFirstName.AutoWidth = true;
            this.valFirstName.CanShrink = true;
            this.valFirstName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetails.PatientFirstName")});
            this.valFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valFirstName.LocationFloat = new DevExpress.Utils.PointFloat(596.7708F, 30.16668F);
            this.valFirstName.Name = "valFirstName";
            this.valFirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valFirstName.SizeF = new System.Drawing.SizeF(213.2292F, 23F);
            this.valFirstName.StylePriority.UseFont = false;
            this.valFirstName.StylePriority.UseForeColor = false;
            // 
            // valLasttName
            // 
            this.valLasttName.AutoWidth = true;
            this.valLasttName.CanShrink = true;
            this.valLasttName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientDetails.PatientLastName")});
            this.valLasttName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valLasttName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.valLasttName.LocationFloat = new DevExpress.Utils.PointFloat(596.7708F, 53.16666F);
            this.valLasttName.Name = "valLasttName";
            this.valLasttName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valLasttName.SizeF = new System.Drawing.SizeF(213.2292F, 23F);
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
            this.valDOB.LocationFloat = new DevExpress.Utils.PointFloat(596.7708F, 76.16666F);
            this.valDOB.Name = "valDOB";
            this.valDOB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.valDOB.SizeF = new System.Drawing.SizeF(213.2292F, 23F);
            this.valDOB.StylePriority.UseFont = false;
            this.valDOB.StylePriority.UseForeColor = false;
            // 
            // HeaderLine
            // 
            this.HeaderLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.HeaderLine.BorderWidth = 1F;
            this.HeaderLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.HeaderLine.LineWidth = 2;
            this.HeaderLine.LocationFloat = new DevExpress.Utils.PointFloat(0F, 99.16666F);
            this.HeaderLine.Name = "HeaderLine";
            this.HeaderLine.SizeF = new System.Drawing.SizeF(820F, 13.16666F);
            this.HeaderLine.StylePriority.UseBorderColor = false;
            this.HeaderLine.StylePriority.UseBorderWidth = false;
            this.HeaderLine.StylePriority.UseForeColor = false;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1});
            this.DetailReport.DataMember = "spGetPatientConsolidatedTestSummary";
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
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.Testname});
            this.GroupHeader1.HeightF = 51.33334F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // Testname
            // 
            this.Testname.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedTestSummary.TestTakenDate")});
            this.Testname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.Testname.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Testname.Name = "Testname";
            this.Testname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Testname.SizeF = new System.Drawing.SizeF(371F, 29.66667F);
            this.Testname.StylePriority.UseFont = false;
            this.Testname.StylePriority.UseForeColor = false;
            this.Testname.StylePriority.UseTextAlignment = false;
            this.Testname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(545.0001F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.QuestionCell,
            this.AnswerCell,
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // QuestionCell
            // 
            this.QuestionCell.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.QuestionCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedTestSummary.QuestionnaireName")});
            this.QuestionCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.QuestionCell.Name = "QuestionCell";
            this.QuestionCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.QuestionCell.StylePriority.UseBorders = false;
            this.QuestionCell.StylePriority.UseFont = false;
            this.QuestionCell.StylePriority.UseForeColor = false;
            this.QuestionCell.StylePriority.UsePadding = false;
            this.QuestionCell.Weight = 0.55503067798377725D;
            // 
            // AnswerCell
            // 
            this.AnswerCell.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AnswerCell.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedTestSummary.Score")});
            this.AnswerCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.AnswerCell.Name = "AnswerCell";
            this.AnswerCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.AnswerCell.StylePriority.UseBorders = false;
            this.AnswerCell.StylePriority.UseFont = false;
            this.AnswerCell.StylePriority.UseForeColor = false;
            this.AnswerCell.StylePriority.UsePadding = false;
            this.AnswerCell.Weight = 0.63704261869422074D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spGetPatientConsolidatedTestSummary.RiskCategory")});
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(179)))), ((int)(((byte)(74)))));
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Weight = 0.801829737357515D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(43)))), ((int)(((byte)(124)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(652F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(146.5F, 29.66667F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Notes";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ClarityDB_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"208\" />";
            storedProcQuery1.Name = "spGetPatientConsolidatedTestSummary";
            queryParameter1.Name = "@ParamPatientID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.@PatientID]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "spGetPatientConsolidatedTestSummary";
            storedProcQuery2.MetaSerializable = "<Meta X=\"140\" Y=\"20\" Width=\"100\" Height=\"254\" />";
            storedProcQuery2.Name = "spGetPatientDetails";
            queryParameter2.Name = "@ParamPatientID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.@PatientID]", typeof(int));
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "spGetPatientDetails";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // @PatientID
            // 
            this.@PatientID.Description = "Patient ID";
            this.@PatientID.Name = "@PatientID";
            this.@PatientID.Type = typeof(int);
            this.@PatientID.ValueInfo = "0";
            this.@PatientID.Visible = false;
            // 
            // TestSummaryReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "spGetPatientDetails";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(12, 18, 20, 20);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.@PatientID});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel Heading;
        private DevExpress.XtraReports.UI.XRPictureBox PPGLogo;
        private DevExpress.XtraReports.UI.XRLabel FirstName;
        private DevExpress.XtraReports.UI.XRLabel LastName;
        private DevExpress.XtraReports.UI.XRLabel DOB;
        private DevExpress.XtraReports.UI.XRLabel valFirstName;
        private DevExpress.XtraReports.UI.XRLabel valLasttName;
        private DevExpress.XtraReports.UI.XRLabel valDOB;
        private DevExpress.XtraReports.UI.XRLine HeaderLine;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel Testname;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell QuestionCell;
        private DevExpress.XtraReports.UI.XRTableCell AnswerCell;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter PatientID;
    }
}
