using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition PartitionInput
    /// The structure used to create and update a partition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-partitioninput.html
    /// </summary>
    public class PartitionInput
    {

        /// <summary>
        /// Parameters
        /// These key-value pairs define partition parameters.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// StorageDescriptor
        /// Provides information about the physical location where the partition is stored.
        /// Required: No
        /// Type: StorageDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageDescriptor")]
        public StorageDescriptor StorageDescriptor { get; set; }

        /// <summary>
        /// Values
        /// The values of the partition. Although this parameter is not required by the SDK, you must specify
        /// this parameter for a valid input.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
