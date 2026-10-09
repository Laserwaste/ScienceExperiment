int temp;
do
{
    Console.WriteLine("Enter a number the temperature: ");
    temp = int.Parse(Console.ReadLine());
    if (temp < -50 || temp > 150)
    {
        Console.WriteLine("Please enter a valid temperature between -50 and 150.");
    }
}
while (temp < -50 || temp > 150);

Console.WriteLine($"Temperature Category: {temp} °C");
switch (temp)
{
    case > 100:
        Console.WriteLine("Category: Extreme.");
        break;
    case > 32:
        Console.WriteLine("Category: Hot.");
        break;
    case >= 0:
        Console.WriteLine("Category: Normal.");
        break;
    
    case < 0:Console.WriteLine("freezing.");
        break;    
    
}