namespace RecogCaptcha
{
    partial class Form2
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImageButton = new System.Windows.Forms.Button();
            this.modifiedImage = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.FilterErosionButton = new System.Windows.Forms.Button();
            this.FilterDilatationButton = new System.Windows.Forms.Button();
            this.FilterDefaultButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterContrastCorrectionButton = new System.Windows.Forms.Button();
            this.FilterGaussianSharpenButton = new System.Windows.Forms.Button();
            this.FilterClosingButton = new System.Windows.Forms.Button();
            this.FilterBlobsFilteringButton = new System.Windows.Forms.Button();
            this.FilterOpeningButton = new System.Windows.Forms.Button();
            this.FilterColorFilteringButton = new System.Windows.Forms.Button();
            this.FilterInvertButton = new System.Windows.Forms.Button();
            this.AppliedFiltersList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DefaultAppliedFilters = new System.Windows.Forms.ListBox();
            this.OCRButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(73, 23);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(129, 23);
            this.openImageButton.TabIndex = 0;
            this.openImageButton.Text = "Selecionar Imagem";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // modifiedImage
            // 
            this.modifiedImage.Location = new System.Drawing.Point(24, 199);
            this.modifiedImage.Name = "modifiedImage";
            this.modifiedImage.Size = new System.Drawing.Size(224, 98);
            this.modifiedImage.TabIndex = 1;
            this.modifiedImage.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(48, 339);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(154, 17);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Não foi reconhecido";
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(24, 52);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(224, 98);
            this.originalImage.TabIndex = 3;
            this.originalImage.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(279, 52);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(129, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // FilterErosionButton
            // 
            this.FilterErosionButton.Location = new System.Drawing.Point(6, 19);
            this.FilterErosionButton.Name = "FilterErosionButton";
            this.FilterErosionButton.Size = new System.Drawing.Size(129, 23);
            this.FilterErosionButton.TabIndex = 6;
            this.FilterErosionButton.Text = "Erosion";
            this.FilterErosionButton.UseVisualStyleBackColor = true;
            this.FilterErosionButton.Click += new System.EventHandler(this.FilterErosionButton_Click);
            // 
            // FilterDilatationButton
            // 
            this.FilterDilatationButton.Location = new System.Drawing.Point(6, 48);
            this.FilterDilatationButton.Name = "FilterDilatationButton";
            this.FilterDilatationButton.Size = new System.Drawing.Size(129, 23);
            this.FilterDilatationButton.TabIndex = 7;
            this.FilterDilatationButton.Text = "Dilatation";
            this.FilterDilatationButton.UseVisualStyleBackColor = true;
            this.FilterDilatationButton.Click += new System.EventHandler(this.FilterDilatationButton_Click);
            // 
            // FilterDefaultButton
            // 
            this.FilterDefaultButton.Location = new System.Drawing.Point(279, 81);
            this.FilterDefaultButton.Name = "FilterDefaultButton";
            this.FilterDefaultButton.Size = new System.Drawing.Size(129, 23);
            this.FilterDefaultButton.TabIndex = 8;
            this.FilterDefaultButton.Text = "Default filters";
            this.FilterDefaultButton.UseVisualStyleBackColor = true;
            this.FilterDefaultButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterContrastCorrectionButton);
            this.groupBox1.Controls.Add(this.FilterGaussianSharpenButton);
            this.groupBox1.Controls.Add(this.FilterClosingButton);
            this.groupBox1.Controls.Add(this.FilterBlobsFilteringButton);
            this.groupBox1.Controls.Add(this.FilterOpeningButton);
            this.groupBox1.Controls.Add(this.FilterColorFilteringButton);
            this.groupBox1.Controls.Add(this.FilterInvertButton);
            this.groupBox1.Controls.Add(this.FilterDilatationButton);
            this.groupBox1.Controls.Add(this.FilterErosionButton);
            this.groupBox1.Location = new System.Drawing.Point(273, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 283);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros AForge";
            // 
            // FilterContrastCorrectionButton
            // 
            this.FilterContrastCorrectionButton.Location = new System.Drawing.Point(6, 252);
            this.FilterContrastCorrectionButton.Name = "FilterContrastCorrectionButton";
            this.FilterContrastCorrectionButton.Size = new System.Drawing.Size(129, 23);
            this.FilterContrastCorrectionButton.TabIndex = 14;
            this.FilterContrastCorrectionButton.Text = "ContrastCorrection";
            this.FilterContrastCorrectionButton.UseVisualStyleBackColor = true;
            this.FilterContrastCorrectionButton.Click += new System.EventHandler(this.FilterContrastCorrectionButton_Click);
            // 
            // FilterGaussianSharpenButton
            // 
            this.FilterGaussianSharpenButton.Location = new System.Drawing.Point(6, 223);
            this.FilterGaussianSharpenButton.Name = "FilterGaussianSharpenButton";
            this.FilterGaussianSharpenButton.Size = new System.Drawing.Size(129, 23);
            this.FilterGaussianSharpenButton.TabIndex = 13;
            this.FilterGaussianSharpenButton.Text = "GaussianSharpen";
            this.FilterGaussianSharpenButton.UseVisualStyleBackColor = true;
            this.FilterGaussianSharpenButton.Click += new System.EventHandler(this.FilterGaussianSharpenButton_Click);
            // 
            // FilterClosingButton
            // 
            this.FilterClosingButton.Location = new System.Drawing.Point(6, 194);
            this.FilterClosingButton.Name = "FilterClosingButton";
            this.FilterClosingButton.Size = new System.Drawing.Size(129, 23);
            this.FilterClosingButton.TabIndex = 12;
            this.FilterClosingButton.Text = "Closing";
            this.FilterClosingButton.UseVisualStyleBackColor = true;
            this.FilterClosingButton.Click += new System.EventHandler(this.FilterClosingButton_Click);
            // 
            // FilterBlobsFilteringButton
            // 
            this.FilterBlobsFilteringButton.Location = new System.Drawing.Point(6, 165);
            this.FilterBlobsFilteringButton.Name = "FilterBlobsFilteringButton";
            this.FilterBlobsFilteringButton.Size = new System.Drawing.Size(129, 23);
            this.FilterBlobsFilteringButton.TabIndex = 11;
            this.FilterBlobsFilteringButton.Text = "BlobsFiltering";
            this.FilterBlobsFilteringButton.UseVisualStyleBackColor = true;
            this.FilterBlobsFilteringButton.Click += new System.EventHandler(this.FilterBlobsFilteringButton_Click);
            // 
            // FilterOpeningButton
            // 
            this.FilterOpeningButton.Location = new System.Drawing.Point(6, 136);
            this.FilterOpeningButton.Name = "FilterOpeningButton";
            this.FilterOpeningButton.Size = new System.Drawing.Size(129, 23);
            this.FilterOpeningButton.TabIndex = 10;
            this.FilterOpeningButton.Text = "Opening";
            this.FilterOpeningButton.UseVisualStyleBackColor = true;
            this.FilterOpeningButton.Click += new System.EventHandler(this.FilterOpeningButton_Click);
            // 
            // FilterColorFilteringButton
            // 
            this.FilterColorFilteringButton.Location = new System.Drawing.Point(6, 107);
            this.FilterColorFilteringButton.Name = "FilterColorFilteringButton";
            this.FilterColorFilteringButton.Size = new System.Drawing.Size(129, 23);
            this.FilterColorFilteringButton.TabIndex = 9;
            this.FilterColorFilteringButton.Text = "ColorFiltering";
            this.FilterColorFilteringButton.UseVisualStyleBackColor = true;
            this.FilterColorFilteringButton.Click += new System.EventHandler(this.FilterColorFilteringButton_Click);
            // 
            // FilterInvertButton
            // 
            this.FilterInvertButton.Location = new System.Drawing.Point(6, 77);
            this.FilterInvertButton.Name = "FilterInvertButton";
            this.FilterInvertButton.Size = new System.Drawing.Size(129, 23);
            this.FilterInvertButton.TabIndex = 8;
            this.FilterInvertButton.Text = "Invert";
            this.FilterInvertButton.UseVisualStyleBackColor = true;
            this.FilterInvertButton.Click += new System.EventHandler(this.FilterInvertButton_Click);
            // 
            // AppliedFiltersList
            // 
            this.AppliedFiltersList.Enabled = false;
            this.AppliedFiltersList.FormattingEnabled = true;
            this.AppliedFiltersList.Location = new System.Drawing.Point(6, 19);
            this.AppliedFiltersList.Name = "AppliedFiltersList";
            this.AppliedFiltersList.Size = new System.Drawing.Size(188, 316);
            this.AppliedFiltersList.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppliedFiltersList);
            this.groupBox2.Location = new System.Drawing.Point(435, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 341);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros aplicados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DefaultAppliedFilters);
            this.groupBox3.Location = new System.Drawing.Point(641, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 341);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros padrao";
            // 
            // DefaultAppliedFilters
            // 
            this.DefaultAppliedFilters.Enabled = false;
            this.DefaultAppliedFilters.FormattingEnabled = true;
            this.DefaultAppliedFilters.Location = new System.Drawing.Point(6, 19);
            this.DefaultAppliedFilters.Name = "DefaultAppliedFilters";
            this.DefaultAppliedFilters.Size = new System.Drawing.Size(188, 316);
            this.DefaultAppliedFilters.TabIndex = 10;
            // 
            // OCRButton
            // 
            this.OCRButton.Location = new System.Drawing.Point(279, 23);
            this.OCRButton.Name = "OCRButton";
            this.OCRButton.Size = new System.Drawing.Size(129, 23);
            this.OCRButton.TabIndex = 13;
            this.OCRButton.Text = "OCR";
            this.OCRButton.UseVisualStyleBackColor = true;
            this.OCRButton.Click += new System.EventHandler(this.OCRButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 435);
            this.Controls.Add(this.OCRButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilterDefaultButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.modifiedImage);
            this.Controls.Add(this.openImageButton);
            this.Name = "Form1";
            this.Text = "Recog. Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.PictureBox modifiedImage;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button FilterErosionButton;
        private System.Windows.Forms.Button FilterDilatationButton;
        private System.Windows.Forms.Button FilterDefaultButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FilterInvertButton;
        private System.Windows.Forms.Button FilterColorFilteringButton;
        private System.Windows.Forms.Button FilterOpeningButton;
        private System.Windows.Forms.Button FilterGaussianSharpenButton;
        private System.Windows.Forms.Button FilterClosingButton;
        private System.Windows.Forms.Button FilterBlobsFilteringButton;
        private System.Windows.Forms.Button FilterContrastCorrectionButton;
        private System.Windows.Forms.ListBox AppliedFiltersList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox DefaultAppliedFilters;
        private System.Windows.Forms.Button OCRButton;
    }
}

