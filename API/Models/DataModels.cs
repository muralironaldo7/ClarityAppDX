using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;

namespace API.Models
{
    public class StaffAuthenticationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class StaffAuthenticationResponse
    {
        //public DataTable UserData { get; set; }
        public long LoginID { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserToken { get; set; }
        public string ErrorMessage { get; set; }

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public StaffAuthenticationResponse()
        {
            
            this.IsAuthenticated = false;
            this.ErrorMessage = "";
        }
    }

    public class PatientListRequest
    {
        public string LoginID { get; set; }
        public string AccountNumber { get; set; }
        public string UserToken { get; set; }

        public PatientListRequest()
        {
            this.LoginID = "0";
            this.UserToken = "";
        }
    }

    public class PatientListResponse
    {
        public ArrayList PatientList { get; set; }
        //public DataTable PatientListDataTable { get; set; }
        public List<PatientDetails> PatientDetailsList { get; set; }
        public string ErrorMessage { get; set; }

        public PatientListResponse()
        {
            this.ErrorMessage = "";
        }
    }

    public class PatientVerifiactionRequest
    {
        public string PatientID { get; set; }
        public string UserToken { get; set; }
        public string LoginID { get; set; }
        public bool LogVerificaiton { get; set; }
    }

    public class PatientVerificationResponse
    {
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string MaskedName { get; set; }
        public string DOB { get; set; }
        public string ErrorMessage { get; set; }
        public string AccountNumber { get; set; }
        public string PhysicianName { get; set; }
    }

    public class PatientQuestionnaireRequest
    {
        public string PatientID { get; set; }
        public string UserToken { get; set; }
    }

    public class PatientQuestionnaireResponse
    {
        public List<QuestionnaireDetails> QuestionnaireList { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class PatientDetails
    {
        public string PatientName { get; set; }
        public string PatientID { get; set; }
        public string AccountNumber { get; set; }
        public string DOB { get; set; }
        public string PhysicianName { get; set; }
        public string MaskedName { get; set; }
        public List<QuestionnaireDetails> QuestionnaireList { get; set; }

        public PatientDetails(string PatientName, string PatientID, string AccNo, string DOB, string PhysicianName)
        {
            this.PatientName = PatientName;
            this.PatientID = PatientID;
            this.AccountNumber = AccNo;
            this.DOB = DOB;
            this.PhysicianName = PhysicianName;
        }

        public PatientDetails(string PatientName, string PatientID)
        {
            this.PatientID = PatientID;
            this.PatientName = PatientName;
        }
    }

    public class QuestionnaireDetails
    {
        public string PatientQuestionnaireID { get; set; }
        public string QuestionnaireID { get; set; }
        public string QuestionnaireName { get; set; }
        public string ScheduledDate { get; set; }
        public string Score { get; set; }
        public string RiskCategory { get; set; }

        public QuestionnaireDetails(string QID, string QName, string sDate, string score, string Category, string PQID)
        {
            this.PatientQuestionnaireID = PQID;
            this.QuestionnaireID = QID;
            this.QuestionnaireName = QName;
            this.ScheduledDate = sDate;
            this.Score = score;
            this.RiskCategory = Category;
        }
    }

    public class QuestionnaireQuestionsRequest
    { 
        public string QuestionnaireID { get; set; }
        public string PQID { get; set; }
        public string UserToken { get; set; }

    }

    public class QuestionDetail
    {
        public string QuestionID { get; set; }
        public string QuestionText { get; set; }
        public List<AnswerDetail> QuestionAnswers { get; set; }

        public QuestionDetail()
        {
            this.QuestionAnswers = new List<AnswerDetail>();
        }
    }

    public class AnswerDetail
    {
        public string AnswerID { get; set; }
        public string AnswerText { get; set; }
        public bool SelectedAnswer { get; set; }
        public int AnswerPoints { get; set; }
    }

    public class QuestionaireQuestionResponse
    {
        public List<QuestionDetail> QuestionAnswerList { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class SaveQuestionnaireRequest
    {
        public string PatientID { get; set; }
        public string QuestionnaireID { get; set; }
        public string PatientQuestionnaireID { get; set; }
        public DateTime QuestionnaireStartDate { get; set; }
        public List<QuestionDetail> QuestionAnswerList { get; set; }
        public string UserToken { get; set; }
    }

    public class SaveQuestionnaireResponse
    {
        public bool SaveStatus { get; set; }
        public string ErrorMessage { get; set; }

        public SaveQuestionnaireResponse()
        {
            SaveStatus = false;
        }
    }
}