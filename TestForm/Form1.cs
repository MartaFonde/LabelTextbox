using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LabelTextbox;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CambiaPosicion(object sender, EventArgs e)
        {
            labelTextbox1.Posicion = labelTextbox1.Posicion == ePosicion.DERECHA? ePosicion.IZQUIERDA : ePosicion.DERECHA;                  
        }

        private void labelTextbox1_CambiaPosicion(object sender, EventArgs e)
        {
            this.Text = labelTextbox1.Posicion.ToString();
        }

        public void CambiaSeparacion(object sender, EventArgs e)
        {
            int separacion;
            if(txtSeparacion.Text.Length > 0 && int.TryParse(txtSeparacion.Text, out separacion))
            {
                labelTextbox1.Separacion = separacion;
            }
        }
        private void labelTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            lblLetra.Text = "Letra: " + e.KeyCode;
        }

        private void labelTextbox1_TxtChanged(object sender, EventArgs e)
        {
            lblTxtChanged.Text = "El texto cambió";
        }
    }
}
