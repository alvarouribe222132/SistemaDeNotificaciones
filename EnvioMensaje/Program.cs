// See https://aka.ms/new-console-template for more information
using EnvioMensaje;
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
		Console.WriteLine("3. WhatsApp");

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

		ProcesadorDeNotificacion procesador = new ProcesadorDeNotificacion(metodoSeleccionado);

		bool resultado = procesador.EnvioDeNotificacion("Proceso de Notificación: ");

		if (resultado)
			Console.WriteLine("Envio Realizado Correctamente");
		else
			Console.WriteLine("Error en el Envio");
	}
}

