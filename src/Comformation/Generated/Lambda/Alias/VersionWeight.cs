using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS Lambda Alias VersionWeight
    /// The VersionWeight property type specifies the percentages of traffic that will invoke each function versions
    /// for an AWS Lambda alias. For more information, see Routing Traffic to Different Function Versions Using
    /// Aliases in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html
    /// </summary>
    public class VersionWeight
    {

        /// <summary>
        /// FunctionVersion
        /// Function version to which the alias points.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public Union<string, IntrinsicFunction> FunctionVersion { get; set; }

        /// <summary>
        /// FunctionWeight
        /// The percentage of traffic that will invoke the function version.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionWeight")]
        public Union<double, IntrinsicFunction> FunctionWeight { get; set; }

    }
}
