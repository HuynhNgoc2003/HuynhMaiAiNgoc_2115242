﻿
using System;
using System.Windows.Forms;

namespace BaiThucHanhThietKeForm
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.họVàTênCủaSinhViên = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họVàTênCủaSinhViên});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // họVàTênCủaSinhViên
            // 
            this.họVàTênCủaSinhViên.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmiBai1,
            this.tsmiBai2,
            this.tsmiBai3,
            this.tsmiBai4});
            this.họVàTênCủaSinhViên.Name = "họVàTênCủaSinhViên";
            this.họVàTênCủaSinhViên.Size = new System.Drawing.Size(124, 20);
            this.họVàTênCủaSinhViên.Text = "Huỳnh Mai Ái Ngọc";
            // 
            // stmiBai1
            // 
            this.stmiBai1.Image = ((System.Drawing.Image)(resources.GetObject("stmiBai1.Image")));
            this.stmiBai1.Name = "stmiBai1";
            this.stmiBai1.Size = new System.Drawing.Size(180, 22);
            this.stmiBai1.Text = "Bài 1";
            this.stmiBai1.Click += new System.EventHandler(this.stmiBai1_Click);
            // 
            // tsmiBai2
            // 
            this.tsmiBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai2.Image")));
            this.tsmiBai2.Name = "tsmiBai2";
            this.tsmiBai2.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai2.Text = "Bài 2";
            this.tsmiBai2.Click += new System.EventHandler(this.tsmiBai2_Click);
            // 
            // tsmiBai3
            // 
            this.tsmiBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai3.Image")));
            this.tsmiBai3.Name = "tsmiBai3";
            this.tsmiBai3.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai3.Text = "Bài 3";
            this.tsmiBai3.Click += new System.EventHandler(this.tsmiBai3_Click);
            // 
            // tsmiBai4
            // 
            this.tsmiBai4.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai4.Image")));
            this.tsmiBai4.Name = "tsmiBai4";
            this.tsmiBai4.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai4.Text = "Bài 4";
            this.tsmiBai4.Click += new System.EventHandler(this.tsmiBai4_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem họVàTênCủaSinhViên;
        private System.Windows.Forms.ToolStripMenuItem stmiBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai2;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai3;
        private ToolStripMenuItem tsmiBai4;

        public ToolStripItemClickedEventHandler menuStrip1_ItemClicked { get; private set; }
    }
}

