using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS::OpsWorks::App SslConfiguration
    /// Describes an app&#39;s SSL configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-app-sslconfiguration.html
    /// </summary>
    public class SslConfiguration
    {

        /// <summary>
        /// Certificate
        /// The contents of the certificate&#39;s domain. crt file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Certificate")]
        public Union<string, IntrinsicFunction> Certificate { get; set; }

        /// <summary>
        /// Chain
        /// Optional. Can be used to specify an intermediate certificate authority key or client authentication.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Chain")]
        public Union<string, IntrinsicFunction> Chain { get; set; }

        /// <summary>
        /// PrivateKey
        /// The private key; the contents of the certificate&#39;s domain. kex file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateKey")]
        public Union<string, IntrinsicFunction> PrivateKey { get; set; }

    }
}
