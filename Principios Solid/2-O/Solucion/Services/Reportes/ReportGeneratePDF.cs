using iTextSharp.text;
using iTextSharp.text.pdf;
using Principios_Solid._2_O.Solucion.Models;

namespace Principios_Solid._2_O.Solucion
{
    internal class ReportGeneratePDF : IReportGenerator
    {
        public void CreateReport()
        {
            string extencion = ".pdf";
            string Nombre = "MiPdf" + extencion;
            //C:\\Users\\LuisR\\source\\repos\\Principios Solid\\Principios Solid\\bin\\Debug\\net7.0\\MiPdf.pdf
            string PathFile = AppDomain.CurrentDomain.BaseDirectory + Nombre;

            //creamos un filestream
            FileStream fs = new(PathFile, FileMode.Create);
            //Creamos el documento y le asignamos el tamaño y el margen
            Document doc = new(PageSize.LETTER, 5, 5, 7, 7);
            // Creamos el escritor de pdf y le asignamos el documento y el filestream
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            //abrimos el documento
            doc.Open();

            //Titulo y autor
            doc.AddAuthor("Luis Rivera");
            doc.AddTitle("Mi Primer PDF creado en c#");

            //Definir la fuentes
            Font Fuente = new(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("PDF Creado desde C#"));
            doc.Add(Chunk.NEWLINE);

            /*
                Creacion de una tabla de alumnos
             */

            //Encabezado de columnas
            PdfPTable Tabla = new(3)
            {
                WidthPercentage = 100
            };

            //Configurando el titulo de nuestras columnas
            PdfPCell clNombre = new(new Phrase("Nombre", Fuente))
            {
                BorderWidth = 0,
                BorderWidthBottom = 0.75f
            };
            PdfPCell clGrado = new(new Phrase("Grado", Fuente))
            {
                BorderWidth = 0,
                BorderWidthBottom = 0.75f
            };
            PdfPCell clEdad = new(new Phrase("Edad", Fuente))
            {
                BorderWidth = 0,
                BorderWidthBottom = 0.75f
            };

            //Agregar Celdas a la tabla
            Tabla.AddCell(clNombre);
            Tabla.AddCell(clGrado);
            Tabla.AddCell(clEdad);

            var listaAlumnos = new List<Alumno>()
            {
                new(){ Nombre="Luis",Edad = 23,Grado = 11},
                new(){ Nombre="Juan",Edad = 25,Grado = 7},
                new(){ Nombre="Alejandro",Edad = 22,Grado = 9},
                new(){ Nombre="Alexis",Edad = 21,Grado = 5}
            };

            //Agregar un renglon por cada alumno y su informacion
            foreach (var estudiante in listaAlumnos)
            {
                clNombre = new(new Phrase(estudiante.Nombre, Fuente)) { BorderWidth = 0 };
                clGrado = new(new Phrase(estudiante.Grado.ToString(), Fuente)) { BorderWidth = 0 };
                clEdad = new(new Phrase(estudiante.Edad.ToString(), Fuente)) { BorderWidth = 0 };

                //Agregar celdas a la tabla
                Tabla.AddCell(clNombre);
                Tabla.AddCell(clEdad);
                Tabla.AddCell(clGrado);
            }
            //Agrega la tabla
            doc.Add(Tabla);

            //Sobreescribe el archivo si existe
            if (File.Exists(PathFile))
            {
                try
                {
                    File.OpenWrite(PathFile);
                }
                catch { }
            }

            //Cierra el documento
            doc.Close();

            //Cierra el PDF Writer
            pw.Close();
        }
    }
}