using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinition
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinition FunctionDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-functiondefinitionversion.html
    /// </summary>
    public class FunctionDefinitionVersion
    {

        /// <summary>
        /// DefaultConfig
        /// The default configuration that applies to all Lambda functions in the group. Individual Lambda
        /// functions can override these settings.
        /// Required: No
        /// Type: DefaultConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DefaultConfig")]
        public DefaultConfig DefaultConfig { get; set; }

        /// <summary>
        /// Functions
        /// The functions in this version.
        /// Required: Yes
        /// Type: List of Function
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Functions")]
        public List<Function> Functions { get; set; }

    }
}
