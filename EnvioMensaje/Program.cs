// See https://aka.ms/new-console-template for more information
using EnvioMensaje;
using System.Threading;
/*
 *========================================================================== 
 * Proyecto: Sistema de Notificaciónes Polimorfismo
 * Archivo: Program.cs
 * Autor: Alvaro David Uribe Moreno
 * Fecha Creación: 2024-02-24
 * Versión: 1.0.0
 * 
 * Descripción:
 * Este programa implementa un sistema de envio de notificaciones 
 * utilizando el principio de Polimorfismo de la Programación Orientada a Objetos. (POO)
 * 
 * El sistema permite enviar notificaciones a través de diferentes canales, tales como:
 * 
 * -Email
 * -SMS
 * -WhatsApp
 * 
 * Cada tipo de notificacion implementa una interfaz común o clase base común, 
 * pero implementado un comportamiento específico para cada canal de comunicación.
 * 
 *==========================================================================
 */

class Program 
{
	static void Main(string[] args)
	{
		Console.WriteLine("=== BIENVENIDO AL SISTEMA DE NOTIFICACIONES ===");
		Console.WriteLine("Proceso de Envio");
		Console.WriteLine("Seleccione el Medio de Notificación:");
		Console.WriteLine("1. Email");
		Console.WriteLine("2. SMS");
		Console.WriteLine("3. WhatsApp \n");

		string opcion = Console.ReadLine();
		INotificador metodoSeleccionado;

		switch (opcion)
		{
			case "1":
				metodoSeleccionado = new NotificadorEmail();
				break;
			case "2":
				metodoSeleccionado = new NotificadorSMS();
				break;
			case "3":
				metodoSeleccionado = new NotificadorWhatsApp();
				break;
			default:
				Console.WriteLine(" X Opción no válida. !!!Verifique!!!.");
				return;
		}

		Console.WriteLine("Seleccione el Mensaje a Enviar: ");
		Console.WriteLine("1. Recordatorio de CITA. ");
		Console.WriteLine("2. Confirmacion de Pago. ");
		Console.WriteLine("3. Alerta de Seguridad. ");
		Console.WriteLine("4. Notificacion de Domicilio ");

		string opcionMensaje = Console.ReadLine();
		string mensaje = opcionMensaje;

		switch (mensaje)
		{
			case "1":
				mensaje = "Recordatorio: Tiene una cita programada para el 5 de Marzo de 2026 a las 09:30 AM.";
				break;
			case "2":
				mensaje = "Su Pago ha sido Confirmado.  !!!Gracias Por su Compra!!!";
				break;
			case "3":
				mensaje = "Alerta: Detectamos Actividad Inusual en su cuenta. Por favor revise y tome medidas de seguridad.";
				break;
			case "4":
				mensaje = "El Envio a su Domicilio se ha realizado, Por favor estar pendiente de nuestro Proximo Contacto";
				break;
			default:
				Console.WriteLine(" X Opción no válida. !!!Verifique!!!.");
				return;

		}

		ProcesadorDeNotificacion procesador = new ProcesadorDeNotificacion(metodoSeleccionado);

		bool resultado = procesador.EnvioDeNotificacion(mensaje);

		Console.Write("\nProcesando envio: ");
		for (int i = 0;
			i < 5; i++)
		{
			Thread.Sleep(500);
			Console.Write(".");
		}
		Console.WriteLine();

		if (resultado)
			Console.WriteLine("Envio Realizado Correctamente");
		else
			Console.WriteLine("Error en el Envio");
	}
}

