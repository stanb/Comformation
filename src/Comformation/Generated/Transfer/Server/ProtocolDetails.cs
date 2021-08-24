using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server ProtocolDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-protocoldetails.html
    /// </summary>
    public class ProtocolDetails
    {

        /// <summary>
        /// PassiveIp
        /// Indicates passive mode, for FTP and FTPS protocols. Enter a single dotted-quad IPv4 address, such as
        /// the external IP address of a firewall, router, or load balancer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PassiveIp")]
        public Union<string, IntrinsicFunction> PassiveIp { get; set; }

    }
}
