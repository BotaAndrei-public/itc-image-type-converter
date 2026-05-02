using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ITC___Image_Type_Converter
{
    public partial class Form1 : Form
    {

        string selectFormat = "";
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private void SelectFormat( Button selectedButton, string format) 
        {
            Button[] buttons = { btn_JPG, btn_PNG, btn_TIFF, btn_GIF, btn_BMP, btn_ICO };
            foreach (Button button in buttons) 
            {
                button.BackColor = Color.White;
                button.ForeColor = SystemColors.ControlDarkDark;
            }

            selectedButton.BackColor = SystemColors.Highlight;
            selectedButton.ForeColor = SystemColors.Info;

            selectFormat = format;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "All |*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";

            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                // 2. Luăm calea fișierului ales și o punem în TextBox
                // txtPath este numele TextBox-ului tău
                textPath.Text = dlgOpenFile.FileName;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (dlgOpenFolder.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = dlgOpenFolder.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textPathOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            if (dlgOpenFolder.ShowDialog() == DialogResult.OK)
            {
                textPathOut.Text = dlgOpenFolder.SelectedPath;
            }
        }

        private void btnConvertNow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPath.Text) || string.IsNullOrEmpty(textPathOut.Text) || string.IsNullOrEmpty(selectFormat))
            {
                MessageBox.Show("Please select source, destination, and a target format!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            try
            {
                string path = textPath.Text;
                string path_out = textPathOut.Text;

                if (File.Exists(path))
                {
                    ConvertSingleImage(path, path_out, selectFormat);
                }
                else if (Directory.Exists(path))
                {
                    string[] extensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };


                    var files = Directory.GetFiles(path).Where(f => extensions.Contains(Path.GetExtension(f).ToLower()));

                    foreach (var f in files)
                    {
                        ConvertSingleImage(f, path_out, selectFormat);
                    }

                   
                }
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000, "Done!", "Success! Files converted.", ToolTipIcon.Info);


            }
            catch (Exception E)
            {
                MessageBox.Show("An error occurred: " + E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ConvertSingleImage(string inputPath, string outputFolder, string format)
        {
            using (Image img = Image.FromFile(inputPath))
            {
                string fileName = Path.GetFileNameWithoutExtension(inputPath);
                string outputPath = Path.Combine(outputFolder, fileName + "." + format.ToLower());

                //Default Type
                ImageFormat imgFormat = ImageFormat.Jpeg;

                switch (format.ToUpper())
                {
                    case "PNG": imgFormat = ImageFormat.Png; break;
                    case "BMP": imgFormat = ImageFormat.Bmp; break;
                    case "GIF": imgFormat = ImageFormat.Gif; break;
                    case "TIFF": imgFormat = ImageFormat.Tiff; break;
                    case "JPG": imgFormat = ImageFormat.Jpeg; break;
                    case "ICO":
                        using (Bitmap bmp = new Bitmap(img))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                
                                bmp.Save(ms, ImageFormat.Png);
                                byte[] pngData = ms.ToArray();

                                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                                {
                                    // Header ICO (standard format)
                                    fs.Write(new byte[] { 0, 0, 1, 0, 1, 0 }, 0, 6);

                                    // DIM (maxim 256x256)
                                    fs.WriteByte((byte)Math.Min(bmp.Width, 255));
                                    fs.WriteByte((byte)Math.Min(bmp.Height, 255));

                                    fs.Write(new byte[] { 0, 0, 1, 0, 32, 0 }, 0, 6); // 32 bits per pixel (Alpha channel)

                                    // Size data PNG
                                    fs.Write(BitConverter.GetBytes(pngData.Length), 0, 4);

                                    // Offset (22 bytes header)
                                    fs.Write(BitConverter.GetBytes(22), 0, 4);

                                    
                                    fs.Write(pngData, 0, pngData.Length);
                                }
                            }
                        }
                        return; 
                }
                img.Save(outputPath, imgFormat);
            }
        }


        private void btn_JPG_Click(object sender, EventArgs e)
        {
            SelectFormat(btn_JPG, "JPG");
        }

        private void btn_PNG_Click(object sender, EventArgs e)
        {
            SelectFormat(btn_PNG, "PNG");
        }

        private void btn_BMP_Click(object sender, EventArgs e)
        {
            SelectFormat(btn_BMP, "BMP");
        }

        private void btn_GIF_Click(object sender, EventArgs e)
        {
            SelectFormat(btn_GIF, "GIF");
        }

        private void btn_TIFF_Click(object sender, EventArgs e)
        {
            SelectFormat(btn_TIFF, "TIFF");
        }

        private void btn_ICO_Click(object sender, EventArgs e)
        {
            SelectFormat(btn_ICO, "ICO");
        }
    }
}
