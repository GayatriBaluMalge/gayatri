
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;                                                                                   
using System.Runtime.Serialization.Formatters.Binary;

    class collections
    {


        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(" brownie");
            al.Add(" cookie");
            al.Add("ice cream");
            al.Add(" custarurds");
            al.Add("frozen");
            FileStream fs = new FileStream("C:\\Day5Task03\\Fyle2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter swr = new StreamWriter(fs);
            foreach (var i in al)
                swr.Write(i);
            swr.Flush();
            swr.Close();
            fs.Close();

            FileStream fr = new FileStream("C:\\Day5Task03\\Fyle2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(
                sr.ReadToEnd());
            sr.Close();
            fr.Close();
            FileInfo f1 = new FileInfo("C:\\Day5Task03\\Fyle2.txt");

            Console.WriteLine(f1.Length);
            Console.WriteLine(f1.CreationTime);
            Console.Read();
        }



    

}