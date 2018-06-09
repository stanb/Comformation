using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// Route&#160;53 HostedZoneVPCs
    /// The HostedZoneVPCs property is part of the AWS::Route53::HostedZone resource that specifies the VPCs to
    /// associate with the hosted zone.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone-hostedzonevpcs.html
    /// </summary>
    public class VPC
    {

        /// <summary>
        /// VPCId
        /// The ID of the Amazon VPC that you want to associate with the hosted zone.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("VPCId")]
        public Union<string, IntrinsicFunction> VPCId { get; set; }

        /// <summary>
        /// VPCRegion
        /// The region in which the Amazon VPC was created as specified in the VPCId property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("VPCRegion")]
        public Union<string, IntrinsicFunction> VPCRegion { get; set; }

    }
}
