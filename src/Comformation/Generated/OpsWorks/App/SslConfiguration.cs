using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS OpsWorks SslConfiguration Type
    /// Describes an SSL configuration for the AWS::OpsWorks::App resource type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-app-sslconfiguration.html
    /// </summary>
    public class SslConfiguration
    {

        /// <summary>
        /// Certificate
        /// The contents of the certificate&#39;s domain. crt file.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Certificate")]
        public Union<string, IntrinsicFunction> Certificate { get; set; }

        /// <summary>
        /// Chain
        /// An intermediate certificate authority key or client authentication.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Chain")]
        public Union<string, IntrinsicFunction> Chain { get; set; }

        /// <summary>
        /// PrivateKey
        /// The private key; the contents of the certificate&#39;s domain. kex file.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PrivateKey")]
        public Union<string, IntrinsicFunction> PrivateKey { get; set; }

    }
}
