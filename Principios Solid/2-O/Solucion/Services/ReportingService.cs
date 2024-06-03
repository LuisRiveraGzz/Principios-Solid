using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._2_O.Solucion
{
	internal class ReportingService
	{
        private readonly IReportGenerator _reportGenerator;
        public ReportingService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        //Esta clase se puede extender sin tocar la propia clase
        public void GenerateReport()
        {
            _reportGenerator.CreateReport();
        }
    }
}
