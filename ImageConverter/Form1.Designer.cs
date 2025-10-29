namespace ImageConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtSource;
        private TextBox txtTarget;
        private Button btnBrowseSrc;
        private Button btnBrowseDst;
        private Button btnStart;
        private ProgressBar progressBar;
        private Label lblStatus;
        private Label lblSrc;
        private Label lblDst;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSource = new TextBox();
            txtTarget = new TextBox();
            btnBrowseSrc = new Button();
            btnBrowseDst = new Button();
            btnStart = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            lblSrc = new Label();
            lblDst = new Label();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Location = new Point(12, 53);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(480, 39);
            txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(12, 131);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(480, 39);
            txtTarget.TabIndex = 3;
            // 
            // btnBrowseSrc
            // 
            btnBrowseSrc.Location = new Point(498, 53);
            btnBrowseSrc.Name = "btnBrowseSrc";
            btnBrowseSrc.Size = new Size(90, 39);
            btnBrowseSrc.TabIndex = 4;
            btnBrowseSrc.Text = "Seç...";
            btnBrowseSrc.UseVisualStyleBackColor = true;
            btnBrowseSrc.Click += btnBrowseSrc_Click;
            // 
            // btnBrowseDst
            // 
            btnBrowseDst.Location = new Point(498, 131);
            btnBrowseDst.Name = "btnBrowseDst";
            btnBrowseDst.Size = new Size(90, 39);
            btnBrowseDst.TabIndex = 5;
            btnBrowseDst.Text = "Seç...";
            btnBrowseDst.UseVisualStyleBackColor = true;
            btnBrowseDst.Click += btnBrowseDst_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 180);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(576, 70);
            btnStart.TabIndex = 6;
            btnStart.Text = "Başlat";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 285);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(576, 23);
            progressBar.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(12, 253);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(576, 29);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "0 / 0";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSrc
            // 
            lblSrc.AutoSize = true;
            lblSrc.Location = new Point(12, 18);
            lblSrc.Name = "lblSrc";
            lblSrc.Size = new Size(164, 32);
            lblSrc.TabIndex = 0;
            lblSrc.Text = "Kaynak klasör:";
            // 
            // lblDst
            // 
            lblDst.AutoSize = true;
            lblDst.Location = new Point(12, 96);
            lblDst.Name = "lblDst";
            lblDst.Size = new Size(153, 32);
            lblDst.TabIndex = 1;
            lblDst.Text = "Hedef klasör:";
            // 
            // Form1
            // 
            ClientSize = new Size(600, 320);
            Controls.Add(lblSrc);
            Controls.Add(lblDst);
            Controls.Add(txtSource);
            Controls.Add(txtTarget);
            Controls.Add(btnBrowseSrc);
            Controls.Add(btnBrowseDst);
            Controls.Add(btnStart);
            Controls.Add(progressBar);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "HEIC/HCEF → JPG Dönüştürücü";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
