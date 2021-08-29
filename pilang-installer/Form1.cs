using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pilang_installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string installationPath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\pilang";
        
        private void pathChangeButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    installationPath = dialog.SelectedPath;
                }
                refreshInstallationPath();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = strings.STEP_DIRECTORY;

            Directory.CreateDirectory(installationPath);
            
            FileInstaller.ExtractEmbeddedFile("pilang_installer.pilang.bat", installationPath + "\\pilang.bat");
            FileInstaller.ExtractEmbeddedFile("pilang_installer.pilang.jar", installationPath + "\\pilang.jar");

            statusLabel.Text = strings.FINISHED;
        }
    }
}