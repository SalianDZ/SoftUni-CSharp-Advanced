using System.Security.Cryptography.X509Certificates;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            Console.WriteLine(GetFolderSize(folderPath));
        }


        public static long GetFolderSize(string path)
        {
            string[] filePaths = Directory.GetFiles(path);

            long size = 0;

            foreach (var filePath in filePaths)
            {
                FileInfo info = new(filePath);
                size += info.Length;
            }

            foreach (var dirPaths in Directory.GetDirectories(path))
            {
                size += GetFolderSize(dirPaths); 
            }
            return size;
        }
    }
}