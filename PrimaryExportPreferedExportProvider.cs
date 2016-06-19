using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MefInstancePicker
{
    public class PrimaryExportPreferedExportProvider : ExportProvider
    {
        private AssemblyCatalog catalog;

        public PrimaryExportPreferedExportProvider(AssemblyCatalog catalog)
        {
            this.catalog = catalog;
        }

        protected override IEnumerable<Export> GetExportsCore(ImportDefinition definition, AtomicComposition atomicComposition)
        {
            var exports = this.catalog.GetExports(definition);

            if ((definition.Cardinality == ImportCardinality.ExactlyOne ||
                definition.Cardinality == ImportCardinality.ZeroOrOne) &&
                exports.Count() > 1)
            {
                var export = exports.FirstOrDefault(e => e.Item2.Metadata.Any(a => a.Key == "IsPrimaryExport" && (bool)a.Value == true));
                return new List<Export> { new Export(export.Item2, () => export.Item1.CreatePart().GetExportedValue(export.Item2)) };
            }

            return exports.Select(e => new Export(e.Item2, () => e.Item1.CreatePart().GetExportedValue(e.Item2)));
        }
    }
}
