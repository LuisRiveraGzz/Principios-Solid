using Principios_Solid._3_L.Solucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._3_L.Solucion.Models
{
	class Carro : IAcelerar, IEstacionar, IFrenar
	{
		public void Acelerar()
		{
			//Codigo para acelerar
		}

		public void Estacionar()
		{
			//Codigo para Estacionar
		}

		public void Frenar()
		{
			//Codigo para Frenar
		}
	}
}
