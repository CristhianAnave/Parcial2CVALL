namespace CpParcial2CVALL
{
	partial class FrmPrincipal
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
			this.components = new System.ComponentModel.Container();
			this.dgvSerie = new System.Windows.Forms.DataGridView();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtParametro = new System.Windows.Forms.TextBox();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblListaSeries = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.txtSinopsis = new System.Windows.Forms.TextBox();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSinopsis = new System.Windows.Forms.Label();
			this.lblDirector = new System.Windows.Forms.Label();
			this.lblEpisodio = new System.Windows.Forms.Label();
			this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
			this.lblFechaEstreno = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpEpisodio = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtFechaEstreno = new System.Windows.Forms.TextBox();
			this.mtcFechaEstreno = new System.Windows.Forms.MonthCalendar();
			((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSerie
			// 
			this.dgvSerie.AllowUserToAddRows = false;
			this.dgvSerie.AllowUserToDeleteRows = false;
			this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSerie.Location = new System.Drawing.Point(320, 144);
			this.dgvSerie.Name = "dgvSerie";
			this.dgvSerie.ReadOnly = true;
			this.dgvSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSerie.Size = new System.Drawing.Size(752, 370);
			this.dgvSerie.TabIndex = 0;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::CpParcial2CVALL.Properties.Resources.buscar;
			this.btnBuscar.Location = new System.Drawing.Point(879, 72);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(46, 41);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnClear
			// 
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Image = global::CpParcial2CVALL.Properties.Resources.limpiar;
			this.btnClear.Location = new System.Drawing.Point(958, 72);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(46, 41);
			this.btnClear.TabIndex = 2;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtParametro
			// 
			this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParametro.Location = new System.Drawing.Point(570, 84);
			this.txtParametro.Name = "txtParametro";
			this.txtParametro.Size = new System.Drawing.Size(284, 26);
			this.txtParametro.TabIndex = 3;
			this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.BackColor = System.Drawing.Color.Black;
			this.lblSubtitulo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(366, 84);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(166, 23);
			this.lblSubtitulo.TabIndex = 4;
			this.lblSubtitulo.Text = "Buscar por Título:";
			// 
			// lblListaSeries
			// 
			this.lblListaSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblListaSeries.BackColor = System.Drawing.Color.Black;
			this.lblListaSeries.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListaSeries.ForeColor = System.Drawing.Color.White;
			this.lblListaSeries.Location = new System.Drawing.Point(1, -1);
			this.lblListaSeries.Name = "lblListaSeries";
			this.lblListaSeries.Size = new System.Drawing.Size(1087, 56);
			this.lblListaSeries.TabIndex = 5;
			this.lblListaSeries.Text = "Lista de Series";
			this.lblListaSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitulo.Location = new System.Drawing.Point(33, 81);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(271, 26);
			this.txtTitulo.TabIndex = 6;
			// 
			// txtSinopsis
			// 
			this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSinopsis.Location = new System.Drawing.Point(33, 143);
			this.txtSinopsis.Name = "txtSinopsis";
			this.txtSinopsis.Size = new System.Drawing.Size(271, 26);
			this.txtSinopsis.TabIndex = 8;
			// 
			// txtDirector
			// 
			this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDirector.Location = new System.Drawing.Point(33, 202);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(271, 26);
			this.txtDirector.TabIndex = 9;
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.Black;
			this.lblTitulo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(29, 55);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(71, 23);
			this.lblTitulo.TabIndex = 10;
			this.lblTitulo.Text = "Título:";
			// 
			// lblSinopsis
			// 
			this.lblSinopsis.BackColor = System.Drawing.Color.Black;
			this.lblSinopsis.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSinopsis.ForeColor = System.Drawing.Color.White;
			this.lblSinopsis.Location = new System.Drawing.Point(29, 114);
			this.lblSinopsis.Name = "lblSinopsis";
			this.lblSinopsis.Size = new System.Drawing.Size(85, 27);
			this.lblSinopsis.TabIndex = 11;
			this.lblSinopsis.Text = "Sinopsis:";
			// 
			// lblDirector
			// 
			this.lblDirector.BackColor = System.Drawing.Color.Black;
			this.lblDirector.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDirector.ForeColor = System.Drawing.Color.White;
			this.lblDirector.Location = new System.Drawing.Point(29, 173);
			this.lblDirector.Name = "lblDirector";
			this.lblDirector.Size = new System.Drawing.Size(85, 27);
			this.lblDirector.TabIndex = 12;
			this.lblDirector.Text = "Director:";
			// 
			// lblEpisodio
			// 
			this.lblEpisodio.BackColor = System.Drawing.Color.Black;
			this.lblEpisodio.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEpisodio.ForeColor = System.Drawing.Color.White;
			this.lblEpisodio.Location = new System.Drawing.Point(29, 236);
			this.lblEpisodio.Name = "lblEpisodio";
			this.lblEpisodio.Size = new System.Drawing.Size(94, 27);
			this.lblEpisodio.TabIndex = 13;
			this.lblEpisodio.Text = "Episódio:";
			// 
			// nudEpisodios
			// 
			this.nudEpisodios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudEpisodios.Location = new System.Drawing.Point(129, 236);
			this.nudEpisodios.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudEpisodios.Name = "nudEpisodios";
			this.nudEpisodios.Size = new System.Drawing.Size(65, 26);
			this.nudEpisodios.TabIndex = 8;
			// 
			// lblFechaEstreno
			// 
			this.lblFechaEstreno.BackColor = System.Drawing.Color.Black;
			this.lblFechaEstreno.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaEstreno.ForeColor = System.Drawing.Color.White;
			this.lblFechaEstreno.Location = new System.Drawing.Point(29, 267);
			this.lblFechaEstreno.Name = "lblFechaEstreno";
			this.lblFechaEstreno.Size = new System.Drawing.Size(244, 27);
			this.lblFechaEstreno.TabIndex = 15;
			this.lblFechaEstreno.Text = "Ajusta a la fecha de estreno :";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = global::CpParcial2CVALL.Properties.Resources.Nuevo;
			this.btnNuevo.Location = new System.Drawing.Point(33, 344);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(108, 51);
			this.btnNuevo.TabIndex = 105;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = global::CpParcial2CVALL.Properties.Resources.editar;
			this.btnEditar.Location = new System.Drawing.Point(211, 401);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(93, 51);
			this.btnEditar.TabIndex = 104;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = global::CpParcial2CVALL.Properties.Resources.eliminar;
			this.btnEliminar.Location = new System.Drawing.Point(33, 460);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(108, 51);
			this.btnEliminar.TabIndex = 103;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Image = global::CpParcial2CVALL.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(211, 458);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(93, 51);
			this.btnCerrar.TabIndex = 102;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = global::CpParcial2CVALL.Properties.Resources.Guardar;
			this.btnGuardar.Location = new System.Drawing.Point(33, 401);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(108, 51);
			this.btnGuardar.TabIndex = 101;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// erpTitulo
			// 
			this.erpTitulo.ContainerControl = this;
			// 
			// erpSinopsis
			// 
			this.erpSinopsis.ContainerControl = this;
			// 
			// erpDirector
			// 
			this.erpDirector.ContainerControl = this;
			// 
			// erpEpisodio
			// 
			this.erpEpisodio.ContainerControl = this;
			// 
			// erpFechaEstreno
			// 
			this.erpFechaEstreno.ContainerControl = this;
			// 
			// txtFechaEstreno
			// 
			this.txtFechaEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFechaEstreno.Location = new System.Drawing.Point(164, 301);
			this.txtFechaEstreno.Name = "txtFechaEstreno";
			this.txtFechaEstreno.Size = new System.Drawing.Size(140, 26);
			this.txtFechaEstreno.TabIndex = 106;
			this.txtFechaEstreno.Enter += new System.EventHandler(this.txtFechaEstreno_Enter);
			this.txtFechaEstreno.Leave += new System.EventHandler(this.txtFechaEstreno_Leave);
			// 
			// mtcFechaEstreno
			// 
			this.mtcFechaEstreno.Location = new System.Drawing.Point(307, 301);
			this.mtcFechaEstreno.Name = "mtcFechaEstreno";
			this.mtcFechaEstreno.TabIndex = 107;
			this.mtcFechaEstreno.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtcPrueba_DateSelected);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.BackgroundImage = global::CpParcial2CVALL.Properties.Resources.serie;
			this.ClientSize = new System.Drawing.Size(1086, 526);
			this.Controls.Add(this.mtcFechaEstreno);
			this.Controls.Add(this.txtFechaEstreno);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblFechaEstreno);
			this.Controls.Add(this.nudEpisodios);
			this.Controls.Add(this.lblEpisodio);
			this.Controls.Add(this.lblDirector);
			this.Controls.Add(this.lblSinopsis);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.txtDirector);
			this.Controls.Add(this.txtSinopsis);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.lblListaSeries);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.txtParametro);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dgvSerie);
			this.Name = "FrmPrincipal";
			this.Text = "::: Serie - Parcial2CVALL :::";
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSerie;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtParametro;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblListaSeries;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.TextBox txtSinopsis;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSinopsis;
		private System.Windows.Forms.Label lblDirector;
		private System.Windows.Forms.Label lblEpisodio;
		private System.Windows.Forms.NumericUpDown nudEpisodios;
		private System.Windows.Forms.Label lblFechaEstreno;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ErrorProvider erpTitulo;
		private System.Windows.Forms.ErrorProvider erpSinopsis;
		private System.Windows.Forms.ErrorProvider erpDirector;
		private System.Windows.Forms.ErrorProvider erpEpisodio;
		private System.Windows.Forms.ErrorProvider erpFechaEstreno;
		private System.Windows.Forms.TextBox txtFechaEstreno;
		private System.Windows.Forms.MonthCalendar mtcFechaEstreno;
	}
}

