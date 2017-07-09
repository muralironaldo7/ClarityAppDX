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

//function OncmbQuestionnaireListChanged(s, e) {
//    ConfigGridView.PerformCallback();
//}

var rowText;
var selectionState;
var cIndex;
var rowKey;
function OnAnswerListGridViewSelectionChanged(s, e) {
    cIndex = e.visibleIndex;
    rowKey = s.GetRowKey(cIndex);
    selectionState = e.isSelected
    s.GetRowValues(cIndex, 'AnswerText', GetRowValues);
}

function GetRowValues(values) {
    rowText = values;
    lbSelectedAnswers.BeginUpdate()
    if (selectionState) {
        lbSelectedAnswers.AddItem(rowText, rowKey);
    }
    else {
        var item = lbSelectedAnswers.FindItemByValue(rowKey);
        lbSelectedAnswers.RemoveItem(item.index);
    }
    lbSelectedAnswers.EndUpdate()

    rowText = null;
    selectionState = null;
    rowKey = null;
    cIndex = null;

}