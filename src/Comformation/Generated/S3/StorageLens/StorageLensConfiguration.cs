using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens StorageLensConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-storagelensconfiguration.html
    /// </summary>
    public class StorageLensConfiguration
    {

        /// <summary>
        /// Id
        /// This property contains the details of the ID of the S3 Storage Lens configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Include
        /// This property contains the details of the bucket and or Regions included for Amazon S3 Storage Lens
        /// configuration.
        /// Required: No
        /// Type: BucketsAndRegions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Include")]
        public BucketsAndRegions Include { get; set; }

        /// <summary>
        /// Exclude
        /// This property contains the details of the bucket and or Regions excluded for Amazon S3 Storage Lens
        /// configuration.
        /// Required: No
        /// Type: BucketsAndRegions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exclude")]
        public BucketsAndRegions Exclude { get; set; }

        /// <summary>
        /// AwsOrg
        /// This property contains the details of the AWS Organization for the S3 Storage Lens configuration.
        /// Required: No
        /// Type: AwsOrg
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsOrg")]
        public AwsOrg AwsOrg { get; set; }

        /// <summary>
        /// AccountLevel
        /// This property contains the details of the account-level metrics for Amazon S3 Storage Lens
        /// configuration.
        /// Required: Yes
        /// Type: AccountLevel
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountLevel")]
        public AccountLevel AccountLevel { get; set; }

        /// <summary>
        /// DataExport
        /// This property contains the details of this S3 Storage Lens configuration&#39;s metrics export.
        /// Required: No
        /// Type: DataExport
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataExport")]
        public DataExport DataExport { get; set; }

        /// <summary>
        /// IsEnabled
        /// This property contains the details of whether the Amazon S3 Storage Lens configuration is enabled.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsEnabled")]
        public Union<bool, IntrinsicFunction> IsEnabled { get; set; }

        /// <summary>
        /// StorageLensArn
        /// This property contains the details of the ARN of the S3 Storage Lens configuration. This property is
        /// read-only.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageLensArn")]
        public Union<string, IntrinsicFunction> StorageLensArn { get; set; }

    }
}
