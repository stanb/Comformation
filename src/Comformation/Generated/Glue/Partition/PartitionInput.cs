using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS Glue Partition PartitionInput
    /// The PartitionInput property type specifies the metadata that's used to create or update an AWS Glue partition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-partitioninput.html
    /// </summary>
    public class PartitionInput
    {

        /// <summary>
        /// Parameters
        /// UTF-8 string–to–UTF-8 string key-value pairs that specify the parameters for the partition.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// StorageDescriptor
        /// Information about the physical storage of the partition.
        /// Required: No
        /// Type: AWS Glue Partition StorageDescriptor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageDescriptor")]
        public Union<StorageDescriptor, IntrinsicFunction> StorageDescriptor { get; set; }

        /// <summary>
        /// Values
        /// A list of UTF-8 strings that specify the values of the partition.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Values")]
        public Union<List<string>, IntrinsicFunction> Values { get; set; }

    }
}
