/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 26/09/2013
 * Time: 12:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace practica3
{
	class menu
	{
	
		public static void Main(string[] args)
		{
			Proceso proceso = new Proceso();
			proceso.iniciar();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}