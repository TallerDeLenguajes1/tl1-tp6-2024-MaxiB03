// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);*/

//EJERCICIO 1
/* 
Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
*/
/*int num, dec, cen, uni, nuevoNum;

Console.WriteLine("Ingrese un numero: ");
bool control=int.TryParse(Console.ReadLine(), out num);

if(control)
{
    if(num>99)
    {
        dec=num/10;
        dec=dec%10;
        cen=num/100;
        uni=num%10;
        nuevoNum=(uni*100)+(dec*10)+cen;
        Console.WriteLine("Numero Invertido: "+nuevoNum);
    }else{
        if(num>9)
        {
            uni=num/10;
            dec=num%10;
            nuevoNum=(dec*10)+uni;
            Console.WriteLine("Numero Invertido: "+nuevoNum);
        }else{
            Console.WriteLine("El Numero No puede invertirse: "+num);
        }
    }
}else{
    Console.WriteLine("No es numero, ingrese nuevamente");
}*/

//EJERCICIO 2

