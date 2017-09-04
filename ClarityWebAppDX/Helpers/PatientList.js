function OnPatientDblClick(s, e) {
    var key = s.GetRowKey(e.visibleIndex);
    PatientDetailsPanel.PerformCallback(key);
}

function gvQuestionnaireHistoryEndCallback(s, e) {
    if (s.cpReportPQID)
    {
        window.open('ReportViewer.aspx?PQID=' + s.cpReportPQID + '&Type=QuestionnaireResponse', '_blank');
    }
}

function OnPatientListGridViewEndCallback(s, e) {
    if (s.cpReportPatientID) {
        window.open('ReportViewer.aspx?PatientID=' + s.cpReportPatientID + '&Type=PatientReport', '_blank');
    }
}