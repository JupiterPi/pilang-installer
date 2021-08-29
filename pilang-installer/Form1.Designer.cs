using System;
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

        private Strings strings = new EnglishStrings();

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
            startButton.Text = strings.BTN_INSTALL;
            startButton.Location = new System.Drawing.Point(12, 12);
            startButton.Size = new System.Drawing.Size(150, 60);
            startButton.Click += new EventHandler(startButton_Click);

            statusLabel = new Label();
            statusLabel.Text = strings.WELCOME;
            /*statusLabel.Text = strings.STEP_DIRECTORY;
            statusLabel.Text = strings.STEP_REGISTRY;
            statusLabel.Text = strings.FINISHED;*/
            statusLabel.Location = new System.Drawing.Point(12+ 150 +12, 12);
            statusLabel.Size = new System.Drawing.Size(400, 60);

            pathChangeButton = new Button();
            pathChangeButton.Text = strings.BTN_CHANGE;
            pathChangeButton.Location = new System.Drawing.Point(12, 12+ 60 +12);
            pathChangeButton.Size = new System.Drawing.Size(75, 30);
            pathChangeButton.Click += new EventHandler(pathChangeButton_Click);

            pathLabel = new Label();
            pathLabel.Text = String.Format(strings.INSTALLATION_PATH, installationPath);
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

        private void refreshInstallationPath()
        {
            pathLabel.Text = String.Format(strings.INSTALLATION_PATH, installationPath);
        }
    }
}