using System;
class multiplication{
	public static void Main(){
			
	Console.WriteLine("Enter the number");
	int n=Convert.ToInt32(Console.ReadLine());
	double multiplication;
	for(int i=1;i<=20;i++)
	{
		multiplication=i*n;
		Console.WriteLine(n +"*"+i+ "=" +multiplication);
	}
}
}