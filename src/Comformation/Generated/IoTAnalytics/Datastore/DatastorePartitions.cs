using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore DatastorePartitions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartitions.html
    /// </summary>
    public class DatastorePartitions
    {

        /// <summary>
        /// Partitions
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of DatastorePartition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Partitions")]
        public List<DatastorePartition> Partitions { get; set; }

    }
}
