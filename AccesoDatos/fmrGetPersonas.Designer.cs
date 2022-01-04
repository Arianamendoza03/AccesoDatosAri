
namespace AccesoDatos
{
    partial class fmrGetPersonas
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
            this.btncargar = new System.Windows.Forms.Button();
            this.dgpersonas = new System.Windows.Forms.DataGridView();
            this.linkSeleccionar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de personas";
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(244, 36);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(107, 35);
            this.btncargar.TabIndex = 1;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // dgpersonas
            // 
            this.dgpersonas.AllowUserToAddRows = false;
            this.dgpersonas.AllowUserToDeleteRows = false;
            this.dgpersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgpersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkSeleccionar,
            this.linkEliminar});
            this.dgpersonas.Location = new System.Drawing.Point(54, 110);
            this.dgpersonas.Name = "dgpersonas";
            this.dgpersonas.ReadOnly = true;
            this.dgpersonas.RowHeadersWidth = 51;
            this.dgpersonas.RowTemplate.Height = 24;
            this.dgpersonas.Size = new System.Drawing.Size(686, 316);
            this.dgpersonas.TabIndex = 2;
            this.dgpersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpersonas_CellContentClick);
            // 
            // linkSeleccionar
            // 
            this.linkSeleccionar.HeaderText = "Accion";
            this.linkSeleccionar.MinimumWidth = 6;
            this.linkSeleccionar.Name = "linkSeleccionar";
            this.linkSeleccionar.ReadOnly = true;
            this.linkSeleccionar.Text = "Seleccionar";
            this.linkSeleccionar.UseColumnTextForLinkValue = true;
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Accion";
            this.linkEliminar.MinimumWidth = 6;
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.ReadOnly = true;
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            // 
            // fmrGetPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgpersonas);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.label1);
            this.Name = "fmrGetPersonas";
            this.Text = "fmrGetPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.DataGridView dgpersonas;
        private System.Windows.Forms.DataGridViewLinkColumn linkSeleccionar;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
    }
}