using System;
class program{
	public static void Main(){
				
	Console.WriteLine("Enter your name and age");
	String name=Console.ReadLine();
	int age=Convert.ToInt32(Console.ReadLine());
	for(int i=0;i<age;i++)
	{
		Console.WriteLine(name);
	}

}
}