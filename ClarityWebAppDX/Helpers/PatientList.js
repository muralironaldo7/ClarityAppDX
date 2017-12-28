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
    if (s.cpReportPatientID != null)
    {
        if (s.cpReportPatientID) {
            if (s.cpButtonID != null)
            {
                if (s.cpButtonID == 'ConsolidatedReport') {
                    window.open('ReportViewer.aspx?PatientID=' + s.cpReportPatientID + '&Type=PatientReport', '_blank');
                }
                else if (s.cpButtonID == 'LatestVisit') {
                    window.open('ReportViewer.aspx?PatientID=' + s.cpReportPatientID + '&Type=VisitDetails', '_blank');
                }
            }
            delete s.cpButtonID;
            delete s.cpReportPatientID;
        }
    }
    
}