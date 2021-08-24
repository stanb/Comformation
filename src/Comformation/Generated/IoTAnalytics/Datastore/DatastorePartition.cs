using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore DatastorePartition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html
    /// </summary>
    public class DatastorePartition
    {

        /// <summary>
        /// Partition
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Partition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Partition")]
        public Partition Partition { get; set; }

        /// <summary>
        /// TimestampPartition
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: TimestampPartition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampPartition")]
        public TimestampPartition TimestampPartition { get; set; }

    }
}
