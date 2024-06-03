using Principios_Solid._3_L.Solucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._3_L.Solucion
{
	//Se pueden implementar tantas interfaces como necesites
	internal class Moto : IAcelerar, IEstacionar, IFrenar
	{
		public void Acelerar()
		{
			//Codigo para Acelerar
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
