using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGatewayConnect
{
    /// <summary>
    /// AWS::EC2::TransitGatewayConnect TransitGatewayConnectOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnect-transitgatewayconnectoptions.html
    /// </summary>
    public class TransitGatewayConnectOptions
    {

        /// <summary>
        /// Protocol
        /// The tunnel protocol.
        /// Required: No
        /// Type: String
        /// Allowed values: gre
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
