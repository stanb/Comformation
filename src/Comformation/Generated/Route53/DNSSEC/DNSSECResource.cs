using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.DNSSEC
{
    /// <summary>
    /// AWS::Route53::DNSSEC
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-dnssec.html
    /// </summary>
    public class DNSSECResource : ResourceBase
    {
        public class DNSSECProperties
        {
            /// <summary>
            /// HostedZoneId
            /// A unique string (ID) that is used to identify a hosted zone. For example: Z00001111A1ABCaaABC11.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

        }

        public string Type { get; } = "AWS::Route53::DNSSEC";

        public DNSSECProperties Properties { get; } = new DNSSECProperties();

    }
}
