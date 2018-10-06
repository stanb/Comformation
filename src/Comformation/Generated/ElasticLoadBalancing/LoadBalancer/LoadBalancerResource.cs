using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer
    /// The AWS::ElasticLoadBalancing::LoadBalancer type creates a LoadBalancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb.html
    /// </summary>
    public class LoadBalancerResource : ResourceBase
    {
        public class LoadBalancerProperties
        {
            /// <summary>
            /// AccessLoggingPolicy
            /// Captures detailed information for all requests made to your load balancer, such as the time a
            /// request was received, client’s IP address, latencies, request path, and server responses.
            /// Required: No
            /// Type: Elastic Load Balancing AccessLoggingPolicy
            /// Update requires: No interruption
            /// </summary>
			public AccessLoggingPolicy AccessLoggingPolicy { get; set; }

            /// <summary>
            /// AppCookieStickinessPolicy
            /// Generates one or more stickiness policies with sticky session lifetimes that follow that of an
            /// application-generated cookie. These policies can be associated only with HTTP/HTTPS listeners.
            /// Required: No
            /// Type: A list of AppCookieStickinessPolicy objects.
            /// Update requires: No interruption
            /// </summary>
			public List<AppCookieStickinessPolicy> AppCookieStickinessPolicy { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// The Availability Zones in which to create the load balancer. You can specify the AvailabilityZones
            /// or Subnets property, but not both.
            /// Note For load balancers that are in a VPC, specify the Subnets property.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement if you did not have an Availability Zone specified and you are adding
            /// one or if you are removing all Availability Zones. Otherwise, update requires no interruption.
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// ConnectionDrainingPolicy
            /// Whether deregistered or unhealthy instances can complete all in-flight requests.
            /// Required: No
            /// Type: Elastic Load Balancing ConnectionDrainingPolicy
            /// Update requires: No interruption
            /// </summary>
			public ConnectionDrainingPolicy ConnectionDrainingPolicy { get; set; }

            /// <summary>
            /// ConnectionSettings
            /// Specifies how long front-end and back-end connections of your load balancer can remain idle.
            /// Required: No
            /// Type: Elastic Load Balancing ConnectionSettings
            /// Update requires: No interruption
            /// </summary>
			public ConnectionSettings ConnectionSettings { get; set; }

            /// <summary>
            /// CrossZone
            /// Whether cross-zone load balancing is enabled for the load balancer. With cross-zone load balancing,
            /// your load balancer nodes route traffic to the back-end instances across all Availability Zones. By
            /// default the CrossZone property is false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> CrossZone { get; set; }

            /// <summary>
            /// HealthCheck
            /// Application health check for the instances.
            /// Required: No
            /// Type: ElasticLoadBalancing LoadBalancer HealthCheck.
            /// Update requires: Replacement if you did not have a health check specified and you are adding one or
            /// if you are removing a health check. Otherwise, update requires no interruption.
            /// </summary>
			public HealthCheck HealthCheck { get; set; }

            /// <summary>
            /// Instances
            /// A list of EC2 instance IDs for the load balancer.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Instances { get; set; }

            /// <summary>
            /// LBCookieStickinessPolicy
            /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the
            /// browser (user-agent), or by a specified expiration period. This policy can be associated only with
            /// HTTP/HTTPS listeners.
            /// Required: No
            /// Type: A list of LBCookieStickinessPolicy objects.
            /// Update requires: No interruption
            /// </summary>
			public List<LBCookieStickinessPolicy> LBCookieStickinessPolicy { get; set; }

            /// <summary>
            /// Listeners
            /// One or more listeners for this load balancer. Each listener must be registered for a specific port,
            /// and you cannot have more than one listener for a given port.
            /// Important If you update the property values for a listener specified by the Listeners property, AWS
            /// CloudFormation will delete the existing listener and create a new one with the updated properties.
            /// During the time that AWS CloudFormation is performing this action, clients will not be able to
            /// connect to the load balancer.
            /// Required: Yes
            /// Type: A list of ElasticLoadBalancing Listener Property Type objects.
            /// Update requires: No interruption
            /// </summary>
			public List<Listeners> Listeners { get; set; }

            /// <summary>
            /// LoadBalancerName
            /// A name for the load balancer. For valid values, see the LoadBalancerName parameter for the
            /// CreateLoadBalancer action in the Elastic Load Balancing API Reference version 2012-06-01.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for
            /// the load balancer. The name must be unique within your set of load balancers. For more information,
            /// see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LoadBalancerName { get; set; }

            /// <summary>
            /// Policies
            /// A list of elastic load balancing policies to apply to this elastic load balancer. Specify only
            /// back-end server policies. For more information, see DescribeLoadBalancerPolicyTypes in the Elastic
            /// Load Balancing API Reference version 2012-06-01.
            /// Required: No
            /// Type: A list of ElasticLoadBalancing policy objects.
            /// Update requires: No interruption
            /// </summary>
			public List<Policies> Policies { get; set; }

            /// <summary>
            /// Scheme
            /// For load balancers attached to an Amazon VPC, this parameter can be used to specify the type of load
            /// balancer to use. Specify internal to create an internal load balancer with a DNS name that resolves
            /// to private IP addresses or internet-facing to create a load balancer with a publicly resolvable DNS
            /// name, which resolves to public IP addresses.
            /// Note If you specify internal, you must specify subnets to associate with the load balancer, not
            /// Availability Zones.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Scheme { get; set; }

            /// <summary>
            /// SecurityGroups
            /// Required: No
            /// Type: A list of security groups assigned to your load balancer within your virtual private cloud
            /// (VPC).
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// Subnets
            /// A list of subnet IDs in your virtual private cloud (VPC) to attach to your load balancer. Do not
            /// specify multiple subnets that are in the same Availability Zone. You can specify the
            /// AvailabilityZones or Subnets property, but not both.
            /// For more information about using Elastic Load Balancing in a VPC, see How Do I Use Elastic Load
            /// Balancing in Amazon VPC in the Elastic Load Balancing Developer Guide.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement if you did not have a subnet specified and you are adding one or if you
            /// are removing all subnets. Otherwise, update requires no interruption. To update the load balancer to
            /// another subnet that is in the same Availability Zone, you must do two updates. You must first update
            /// the load balancer to use a subnet in different Availability Zone. After the update is complete,
            /// update the load balancer to use the new subnet that is in the original Availability Zone.
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for this load balancer.
            /// Required: No
            /// Type: Resource Tag
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
