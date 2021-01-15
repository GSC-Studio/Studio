using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSC_Studio.Core.Assets
{
    public class FileModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public List<ErrorMessage> Errors { get; set; }
        public bool Saved { get; set; }
        public List<string> History { get; set; }
    }
}
