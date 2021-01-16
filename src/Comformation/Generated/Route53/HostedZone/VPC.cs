using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone VPC
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-vpc.html
    /// </summary>
    public class VPC
    {

        /// <summary>
        /// VPCId
        /// 		
        /// Private hosted zones only: The ID of an Amazon VPC.
        /// 		
        /// Note For public hosted zones, omit VPCs, VPCId, and VPCRegion.
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
        /// Private hosted zones only: The region that an Amazon VPC was created in.
        /// 		
        /// Note For public hosted zones, omit VPCs, VPCId, and VPCRegion.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: af-south-1 | ap-east-1 | ap-northeast-1 | ap-northeast-2 | ap-northeast-3 |
        /// ap-south-1 | ap-southeast-1 | ap-southeast-2 | ca-central-1 | cn-north-1 | eu-central-1 | eu-north-1
        /// | eu-south-1 | eu-west-1 | eu-west-2 | eu-west-3 | me-south-1 | sa-east-1 | us-east-1 | us-east-2 |
        /// us-gov-east-1 | us-gov-west-1 | us-iso-east-1 | us-isob-east-1 | us-west-1 | us-west-2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VPCRegion")]
        public Union<string, IntrinsicFunction> VPCRegion { get; set; }

    }
}
