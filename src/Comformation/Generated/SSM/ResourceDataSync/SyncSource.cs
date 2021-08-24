using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.ResourceDataSync
{
    /// <summary>
    /// AWS::SSM::ResourceDataSync SyncSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-syncsource.html
    /// </summary>
    public class SyncSource
    {

        /// <summary>
        /// IncludeFutureRegions
        /// Whether to automatically synchronize and aggregate data from new AWS Regions when those Regions come
        /// online.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeFutureRegions")]
        public Union<bool, IntrinsicFunction> IncludeFutureRegions { get; set; }

        /// <summary>
        /// SourceRegions
        /// The SyncSource AWS Regions included in the resource data sync.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceRegions")]
        public List<Union<string, IntrinsicFunction>> SourceRegions { get; set; }

        /// <summary>
        /// SourceType
        /// The type of data source for the resource data sync. SourceType is either AwsOrganizations (if an
        /// organization is present in AWS Organizations) or SingleAccountMultiRegions.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceType")]
        public Union<string, IntrinsicFunction> SourceType { get; set; }

        /// <summary>
        /// AwsOrganizationsSource
        /// Information about the AwsOrganizationsSource resource data sync source. A sync source of this type
        /// can synchronize data from AWS Organizations.
        /// Required: No
        /// Type: AwsOrganizationsSource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsOrganizationsSource")]
        public AwsOrganizationsSource AwsOrganizationsSource { get; set; }

    }
}
