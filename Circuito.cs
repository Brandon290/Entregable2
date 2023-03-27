namespace Carrera;
using System.Collections.Generic;


public class Circuito
{

    public string nombre{get;set;}
    public int vueltas{get;set;}

    public IMonoplaza? CarroActual;

    public List<IMonoplaza> monoplazas = new List<IMonoplaza>();

    public Circuito(string nombre,int vueltas){

        this.nombre = nombre;
        this.vueltas = vueltas;
    }

    public void AgregarMonoplaza(IMonoplaza monoplazas){
        if(CarroActual != null){
            Console.WriteLine("Ya hay un carro, espere turno");
            return;
        }

         Console.WriteLine("${monoplazas.escuderia} Se ha añadido un carro");
         CarroActual = monoplazas;
        
    }


    public void Prueba(){
        if(CarroActual ==null)
        {
             Console.WriteLine("No hay carro");
             return;

        }

        CarroActual.encender();
        CarroActual.movimiento();

        Console.WriteLine("${CarroActual.carroceria} Monoplaza haciendo prueba");

        CarroActual.apagar();
        CarroActual.detener();
    }

    public void ElminarMonoplaza(){
        if(CarroActual == null)
        {
             Console.WriteLine("No hay carro en el circuito");
             return;
        }

          Console.WriteLine("${CarroActual.carroceria} El carro sera eliminado del circuito");
          CarroActual = null;

    }
}