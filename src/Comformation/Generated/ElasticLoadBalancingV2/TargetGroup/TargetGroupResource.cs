using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::TargetGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-targetgroup.html
    /// </summary>
    public class TargetGroupResource : ResourceBase
    {
        public class TargetGroupProperties
        {
            /// <summary>
            /// HealthCheckEnabled
            /// Indicates whether health checks are enabled. If the target type is lambda, health checks are
            /// disabled by default but can be enabled. If the target type is instance or ip, health checks are
            /// always enabled and cannot be disabled.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> HealthCheckEnabled { get; set; }

            /// <summary>
            /// HealthCheckIntervalSeconds
            /// The approximate amount of time, in seconds, between health checks of an individual target. If the
            /// target group protocol is TCP, TLS, UDP, or TCP_UDP, the supported values are 10 and 30 seconds. If
            /// the target group protocol is HTTP or HTTPS, the default is 30 seconds. If the target group protocol
            /// is GENEVE, the default is 10 seconds. If the target type is lambda, the default is 35 seconds.
            /// Required: No
            /// Type: Integer
            /// Minimum: 5
            /// Maximum: 300
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// HealthCheckPath
            /// [HTTP/HTTPS health checks] The destination for health checks on the targets.
            /// [HTTP1 or HTTP2 protocol version] The ping path. The default is /.
            /// [GRPC protocol version] The path of a custom health check method with the format /package.
            /// service/method. The default is /AWS. ALB/healthcheck.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HealthCheckPath { get; set; }

            /// <summary>
            /// HealthCheckPort
            /// The port the load balancer uses when performing health checks on targets. If the protocol is HTTP,
            /// HTTPS, TCP, TLS, UDP, or TCP_UDP, the default is traffic-port, which is the port on which each
            /// target receives traffic from the load balancer. If the protocol is GENEVE, the default is port 80.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HealthCheckPort { get; set; }

            /// <summary>
            /// HealthCheckProtocol
            /// The protocol the load balancer uses when performing health checks on targets. For Application Load
            /// Balancers, the default is HTTP. For Network Load Balancers and Gateway Load Balancers, the default
            /// is TCP. The TCP protocol is not supported for health checks if the protocol of the target group is
            /// HTTP or HTTPS. The GENEVE, TLS, UDP, and TCP_UDP protocols are not supported for health checks.
            /// Required: No
            /// Type: String
            /// Allowed values: GENEVE | HTTP | HTTPS | TCP | TCP_UDP | TLS | UDP
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HealthCheckProtocol { get; set; }

            /// <summary>
            /// HealthCheckTimeoutSeconds
            /// The amount of time, in seconds, during which no response from a target means a failed health check.
            /// For target groups with a protocol of HTTP, HTTPS, or GENEVE, the default is 5 seconds. For target
            /// groups with a protocol of TCP or TLS, this value must be 6 seconds for HTTP health checks and 10
            /// seconds for TCP and HTTPS health checks. If the target type is lambda, the default is 30 seconds.
            /// Required: No
            /// Type: Integer
            /// Minimum: 2
            /// Maximum: 120
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthCheckTimeoutSeconds { get; set; }

            /// <summary>
            /// HealthyThresholdCount
            /// The number of consecutive health checks successes required before considering an unhealthy target
            /// healthy. For target groups with a protocol of HTTP or HTTPS, the default is 5. For target groups
            /// with a protocol of TCP, TLS, or GENEVE, the default is 3. If the target type is lambda, the default
            /// is 5.
            /// Required: No
            /// Type: Integer
            /// Minimum: 2
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthyThresholdCount { get; set; }

            /// <summary>
            /// Matcher
            /// [HTTP/HTTPS health checks] The HTTP or gRPC codes to use when checking for a successful response
            /// from a target.
            /// Required: No
            /// Type: Matcher
            /// Update requires: No interruption
            /// </summary>
            public Matcher Matcher { get; set; }

            /// <summary>
            /// Name
            /// The name of the target group.
            /// This name must be unique per region per account, can have a maximum of 32 characters, must contain
            /// only alphanumeric characters or hyphens, and must not begin or end with a hyphen.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Port
            /// The port on which the targets receive traffic. This port is used unless you specify a port override
            /// when registering the target. If the target is a Lambda function, this parameter does not apply. If
            /// the protocol is GENEVE, the supported port is 6081.
            /// Required: Conditional
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 65535
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol to use for routing traffic to the targets. For Application Load Balancers, the
            /// supported protocols are HTTP and HTTPS. For Network Load Balancers, the supported protocols are TCP,
            /// TLS, UDP, or TCP_UDP. For Gateway Load Balancers, the supported protocol is GENEVE. A TCP_UDP
            /// listener must be associated with a TCP_UDP target group. If the target is a Lambda function, this
            /// parameter does not apply.
            /// Required: Conditional
            /// Type: String
            /// Allowed values: GENEVE | HTTP | HTTPS | TCP | TCP_UDP | TLS | UDP
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// ProtocolVersion
            /// [HTTP/HTTPS protocol] The protocol version. The possible values are GRPC, HTTP1, and HTTP2.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProtocolVersion { get; set; }

            /// <summary>
            /// Tags
            /// The tags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TargetGroupAttributes
            /// The attributes.
            /// Required: No
            /// Type: List of TargetGroupAttribute
            /// Update requires: No interruption
            /// </summary>
            public List<TargetGroupAttribute> TargetGroupAttributes { get; set; }

            /// <summary>
            /// TargetType
            /// The type of target that you must specify when registering targets with this target group. You can&#39;t
            /// specify targets for a target group using more than one target type.
            /// instance - Register targets by instance ID. This is the default value. ip - Register targets by IP
            /// address. You can specify IP addresses from the subnets of the virtual private cloud (VPC) for the
            /// target group, the RFC 1918 range (10. 0. 0. 0/8, 172. 16. 0. 0/12, and 192. 168. 0. 0/16), and the
            /// RFC 6598 range (100. 64. 0. 0/10). You can&#39;t specify publicly routable IP addresses. lambda -
            /// Register a single Lambda function as a target.
            /// Required: No
            /// Type: String
            /// Allowed values: instance | ip | lambda
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetType { get; set; }

            /// <summary>
            /// Targets
            /// The targets.
            /// Required: No
            /// Type: List of TargetDescription
            /// Update requires: No interruption
            /// </summary>
            public List<TargetDescription> Targets { get; set; }

            /// <summary>
            /// UnhealthyThresholdCount
            /// The number of consecutive health check failures required before considering a target unhealthy. If
            /// the target group protocol is HTTP or HTTPS, the default is 2. If the target group protocol is TCP or
            /// TLS, this value must be the same as the healthy threshold count. If the target group protocol is
            /// GENEVE, the default is 3. If the target type is lambda, the default is 2.
            /// Required: No
            /// Type: Integer
            /// Minimum: 2
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> UnhealthyThresholdCount { get; set; }

            /// <summary>
            /// VpcId
            /// The identifier of the virtual private cloud (VPC). If the target is a Lambda function, this
            /// parameter does not apply. Otherwise, this parameter is required.
            /// Required: Conditional
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
