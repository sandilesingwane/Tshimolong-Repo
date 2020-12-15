using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using System.Configuration;
using System.Threading.Tasks;
public partial class survey_surveyResults : System.Web.UI.Page
{
     OdbcConnection tshimologongConn = new OdbcConnection(ConfigurationManager.ConnectionStrings["ConnectionStringTshimologong"].ConnectionString);
  
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            tshimologongConn.Open();
            //****************************Total number of survey***************************************************
            string totSurvey = "SELECT COUNT(s_id) FROM userdetail";
            OdbcCommand surveyTotal = new OdbcCommand(totSurvey, tshimologongConn);
            int sumSurvey = Convert.ToInt32(surveyTotal.ExecuteScalar());
            Label12.Visible = true;
            Label12.Text = "" + sumSurvey;
            //*****************************age average *************************************************************
            string aveAge = " SELECT SUM(age) FROM userdetail";
            OdbcCommand ageCommand = new OdbcCommand(aveAge, tshimologongConn);
            int averageAge = Convert.ToInt32(ageCommand.ExecuteScalar());
            Label13.Visible = true;
            Label13.Text = "" + (averageAge / sumSurvey);
            //***************************oldest person completed the survey******************************************
            string maximumAge = "SELECT fName FROM userdetail WHERE age  =(SELECT MAX(age)  FROM userdetail) ";
            OdbcCommand maxAgeCommand  = new OdbcCommand(maximumAge, tshimologongConn);
            string orderPerson = maxAgeCommand.ExecuteScalar().ToString();
            Label14.Visible = true;
            Label14.Text = orderPerson;

            //***************************youngest person completed the survey****************************************
            string mINImumAge = "SELECT fName FROM userdetail WHERE age  =(SELECT MIN(age)  FROM userdetail)";
            OdbcCommand minAgeCommand = new OdbcCommand(mINImumAge, tshimologongConn);
            string youngerPerson = minAgeCommand.ExecuteScalar().ToString();
            Label15.Visible = true;
            Label15.Text =  youngerPerson;


            //===============PERCENTAGES OF PEOPLE FOOD CHOICES===================================================

            //===PEOPLE WHO EAT PIZZA=========

            string eatPizza = "SELECT COUNT(s_id) FROM userdetail WHERE foodChoice ='Pizza	'";
            OdbcCommand pizzaCommand = new OdbcCommand(eatPizza, tshimologongConn);
            double pizzaPercentage = Convert.ToDouble(pizzaCommand.ExecuteScalar());
            Label16.Visible = true;
            Label16.Text = ( pizzaPercentage / sumSurvey) * 100 + "%";

            //====================percentage of people who like PASTA===============================================
            string eatPasta = "SELECT COUNT(s_id) FROM userdetail WHERE foodChoice ='Pasta	' ";
            OdbcCommand pastaCommand = new OdbcCommand(eatPasta, tshimologongConn);
            double pastaPercentage = Convert.ToDouble(pastaCommand.ExecuteScalar());
            Label17.Visible = true;
            Label17.Text = (pastaPercentage / sumSurvey) * 100 + "%";

            //=======================percentage of people who like pap and wors =====================================
            string eatPap = "SELECT COUNT(s_id) FROM userdetail WHERE foodChoice ='Pap and Wors	' ";
            OdbcCommand papCommand = new OdbcCommand(eatPap, tshimologongConn);
            double papPercentage = Convert.ToDouble(papCommand.ExecuteScalar());
            Label18.Visible = true;
            Label18.Text = (papPercentage / sumSurvey) * 100 + "%";

            //================================percentage who like chicken stir fry=======================================

            string eatChicken = "SELECT COUNT(s_id) FROM userdetail WHERE foodChoice ='Chicken stir fry	' ";
            OdbcCommand chickenCommand = new OdbcCommand(eatChicken, tshimologongConn);
            double chickenPercentage = Convert.ToDouble(chickenCommand.ExecuteScalar());
            Label26.Visible = true;
            Label26.Text = (chickenPercentage / sumSurvey) * 100 + "%";

            //*********************************percentage who like chicken stir fry**********************************
            string eatBeef = "SELECT COUNT(s_id) FROM userdetail WHERE foodChoice ='' ";
            OdbcCommand beefCommand = new OdbcCommand(eatBeef, tshimologongConn);
            double beefPercentage = Convert.ToDouble(beefCommand.ExecuteScalar());
            Label27.Visible = true;
            Label27.Text = (beefPercentage / sumSurvey) * 100 + "%";
            //===================================percentage who like beef stir fry====================================

            string eatOther = "SELECT COUNT(s_id) FROM userdetail WHERE foodChoice ='Other	' ";
            OdbcCommand otherCommand = new OdbcCommand(eatOther, tshimologongConn);
            double otherPercentage = Convert.ToDouble(otherCommand.ExecuteScalar());
            Label28.Visible = true;
            Label28.Text = (otherPercentage / sumSurvey) * 100 + "%";
            //=====================================people like to eat out==================================================================
            string eatOutString = "SELECT COUNT(s_id) FROM userdetail WHERE eatOut ='1' ";
            OdbcCommand eatOutCommand = new OdbcCommand(eatOutString, tshimologongConn);
            double eatOutPercentage = Convert.ToDouble(eatOutCommand.ExecuteScalar());
            Label19.Visible = true;
            Label19.Text = (eatOutPercentage / sumSurvey) * 100 + "%";

            //===========================people watch movie==================================================================================
            string watchMovieString = "SELECT COUNT(s_id) FROM userdetail WHERE watchMovie ='1' ";
            OdbcCommand watchMovieCommand = new OdbcCommand(watchMovieString, tshimologongConn);
            double watchMoviePercentage = Convert.ToDouble(watchMovieCommand.ExecuteScalar());
            Label20.Visible = true;
            Label20.Text = (watchMoviePercentage / sumSurvey) * 100 + "%";
            
          //============================== people like  to watch tv =====================================================================================
            string watchTVString = "SELECT COUNT(s_id) FROM userdetail WHERE watchTv ='1' ";
            OdbcCommand watchTVCommand = new OdbcCommand(watchTVString, tshimologongConn);
            double watchTVPercentage = Convert.ToDouble(watchTVCommand.ExecuteScalar());
            Label21.Visible = true;
            Label21.Text = (watchTVPercentage / sumSurvey) * 100 + "%";
          
           //===================================== PEOPLE LIKE LISTEN TO RADIO ======================================================================

            string listenRadioString = "SELECT COUNT(s_id) FROM userdetail WHERE listenRadio ='1' ";
            OdbcCommand listenRadioCommand = new OdbcCommand(listenRadioString, tshimologongConn);
            double listenRadioPercentage = Convert.ToDouble(watchMovieCommand.ExecuteScalar());
            Label22.Visible = true;
            Label22.Text = (listenRadioPercentage / sumSurvey) * 100 + "%";
        
        }
        catch (OdbcException)
        {

        }
        finally
        {
            tshimologongConn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Default.aspx");
    }
}