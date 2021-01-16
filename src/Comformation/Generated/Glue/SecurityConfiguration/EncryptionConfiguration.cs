using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SecurityConfiguration
{
    /// <summary>
    /// AWS::Glue::SecurityConfiguration EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// S3Encryptions
        /// The encyption configuration for Amazon Simple Storage Service (Amazon S3) data.
        /// Required: No
        /// Type: S3Encryptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Encryptions")]
        public List<S3Encryption> S3Encryptions { get; set; }

        /// <summary>
        /// CloudWatchEncryption
        /// The encryption configuration for Amazon CloudWatch.
        /// Required: No
        /// Type: CloudWatchEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchEncryption")]
        public CloudWatchEncryption CloudWatchEncryption { get; set; }

        /// <summary>
        /// JobBookmarksEncryption
        /// The encryption configuration for job bookmarks.
        /// Required: No
        /// Type: JobBookmarksEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobBookmarksEncryption")]
        public JobBookmarksEncryption JobBookmarksEncryption { get; set; }

    }
}
