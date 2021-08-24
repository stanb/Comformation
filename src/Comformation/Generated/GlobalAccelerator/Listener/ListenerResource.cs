using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GlobalAccelerator.Listener
{
    /// <summary>
    /// AWS::GlobalAccelerator::Listener
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-listener.html
    /// </summary>
    public class ListenerResource : ResourceBase
    {
        public class ListenerProperties
        {
            /// <summary>
            /// AcceleratorArn
            /// 		
            /// The Amazon Resource Name (ARN) of your accelerator.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AcceleratorArn { get; set; }

            /// <summary>
            /// PortRanges
            /// 		
            /// The list of port ranges for the connections from clients to the accelerator.
            /// 	
            /// Required: Yes
            /// Type: List of PortRange
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public List<PortRange> PortRanges { get; set; }

            /// <summary>
            /// Protocol
            /// 		
            /// The protocol for the connections from clients to the accelerator.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: TCP | UDP
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// ClientAffinity
            /// 		
            /// Client affinity lets you direct all requests from a user to the same endpoint, if you have stateful
            /// applications, 			regardless of the port and protocol of the client request. Client affinity gives
            /// you control over whether to always 			route each client to the same specific endpoint.
            /// AWS Global Accelerator uses a consistent-flow hashing algorithm to choose the optimal endpoint for a
            /// connection. If client 			affinity is NONE, Global Accelerator uses the &quot;five-tuple&quot; (5-tuple)
            /// properties—source IP address, source port, 			destination IP address, destination port, and
            /// protocol—to select the hash value, and then chooses the best 			endpoint. However, with this
            /// setting, if someone uses different ports to connect to Global Accelerator, their connections might
            /// not 			be always routed to the same endpoint because the hash value changes.
            /// 		
            /// If you want a given client to always be routed to the same endpoint, set client affinity to
            /// SOURCE_IP 			instead. When you use the SOURCE_IP setting, Global Accelerator uses the &quot;two-tuple&quot;
            /// (2-tuple) properties— 			source (client) IP address and destination IP address—to select the hash
            /// value.
            /// 		
            /// The default value is NONE.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: NONE | SOURCE_IP
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ClientAffinity { get; set; }

        }

        public string Type { get; } = "AWS::GlobalAccelerator::Listener";

        public ListenerProperties Properties { get; } = new ListenerProperties();

    }

    public static class ListenerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ListenerArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ListenerArn");
    }
}
