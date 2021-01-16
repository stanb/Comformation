using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.PushTemplate
{
    /// <summary>
    /// AWS::Pinpoint::PushTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html
    /// </summary>
    public class PushTemplateResource : ResourceBase
    {
        public class PushTemplateProperties
        {
            /// <summary>
            /// GCM
            /// The message template to use for the GCM channel, which is used to send notifications through the
            /// Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging (GCM), service. This message
            /// template overrides the default template for push notification channels (Default).
            /// Required: No
            /// Type: AndroidPushNotificationTemplate
            /// Update requires: No interruption
            /// </summary>
            public AndroidPushNotificationTemplate GCM { get; set; }

            /// <summary>
            /// Baidu
            /// The message template to use for the Baidu (Baidu Cloud Push) channel. This message template
            /// overrides the default template for push notification channels (Default).
            /// Required: No
            /// Type: AndroidPushNotificationTemplate
            /// Update requires: No interruption
            /// </summary>
            public AndroidPushNotificationTemplate Baidu { get; set; }

            /// <summary>
            /// TemplateName
            /// The name of the message template.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateName { get; set; }

            /// <summary>
            /// ADM
            /// The message template to use for the ADM (Amazon Device Messaging) channel. This message template
            /// overrides the default template for push notification channels (Default).
            /// Required: No
            /// Type: AndroidPushNotificationTemplate
            /// Update requires: No interruption
            /// </summary>
            public AndroidPushNotificationTemplate ADM { get; set; }

            /// <summary>
            /// APNS
            /// The message template to use for the APNs (Apple Push Notification service) channel. This message
            /// template overrides the default template for push notification channels (Default).
            /// Required: No
            /// Type: APNSPushNotificationTemplate
            /// Update requires: No interruption
            /// </summary>
            public APNSPushNotificationTemplate APNS { get; set; }

            /// <summary>
            /// TemplateDescription
            /// A custom description of the message template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateDescription { get; set; }

            /// <summary>
            /// DefaultSubstitutions
            /// A JSON object that specifies the default values to use for message variables in the message
            /// template. This object is a set of key-value pairs. Each key defines a message variable in the
            /// template. The corresponding value defines the default value for that variable. When you create a
            /// message that&#39;s based on the template, you can override these defaults with message-specific and
            /// address-specific variables and values.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultSubstitutions { get; set; }

            /// <summary>
            /// Default
            /// The default message template to use for push notification channels.
            /// Required: No
            /// Type: DefaultPushNotificationTemplate
            /// Update requires: No interruption
            /// </summary>
            public DefaultPushNotificationTemplate Default { get; set; }

            /// <summary>
            /// Tags
            /// A string-to-string map of key-value pairs that defines the tags to associate with the message
            /// template. Each tag consists of a required tag key and an associated tag value.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::PushTemplate";

        public PushTemplateProperties Properties { get; } = new PushTemplateProperties();

    }

    public static class PushTemplateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
