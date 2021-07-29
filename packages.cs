using System;
class packages{
	public static void Main()
{
 string packages;
 Console.WriteLine("Enter your  package like  A,B,C");
 packages=Console.ReadLine();
	switch(packages){
	case "A":Console.WriteLine("package has Youth special,Children's club and movies and the cost is 250rs");
		break;
	case "B":Console.WriteLine("Your package has Movie,sports,news and regional-2 Channels, the cost is 450rs");	
		break;
	case "C":Console.WriteLine("Your package has Discovery,History and national, the cost is 350rs");
		break;
	default:Console.WriteLine("No pakages available ");
		break;
}
}


}