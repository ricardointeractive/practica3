/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 26/09/2013
 * Time: 07:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace practica3
{
	
	    public class Proceso
	    {
		public Hashtable tabla;
		public Proceso()
		{
			this.tabla = new Hashtable();
		}
		
		public void capturar(){
		    for(int a=0;a<4;a++){
	            Persona p =new Persona();
     		    Console.WriteLine("Codigo:");
                p.codigo=double.Parse(Console.ReadLine());
			    Console.WriteLine("Nombre: ");
	            p.nombre=Console.ReadLine();
		        Console.WriteLine("Telefono: ");
	            p.telefono=double.Parse(Console.ReadLine());
	            Console.WriteLine("Facebook: ");
	            p.facebook=Console.ReadLine();
	            this.tabla.Add(p.codigo,p);
	            System.Console.Clear(); 
	        }		
		}
		
		public void editar(){
		     for(int b=0;b<2;b++){
				 Persona edi =new Persona();
				 Console.WriteLine("Buscar codigo para editar:");
                 edi.codigo=double.Parse(Console.ReadLine());
                 if(!tabla.ContainsKey(edi.codigo)){
                 	Console.WriteLine("no existe el codigo");
                 }
                 else{
                 edi=(Persona)(this.tabla[edi.codigo]);
                 Console.WriteLine("Nombre: ");
                 Console.WriteLine(edi.nombre);
		         Console.WriteLine("Telefono: ");
		         Console.WriteLine(edi.telefono);
	             Console.WriteLine("Facbook: ");
	             Console.WriteLine(edi.facebook);
	             
                 Console.WriteLine("Editar codigo: ");
                 Console.WriteLine("");
	             Console.WriteLine("Nombre: "); 
	             edi.nombre=Console.ReadLine();
		         Console.WriteLine("Telefono: ");
	             edi.telefono=double.Parse(Console.ReadLine());
	             Console.WriteLine("Facbook: ");
	             edi.facebook=Console.ReadLine();
	             System.Console.Clear();
                 }
             }
		}
		
		public void eliminar(){
				 for(int c=0;c<2;c++){
				 Persona elim =new Persona();
				 Console.WriteLine("Eliminar Codigo:");
                 elim.codigo=double.Parse(Console.ReadLine());
                 if(!tabla.ContainsKey(elim.codigo)){
                 	Console.WriteLine("no existe el codigo");
                 }
                 else{
                 elim=(Persona)(this.tabla[elim.codigo]);
                 Console.WriteLine("Nombre: ");
                 Console.WriteLine(elim.nombre);
		         Console.WriteLine("Telefono: ");
		         Console.WriteLine(elim.telefono);
	             Console.WriteLine("Facbook: ");
	             Console.WriteLine(elim.facebook);
	             Console.WriteLine("Deceas Eliminar S/N");
			     string opc=Console.ReadLine();
			     if(opc=="s"){
				 this.tabla.Remove(elim.codigo);
			     }
			     else {
				 Console.WriteLine("no se elimino");
		       	 }
                 System.Console.Clear();
                 }
		         }
		         }
		public void mostrar(){
			     Console.WriteLine("Mostrar Contenido");
			     IDictionaryEnumerator enumerador = tabla.GetEnumerator();
			     while ( enumerador.MoveNext() ){
			      Persona mostrar=(Persona)(tabla[enumerador.Key]);
			      
			      Console.WriteLine("Codigo");
			      Console.WriteLine(mostrar.codigo);
			      
			      Console.WriteLine("nombre");
			      Console.WriteLine(mostrar.nombre);
			    
			      Console.WriteLine("telefono");
			      Console.WriteLine(mostrar.telefono);
			      
			      Console.WriteLine("facebook");
			      Console.WriteLine(mostrar.facebook);
			     }
			     }
			     
		public void iniciar(){
			this.capturar();
			this.editar();
			this.eliminar();
			this.mostrar();
		}
		}
	}

