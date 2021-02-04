
namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.txtSeparacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeparacion = new System.Windows.Forms.Button();
            this.lblLetra = new System.Windows.Forms.Label();
            this.lblTxtChanged = new System.Windows.Forms.Label();
            this.labelTextbox1 = new LabelTextbox.LabelTextbox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(137, 95);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(139, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Cambia posición";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.CambiaPosicion);
            // 
            // txtSeparacion
            // 
            this.txtSeparacion.Location = new System.Drawing.Point(599, 37);
            this.txtSeparacion.Name = "txtSeparacion";
            this.txtSeparacion.Size = new System.Drawing.Size(64, 20);
            this.txtSeparacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Separación";
            // 
            // btnSeparacion
            // 
            this.btnSeparacion.Location = new System.Drawing.Point(681, 34);
            this.btnSeparacion.Name = "btnSeparacion";
            this.btnSeparacion.Size = new System.Drawing.Size(44, 23);
            this.btnSeparacion.TabIndex = 4;
            this.btnSeparacion.Text = "OK";
            this.btnSeparacion.UseVisualStyleBackColor = true;
            this.btnSeparacion.Click += new System.EventHandler(this.CambiaSeparacion);
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(68, 163);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(49, 13);
            this.lblLetra.TabIndex = 5;
            this.lblLetra.Text = "lblKeyUp";
            // 
            // lblTxtChanged
            // 
            this.lblTxtChanged.AutoSize = true;
            this.lblTxtChanged.Location = new System.Drawing.Point(71, 208);
            this.lblTxtChanged.Name = "lblTxtChanged";
            this.lblTxtChanged.Size = new System.Drawing.Size(75, 13);
            this.lblTxtChanged.TabIndex = 6;
            this.lblTxtChanged.Text = "lblTxtChanged";
            // 
            // labelTextbox1
            // 
            this.labelTextbox1.Location = new System.Drawing.Point(52, 37);
            this.labelTextbox1.Name = "labelTextbox1";
            this.labelTextbox1.Posicion = LabelTextbox.ePosicion.DERECHA;
            this.labelTextbox1.PswChr = '\0';
            this.labelTextbox1.Separacion = 20;
            this.labelTextbox1.Size = new System.Drawing.Size(337, 20);
            this.labelTextbox1.TabIndex = 0;
            this.labelTextbox1.TextLbl = "lkjkhjkjhjkhjk";
            this.labelTextbox1.TextTxt = "";
            this.labelTextbox1.TxtWidth = 250;
            this.labelTextbox1.CambiaPosicion += new System.EventHandler(this.labelTextbox1_CambiaPosicion);
            this.labelTextbox1.TxtChanged += new System.EventHandler(this.labelTextbox1_TxtChanged);
            this.labelTextbox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextbox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTxtChanged);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.btnSeparacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeparacion);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.labelTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelTextbox.LabelTextbox labelTextbox1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtSeparacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeparacion;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Label lblTxtChanged;
    }
}

