using Part_4___Random_Numbers;
int minNumber, maxNumber, number1, number2, number3, number4, number5;
Random generator = new Random();


Console.WriteLine("hey, type in a number");
minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Great! Now type in a number greater than the previous");
maxNumber  = Convert.ToInt32(Console.ReadLine());
number1 = generator.Next(minNumber, maxNumber);
number2 = generator.Next(minNumber, maxNumber);
number3 = generator.Next(minNumber, maxNumber);
number4 = generator.Next(minNumber, maxNumber);
number5 = generator.Next(minNumber, maxNumber);
Console.WriteLine($"Numbers are {number1} {number2} {number3} {number4} {number5}");


Die die1 = new Die();
Console.WriteLine(die1);
die1.RollDie();

Die die2 = new Die();
Console.WriteLine(die1);
die2.RollDie();
