using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore DatastoreStorage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html
    /// </summary>
    public class DatastoreStorage
    {

        /// <summary>
        /// CustomerManagedS3
        /// Use this to store data store data in an S3 bucket that you manage. The choice of service-managed or
        /// customer-managed S3 storage cannot be changed after creation of the data store.
        /// Required: No
        /// Type: CustomerManagedS3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomerManagedS3")]
        public CustomerManagedS3 CustomerManagedS3 { get; set; }

        /// <summary>
        /// ServiceManagedS3
        /// Use this to store data store data in an S3 bucket managed by the AWS IoT Analytics service. The
        /// choice of service-managed or customer-managed S3 storage cannot be changed after creation of the
        /// data store.
        /// Required: No
        /// Type: ServiceManagedS3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceManagedS3")]
        public ServiceManagedS3 ServiceManagedS3 { get; set; }

        /// <summary>
        /// IotSiteWiseMultiLayerStorage
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: IotSiteWiseMultiLayerStorage
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotSiteWiseMultiLayerStorage")]
        public IotSiteWiseMultiLayerStorage IotSiteWiseMultiLayerStorage { get; set; }

    }
}
