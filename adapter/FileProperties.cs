using System.Collections.Generic;
using System.IO;

namespace adapter
{
    public class FileProperties : FileIO
    {
        private FileStream _fileStream;
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string GetValue(string key)
        {
            if (!_dictionary.ContainsKey(key))
                return string.Empty;

            return _dictionary[key];
        }

        public void ReadFromFile(string fileName)
        {
            _fileStream = File.Open(fileName, FileMode.OpenOrCreate);
        }

        public void SetValue(string key, string value)
        {
            _dictionary.Add(key, value);
        }

        public void WriteToFile(string fileName)
        {
            foreach (var key in _dictionary.Keys)
            {
                _fileStream.Write(System.Text.UTF8Encoding.UTF8.GetBytes(_dictionary[key]));    
            }
        }
    }
}