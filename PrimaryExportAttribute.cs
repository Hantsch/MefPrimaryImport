using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefInstancePicker
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PrimaryExportAttribute : ExportAttribute
    {
        public PrimaryExportAttribute()
        {
            this.IsPrimaryExport = true;
        }

        public bool IsPrimaryExport { get; set; }
    }
}
