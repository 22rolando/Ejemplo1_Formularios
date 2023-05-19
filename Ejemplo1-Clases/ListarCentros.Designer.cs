
namespace Ejemplo1_Clases
{
    partial class ListarCentros
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewCen = new System.Windows.Forms.DataGridView();
            this.btnCancelar_ListCentro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar_ListCentro);
            this.groupBox1.Controls.Add(this.dataGridViewCen);
            this.groupBox1.Location = new System.Drawing.Point(101, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de centros";
            // 
            // dataGridViewCen
            // 
            this.dataGridViewCen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCen.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCen.Name = "dataGridViewCen";
            this.dataGridViewCen.Size = new System.Drawing.Size(584, 210);
            this.dataGridViewCen.TabIndex = 0;
            this.dataGridViewCen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCen_CellContentClick);
            // 
            // btnCancelar_ListCentro
            // 
            this.btnCancelar_ListCentro.Location = new System.Drawing.Point(463, 254);
            this.btnCancelar_ListCentro.Name = "btnCancelar_ListCentro";
            this.btnCancelar_ListCentro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_ListCentro.TabIndex = 1;
            this.btnCancelar_ListCentro.Text = "Cancelar";
            this.btnCancelar_ListCentro.UseVisualStyleBackColor = true;
            this.btnCancelar_ListCentro.Click += new System.EventHandler(this.btnCancelar_ListCentro_Click);
            // 
            // ListarCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListarCentros";
            this.Text = "ListarCentros";
            this.Load += new System.EventHandler(this.ListarCentros_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewCen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelar_ListCentro;
    }
}