using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{

    public string user, pass;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(Page.IsPostBack == true)
        {
            labelex.Text = "Se insertó Correctamente";
        }
        else
        {
            labelex.Text = "Manco";
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {

         
       
        user = txtuser.Text;
        pass = txtpass.Text;

        string auxUser = "", auxPass = "";
        string URL = "~/lobby.aspx", query;
        URL = Page.ResolveClientUrl(URL);

        


        if (txtuser.Text != "" && txtpass.Text != "") {

            
            SqlConnection conexion = new SqlConnection("Server=tcp:kobranza-server.database.windows.net,1433;Initial Catalog=kobranzaDB;Persist Security Info=False;User ID=kobranza-server-admin;Password=C43386T17CPRC5VM$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //query = "INSERT INTO Gestor VALUES(5, 'Marjorie Caballero', 'mcaballero', '1234', 0)";
                query = "SELECT pass FROM Gestor WHERE usuario = '" + user + "'";
                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();

                SqlDataReader sqlLector = comando.ExecuteReader();
                 if (sqlLector.HasRows)
                {

                    sqlLector.Read();
                    auxPass = sqlLector.GetString(0);
                    
                    if (auxPass == "1234")
                    {
                            
                        Response.Redirect(URL);

                    }

                    
                }




               

            }

        }
        else
        {
            if(txtuser.Text == "" || txtpass.Text == "")
            {
                txtuser.Text = "";
                txtpass.Text = "";
                
                
            }
        }


    }

   
}