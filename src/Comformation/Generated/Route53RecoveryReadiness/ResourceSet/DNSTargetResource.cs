using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryReadiness.ResourceSet
{
    /// <summary>
    /// AWS::Route53RecoveryReadiness::ResourceSet DNSTargetResource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-dnstargetresource.html
    /// </summary>
    public class DNSTargetResource
    {

        /// <summary>
        /// DomainName
        /// The domain name that acts as an ingress point to a portion of the customer application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// RecordSetId
        /// The Route 53 record set ID that will uniquely identify a DNS record, given a name and a type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordSetId")]
        public Union<string, IntrinsicFunction> RecordSetId { get; set; }

        /// <summary>
        /// HostedZoneArn
        /// The hosted zone Amazon Resource Name (ARN) that contains the DNS record with the provided name of
        /// the target resource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostedZoneArn")]
        public Union<string, IntrinsicFunction> HostedZoneArn { get; set; }

        /// <summary>
        /// RecordType
        /// The type of DNS record of the target resource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecordType")]
        public Union<string, IntrinsicFunction> RecordType { get; set; }

        /// <summary>
        /// TargetResource
        /// The target resource that the Route 53 record points to.
        /// Required: No
        /// Type: TargetResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetResource")]
        public TargetResource TargetResource { get; set; }

    }
}
