function NewQuestionnaireTextChanged(s, e) {
    lblQuestionnaireName.SetValue(s.GetValue());
    $('#QuestionnaireDetails').show();
}

function gvConfigEndCallback(s, e) {
    txtRiskThreshold.SetValue('');
    cmbRiskType.SetSelectedIndex(-1);
}