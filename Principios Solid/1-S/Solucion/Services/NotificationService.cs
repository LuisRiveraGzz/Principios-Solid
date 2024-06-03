using Principios_Solid._1_S.Solucion.Interfaces;

namespace Principios_Solid._1_S.Solucion
{
	internal class NotificationService : INotification
	{
		public bool EmailVoice(Invoice invoice)
		{
			return true;
		}
	}
}
