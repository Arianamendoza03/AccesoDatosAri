
namespace AccesoDatos
{
    partial class frmConxPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMostrarCedula = new System.Windows.Forms.TextBox();
            this.txtMostrarNombresyApellidos = new System.Windows.Forms.TextBox();
            this.txtMostrarpeso = new System.Windows.Forms.TextBox();
            this.datotiempo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // txtMostrarCedula
            // 
            this.txtMostrarCedula.Location = new System.Drawing.Point(32, 110);
            this.txtMostrarCedula.Name = "txtMostrarCedula";
            this.txtMostrarCedula.Size = new System.Drawing.Size(136, 20);
            this.txtMostrarCedula.TabIndex = 4;
            // 
            // txtMostrarNombresyApellidos
            // 
            this.txtMostrarNombresyApellidos.Location = new System.Drawing.Point(267, 110);
            this.txtMostrarNombresyApellidos.Name = "txtMostrarNombresyApellidos";
            this.txtMostrarNombresyApellidos.Size = new System.Drawing.Size(145, 20);
            this.txtMostrarNombresyApellidos.TabIndex = 5;
            // 
            // txtMostrarpeso
            // 
            this.txtMostrarpeso.Location = new System.Drawing.Point(32, 277);
            this.txtMostrarpeso.Name = "txtMostrarpeso";
            this.txtMostrarpeso.Size = new System.Drawing.Size(133, 20);
            this.txtMostrarpeso.TabIndex = 7;
            // 
            // datotiempo
            // 
            this.datotiempo.Location = new System.Drawing.Point(526, 115);
            this.datotiempo.Name = "datotiempo";
            this.datotiempo.Size = new System.Drawing.Size(210, 20);
            this.datotiempo.TabIndex = 8;
            // 
            // frmConxPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datotiempo);
            this.Controls.Add(this.txtMostrarpeso);
            this.Controls.Add(this.txtMostrarNombresyApellidos);
            this.Controls.Add(this.txtMostrarCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConxPersona";
            this.Text = "Consulta por Persona";
            this.Load += new System.EventHandler(this.frmConxPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMostrarCedula;
        private System.Windows.Forms.TextBox txtMostrarNombresyApellidos;
        private System.Windows.Forms.TextBox txtMostrarpeso;
        private System.Windows.Forms.DateTimePicker datotiempo;
    }
}