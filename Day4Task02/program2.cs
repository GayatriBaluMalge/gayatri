using System;
interface packages
{
void silver();
void gold();
void platinum();
}
class membership: packages
{
public void silver()
{
Console.WriteLine("3 days accomadation at resort");
}
public void gold()
{
Console.WriteLine("5 days accomadation at resort & 2 dinner on the house");
}
public void platinum()
{
Console.WriteLine("7 days accomadation at resort &5 dinner on the house");
}
}
class program
{
public static void Main()
{
membership m=new membership();
m.silver();
m.gold();
m.platinum();
}
}