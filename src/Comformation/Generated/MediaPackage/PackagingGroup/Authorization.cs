using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingGroup
{
    /// <summary>
    /// AWS::MediaPackage::PackagingGroup Authorization
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packaginggroup-authorization.html
    /// </summary>
    public class Authorization
    {

        /// <summary>
        /// CdnIdentifierSecret
        /// The Amazon Resource Name (ARN) for the secret in AWS Secrets Manager that is used for CDN
        /// authorization.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CdnIdentifierSecret")]
        public Union<string, IntrinsicFunction> CdnIdentifierSecret { get; set; }

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

    }
}
