using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server EndpointDetails
    /// The virtual private cloud (VPC) endpoint settings that you want to configure for your SFTP server. This
    /// parameter is required when you specify a value for the EndpointType parameter.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html
    /// </summary>
    public class EndpointDetails
    {

        /// <summary>
        /// VpcEndpointId
        /// The ID of the VPC endpoint.
        /// Required: Yes
        /// Type: String
        /// Pattern: ^vpce-[0-9a-f]{17}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcEndpointId")]
        public Union<string, IntrinsicFunction> VpcEndpointId { get; set; }

    }
}
