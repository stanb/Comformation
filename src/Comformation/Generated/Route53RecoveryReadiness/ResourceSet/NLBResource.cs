using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.ResourceSet
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::ResourceSet NLBResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-nlbresource.html
    /// </summary>
    public class NLBResource
    {

        /// <summary>
        /// Arn
        /// 	
        /// A Network Load Balancer resource Amazon Resource Name (ARN).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
