using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.ResourceSet
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::ResourceSet Resource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-resource.html
    /// </summary>
    public class Resource
    {

        /// <summary>
        /// ResourceArn
        /// The Amazon Resource Name (ARN) of the AWS resource. This is a required setting for all ResourceSet
        /// ResourceSetType settings except AWS::Route53RecoveryReadiness::DNSTargetResource. Do not set this
        /// when ResourceSetType is set to AWS::Route53RecoveryReadiness::DNSTargetResource.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceArn")]
        public Union<string, IntrinsicFunction> ResourceArn { get; set; }

        /// <summary>
        /// ComponentId
        /// The component identifier of the resource, generated when DNS target resource is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentId")]
        public Union<string, IntrinsicFunction> ComponentId { get; set; }

        /// <summary>
        /// DnsTargetResource
        /// A component for DNS/routing control readiness checks. This is a required setting when ResourceSet
        /// ResourceSetType is set to AWS::Route53RecoveryReadiness::DNSTargetResource. Do not set it for any
        /// other ResourceSetType setting.
        /// Required: Conditional
        /// Type: DNSTargetResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DnsTargetResource")]
        public DNSTargetResource DnsTargetResource { get; set; }

        /// <summary>
        /// ReadinessScopes
        /// A list of recovery group Amazon Resource Names (ARNs) and cell ARNs that this resource is contained
        /// within.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadinessScopes")]
        public List<Union<string, IntrinsicFunction>> ReadinessScopes { get; set; }

    }
}
