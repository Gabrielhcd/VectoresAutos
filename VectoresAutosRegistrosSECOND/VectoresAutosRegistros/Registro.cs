using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresAutosRegistros
{
	class Registro
	{
		private Auto[] _vecRegistros = new Auto[15];
		private int _autos = 0;
		/// <summary>
		/// Valida que el obejto no exista ya mediante la placa, asi como compara las placas
		///del objeto que se desea agregar con las placas de los obejtos ya existentes
		/// </summary>
		/// <param name="carrito"></param>
		public void Agregar(Auto carrito)
		{
			for(int i = 0; i <= _autos; i++)
			{
				if (carrito.placa != _vecRegistros[i].placa)
				{
					_vecRegistros[_autos] = carrito;
					_autos++;

					
				}
				else
				{
					MessageBox.Show("Auto ya existente");
				}
			}
		}
		/// <summary>
		/// Busca auto por placa
		/// </summary>
		/// <param name="carro"></param>
		/// <returns></returns>
		public string Buscar(Auto carro)
		{
			string Search = "";
			for(int i=0; i <= _autos; i++)
			{
				if (carro.placa.CompareTo(_vecRegistros[i].placa) == 0)
					MessageBox.Show("Auto ya existente1");
				else if (carro.placa.CompareTo(_vecRegistros[i].placa) < 0)
				{
					_vecRegistros[i + 1] = _vecRegistros[i];
					_vecRegistros[i] = carro;
				}
				else if (carro.placa.CompareTo(_vecRegistros[i].placa) > 0)
				{
					_vecRegistros[i + 2] = _vecRegistros[i + 1];
					_vecRegistros[i + 1] = carro;
				}
				else
					MessageBox.Show("Error");
			}
			return Search;
		}
		/// <summary>
		/// Elimina el objeto en la posicion deseada
		/// </summary>
		/// <param name="posicion"></param>
		public void Eliminar(int posicion)
		{
			for(int i = posicion; i < _autos; i++)
			{
				_vecRegistros[i] = _vecRegistros[i + 1];
			}
		}
		/*public void Insertar(int posicion, Auto objeto)
		{
			Auto temp;
			for(int i = posicion; i <= _vecRegistros.Length; i++)
			{
				temp = _vecRegistros[i];
				_vecRegistros[i] = objeto;
				_vecRegistros[i + 1] = temp;
			}
		}*/
		/// <summary>
		/// Muestra un listado de todos los autos ya agregados al registro
		/// </summary>
		/// <returns></returns>
		public string Listar()
		{
			string show = "";
			for(int i = 0; i <= _autos; i++)
			{
				show += "Auto " + i + "--"+ _vecRegistros[i].ToString() + Environment.NewLine;
			}
			return show;
		}
	}
}
