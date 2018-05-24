using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html
    /// </summary>
    public class HostedZoneResource : ResourceBase
    {
        public class HostedZoneProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzoneconfig
            /// </summary>
			public Union<HostedZoneConfig, IntrinsicFunction> HostedZoneConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzonetags
            /// </summary>
			public Union<List<HostedZoneTag>, IntrinsicFunction> HostedZoneTags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-queryloggingconfig
            /// </summary>
			public Union<QueryLoggingConfig, IntrinsicFunction> QueryLoggingConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-vpcs
            /// </summary>
			public Union<List<VPC>, IntrinsicFunction> VPCs { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::HostedZone";
        
        public HostedZoneProperties Properties { get; } = new HostedZoneProperties();
    }

	public static class HostedZoneAttributes
	{
        public static readonly ResourceAttribute<List<string>> NameServers = new ResourceAttribute<List<string>>("NameServers");
	}
}
