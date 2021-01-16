using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.CoreDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::CoreDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-coredefinitionversion.html
    /// </summary>
    public class CoreDefinitionVersionResource : ResourceBase
    {
        public class CoreDefinitionVersionProperties
        {
            /// <summary>
            /// Cores
            /// The Greengrass core in this version. Currently, the Cores property for a core definition version can
            /// contain only one core.
            /// Required: Yes
            /// Type: List of Core
            /// Update requires: Replacement
            /// </summary>
            public List<Core> Cores { get; set; }

            /// <summary>
            /// CoreDefinitionId
            /// The ID of the core definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CoreDefinitionId { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::CoreDefinitionVersion";

        public CoreDefinitionVersionProperties Properties { get; } = new CoreDefinitionVersionProperties();

    }
}
