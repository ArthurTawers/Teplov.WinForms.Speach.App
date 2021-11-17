using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teplov.Develop.DonwloadForUrl.BL;
using System.Speech.Synthesis;
using System.IO;

namespace Teplov.WinForms.Speech.AppForm
{
    class MainPresenter
    {
        SpeechSynthesizer speech;

        private readonly IMessageService messageService;
        private readonly IMainForm mainForm;
        private readonly IFileManager manager;
        private WordsHelper wordsHelper;
        private string nowKey;
        int i = 0;
        int correctAnswer = 0;
        public MainPresenter(IMessageService ms, IMainForm mf,IFileManager mg)
        {
            messageService = ms;
            mainForm = mf;
            manager = mg;

            speech = new SpeechSynthesizer();
            speech.SelectVoice(speech.GetInstalledVoices().Last().VoiceInfo.Name);

            mainForm.EventButSelect += MainForm_EventButSelect;
            mainForm.EventButStart += MainForm_EventButStart;
            mainForm.EventButVoice += MainForm_EventButVoice;
            mainForm.EventRateChanged += MainForm_EventRateChanged;
            mainForm.EventVolumeChanged += MainForm_EventVolumeChanged;
            mainForm.EventButSkip += MainForm_EventButSkip;
            mainForm.EventButReply += MainForm_EventButReply;
        }

        private void MainForm_EventButReply(object sender, EventArgs e)
        {
            string[] value = wordsHelper.GetValue(nowKey).Split('/');
            foreach (string str in value)
            {
                if (mainForm.PropAnswerText == str)
                {
                    nowKey = wordsHelper.GetNextKey();
                    i++;
                    mainForm.Progress = i + "/" + wordsHelper.Length;
                    mainForm.PropAnswerText = "";
                    correctAnswer++;
                    if (i >= wordsHelper.Length)
                        End();
                    return;
                }
            }
            messageService.ShowError("Неверно");         

        }
        private void End()
        {
            messageService.ShowExclimition("Результат: " +
                "\nПравильно: " + correctAnswer +
                "\nНеправильно: " + (wordsHelper.Length - correctAnswer).ToString());
            correctAnswer = 0;
            i = 0;
            mainForm.Progress = i + "/" + wordsHelper.Length;
            wordsHelper.Reset();
            nowKey = wordsHelper.GetNextKey();
        }

        private void MainForm_EventButSkip(object sender, EventArgs e)
        {
            nowKey = wordsHelper.GetNextKey();
            i++;
            
            mainForm.Progress = i + "/" + wordsHelper.Length;

            if (i == wordsHelper.Length)
                End();
        }

        private void MainForm_EventVolumeChanged(object sender, EventArgs e)
        {
            speech.Volume = mainForm.Volume;
        }

        private void MainForm_EventRateChanged(object sender, EventArgs e)
        {
            speech.Rate = mainForm.Rate;
        }

        private void MainForm_EventButVoice(object sender, EventArgs e)
        {
            speech.SpeakAsync(nowKey);
        }

        private void MainForm_EventButStart(object sender, EventArgs e)
        {
            if (mainForm.PropFilePath == "")
            {
                messageService.ShowError("Выберите файл!");
                return;
            }
            try
            {
                wordsHelper= new WordsHelper(manager.GetDictionary());
                nowKey = wordsHelper.GetNextKey();
                i = 0;
                mainForm.Progress = i + "/" + wordsHelper.Length.ToString();
                mainForm.PropAnswerText = "";
                speech.Volume = mainForm.Volume;
                speech.Rate = mainForm.Rate;
            }
            catch(Exception exc)
            {
                messageService.ShowError(exc.Message);
            }
        }

        private void MainForm_EventButSelect(object sender, EventArgs e)
        {
            try
            {
                manager.SetFilePath(mainForm.PropFilePath);
            }
            catch(Exception exc)
            {
                messageService.ShowError(exc.Message);
            }
                
        }
    }
}
