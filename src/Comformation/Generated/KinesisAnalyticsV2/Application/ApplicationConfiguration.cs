using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application ApplicationConfiguration
    /// The ApplicationConfiguration property type define the the creation parameters for an Amazon Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationconfiguration.html
    /// </summary>
    public class ApplicationConfiguration
    {

        /// <summary>
        /// ApplicationCodeConfiguration
        /// The code location and type parameters for a Java-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: ApplicationCodeConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationCodeConfiguration")]
        public ApplicationCodeConfiguration ApplicationCodeConfiguration { get; set; }

        /// <summary>
        /// EnvironmentProperties
        /// Describes execution properties for a Java-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: EnvironmentProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnvironmentProperties")]
        public EnvironmentProperties EnvironmentProperties { get; set; }

        /// <summary>
        /// FlinkApplicationConfiguration
        /// The creation and update parameters for a Java-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: FlinkApplicationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FlinkApplicationConfiguration")]
        public FlinkApplicationConfiguration FlinkApplicationConfiguration { get; set; }

        /// <summary>
        /// SqlApplicationConfiguration
        /// The creation and update parameters for an SQL-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: SqlApplicationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqlApplicationConfiguration")]
        public SqlApplicationConfiguration SqlApplicationConfiguration { get; set; }

        /// <summary>
        /// ApplicationSnapshotConfiguration
        /// Describes whether snapshots are enabled for a Java-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: ApplicationSnapshotConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationSnapshotConfiguration")]
        public ApplicationSnapshotConfiguration ApplicationSnapshotConfiguration { get; set; }

    }
}
