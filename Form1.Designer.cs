namespace ITC___Image_Type_Converter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            btnSelectFile = new Button();
            btnSelectFolder = new Button();
            label2 = new Label();
            dlgOpenFile = new OpenFileDialog();
            dlgOpenFolder = new FolderBrowserDialog();
            pathTxt = new Label();
            textPath = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textPathOut = new TextBox();
            btnBrowseOut = new Button();
            btnConvertNow = new Button();
            label5 = new Label();
            btn_JPG = new Button();
            btn_PNG = new Button();
            btn_BMP = new Button();
            btn_GIF = new Button();
            btn_TIFF = new Button();
            btn_ICO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "Image File Converter";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Help;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Supported Formats: JPG, PNG, BMP, GIF, TIFF.");
            pictureBox1.Click += pictureBox1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(25, 105);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(85, 30);
            btnSelectFile.TabIndex = 2;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(116, 105);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(85, 30);
            btnSelectFolder.TabIndex = 3;
            btnSelectFolder.Text = "Select Folder\r\n";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(25, 50);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 4;
            label2.Text = "Select source:";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            // 
            // pathTxt
            // 
            pathTxt.AutoSize = true;
            pathTxt.Location = new Point(25, 80);
            pathTxt.Name = "pathTxt";
            pathTxt.Size = new Size(40, 15);
            pathTxt.TabIndex = 5;
            pathTxt.Text = "Path : ";
            // 
            // textPath
            // 
            textPath.Location = new Point(60, 75);
            textPath.Name = "textPath";
            textPath.Size = new Size(400, 23);
            textPath.TabIndex = 6;
            textPath.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 145);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 7;
            label3.Text = "Select destination:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 175);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Save to:";
            // 
            // textPathOut
            // 
            textPathOut.Location = new Point(72, 170);
            textPathOut.Name = "textPathOut";
            textPathOut.Size = new Size(388, 23);
            textPathOut.TabIndex = 9;
            textPathOut.TextChanged += textPathOut_TextChanged;
            // 
            // btnBrowseOut
            // 
            btnBrowseOut.Location = new Point(25, 200);
            btnBrowseOut.Name = "btnBrowseOut";
            btnBrowseOut.Size = new Size(85, 30);
            btnBrowseOut.TabIndex = 10;
            btnBrowseOut.Text = "Select Folder";
            btnBrowseOut.UseVisualStyleBackColor = true;
            btnBrowseOut.Click += btnBrowseOut_Click;
            // 
            // btnConvertNow
            // 
            btnConvertNow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConvertNow.BackColor = SystemColors.Highlight;
            btnConvertNow.Cursor = Cursors.Hand;
            btnConvertNow.FlatAppearance.BorderColor = Color.Black;
            btnConvertNow.FlatAppearance.MouseDownBackColor = Color.Black;
            btnConvertNow.FlatAppearance.MouseOverBackColor = Color.Black;
            btnConvertNow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertNow.ForeColor = SystemColors.Info;
            btnConvertNow.Location = new Point(25, 400);
            btnConvertNow.Name = "btnConvertNow";
            btnConvertNow.Size = new Size(435, 30);
            btnConvertNow.TabIndex = 11;
            btnConvertNow.Text = "CONVERT NOW";
            btnConvertNow.UseVisualStyleBackColor = false;
            btnConvertNow.Click += btnConvertNow_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 245);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 12;
            label5.Text = "Convert to:";
            // 
            // btn_JPG
            // 
            btn_JPG.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_JPG.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_JPG.ForeColor = SystemColors.ControlDarkDark;
            btn_JPG.Location = new Point(25, 275);
            btn_JPG.Name = "btn_JPG";
            btn_JPG.Size = new Size(80, 50);
            btn_JPG.TabIndex = 13;
            btn_JPG.Text = "JPG";
            btn_JPG.UseVisualStyleBackColor = true;
            btn_JPG.Click += btn_JPG_Click;
            // 
            // btn_PNG
            // 
            btn_PNG.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_PNG.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PNG.ForeColor = SystemColors.ControlDarkDark;
            btn_PNG.Location = new Point(111, 275);
            btn_PNG.Name = "btn_PNG";
            btn_PNG.Size = new Size(80, 50);
            btn_PNG.TabIndex = 14;
            btn_PNG.Text = "PNG";
            btn_PNG.UseVisualStyleBackColor = true;
            btn_PNG.Click += btn_PNG_Click;
            // 
            // btn_BMP
            // 
            btn_BMP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_BMP.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BMP.ForeColor = SystemColors.ControlDarkDark;
            btn_BMP.Location = new Point(197, 275);
            btn_BMP.Name = "btn_BMP";
            btn_BMP.Size = new Size(80, 50);
            btn_BMP.TabIndex = 15;
            btn_BMP.Text = "BMP";
            btn_BMP.UseVisualStyleBackColor = true;
            btn_BMP.Click += btn_BMP_Click;
            // 
            // btn_GIF
            // 
            btn_GIF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_GIF.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GIF.ForeColor = SystemColors.ControlDarkDark;
            btn_GIF.Location = new Point(283, 275);
            btn_GIF.Name = "btn_GIF";
            btn_GIF.Size = new Size(80, 50);
            btn_GIF.TabIndex = 16;
            btn_GIF.Text = "GIF";
            btn_GIF.UseVisualStyleBackColor = true;
            btn_GIF.Click += btn_GIF_Click;
            // 
            // btn_TIFF
            // 
            btn_TIFF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_TIFF.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_TIFF.ForeColor = SystemColors.ControlDarkDark;
            btn_TIFF.Location = new Point(369, 275);
            btn_TIFF.Name = "btn_TIFF";
            btn_TIFF.Size = new Size(80, 50);
            btn_TIFF.TabIndex = 17;
            btn_TIFF.Text = "TIFF";
            btn_TIFF.UseVisualStyleBackColor = true;
            btn_TIFF.Click += btn_TIFF_Click;
            // 
            // btn_ICO
            // 
            btn_ICO.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ICO.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ICO.ForeColor = SystemColors.ControlDarkDark;
            btn_ICO.Location = new Point(25, 331);
            btn_ICO.Name = "btn_ICO";
            btn_ICO.Size = new Size(80, 50);
            btn_ICO.TabIndex = 18;
            btn_ICO.Text = "ICO";
            btn_ICO.UseVisualStyleBackColor = true;
            btn_ICO.Click += btn_ICO_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(484, 444);
            Controls.Add(btn_ICO);
            Controls.Add(btn_TIFF);
            Controls.Add(btn_GIF);
            Controls.Add(btn_BMP);
            Controls.Add(btn_PNG);
            Controls.Add(btn_JPG);
            Controls.Add(label5);
            Controls.Add(btnConvertNow);
            Controls.Add(btnBrowseOut);
            Controls.Add(textPathOut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textPath);
            Controls.Add(pathTxt);
            Controls.Add(label2);
            Controls.Add(btnSelectFolder);
            Controls.Add(btnSelectFile);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "ITC - Image Type Converter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private Button btnSelectFile;
        private Button btnSelectFolder;
        private Label label2;
        private OpenFileDialog dlgOpenFile;
        private FolderBrowserDialog dlgOpenFolder;
        private Label pathTxt;
        private TextBox textPath;
        private Label label3;
        private Label label4;
        private TextBox textPathOut;
        private Button btnBrowseOut;
        private Button btnConvertNow;
        private Label label5;
        private Button btn_JPG;
        private Button btn_PNG;
        private Button btn_BMP;
        private Button btn_GIF;
        private Button btn_TIFF;
        private Button btn_ICO;
    }
}
