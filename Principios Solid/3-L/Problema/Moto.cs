using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._3_L.Problema
{
	internal class Moto:Vehiculo
	{
		public override void Acelerar()
		{
			//codigo para acelerar
		}
		//Una Bicicleta no puede despegar o aterrizar
		public override void Aterrizar()
		{
			throw new NotImplementedException();
		}
		public override void Despegar()
		{
			throw new NotImplementedException();
		}
		public override void Estacionar()
		{
			//codigo para acelerar
		}
		public override void Frenar()
		{
			//codigo para acelerar
		}
	}
}
