using Principios_Solid._5_D.Problema;
using Principios_Solid._5_D.Solucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._5_D.Solucion.Servicios
{
	internal class OrderService
	{
		private readonly IEventNotification _eventNotification;
		public OrderService(IEventNotification eventNotification) 
		{ 
			_eventNotification = eventNotification;
		}
		public void GenerateOrder(Order order)
		{
			//Todo: Codigo para la crear la orden
			//enviar notificacion a datadog
			_eventNotification.LogEvent("La orden fue creada satisfactoriamente");
		}
	}
	class Order
	{

	}
}
