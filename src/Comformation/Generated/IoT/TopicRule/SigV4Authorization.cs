using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule SigV4Authorization
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sigv4authorization.html
    /// </summary>
    public class SigV4Authorization
    {

        /// <summary>
        /// ServiceName
        /// The service name to use while signing with Sig V4.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

        /// <summary>
        /// SigningRegion
        /// The signing region.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigningRegion")]
        public Union<string, IntrinsicFunction> SigningRegion { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the signing role.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
