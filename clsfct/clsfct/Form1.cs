using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace clsfct
{
    public partial class Form1 : Form
    {
        List<String> filePaths = new List<string>();
        List<String[]> tags = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("-------------------------------------------------");
        }
        public void OpenFiles()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Текстовые файлы (*.txt/*.pdf/*.docx/*.doc/*.html)|*.txt;*.pdf;*.docx;*.doc;*.html";
                openFileDialog.FilterIndex = 2;
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in openFileDialog.FileNames)
                    {
                        if (!listBox1.Items.Contains(file))
                        {
                            filePaths.Add(file);
                        }
                    }
                    /*foreach (String file in openFileDialog.FileNames)
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        Debug.WriteLine(filePath, fileContent);
                    }*/
                    updateListBox();
                }
            }
        }

        public void CloseApp()
        {
            System.Windows.Forms.Application.Exit();
        }
        
        public void TagsOpenForm()
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        public void BeginRenameWork()
        {
            progressBar1.Visible = true;
            button1.Visible = false;
            progressBar1.Refresh();
            progressBar1.Value = 16;
            String resultfolder = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\Классифицированные статьи";
            if (!Directory.Exists(resultfolder))
            {
                Directory.CreateDirectory(resultfolder);
            }
            using (StreamReader reader = new StreamReader("config.txt"))
            {
                var line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("["))
                    {
                        tags.Add(line.Split("="));
                    }
                }
            }
            progressBar1.Value = 33;
            foreach (String filepath in listBox1.Items)
            {
                if (filepath.Split(".").Last() == "pdf")
                {
                    var documenttag = "";
                    String pdftext = "";
                    StringBuilder text = new StringBuilder();
                    using (PdfReader reader = new PdfReader(filepath))
                    {
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }
                    }
                    pdftext = text.ToString();
                    foreach (String[] array in tags)
                    {
                        documenttag = array[0];
                        Debug.WriteLine("documenttag: " + documenttag);
                        string[] tmp = array[1].Split(",");
                        foreach (String word in tmp)
                        {
                            if (pdftext.Contains(word))
                            {
                                try
                                {
                                    File.Copy(filepath, resultfolder + "\\" + documenttag + filepath.Split("\\").Last());
                                    Debug.WriteLine("Copied: " + filepath.Split("\\").Last() + " with documenttag:" + documenttag);
                                }
                                catch { }
                            }
                        }
                    }
                }
                else if (filepath.Split(".").Last() == "docx")
                {
                    var documenttag = "";
                    String docxtext = "";
                    using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filepath, false))
                    {  
                        Body body = wordDocument.MainDocumentPart.Document.Body;
                        docxtext = body.InnerText.ToString();
                    }
                    foreach (String[] array in tags)
                    {
                        documenttag = array[0];
                        Debug.WriteLine("documenttag: " + documenttag);
                        string[] tmp = array[1].Split(",");
                        foreach (String word in tmp)
                        {
                            if (docxtext.Contains(word))
                            {
                                try
                                {
                                    File.Copy(filepath, resultfolder + "\\" + documenttag + filepath.Split("\\").Last());
                                    Debug.WriteLine("Copied: " + filepath.Split("\\").Last() + " with documenttag:" + documenttag);
                                }
                                catch { }
                            }
                        }
                    }
                }
                else
                {
                    var documenttag = "";
                    var line = "";
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            foreach (String[] array in tags)
                            {
                                documenttag = array[0];
                                Debug.WriteLine("documenttag: " + documenttag);
                                string[] tmp = array[1].Split(",");
                                foreach (String word in tmp)
                                {
                                    if (line.Contains(word))
                                    {
                                        try
                                        {
                                            File.Copy(filepath, resultfolder + "\\" + documenttag + filepath.Split("\\").Last());
                                            Debug.WriteLine("Copied: " + filepath.Split("\\").Last() + " with documenttag:" + documenttag);
                                        }
                                        catch { }
                                    }
                                }
                                if (progressBar1.Value < 50)
                                {
                                    progressBar1.Value = 50;
                                }

                            }
                            if (progressBar1.Value < 66)
                            {
                                progressBar1.Value = 66;
                            }
                        }
                        if (progressBar1.Value < 83)
                        {
                            progressBar1.Value = 83;
                        }
                    }
                }
            }
            progressBar1.Visible = false;
            button1.Visible = true;
            MessageBox.Show("Файлы классифицированы и скопированы в: "+resultfolder,"Готово");
        }
    }
}
