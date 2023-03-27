using Carrera;
using System.Collections.Generic;


Circuito circuito = new Circuito("Monaco", 2);

Monoplaza mclaren = new Monoplaza("Mclaren");
Monoplaza ferrari = new Monoplaza("Ferrari");
Monoplaza redBull = new Monoplaza ("RedBull");

circuito.AgregarMonoplaza(mclaren);
circuito.Prueba();


circuito.AgregarMonoplaza(ferrari);
circuito.Prueba();

circuito.AgregarMonoplaza(redBull);
circuito.Prueba();

circuito.ElminarMonoplaza();