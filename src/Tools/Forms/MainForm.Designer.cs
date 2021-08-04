
namespace Tools.Forms
{
    partial class MainForm
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
            this.ItemButton = new System.Windows.Forms.Button();
            this.BuffButton = new System.Windows.Forms.Button();
            this.PacketCleanerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemButton
            // 
            this.ItemButton.AccessibleName = "ItemButton";
            this.ItemButton.Location = new System.Drawing.Point(12, 12);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(75, 23);
            this.ItemButton.TabIndex = 0;
            this.ItemButton.Text = "Item";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // BuffButton
            // 
            this.BuffButton.AccessibleName = "BuffButton";
            this.BuffButton.Location = new System.Drawing.Point(93, 12);
            this.BuffButton.Name = "BuffButton";
            this.BuffButton.Size = new System.Drawing.Size(75, 23);
            this.BuffButton.TabIndex = 1;
            this.BuffButton.Text = "Buff";
            this.BuffButton.UseVisualStyleBackColor = true;
            this.BuffButton.Click += new System.EventHandler(this.BuffButton_Click);
            // 
            // PacketCleanerButton
            // 
            this.PacketCleanerButton.AccessibleName = "PacketCleanerButton";
            this.PacketCleanerButton.Location = new System.Drawing.Point(174, 12);
            this.PacketCleanerButton.Name = "PacketCleanerButton";
            this.PacketCleanerButton.Size = new System.Drawing.Size(97, 23);
            this.PacketCleanerButton.TabIndex = 2;
            this.PacketCleanerButton.Text = "Packet cleaner";
            this.PacketCleanerButton.UseVisualStyleBackColor = true;
            this.PacketCleanerButton.Click += new System.EventHandler(this.PacketCleanerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PacketCleanerButton);
            this.Controls.Add(this.BuffButton);
            this.Controls.Add(this.ItemButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button BuffButton;
        private System.Windows.Forms.Button PacketCleanerButton;
    }
}