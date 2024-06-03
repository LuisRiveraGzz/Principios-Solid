
namespace Principios_Solid._1_S.Solucion
{
	internal class OrderService
	{
		#region Interfaces
        // Estos son campos donde guardaremos las interfaces para su uso
		private readonly OrderRepository _OrderRepository;
		private readonly InvoiceService _InvoiceService;
		private readonly NotificationService _NotificationService;
		private readonly LoggerService _LoggerService;
		#endregion

        //Inyectamos las interfaces
		public OrderService(
            OrderRepository orderRepository,
            InvoiceService invoiceService,
            NotificationService notificationService,
            LoggerService loggerService
            )
        {
            //Almacenamos las interfaces
            _OrderRepository = orderRepository;
            _InvoiceService = invoiceService;
            _NotificationService = notificationService;
            _LoggerService = loggerService;
        }

        //Este metodo ya no necesita cambios debido a que utilizamos
        //interfaces externas para hacer cada accion, es decir si necesitamos
        //implementar algo más tendremos que cambiar las interfaces y no el método
        //El funcionamiento es externo y no interno
        public void SaveOrder(Order order)
        {
            try 
            {
                _OrderRepository.InsertOrder(order);
                var invoice = _InvoiceService.CreateInvoice(order);
                _NotificationService.EmailVoice(invoice);
                _LoggerService.Info("The order has been complete");
            }
            catch(Exception e)
            {
                _LoggerService.Error(e.Message, e);
            }
        }
    }
}
