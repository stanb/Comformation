using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint Authorization
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-authorization.html
    /// </summary>
    public class Authorization
    {

        /// <summary>
        /// SecretsRoleArn
        /// The Amazon Resource Name (ARN) for the IAM role that allows MediaPackage to communicate with AWS
        /// Secrets Manager.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretsRoleArn")]
        public Union<string, IntrinsicFunction> SecretsRoleArn { get; set; }

        /// <summary>
        /// CdnIdentifierSecret
        /// The Amazon Resource Name (ARN) for the secret in AWS Secrets Manager that your Content Distribution
        /// Network (CDN) uses for authorization to access your endpoint.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CdnIdentifierSecret")]
        public Union<string, IntrinsicFunction> CdnIdentifierSecret { get; set; }

    }
}
