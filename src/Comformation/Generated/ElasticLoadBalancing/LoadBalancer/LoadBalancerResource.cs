using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer
    /// Specifies a Classic Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html
    /// </summary>
    public class LoadBalancerResource : ResourceBase
    {
        public class LoadBalancerProperties
        {
            /// <summary>
            /// AccessLoggingPolicy
            /// Information about where and how access logs are stored for the load balancer.
            /// Required: No
            /// Type: AccessLoggingPolicy
            /// Update requires: No interruption
            /// </summary>
			public AccessLoggingPolicy AccessLoggingPolicy { get; set; }

            /// <summary>
            /// AppCookieStickinessPolicy
            /// Information about a policy for application-controlled session stickiness.
            /// Required: No
            /// Type: List of AppCookieStickinessPolicy
            /// Update requires: No interruption
            /// </summary>
			public List<AppCookieStickinessPolicy> AppCookieStickinessPolicy { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// The Availability Zones for the load balancer. For load balancers in a VPC, specify Subnets instead.
            /// Update requires replacement if you did not previously specify an Availability Zone or if you are
            /// removing all Availability Zones. Otherwise, update requires no interruption.
            /// Required: No
            /// Type: List of String
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// ConnectionDrainingPolicy
            /// If enabled, the load balancer allows existing requests to complete before the load balancer shifts
            /// traffic away from a deregistered or unhealthy instance.
            /// For more information, see Configure Connection Draining in the Classic Load Balancers Guide.
            /// Required: No
            /// Type: ConnectionDrainingPolicy
            /// Update requires: No interruption
            /// </summary>
			public ConnectionDrainingPolicy ConnectionDrainingPolicy { get; set; }

            /// <summary>
            /// ConnectionSettings
            /// If enabled, the load balancer allows the connections to remain idle (no data is sent over the
            /// connection) for the specified duration.
            /// By default, Elastic Load Balancing maintains a 60-second idle connection timeout for both front-end
            /// and back-end connections of your load balancer. For more information, see Configure Idle Connection
            /// Timeout in the Classic Load Balancers Guide.
            /// Required: No
            /// Type: ConnectionSettings
            /// Update requires: No interruption
            /// </summary>
			public ConnectionSettings ConnectionSettings { get; set; }

            /// <summary>
            /// CrossZone
            /// If enabled, the load balancer routes the request traffic evenly across all instances regardless of
            /// the Availability Zones.
            /// For more information, see Configure Cross-Zone Load Balancing in the Classic Load Balancers Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> CrossZone { get; set; }

            /// <summary>
            /// HealthCheck
            /// The health check settings to use when evaluating the health of your EC2 instances.
            /// Update requires replacement if you did not previously specify health check settings or if you are
            /// removing the health check settings. Otherwise, update requires no interruption.
            /// Required: No
            /// Type: HealthCheck
            /// </summary>
			public HealthCheck HealthCheck { get; set; }

            /// <summary>
            /// Instances
            /// The IDs of the instances for the load balancer.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Instances { get; set; }

            /// <summary>
            /// LBCookieStickinessPolicy
            /// Information about a policy for duration-based session stickiness.
            /// Required: No
            /// Type: List of LBCookieStickinessPolicy
            /// Update requires: No interruption
            /// </summary>
			public List<LBCookieStickinessPolicy> LBCookieStickinessPolicy { get; set; }

            /// <summary>
            /// Listeners
            /// The listeners for the load balancer. You can specify at most one listener per port.
            /// If you update the properties for a listener, AWS CloudFormation deletes the existing listener and
            /// creates a new one with the specified properties. While the new listener is being created, clients
            /// cannot connect to the load balancer.
            /// Required: Yes
            /// Type: List of Listeners
            /// Update requires: No interruption
            /// </summary>
			public List<Listeners> Listeners { get; set; }

            /// <summary>
            /// LoadBalancerName
            /// The name of the load balancer. This name must be unique within your set of load balancers for the
            /// region.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID for the load
            /// balancer. For more information, see Name Type. If you specify a name, you cannot perform updates
            /// that require replacement of this resource, but you can perform other updates. To replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

            /// <summary>
            /// Policies
            /// The policies defined for your Classic Load Balancer. Specify only back-end server policies.
            /// Required: No
            /// Type: List of Policies
            /// Update requires: No interruption
            /// </summary>
			public List<Policies> Policies { get; set; }

            /// <summary>
            /// Scheme
            /// The type of load balancer. Valid only for load balancers in a VPC.
            /// If Scheme is internet-facing, the load balancer has a public DNS name that resolves to a public IP
            /// address.
            /// If Scheme is internal, the load balancer has a public DNS name that resolves to a private IP
            /// address.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Scheme { get; set; }

            /// <summary>
            /// SecurityGroups
            /// The security groups for the load balancer. Valid only for load balancers in a VPC.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// Subnets
            /// The IDs of the subnets for the load balancer. You can specify at most one subnet per Availability
            /// Zone.
            /// Update requires replacement if you did not previously specify a subnet or if you are removing all
            /// subnets. Otherwise, update requires no interruption. To update to a different subnet in the current
            /// Availability Zone, you must first update to a subnet in a different Availability Zone, then update
            /// to the new subnet in the original Availability Zone.
            /// Required: No
            /// Type: List of String
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

            /// <summary>
            /// Tags
            /// The tags associated with a load balancer.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancing::LoadBalancer";

        public LoadBalancerProperties Properties { get; } = new LoadBalancerProperties();

    }

	public static class LoadBalancerAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CanonicalHostedZoneName = new ResourceAttribute<Union<string, IntrinsicFunction>>("CanonicalHostedZoneName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CanonicalHostedZoneNameID = new ResourceAttribute<Union<string, IntrinsicFunction>>("CanonicalHostedZoneNameID");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DNSName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DNSName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SourceSecurityGroup_GroupName = new ResourceAttribute<Union<string, IntrinsicFunction>>("SourceSecurityGroup", "GroupName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SourceSecurityGroup_OwnerAlias = new ResourceAttribute<Union<string, IntrinsicFunction>>("SourceSecurityGroup", "OwnerAlias");
	}
}
