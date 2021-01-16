using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain DomainEndpointOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html
    /// </summary>
    public class DomainEndpointOptions
    {

        /// <summary>
        /// CustomEndpoint
        /// The fully qualified URL for your custom endpoint.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public Union<string, IntrinsicFunction> CustomEndpoint { get; set; }

        /// <summary>
        /// CustomEndpointCertificateArn
        /// The AWS Certificate Manager ARN for your domain&#39;s SSL/TLS certificate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomEndpointCertificateArn")]
        public Union<string, IntrinsicFunction> CustomEndpointCertificateArn { get; set; }

        /// <summary>
        /// CustomEndpointEnabled
        /// True to enable a custom endpoint for the domain. If enabled, you must also provide values for
        /// CustomEndpoint and CustomEndpointCertificateArn.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomEndpointEnabled")]
        public Union<bool, IntrinsicFunction> CustomEndpointEnabled { get; set; }

        /// <summary>
        /// EnforceHTTPS
        /// True to require that all traffic to the domain arrive over HTTPS.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnforceHTTPS")]
        public Union<bool, IntrinsicFunction> EnforceHTTPS { get; set; }

        /// <summary>
        /// TLSSecurityPolicy
        /// The minimum TLS version required for traffic to the domain. Valid values are TLS 1. 0 (default) or
        /// 1. 2:
        /// Policy-Min-TLS-1-0-2019-07 Policy-Min-TLS-1-2-2019-07
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TLSSecurityPolicy")]
        public Union<string, IntrinsicFunction> TLSSecurityPolicy { get; set; }

    }
}
