using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsForRemasters
{
    public partial class FormToolsForRemasters : Form
    {
        public FormToolsForRemasters()
        {
            InitializeComponent();
        }

        private void FormToolsForRemasters_Load(object sender, EventArgs e)
        {
            Color foreColor = Color.White;
            Color backColor = Color.FromArgb(20, 44, 42);
            Color buttonColor = Color.FromArgb(118, 178, 56);

            BackColor = backColor;
            foreach (Control control in Controls)
                if (control is Button)
                    control.ForeColor = buttonColor;
                else if (control is Label || control is CheckBox)
                    control.ForeColor = foreColor;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Repair(TextBoxPath.Text, NumericUpDownLimit.Value, NumericUpDownMultiplier.Value, ProgressBar);
            MessageBox.Show("Done!");
        }

        private void ButtonFindTemp_Click(object sender, EventArgs e)
        {
            FindTemp(TextBoxPath.Text, ProgressBar);
            MessageBox.Show("Done!");
        }

        private static void Repair(string path, decimal limit, decimal multiplier, ProgressBar progressBar)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
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
            progressBar.Value = 0;
            progressBar.Maximum = groupedFiles.Where(g => g.Count() > 2).Count();
            foreach (var group in groupedFiles.Where(g => g.Count() > 2))
            {
                progressBar.Value++;
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
        }

        private static void FindTemp(string path, ProgressBar progressBar)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            var tempFiles = files
                .Where(file =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    return fileName.Length <= 36;
                });
            Directory.CreateDirectory("temp");
            progressBar.Value = 0;
            progressBar.Maximum = tempFiles.Count();
            foreach (var file in tempFiles)
            {
                progressBar.Value++;
                File.Move(file, "temp\\" + Path.GetFileName(file));
            }
        }
    }
}
