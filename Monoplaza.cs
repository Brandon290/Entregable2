namespace Carrera;
using System.Collections.Generic;

public class Monoplaza: IMonoplaza
{

    public string escuderia {get; set;}

    public Monoplaza(string escuderia){
      
      this.escuderia = escuderia;
    }

    public void encender()
    {

            Console.WriteLine("{Monoplaza.escuderia} El vehiculo esta encendido");

       }

    public void apagar()
    {

            Console.WriteLine(" {escuderia} El vehiculo esta apagado");

       
    }

    public void movimiento()
    {

            Console.WriteLine("{escuderia} El vehiculo esta en movimiento");

       
    }

    public void detener()
    {

            Console.WriteLine("{escuderia} El vehiculo esta parado");

       
    }

}