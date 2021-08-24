using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSetGroup
{
    /// <summary>
    /// AWS::Route53::RecordSetGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html
    /// </summary>
    public class RecordSetGroupResource : ResourceBase
    {
        public class RecordSetGroupProperties
        {
            /// <summary>
            /// Comment
            /// 		
            /// Optional: Any comments you want to include about a change batch 			request.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Comment { get; set; }

            /// <summary>
            /// HostedZoneId
            /// 		
            /// The ID of the hosted zone that you want to create records in.
            /// 		
            /// Specify either HostedZoneName or HostedZoneId, but not both. If you have multiple hosted zones
            /// 			with the same domain name, you must specify the hosted zone using HostedZoneId.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 32
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

            /// <summary>
            /// HostedZoneName
            /// 	
            /// The name of the hosted zone that you want to create records in. You must include a trailing dot (for
            /// example, www. example. com. ) as part of the HostedZoneName.
            /// 		
            /// When you create a stack using an AWS::Route53::RecordSet that specifies HostedZoneName, 			AWS
            /// CloudFormation attempts to find a hosted zone whose name matches the HostedZoneName. If AWS
            /// CloudFormation 			can&#39;t find a hosted zone with a matching domain name, or if there is more than one
            /// hosted zone with the specified domain name, 			AWS CloudFormation will not create the stack.
            /// 		
            /// Specify either HostedZoneName or HostedZoneId, but not both. If you have multiple hosted zones
            /// 			with the same domain name, you must specify the hosted zone using HostedZoneId.
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> HostedZoneName { get; set; }

            /// <summary>
            /// RecordSets
            /// 		
            /// A complex type that contains one RecordSet element for each record that you want to create.
            /// 	
            /// Required: No
            /// Type: List of RecordSet
            /// Update requires: No interruption
            /// </summary>
            public List<RecordSet> RecordSets { get; set; }

        }

        public string Type { get; } = "AWS::Route53::RecordSetGroup";

        public RecordSetGroupProperties Properties { get; } = new RecordSetGroupProperties();

    }
}
