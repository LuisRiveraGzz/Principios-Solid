using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._3_L.Problema
{
	internal class Avion : Vehiculo
	{
		public override void Acelerar()
		{
			throw new NotImplementedException();
		}
		public override void Aterrizar()
		{
			//codigo para Aterrizar
		}
		public override void Despegar()
		{
			//codigo para acelerar
		}
		public override void Estacionar()
		{
			throw new NotImplementedException();
		}
		public override void Frenar()
		{
			throw new NotImplementedException();
		}
	}
}
