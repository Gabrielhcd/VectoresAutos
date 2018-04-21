using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresAutosRegistros
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Registro catalogoAutos = new Registro();
		Auto carData;


		private void btnAdd_Click(object sender, EventArgs e)
		{
			string placa = Convert.ToString(txtPlaca.Text);
			string marca = Convert.ToString(txtMarca.Text);
			string modelo = Convert.ToString(txtModelo.Text);
			string tel = Convert.ToString(txtTelefono.Text);
			string year = Convert.ToString(txtYear.Text);
			carData = new Auto(placa, marca, modelo, tel, year);
			catalogoAutos.Agregar(carData);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string placa = Convert.ToString(txtPlaca.Text);
			string marca = Convert.ToString(txtMarca.Text);
			string modelo = Convert.ToString(txtModelo.Text);
			string tel = Convert.ToString(txtTelefono.Text);
			string year = Convert.ToString(txtYear.Text);
			carData = new Auto(placa, marca, modelo, tel, year);
			catalogoAutos.Agregar(carData);
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			int posicion = Convert.ToUInt16(txtPosicion.Text);
			catalogoAutos.Eliminar(posicion);
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			string placa = Convert.ToString(txtPlaca.Text);
			string marca = Convert.ToString(txtMarca.Text);
			string modelo = Convert.ToString(txtModelo.Text);
			string tel = Convert.ToString(txtTelefono.Text);
			string year = Convert.ToString(txtYear.Text);
			int posicion = Convert.ToUInt16(txtPosicion.Text);
			carData = new Auto(placa, marca, modelo, tel, year);
			//catalogoAutos.Insertar(posicion, carData);
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			catalogoAutos.Listar();
		}
	}
}
