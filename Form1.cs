using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace PrototypeFixer
{
    public partial class Prototype1Kafi : Form
    {
        string path = "";

        public Prototype1Kafi()
        {
            InitializeComponent();
        }

        private void Prototype1Kafi_Load(object sender, EventArgs e)
        {
            GameDirectoryLabel.Parent = BackgroundImage;
            GameDirectoryLabel.BackColor = Color.Transparent;
            creatorLabel.Parent = BackgroundImage;
            creatorLabel.BackColor = Color.Transparent;
        }


        private void DownloadFixesBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vanadic-jug.000webhostapp.com/Pages/PrototypeKAFI/prototypeKAFI.html");
        }

        private void GDButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            path = folderBrowserDialog.SelectedPath;

            if(path == "")
            {
                GameDirectoryLabel.Text = "Game Directory Not Set";
                GameDirectoryLabel.ForeColor = Color.Red;
            }
            else if (File.Exists(path + "\\prototypef.exe"))
            {
                GameDirectoryLabel.Text = "Game Directory Set";
                GameDirectoryLabel.ForeColor = Color.Green;
            }

            Console.WriteLine(folderBrowserDialog.SelectedPath);
        }

        private void LowFpsFixButton_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\dinput8.dll";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\dinput8.dll";
            var destination = Path.Combine(path + "\\dinput8.dll");

            if (File.Exists(sourceDesktop) && path != "")
            {
                File.Move(sourceDesktop, destination);
            }
            else if (File.Exists(sourceDownloads) && path != "")
            {
                File.Move(sourceDownloads, destination);
            }
        }




        private void CrashFixBTN_Click(object sender, EventArgs e)
        {
            var sourceDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\prototypeenginef.dll";
            var sourceDownloads = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + "\\prototypeenginef.dll";
            var destination = Path.Combine(path + "\\prototypeenginef.dll");

            if (File.Exists(destination))
            {
                File.Delete(destination);

                if (File.Exists(sourceDesktop) && path != "")
                {
                    File.Move(sourceDesktop, destination);
                }
                else if (File.Exists(sourceDownloads) && path != "")
                {
                    File.Move(sourceDownloads, destination);
                }
            }
            else
            {
                if (File.Exists(sourceDesktop) && path != "")
                {
                    File.Move(sourceDesktop, destination);
                }
                else if (File.Exists(sourceDownloads) && path != "")
                {
                    File.Move(sourceDownloads, destination);
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void creatorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KasKillo");
        }
    }
}
