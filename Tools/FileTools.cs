using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public class FileTools
    {
        public string Path { get; set; }
        public string ReadText() => File.ReadAllText(Path);
        public void WriteText(string text) => File.WriteAllText(Path, text);
        public FileTools(string path) => Path = path;
    }
}
