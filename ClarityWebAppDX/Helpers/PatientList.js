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