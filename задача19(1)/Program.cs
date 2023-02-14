// Задача19(1) Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void palindrome (int uN)

{
    int ed = uN % 10;
    int dec = uN % 100 / 10;
    int thous = uN / 1000 % 10;
    int tenthous = uN / 10000;
   
    if (ed == tenthous && dec == thous )
   {
        Console.WriteLine("this number is a palindrome");
   }
    
   else
   Console.WriteLine("this number is not a palindrome");

}
Console.Write("enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 & number <100000)
{
    palindrome(number);
}
else
Console.WriteLine("you entered a non-five-digit number, please try again");
