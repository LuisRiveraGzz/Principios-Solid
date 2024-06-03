//Se agrega desde dependencias/referencias escibiendo word
using ObjWord = Microsoft.Office.Interop.Word;

namespace Principios_Solid._2_O.Solucion
{
	internal class ReportGenerateWord : IReportGenerator
	{
		public void CreateReport()
		{
            string extencion = ".docx";
            string Nombre = "MiPrimerArchivoWord" + extencion;
            //C:\\Users\\LuisR\\source\\repos\\Principios Solid\\Principios Solid\\bin\\Debug\\net7.0\\MiPrimerArchivoWord.docx
            string PathFile = AppDomain.CurrentDomain.BaseDirectory + Nombre;

            //Obtiene la ruta del escritorio
            //C:\\Users\\LuisR\\OneDrive\\Escritorio\\MiPrimerArchivoWord.docx.docx
            //string PathFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Nombre;

            // Instanciacion de word
            ObjWord.Application Word = new();
            //Creacion de documento word
            ObjWord.Document documento = Word.Documents.Add();

            //Crear parrafos
            ObjWord.Paragraph parrafo1 = documento.Content.Paragraphs.Add(Type.Missing);
            /**
             * Darle formato al parrafo 
             */
            parrafo1.Range.Font.Size = 12;
            parrafo1.Range.Font.Color = ObjWord.WdColor.wdColorBlack;
            parrafo1.Range.Text = "Este es mi primer parrafo";

            parrafo1.Range.InsertParagraphAfter();


            ObjWord.Paragraph parrafo2 = documento.Content.Paragraphs.Add(Type.Missing);
            /**
             * Darle formato al parrafo 
             */
            parrafo2.Range.Font.Size = 18;
            parrafo2.Range.Font.Color = ObjWord.WdColor.wdColorBlack;
            parrafo2.Range.Text = "Este es mi segundo parrafo";
            parrafo2.Range.InsertParagraphAfter();

            //Eliminarlo si existe
            if (File.Exists(PathFile))
            {
                File.Delete(PathFile);
            }
            //Guardar documento
            documento.SaveAs2(PathFile);
            //cerrar el documento
            documento.Close();
            //cerrar word
            Word.Quit();
        }
	}
}
