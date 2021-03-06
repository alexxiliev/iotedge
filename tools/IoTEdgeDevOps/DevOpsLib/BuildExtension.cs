// Copyright (c) Microsoft. All rights reserved.
namespace DevOpsLib
{
    using System.Collections.Generic;

    public static class BuildExtension
    {
        public static HashSet<BuildDefinitionId> BuildDefinitions =>
            new HashSet<BuildDefinitionId>
            {
                BuildDefinitionId.CI,
                BuildDefinitionId.EdgeletCI,
                BuildDefinitionId.LibiohsmCI,
                BuildDefinitionId.BuildImages,
                BuildDefinitionId.EdgeletPackages,
                BuildDefinitionId.EndToEndTest
            };

        public static string DisplayName(this BuildDefinitionId buildDefinitionId)
        {
            var definitionIdToDisplayNameMapping = new Dictionary<BuildDefinitionId, string>
            {
                { BuildDefinitionId.BuildImages, "Build Images" },
                { BuildDefinitionId.CI, "CI" },
                { BuildDefinitionId.EdgeletCI, "Edgelet CI" },
                { BuildDefinitionId.EdgeletPackages, "Edgelet Packages" },
                { BuildDefinitionId.EdgeletRelease, "Edgelet Release" },
                { BuildDefinitionId.EndToEndTest, "End-to-End Test" },
                { BuildDefinitionId.ImageRelease, "Image Release" },
                { BuildDefinitionId.LibiohsmCI, "Libiohsm CI" },
            };

            return definitionIdToDisplayNameMapping.ContainsKey(buildDefinitionId) ? definitionIdToDisplayNameMapping[buildDefinitionId] : buildDefinitionId.ToString();
        }

        public static string IdString(this BuildDefinitionId buildDefinitionId) => ((int) buildDefinitionId).ToString();
    }
}
