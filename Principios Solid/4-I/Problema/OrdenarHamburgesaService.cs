using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._4_I.Problema
{
	internal class OrdenarHamburgesaService : IOrdenarComidaService
	{
		public void OrdenarBistec(int cantidad)
		{
			throw new NotImplementedException("No puedo ordenar bistecs desde este servicio");
		}
		public void OrdenarEnsalada(int cantidad)
		{
			throw new NotImplementedException("No puedo ordenar ensaladas desde este servicio");
		}
		//Solo necesito este metodo para este servicio
		public void OrdenarHamburguesa(int cantidad)
		{
			//Codigo para ordenar una Hamburguesa
		}
	}
}
