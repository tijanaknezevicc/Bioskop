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
    public partial class Opis : Form
    {
        public Opis()
        {
            InitializeComponent();
        }

        string cs = @"Data source = KOMPAC\SQLEXPRESS; Initial catalog = Bioskop3; Integrated security = true";
        SqlConnection veza;
        SqlDataAdapter adapterPunNaziv, adapterOcena, adapterTrajanje, adapterGlumci, adapterSinopsis;

        private void buttonTrailer_Click(object sender, EventArgs e)
        {
            Trailer formaTrailer = new Trailer();
            formaTrailer.Show();
        }

        DataTable podaci;

        private void Opis_Load(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            podaci = new DataTable();

            adapterPunNaziv = new SqlDataAdapter($"select dbo.punNaziv('{Program.Film}')", veza);
            adapterPunNaziv.Fill(podaci);

            labelPunNaziv.Text = podaci.Rows[0][0].ToString();

            adapterOcena = new SqlDataAdapter($"select dbo.filmOcena('{Program.Film}')", veza);
            adapterOcena.Fill(podaci);

            labelOcena.Text = podaci.Rows[1][0].ToString();

            adapterGlumci = new SqlDataAdapter($"select dbo.glumci('{Program.Film}')", veza);
            adapterGlumci.Fill(podaci);

            labelGlumci.Text = podaci.Rows[2][0].ToString();

            adapterTrajanje = new SqlDataAdapter($"select dbo.trajanje('{Program.Film}')", veza);
            adapterTrajanje.Fill(podaci);

            labelTrajanje.Text = podaci.Rows[3][0].ToString();

            adapterSinopsis = new SqlDataAdapter($"select dbo.filmOpis('{Program.Film}')", veza);
            adapterSinopsis.Fill(podaci);

            labelOpis.Text = podaci.Rows[4][0].ToString();
        }
    }
}
