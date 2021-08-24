using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.DataflowEndpointGroup
{
    /// <summary>
    /// AWS::GroundStation::DataflowEndpointGroup SocketAddress
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-socketaddress.html
    /// </summary>
    public class SocketAddress
    {

        /// <summary>
        /// Name
        /// The name of the endpoint, such as Endpoint 1.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Port
        /// The port of the endpoint, such as 55888.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

    }
}
