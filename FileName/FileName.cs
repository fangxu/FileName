using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;



namespace FileName
{
    public partial class FileName : Form
    {
        private string path = null;
        public FileName()
        {
            InitializeComponent();
            listViewFiles.Columns.Add("File", -2, HorizontalAlignment.Left);
            listViewFiles.Columns.Add("Preview", -2, HorizontalAlignment.Left);
        }

        private void FileName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void FileName_DragDrop(object sender, DragEventArgs e)
        {
            listViewFiles.Items.Clear();
            string[] temp = (string[])e.Data.GetData(DataFormats.FileDrop);
            path = temp[0].Substring(0, temp[0].LastIndexOf("\\") + 1);
            textBolxPath.Text = path;
            //DirectoryInfo dir = new DirectoryInfo(path);
            //string[] files = Directory.GetFiles(path);
            //FileInfo[] files = new DirectoryInfo(path).GetFiles();
            //Array.Sort(files);


            //listViewFiles.Items.Add(new ListViewItem(new string[] { "fefe", "fefwwwww" }));
            foreach (string s in temp)
            {
                string name = s.Substring(s.LastIndexOf("\\") + 1, s.Length - s.LastIndexOf("\\") - 1);
                listViewFiles.Items.Add(new ListViewItem(new string[] { name, name }));
            }

            listViewFiles.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewFiles.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewFiles.Sort();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            string patternNew = textBoxNewName.Text;
            //string patternOld = textBoxOldName.Text;
            string replace = textBoxReplace.Text;
            //Regex rOld = new Regex(patternOld, RegexOptions.Compiled);
            Regex rNew = new Regex(patternNew, RegexOptions.Compiled);

            try
            {
                for (int i = 0; i < listViewFiles.Items.Count; i++)
                {
                    //if (rOld.Match(listViewFiles.Items[i].Text).Success)
                    //{
                    listViewFiles.Items[i].SubItems[1].Text = rNew.Replace(listViewFiles.Items[i].Text, replace);
                    //}
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string oldName = null;
            string newName = null;
            EnableUI(false);
            for (int i = 0; i < listViewFiles.Items.Count; i++)
            {
                oldName = path + listViewFiles.Items[i].Text;
                newName = path + listViewFiles.Items[i].SubItems[1].Text;

                try
                {
                    File.Move(oldName, newName);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            EnableUI(true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxTop.Checked;
        }

        private void EnableUI(bool en)
        {
            buttonApply.Enabled = en;
            buttonPreview.Enabled = en;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
