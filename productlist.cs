using System; 
class products
{
public static void Main()
{
String [][] arr = new String[3][];
arr[0] = new String[4]{"parle-G","20-20","Coconut","patanjali"};
arr[1] = new String[5]{"kaccha mango","dark-fantacy","melody","dairymilk","kitcat"};
arr[2] = new String[6]{"sprite","fanta","thumbs up","maaza","cococola","pepsi"};
for(int i =0;i<arr.Length;i++)
{
	for(int j=0;j<arr[i].Length;j++)
	Console.Write(arr[i][j] +"\t");
Console.WriteLine();
}
}
}