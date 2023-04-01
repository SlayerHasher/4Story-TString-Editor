namespace TString_Editor
{
    partial class Donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donate));
            this.RequisitesLabel = new System.Windows.Forms.Label();
            this.USDLabel = new System.Windows.Forms.Label();
            this.USDRequisiteLabel = new System.Windows.Forms.Label();
            this.EURRequisiteLabel = new System.Windows.Forms.Label();
            this.EURLabel = new System.Windows.Forms.Label();
            this.EURPictureBox = new System.Windows.Forms.PictureBox();
            this.USDPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EURPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USDPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RequisitesLabel
            // 
            this.RequisitesLabel.AutoSize = true;
            this.RequisitesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequisitesLabel.Location = new System.Drawing.Point(538, 9);
            this.RequisitesLabel.Name = "RequisitesLabel";
            this.RequisitesLabel.Size = new System.Drawing.Size(247, 25);
            this.RequisitesLabel.TabIndex = 0;
            this.RequisitesLabel.Text = "My requisites Tinkoff Bank:";
            // 
            // USDLabel
            // 
            this.USDLabel.AutoSize = true;
            this.USDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.USDLabel.Location = new System.Drawing.Point(289, 54);
            this.USDLabel.Name = "USDLabel";
            this.USDLabel.Size = new System.Drawing.Size(50, 20);
            this.USDLabel.TabIndex = 1;
            this.USDLabel.Text = "USD:";
            // 
            // USDRequisiteLabel
            // 
            this.USDRequisiteLabel.AutoSize = true;
            this.USDRequisiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.USDRequisiteLabel.Location = new System.Drawing.Point(183, 74);
            this.USDRequisiteLabel.Name = "USDRequisiteLabel";
            this.USDRequisiteLabel.Size = new System.Drawing.Size(266, 20);
            this.USDRequisiteLabel.TabIndex = 4;
            this.USDRequisiteLabel.Text = "MasterCard: 5536 9141 9584 9561";
            // 
            // EURRequisiteLabel
            // 
            this.EURRequisiteLabel.AutoSize = true;
            this.EURRequisiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EURRequisiteLabel.Location = new System.Drawing.Point(862, 74);
            this.EURRequisiteLabel.Name = "EURRequisiteLabel";
            this.EURRequisiteLabel.Size = new System.Drawing.Size(266, 20);
            this.EURRequisiteLabel.TabIndex = 6;
            this.EURRequisiteLabel.Text = "MasterCard: 5536 9141 9855 9589";
            // 
            // EURLabel
            // 
            this.EURLabel.AutoSize = true;
            this.EURLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EURLabel.Location = new System.Drawing.Point(970, 54);
            this.EURLabel.Name = "EURLabel";
            this.EURLabel.Size = new System.Drawing.Size(49, 20);
            this.EURLabel.TabIndex = 5;
            this.EURLabel.Text = "EUR:";
            // 
            // EURPictureBox
            // 
            this.EURPictureBox.Image = global::TString_Editor.Properties.Resources.EUR;
            this.EURPictureBox.Location = new System.Drawing.Point(667, 97);
            this.EURPictureBox.Name = "EURPictureBox";
            this.EURPictureBox.Size = new System.Drawing.Size(649, 596);
            this.EURPictureBox.TabIndex = 3;
            this.EURPictureBox.TabStop = false;
            // 
            // USDPictureBox
            // 
            this.USDPictureBox.Image = global::TString_Editor.Properties.Resources.USD;
            this.USDPictureBox.Location = new System.Drawing.Point(12, 97);
            this.USDPictureBox.Name = "USDPictureBox";
            this.USDPictureBox.Size = new System.Drawing.Size(649, 596);
            this.USDPictureBox.TabIndex = 2;
            this.USDPictureBox.TabStop = false;
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 705);
            this.Controls.Add(this.EURRequisiteLabel);
            this.Controls.Add(this.EURLabel);
            this.Controls.Add(this.USDRequisiteLabel);
            this.Controls.Add(this.EURPictureBox);
            this.Controls.Add(this.USDPictureBox);
            this.Controls.Add(this.USDLabel);
            this.Controls.Add(this.RequisitesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Donate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donate";
            ((System.ComponentModel.ISupportInitialize)(this.EURPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USDPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RequisitesLabel;
        private System.Windows.Forms.Label USDLabel;
        private System.Windows.Forms.PictureBox USDPictureBox;
        private System.Windows.Forms.PictureBox EURPictureBox;
        private System.Windows.Forms.Label USDRequisiteLabel;
        private System.Windows.Forms.Label EURRequisiteLabel;
        private System.Windows.Forms.Label EURLabel;
    }
}