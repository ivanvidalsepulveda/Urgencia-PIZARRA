using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace pizarra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

        }


        SqlConnection con = new SqlConnection(@"Data Source = 192.168.100.13; Initial Catalog = CLINIWIN; Persist Security Info=True;User ID = TURGENCIA; Password=184114518");
        String consulta_cliniwin = "exec consulta_cantidad_pacientes_urg";

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1_Tick(null, null);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            cargar_Click(null, null);
        }



        private void cargar_Click(object sender, EventArgs e)
        {

            con.Open();
            using (SqlDataAdapter sdaa = new SqlDataAdapter(consulta_cliniwin, con))
            {
               
                using (DataTable dtt = new DataTable())
                {
                    sdaa.Fill(dtt);
                    DataRow rows = dtt.Rows[0];


                    c2a.Text = Convert.ToString(rows["adultos_c2"]);
                    c2n.Text = Convert.ToString(rows["niños_c2"]);
                    c3a.Text = Convert.ToString(rows["adultos_c3"]);
                    c3n.Text = Convert.ToString(rows["niños_c3"]);
                    c4a.Text = Convert.ToString(rows["adultos_c4"]);
                    c4n.Text = Convert.ToString(rows["niños_c4"]);
                    c5a.Text = Convert.ToString(rows["adultos_c5"]);
                    c5n.Text = Convert.ToString(rows["niños_c5"]);
                    sca.Text = Convert.ToString(rows["adultos_espera_sc"]);
                    scn.Text = Convert.ToString(rows["niños_espera_sc"]);
                    enAtencion.Text = Convert.ToString(rows["pacientes_box"]);


                }
  

            }
            con.Close();

            /// n° pacientes en espera 
            enEspera.Text = (Convert.ToInt16(c2a.Text) + Convert.ToInt16(c2n.Text) + Convert.ToInt16(c3a.Text) + Convert.ToInt16(c3n.Text) + Convert.ToInt16(c4a.Text) + Convert.ToInt16(c4n.Text)
                    + Convert.ToInt16(c5a.Text) + Convert.ToInt16(c5n.Text) + Convert.ToInt16(sca.Text) + Convert.ToInt16(scn.Text)).ToString();

            //total pacientes
            enTotal.Text = (Convert.ToInt16(enEspera.Text) + Convert.ToInt16(enAtencion.Text)).ToString();

            //total pacientes adultos
            totala.Text = (Convert.ToInt16(c2a.Text) + Convert.ToInt16(c3a.Text) + Convert.ToInt16(c4a.Text) + Convert.ToInt16(c5a.Text) + Convert.ToInt16(sca.Text)).ToString();
            //total pacientes niños
            totaln.Text = (Convert.ToInt16(c2n.Text) + Convert.ToInt16(c3n.Text) + Convert.ToInt16(c4n.Text) + Convert.ToInt16(c5n.Text) + Convert.ToInt16(scn.Text)).ToString();

          

            DateTime t = DateTime.Now;

            fecha.Text = t.ToString("D", CultureInfo.CreateSpecificCulture("es-CL"));
            hora.Text = t.ToString("t", CultureInfo.CreateSpecificCulture("es-CL"));


        }
    }
}
