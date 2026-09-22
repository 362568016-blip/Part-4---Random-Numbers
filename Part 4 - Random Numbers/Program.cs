int minNumber, maxNumber, number1, number2, number3, number4, number5, dieNumber1, dieNumber2, totalNumber; 
double decimalNumber1, decimalNumber2, decimalNumber3;
Random generator = new Random();


Console.WriteLine("hey, type in a number");
minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Great! Now type in a number greater than the previous");
maxNumber = Convert.ToInt32(Console.ReadLine());
number1 = generator.Next(minNumber, maxNumber);
number2 = generator.Next(minNumber, maxNumber);
number3 = generator.Next(minNumber, maxNumber);
number4 = generator.Next(minNumber, maxNumber);
number5 = generator.Next(minNumber, maxNumber);
Console.WriteLine($"Numbers are {number1} {number2} {number3} {number4} {number5}");


dieNumber1 = generator.Next(1, 7);
dieNumber2 = generator.Next(1, 7);
totalNumber = (dieNumber1 + dieNumber2);
Console.WriteLine($"Your two dice numbers are {dieNumber1} and {dieNumber2}.");
Console.WriteLine($"The Total is {totalNumber}!");


//decimalNumber1 = generator.NextDouble() + Convert.ToInt32(Console.ReadLine());
//decimalNumber2 = generator.NextDouble() + Convert.ToInt32(Console.ReadLine());
//decimalNumber3 = generator.NextDouble() + Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(decimalNumber1, decimalNumber2, decimalNumber3);

//i give up