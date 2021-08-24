using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore CustomerManagedS3
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html
    /// </summary>
    public class CustomerManagedS3
    {

        /// <summary>
        /// Bucket
        /// The name of the Amazon S3 bucket where your data is stored.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 255
        /// Pattern: ^[a-zA-Z0-9. \-_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants AWS IoT Analytics permission to interact with your Amazon S3
        /// resources.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// KeyPrefix
        /// (Optional) The prefix used to create the keys of the data store data objects. Each object in an
        /// Amazon S3 bucket has a key that is its unique identifier in the bucket. Each object in a bucket has
        /// exactly one key. The prefix must end with a forward slash (/).
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^[a-zA-Z0-9!_. *&#39;()/{}:-]*/$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyPrefix")]
        public Union<string, IntrinsicFunction> KeyPrefix { get; set; }

    }
}
