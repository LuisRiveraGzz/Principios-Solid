using Principios_Solid._2_O.Solucion.Models;

namespace Principios_Solid._2_O.Problema
{
    internal class ReportingService
	{
		public static void GenerarReporte(ReportType tipo)
		{
			//Este no es codigo limpio
			//Si la clase se extiende tendremos que cambiar la propia clase
			//Al agregar nuevos tipos de reportes tendremos que agregar más condicionales
			if(tipo== ReportType.PDF)
			{
				CreatePDFReport();
			}
			else if (tipo == ReportType.Excel)
			{
				CreateExcelReport();
			}
			else if(tipo == ReportType.Xml)
			{
				CreateReportXML();
			}

		}
		
		//Generamos nuevos metodos por cada Tipo de reporte
		private static void CreatePDFReport()
		{
		}
		private static void CreateReportXML()
		{

		}

		private static void CreateExcelReport()
		{
		}
	}
}
