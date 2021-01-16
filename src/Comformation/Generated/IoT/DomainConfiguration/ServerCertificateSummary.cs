using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.DomainConfiguration
{
    /// <summary>
    /// AWS::IoT::DomainConfiguration ServerCertificateSummary
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificatesummary.html
    /// </summary>
    public class ServerCertificateSummary
    {

        /// <summary>
        /// ServerCertificateArn
        /// The ARN of the server certificate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerCertificateArn")]
        public Union<string, IntrinsicFunction> ServerCertificateArn { get; set; }

        /// <summary>
        /// ServerCertificateStatus
        /// The status of the server certificate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerCertificateStatus")]
        public Union<string, IntrinsicFunction> ServerCertificateStatus { get; set; }

        /// <summary>
        /// ServerCertificateStatusDetail
        /// Details that explain the status of the server certificate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerCertificateStatusDetail")]
        public Union<string, IntrinsicFunction> ServerCertificateStatusDetail { get; set; }

    }
}
