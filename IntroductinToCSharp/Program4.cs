using System;

class Program4
{
    static void Main()
    {
        string Name = "El \"mirro\" Bobbio \nis\nkinda\nkewl";
        Console.WriteLine(Name);

        string filename = "c:\\myfolder\\mysubfolder\\myfile \a\a\a\a\a\a\a\a\a\a\a\a";
        Console.WriteLine(filename);

        string filename2 = @"c:\myfolder\mysubfolder\myfile2";
        Console.WriteLine(filename2);

        //int i = 0;
        //Console.WriteLine("Integer Min/Max = {0}/{1}", int.MinValue, int.MaxValue);
    }
}
