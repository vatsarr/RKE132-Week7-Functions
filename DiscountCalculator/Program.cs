
Console.WriteLine("Enter total sum for discount:");
int userTotal = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userTotal);
Console.WriteLine($"Your discount is {discount}%");

double newTotal = CalculateNewTotal(userTotal, discount);
Console.WriteLine($"Updated total with disount is: {newTotal} euros");

static double CalculateDiscount(int total)
{
	if (total < 10)
	{
		return 1;
	}
	else if (total >= 10 && total < 20)
	{
		return 5;
	}
	else
	{
		return 10;
	}
};

static double CalculateNewTotal(double total, double discount)
{
	double result = total - (total * discount) / 100;
	return result;
};