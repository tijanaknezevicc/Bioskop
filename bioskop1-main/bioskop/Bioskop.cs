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

namespace bioskop
{
    public partial class Bioskop : Form
    {
        public Bioskop()
        {
            InitializeComponent();
        }

        string cs = @"Data source = KOMPAC\SQLEXPRESS; Initial catalog = Bioskop3; Integrated security = true";
        SqlConnection veza;
        SqlDataAdapter adapter;
        DataTable podaci;

        private void Bioskop_Load(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter("select * from Pogled", veza);
            podaci = new DataTable();
            adapter.Fill(podaci);
            dgTabela.DataSource = podaci;
            dgTabela.ReadOnly = true;
            dgTabela.AllowUserToAddRows = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string film = tbFilm.Text.ToLower();
            string vreme = tbVreme.Text.ToLower();
            string naredba = $"select * from pogled where lower(film) like '%{film}%' and lower(vreme) like '%{vreme}%';";
            adapter = new SqlDataAdapter(naredba, veza);
            podaci.Clear();
            podaci = new DataTable();
            adapter.Fill(podaci);
            dgTabela.DataSource = podaci;
        }

        private void btnOpis_Click(object sender, EventArgs e)
        {
            Program.Film = dgTabela.CurrentCell.Value.ToString();
            Opis formaOpis = new Opis();
            formaOpis.Show();
        }
    }
}
