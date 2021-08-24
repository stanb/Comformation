using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.DataflowEndpointGroup
{
    /// <summary>
    /// AWS::GroundStation::DataflowEndpointGroup EndpointDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html
    /// </summary>
    public class EndpointDetails
    {

        /// <summary>
        /// SecurityDetails
        /// The role ARN, and IDs for security groups and subnets.
        /// Required: No
        /// Type: SecurityDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityDetails")]
        public SecurityDetails SecurityDetails { get; set; }

        /// <summary>
        /// Endpoint
        /// Information about the endpoint such as name and the endpoint address.
        /// Required: No
        /// Type: DataflowEndpoint
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public DataflowEndpoint Endpoint { get; set; }

    }
}
