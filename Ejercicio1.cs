using System;			
public class Program
{
	public static void Main()
	{
		int califiacion; // declaré una variable
		Console.Write("Dame tu calificación"); // pedí un dato
		califiacion= Convert.ToInt32(Console.ReadLine()); // Leo lo que me pide el usuario y lo almaceno
		Console.Write("Tienes calificación: "+califiacion);
		// si entonces
		if(califiacion==10){
			Console.Write("Felicidades eres chid@");
		}
		switch(califiacion){
			case 9: 
				Console.Write("Felicidades medio chid@");
			break;
			case 8: 
				Console.Write("Felicidades casi eres chid@");
			break;
			default:
				Console.Write("No te voy a felicitar");
			break; 
		}
		
		
	}
}