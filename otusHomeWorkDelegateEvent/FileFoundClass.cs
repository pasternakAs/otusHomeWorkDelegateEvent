using System;

namespace otusHomeWorkDelegateEvent
{
    public delegate void FileFoundEventHandler(object source, FileArgs e);

    public class FileFoundClass
    {
        private string _path;
        private EventWorkClass _eventClass;

        //Написать класс, обходящий каталог файлов и выдающий событие при нахождении каждого файла;
        //Оформить событие и его аргументы с использованием.NET соглашений:
        //public event EventHandler FileFound;
        //FileArgs – будет содержать имя файла и наследоваться от EventArgs
        //Добавить возможность отмены дальнейшего поиска из обработчика;
        //Вывести в консоль сообщения, возникающие при срабатывании событий и результат поиска максимального элемента.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">путь</param>
        public FileFoundClass(string path)
        {
            _path = path;

            _eventClass = new EventWorkClass();
            _eventClass.FileFoundEventHandler += new FileFoundEventHandler(FileFoundMessage);
            _eventClass.RaiseEvent(_path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        static void FileFoundMessage(object source, FileArgs e)
        {
            Console.WriteLine(e.GetInfo());
        }
    }
}
