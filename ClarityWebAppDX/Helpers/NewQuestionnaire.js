﻿function NewQuestionnaireTextChanged(s, e) {
    lblQuestionnaireName.SetValue(s.GetValue());
    $('#QuestionnaireDetails').show();
}

function gvConfigEndCallback(s, e) {
    txtMinValue.SetValue('');
    txtMaxValue.SetValue('');
    cmbRiskType.SetSelectedIndex(-1);
}

function OncmdAddThresholdClick (s, e) {
    e.processOnServer = false;
    if (ASPxClientEdit.ValidateGroup('Threshold')) {
        ConfigGridView.PerformCallback();
    }
}