namespace tpIntegrador
{
    partial class frmAltaArticulo
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
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblDescipcionNuevo = new System.Windows.Forms.Label();
            this.lblImagenNuevo = new System.Windows.Forms.Label();
            this.lblPrecioNuevo = new System.Windows.Forms.Label();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtDescipcionNuevo = new System.Windows.Forms.TextBox();
            this.txtImagenNuevo = new System.Windows.Forms.TextBox();
            this.txtPrecioNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmboxMarca = new System.Windows.Forms.ComboBox();
            this.cmboxCategoria = new System.Windows.Forms.ComboBox();
            this.pcBoxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(31, 46);
            this.lblCodigoNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Código:";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(31, 89);
            this.lblNombreNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(50, 13);
            this.lblNombreNuevo.TabIndex = 7;
            this.lblNombreNuevo.Text = "Nombre: ";
            // 
            // lblDescipcionNuevo
            // 
            this.lblDescipcionNuevo.AutoSize = true;
            this.lblDescipcionNuevo.Location = new System.Drawing.Point(31, 134);
            this.lblDescipcionNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescipcionNuevo.Name = "lblDescipcionNuevo";
            this.lblDescipcionNuevo.Size = new System.Drawing.Size(66, 13);
            this.lblDescipcionNuevo.TabIndex = 8;
            this.lblDescipcionNuevo.Text = "Descripción:";
            // 
            // lblImagenNuevo
            // 
            this.lblImagenNuevo.AutoSize = true;
            this.lblImagenNuevo.Location = new System.Drawing.Point(31, 175);
            this.lblImagenNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenNuevo.Name = "lblImagenNuevo";
            this.lblImagenNuevo.Size = new System.Drawing.Size(61, 13);
            this.lblImagenNuevo.TabIndex = 9;
            this.lblImagenNuevo.Text = "Imagen Url:";
            // 
            // lblPrecioNuevo
            // 
            this.lblPrecioNuevo.AutoSize = true;
            this.lblPrecioNuevo.Location = new System.Drawing.Point(31, 210);
            this.lblPrecioNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioNuevo.Name = "lblPrecioNuevo";
            this.lblPrecioNuevo.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioNuevo.TabIndex = 10;
            this.lblPrecioNuevo.Text = "Precio:";
            this.lblPrecioNuevo.Click += new System.EventHandler(this.lblPrecioNuevo_Click);
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(104, 46);
            this.txtCodigoNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigoNuevo.TabIndex = 0;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(104, 89);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(76, 20);
            this.txtNombreNuevo.TabIndex = 1;
            // 
            // txtDescipcionNuevo
            // 
            this.txtDescipcionNuevo.Location = new System.Drawing.Point(104, 134);
            this.txtDescipcionNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescipcionNuevo.Name = "txtDescipcionNuevo";
            this.txtDescipcionNuevo.Size = new System.Drawing.Size(76, 20);
            this.txtDescipcionNuevo.TabIndex = 2;
            // 
            // txtImagenNuevo
            // 
            this.txtImagenNuevo.Location = new System.Drawing.Point(104, 175);
            this.txtImagenNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagenNuevo.Name = "txtImagenNuevo";
            this.txtImagenNuevo.Size = new System.Drawing.Size(76, 20);
            this.txtImagenNuevo.TabIndex = 3;
            this.txtImagenNuevo.Leave += new System.EventHandler(this.txtImagenNuevo_Leave);
            // 
            // txtPrecioNuevo
            // 
            this.txtPrecioNuevo.Location = new System.Drawing.Point(104, 210);
            this.txtPrecioNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioNuevo.Name = "txtPrecioNuevo";
            this.txtPrecioNuevo.Size = new System.Drawing.Size(76, 20);
            this.txtPrecioNuevo.TabIndex = 4;
            this.txtPrecioNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioNuevo_KeyPress);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Location = new System.Drawing.Point(33, 309);
            this.btnAgregarNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(56, 19);
            this.btnAgregarNuevo.TabIndex = 7;
            this.btnAgregarNuevo.Text = "Agregar ";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 309);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 19);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(33, 244);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 271);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmboxMarca
            // 
            this.cmboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxMarca.FormattingEnabled = true;
            this.cmboxMarca.Location = new System.Drawing.Point(104, 244);
            this.cmboxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxMarca.Name = "cmboxMarca";
            this.cmboxMarca.Size = new System.Drawing.Size(92, 21);
            this.cmboxMarca.TabIndex = 5;
            // 
            // cmboxCategoria
            // 
            this.cmboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxCategoria.FormattingEnabled = true;
            this.cmboxCategoria.Location = new System.Drawing.Point(104, 271);
            this.cmboxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxCategoria.Name = "cmboxCategoria";
            this.cmboxCategoria.Size = new System.Drawing.Size(92, 21);
            this.cmboxCategoria.TabIndex = 6;
            // 
            // pcBoxArticulo
            // 
            this.pcBoxArticulo.Location = new System.Drawing.Point(257, 70);
            this.pcBoxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pcBoxArticulo.Name = "pcBoxArticulo";
            this.pcBoxArticulo.Size = new System.Drawing.Size(200, 214);
            this.pcBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxArticulo.TabIndex = 16;
            this.pcBoxArticulo.TabStop = false;
            this.pcBoxArticulo.Click += new System.EventHandler(this.pcBoxArticulo_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(199, 175);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(44, 23);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 366);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pcBoxArticulo);
            this.Controls.Add(this.cmboxCategoria);
            this.Controls.Add(this.cmboxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.txtPrecioNuevo);
            this.Controls.Add(this.txtImagenNuevo);
            this.Controls.Add(this.txtDescipcionNuevo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.txtCodigoNuevo);
            this.Controls.Add(this.lblPrecioNuevo);
            this.Controls.Add(this.lblImagenNuevo);
            this.Controls.Add(this.lblDescipcionNuevo);
            this.Controls.Add(this.lblNombreNuevo);
            this.Controls.Add(this.lblCodigoNuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblDescipcionNuevo;
        private System.Windows.Forms.Label lblImagenNuevo;
        private System.Windows.Forms.Label lblPrecioNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtDescipcionNuevo;
        private System.Windows.Forms.TextBox txtImagenNuevo;
        private System.Windows.Forms.TextBox txtPrecioNuevo;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmboxMarca;
        private System.Windows.Forms.ComboBox cmboxCategoria;
        private System.Windows.Forms.PictureBox pcBoxArticulo;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}