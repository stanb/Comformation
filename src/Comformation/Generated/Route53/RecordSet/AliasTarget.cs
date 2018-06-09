using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSet
{
    /// <summary>
    /// Route 53 AliasTarget Property
    /// AliasTarget is a property of the AWS::Route53::RecordSet resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-aliastarget.html
    /// </summary>
    public class AliasTarget
    {

        /// <summary>
        /// DNSName
        /// The DNS name of the load balancer, the domain name of the CloudFront distribution, the website
        /// endpoint of the Amazon S3 bucket, or another record set in the same hosted zone that is the target
        /// of the alias.
        /// Type: String
        /// Required: Yes
        /// </summary>
        [JsonProperty("DNSName")]
        public Union<string, IntrinsicFunction> DNSName { get; set; }

        /// <summary>
        /// EvaluateTargetHealth
        /// Whether Route&#160;53 checks the health of the resource record sets in the alias target when responding
        /// to DNS queries. For more information about using this property, see EvaluateTargetHealth in the
        /// Amazon Route&#160;53 API Reference.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("EvaluateTargetHealth")]
        public Union<bool, IntrinsicFunction> EvaluateTargetHealth { get; set; }

        /// <summary>
        /// HostedZoneId
        /// The hosted zone ID. For load balancers, use the canonical hosted zone ID of the load balancer. For
        /// Amazon S3, use the hosted zone ID for your bucket&#39;s website endpoint. For CloudFront, use
        /// Z2FDTNDATAQYW2. For a list of hosted zone IDs of other services, see the relevant service in the AWS
        /// Regions and Endpoints.
        /// Type: String
        /// Required: Yes
        /// </summary>
        [JsonProperty("HostedZoneId")]
        public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

    }
}
