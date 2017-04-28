using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaKlientow
{
    public partial class Frm_Loguj : Form
    {
        
        public Frm_Loguj()
        {
            InitializeComponent();
            
        }

        public string getPassword()
        {
            lbl_error.Text = "";
            string haslo = "";

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=A515;Initial Catalog=Users;Integrated Security=True";
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT Password FROM Login WHERE Id = 1", conn);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            haslo = reader.GetValue(0).ToString();
                        }
                    }
                }
            }catch(Exception e)
            {
                lbl_error.Text = "Brak połączenia z bazą danych";
            }

            return haslo;
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbl_warning.Text = "";
                if(getPassword() == txt_password.Text)
                {
                    this.Hide();
                    Frm_Panel frm_panel = new Frm_Panel();
                    frm_panel.Show();
                }
                else
                {
                    txt_password.Text = "";
                    lbl_warning.Text = "Błędne hasło !";
                }
            }
        }
    }
}
