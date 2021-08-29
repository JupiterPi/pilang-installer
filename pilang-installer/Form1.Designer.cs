using System.Windows.Forms;

namespace pilang_installer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private Button startButton;
        private Label statusLabel;
        private Button pathChangeButton;
        private Label pathLabel;
        
        private void InitializeComponent()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            startButton = new Button();
            startButton.Text = "Install";
            startButton.Location = new System.Drawing.Point(12, 12);
            startButton.Size = new System.Drawing.Size(150, 60);

            statusLabel = new Label();
            statusLabel.Text = "Press 'Install' to install pilang on this machine. You can change the installation path below.";
            /*statusLabel.Text = "Creating and filling runtime directory...";
            statusLabel.Text = "Referencing runtime in system registry...";
            statusLabel.Text = "Finished installing successfully! For the changes to take effect, (re)open all running terminal instances. You can close this window now.";*/
            statusLabel.Location = new System.Drawing.Point(12+ 150 +12, 12);
            statusLabel.Size = new System.Drawing.Size(400, 60);

            pathChangeButton = new Button();
            pathChangeButton.Text = "(change)";
            pathChangeButton.Location = new System.Drawing.Point(12, 12+ 60 +12);
            pathChangeButton.Size = new System.Drawing.Size(75, 30);

            pathLabel = new Label();
            pathLabel.Text = "Installation path: C:\\Users\\<user>\\pilang";
            pathLabel.Location = new System.Drawing.Point(12+ 75 +12, 12+ 60 +12 +4);
            pathLabel.Size = new System.Drawing.Size(475, 30);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(12+ 150 +12+ 400 +12, 12+ 60 +12+ 30 +12);
            this.Text = "pilang Setup Wizard";
            
            this.Controls.Add(startButton);
            this.Controls.Add(statusLabel);
            this.Controls.Add(pathChangeButton);
            this.Controls.Add(pathLabel);
        }
    }
}