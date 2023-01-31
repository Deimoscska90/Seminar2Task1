int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000);
    return result;
}

int GetDeleteOfFirstAndThirdNumber(int number)
{   
int SecondDigit = number%100; 
   
return SecondDigit/10;
}

int number = GetNumber();
int result = GetDeleteOfFirstAndThirdNumber(number);

Console.WriteLine($"Было:{number}, Стало:{result}");