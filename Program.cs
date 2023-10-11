//Crear una lista vacía de tipo objeto

List<object> listaVacia = new List<object>();
Console.WriteLine(listaVacia); //System.Collections.Generic.List`1[System.Object]

//Agregue los siguientes valores a la lista: 7, 28, -1, verdadero, "silla"

listaVacia.Add(7);
listaVacia.Add(28);
listaVacia.Add(-1);
listaVacia.Add(true);
listaVacia.Add("silla");

Console.WriteLine(listaVacia[0]);
Console.WriteLine(listaVacia[1]);
Console.WriteLine(listaVacia[2]);
Console.WriteLine(listaVacia[3]);
Console.WriteLine(listaVacia[4]);

//Recorra la lista e imprima todos los valores.

foreach(object recorrido in listaVacia)
{
    Console.WriteLine(recorrido);
}

//Sume todos los valores que son de tipo Int y genere la suma
 int sumRecorrido = 0; 
foreach(object resultado in listaVacia)
{
    if(resultado is int)
    {
        sumRecorrido += (int)resultado;
    }
}
Console.WriteLine(sumRecorrido);





