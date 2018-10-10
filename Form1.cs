using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = project.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.*/
            LoadNewFile();
        }

        /*private void LoadNewFile()
        {
            throw new NotImplementedException();
        }*/

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
       

        private void LoadNewFile()
        {

            /*OpenFileDialog ofd = new OpenFileDialog();

            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = ofd.FileName;
            }*/
  
            /*OpenFileDialog ofd = new OpenFileDialog();
            string PictureFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.InitialDirectory = PictureFolder;
            ofd.Filter = "Pictures|*.jpg;*.bmp;*.png";
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                userSelectedFilePath = ofd.FileName;
            }*/

          OpenFileDialog ofd = new OpenFileDialog();
          string PictureFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
          ofd.InitialDirectory = PictureFolder;
          ofd.Title = "Pick a picture; any picture";
          ofd.CustomPlaces.Add(@"C:\");
          ofd.CustomPlaces.Add(@"C:\Program Files\");
          ofd.CustomPlaces.Add(@"K:\Documents\Pictures\");
          ofd.Multiselect = true;   
          //ofd.Filter = "Pictures|*.jpg; *.bmp; *.png|Documents|*.txt; *.doc; *.log|All|*.*";

         // System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
          /*
            if (dr == DialogResult.OK)
          {
              tbFilePath.Text = ofd.FileName;
               
              //userSelectedFilePath = ofd.FileName;
              foreach (string fileName in ofd.FileNames)
              {
                  userSelectedFilePath += fileName + Environment.NewLine;
              }
          }*/
          if (ofd.ShowDialog() == DialogResult.OK)
          {
             tbFilePath.Text= Path.GetFileName(ofd.FileName);
            //getfilename(ofd.FileName);

              //string[] arr = path.Split('/');
              //string filename = arr[arr.Length - 1];
              //tbFilePath.Text = filename;
          }

           
        }
        


        private void tbFilePath_TextChanged(object sender, EventArgs e)
        {
            //string FilePath = @"C:\Program Files\";
            //string Result = Path.GetFileName(FilePath);//With Extension
            //string Result = userSelectedFilePath;
            //Console.WriteLine("\n" +Result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.Show();
            this.Hide();

        }

    }
}
