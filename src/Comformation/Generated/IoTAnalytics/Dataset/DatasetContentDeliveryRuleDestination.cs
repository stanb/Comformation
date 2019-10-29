using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset DatasetContentDeliveryRuleDestination
    /// The destination to which data set contents are delivered.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-datasetcontentdeliveryruledestination.html
    /// </summary>
    public class DatasetContentDeliveryRuleDestination
    {

        /// <summary>
        /// IotEventsDestinationConfiguration
        /// Configuration information for delivery of data set contents to AWS IoT Events.
        /// Required: No
        /// Type: IotEventsDestinationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotEventsDestinationConfiguration")]
        public IotEventsDestinationConfiguration IotEventsDestinationConfiguration { get; set; }

        /// <summary>
        /// S3DestinationConfiguration
        /// Configuration information for delivery of data set contents to Amazon S3.
        /// Required: No
        /// Type: S3DestinationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3DestinationConfiguration")]
        public S3DestinationConfiguration S3DestinationConfiguration { get; set; }

    }
}
