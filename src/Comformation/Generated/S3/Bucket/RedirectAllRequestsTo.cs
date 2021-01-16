using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket RedirectAllRequestsTo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-redirectallrequeststo.html
    /// </summary>
    public class RedirectAllRequestsTo
    {

        /// <summary>
        /// HostName
        /// Name of the host where requests are redirected.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostName")]
        public Union<string, IntrinsicFunction> HostName { get; set; }

        /// <summary>
        /// Protocol
        /// Protocol to use when redirecting requests. The default is the protocol that is used in the original
        /// request.
        /// Required: No
        /// Type: String
        /// Allowed values: http | https
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
