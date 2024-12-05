// string fileName = "myfile.txt";
// string fileName2 = "myfile.txt2";

// var flh = File.CreateText(fileName);
// flh.WriteLine("This is my first line");
// flh.Close();
// flh.Dispose();
// IDisposable
// using (StreamWriter flh2 = File.CreateText(fileName2))
// {
//     flh2.WriteLine("my test");
// }
// Console.WriteLine(flh);

//public static System.IO.StreamWriter AppendTxt (string path);
// string path = "files/myfile.txt";

string dirName = "files";
DirectoryInfo di;
if (!Directory.Exists(dirName))
{
  di = Directory.CreateDirectory(dirName);
}else {
    di = new DirectoryInfo(dirName);
}
foreach (var file in di.GetFiles())
{
    var fw = file.AppendText();
    fw.WriteLine("This is a message");
    fw.Close();
    Console.WriteLine(file);
}
foreach (var file in di.GetFiles())
{
    file.Delete();
    Console.WriteLine(file);
}


// using (StreamWriter sw = File.AppendText(path))
// {
//     sw.WriteLine("This is a new line");
// }

// using (StreamReader sr = File.OpenText(path))
// {
//     string? s;
//     while ((s = sr.ReadLine()) != null)
//     {
//             Console.WriteLine(s);
//     }
// }

// try
// {
//     string[] lines = File.ReadAllLines(path);
//     foreach (var line in lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// catch (FileNotFoundException)
// {
//     Console.WriteLine($"The file you provide {path} doesn't exist");
// }
// catch (Exception e)
// {

//     Console.WriteLine(e.Message);
//     Console.WriteLine(e.GetBaseException());
// }
// finally{
//     Console.WriteLine("This is finally");
// }
// Console.WriteLine("The code goes on");




