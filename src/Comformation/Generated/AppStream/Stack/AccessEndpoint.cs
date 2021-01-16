using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// AWS::AppStream::Stack AccessEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-accessendpoint.html
    /// </summary>
    public class AccessEndpoint
    {

        /// <summary>
        /// EndpointType
        /// The type of interface endpoint.
        /// Required: Yes
        /// Type: String
        /// Allowed values: STREAMING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointType")]
        public Union<string, IntrinsicFunction> EndpointType { get; set; }

        /// <summary>
        /// VpceId
        /// The identifier (ID) of the VPC in which the interface endpoint is used.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpceId")]
        public Union<string, IntrinsicFunction> VpceId { get; set; }

    }
}
