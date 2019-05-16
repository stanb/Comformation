using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSetGroup
{
    /// <summary>
    /// AWS::Route53::RecordSetGroup
    /// A complex type that contains an optional comment, the name and ID of the hosted zone that you want to make
    /// changes in, 			and values for the resource record sets that you want to add, update, or delete.
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
            /// The ID of the hosted zone that contains the resource record sets that you want to change.
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
            /// The name of the hosted zone that you want to create, update, or delete resource record sets in.
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
            /// A complex type that contains one RecordSet element for each resource record set that you want to
            /// add, update, or delete.
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
