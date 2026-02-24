using System;
using System.Collections.Generic;
using System.Text;

namespace EnvioMensaje
{
	public interface INotificador
	{
		bool ProcesadorDeNotificacion(string mensaje);
		// al usar bool significa que este metodo retornará un resultado Logico True o False
		//con el objetivo de saber si la notificacion se envio correctamente o no.
	}
}
