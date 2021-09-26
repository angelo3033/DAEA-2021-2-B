
namespace Lab04
{
    partial class Curso
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
            this.btnListarC = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarC
            // 
            this.btnListarC.Location = new System.Drawing.Point(24, 13);
            this.btnListarC.Name = "btnListarC";
            this.btnListarC.Size = new System.Drawing.Size(75, 23);
            this.btnListarC.TabIndex = 0;
            this.btnListarC.Text = "Listar";
            this.btnListarC.UseVisualStyleBackColor = true;
            this.btnListarC.Click += new System.EventHandler(this.btnListarC_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(120, 15);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(236, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(375, 13);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarC.TabIndex = 2;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(24, 56);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(426, 382);
            this.dgvListado.TabIndex = 3;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnListarC);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarC;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}