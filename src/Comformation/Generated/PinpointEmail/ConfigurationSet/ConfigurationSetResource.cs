using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSet
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationset.html
    /// </summary>
    public class ConfigurationSetResource : ResourceBase
    {
        public class ConfigurationSetProperties
        {
            /// <summary>
            /// SendingOptions
            /// An object that defines whether or not Amazon Pinpoint can send email that you send using the
            /// configuration set.
            /// Required: No
            /// Type: SendingOptions
            /// Update requires: No interruption
            /// </summary>
            public SendingOptions SendingOptions { get; set; }

            /// <summary>
            /// TrackingOptions
            /// An object that defines the open and click tracking options for emails that you send using the
            /// configuration set.
            /// Required: No
            /// Type: TrackingOptions
            /// Update requires: No interruption
            /// </summary>
            public TrackingOptions TrackingOptions { get; set; }

            /// <summary>
            /// ReputationOptions
            /// An object that defines whether or not Amazon Pinpoint collects reputation metrics for the emails
            /// that you send that use the configuration set.
            /// Required: No
            /// Type: ReputationOptions
            /// Update requires: No interruption
            /// </summary>
            public ReputationOptions ReputationOptions { get; set; }

            /// <summary>
            /// DeliveryOptions
            /// An object that defines the dedicated IP pool that is used to send emails that you send using the
            /// configuration set.
            /// Required: No
            /// Type: DeliveryOptions
            /// Update requires: No interruption
            /// </summary>
            public DeliveryOptions DeliveryOptions { get; set; }

            /// <summary>
            /// Tags
            /// An object that defines the tags (keys and values) that you want to associate with the configuration
            /// set.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tags> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the configuration set.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::PinpointEmail::ConfigurationSet";

        public ConfigurationSetProperties Properties { get; } = new ConfigurationSetProperties();

    }
}
