function OncmdEditConfigurationClick(s, e) {
    e.processOnServer = false;
    ConfigGridView.PerformCallback();
}

var EditMode = false;
function OncmdEditQuestionnaireNameClick(s, e) {
    e.processOnServer = false;
    if (EditMode) {
        EditMode = false;
        txtQuestionnaireName.SetEnabled(false);
        cmdEditQuestionnaireName.SetText('Edit');
    }
    else{
        EditMode = true;
        txtQuestionnaireName.SetEnabled(true);
        cmdEditQuestionnaireName.SetText('Save');
    }
}

function OncmbQuestionnaireListChanged(s, e) {
    ConfigGridView.PerformCallback();
}