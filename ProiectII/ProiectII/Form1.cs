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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // login buton
        {
            string username = textBox_Username.Text;
            string password =  textBox_Password.Text; // parola si username stocate in variabile 

            if (username != "" && password != "") // sa nu fie vreun camp gol
            {
                // facem conexiunea la baza de date
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raul Detesan\OneDrive\Desktop\II\ProiectII\ProiectII\UsersCredentials.mdf;Integrated Security=True";

                // stocam in adapterul "sda" toate campurile din baza de date care au username = variabila username si password = variabile password
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM CredentialsTable WHERE username='" + username + "' AND password='" + password + "'", connectionString);

                DataTable dt = new DataTable();  
                sda.Fill(dt); // facem un tabel virtual si introducem datele adapter-ului "sda" in el

                if (dt.Rows[0][0].ToString() == "1") // daca primul element este 1, inseamna ca a gasit un match pentru username si parola din textboxuri in baza de date
                {
                    MessageBox.Show("Logat cu succes!"); // contul exista deci login cu succes
                }
                else MessageBox.Show("Username sau parola incorecta!"); // contul nu exista -> eroare
            }
            else MessageBox.Show("Unul din elemente este nul!", "Eroare!"); // cel putin un texbox este gol
        }

        private void button2_Click(object sender, EventArgs e) // create acc
        {
            Form formCreateAcc = new FormCreateAcc();
            formCreateAcc.ShowDialog(); // afiseaza form pentru create account
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
