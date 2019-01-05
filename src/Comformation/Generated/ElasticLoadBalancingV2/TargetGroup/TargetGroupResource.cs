using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::TargetGroup
    /// The AWS::ElasticLoadBalancingV2::TargetGroup resource creates an Elastic Load Balancing target group that
    /// routes requests to one or more registered targets, such as EC2 instances. For more information, see Getting
    /// Started in the Elastic Load Balancing User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html
    /// </summary>
    public class TargetGroupResource : ResourceBase
    {
        public class TargetGroupProperties
        {
            /// <summary>
            /// HealthCheckIntervalSeconds
            /// The approximate number of seconds between health checks for an individual target.
            /// For valid and default values, see the HealthCheckIntervalSeconds parameter for the CreateTargetGroup
            /// action in the Elastic Load Balancing API Reference version 2015-12-01.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// HealthCheckPath
            /// [HTTP/HTTPS health checks] The ping path destination where Elastic Load Balancing sends health check
            /// requests. The default is /.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckPath { get; set; }

            /// <summary>
            /// HealthCheckPort
            /// The port that the load balancer uses when performing health checks on the targets.
            /// For valid and default values, see the HealthCheckPort parameter for the CreateTargetGroup action in
            /// the Elastic Load Balancing API Reference version 2015-12-01.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckPort { get; set; }

            /// <summary>
            /// HealthCheckProtocol
            /// The protocol that the load balancer uses when performing health checks on the targets, such as HTTP
            /// or HTTPS.
            /// For valid and default values, see the HealthCheckProtocol parameter for the CreateTargetGroup action
            /// in the Elastic Load Balancing API Reference version 2015-12-01.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckProtocol { get; set; }

            /// <summary>
            /// HealthCheckTimeoutSeconds
            /// The number of seconds to wait for a response before considering that a health check has failed. For
            /// Application Load Balancers, the range is 2–60 seconds and the default is 5 seconds. For Network Load
            /// Balancers, this value is 10 seconds for TCP and HTTPS health checks and 6 seconds for HTTP health
            /// checks.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HealthCheckTimeoutSeconds { get; set; }

            /// <summary>
            /// HealthyThresholdCount
            /// The number of consecutive successful health checks that are required before an unhealthy target is
            /// considered healthy.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HealthyThresholdCount { get; set; }

            /// <summary>
            /// Matcher
            /// [HTTP/HTTPS health checks] The HTTP codes that a healthy target uses when responding to a health
            /// check.
            /// For more information about specifying this property, see Matcher in the Elastic Load Balancing API
            /// Reference version 2015-12-01.
            /// Required: No
            /// Type: Elastic Load Balancing TargetGroup Matcher
            /// Update requires: No interruption
            /// </summary>
			public Matcher Matcher { get; set; }

            /// <summary>
            /// Name
            /// A name for the target group.
            /// Important This name must be unique per account, per region. The target group name should be shorter
            /// than 32 characters because AWS CloudFormation uses the target group name to create the name of the
            /// load balancer.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Port
            /// The port on which the targets receive traffic.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol to use for routing traffic to the targets.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for the target group. Use tags to help manage resources.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption.
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TargetGroupAttributes
            /// Target group configurations.
            /// Required: No
            /// Type: List of Elastic Load Balancing TargetGroup TargetGroupAttributes
            /// Update requires: No interruption
            /// </summary>
			public List<TargetGroupAttribute> TargetGroupAttributes { get; set; }

            /// <summary>
            /// TargetType
            /// The registration type of the targets in this target group. Valid values are instance and ip. The
            /// default is instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// Targets
            /// The targets to add to this target group.
            /// Required: No
            /// Type: List of Elastic Load Balancing TargetGroup TargetDescription
            /// Update requires: No interruption
            /// </summary>
			public List<TargetDescription> Targets { get; set; }

            /// <summary>
            /// UnhealthyThresholdCount
            /// The number of consecutive failed health checks that are required before a target is considered
            /// unhealthy.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> UnhealthyThresholdCount { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC in which your targets are located.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::TargetGroup";

        public TargetGroupProperties Properties { get; } = new TargetGroupProperties();

    }

	public static class TargetGroupAttributes
	{
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> LoadBalancerArns = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("LoadBalancerArns");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TargetGroupFullName = new ResourceAttribute<Union<string, IntrinsicFunction>>("TargetGroupFullName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TargetGroupName = new ResourceAttribute<Union<string, IntrinsicFunction>>("TargetGroupName");
	}
}
