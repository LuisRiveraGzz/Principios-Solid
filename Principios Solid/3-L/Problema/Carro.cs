using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._3_L.Problema
{
	//Esta clase no cumple con el principio
	internal class Carro:Vehiculo
	{
		public override void Acelerar() 
		{
			//codigo para acelerar
		}     
		//Un carro no puede despegar o aterrizar lo que dara un error
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
