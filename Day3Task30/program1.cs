using System;
class Program1
{
abstract class parent
{
public void add(int x,int y)
{
Console.WriteLine(x+y);
}
public void sub(int x,int y)
{
Console.WriteLine(x-y);
}

public abstract void mul(int x,int y);
public abstract void div(int x,int y);
}

class child: parent
{
public override void mul(int x,int y)
{
Console.WriteLine(x*y);
}
public override void div(int x,int y)
{
Console.WriteLine(x/y);
}
public static void Main()
{
child c=new child();
c.add(12,2);
c.sub(12,2);
c.mul(12,2);
c.div(12,2);
}
}
}

