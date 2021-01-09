using System.IO;
using UnitsNet.CodeGen;

namespace UnitsNetQuantityExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate();
        }

        private static void Generate()
        {
            var basePath = Directory.GetCurrentDirectory();
            var baseProjectpath = Path.Combine(basePath, "../../../");
            var customPath = Path.Combine(baseProjectpath, "Custom");
            var sourceFolderPath = Path.Combine(customPath, "UnitDefinitions");
            var quantitiesTargetFolderPath = Path.Combine(customPath, "Quantities");
            var unitsTargetFolderPath = Path.Combine(customPath, "Units");
            var quantityfactoryFolderPath = customPath;
            var options = new Options
            {
                LogVerbose = true,
                SourceFolderPath = sourceFolderPath,
                UseNullableReferenceTypes = false,
                Quantities = new GenerateOptions
                {
                    NamespaceName = "UnitsNetQuantityExtensionExample.Custom.Quantities",
                    TargetFolderPath = quantitiesTargetFolderPath
                },
                Units = new GenerateOptions
                {
                    NamespaceName = "UnitsNetQuantityExtensionExample.Custom.Units",
                    TargetFolderPath = unitsTargetFolderPath
                },
                StaticQuantityFactory = new GenerateOptions
                {
                    NamespaceName = "UnitsNetQuantityExtensionExample.Custom",
                    TargetFilename = "PetroleumEngineeringQuantities",
                    TargetFolderPath = quantityfactoryFolderPath
                },
            };
            var generator = new ExtensionsCodeGen(options);
            generator.Generate();
        }
    }
}
