using System;
using System.Collections.Generic;
using System.Text;

namespace EnvioMensaje
{
	public class ProcesadorDeNotificacion 
	{
		private readonly INotificador _notificador;

		public ProcesadorDeNotificacion(INotificador metodoSeleccionado)
		{
			_notificador = metodoSeleccionado;
		}
		public bool EnvioDeNotificacion(string mensaje)
		{
			return _notificador.ProcesadorDeNotificacion(mensaje);
			
		}
	}
}
