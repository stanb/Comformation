using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule HttpAuthorization
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpauthorization.html
    /// </summary>
    public class HttpAuthorization
    {

        /// <summary>
        /// Sigv4
        /// Use Sig V4 authorization. For more information, see Signature Version 4 Signing Process.
        /// Required: No
        /// Type: SigV4Authorization
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sigv4")]
        public SigV4Authorization Sigv4 { get; set; }

    }
}
