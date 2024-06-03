using Principios_Solid._4_I.Problema;
using Principios_Solid._4_I.Solucion.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._4_I.Solucion
{
	internal class Program
	{
		void Main()
		{
			OrdenarHamburguesasService servicio = new();
			servicio.OrdenarHamburguesas(2);
		}
	}
}
