using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DomainName
{
    /// <summary>
    /// AWS::ApiGateway::DomainName MutualTlsAuthentication
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-mutualtlsauthentication.html
    /// </summary>
    public class MutualTlsAuthentication
    {

        /// <summary>
        /// TruststoreUri
        /// An Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example,
        /// s3://bucket-name/key-name. The truststore can contain certificates from public or private
        /// certificate authorities. To update the truststore, upload a new version to S3, and then update your
        /// custom domain name to use the new version. To update the truststore, you must have permissions to
        /// access the S3 object.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TruststoreUri")]
        public Union<string, IntrinsicFunction> TruststoreUri { get; set; }

        /// <summary>
        /// TruststoreVersion
        /// The version of the S3 object that contains your truststore. To specify a version, you must have
        /// versioning enabled for the S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TruststoreVersion")]
        public Union<string, IntrinsicFunction> TruststoreVersion { get; set; }

    }
}
