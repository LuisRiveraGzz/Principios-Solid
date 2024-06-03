using Principios_Solid._1_S.Solucion.Interfaces;

namespace Principios_Solid._1_S.Solucion
{
	internal class InvoiceService : IInvoice
	{
		public Invoice CreateInvoice(Order order)
		{
			return new Invoice();
		}
	}
}
