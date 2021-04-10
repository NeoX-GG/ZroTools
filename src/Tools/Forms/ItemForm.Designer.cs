
namespace Tools.Forms
{
    partial class ItemForm
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
            this.VnumComboBox = new System.Windows.Forms.ComboBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ValuesTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RegionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VnumComboBox
            // 
            this.VnumComboBox.FormattingEnabled = true;
            this.VnumComboBox.Location = new System.Drawing.Point(12, 12);
            this.VnumComboBox.Name = "VnumComboBox";
            this.VnumComboBox.Size = new System.Drawing.Size(121, 23);
            this.VnumComboBox.TabIndex = 0;
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(139, 12);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(526, 23);
            this.NameComboBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ValuesTxtBox
            // 
            this.ValuesTxtBox.Location = new System.Drawing.Point(617, 40);
            this.ValuesTxtBox.MaxLength = 2147483647;
            this.ValuesTxtBox.Multiline = true;
            this.ValuesTxtBox.Name = "ValuesTxtBox";
            this.ValuesTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValuesTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ValuesTxtBox.Size = new System.Drawing.Size(170, 398);
            this.ValuesTxtBox.TabIndex = 3;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(12, 40);
            this.DescriptionTxtBox.MaxLength = 2147483647;
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTxtBox.Size = new System.Drawing.Size(599, 342);
            this.DescriptionTxtBox.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(510, 402);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RegionComboBox
            // 
            this.RegionComboBox.FormattingEnabled = true;
            this.RegionComboBox.Location = new System.Drawing.Point(671, 12);
            this.RegionComboBox.Name = "RegionComboBox";
            this.RegionComboBox.Size = new System.Drawing.Size(116, 23);
            this.RegionComboBox.TabIndex = 7;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegionComboBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.ValuesTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.VnumComboBox);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VnumComboBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ValuesTxtBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox RegionComboBox;
    }
}