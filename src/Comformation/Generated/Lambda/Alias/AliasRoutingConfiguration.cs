using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS::Lambda::Alias AliasRoutingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-aliasroutingconfiguration.html
    /// </summary>
    public class AliasRoutingConfiguration
    {

        /// <summary>
        /// AdditionalVersionWeights
        /// The second version, and the percentage of traffic that&#39;s routed to it.
        /// Required: Yes
        /// Type: List of VersionWeight
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdditionalVersionWeights")]
        public List<VersionWeight> AdditionalVersionWeights { get; set; }

    }
}
