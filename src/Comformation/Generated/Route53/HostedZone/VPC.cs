using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone VPC
    /// (Private hosted zones only) A complex type that contains information about an Amazon VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone-hostedzonevpcs.html
    /// </summary>
    public class VPC
    {

        /// <summary>
        /// VPCId
        /// 		
        /// (Private hosted zones only) The ID of an Amazon VPC.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VPCId")]
        public Union<string, IntrinsicFunction> VPCId { get; set; }

        /// <summary>
        /// VPCRegion
        /// 		
        /// (Private hosted zones only) The region that an Amazon VPC was created in.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ap-east-1 | ap-northeast-1 | ap-northeast-2 | ap-northeast-3 | ap-south-1 |
        /// ap-southeast-1 | ap-southeast-2 | ca-central-1 | cn-north-1 | eu-central-1 | eu-north-1 | eu-west-1
        /// | eu-west-2 | eu-west-3 | sa-east-1 | us-east-1 | us-east-2 | us-west-1 | us-west-2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VPCRegion")]
        public Union<string, IntrinsicFunction> VPCRegion { get; set; }

    }
}
