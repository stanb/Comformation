using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority RevocationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-revocationconfiguration.html
    /// </summary>
    public class RevocationConfiguration
    {

        /// <summary>
        /// CrlConfiguration
        /// Configuration of the certificate revocation list (CRL), if any, maintained by your private CA.
        /// Required: No
        /// Type: CrlConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrlConfiguration")]
        public CrlConfiguration CrlConfiguration { get; set; }

    }
}
