using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline Activity
    /// The Activity property type specifies a list of activities for an AWS IoT Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-activity.html
    /// </summary>
    public class Activity
    {

        /// <summary>
        /// SelectAttributes
        /// Creates a new message using only the specified attributes from the original message.
        /// Required: No
        /// Type: SelectAttributes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectAttributes")]
        public SelectAttributes SelectAttributes { get; set; }

        /// <summary>
        /// Datastore
        /// Specifies where to store the processed message data.
        /// Required: No
        /// Type: Datastore
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Datastore")]
        public Datastore Datastore { get; set; }

        /// <summary>
        /// Filter
        /// Filters a message based on its attributes.
        /// Required: No
        /// Type: Filter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter { get; set; }

        /// <summary>
        /// AddAttributes
        /// Adds other attributes based on existing attributes in the message.
        /// Required: No
        /// Type: AddAttributes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddAttributes")]
        public AddAttributes AddAttributes { get; set; }

        /// <summary>
        /// Channel
        /// Determines the source of the messages to be processed.
        /// Required: No
        /// Type: Channel
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Channel")]
        public Channel Channel { get; set; }

        /// <summary>
        /// DeviceShadowEnrich
        /// Adds information from the AWS IoT Device Shadows service to a message.
        /// Required: No
        /// Type: DeviceShadowEnrich
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceShadowEnrich")]
        public DeviceShadowEnrich DeviceShadowEnrich { get; set; }

        /// <summary>
        /// Math
        /// Computes an arithmetic expression using the message&#39;s attributes and adds it to the message.
        /// Required: No
        /// Type: Math
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Math")]
        public Math Math { get; set; }

        /// <summary>
        /// Lambda
        /// Runs a Lambda function to modify the message.
        /// Required: No
        /// Type: Lambda
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lambda")]
        public Lambda Lambda { get; set; }

        /// <summary>
        /// DeviceRegistryEnrich
        /// Adds data from the AWS IoT device registry to your message.
        /// Required: No
        /// Type: DeviceRegistryEnrich
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceRegistryEnrich")]
        public DeviceRegistryEnrich DeviceRegistryEnrich { get; set; }

        /// <summary>
        /// RemoveAttributes
        /// Removes attributes from a message.
        /// Required: No
        /// Type: RemoveAttributes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveAttributes")]
        public RemoveAttributes RemoveAttributes { get; set; }

    }
}
