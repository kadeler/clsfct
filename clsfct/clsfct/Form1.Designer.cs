
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace clsfct
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьКлючевыеСловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьФайлИзСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.выбратьToolStripMenuItem.Text = "Выбрать...";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.chooseFileClickEvent);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitClickEvent);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настроитьКлючевыеСловаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настроитьКлючевыеСловаToolStripMenuItem
            // 
            this.настроитьКлючевыеСловаToolStripMenuItem.Name = "настроитьКлючевыеСловаToolStripMenuItem";
            this.настроитьКлючевыеСловаToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.настроитьКлючевыеСловаToolStripMenuItem.Text = "Настроить ключевые слова";
            this.настроитьКлючевыеСловаToolStripMenuItem.Click += new System.EventHandler(this.tagsClickEvent);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 453);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(312, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Переименовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.renameClickEvent);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 409);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listRightClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьФайлИзСпискаToolStripMenuItem,
            this.очиститьСписокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 70);
            // 
            // удалитьФайлИзСпискаToolStripMenuItem
            // 
            this.удалитьФайлИзСпискаToolStripMenuItem.Name = "удалитьФайлИзСпискаToolStripMenuItem";
            this.удалитьФайлИзСпискаToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.удалитьФайлИзСпискаToolStripMenuItem.Text = "Удалить файл из списка";
            this.удалитьФайлИзСпискаToolStripMenuItem.Click += new System.EventHandler(this.eraseItemClickEvent);
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.очиститьСписокToolStripMenuItem.Text = "Очистить список";
            this.очиститьСписокToolStripMenuItem.Click += new System.EventHandler(this.clearListClickEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 488);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Классификатор новостных статей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chooseFileClickEvent(object sender, System.EventArgs e)
        {
            OpenFiles();
        }

        private void exitClickEvent(object sender, System.EventArgs e)
        {
            CloseApp();
        }

        private void tagsClickEvent(object sender, System.EventArgs e)
        {
            TagsOpenForm();
        }

        private void renameClickEvent(object sender, System.EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Вы не выбрали файлы для классификации", "Ошибка");
            }
            else
            {
            BeginRenameWork();
            }
        }

        private void listRightClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
                if (listBox1.SelectedIndex != -1)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void updateListBox()
        {
            foreach (string path in filePaths)
            {
                this.listBox1.Items.AddRange(new object[] { path });
            }
            filePaths.Clear();
        }

        private void eraseItemClickEvent(object sender, System.EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void clearListClickEvent(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
        }
        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьКлючевыеСловаToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьФайлИзСпискаToolStripMenuItem;
        private ToolStripMenuItem очиститьСписокToolStripMenuItem;
    }
}

