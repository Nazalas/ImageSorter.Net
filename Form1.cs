using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Image_Sorter
{
    public partial class Form1 : Form
    {
        private static Regex r = new Regex(":");

        public Form1()
        {
            InitializeComponent();
            txtSourceDirectory.Text = @"C:\temp\images_unsorted";
            txtTargetDirectory.Text = @"C:\temp\images_sorted";

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string sourceDirectory = txtSourceDirectory.Text;
            string targetDirectory = txtTargetDirectory.Text;

            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show("Invalid Source Directory");
            }
            else
            {
                IEnumerable<string> fileEntries = null;

                bool recursive = chkRecursive.Checked;
                bool overwrite = chkOverwrite.Checked;

                if (recursive)
                {
                    fileEntries = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);
                }
                else
                {
                    fileEntries = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly);
                }

                if(fileEntries.Count() <= 0)
                {
                    MessageBox.Show("No Files to sort");
                    return;
                }

                progressBar.Minimum = 1;
                progressBar.Maximum = fileEntries.Count();
                progressBar.Value = 1;
                progressBar.Step = 1;

                txtResults.Text += "Searching..." + Environment.NewLine;
                txtResults.Text += "Found " + fileEntries.Count() + "Files" + Environment.NewLine;

                foreach (string fileEntry in fileEntries)
                {
                    string fileTargetPath = null;
                    FileInfo fileInfo = new FileInfo(fileEntry);

                    if (!(fileInfo.Extension == ".jpg" || fileInfo.Extension == ".jpeg" || fileInfo.Extension == ".gif" || fileInfo.Extension == ".png"))
                    {
                        continue;
                    }

                    try
                    {
                        DateTime createdTime = GetDateTakenFromImage(fileEntry);

                        int year = createdTime.Year;
                        int month = createdTime.Month;
                        int day = createdTime.Day;

                        fileTargetPath = targetDirectory + @"\" + year + @"\" + month + @"\" + day;
                    }
                    catch(InvalidDateException ex)
                    {
                        fileTargetPath = targetDirectory + @"\unknown_date";
                    }

                    

                    if (!Directory.Exists(fileTargetPath))
                        Directory.CreateDirectory(fileTargetPath);

                    string fileTarget = fileTargetPath + @"\" + fileInfo.Name;

                    if (File.Exists(fileTarget) && overwrite)
                        File.Delete(fileTarget);

                    if (File.Exists(fileTarget) && !overwrite)
                    {
                        progressBar.PerformStep();
                        continue;
                    }
                        
                    fileInfo.MoveTo(fileTarget);

                    progressBar.PerformStep();
                }

                txtResults.Text += "Complete" + Environment.NewLine;
            }
        }

        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                string dateTaken = null;
                try
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    return DateTime.Parse(dateTaken);
                }
                catch(Exception ex)
                {
                    throw new InvalidDateException("Invalid Date");
                }

            }
        }
    }

    [Serializable]
    public class InvalidDateException : Exception
    {
        public InvalidDateException() : base() { }
        public InvalidDateException(string message) : base(message) { }
        public InvalidDateException(string message, Exception inner) : base(message, inner) { }

        protected InvalidDateException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
