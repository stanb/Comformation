using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DatasetContentDeliveryRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html
    /// </summary>
    public class DatasetContentDeliveryRule
    {

        /// <summary>
        /// Destination
        /// The destination to which dataset contents are delivered.
        /// Required: Yes
        /// Type: DatasetContentDeliveryRuleDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public DatasetContentDeliveryRuleDestination Destination { get; set; }

        /// <summary>
        /// EntryName
        /// The name of the dataset content delivery rules entry.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntryName")]
        public Union<string, IntrinsicFunction> EntryName { get; set; }

    }
}
