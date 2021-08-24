using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore IotSiteWiseMultiLayerStorage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-iotsitewisemultilayerstorage.html
    /// </summary>
    public class IotSiteWiseMultiLayerStorage
    {

        /// <summary>
        /// CustomerManagedS3Storage
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: CustomerManagedS3Storage
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomerManagedS3Storage")]
        public CustomerManagedS3Storage CustomerManagedS3Storage { get; set; }

    }
}
