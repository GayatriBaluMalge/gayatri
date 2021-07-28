using System;
class CampusRecruit
{
public static void Main()
{

Console.WriteLine("Enter your GPA");
int GPA= Convert.ToInt32(Console.ReadLine());

if(GPA >=7  )
{
Console.WriteLine("Aptitude test"); 
Console.WriteLine("enter apti score ");
 int AptiScore= Convert.ToInt32(Console.ReadLine());
if(AptiScore >=7  )
{
Console.WriteLine("technical interview"); 
Console.WriteLine("enter technical score");
 int techscore= Convert.ToInt32(Console.ReadLine());

if(techscore >=7  )
{
Console.WriteLine("HR Interview"); 
Console.WriteLine("Enter your HR Score ");
 int hrScore= Convert.ToInt32(Console.ReadLine());

if(hrScore >=7  )
{
Console.WriteLine("Selected"); 
}
else
{
Console.WriteLine("Not Selected");
}
}
else
{
Console.WriteLine("Try after 3 months");
}
}
else
{
Console.WriteLine("Try after 6 months");
}
}
else
{
Console.WriteLine("Not Eligible");
}
}
}