using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProiectII
{
    public partial class FormCreateAcc : Form
    {
        public FormCreateAcc()
        {
            InitializeComponent();
        }

        private void but2_CreateAcc_Click(object sender, EventArgs e)
        {

            if (textBox_Username.Text != "" && textBox_Pass.Text != "" && textBox_PassCon.Text !="") // verifica campurile pentru a nu fi goale
            {
                if (textBox_Pass.Text == textBox_PassCon.Text) // parolele trebuie sa coincida
                {
                    // facem conexiunea si creem adapter-ul sda
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raul Detesan\OneDrive\Desktop\II\ProiectII\ProiectII\UsersCredentials.mdf;Integrated Security=True";
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM CredentialsTable WHERE username='" + textBox_Username.Text + "' AND password='" + textBox_Pass.Text + "'", connectionString);

                    // facem query de inserat in baza de date
                    string query = "INSERT INTO CredentialsTable (Username, Password) VALUES (@Username, @Password)";

                    DataTable dt = new DataTable(); 
                    sda.Fill(dt); // populam tabela virtuala dt cu rezultatele adapter-ului sda

                    if (dt.Rows[0][0].ToString() == "1") // verificam daca exista un cont cu acelasi username si aceeasi parola
                    {
                        MessageBox.Show("Username indisponibil!"); // exista un cont identic, dam eroare si nu merge programul mai departe

                    }
                    else // nu exista contul pe care vrem sa il cream in baza de date, continuam cu insertia
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                string username = textBox_Username.Text;
                                string password = textBox_Pass.Text;  // luam textul din texboxuri


                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", password); 


                                command.ExecuteNonQuery();// introducem textul in baza de date
                            }
                            MessageBox.Show("Cont creat cu succes!"); 
                        }
                    }

                }else MessageBox.Show("Parolele introduse nu sunt similare!");
                
            }
            else MessageBox.Show("Eroare in creearea contului! Un element este nul.", "Error!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
