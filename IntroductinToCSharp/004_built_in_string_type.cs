using System;

class built_in_string_type_004
{
    static void Main()
    {
        // escape quotes, new line
        string Name = "El \"mirro\" Bobbio \nis\nkinda\nkewl";
        Console.WriteLine(Name);

        // escape backslash (file paths), bell
        string filename = "c:\\myfolder\\mysubfolder\\myfile \a \a \a";
        Console.WriteLine(filename);

        // verbatim literal (treat escape sequences as printable characters    
        string filename2 = @"c:\myfolder\mysubfolder\myfile \a \a";
        Console.WriteLine(filename2);
    }
}
