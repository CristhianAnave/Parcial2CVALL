using CadParcial2CVALL;
using ClnParcial2CVALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2CVALL
{
	public partial class FrmPrincipal : Form
	{
		private bool esNuevo = false;
		public FrmPrincipal()
		{
			InitializeComponent();
			mtcFechaEstreno.Visible = false;
		}

		public void listar() 
		{
			var lista = serieCln.listarPa(txtParametro.Text);
			dgvSerie.DataSource = lista;
			dgvSerie.Columns["id"].Visible = false;
			dgvSerie.Columns["estado"].Visible = false;

			dgvSerie.Columns["titulo"].HeaderText = "TÍTULO";
			dgvSerie.Columns["sinopsis"].HeaderText = "SINOPSIS";
			dgvSerie.Columns["director"].HeaderText = "DIRECTOR";
			dgvSerie.Columns["episodios"].HeaderText = "EPISODIO";
			dgvSerie.Columns["fechaEstreno"].HeaderText = "FECHA DE ESTRENO";
			dgvSerie.Columns["usuarioRegistro"].HeaderText = "USUARIO REGISTRO";
			dgvSerie.Columns["fechaRegistro"].HeaderText = "FECHA DE REGISTRO";

			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;

			if (lista.Count > 0) dgvSerie.CurrentCell = dgvSerie.Rows[0].Cells["titulo"];
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			listar();
			DesactivarCampos();
		    txtFechaEstreno.Text = string.Empty;
		}

		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			HabilitarCampos();
			txtTitulo.Focus();
			limpiar();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void limpiarBusqueda() 
		{
		 txtParametro.Text = string.Empty;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			limpiarBusqueda();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var serie = new Serie();
				serie.titulo = txtTitulo.Text.Trim();
				serie.sinopsis = txtSinopsis.Text.Trim();
				serie.director = txtDirector.Text.Trim();
				serie.episodios = (int)nudEpisodios.Value;

				DateTime fechaEstreno;
				if (DateTime.TryParseExact(txtFechaEstreno.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaEstreno))
				{
					serie.fechaEstreno = fechaEstreno; // Asignar la fecha convertida
				}
				else
				{
					MessageBox.Show("El formato de la fecha debe ser dd/MM/yyyy.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return; // Sale del método si el formato es incorrecto
				}

				serie.usuarioRegistro = "Cristhian";
				if (esNuevo)
				{
					serie.fechaRegistro = DateTime.Now;
					serie.estado = 1;
					serieCln.insertar(serie);
				}
				else
				{
					int index = dgvSerie.CurrentCell.RowIndex;
					serie.id = Convert.ToInt32(dgvSerie.Rows[index].Cells["id"].Value);
					serieCln.actualizar(serie);
				}
				listar();
				MessageBox.Show("Serie guardada correctamente", ":::Serie - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			limpiar();
			DesactivarCampos();
			mtcFechaEstreno.Visible = false;
		}

		private bool validar()
		{
			bool esValido = true;
			erpTitulo.SetError(txtTitulo, "");
			erpSinopsis.SetError(txtSinopsis, "");
			erpDirector.SetError(txtDirector, "");
			erpEpisodio.SetError(nudEpisodios, "");
			erpFechaEstreno.SetError(txtFechaEstreno, "");

			if (string.IsNullOrEmpty(txtTitulo.Text))
			{
				esValido = false;
				erpTitulo.SetError(txtTitulo, "El campo Titulo es obligatorio");
			}
			if (string.IsNullOrEmpty(txtSinopsis.Text))
			{
				esValido = false;
				erpSinopsis.SetError(txtSinopsis, "El campo Sinopsis es obligatorio");
			}
			if (string.IsNullOrEmpty(txtDirector.Text))
			{
				esValido = false;
				erpDirector.SetError(txtDirector, "El campo Director es obligatorio");
			}
			if (nudEpisodios.Value < 0)
			{
				esValido = false;
				erpEpisodio.SetError(nudEpisodios, "El campo Episodios no debe ser negativo");
			}
			if (string.IsNullOrEmpty(txtFechaEstreno.Text))
			{
				esValido = false;
				erpFechaEstreno.SetError(txtFechaEstreno, "El campo Fecha de Estreno es obligatorio");
			}
			return esValido;
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			int index = dgvSerie.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvSerie.Rows[index].Cells["id"].Value);
			var serie = serieCln.obtenerUno(id);
			txtTitulo.Text = serie.titulo;
			txtSinopsis.Text = serie.sinopsis;
			txtDirector.Text = serie.director;
			nudEpisodios.Value = serie.episodios;
			if (serie.fechaEstreno.HasValue)
			{
				txtFechaEstreno.Text = serie.fechaEstreno.Value.ToString("dd/MM/yyyy");
			}
			else 
			{
				txtFechaEstreno.Text = "Fecha no disponible";
			}
			txtTitulo.Focus();
			HabilitarCampos();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvSerie.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvSerie.Rows[index].Cells["id"].Value);
			string titulo = dgvSerie.Rows[index].Cells["titulo"].Value.ToString();
			DialogResult dialog =
				MessageBox.Show($"¿Está seguro que desea dar de baja a la serie con el titulo {titulo}?",
				"::: Serie - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				serieCln.eliminar(id, "Cristhian");
				listar();
				MessageBox.Show("serie dada de baja correctamente", "::: Serie - Mensaje :::",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void limpiar() 
		{
		  txtTitulo.Text = string.Empty;
		  txtSinopsis.Text = string.Empty;
		  txtDirector.Text = string.Empty;
		  nudEpisodios.Value = 0;
          txtFechaEstreno.Text = string.Empty;
		}

		private void DesactivarCampos()
		{
			txtTitulo.Enabled = false;
			txtSinopsis.Enabled = false;
			txtDirector.Enabled = false;
			txtFechaEstreno.Enabled = false; 
		}
		private void HabilitarCampos()
		{
			txtTitulo.Enabled = true;
			txtSinopsis.Enabled = true;
			txtDirector.Enabled = true;
			txtFechaEstreno.Enabled=true;
		}

		private void mtcPrueba_DateSelected(object sender, DateRangeEventArgs e)
		{
			txtFechaEstreno.Text = mtcFechaEstreno.SelectionStart.ToString("dd/MM/yyyy");
			mtcFechaEstreno.Visible = false;
		}

		private void txtFechaEstreno_Enter(object sender, EventArgs e)
		{
			// Mostrar el MonthCalendar cuando el TextBox recibe el foco
			mtcFechaEstreno.Location = new Point(txtFechaEstreno.Right + 5, txtFechaEstreno.Top); // Posicionar el calendario
			mtcFechaEstreno.Visible = true; // Mostrar el calendario
		}

	}
}
