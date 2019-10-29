using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DatasetContentDeliveryRule
    /// When data set contents are created they are delivered to destination specified here.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryrule.html
    /// </summary>
    public class DatasetContentDeliveryRule
    {

        /// <summary>
        /// Destination
        /// The destination to which data set contents are delivered.
        /// Required: Yes
        /// Type: DatasetContentDeliveryRuleDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public DatasetContentDeliveryRuleDestination Destination { get; set; }

        /// <summary>
        /// EntryName
        /// The name of the data set content delivery rules entry.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntryName")]
        public Union<string, IntrinsicFunction> EntryName { get; set; }

    }
}
