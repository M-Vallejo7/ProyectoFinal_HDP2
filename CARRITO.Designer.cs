
namespace Login._1
{
    partial class frmCARRITO
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
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncomprar = new System.Windows.Forms.Button();
            this.pnlcanti = new System.Windows.Forms.Panel();
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
            this.dtvproductos.Size = new System.Drawing.Size(687, 609);
            this.dtvproductos.TabIndex = 2;
            this.dtvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvproductos_CellClick);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcantidad.Location = new System.Drawing.Point(984, 69);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(99, 22);
            this.lblcantidad.TabIndex = 3;
            this.lblcantidad.Text = "CANTIDAD";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(969, 92);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(132, 27);
            this.txtcantidad.TabIndex = 4;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodificar.Location = new System.Drawing.Point(944, 151);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(199, 28);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "MODIFICAR CANTIDAD";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneliminar.Location = new System.Drawing.Point(944, 258);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(199, 28);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncomprar
            // 
            this.btncomprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncomprar.Location = new System.Drawing.Point(944, 375);
            this.btncomprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(199, 28);
            this.btncomprar.TabIndex = 7;
            this.btncomprar.Text = "REALIZAR COMPRA";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // pnlcanti
            // 
            this.pnlcanti.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlcanti.Location = new System.Drawing.Point(969, 117);
            this.pnlcanti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlcanti.Name = "pnlcanti";
            this.pnlcanti.Size = new System.Drawing.Size(133, 12);
            this.pnlcanti.TabIndex = 9;
            // 
            // frmCARRITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1419, 709);
            this.Controls.Add(this.pnlcanti);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.dtvproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCARRITO";
            this.Text = "CARRITO";
            ((System.ComponentModel.ISupportInitialize)(this.dtvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvproductos;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.Panel pnlcanti;
    }
}