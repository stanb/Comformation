using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html
    /// </summary>
    public class LoadBalancerResource : ResourceBase
    {
        public class LoadBalancerProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-accessloggingpolicy
            /// </summary>
			public Union<AccessLoggingPolicy, IntrinsicFunction> AccessLoggingPolicy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-appcookiestickinesspolicy
            /// </summary>
			public Union<List<AppCookieStickinessPolicy>, IntrinsicFunction> AppCookieStickinessPolicy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-availabilityzones
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AvailabilityZones { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-connectiondrainingpolicy
            /// </summary>
			public Union<ConnectionDrainingPolicy, IntrinsicFunction> ConnectionDrainingPolicy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-connectionsettings
            /// </summary>
			public Union<ConnectionSettings, IntrinsicFunction> ConnectionSettings { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-crosszone
            /// </summary>
			public Union<bool, IntrinsicFunction> CrossZone { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-healthcheck
            /// </summary>
			public Union<HealthCheck, IntrinsicFunction> HealthCheck { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-instances
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Instances { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-lbcookiestickinesspolicy
            /// </summary>
			public Union<List<LBCookieStickinessPolicy>, IntrinsicFunction> LBCookieStickinessPolicy { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-listeners
            /// </summary>
			public Union<List<Listeners>, IntrinsicFunction> Listeners { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-elbname
            /// </summary>
			public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-policies
            /// </summary>
			public Union<List<Policies>, IntrinsicFunction> Policies { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-scheme
            /// </summary>
			public Union<string, IntrinsicFunction> Scheme { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-securitygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-ec2-elb-subnets
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Subnets { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html#cfn-elasticloadbalancing-loadbalancer-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticLoadBalancing::LoadBalancer";
        
        public LoadBalancerProperties Properties { get; } = new LoadBalancerProperties();
    }

	public static class LoadBalancerAttributes
	{
        public static readonly ResourceAttribute<string> CanonicalHostedZoneName = new ResourceAttribute<string>("CanonicalHostedZoneName");
        public static readonly ResourceAttribute<string> CanonicalHostedZoneNameID = new ResourceAttribute<string>("CanonicalHostedZoneNameID");
        public static readonly ResourceAttribute<string> DNSName = new ResourceAttribute<string>("DNSName");
        public static readonly ResourceAttribute<string> SourceSecurityGroup_GroupName = new ResourceAttribute<string>("SourceSecurityGroup", "GroupName");
        public static readonly ResourceAttribute<string> SourceSecurityGroup_OwnerAlias = new ResourceAttribute<string>("SourceSecurityGroup", "OwnerAlias");
	}
}
