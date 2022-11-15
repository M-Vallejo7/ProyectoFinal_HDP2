
namespace Login._1
{
    partial class frmPRODUCTOS_CLIENTE
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
            this.dtvproductos = new System.Windows.Forms.DataGridView();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btncarrito = new System.Windows.Forms.Button();
            this.pnlcantidad = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvproductos
            // 
            this.dtvproductos.AllowUserToAddRows = false;
            this.dtvproductos.AllowUserToDeleteRows = false;
            this.dtvproductos.AllowUserToOrderColumns = true;
            this.dtvproductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtvproductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtvproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvproductos.Location = new System.Drawing.Point(16, 15);
            this.dtvproductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtvproductos.Name = "dtvproductos";
            this.dtvproductos.ReadOnly = true;
            this.dtvproductos.RowHeadersWidth = 51;
            this.dtvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvproductos.Size = new System.Drawing.Size(687, 727);
            this.dtvproductos.TabIndex = 1;
            this.dtvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvproductos_CellClick);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcantidad.Location = new System.Drawing.Point(904, 117);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(84, 29);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(881, 149);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(132, 22);
            this.txtcantidad.TabIndex = 3;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // btncarrito
            // 
            this.btncarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncarrito.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncarrito.Location = new System.Drawing.Point(867, 254);
            this.btncarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncarrito.Name = "btncarrito";
            this.btncarrito.Size = new System.Drawing.Size(168, 28);
            this.btncarrito.TabIndex = 4;
            this.btncarrito.Text = "ENVIAR A CARRITO";
            this.btncarrito.UseVisualStyleBackColor = true;
            this.btncarrito.Click += new System.EventHandler(this.btncarrito_Click);
            // 
            // pnlcantidad
            // 
            this.pnlcantidad.BackColor = System.Drawing.Color.Aqua;
            this.pnlcantidad.Location = new System.Drawing.Point(881, 171);
            this.pnlcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlcantidad.Name = "pnlcantidad";
            this.pnlcantidad.Size = new System.Drawing.Size(133, 12);
            this.pnlcantidad.TabIndex = 9;
            // 
            // frmPRODUCTOS_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.Controls.Add(this.pnlcantidad);
            this.Controls.Add(this.btncarrito);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.dtvproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPRODUCTOS_CLIENTE";
            this.Text = "PRODUCTOS_CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.dtvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvproductos;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btncarrito;
        private System.Windows.Forms.Panel pnlcantidad;
    }
}