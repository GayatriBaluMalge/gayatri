using System;
class students{
	public static void Main(){
	double total=0;
	double percentage;
		
int[]marks =new int[]{32,45,39,23,65};
for(int i=0;i<marks.Length;i++)
 Console.WriteLine(marks[i]);
foreach(int i in marks)
	{
		total=total+i;
	}
percentage= (total/500)*100;
		Console.WriteLine("percentage is="+percentage+" total is="+total);
}
}
