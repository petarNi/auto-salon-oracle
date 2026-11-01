using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void broj_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cmdSaloni_Click(object sender, EventArgs e)
        {
            Forme.Saloni saloni = new Forme.Saloni();
            saloni.Show();
        }

        private void cmdIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
