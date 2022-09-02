// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int numberM = 4;
int numberN = 8;
void Findsum(int numberM, int numberN, int sum = 0)
{ 
     
    if (numberM > numberN)
    {
    Console.WriteLine(sum);
    return;
    }
    sum = sum + numberM; 
    numberM++;
   
    Findsum(numberM,numberN, sum);
}
Findsum(numberM, numberN);