using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GlobalAccelerator.EndpointGroup
{
    /// <summary>
    /// AWS::GlobalAccelerator::EndpointGroup PortOverride
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-portoverride.html
    /// </summary>
    public class PortOverride
    {

        /// <summary>
        /// ListenerPort
        /// 		
        /// The listener port that you want to map to a specific endpoint port. This is the port that user
        /// traffic 		arrives to the Global Accelerator on.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ListenerPort")]
        public Union<int, IntrinsicFunction> ListenerPort { get; set; }

        /// <summary>
        /// EndpointPort
        /// 		
        /// The endpoint port that you want a listener port to be mapped to. This is the port on the endpoint,
        /// 			such as the Application Load Balancer or Amazon EC2 instance.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointPort")]
        public Union<int, IntrinsicFunction> EndpointPort { get; set; }

    }
}
