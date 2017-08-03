function OnPatientDblClick(s, e) {
    var key = s.GetRowKey(e.visibleIndex);
    alert(key);
    PatientDetailsPanel.PerformCallback(key);
}