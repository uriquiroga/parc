namespace prySeguros
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.panel_Lateral = new System.Windows.Forms.Panel();
            this.btnBasedatos = new System.Windows.Forms.Button();
            this.btnPlanilla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.White;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(10, 294);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(265, 38);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = " Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.White;
            this.btnListado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Location = new System.Drawing.Point(10, 408);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(265, 37);
            this.btnListado.TabIndex = 1;
            this.btnListado.Text = "Ver listado de proveedores";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // panel_Lateral
            // 
            this.panel_Lateral.BackColor = System.Drawing.Color.SlateBlue;
            this.panel_Lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Lateral.Controls.Add(this.btnBasedatos);
            this.panel_Lateral.Controls.Add(this.btnPlanilla);
            this.panel_Lateral.Controls.Add(this.btnProveedores);
            this.panel_Lateral.Controls.Add(this.btnListado);
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(301, 681);
            this.panel_Lateral.TabIndex = 2;
            // 
            // btnBasedatos
            // 
            this.btnBasedatos.BackColor = System.Drawing.Color.White;
            this.btnBasedatos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasedatos.Location = new System.Drawing.Point(10, 242);
            this.btnBasedatos.Name = "btnBasedatos";
            this.btnBasedatos.Size = new System.Drawing.Size(265, 37);
            this.btnBasedatos.TabIndex = 3;
            this.btnBasedatos.Text = "Archivos";
            this.btnBasedatos.UseVisualStyleBackColor = false;
            this.btnBasedatos.Click += new System.EventHandler(this.btnBasedatos_Click);
            // 
            // btnPlanilla
            // 
            this.btnPlanilla.BackColor = System.Drawing.Color.White;
            this.btnPlanilla.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanilla.Location = new System.Drawing.Point(10, 354);
            this.btnPlanilla.Name = "btnPlanilla";
            this.btnPlanilla.Size = new System.Drawing.Size(265, 37);
            this.btnPlanilla.TabIndex = 2;
            this.btnPlanilla.Text = "Planilla";
            this.btnPlanilla.UseVisualStyleBackColor = false;
            this.btnPlanilla.Click += new System.EventHandler(this.btnPlanilla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prySeguros.Properties.Resources.u__2_;
            this.pictureBox1.Location = new System.Drawing.Point(297, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Lateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel_Lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Panel panel_Lateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlanilla;
        private System.Windows.Forms.Button btnBasedatos;
    }
}