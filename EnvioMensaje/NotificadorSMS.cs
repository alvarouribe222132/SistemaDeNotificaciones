using System;
using System.Collections.Generic;
using System.Text;

namespace EnvioMensaje
{
	internal class NotificadorSMS : INotificador
	{
		public bool ProcesadorDeNotificacion(string mensaje) 
		{
			Console.WriteLine("=== Iniciando el Proceso de Envio ===");
			Console.WriteLine($"=== Enviando Mensaje de Texto al Cel  +5730605...... {mensaje} ===");

			return true;
		}
	}
}
