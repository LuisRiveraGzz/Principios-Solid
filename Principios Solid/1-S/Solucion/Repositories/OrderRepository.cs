using Principios_Solid._1_S.Solucion.Interfaces;

namespace Principios_Solid._1_S.Solucion
{
	class OrderRepository:IOrder
	{
		public bool InsertOrder(Order order)
		{
			return true;
		}
	}
}
