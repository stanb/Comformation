using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSetGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html
    /// </summary>
    public class RecordSetGroupResource : ResourceBase
    {
        public class RecordSetGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-comment
            /// </summary>
			public Union<string, IntrinsicFunction> Comment { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-hostedzoneid
            /// </summary>
			public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-hostedzonename
            /// </summary>
			public Union<string, IntrinsicFunction> HostedZoneName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-recordsetgroup.html#cfn-route53-recordsetgroup-recordsets
            /// </summary>
			public Union<List<RecordSet>, IntrinsicFunction> RecordSets { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::RecordSetGroup";
        
        public RecordSetGroupProperties Properties { get; } = new RecordSetGroupProperties();
    }
}
