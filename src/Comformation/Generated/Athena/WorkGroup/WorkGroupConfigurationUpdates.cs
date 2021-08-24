using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.WorkGroup
{
    /// <summary>
    /// AWS::Athena::WorkGroup WorkGroupConfigurationUpdates
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-workgroupconfigurationupdates.html
    /// </summary>
    public class WorkGroupConfigurationUpdates
    {

        /// <summary>
        /// BytesScannedCutoffPerQuery
        /// The upper limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan.
        /// No default is defined.
        /// Note This property currently supports integer types. Support for long values is planned.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BytesScannedCutoffPerQuery")]
        public Union<int, IntrinsicFunction> BytesScannedCutoffPerQuery { get; set; }

        /// <summary>
        /// EnforceWorkGroupConfiguration
        /// If set to &quot;true&quot;, the settings for the workgroup override client-side settings. If set to &quot;false&quot;
        /// client-side settings are used. For more information, see Workgroup Settings Override Client-Side
        /// Settings.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnforceWorkGroupConfiguration")]
        public Union<bool, IntrinsicFunction> EnforceWorkGroupConfiguration { get; set; }

        /// <summary>
        /// PublishCloudWatchMetricsEnabled
        /// Indicates whether this workgroup enables publishing metrics to Amazon CloudWatch.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PublishCloudWatchMetricsEnabled")]
        public Union<bool, IntrinsicFunction> PublishCloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// RequesterPaysEnabled
        /// If set to true, allows members assigned to a workgroup to specify Amazon S3 Requester Pays buckets
        /// in queries. If set to false, workgroup members cannot query data from Requester Pays buckets, and
        /// queries that retrieve data from Requester Pays buckets cause an error. The default is false. For
        /// more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple
        /// Storage Service Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RequesterPaysEnabled")]
        public Union<bool, IntrinsicFunction> RequesterPaysEnabled { get; set; }

        /// <summary>
        /// ResultConfigurationUpdates
        /// The result configuration information about the queries in this workgroup that will be updated.
        /// Includes the updated results location and an updated option for encrypting query results.
        /// Required: No
        /// Type: ResultConfigurationUpdates
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResultConfigurationUpdates")]
        public ResultConfigurationUpdates ResultConfigurationUpdates { get; set; }

        /// <summary>
        /// RemoveBytesScannedCutoffPerQuery
        /// Indicates that the data usage control limit per query is removed. See BytesScannedCutoffPerQuery.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveBytesScannedCutoffPerQuery")]
        public Union<bool, IntrinsicFunction> RemoveBytesScannedCutoffPerQuery { get; set; }

        /// <summary>
        /// EngineVersion
        /// The engine version requested when a workgroup is updated. After the update, all queries on the
        /// workgroup run on the requested engine version. If no value was previously set, the default is Auto.
        /// Queries on the AmazonAthenaPreviewFunctionality workgroup run on the preview engine regardless of
        /// this setting.
        /// Required: No
        /// Type: EngineVersion
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EngineVersion")]
        public EngineVersion EngineVersion { get; set; }

    }
}
