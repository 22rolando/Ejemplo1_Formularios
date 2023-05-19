
namespace Ejemplo1_Clases
{
    partial class frmListarTrabajadores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar_ListTrabajador = new System.Windows.Forms.Button();
            this.dataGridViewTra = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar_ListTrabajador);
            this.groupBox1.Controls.Add(this.dataGridViewTra);
            this.groupBox1.Location = new System.Drawing.Point(102, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Trabajadores";
            // 
            // btnCancelar_ListTrabajador
            // 
            this.btnCancelar_ListTrabajador.Location = new System.Drawing.Point(463, 254);
            this.btnCancelar_ListTrabajador.Name = "btnCancelar_ListTrabajador";
            this.btnCancelar_ListTrabajador.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_ListTrabajador.TabIndex = 1;
            this.btnCancelar_ListTrabajador.Text = "Cancelar";
            this.btnCancelar_ListTrabajador.UseVisualStyleBackColor = true;
            this.btnCancelar_ListTrabajador.Click += new System.EventHandler(this.btnCancelar_ListTrabajador_Click);
            // 
            // dataGridViewTra
            // 
            this.dataGridViewTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTra.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTra.Name = "dataGridViewTra";
            this.dataGridViewTra.Size = new System.Drawing.Size(584, 210);
            this.dataGridViewTra.TabIndex = 0;
            // 
            // frmListarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarTrabajadores";
            this.Text = "Lista Trabajadores";
            this.Load += new System.EventHandler(this.frmTrabajadores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar_ListTrabajador;
        private System.Windows.Forms.DataGridView dataGridViewTra;
    }
}