using GSC_Studio.Core.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSC_Studio.Core.Service
{
    public static class Project
    {
        public static bool IsProjectUnsaved(this ProjectModel model) => (model.Files.Find(e => e.Saved == false) != null);

    }
}
