namespace SaveEditorSwitch
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.openSaveDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Main_Theme_Controller = new MonoFlat.MonoFlat_ThemeContainer();
            this.NotificationBox = new MonoFlat.MonoFlat_NotificationBox();
            this.VersionTag = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Separator1 = new MonoFlat.MonoFlat_Separator();
            this.ExportSaveButton = new MonoFlat.MonoFlat_Button();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.monoFlat_LinkLabel1 = new MonoFlat.MonoFlat_LinkLabel();
            this.monoFlat_SocialButton1 = new MonoFlat.MonoFlat_SocialButton();
            this.monoFlat_Panel1 = new MonoFlat.MonoFlat_Panel();
            this.SaveFileSizeLabel = new MonoFlat.MonoFlat_HeaderLabel();
            this.Checksum_lab = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.ImportSaveButton = new MonoFlat.MonoFlat_Button();
            this.MoneyLab = new MonoFlat.MonoFlat_TextBox();
            this.Main_Theme_Controller.SuspendLayout();
            this.monoFlat_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openSaveDialog
            // 
            this.openSaveDialog.FileName = "openSaveDialog";
            // 
            // Main_Theme_Controller
            // 
            this.Main_Theme_Controller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Main_Theme_Controller.Controls.Add(this.NotificationBox);
            this.Main_Theme_Controller.Controls.Add(this.VersionTag);
            this.Main_Theme_Controller.Controls.Add(this.monoFlat_Separator1);
            this.Main_Theme_Controller.Controls.Add(this.ExportSaveButton);
            this.Main_Theme_Controller.Controls.Add(this.monoFlat_ControlBox1);
            this.Main_Theme_Controller.Controls.Add(this.monoFlat_LinkLabel1);
            this.Main_Theme_Controller.Controls.Add(this.monoFlat_SocialButton1);
            this.Main_Theme_Controller.Controls.Add(this.monoFlat_Panel1);
            this.Main_Theme_Controller.Controls.Add(this.monoFlat_HeaderLabel1);
            this.Main_Theme_Controller.Controls.Add(this.ImportSaveButton);
            this.Main_Theme_Controller.Controls.Add(this.MoneyLab);
            this.Main_Theme_Controller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Theme_Controller.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Main_Theme_Controller.Location = new System.Drawing.Point(0, 0);
            this.Main_Theme_Controller.Name = "Main_Theme_Controller";
            this.Main_Theme_Controller.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.Main_Theme_Controller.RoundCorners = true;
            this.Main_Theme_Controller.Sizable = true;
            this.Main_Theme_Controller.Size = new System.Drawing.Size(738, 427);
            this.Main_Theme_Controller.SmartBounds = true;
            this.Main_Theme_Controller.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Main_Theme_Controller.TabIndex = 6;
            this.Main_Theme_Controller.Text = "           Yu-Gi-Oh! Legacy of the Duelist Save Manager";
            // 
            // NotificationBox
            // 
            this.NotificationBox.BorderCurve = 8;
            this.NotificationBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.NotificationBox.Image = null;
            this.NotificationBox.Location = new System.Drawing.Point(247, 179);
            this.NotificationBox.MinimumSize = new System.Drawing.Size(100, 40);
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Warning;
            this.NotificationBox.RoundCorners = false;
            this.NotificationBox.ShowCloseButton = true;
            this.NotificationBox.Size = new System.Drawing.Size(277, 109);
            this.NotificationBox.TabIndex = 20;
            this.NotificationBox.Text = "This Is A Beta !!!";
            // 
            // VersionTag
            // 
            this.VersionTag.AutoSize = true;
            this.VersionTag.BackColor = System.Drawing.Color.Transparent;
            this.VersionTag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VersionTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.VersionTag.Location = new System.Drawing.Point(686, 378);
            this.VersionTag.Name = "VersionTag";
            this.VersionTag.Size = new System.Drawing.Size(39, 20);
            this.VersionTag.TabIndex = 19;
            this.VersionTag.Text = "1.0.1";
            // 
            // monoFlat_Separator1
            // 
            this.monoFlat_Separator1.Location = new System.Drawing.Point(1, 130);
            this.monoFlat_Separator1.Name = "monoFlat_Separator1";
            this.monoFlat_Separator1.Size = new System.Drawing.Size(737, 18);
            this.monoFlat_Separator1.TabIndex = 18;
            this.monoFlat_Separator1.Text = "monoFlat_Separator1";
            // 
            // ExportSaveButton
            // 
            this.ExportSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportSaveButton.Enabled = false;
            this.ExportSaveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ExportSaveButton.Image = null;
            this.ExportSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportSaveButton.Location = new System.Drawing.Point(580, 83);
            this.ExportSaveButton.Name = "ExportSaveButton";
            this.ExportSaveButton.Size = new System.Drawing.Size(146, 41);
            this.ExportSaveButton.TabIndex = 7;
            this.ExportSaveButton.Text = "Export Save";
            this.ExportSaveButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ExportSaveButton.Click += new System.EventHandler(this.ExportSaveButton_Click);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(626, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 17;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // monoFlat_LinkLabel1
            // 
            this.monoFlat_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.monoFlat_LinkLabel1.AutoSize = true;
            this.monoFlat_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.monoFlat_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_LinkLabel1.Location = new System.Drawing.Point(309, 378);
            this.monoFlat_LinkLabel1.Name = "monoFlat_LinkLabel1";
            this.monoFlat_LinkLabel1.Size = new System.Drawing.Size(124, 20);
            this.monoFlat_LinkLabel1.TabIndex = 16;
            this.monoFlat_LinkLabel1.TabStop = true;
            this.monoFlat_LinkLabel1.Text = "Created By KranK";
            this.monoFlat_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.monoFlat_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.monoFlat_LinkLabel1_LinkClicked);
            // 
            // monoFlat_SocialButton1
            // 
            this.monoFlat_SocialButton1.Image = global::Yu_Gi_Oh_Legacy_of_the_Duelist_Save_Manager.Properties.Resources.yugioh_4;
            this.monoFlat_SocialButton1.Location = new System.Drawing.Point(3, 3);
            this.monoFlat_SocialButton1.Name = "monoFlat_SocialButton1";
            this.monoFlat_SocialButton1.Size = new System.Drawing.Size(54, 54);
            this.monoFlat_SocialButton1.TabIndex = 13;
            this.monoFlat_SocialButton1.Text = "monoFlat_SocialButton1";
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel1.Controls.Add(this.SaveFileSizeLabel);
            this.monoFlat_Panel1.Controls.Add(this.Checksum_lab);
            this.monoFlat_Panel1.Location = new System.Drawing.Point(0, 401);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(738, 26);
            this.monoFlat_Panel1.TabIndex = 10;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // SaveFileSizeLabel
            // 
            this.SaveFileSizeLabel.AutoSize = true;
            this.SaveFileSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileSizeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SaveFileSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveFileSizeLabel.Location = new System.Drawing.Point(481, 0);
            this.SaveFileSizeLabel.Name = "SaveFileSizeLabel";
            this.SaveFileSizeLabel.Size = new System.Drawing.Size(138, 25);
            this.SaveFileSizeLabel.TabIndex = 10;
            this.SaveFileSizeLabel.Text = "Save File Size: ";
            // 
            // Checksum_lab
            // 
            this.Checksum_lab.AutoSize = true;
            this.Checksum_lab.BackColor = System.Drawing.Color.Transparent;
            this.Checksum_lab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Checksum_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Checksum_lab.Location = new System.Drawing.Point(8, 0);
            this.Checksum_lab.Name = "Checksum_lab";
            this.Checksum_lab.Size = new System.Drawing.Size(112, 25);
            this.Checksum_lab.TabIndex = 9;
            this.Checksum_lab.Text = "Checksum: ";
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(43, 148);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(79, 25);
            this.monoFlat_HeaderLabel1.TabIndex = 8;
            this.monoFlat_HeaderLabel1.Text = "Money:";
            // 
            // ImportSaveButton
            // 
            this.ImportSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.ImportSaveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImportSaveButton.Image = null;
            this.ImportSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportSaveButton.Location = new System.Drawing.Point(13, 83);
            this.ImportSaveButton.Name = "ImportSaveButton";
            this.ImportSaveButton.Size = new System.Drawing.Size(146, 41);
            this.ImportSaveButton.TabIndex = 6;
            this.ImportSaveButton.Text = "Import Save";
            this.ImportSaveButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ImportSaveButton.Click += new System.EventHandler(this.ImportSaveButton_Click);
            // 
            // MoneyLab
            // 
            this.MoneyLab.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLab.Enabled = false;
            this.MoneyLab.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MoneyLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.MoneyLab.Image = null;
            this.MoneyLab.Location = new System.Drawing.Point(20, 179);
            this.MoneyLab.MaxLength = 9;
            this.MoneyLab.Multiline = false;
            this.MoneyLab.Name = "MoneyLab";
            this.MoneyLab.ReadOnly = false;
            this.MoneyLab.Size = new System.Drawing.Size(135, 46);
            this.MoneyLab.TabIndex = 4;
            this.MoneyLab.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.MoneyLab.UseSystemPasswordChar = false;
            this.MoneyLab.TextChanged += new System.EventHandler(this.MoneyLab_TextChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.Main_Theme_Controller);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "           Yu-Gi-Oh! Legacy of the Duelist Save Manager";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Main_Theme_Controller.ResumeLayout(false);
            this.Main_Theme_Controller.PerformLayout();
            this.monoFlat_Panel1.ResumeLayout(false);
            this.monoFlat_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openSaveDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MonoFlat.MonoFlat_ThemeContainer Main_Theme_Controller;
        private MonoFlat.MonoFlat_TextBox MoneyLab;
        private MonoFlat.MonoFlat_Button ImportSaveButton;
        private MonoFlat.MonoFlat_HeaderLabel Checksum_lab;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat.MonoFlat_Button ExportSaveButton;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel1;
        private MonoFlat.MonoFlat_SocialButton monoFlat_SocialButton1;
        private MonoFlat.MonoFlat_HeaderLabel SaveFileSizeLabel;
        private MonoFlat.MonoFlat_LinkLabel monoFlat_LinkLabel1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_NotificationBox NotificationBox;
        private MonoFlat.MonoFlat_Label VersionTag;
        private MonoFlat.MonoFlat_Separator monoFlat_Separator1;
    }
}

