using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FMS.Policy
{
    /// <summary>
    /// AWS::FMS::Policy IEMap
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fms-policy-iemap.html
    /// </summary>
    public class IEMap
    {

        /// <summary>
        /// ACCOUNT
        /// The account list for the map.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ACCOUNT")]
        public List<Union<string, IntrinsicFunction>> ACCOUNT { get; set; }

        /// <summary>
        /// ORGUNIT
        /// The organizational unit list for the map.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ORGUNIT")]
        public List<Union<string, IntrinsicFunction>> ORGUNIT { get; set; }

    }
}
