int Summ(int m, int n)
{
	int start = m;
	int end = n;
	if(m > n)
	{
		start = n;
		end = m;
	}
    else if(n == m)
	{
	    return m;
	}
	return (end + start)*(end - start + 1)/2;
}
		
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summ(m, n));