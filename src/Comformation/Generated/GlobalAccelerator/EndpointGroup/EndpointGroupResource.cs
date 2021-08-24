using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GlobalAccelerator.EndpointGroup
{
    /// <summary>
    /// AWS::GlobalAccelerator::EndpointGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html
    /// </summary>
    public class EndpointGroupResource : ResourceBase
    {
        public class EndpointGroupProperties
        {
            /// <summary>
            /// ListenerArn
            /// 		
            /// The Amazon Resource Name (ARN) of the listener.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ListenerArn { get; set; }

            /// <summary>
            /// EndpointGroupRegion
            /// 	 	
            /// The AWS Regions where the endpoint group is located.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointGroupRegion { get; set; }

            /// <summary>
            /// EndpointConfigurations
            /// 		
            /// The list of endpoint objects.
            /// 	
            /// Required: No
            /// Type: List of EndpointConfiguration
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public List<EndpointConfiguration> EndpointConfigurations { get; set; }

            /// <summary>
            /// TrafficDialPercentage
            /// 		
            /// The percentage of traffic to send to an AWS Regions. Additional traffic is distributed to other
            /// endpoint groups for 			this listener.
            /// 		
            /// Use this action to increase (dial up) or decrease (dial down) traffic to a specific Region. The
            /// percentage is 			applied to the traffic that would otherwise have been routed to the Region based on
            /// optimal routing.
            /// 		
            /// The default value is 100.
            /// 	
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> TrafficDialPercentage { get; set; }

            /// <summary>
            /// HealthCheckPort
            /// 		
            /// The port that Global Accelerator uses to perform health checks on endpoints that are part of this
            /// endpoint group.
            /// 		 		
            /// The default port is the port for the listener that this endpoint group is associated with. If the
            /// listener port is a 			list, Global Accelerator uses the first specified port in the list of ports.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 65535
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthCheckPort { get; set; }

            /// <summary>
            /// HealthCheckProtocol
            /// 		
            /// The protocol that Global Accelerator uses to perform health checks on endpoints that are part of
            /// this endpoint group. The default 			value is TCP.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: HTTP | HTTPS | TCP
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HealthCheckProtocol { get; set; }

            /// <summary>
            /// HealthCheckPath
            /// 		
            /// If the protocol is HTTP/S, then this value provides the ping path that Global Accelerator uses for
            /// the destination on the 			endpoints for health checks. The default is slash (/).
            /// 	
            /// Required: No
            /// Type: String
            /// Maximum: 255
            /// Pattern: ^/[-a-zA-Z0-9@:%_\\+. ~#?&amp;amp;/=]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HealthCheckPath { get; set; }

            /// <summary>
            /// HealthCheckIntervalSeconds
            /// 		
            /// The time—10 seconds or 30 seconds—between health checks for each endpoint. The default value is 30.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Minimum: 10
            /// Maximum: 30
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthCheckIntervalSeconds { get; set; }

            /// <summary>
            /// ThresholdCount
            /// 		
            /// The number of consecutive health checks required to set the state of a healthy endpoint to
            /// unhealthy, or to set an 			unhealthy endpoint to healthy. The default value is 3.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ThresholdCount { get; set; }

            /// <summary>
            /// PortOverrides
            /// 		
            /// Allows you to override the destination ports used to route traffic to an endpoint. 			Using a port
            /// override lets you to map a list of external destination ports (that your 			users send traffic to)
            /// to a list of internal destination ports that you want an application 			endpoint to receive traffic
            /// on.
            /// 	
            /// Required: No
            /// Type: List of PortOverride
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public List<PortOverride> PortOverrides { get; set; }

        }

        public string Type { get; } = "AWS::GlobalAccelerator::EndpointGroup";

        public EndpointGroupProperties Properties { get; } = new EndpointGroupProperties();

    }

    public static class EndpointGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EndpointGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("EndpointGroupArn");
    }
}
