﻿namespace GAMECOTUONG
{
    partial class frmMenu
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
            this.btExit = new System.Windows.Forms.Button();
            this.btOption = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.Control;
            this.btExit.BackgroundImage = global::GAMECOTUONG.Properties.Resources.Exit;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Location = new System.Drawing.Point(275, 105);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(40, 40);
            this.btExit.TabIndex = 10;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            this.btExit.MouseHover += new System.EventHandler(this.btExit_MouseHover);
            // 
            // btOption
            // 
            this.btOption.BackgroundImage = global::GAMECOTUONG.Properties.Resources.Options;
            this.btOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOption.FlatAppearance.BorderSize = 0;
            this.btOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOption.Location = new System.Drawing.Point(229, 105);
            this.btOption.Name = "btOption";
            this.btOption.Size = new System.Drawing.Size(40, 40);
            this.btOption.TabIndex = 9;
            this.btOption.UseVisualStyleBackColor = true;
            this.btOption.MouseHover += new System.EventHandler(this.btOption_MouseHover);
            // 
            // btSave
            // 
            this.btSave.BackgroundImage = global::GAMECOTUONG.Properties.Resources.Save;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(183, 105);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(40, 40);
            this.btSave.TabIndex = 8;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.MouseHover += new System.EventHandler(this.btSave_MouseHover);
            // 
            // btOpen
            // 
            this.btOpen.BackgroundImage = global::GAMECOTUONG.Properties.Resources.Open;
            this.btOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Location = new System.Drawing.Point(137, 105);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(40, 40);
            this.btOpen.TabIndex = 7;
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.MouseHover += new System.EventHandler(this.btOpen_MouseHover);
            // 
            // btNew
            // 
            this.btNew.BackgroundImage = global::GAMECOTUONG.Properties.Resources.Newgame;
            this.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNew.FlatAppearance.BorderSize = 0;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNew.Location = new System.Drawing.Point(91, 105);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(40, 40);
            this.btNew.TabIndex = 6;
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            this.btNew.MouseHover += new System.EventHandler(this.btNew_MouseHover);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(162, 187);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Trở về";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("VNI-Souvir", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.Maroon;
            this.lbMenu.Location = new System.Drawing.Point(136, 33);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(144, 55);
            this.lbMenu.TabIndex = 12;
            this.lbMenu.Text = "MENU";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 251);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btOption);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btNew);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btOption;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbMenu;
    }
}