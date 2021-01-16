using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint SpekeKeyProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-spekekeyprovider.html
    /// </summary>
    public class SpekeKeyProvider
    {

        /// <summary>
        /// ResourceId
        /// Unique identifier for this endpoint, as it is configured in the key provider service.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceId")]
        public Union<string, IntrinsicFunction> ResourceId { get; set; }

        /// <summary>
        /// SystemIds
        /// List of unique identifiers for the DRM systems to use, as defined in the CPIX specification.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SystemIds")]
        public List<Union<string, IntrinsicFunction>> SystemIds { get; set; }

        /// <summary>
        /// Url
        /// URL for the key provider’s key retrieval API endpoint. Must start with https://.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN for the IAM role that&#39;s granted by the key provider to provide access to the key provider
        /// API. This role must have a trust policy that allows AWS Elemental MediaPackage to assume the role,
        /// and it must have a sufficient permissions policy to allow access to the specific key retrieval URL.
        /// Valid format: arn:aws:iam::{accountID}:role/{name}
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// CertificateArn
        /// The Amazon Resource Name (ARN) for the certificate that you imported to AWS Certificate Manager to
        /// add content key encryption to this endpoint. For this feature to work, your DRM key provider must
        /// support content key encryption.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
