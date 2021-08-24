using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Channel
{
    /// <summary>
    /// AWS::IoTAnalytics::Channel ChannelStorage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-channel-channelstorage.html
    /// </summary>
    public class ChannelStorage
    {

        /// <summary>
        /// CustomerManagedS3
        /// Used to store channel data in an S3 bucket that you manage. If customer managed storage is selected,
        /// the retentionPeriod parameter is ignored. You can&#39;t change the choice of S3 storage after the data
        /// store is created.
        /// Required: No
        /// Type: CustomerManagedS3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomerManagedS3")]
        public CustomerManagedS3 CustomerManagedS3 { get; set; }

        /// <summary>
        /// ServiceManagedS3
        /// Used to store channel data in an S3 bucket managed by AWS IoT Analytics. You can&#39;t change the choice
        /// of S3 storage after the data store is created.
        /// Required: No
        /// Type: ServiceManagedS3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceManagedS3")]
        public ServiceManagedS3 ServiceManagedS3 { get; set; }

    }
}
