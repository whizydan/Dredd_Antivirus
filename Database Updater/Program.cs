// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlClient;
using System.Text;


const Int32 BufferSize = 1024;
string dataSource = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Dredd Antivirus\\Dredd Antivirus\\Dredd Antivirus\\Data.mdf\";Integrated Security=True;Connect Timeout=30";
SqlConnection conn = new SqlConnection(dataSource);
conn.Open();


using (var fileStream = File.OpenRead("C:\\Users\\Kerberos\\Downloads\\VirusShare_00003.md5"))
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
{
    String line; int i = 0;
    while ((line = streamReader.ReadLine()) != null)
    {
        Console.WriteLine($"Writing hash {i}: {line}");
        SqlCommand cmd = new SqlCommand($"insert into Viruses(Hash) values('{line}')", conn);
        cmd.ExecuteNonQuery();
        i++;
    }
}