using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ATX___File_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
        }
        string file1;
        string file2;
        string file1Hash;
        string file2Hash;

        public static string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        private void fileName1_Click(object sender, EventArgs e)
        {

        }

        private void uploadFile1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            this.openFileDialog1.Multiselect = false;
            foreach (String file in openFileDialog1.FileNames)
            {
                file1 = file;
                fileName1.Text = file;
                file1Hash = GetChecksum(file);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("File1 Hash = " + file1Hash);
            }
        }

        private void uploadFile2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            this.openFileDialog1.Multiselect = false;
            foreach (String file in openFileDialog1.FileNames)
            {
                file2 = file;
                fileName2.Text = file;
                file2Hash = GetChecksum(file);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("File2 Hash = " + file2Hash);
            }
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(file1Hash == file2Hash)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File1 Hash" + "(" + file1 + ")" + " is EQUAL to File2!" + "(" + file2 + ")" + " (File is the same)");
                MessageBox.Show("File 1 " + "(" + file1 + ")" + " is the same as File 2 " + "(" + file2 + ")");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File1 Hash" + "(" + file1 + ")" + " is NOT equal to File2!" + "(" + file2 + ")" + " (File is NOT the same)");
                MessageBox.Show("File 1 " + "(" + file1 + ")" + " is NOT the same as File 2 " + "(" + file2 + ")");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Title = "ATX - FileID - Output";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FileID is ready!");
        }
    }
}
