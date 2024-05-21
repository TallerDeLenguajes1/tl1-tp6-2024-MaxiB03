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
//op=int.Parse(Console.ReadLine()); //Entrada como cadena y Convierte la cadena en entero

//EJERCICIO 2

int op, resp, num1, num2;

do
{
    Console.WriteLine("Operaciones:");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("Selecionar Operacion: ");
    bool controlOp=int.TryParse(Console.ReadLine(), out op);

    if(controlOp)
    {
        //Controlo que cadena ingresada sea un numero
        Console.WriteLine("Ingrese un numero: ");
        bool control1=int.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Ingrese otro numero: ");
        bool control2=int.TryParse(Console.ReadLine(), out num2);

        if(control1 && control2)
        {
            switch (op)
            {
                case 1:
                Console.WriteLine("El resultado de la Suma es:"+(num1+num2));
                break;
                case 2: 
                Console.WriteLine("El resultado de la Diferencia es:"+(num1-num2));
                break;
                case 3:
                Console.WriteLine("El resultado del Producto es:"+(num1*num2));
                break;
                case 4:
                Console.WriteLine("El resultado de la Division es:"+(num1/num2));
                break;

                default:
                Console.WriteLine("La Operacion Ingresada no existe");
                break;
            }

        }else{
            Console.WriteLine("Algun dato Ingresado no es un numero, Ingrese nuevamente");
        }

    }else{
        Console.WriteLine("Operacion Ingresada Incorrecta");
    }

    Console.WriteLine("Desea Realizar otra Operacion?(Si=1)(No=0)");
    bool controlResp=int.TryParse(Console.ReadLine(), out resp);
    
} while (resp!=0);