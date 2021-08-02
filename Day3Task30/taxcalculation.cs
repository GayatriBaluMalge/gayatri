using System;
class TaxCalculation
{
public virtual void calculateTax()
{
int value = 50000;
double vat = ((2.0/100)*value);
Console.WriteLine("The VAT is " + vat);
}
}
class Tax : TaxCalculation
{
public override void calculateTax()
{
int val = 70000;
double gst = ((12.0/100)*val);
Console.WriteLine("The GST is " + gst);
}
public static void Main()
{
TaxCalculation tc = new TaxCalculation();
tc.calculateTax();
Tax t = new Tax();
t.calculateTax();
}
}