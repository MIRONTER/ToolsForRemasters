using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsForRemasters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Path to directory:");
            string[] files = Directory.GetFiles(Console.ReadLine(), "*", SearchOption.AllDirectories);
            Console.WriteLine("Limit of files in group:");
            int limit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Multiplier:");
            int multiplier = Convert.ToInt16(Console.ReadLine());

            var groupedFiles = files
                .Where(file =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    return fileName.Length > 36;
                })
                .GroupBy(file =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    int start = fileName.IndexOf('-');
                    int end = fileName.IndexOf('-', start + 1) - start;
                    return fileName.Substring(start, end);
                });
            foreach (var group in groupedFiles.Where(g => g.Count() > 1))
            {
                if (group.Count() > limit)
                {
                    Console.WriteLine("Need check: " + group.Key);
                    Directory.CreateDirectory(group.Key);
                    foreach (var file in group)
                        File.Copy(file, group.Key + "\\" + Path.GetFileName(file), true);
                }
                else
                {
                    string largestFile = group.OrderByDescending(f => new FileInfo(f).Length).FirstOrDefault();
                    foreach (var file in group)
                        if (new FileInfo(largestFile).Length > new FileInfo(file).Length * multiplier)
                            File.Copy(largestFile, file, true);
                }
            }

            var tempFiles = files
                .Where(file =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    return fileName.Length <= 36;
                });
            Directory.CreateDirectory("temp");
            foreach (var file in tempFiles)
            {
                File.Move(file, "temp\\" + Path.GetFileName(file));
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
