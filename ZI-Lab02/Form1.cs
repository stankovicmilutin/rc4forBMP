using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZI_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.FilterIndex = 1;
            d.Filter = "Bitmap files|*.bmp|All Files (*.*)|*.*";

            // Call the ShowDialog method to show the dialog box.
            DialogResult res = d.ShowDialog();

            // Process input if the user clicked OK.
            if (res.ToString() == "OK")
            {
                this.selFileTb.Text = d.FileName.ToString();
            }
        }

        private void cryptBtn_Click(object sender, EventArgs e)
        {   
            // Copy header
            byte[] header = new byte[54];
            List<Byte> body = new List<byte>();
            byte[] temp = new byte[1];


            using (BinaryReader sourceF = new BinaryReader(File.Open(this.selFileTb.Text, FileMode.Open)))
            {
                sourceF.Read(header, 0, header.Length);
                using (BinaryWriter newF = new BinaryWriter(File.Open(this.newFileTb.Text, FileMode.OpenOrCreate)))
                {
                    newF.Write(header, 0, header.Length);
                    int len = 0;
                    while (sourceF.BaseStream.Position != sourceF.BaseStream.Length)
                    {
                        sourceF.Read(temp, 0, 1);
                        body.Add(temp[0]);
                        len++;
                    }
                    byte[] b = body.ToArray();

                    

                    newF.Write(this.Crypt(b), 0, len);
                }
            }
        }

        
        private byte[] Crypt(byte[] input)
        {
            long i = 0;
            long j = 0;
            for (long offset = 0; offset < input.Length; offset++)
            {
                i = (i + 1) % keyLen;
                j = (j + localKey[i]) % keyLen;
                byte temp = localKey[i];
                localKey[i] = localKey[j];
                localKey[j] = temp;
                byte a = input[offset];
                byte b = localKey[(localKey[i] + localKey[j]) % keyLen];
                output[offset] = (byte)((int)a ^ (int)b);
            }

            return output;
        }
        

    }
}
