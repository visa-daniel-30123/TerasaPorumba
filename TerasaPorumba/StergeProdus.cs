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
    public partial class StergeProdus : Form
    {
        public StergeProdus()
        {
            InitializeComponent();
            this.FormClosing += (s, args) => { MenuSingleton.Meniu.saveAsJson(); };
        }

        private void deleteProdButton_Click(object sender, EventArgs e)
        {
            Produs p1 = new Produs();
            int n = 0;
            n = int.Parse(idIdentTextBox.Text);
            foreach (Produs p in MenuSingleton.Meniu.produse)
            {
                if (p.id == n)
                {
                    p1 = p;
                }
            }
            MenuSingleton.Meniu.produse.Remove(p1);
            MessageBox.Show("Produsul a fost sters cu succes ");
           
        }
    }
}
