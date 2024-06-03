using Principios_Solid._2_O.Solucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._2_O.Problema
{
	enum ReportType{PDF,Excel,Xml}
	internal class Program
	{
		public static void Main()
		{
			List<Order> orders = new();//Obtenemos datos de una base de datos
			ReportingService service = new();//Enviamos la implementacion
			//El Tipo de reporte se tiene que extender si se quieren agregar nuevos tipos de reportes 
			service.GenerarReporte(orders,ReportType.PDF);
		}
	}
}
