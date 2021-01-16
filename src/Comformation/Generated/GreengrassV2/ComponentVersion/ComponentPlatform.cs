using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion ComponentPlatform
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentplatform.html
    /// </summary>
    public class ComponentPlatform
    {

        /// <summary>
        /// Name
        /// The friendly name of the platform. This name helps you identify the platform.
        /// If you omit this parameter, AWS IoT Greengrass creates a friendly name from the os and architecture
        /// of the platform.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Attributes
        /// A dictionary of attributes for the platform. The AWS IoT Greengrass Core software defines the os and
        /// platform by default. You can specify additional platform attributes for a core device when you
        /// deploy the Greengrass nucleus component. For more information, see the Greengrass nucleus component
        /// in the AWS IoT Greengrass V2 Developer Guide.
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Attributes")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

    }
}
