using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerasaPorumba
{
    public partial class AdaugaProdus : Form
    {
        public AdaugaProdus()
        {
            InitializeComponent();
            this.FormClosing += (s, args) => { MenuSingleton.Meniu.saveAsJson(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* MenuSingleton.Meniu.AdaugaProdus(
                 new Produs
                 {
                     id = int.Parse(idTextBox.Text),
                     cantitate = int.Parse(ncantitateUpDown.Text),
                     pret = double.Parse(pretTextBox.Text),
                     denumireProd = denumireTextBox.Text
                 }
             );*/
            int id = int.Parse(idTextBox.Text);
            Boolean boll = false;
            foreach (Produs p in MenuSingleton.Meniu.produse)
            {
                if(p.id== id)
                {
                    boll = true;
                }
            }
            if (boll)
            {
                MessageBox.Show("Produsul nu a fost adaugat cu succes!");
            }
            else
            {
                 MenuSingleton.Meniu.AdaugaProdus(
                 new Produs
                 {
                     id = int.Parse(idTextBox.Text),
                     cantitate = int.Parse(ncantitateUpDown.Text),
                     pret = double.Parse(pretTextBox.Text),
                     denumireProd = denumireTextBox.Text
                 }
             );
                MessageBox.Show("Produsul a fost adaugat cu succes!");
            }
            idTextBox.Text = string.Empty;
            ncantitateUpDown.Value = 0;
            pretTextBox.Text = string.Empty;
            denumireTextBox.Text = string.Empty;
        }
    }
}
