using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._4_I.Problema
{
	internal class Program
	{
		public static void Main()
		{
			//No Marca error pero deberia
			OrdenarHamburgesaService servicio = new();
			servicio.OrdenarEnsalada(2);
		}
	}
}
