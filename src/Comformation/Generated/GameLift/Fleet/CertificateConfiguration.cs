using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet CertificateConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-certificateconfiguration.html
    /// </summary>
    public class CertificateConfiguration
    {

        /// <summary>
        /// CertificateType
        /// Indicates whether a TLS/SSL certificate is generated for the fleet.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DISABLED | GENERATED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CertificateType")]
        public Union<string, IntrinsicFunction> CertificateType { get; set; }

    }
}
