using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Website Configuration Redirect All Requests To Property
    /// The RedirectAllRequestsTo code is an embedded property of the Amazon S3 Website Configuration Property
    /// property that describes the redirect behavior of all requests to a website endpoint of an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-redirectallrequeststo.html
    /// </summary>
    public class RedirectAllRequestsTo
    {

        /// <summary>
        /// HostName
        /// Name of the host where requests are redirected.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("HostName")]
        public Union<string, IntrinsicFunction> HostName { get; set; }

        /// <summary>
        /// Protocol
        /// Protocol to use (http or https) when redirecting requests. The default is the protocol that is used
        /// in the original request.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

    }
}
