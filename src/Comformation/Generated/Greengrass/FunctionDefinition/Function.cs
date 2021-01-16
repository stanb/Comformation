using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinition
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinition Function
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-functiondefinition-function.html
    /// </summary>
    public class Function
    {

        /// <summary>
        /// FunctionArn
        /// The Amazon Resource Name (ARN) of the alias (recommended) or version of the referenced Lambda
        /// function.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FunctionArn")]
        public Union<string, IntrinsicFunction> FunctionArn { get; set; }

        /// <summary>
        /// FunctionConfiguration
        /// The group-specific settings of the Lambda function. These settings configure the function&#39;s behavior
        /// in the Greengrass group.
        /// Required: Yes
        /// Type: FunctionConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FunctionConfiguration")]
        public FunctionConfiguration FunctionConfiguration { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the function. This value must be unique within the function
        /// definition version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}
