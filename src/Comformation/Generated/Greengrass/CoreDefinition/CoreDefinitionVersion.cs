using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.CoreDefinition
{
    /// <summary>
    /// AWS IoT Greengrass CoreDefinition CoreDefinitionVersion
    /// A core definition version contains a Greengrass core.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-coredefinition-coredefinitionversion.html
    /// </summary>
    public class CoreDefinitionVersion
    {

        /// <summary>
        /// Cores
        /// The Greengrass core in this version. Currently, a core definition version can contain only one core.
        /// Required: Yes
        /// Type: List of Core property types. This list must contain exactly one Core.
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Cores")]
        public List<Core> Cores { get; set; }

    }
}
