// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("у=k1*х + b1 and y=k2*x + b2.");
EnterCoeff("k1");
double k1=Convert.ToDouble(Console.ReadLine());
EnterCoeff("b1");
double b1=Convert.ToDouble(Console.ReadLine());
EnterCoeff("k2");
double k2=Convert.ToDouble(Console.ReadLine());
EnterCoeff("b2");
double b2=Convert.ToDouble(Console.ReadLine());

FindCoordinates(k1,k2,b1,b2); 

void FindCoordinates(double k1, double k2, double b1, double b2)
{
  double [] coord = new double [2]; 
  
  if (k1==k2 && b1==b2)
    {
        Console.WriteLine("");
        return;
    } 
  else if (k1==k2)
    {
        Console.WriteLine("Прямые паралельны");
        return;
    }
  else
   {
       coord[0] = (b2-b1)/(k1-k2);
       coord[1] = k1*coord[0] + b1;
       Console.WriteLine($" у={k1}*х + {b1} and y={k2}*x + {b2} equal to [{coord[0]} ; {coord[1]}].");
   }
  
} 


void EnterCoeff (string nameCoeff)
{
   Console.Write($"Enter coefficient {nameCoeff}: ") ;
}

