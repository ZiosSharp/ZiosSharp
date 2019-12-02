using System.IO;                // Для работы с файлами
using System.Text;              // Для работы с текстами, кодировками и т.д.

namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string filePath);
    }
    /*
     * Умеет как получать содержимое файла, так и сохранять в указанной кодировке,
     * либо в кодрировке по умолчанию.
    */
    public class FileManager: IFileManager        
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);
        /*
         * Проверка существования файла по указанному пути использую функцию IE класса File.
         * (возвращает булево в зависимости существует файл или нет
        */
        public bool IsExist(string filePath)                
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }
        /*
         * Перегруженный метод. Проверяет если не указана кодировка, то Windows кодировка
        */
        public string GetContent(string filePath)           
        {
            return GetContent(filePath, _defaultEncoding);
        }
        /*
         * Открывание файла. Два параметра - получение пути к файлу и получение кодировки файла
        */
        public string GetContent(string filePath, Encoding encoding)        
        {
        /*
        * При помощи метода RAT считываем содержание файла и возвращаем его управляещему коду
        */
            string content = File.ReadAllText(filePath, encoding);      
            return content;
        }
        /*
         * Перегруженный метод. Не требует указания кодировки, а исп-ет кодировку по умолчанию
         */
        public void SaveContent(string content, string filePath)                        
        {
            SaveContent(content, filePath, _defaultEncoding);
        }
        /*
         * выполняет метод WAT
         */
        public void SaveContent(string content, string filePath, Encoding encoding)  
        {        
            File.WriteAllText(filePath, content, encoding);
        }
        /*
         * Подсчет кол-ва символов в содержимом файла
         * (берем содержание файла и считываем его длину.)
         */
        public int GetSymbolCount(string content)       
        {
            int count = content.Length;
            return count;
        }
    }
}
