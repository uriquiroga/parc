namespace prySeguros
{
    partial class frmCarpetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetas));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnBasedeDatos = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(64, 165);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(358, 440);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // btnBasedeDatos
            // 
            this.btnBasedeDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnBasedeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasedeDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBasedeDatos.Location = new System.Drawing.Point(255, 12);
            this.btnBasedeDatos.Name = "btnBasedeDatos";
            this.btnBasedeDatos.Size = new System.Drawing.Size(342, 37);
            this.btnBasedeDatos.TabIndex = 1;
            this.btnBasedeDatos.Text = "Nivel 1";
            this.btnBasedeDatos.UseVisualStyleBackColor = false;
            this.btnBasedeDatos.Click += new System.EventHandler(this.btnBasedeDatos_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(61, 149);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "- Estado... -";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDatos
            // 
            this.btnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.Location = new System.Drawing.Point(255, 80);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(342, 40);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Nivel 2";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContenido.ForeColor = System.Drawing.Color.White;
            this.lblContenido.Location = new System.Drawing.Point(474, 165);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(360, 440);
            this.lblContenido.TabIndex = 4;
            this.lblContenido.Text = "...";
            // 
            // frmCarpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 681);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnBasedeDatos);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarpetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnBasedeDatos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Label lblContenido;
    }
}