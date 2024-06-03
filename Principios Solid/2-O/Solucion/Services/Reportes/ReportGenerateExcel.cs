//Para uso exclusivo de excel
using Principios_Solid._2_O.Solucion.Models;
using SpreadsheetLight;
using System.Data;

namespace Principios_Solid._2_O.Solucion
{
	//Creamos una clase por cada tipo de archivo y le implementamos la interface
	//la cual nos obligara a colocar los mismos metodos, pero el resultado puede ser diferente
	internal class ReportGenerateExcel : IReportGenerator
	{
		public void CreateReport()
		{
			string extencion = ".xlsx";
			string Nombre = "MiExcel" + extencion;

            //C:\\Users\\LuisR\\source\\repos\\Principios Solid\\Principios Solid\\bin\\Debug\\net7.0\\MiExcel.xlsx
            string PathFile = AppDomain.CurrentDomain.BaseDirectory + Nombre;

			//Creacion de documento excel
			SLDocument Documento = new();

			//Creacion de tabla
			DataTable tabla = new();

			//Encabezados
			tabla.Columns.Add("Nombre",typeof(string));
			tabla.Columns.Add("Edad",typeof(int));
			tabla.Columns.Add("Sexo",typeof(string));
			List<Alumno> ListaAlumnos = new()
			{
				new(){ Nombre = "Pepe" , Edad = 19, Sexo = "Hombre"},
				new(){ Nombre = "Ana" , Edad = 20, Sexo = "Mujer"},
				new(){ Nombre = "Perla" , Edad = 30, Sexo = "Mujer"},
				new(){ Nombre = "Luis" , Edad = 30, Sexo = "Hombre"}
			};	

            //Renglones(registros)
            foreach (var alumno in ListaAlumnos)
			{
                tabla.Rows.Add(alumno.Nombre, alumno.Edad, alumno.Sexo);
            }

			//Importa la tabla desde el renglon 1,columna 1 e incluye los encabezados
			Documento.ImportDataTable(2,2,tabla,true);

			//Borrara el archivo si existe
			if (File.Exists(PathFile))
			{
				File.Delete(PathFile);
			}

			//Guardara el archivo
			Documento.SaveAs(PathFile);
		}
	}
}
