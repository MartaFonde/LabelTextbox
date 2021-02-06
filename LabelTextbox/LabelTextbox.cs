using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTextbox
{
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }
    [
        DefaultProperty("TextLbl"),
        DefaultEvent("Load")
    ]
    public partial class LabelTextbox : UserControl
    {
        
        
        private ePosicion posicion = ePosicion.IZQUIERDA;

        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    //recolocar();
                    Refresh();
                    CambiaPosicion?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    //recolocar();
                    Refresh();
                    CambiaSeparacion?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Design")]
        [Description("Ancho del Textbox, en píxeles")]
        public int TxtWidth
        {
            set
            {
                if (value > 0)
                {
                    txt.Width = value;
                    //recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return txt.Width;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                //recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
                
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //this.Width = txt.Width + lbl.Width + Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //this.Width = txt.Width + lbl.Width + Separacion;
                    txt.Width = this.Width - lbl.Width - Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }


        //CREA EVENTO: evento que se lance si se detecta un cambio de posición para
        //lbl respecto de txt de forma que se puedan cambiar la distribución de otros componentes en el formulario si
        //fuera necesario.

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler CambiaPosicion;

        [Category("La separación cambió")]
        [Description("Se lanza cuando la propiedad Separación cambia")]
        public event System.EventHandler CambiaSeparacion;

        [Category("El texto de Textbox cambió")]
        [Description("Se lanza cuando el texto de la Textbox cambia")]
        public event System.EventHandler TxtChanged;


        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            //recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.TxtChanged?.Invoke(sender, e);  //IMPORTANTE COMPROBRAR QUE O EVENT != NULL --> EVENT = NULL SE NINGUNHA FUNCION O RECOLLE NO FORM (NullException)
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
            e.Graphics.DrawLine(new Pen(Color.Violet),
                    lbl.Left, this.Height - 1,
                    lbl.Left + lbl.Width, this.Height - 1);
        }


        public LabelTextbox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            //recolocar();
        }

        
    }
}
