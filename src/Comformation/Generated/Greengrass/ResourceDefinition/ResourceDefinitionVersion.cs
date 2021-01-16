using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ResourceDefinition
{
    /// <summary>
    /// AWS::Greengrass::ResourceDefinition ResourceDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedefinitionversion.html
    /// </summary>
    public class ResourceDefinitionVersion
    {

        /// <summary>
        /// Resources
        /// The resources in this version.
        /// Required: Yes
        /// Type: List of ResourceInstance
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Resources")]
        public List<ResourceInstance> Resources { get; set; }

    }
}
