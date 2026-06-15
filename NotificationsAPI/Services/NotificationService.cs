namespace NotificationsAPI.Services;

public class NotificationService
{
	public void SendWelcomeEmail (string email)
	{
		Console.WriteLine(
			$"[EMAIL] Bem-vindo enviado para {email}");
	}

	public void SendPurchaseConfirmation (string userId)
	{
		Console.WriteLine(
			$"[EMAIL] Compra confirmada para usuário {userId}");
	}
}