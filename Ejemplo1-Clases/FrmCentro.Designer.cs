
namespace Ejemplo1_Clases
{
    partial class FrmCentro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre_Centro = new System.Windows.Forms.TextBox();
            this.txtEmailCentro = new System.Windows.Forms.TextBox();
            this.txtTelefonoCentro = new System.Windows.Forms.TextBox();
            this.txtDireccionCentro = new System.Windows.Forms.TextBox();
            this.btnGuardar_centro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar_centro);
            this.groupBox1.Controls.Add(this.txtDireccionCentro);
            this.groupBox1.Controls.Add(this.txtTelefonoCentro);
            this.groupBox1.Controls.Add(this.txtEmailCentro);
            this.groupBox1.Controls.Add(this.txtNombre_Centro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(77, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Centro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtNombre_Centro
            // 
            this.txtNombre_Centro.Location = new System.Drawing.Point(94, 39);
            this.txtNombre_Centro.Name = "txtNombre_Centro";
            this.txtNombre_Centro.Size = new System.Drawing.Size(276, 20);
            this.txtNombre_Centro.TabIndex = 4;
            this.txtNombre_Centro.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtEmailCentro
            // 
            this.txtEmailCentro.Location = new System.Drawing.Point(94, 201);
            this.txtEmailCentro.Name = "txtEmailCentro";
            this.txtEmailCentro.Size = new System.Drawing.Size(276, 20);
            this.txtEmailCentro.TabIndex = 5;
            // 
            // txtTelefonoCentro
            // 
            this.txtTelefonoCentro.Location = new System.Drawing.Point(94, 137);
            this.txtTelefonoCentro.Name = "txtTelefonoCentro";
            this.txtTelefonoCentro.Size = new System.Drawing.Size(276, 20);
            this.txtTelefonoCentro.TabIndex = 6;
            // 
            // txtDireccionCentro
            // 
            this.txtDireccionCentro.Location = new System.Drawing.Point(94, 84);
            this.txtDireccionCentro.Name = "txtDireccionCentro";
            this.txtDireccionCentro.Size = new System.Drawing.Size(276, 20);
            this.txtDireccionCentro.TabIndex = 7;
            // 
            // btnGuardar_centro
            // 
            this.btnGuardar_centro.Location = new System.Drawing.Point(108, 264);
            this.btnGuardar_centro.Name = "btnGuardar_centro";
            this.btnGuardar_centro.Size = new System.Drawing.Size(119, 24);
            this.btnGuardar_centro.TabIndex = 8;
            this.btnGuardar_centro.Text = "Guardar";
            this.btnGuardar_centro.UseVisualStyleBackColor = true;
            this.btnGuardar_centro.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 24);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCentro";
            this.Text = "FrmCentro";
            this.Load += new System.EventHandler(this.FrmCentro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar_centro;
        private System.Windows.Forms.TextBox txtDireccionCentro;
        private System.Windows.Forms.TextBox txtTelefonoCentro;
        private System.Windows.Forms.TextBox txtEmailCentro;
        private System.Windows.Forms.TextBox txtNombre_Centro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}