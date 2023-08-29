//#region variables
////Enteros
//int num1 = 0;

////Decimales y flotante
//double num2 = 2.0;

//float num3 = 3.5F;

////Caracteres y strings
//char char4 = '4';

//string saludo = "hola";

////Booleano
//bool verdadero = true;

//#endregion

//#region operaciones basicas
//int valor1 = 5;
//int valor2 = 2;

////suma
//int suma = valor1 + valor2;
////resta
//int resta = valor1 - valor2;
////multiplicacion
//int multiplicacion = valor1 * valor2;

////division
//double division = valor1 / valor2;

////potencias
//double potencias = Math.Pow(valor1, valor2);

////modulo
//double modulo = valor1 % valor2;

////Concatenacion
//char charConcatenar = 'A';
//string cadenaAConcatenarUno = "Hola";
//string cadenaAConcatenarDos = "mundo";

//string concatenacion = $"{cadenaAConcatenarUno} {charConcatenar} {cadenaAConcatenarDos}";
//#endregion

//#region condicionales
//if (2 > 3)
//{
//    Console.WriteLine(true);
//}
//else if (9 > 8)
//{
//    Console.WriteLine("4 es mayor que 8");
//}
//else
//{
//    Console.WriteLine(false);
//}

//int precio = 3;
//switch (precio)
//{
//    case 1:
//        Console.WriteLine(true);
//        break;
//    case 2:
//        Console.WriteLine(false);
//        break;
//    default:
//        Console.WriteLine("Hola");
//        break;
//}



//#endregion

//#region ciclos
//for(int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//int contador = 0;
//while (contador <= 10)
//{
//Console.WriteLine(contador);
//    contador++;
//}
//#endregion

//#region Arrays/listas, mapas
//int[] numeros = {1,2,3,4};
//string[] nombres = { "Juan", "Pepe", "Pablo" };

//List<int> numerosImpares = new List<int>(); //[]
//numerosImpares.Add(3); //[3]
// numerosImpares.AddRange(numeros);//[3,1,2,3,4]

//numerosImpares.Where(x => x == 8).FirstOrDefault(0);

//Dictionary<string,string> miMapa = new Dictionary<string,string>();
//miMapa.Add("nombre", "sebas");
//miMapa.Add("apellido", "perez");

//string resultadoMapa;

//bool esEncontrado = miMapa.TryGetValue("apellido", out resultadoMapa);

//if (esEncontrado)
//{
//    Console.WriteLine($"El resultado del mapa es:{resultadoMapa}");
//}
//#endregion

//int initializeInMethod;
//if (OutArgExample(out initializeInMethod))
//{
//Console.WriteLine(initializeInMethod);     // value is now 44
//}

//bool OutArgExample(out int number)
//{

//    number = 44;

//    return true;
//}

#region funciones

static void saludar()
{
    Console.WriteLine("Hola, como estas?");
}
saludar();
int sumarNumeros(int x, int y)
{
    return x + y;
}
Console.WriteLine(sumarNumeros(2, 3));

string concatenarCadenas(string cadena1, string cadena2)
{
    return $"{cadena1} {cadena2}";
}
Console.WriteLine(concatenarCadenas("hola", "mundo"));

/**
 * Retornar si el numero 1 es mayor que numero dos
 * e indicar que numero es mayor
 */
bool verdaderoOFalso(int numero1, int numero2, out int grandNumberx)

{

    if(numero1 > numero2)
    {
        grandNumberx = numero1;
        return true;
    }

    grandNumberx = numero2;
    //num uno es mayor que num 2 
    return false;
    
}
int grandNumber;

verdaderoOFalso(3, 2, out grandNumber);
Console.WriteLine();

Console.WriteLine(grandNumber);

bool verdaderoOFalso2(int num1, int num2)
{
    int numeroMayor;
    if (num1 > num2)
    {
        numeroMayor = num1;
        return true;
    }
    numeroMayor = num2;
    return false;
}
Console.WriteLine(verdaderoOFalso2(3,2));
Console.WriteLine();

#endregion
