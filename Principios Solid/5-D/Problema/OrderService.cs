using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._5_D.Problema
{
	//Esta es una clase concreta, no una abstraccion
	public class DataDogService
	{
		public void LogEvent(string Mensaje)
		{
			//Codigo para el evento DataDog
		}
	}
	public class OrderService
	{
		public readonly DataDogService _dataDogService;
        public OrderService(DataDogService dataDogService)
        {
			_dataDogService = dataDogService;
        }

		public void GenerateOrder(Order order)
		{
			//Todo: Codigo para la crear la orden
			//enviar notificacion a datadog
			_dataDogService.LogEvent("La orden fue creada satisfactoriamente");
		}
    }

	public class Order
	{

	}
}
