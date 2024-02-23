// See https://aka.ms/new-console-template for more information
using SevenZipExtractor;

Console.WriteLine("Hello, World!");

string sourceDir = ""; // Directory to find the .7z files
string targetDir = ""; // Directory to unzip the .7z files to

try
{
    var files = Directory.EnumerateFiles(sourceDir, "*.7z", SearchOption.AllDirectories);

    foreach(string file in files)
    {
        Console.WriteLine(file);

        using (ArchiveFile archive = new ArchiveFile(file))
        {
            archive.Extract(targetDir);
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}