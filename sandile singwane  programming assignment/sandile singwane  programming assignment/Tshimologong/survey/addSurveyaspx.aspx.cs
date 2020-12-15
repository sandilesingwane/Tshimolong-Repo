using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using System.Configuration;
public partial class survey_addSurveyaspx : System.Web.UI.Page
{
    OdbcConnection tshimologongConn = new OdbcConnection(ConfigurationManager.ConnectionStrings["ConnectionStringTshimologong"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            tshimologongConn.Open();

            var foodType ="";

            for(int r =0;r < CheckBoxList1.Items.Count; r++)
            {
                if(CheckBoxList1.Items[r].Selected)
                {
                    foodType = CheckBoxList1.Items[r].Text + '\t';
                    
                }
            }
            //if(CheckBoxList1.SelectedItem.ToString() == "")
            //{
            //    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "scriptClient", "alert(' please select your favourite food')", true);
            //    return;
            //}
            string addUserDetail = "INSERT INTO  userDetail(surname,fName,contact,date,age,foodChoice,eatOut,watchMovie,watchTv,listenRadio) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + foodType +"','" + RadioButtonListEatOut.SelectedValue +"','" +RadioButtonListwMovies.SelectedValue +"','" + RadioButtonListwTV.SelectedValue +"','" + RadioButtonListlRadio.SelectedValue+"')";
            OdbcCommand userCommand = new OdbcCommand(addUserDetail, tshimologongConn);
            userCommand.ExecuteNonQuery();

            TextBox5.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox1.Text = string.Empty;
         
            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "scriptClient", "alert(' you have successfully completed our survey  ')", true);
            return;
        }
        catch(OdbcException)
        {

            ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "scriptClient", "alert(' you have not completed our survey please try again later  ')", true);

            return;
        }
        finally
        {
            tshimologongConn.Close();
        }
    }
    
}