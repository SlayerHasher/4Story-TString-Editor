namespace TString_Editor
{
    partial class TString_Editor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TString_Editor));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CopyrightToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.StringTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.StringLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.DonateToolStripMenuItem});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            resources.ApplyResources(this.OpenToolStripMenuItem, "OpenToolStripMenuItem");
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // DonateToolStripMenuItem
            // 
            this.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem";
            resources.ApplyResources(this.DonateToolStripMenuItem, "DonateToolStripMenuItem");
            this.DonateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountToolStripStatusLabel,
            this.TabToolStripStatusLabel,
            this.CopyrightToolStripStatusLabel});
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // CountToolStripStatusLabel
            // 
            this.CountToolStripStatusLabel.Name = "CountToolStripStatusLabel";
            resources.ApplyResources(this.CountToolStripStatusLabel, "CountToolStripStatusLabel");
            // 
            // TabToolStripStatusLabel
            // 
            this.TabToolStripStatusLabel.Name = "TabToolStripStatusLabel";
            resources.ApplyResources(this.TabToolStripStatusLabel, "TabToolStripStatusLabel");
            // 
            // CopyrightToolStripStatusLabel
            // 
            this.CopyrightToolStripStatusLabel.IsLink = true;
            this.CopyrightToolStripStatusLabel.Name = "CopyrightToolStripStatusLabel";
            resources.ApplyResources(this.CopyrightToolStripStatusLabel, "CopyrightToolStripStatusLabel");
            this.CopyrightToolStripStatusLabel.Click += new System.EventHandler(this.CopyrightToolStripStatusLabel_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            // 
            // SearchTextBox
            // 
            resources.ApplyResources(this.SearchTextBox, "SearchTextBox");
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            resources.ApplyResources(this.ListBox, "ListBox");
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            resources.ApplyResources(this.ListBox2, "ListBox2");
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // IDTextBox
            // 
            resources.ApplyResources(this.IDTextBox, "IDTextBox");
            this.IDTextBox.Name = "IDTextBox";
            // 
            // StringTextBox
            // 
            resources.ApplyResources(this.StringTextBox, "StringTextBox");
            this.StringTextBox.Name = "StringTextBox";
            // 
            // IDLabel
            // 
            resources.ApplyResources(this.IDLabel, "IDLabel");
            this.IDLabel.Name = "IDLabel";
            // 
            // StringLabel
            // 
            resources.ApplyResources(this.StringLabel, "StringLabel");
            this.StringLabel.Name = "StringLabel";
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TString_Editor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StringLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.StringTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TString_Editor";
            this.Load += new System.EventHandler(this.TString_Editor_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.ToolStripStatusLabel CountToolStripStatusLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox StringTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label StringLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolStripStatusLabel TabToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CopyrightToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DonateToolStripMenuItem;
    }
}

