using System;
using System.Collections.Generic;
using System.Text;

namespace EnvioMensaje
{
	internal class NotificadorWhatsApp : INotificador
	{
		public bool ProcesadorDeNotificacion(string mensaje) 
		{
			Console.WriteLine("=== Iniciando el Proceso de Envio ===");
			Console.WriteLine($"=== Enviando Mensaje de WhatsApp al Cel  +5730605...... {mensaje} ===");

			return true;
		}
	}
}
