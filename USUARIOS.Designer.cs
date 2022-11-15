
namespace Login._1
{
    partial class USUARIOS
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
            this.dtvUSUARIOS = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtIDN = new System.Windows.Forms.TextBox();
            this.lblidn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvUSUARIOS
            // 
            this.dtvUSUARIOS.AllowUserToAddRows = false;
            this.dtvUSUARIOS.AllowUserToDeleteRows = false;
            this.dtvUSUARIOS.AllowUserToOrderColumns = true;
            this.dtvUSUARIOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtvUSUARIOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dtvUSUARIOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUSUARIOS.Location = new System.Drawing.Point(59, 128);
            this.dtvUSUARIOS.Margin = new System.Windows.Forms.Padding(4);
            this.dtvUSUARIOS.Name = "dtvUSUARIOS";
            this.dtvUSUARIOS.ReadOnly = true;
            this.dtvUSUARIOS.RowHeadersWidth = 51;
            this.dtvUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUSUARIOS.Size = new System.Drawing.Size(773, 368);
            this.dtvUSUARIOS.TabIndex = 1;
            this.dtvUSUARIOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvUSUARIOS_CellClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btneliminar.Location = new System.Drawing.Point(1076, 429);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(135, 35);
            this.btneliminar.TabIndex = 23;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnmodificar.Location = new System.Drawing.Point(1076, 305);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(135, 35);
            this.btnmodificar.TabIndex = 22;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnagregar.Location = new System.Drawing.Point(1076, 194);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(135, 35);
            this.btnagregar.TabIndex = 21;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcorreo.Location = new System.Drawing.Point(881, 447);
            this.lblcorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(78, 22);
            this.lblcorreo.TabIndex = 20;
            this.lblcorreo.Text = "CORREO";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(854, 473);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(132, 27);
            this.txtcorreo.TabIndex = 19;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcantidad.Location = new System.Drawing.Point(862, 245);
            this.lblcantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(124, 22);
            this.lblcantidad.TabIndex = 18;
            this.lblcantidad.Text = "CONTRASEÑA";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblnombre.Location = new System.Drawing.Point(876, 161);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(83, 22);
            this.lblnombre.TabIndex = 17;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcodigo.Location = new System.Drawing.Point(882, 343);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(77, 22);
            this.lblcodigo.TabIndex = 16;
            this.lblcodigo.Text = "CODIGO";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(854, 271);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(132, 27);
            this.txtcontrasena.TabIndex = 15;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(854, 185);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 27);
            this.txtnombre.TabIndex = 14;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(854, 369);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(132, 27);
            this.txtcodigo.TabIndex = 13;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(854, 554);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 27);
            this.txtid.TabIndex = 13;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.SystemColors.Window;
            this.lblid.Location = new System.Drawing.Point(882, 519);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(28, 22);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "ID";
            // 
            // txtIDN
            // 
            this.txtIDN.Enabled = false;
            this.txtIDN.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDN.Location = new System.Drawing.Point(854, 106);
            this.txtIDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDN.Name = "txtIDN";
            this.txtIDN.Size = new System.Drawing.Size(132, 27);
            this.txtIDN.TabIndex = 14;
            // 
            // lblidn
            // 
            this.lblidn.AutoSize = true;
            this.lblidn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidn.ForeColor = System.Drawing.SystemColors.Window;
            this.lblidn.Location = new System.Drawing.Point(876, 82);
            this.lblidn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidn.Name = "lblidn";
            this.lblidn.Size = new System.Drawing.Size(41, 22);
            this.lblidn.TabIndex = 17;
            this.lblidn.Text = "IDN";
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1440, 757);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblidn);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtIDN);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.dtvUSUARIOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USUARIOS";
            this.Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtvUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvUSUARIOS;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtIDN;
        private System.Windows.Forms.Label lblidn;
    }
}