using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association Target
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Key
        /// User-defined criteria for sending commands that target instances that meet the criteria.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 163
        /// Pattern: ^[\p{L}\p{Z}\p{N}_. :/=\-@]*$|resource-groups:ResourceTypeFilters|resource-groups:Name
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Values
        /// User-defined criteria that maps to Key. For example, if you specified tag:ServerRole, you could
        /// specify value:WebServer to run a command on instances that include EC2 tags of ServerRole,WebServer.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
