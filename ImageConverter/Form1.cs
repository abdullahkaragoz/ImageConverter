using ImageMagick;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseSrc_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            dlg.Description = "Kaynak klasörü seçin (HEIC/HCEF dosyaları burada)";
            if (dlg.ShowDialog(this) == DialogResult.OK)
                txtSource.Text = dlg.SelectedPath;
        }

        private void btnBrowseDst_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            dlg.Description = "Hedef klasörü seçin (JPG'ler buraya yazılacak)";
            if (dlg.ShowDialog(this) == DialogResult.OK)
                txtTarget.Text = dlg.SelectedPath;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var src = txtSource.Text.Trim();
            var dst = txtTarget.Text.Trim();

            if (!Directory.Exists(src))
            {
                MessageBox.Show("Kaynak klasör geçersiz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(dst))
            {
                MessageBox.Show("Hedef klasör seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Directory.CreateDirectory(dst);

            var exts = new[] { ".heic", ".hcef", ".heif" };
            var files = Directory.EnumerateFiles(src, "*.*", SearchOption.TopDirectoryOnly)
                                 .Where(f => exts.Contains(Path.GetExtension(f).ToLowerInvariant()))
                                 .ToList();

            if (files.Count == 0)
            {
                MessageBox.Show("Bu klasörde HEIC/HCEF dosyası bulunamadı.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ToggleUi(false);
            progressBar.Minimum = 0;
            progressBar.Maximum = files.Count;
            progressBar.Value = 0;
            lblStatus.Text = $"0 / {files.Count}";

            int ok = 0, fail = 0;

            await Task.Run(() =>
            {
                foreach (var file in files)
                {
                    try
                    {
                        string outPath = Path.Combine(dst, Path.GetFileNameWithoutExtension(file) + ".jpg");

                        using (var image = new MagickImage(file))
                        {
                            image.Quality = 95;
                            image.ColorSpace = ColorSpace.sRGB;
                            image.Write(outPath, MagickFormat.Jpeg);
                        }

                        ok++;
                    }
                    catch
                    {
                        fail++;
                    }

                    this.BeginInvoke(new Action(() =>
                    {
                        progressBar.Value = Math.Min(progressBar.Value + 1, progressBar.Maximum);
                        lblStatus.Text = $"{progressBar.Value} / {progressBar.Maximum}";
                    }));
                }
            });

            ToggleUi(true);

            if (fail == 0)
                MessageBox.Show("Dönüştürme başarılı 🎉", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Bitti fakat {fail} dosya dönüştürülemedi.\n" +
                                $"Başarılı: {ok} / Toplam: {files.Count}",
                                "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ToggleUi(bool enabled)
        {
            btnStart.Enabled = enabled;
            btnBrowseSrc.Enabled = enabled;
            btnBrowseDst.Enabled = enabled;
        }
    }
}
