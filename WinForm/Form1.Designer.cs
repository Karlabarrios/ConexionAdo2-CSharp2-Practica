
namespace WinForm
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pxbDiscos = new System.Windows.Forms.PictureBox();
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.lblApp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // pxbDiscos
            // 
            this.pxbDiscos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pxbDiscos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxbDiscos.Location = new System.Drawing.Point(12, 27);
            this.pxbDiscos.Name = "pxbDiscos";
            this.pxbDiscos.Size = new System.Drawing.Size(319, 313);
            this.pxbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbDiscos.TabIndex = 0;
            this.pxbDiscos.TabStop = false;
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(343, 72);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(562, 182);
            this.dgvDiscos.TabIndex = 1;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Neutral Face", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApp.Location = new System.Drawing.Point(337, 25);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(343, 34);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "APLICACIÓN DE DISCOS";
            this.lblApp.MouseLeave += new System.EventHandler(this.lblApp_MouseLeave);
            this.lblApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblApp_MouseMove);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(917, 361);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.dgvDiscos);
            this.Controls.Add(this.pxbDiscos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.Text = "App Discos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbDiscos;
        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.Label lblApp;
    }
}

