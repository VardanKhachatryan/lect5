// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number=44;
int firstNumber = number/10;
int secondNumber = number % 10;
if (firstNumber>secondNumber){
    Console.Write(firstNumber);
}
else if(firstNumber<secondNumber){
Console.Write(secondNumber);
}
else Console.Write(secondNumber);
