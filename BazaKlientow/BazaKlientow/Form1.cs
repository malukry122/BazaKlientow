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
        string haslo = "";
        public Frm_Loguj()
        {
            InitializeComponent();
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
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbl_warning.Text = "";
                if(haslo == txt_password.Text)
                {
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
