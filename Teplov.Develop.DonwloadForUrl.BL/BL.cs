using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teplov.Develop.DonwloadForUrl.BL
{
    public interface IFileManager
    {
        void SetFilePath(string str);
        Dictionary<string, string> GetDictionary();

    }

    public class FileManager : IFileManager
    {
        string filePath;
        public Dictionary<string,string> GetDictionary()
        {
            string[] AllLines;
            Dictionary<string, string> AllWords = new Dictionary<string, string>();
            try
            {
                if (filePath != null)
                    if (File.Exists(filePath))
                    {
                        AllLines = File.ReadAllLines(filePath);
                        if (AllLines.Length != 0 && AllLines[0] != "")
                            foreach (string str in AllLines)
                            {
                                if(str.Contains(":"))
                                    AllWords.Add(str.Split(':').First(), str.Split(':').Last());
                            }
                        else
                        {
                            throw new Exception("В файле нету слов!");
                        }
                    }
                    else
                    {
                        throw new Exception("Файл не существует");
                    }
                else
                {
                    throw new Exception("Файл не задан!");
                }
            }
            catch
            {
                throw ;
            }
            return AllWords;
        }

        public void SetFilePath(string path)
        {
            if (path != null)
            {
                if (File.Exists(path))
                    filePath = path;
            }
            else
                throw new Exception("Файла не существует");
            
        }
    }

}
