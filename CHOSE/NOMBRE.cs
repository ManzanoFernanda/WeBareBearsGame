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
    public partial class NOMBRE : Form
    {
        private int Puntaje = 0;
        ListaDePuntos lista = new ListaDePuntos();

       
        public NOMBRE(int Punto)
            {
            Puntaje = Punto;
           
            InitializeComponent();
             }

        private void NOMBRE_Load(object sender, EventArgs e)
             {

             }
              
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer Sclick = new SoundPlayer(CHOSE.Properties.Resources.BT);
            Sclick.Play();

            Task oTask = new Task(Espera);
            oTask.Start();
            lista.GuardarPuntos(txtNombre.Text, Puntaje);
            Form formulario = new PUNTOS();
            formulario.Show();
            this.Hide();

        }
        public void Espera()
        {
            Thread.Sleep(1500);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


