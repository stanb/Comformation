using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.ResourceSet
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::ResourceSet TargetResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-targetresource.html
    /// </summary>
    public class TargetResource
    {

        /// <summary>
        /// NLBResource
        /// The Network Load Balancer resource that a DNS target resource points to. You must set either this or
        /// R53Resource, but not both.
        /// Required: No
        /// Type: NLBResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NLBResource")]
        public NLBResource NLBResource { get; set; }

        /// <summary>
        /// R53Resource
        /// The Route 53 resource that a DNS target resource record points to. You must set either this or
        /// NLBResource, but not both.
        /// Required: No
        /// Type: R53ResourceRecord
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("R53Resource")]
        public R53ResourceRecord R53Resource { get; set; }

    }
}
