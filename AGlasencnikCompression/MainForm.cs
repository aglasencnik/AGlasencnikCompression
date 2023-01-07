using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGlasencnikCompression
{
    public partial class MainForm : Form
    {
        private string inputFilePath;
        private string outputFilePath;

        public MainForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void btnOpenFileCompress_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog() 
                { 
                    Filter = "All files|*.*", 
                    ValidateNames = true, 
                    Multiselect = false 
                })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        tbxCompress.Text = dialog.SafeFileName;
                        inputFilePath = dialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void btnOpenFileDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog() 
                { 
                    Filter = "Gzip Archive|*.gz", 
                    ValidateNames = true, 
                    Multiselect = false 
                })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        tbxDecompress.Text = dialog.SafeFileName;
                        inputFilePath = dialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(inputFilePath))
                {
                    var dialog = MessageBox.Show("Ali res želite stisniti to datoteko?", 
                        "Ali res želite stisniti to datoteko?", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        CompressFile(inputFilePath, inputFilePath + ".gz");

                        inputFilePath = "";
                        outputFilePath = "";
                        tbxCompress.Text = "";
                    }
                    else MessageBox.Show("Stiskanje preklicano!", 
                        "Stiskanje preklicano!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Nobena datoteka ni izbrana!", 
                    "Datoteka ni izbrana!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(inputFilePath))
                {
                    var dialog = MessageBox.Show("Ali res želite razširiti to datoteko?",
                        "Ali res želite razširiti to datoteko?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        outputFilePath = tbxDecompress.Text.Substring(0, tbxDecompress.Text.Length - 3);

                        DecompressFile(inputFilePath, outputFilePath);

                        inputFilePath = "";
                        outputFilePath = "";
                        tbxDecompress.Text = "";
                    }
                    else MessageBox.Show("Razširjanje preklicano!",
                        "Razširjanje preklicano!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Nobena datoteka ni izbrana!", 
                    "Datoteka ni izbrana!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void CompressFile(string inputFile, string outputFile)
        {
            try
            {
                using (FileStream outputStream = File.Create(outputFile))
                {
                    using (GZipStream compressionStream = new GZipStream(outputStream, CompressionMode.Compress))
                    {
                        using (FileStream inputStream = File.OpenRead(inputFile))
                        {
                            long inputLength = inputStream.Length;
                            int progress = 0;

                            const int bufferSize = 1024 * 1024;
                            byte[] buffer = new byte[bufferSize];
                            int bytesRead;
                            while ((bytesRead = inputStream.Read(buffer, 0, bufferSize)) > 0)
                            {
                                compressionStream.Write(buffer, 0, bytesRead);

                                progress += bytesRead;
                                progressBar.Value = (int)((double)progress / inputLength * 100);
                                progressBar.Update();
                            }
                        }
                    }
                }

                FileInfo inputInfo = new FileInfo(inputFile);
                FileInfo outputInfo = new FileInfo(outputFile);
                double ratio = Math.Round((double)inputInfo.Length / outputInfo.Length, 3);

                MessageBox.Show("Stiskanje datoteke je bilo uspešno!"
                    + Environment.NewLine + $"Razmerje stiskanja je bilo: {ratio}", 
                    "Stiskanje datoteke uspešno!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBar.Value = 0;
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }

        private void DecompressFile(string inputFile, string outputFile)
        {
            try
            {
                using (FileStream inputStream = File.OpenRead(inputFile))
                {
                    using (GZipStream decompressionStream = new GZipStream(inputStream, CompressionMode.Decompress))
                    {
                        using (FileStream outputStream = File.Create(outputFile))
                        {
                            int progress = 0;

                            const int bufferSize = 1024 * 1024;
                            byte[] buffer = new byte[bufferSize];
                            int bytesRead;
                            while ((bytesRead = decompressionStream.Read(buffer, 0, bufferSize)) > 0)
                            {
                                outputStream.Write(buffer, 0, bytesRead);

                                progress += bytesRead;
                                progressBar.Value = (int)((double)progress / outputStream.Length * 100);
                                progressBar.Update();
                            }
                        }
                    }
                }

                MessageBox.Show("Razširjanje datoteke je bilo uspešno!",
                    "Razširjanje datoteke uspešno!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBar.Value = 0;
            }
            catch (Exception ex)
            {
                _ = new ErrorHandlerService(ex);
            }
        }
    }
}
