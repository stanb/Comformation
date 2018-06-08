using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// Route 53 HostedZoneConfig Property
    /// The HostedZoneConfig property is part of the AWS::Route53::HostedZone resource that can contain a comment
    /// about the hosted zone.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-hostedzone-hostedzoneconfig.html
    /// </summary>
    public class HostedZoneConfig
    {

        /// <summary>
        /// Comment
        /// Any comments that you want to include about the hosted zone.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

    }
}
