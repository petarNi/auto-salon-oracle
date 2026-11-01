using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon.Forme
{
    public partial class KupciPoSalonu : Form
    {
        private int _salonId;

        public KupciPoSalonu(int salonId)
        {
            InitializeComponent();
            _salonId = salonId;

        }

        private void KupciPoSalonu_Load(object sender, EventArgs e)
        {
            List<KupacPregled> kupci = DTOManager.VratiKupceZaSalon(_salonId);
            PopuniListView(kupci);
        }

        private void PopuniListView(List<KupacPregled> kupci)
        {
            listViewKupci.Items.Clear();

            foreach (KupacPregled kupac in kupci)
            {
                ListViewItem item;

                if (kupac.TipKupca == "fizicko")
                {
                    item = new ListViewItem("Fizičko lice");
                    item.SubItems.Add(kupac.Ime);
                    item.SubItems.Add(kupac.Prezime);
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                }
                else
                {
                    item = new ListViewItem("Pravno lice");
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                    item.SubItems.Add(kupac.NazivFirme);
                    item.SubItems.Add(kupac.SedisteFirme);
                }

                item.SubItems.Add(kupac.Marka);
                item.SubItems.Add(kupac.Model);

                listViewKupci.Items.Add(item);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
