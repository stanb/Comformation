using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone HostedZoneConfig
    /// A complex type that contains an optional comment about your hosted zone. If you don&#39;t 			want to specify a
    /// comment, omit both the HostedZoneConfig and 			Comment elements.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzoneconfig.html
    /// </summary>
    public class HostedZoneConfig
    {

        /// <summary>
        /// Comment
        /// 		
        /// Any comments that you want to include about the hosted zone.
        /// 	
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

    }
}
