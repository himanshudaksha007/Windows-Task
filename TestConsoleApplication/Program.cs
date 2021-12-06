// See https://aka.ms/new-console-template for more information

using System.Text;

string guid = System.Guid.NewGuid().ToString();
string testString = "Test File";
byte[] buffer = Encoding.ASCII.GetBytes(testString);
File.WriteAllBytes("c:/temp/" + guid + ".txt", buffer);

Console.WriteLine("Hello, World!");
