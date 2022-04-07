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
    public partial class Trailer : Form
    {
        public Trailer()
        {
            InitializeComponent();
        }

        string cs = @"Data source = KOMPAC\SQLEXPRESS; Initial catalog = Bioskop3; Integrated security = true";
        SqlConnection veza;
        SqlDataAdapter adapter;
        DataTable podaci;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter($"select dbo.link('{Program.Film}')", veza);
            podaci = new DataTable();
            adapter.Fill(podaci);

            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";


            var url = podaci.Rows[0][0].ToString();

            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
