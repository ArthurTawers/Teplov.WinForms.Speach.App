
namespace Teplov.WinForms.Speech.AppForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butStart = new System.Windows.Forms.Button();
            this.LabelSelect = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.butSelect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.PictureVoice = new System.Windows.Forms.PictureBox();
            this.answerText = new System.Windows.Forms.TextBox();
            this.ButSkip = new System.Windows.Forms.Button();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.VolumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RateNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ButReply = new System.Windows.Forms.Button();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.groupTop = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureVoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumeric)).BeginInit();
            this.MainGroup.SuspendLayout();
            this.groupTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStart.Location = new System.Drawing.Point(163, 123);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(464, 42);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click_1);
            // 
            // LabelSelect
            // 
            this.LabelSelect.AutoSize = true;
            this.LabelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelect.Location = new System.Drawing.Point(148, 16);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.Size = new System.Drawing.Size(82, 20);
            this.LabelSelect.TabIndex = 1;
            this.LabelSelect.Text = "Select file:";
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePath.Location = new System.Drawing.Point(230, 14);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(416, 24);
            this.FilePath.TabIndex = 2;
            // 
            // butSelect
            // 
            this.butSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSelect.Location = new System.Drawing.Point(652, 10);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(101, 33);
            this.butSelect.TabIndex = 3;
            this.butSelect.Text = "Select";
            this.butSelect.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ProgressForm});
            this.statusStrip1.Location = new System.Drawing.Point(0, 176);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(639, 37);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 32);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // ProgressForm
            // 
            this.ProgressForm.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressForm.Name = "ProgressForm";
            this.ProgressForm.Size = new System.Drawing.Size(59, 32);
            this.ProgressForm.Text = "0/0";
            // 
            // PictureVoice
            // 
            this.PictureVoice.AccessibleDescription = "";
            this.PictureVoice.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PictureVoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureVoice.Image = global::Teplov.WinForms.Speech.AppForm.Properties.Resources.unnamed;
            this.PictureVoice.Location = new System.Drawing.Point(67, -5);
            this.PictureVoice.Name = "PictureVoice";
            this.PictureVoice.Size = new System.Drawing.Size(67, 46);
            this.PictureVoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureVoice.TabIndex = 5;
            this.PictureVoice.TabStop = false;
            // 
            // answerText
            // 
            this.answerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerText.Location = new System.Drawing.Point(228, 2);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(464, 29);
            this.answerText.TabIndex = 6;
            // 
            // ButSkip
            // 
            this.ButSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButSkip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSkip.Location = new System.Drawing.Point(577, 42);
            this.ButSkip.Name = "ButSkip";
            this.ButSkip.Size = new System.Drawing.Size(115, 41);
            this.ButSkip.TabIndex = 8;
            this.ButSkip.Text = "SKIP>>>";
            this.ButSkip.UseVisualStyleBackColor = true;
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelQuestion.Location = new System.Drawing.Point(752, 14);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(20, 24);
            this.LabelQuestion.TabIndex = 9;
            this.LabelQuestion.Text = "?";
            this.LabelQuestion.Click += new System.EventHandler(this.LabelQuestion_Click);
            // 
            // VolumeNumeric
            // 
            this.VolumeNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.VolumeNumeric.Location = new System.Drawing.Point(146, 86);
            this.VolumeNumeric.Name = "VolumeNumeric";
            this.VolumeNumeric.Size = new System.Drawing.Size(51, 24);
            this.VolumeNumeric.TabIndex = 10;
            this.VolumeNumeric.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rate:";
            // 
            // RateNumeric
            // 
            this.RateNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RateNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateNumeric.Location = new System.Drawing.Point(123, 56);
            this.RateNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RateNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.RateNumeric.Name = "RateNumeric";
            this.RateNumeric.Size = new System.Drawing.Size(36, 24);
            this.RateNumeric.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(141, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "answer:";
            // 
            // ButReply
            // 
            this.ButReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButReply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButReply.Location = new System.Drawing.Point(229, 42);
            this.ButReply.Name = "ButReply";
            this.ButReply.Size = new System.Drawing.Size(115, 41);
            this.ButReply.TabIndex = 7;
            this.ButReply.Text = "REPLY";
            this.ButReply.UseVisualStyleBackColor = true;
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.answerText);
            this.MainGroup.Controls.Add(this.ButSkip);
            this.MainGroup.Controls.Add(this.VolumeNumeric);
            this.MainGroup.Controls.Add(this.label3);
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Controls.Add(this.RateNumeric);
            this.MainGroup.Controls.Add(this.ButReply);
            this.MainGroup.Controls.Add(this.label2);
            this.MainGroup.Controls.Add(this.PictureVoice);
            this.MainGroup.Location = new System.Drawing.Point(-65, 37);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(710, 145);
            this.MainGroup.TabIndex = 15;
            this.MainGroup.TabStop = false;
            // 
            // groupTop
            // 
            this.groupTop.Controls.Add(this.LabelSelect);
            this.groupTop.Controls.Add(this.FilePath);
            this.groupTop.Controls.Add(this.LabelQuestion);
            this.groupTop.Controls.Add(this.butSelect);
            this.groupTop.Location = new System.Drawing.Point(-149, -8);
            this.groupTop.Name = "groupTop";
            this.groupTop.Size = new System.Drawing.Size(782, 41);
            this.groupTop.TabIndex = 16;
            this.groupTop.TabStop = false;
            this.groupTop.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(639, 213);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.groupTop);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(655, 252);
            this.MinimumSize = new System.Drawing.Size(655, 252);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnglishSpeech v0.1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureVoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumeric)).EndInit();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.groupTop.ResumeLayout(false);
            this.groupTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label LabelSelect;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ProgressForm;
        private System.Windows.Forms.PictureBox PictureVoice;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Button ButSkip;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.NumericUpDown VolumeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RateNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button ButReply;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.GroupBox groupTop;
    }
}

