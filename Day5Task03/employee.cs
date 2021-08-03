using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace firstconsole
{
    [Serializable]
    class EmployeeDetails
    {
        int EmpID;
        string Name;
        string Gender;
        int Age;
        public  EmployeeDetails(int id, string name, string gender, int age)
        {
            EmpID = id;
            Name = name;
            Gender = gender;
            Age = age;
        }
        public static void Main()
        {
            EmployeeDetails ed = new EmployeeDetails(2, "gayatri", "Female", 23);
            FileStream fs = new FileStream("C:/Day5Task03/EmployeeData.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ed);
            fs.Close();
        
            FileStream fs1 = new FileStream("C:/Day5Task03/EmployeeData.txt", FileMode.Open, FileAccess.Read);           
            EmployeeDetails e = (EmployeeDetails)bf.Deserialize(fs1);
            Console.WriteLine(e.EmpID);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Gender);
            Console.WriteLine(e.Age);
            Console.Read();
        }
    }
}