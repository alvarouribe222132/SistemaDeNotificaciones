using System;
using System.Collections.Generic;
using System.Text;

namespace EnvioMensaje
{
	internal class NotificadorEmail : INotificador
	{
		public bool ProcesadorDeNotificacion(string mensaje) 
		{
			Console.WriteLine("=== Iniciando el Proceso de Envio ===");
			Console.WriteLine($"=== Enviando Correo a usuario@itm.edu.co con el mensaje: {mensaje} ===");

			return true;
		}
	
	}
}
