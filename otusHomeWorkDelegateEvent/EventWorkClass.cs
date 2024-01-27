using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace otusHomeWorkDelegateEvent
{
    public class EventWorkClass
    {
        public bool _isBreak = false;
        private bool _notRepeatQuestion = false;
        public event FileFoundEventHandler FileFoundEventHandler;

        /// <summary>
        /// Констурктор
        /// </summary>
        /// <param name="path">путь</param>
        public void RaiseEvent(string path)
        {
            var directoryInfo = new DirectoryInfo(path);

            FoundFileMethod(directoryInfo);
        }

        /// <summary>
        /// Поиск по директориям файлов
        /// </summary>
        /// <param name="directoryInfo"></param>
        private void FoundFileMethod(DirectoryInfo directoryInfo)
        {
            try
            {
                var files = directoryInfo.GetFiles("*.*");

                if (files != null)
                {
                    foreach (FileInfo file in files)
                    {
                        FileFoundEventHandler(this, new FileArgs("Найден файл - " + file.Name));
                        _notRepeatQuestion = false;
                    }

                    var subDirectory = directoryInfo.GetDirectories();

                    foreach (DirectoryInfo dirInfo in subDirectory)
                    {
                        if (_isBreak) return;
                        if (Quest())
                        {
                            _notRepeatQuestion = true;
                            FoundFileMethod(dirInfo);
                        }
                        else { _isBreak = true; break; }
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool Quest()
        {
            if (_notRepeatQuestion) { return true; }

            Console.WriteLine("Продолжить поиск? [y/n]");
            string yesNo = Console.ReadLine();

            if (yesNo == "y")
                return true;
            else
                return false;
        }
    }
}
