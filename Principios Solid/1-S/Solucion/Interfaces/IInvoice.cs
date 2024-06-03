using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._1_S.Solucion.Interfaces
{
	interface IInvoice
	{
		Invoice CreateInvoice(Order order);
	}
}
