using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Teplov.WinForms.Speech.AppForm
{
    public interface IMainForm
    {
        string PropFilePath { get;}
        string PropAnswerText { get; set; }
        int Rate { get;}
        int Volume { get;}
        string Progress { set; }

        event EventHandler EventButStart;
        event EventHandler EventButReply;
        event EventHandler EventButSkip;
        event EventHandler EventButSelect;
        event EventHandler EventButVoice;
        event EventHandler EventRateChanged;
        event EventHandler EventVolumeChanged;

    }

    public partial class MainForm : Form,IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
          
            FirstLoadForm();
            
            butSelect.Click += ButSelect_Click;

            butStart.Click += ButStart_Click;

            ButReply.Click += ButReply_Click;

            ButSkip.Click += ButSkip_Click;

            PictureVoice.Click += PictureVoice_Click;

            RateNumeric.ValueChanged += RateNumeric_ValueChanged;

            VolumeNumeric.ValueChanged += VolumeNumeric_ValueChanged;

        }

        #region Проброс Событий

        private void VolumeNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (EventVolumeChanged != null)
                EventVolumeChanged(this, EventArgs.Empty);
        }

        private void RateNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (EventRateChanged != null)
                EventRateChanged(this, EventArgs.Empty);
        }

        private void PictureVoice_Click(object sender, EventArgs e)
        {
            if (EventButVoice != null)
                EventButVoice(this, EventArgs.Empty);
        }

        private void ButSkip_Click(object sender, EventArgs e)
        {
            if (EventButSkip != null)
                EventButSkip(this, EventArgs.Empty);
        }

        private void ButReply_Click(object sender, EventArgs e)
        {
            if (EventButReply != null)
                EventButReply(this, EventArgs.Empty);
        }
        #endregion
        private void ButStart_Click(object sender, EventArgs e)
        {
            if (FilePath.Text == "")
            {
                MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (butStart.Text == "Start")
            {
                butStart.Location = new Point(164, 123);
                MainGroup.Visible = true;
                butStart.Text = "Stop";
                groupTop.Visible = false;

                if(EventButStart != null)
                {
                    EventButStart(this, EventArgs.Empty);
                }

            }
            else
            {
                
                if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.No)
                    return;
                butStart.Location = new Point(100, 100);
                MainGroup.Visible = false;
                butStart.Text = "Start";
                ProgressForm.Text = "0/0";


                if (EventButStop!= null)
                {
                    EventButStop(this, EventArgs.Empty);
                }
                groupTop.Visible = true;
            }
        }

        private void FirstLoadForm()
        {
            ToolTip t = new ToolTip();
            t.UseAnimation = true;
            t.UseFading = true;
            t.InitialDelay = 0;
            
            t.AutoPopDelay = 15000;
            t.SetToolTip(PictureVoice, "Voice");
            t.SetToolTip(LabelQuestion, "Указывайте текстовый формат файла." +
                                        "\nОбщая форма записи в файл:" +
                                        "\nВыражение:перевод" +
                                        "\nНеправильный формат будет пропускаться или не воспроизводиться!");
            butStart.Location = new Point(110, 110);
            MainGroup.Visible = false;

        }

        private void ButSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = dlg.FileName;              
                if (EventButSelect != null)
                    EventButSelect(this, EventArgs.Empty);
            }
        }
      
        #region Реализация IForm
        public string PropFilePath
        {
            get { return FilePath.Text; }           
        }

        public string PropAnswerText
        {
            get { return answerText.Text; }
            set { answerText.Text = value; }
        }

        public int Rate
        {
            get { return Convert.ToInt32(RateNumeric.Value); }
        }

        public int Volume
        {
            get { return Convert.ToInt32(VolumeNumeric.Value); }
        }

        public string Progress
        {
            set { ProgressForm.Text = value; }
        }

        public event EventHandler EventButStart;
        public event EventHandler EventButStop;
        public event EventHandler EventButReply;
        public event EventHandler EventButSkip;
        public event EventHandler EventButSelect;
        public event EventHandler EventButVoice;
        public event EventHandler EventRateChanged;
        public event EventHandler EventVolumeChanged;
        #endregion

        private void LabelQuestion_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Надо просто мышкой навести", "Ты долбаеб?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void butStart_Click_1(object sender, EventArgs e)
        {

        }
    }
}
