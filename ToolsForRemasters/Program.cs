using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ToolsForRemasters
{
    public static void Main(string[] args)
    {
        string[] files = Directory.GetFiles(Console.ReadLine());

        var groupedFiles = files
            .Where(file =>
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                return fileName.Length > 40;
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
            if (group.Count() > 3)
            {
                Console.WriteLine("Need check: " + group.Key);
                Directory.CreateDirectory(group.Key);
                foreach (var file in group)
                    File.Copy(file, group.Key + "\\" + Path.GetFileName(file), true);
            }
            else
            {
                string? largestFile = group.OrderByDescending(f => new FileInfo(f).Length).FirstOrDefault();
                foreach (var file in group)
                    if (new FileInfo(largestFile).Length > new FileInfo(file).Length + 30000)
                        File.Copy(largestFile, file, true);
            }
        }

        Console.ReadLine();
    }
}
