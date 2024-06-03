using Principios_Solid._1_S.Solucion;

namespace Principios_Solid.Problema
{
	internal class OrderService
	{
		public void SaveOrder(Order order)
		{
			try
			{
				this.InsertOrder(order);
				var invoice = this.CreateInvoice(order);
				this.EmailEnvoice(order);
				File.WriteAllText(@"c:\InfoLog.txt", "The order has been complete");
			}
			catch(Exception e)
			{
				File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
			}
		}

		
		private bool InsertOrder(Order order) 
		{
			//Codigo para insertar una orden en la base de datos
			return true;
		}
		private void EmailEnvoice(Order order)
		{
			throw new NotImplementedException();
		}
		private Invoice CreateInvoice(Order order)
		{
			return new Invoice();
		}
		
	}
}