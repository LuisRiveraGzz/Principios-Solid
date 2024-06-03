using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._3_L.Problema
{
	abstract class Vehiculo
	{
		public virtual void Acelerar() { }
		public virtual void Aterrizar() { }
		public virtual void Despegar() { }
		public virtual void Estacionar() { }
		public virtual void Frenar() { }
	}
}
