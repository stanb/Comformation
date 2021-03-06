using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinition
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinition DefaultConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-defaultconfig.html
    /// </summary>
    public class DefaultConfig
    {

        /// <summary>
        /// Execution
        /// Configuration settings for the Lambda execution environment on the AWS IoT Greengrass core.
        /// Required: Yes
        /// Type: Execution
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Execution")]
        public Execution Execution { get; set; }

    }
}
