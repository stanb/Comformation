using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration SpekeKeyProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-spekekeyprovider.html
    /// </summary>
    public class SpekeKeyProvider
    {

        /// <summary>
        /// RoleArn
        /// The ARN for the IAM role that&#39;s granted by the key provider to provide access to the key provider
        /// API. Valid format: arn:aws:iam::{accountID}:role/{name}
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

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
        /// URL for the key provider&#39;s key retrieval API endpoint. Must start with https://.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
