using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster Sasl
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-sasl.html
    /// </summary>
    public class Sasl
    {

        /// <summary>
        /// Iam
        /// Details for IAM access control.
        /// Required: No
        /// Type: Iam
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Iam")]
        public Iam Iam { get; set; }

        /// <summary>
        /// Scram
        /// Details for SASL/SCRAM client authentication.
        /// Required: No
        /// Type: Scram
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Scram")]
        public Scram Scram { get; set; }

    }
}
