using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.DomainName
{
    /// <summary>
    /// AWS::ApiGatewayV2::DomainName DomainNameConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html
    /// </summary>
    public class DomainNameConfiguration
    {

        /// <summary>
        /// SecurityPolicy
        /// The Transport Layer Security (TLS) version of the security policy for this domain name. The valid
        /// values are TLS_1_0 and TLS_1_2.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public Union<string, IntrinsicFunction> SecurityPolicy { get; set; }

        /// <summary>
        /// EndpointType
        /// The endpoint type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointType")]
        public Union<string, IntrinsicFunction> EndpointType { get; set; }

        /// <summary>
        /// CertificateName
        /// The user-friendly name of the certificate that will be used by the edge-optimized endpoint for this
        /// domain name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateName")]
        public Union<string, IntrinsicFunction> CertificateName { get; set; }

        /// <summary>
        /// CertificateArn
        /// An AWS-managed certificate that will be used by the edge-optimized endpoint for this domain name.
        /// AWS Certificate Manager is the only supported source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
