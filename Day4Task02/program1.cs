using System;
class empdetail
{
String name;
int age;
public empdetail(string name,int age)
{
this.name=name;
this.age=age;
}

public static void Main()
{
empdetail e1=new empdetail("gayu",23);
Console.WriteLine(e1.name);
Console.WriteLine(e1.age);


}
}