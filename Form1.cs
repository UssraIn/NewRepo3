using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2emeApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source =C:\\Users\\hp\\Desktop\\la bdd\\Memoire.db";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text; // Vous devriez hasher les mots de passe dans une application réelle

            if (AuthenticateUser(username, password))
            {
                //Pour ajouter notre fentre


                Form2 form = new Form2();
                form.Show();
                Hide();

                //  MessageBox.Show("Connexion réussie !");
                // Ouvrir le formulaire principal ou effectuer d'autres actions après la connexion
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Login WHERE username = @username AND password = @password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows; // Si des lignes sont retournées, les informations d'identification sont correctes
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Application.Exit();
        }
    }
}
