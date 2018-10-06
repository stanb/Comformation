using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS Lambda Alias AliasRoutingConfiguration
    /// The AliasRoutingConfiguration property type specifies two different versions of an AWS Lambda function,
    /// allowing you to dictate what percentage of traffic will invoke each version. For more information, see Routing
    /// Traffic to Different Function Versions Using Aliases in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-aliasroutingconfiguration.html
    /// </summary>
    public class AliasRoutingConfiguration
    {

        /// <summary>
        /// AdditionalVersionWeights
        /// The percentage of traffic that will invoke the updated function version.
        /// Required: Yes
        /// Type: List of AWS Lambda Alias VersionWeight
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdditionalVersionWeights")]
        public List<VersionWeight> AdditionalVersionWeights { get; set; }

    }
}
