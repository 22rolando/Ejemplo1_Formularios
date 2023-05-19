
namespace Ejemplo1_Clases
{
    partial class FrmListarEstudiante
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
            this.btnCancelar_ListEstudiante = new System.Windows.Forms.Button();
            this.dataGridViewEst = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar_ListEstudiante);
            this.groupBox1.Controls.Add(this.dataGridViewEst);
            this.groupBox1.Location = new System.Drawing.Point(102, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Estudiantes";
            // 
            // btnCancelar_ListEstudiante
            // 
            this.btnCancelar_ListEstudiante.Location = new System.Drawing.Point(463, 254);
            this.btnCancelar_ListEstudiante.Name = "btnCancelar_ListEstudiante";
            this.btnCancelar_ListEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_ListEstudiante.TabIndex = 1;
            this.btnCancelar_ListEstudiante.Text = "Cancelar";
            this.btnCancelar_ListEstudiante.UseVisualStyleBackColor = true;
            this.btnCancelar_ListEstudiante.Click += new System.EventHandler(this.btnCancelar_ListEstudiante_Click);
            // 
            // dataGridViewEst
            // 
            this.dataGridViewEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEst.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEst.Name = "dataGridViewEst";
            this.dataGridViewEst.Size = new System.Drawing.Size(584, 210);
            this.dataGridViewEst.TabIndex = 0;
            this.dataGridViewEst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEst_CellContentClick);
            // 
            // FrmListarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListarEstudiante";
            this.Text = "FrmListarEstudiante";
            this.Load += new System.EventHandler(this.FrmListarEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar_ListEstudiante;
        private System.Windows.Forms.DataGridView dataGridViewEst;
    }
}