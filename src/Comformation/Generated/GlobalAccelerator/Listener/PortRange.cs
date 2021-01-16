using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GlobalAccelerator.Listener
{
    /// <summary>
    /// AWS::GlobalAccelerator::Listener PortRange
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-listener-portrange.html
    /// </summary>
    public class PortRange
    {

        /// <summary>
        /// FromPort
        /// 		
        /// The first port in the range of ports, inclusive.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// ToPort
        /// 		
        /// The last port in the range of ports, inclusive.
        /// 	
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
