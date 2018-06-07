using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSetGroup
{
    /// <summary>
    /// AWS::Route53::RecordSetGroup
    /// The AWS::Route53::RecordSetGroup resource creates record sets for a hosted zone. For more information about
    /// constraints and values for each property, see POST CreateHostedZone for hosted zones and POST
    /// ChangeResourceRecordSet for resource record sets.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup.html
    /// </summary>
    public class RecordSetGroupResource : ResourceBase
    {
        public class RecordSetGroupProperties
        {
            /// <summary>
            /// Comment
            /// Any comments you want to include about the hosted zone.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup.html#cfn-route53-recordsetgroup-comment
            /// </summary>
			public Union<string, IntrinsicFunction> Comment { get; set; }

            /// <summary>
            /// HostedZoneId
            /// The ID of the hosted zone.
            /// Required: Conditional: You must specify either the HostedZoneName or HostedZoneId, but you cannot
            /// specify both.
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup.html#cfn-route53-recordsetgroup-hostedzoneid
            /// </summary>
			public Union<string, IntrinsicFunction> HostedZoneId { get; set; }

            /// <summary>
            /// HostedZoneName
            /// The name of the domain for the hosted zone where you want to add the record set.
            /// When you create a stack using an AWS::Route53::RecordSet that specifies HostedZoneName, AWS
            /// CloudFormation attempts to find a hosted zone whose name matches the HostedZoneName. If AWS
            /// CloudFormation cannot find a hosted zone with a matching domain name, or if there is more than one
            /// hosted zone with the specified domain name, AWS CloudFormation will not create the stack.
            /// If you have multiple hosted zones with the same domain name, you must explicitly specify the hosted
            /// zone using HostedZoneId.
            /// Required: Conditional. You must specify either the HostedZoneName or HostedZoneId, but you cannot
            /// specify both.
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup.html#cfn-route53-recordsetgroup-hostedzonename
            /// </summary>
			public Union<string, IntrinsicFunction> HostedZoneName { get; set; }

            /// <summary>
            /// RecordSets
            /// List of resource record sets to add. The maximum number of records is 1,000.
            /// Required: Yes
            /// Type:: List of AWS::Route53::RecordSet objects, as shown in the following example:
            /// "RecordSets" : [ { "Name" : "mysite. example. com. ", "Type" : "CNAME", "TTL" : "900",
            /// "SetIdentifier" : "Frontend One", "Weight" : "4", "ResourceRecords" : ["example-ec2. amazonaws.
            /// com"] }, { "Name" : "mysite. example. com. ", "Type" : "CNAME", "TTL" : "900", "SetIdentifier" :
            /// "Frontend Two", "Weight" : "6", "ResourceRecords" : ["example-ec2-larger. amazonaws. com"] } ]
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordsetgroup.html#cfn-route53-recordsetgroup-recordsets
            /// </summary>
			public Union<List<RecordSet>, IntrinsicFunction> RecordSets { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::RecordSetGroup";
        
        public RecordSetGroupProperties Properties { get; } = new RecordSetGroupProperties();
    }
}
