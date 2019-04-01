using AForge.Imaging.Filters;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace RecogCaptcha
{
    public partial class Form2 : Form
    {
        bool first = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap image = new Bitmap(openFileDialog.FileName);
            if (image != null)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(openFileDialog.FileName);
                originalImage.Image = new Bitmap(image);
                reconhecerCaptcha(image);
            }
            image.Dispose();
        }

        private void reconhecerCaptcha(Image img)
        {
            Bitmap imagem = new Bitmap(img);
            imagem = imagem.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Erosion erosion = new Erosion();
            Dilatation dilatation = new Dilatation();
            Invert inverter = new Invert();
            ColorFiltering cor = new ColorFiltering();
            cor.Blue = new AForge.IntRange(200, 255);
            cor.Red = new AForge.IntRange(200, 255);
            cor.Green = new AForge.IntRange(200, 255);
            Opening open = new Opening();
            BlobsFiltering bc = new BlobsFiltering();
            Closing close = new Closing();
            GaussianSharpen gs = new GaussianSharpen();
            ContrastCorrection cc = new ContrastCorrection();
            bc.MinHeight = 10;

            FiltersSequence seq = new FiltersSequence(gs, inverter, open, inverter, bc, inverter, open, cc, cor, bc, inverter);

            modifiedImage.Image = new Bitmap(originalImage.Image);

            applyFilters(seq);
        }

        private string OCR(Bitmap imgsource)
        {
            string ocrtext = "";
            
            using (var engine = new TesseractEngine(@"tessdata", "por", EngineMode.Default))
            {
                string letters = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "0123456789";
                engine.SetVariable("tessedit_char_whitelist", $"{numbers}{letters}{letters.ToUpper()}");
                engine.SetVariable("tessedit_unrej_any_wd", true);
                engine.SetVariable("tessedit_adapt_to_char_fragments", true);
                engine.SetVariable("tessedit_redo_xheight", true);
                engine.SetVariable("chop_enable", true);

                Bitmap x = imgsource.Clone(new Rectangle(0, 0, imgsource.Width, imgsource.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                using (var img = PixConverter.ToPix(imgsource))
                {
                    using (var page = engine.Process(img))
                    {
                        ocrtext = page.GetText();
                    }
                }
            }
            return ocrtext;
        }

        private void applyFilters(FiltersSequence seq)
        {
            Bitmap img = new Bitmap(modifiedImage.Image);
            Bitmap image = new Bitmap(modifiedImage.Image);
            image = image.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            modifiedImage.Image = seq.Apply(image);

            string reconhecido = OCR((Bitmap)modifiedImage.Image);

            resultLabel.Text = reconhecido;

            IEnumerator enumerator = seq.GetEnumerator();

            foreach (var filter in seq)
            {
                AppliedFiltersList.Items.Add(filter.ToString());
            }

            if (first)
            {
                foreach (var filter in seq)
                {
                    DefaultAppliedFilters.Items.Add(filter.ToString());
                }

                first = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            modifiedImage.Image = (Bitmap)originalImage.Image;
            AppliedFiltersList.Items.Clear();
            resultLabel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reconhecerCaptcha((Bitmap)originalImage.Image);
        }

        private void FilterErosionButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new Erosion()));
        }

        private void FilterDilatationButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new Dilatation()));
        }

        private void FilterInvertButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new Invert()));
        }

        private void FilterColorFilteringButton_Click(object sender, EventArgs e)
        {
            ColorFiltering color = new ColorFiltering();
            color.Blue = new AForge.IntRange(200, 255);
            color.Red = new AForge.IntRange(200, 255);
            color.Green = new AForge.IntRange(200, 255);

            applyFilters(new FiltersSequence(color));
        }

        private void FilterOpeningButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new Opening()));
        }

        private void FilterBlobsFilteringButton_Click(object sender, EventArgs e)
        {
            BlobsFiltering blobsFiltering = new BlobsFiltering();
            blobsFiltering.MinHeight = 10;
            applyFilters(new FiltersSequence(blobsFiltering));
        }

        private void FilterClosingButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new Closing()));
        }

        private void FilterGaussianSharpenButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new GaussianSharpen()));
        }

        private void FilterContrastCorrectionButton_Click(object sender, EventArgs e)
        {
            applyFilters(new FiltersSequence(new ContrastCorrection()));
        }

        private void OCRButton_Click(object sender, EventArgs e)
        {
            string reconhecido = OCR((Bitmap)originalImage.Image);

            resultLabel.Text = reconhecido;
        }
    }
}
