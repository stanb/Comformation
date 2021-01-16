using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server EndpointDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html
    /// </summary>
    public class EndpointDetails
    {

        /// <summary>
        /// AddressAllocationIds
        /// A list of address allocation IDs that are required to attach an Elastic IP address to your server&#39;s
        /// endpoint. This is only valid in the UpdateServer API.
        /// Note This property can only be set when EndpointType is set to VPC.
        /// Required: No
        /// Type: List of String
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("AddressAllocationIds")]
        public List<Union<string, IntrinsicFunction>> AddressAllocationIds { get; set; }

        /// <summary>
        /// VpcId
        /// The VPC ID of the virtual private cloud in which the server&#39;s endpoint will be hosted.
        /// Note This property can only be set when EndpointType is set to VPC.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

        /// <summary>
        /// VpcEndpointId
        /// The ID of the VPC endpoint.
        /// Note This property can only be set when EndpointType is set to VPC_ENDPOINT.
        /// Required: No
        /// Type: String
        /// Minimum: 22
        /// Maximum: 22
        /// Pattern: ^vpce-[0-9a-f]{17}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcEndpointId")]
        public Union<string, IntrinsicFunction> VpcEndpointId { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// A list of security groups IDs that are available to attach to your server&#39;s endpoint.
        /// Note This property can only be set when EndpointType is set to VPC.
        /// Maximum number of security groups: 5
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// A list of subnet IDs that are required to host your server endpoint in your VPC.
        /// Note This property can only be set when EndpointType is set to VPC.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
