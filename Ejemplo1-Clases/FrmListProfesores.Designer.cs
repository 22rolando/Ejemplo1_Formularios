
namespace Ejemplo1_Clases
{
    partial class FrmListProfesores
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
            this.btnCancelar_ListProfesores = new System.Windows.Forms.Button();
            this.dataGridViewProf = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProf)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar_ListProfesores);
            this.groupBox1.Controls.Add(this.dataGridViewProf);
            this.groupBox1.Location = new System.Drawing.Point(102, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Profesores";
            // 
            // btnCancelar_ListProfesores
            // 
            this.btnCancelar_ListProfesores.Location = new System.Drawing.Point(463, 254);
            this.btnCancelar_ListProfesores.Name = "btnCancelar_ListProfesores";
            this.btnCancelar_ListProfesores.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_ListProfesores.TabIndex = 1;
            this.btnCancelar_ListProfesores.Text = "Cancelar";
            this.btnCancelar_ListProfesores.UseVisualStyleBackColor = true;
            this.btnCancelar_ListProfesores.Click += new System.EventHandler(this.btnCancelar_ListProfesores_Click);
            // 
            // dataGridViewProf
            // 
            this.dataGridViewProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProf.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewProf.Name = "dataGridViewProf";
            this.dataGridViewProf.Size = new System.Drawing.Size(584, 210);
            this.dataGridViewProf.TabIndex = 0;
            this.dataGridViewProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProf_CellContentClick);
            // 
            // FrmListProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListProfesores";
            this.Text = "FrmProfesores";
            this.Load += new System.EventHandler(this.FrmListProfesores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar_ListProfesores;
        private System.Windows.Forms.DataGridView dataGridViewProf;
    }
}