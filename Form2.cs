using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2emeApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Vérifier que txtProfileId contient un entier valide
                int profileId;
                bool isNumeric = int.TryParse(txtProfileId.Text, out profileId);
                if (!isNumeric)
                {
                    MessageBox.Show("Veuillez entrer un identifiant de profil valide (nombre entier).");
                    return;
                }

                // Continuer avec le reste de la méthode si la conversion est réussie...
                // ...
            }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }
