namespace Principios_Solid._2_O.Solucion;
internal class Program
{
	public static void Main() 
	{
		//Este ejemplo si es codigo limpio
		//Aqui puedes cambiar el tipo de archivo sin problemas
		ReportingService servicio = new(new ReportGenerateExcel());
		ReportingService servicio1 = new(new ReportGeneratePDF());
		ReportingService servicio2 = new(new ReportGenerateWord());

		servicio.GenerateReport();
		servicio1.GenerateReport();
		servicio2.GenerateReport();
	}
}