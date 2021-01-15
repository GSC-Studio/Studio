using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSC_Studio.Core.Assets
{
    public class ProjectModel
    {
        public string Name { get; set; }
        public List<FileModel> Files { get; set; }
        public int CurrentEditor { get; set; }
        public string ProjectPath { get; set; }
        public BuildMode Mode { get; set; }
    }
}
