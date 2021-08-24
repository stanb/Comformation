using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.ConfigurationProfile
{
    /// <summary>
    /// AWS::AppConfig::ConfigurationProfile Validators
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-configurationprofile-validators.html
    /// </summary>
    public class Validators
    {

        /// <summary>
        /// Type
        /// AWS AppConfig supports validators of type JSON_SCHEMA and LAMBDA
        /// Required: No
        /// Type: String
        /// Allowed values: JSON_SCHEMA | LAMBDA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Content
        /// Either the JSON Schema content or the Amazon Resource Name (ARN) of an Lambda function.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 32768
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Content")]
        public Union<string, IntrinsicFunction> Content { get; set; }

    }
}
