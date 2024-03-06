// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int N=888;
if (N>0 && N<10){
     Console.Write(N);
}    
else {
while (N>0){
        int currentDigit = N % 10;
        N /= 10;
        Console.Write(currentDigit + ",");
    }
}  
