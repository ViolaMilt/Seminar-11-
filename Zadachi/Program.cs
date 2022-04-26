//Задача 1. На вход подаются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].


 Console.WriteLine ("Задача 1 ");
int n = 5;
int m = 8;


void Massive (int x,int y)
{

int []array = new int[5];
Random rand = new Random ();

for ( int i = 0; i<array.Length; i++)
{
    array[i] = rand.Next (x,y+1);
    Console.Write (array[i] + " ");
}
}


Massive (n,m);

Console.WriteLine ("  ");
Console.WriteLine ("Задача 2");
//Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10.
 //Найдите количество элементов, значение которых больше 5, и их сумму.

 void Metod ()
{
int count = 0;
int sum = 0;
int [,]massiv = new int[3,3];
Random rand = new Random ();

for ( int i = 0; i<massiv.GetLength(0); i++)
{
    for ( int j = 0; j<massiv.GetLength(1); j++)
    {massiv[i,j] = rand.Next (1,11);
     Console.Write (massiv[i,j] + "   ");
     if (massiv[i,j] > 5)
     {
         count = count + 1;
         sum = sum + massiv[i,j];
     }
    }
    Console.WriteLine (" ");
}
  Console.WriteLine ("Количество элементов > 5 =  " + count);
  Console.WriteLine ("Сумма элементов > 5 =  " + sum);
}

Metod();


Console.WriteLine ("Задача 3");
//Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.


Console.WriteLine ("Введите интересующий год");

int x = Convert.ToInt32(Console.ReadLine ());
int proverka =0;

void VisokosniiGod(int a,int del = 4)
{   

    if ( a%4 !=0 || ( a%100 ==0 && a%400 != 0)) 
    {Console.WriteLine (" Введенный год не високосный");
    return;
    }
    else
    {
       if ( a%del == 0)
      {
        proverka = proverka + 1;
        
        if (del == 4)
        {
            del=100;
            
            VisokosniiGod(a,del);
        }
        if (del == 100)
        {
            del=400;
            
           VisokosniiGod (a,del);
        }

    }
        else
        { if( del==100)
         {
            proverka = proverka + 1;
           Console.WriteLine (proverka);
           Console.WriteLine (" Введенный год високосный_100");
         }
        }
    
    
  if (proverka == 3)
{
    proverka =0;

Console.WriteLine (" Введенный год високосный");

}
        }//главный else

    
}//метод
VisokosniiGod (x);