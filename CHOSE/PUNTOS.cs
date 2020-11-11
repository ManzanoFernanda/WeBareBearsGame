using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using BackEnd;



namespace CHOSE
{
    public partial class PUNTOS : Form
    {
        ListaDePuntos Puntaje = new ListaDePuntos();
        public PUNTOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(CHOSE.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();

           
            Form formulario = new PERSONAJE();
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Espera()
        {
            Thread.Sleep(1500);
        }

        private void PUNTOS_Load(object sender, EventArgs e)
        {
            dgvPuntos.DataSource = Puntaje.lista;
        }

        private void LISTANOMBRE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
