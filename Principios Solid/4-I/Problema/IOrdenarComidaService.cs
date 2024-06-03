using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._4_I.Problema
{
	interface IOrdenarComidaService
	{
		void OrdenarBistec(int cantidad);
		void OrdenarHamburguesa(int cantidad);
		void OrdenarEnsalada(int cantidad);
	}
}
