using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.Identity
{
    /// <summary>
    /// AWS::PinpointEmail::Identity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html
    /// </summary>
    public class IdentityResource : ResourceBase
    {
        public class IdentityProperties
        {
            /// <summary>
            /// FeedbackForwardingEnabled
            /// Used to enable or disable feedback forwarding for an identity. This setting determines what happens
            /// when an identity is used to send an email that results in a bounce or complaint event.
            /// When you enable feedback forwarding, Amazon Pinpoint sends you email notifications when bounce or
            /// complaint events occur. Amazon Pinpoint sends this notification to the address that you specified in
            /// the Return-Path header of the original email.
            /// When you disable feedback forwarding, Amazon Pinpoint sends notifications through other mechanisms,
            /// such as by notifying an Amazon SNS topic. You&#39;re required to have a method of tracking bounces and
            /// complaints. If you haven&#39;t set up another mechanism for receiving bounce or complaint notifications,
            /// Amazon Pinpoint sends an email notification when these events occur (even if this setting is
            /// disabled).
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> FeedbackForwardingEnabled { get; set; }

            /// <summary>
            /// DkimSigningEnabled
            /// For domain identities, this attribute is used to enable or disable DomainKeys Identified Mail (DKIM)
            /// signing for the domain.
            /// If the value is true, then the messages that you send from the domain are signed using both the DKIM
            /// keys for your domain, as well as the keys for the amazonses. com domain. If the value is false, then
            /// the messages that you send are only signed using the DKIM keys for the amazonses. com domain.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DkimSigningEnabled { get; set; }

            /// <summary>
            /// Tags
            /// An object that defines the tags (keys and values) that you want to associate with the email
            /// identity.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tags> Tags { get; set; }

            /// <summary>
            /// Name
            /// The address or domain of the identity, such as sender@example. com or example. co. uk.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// MailFromAttributes
            /// Used to enable or disable the custom Mail-From domain configuration for an email identity.
            /// Required: No
            /// Type: MailFromAttributes
            /// Update requires: No interruption
            /// </summary>
            public MailFromAttributes MailFromAttributes { get; set; }

        }

        public string Type { get; } = "AWS::PinpointEmail::Identity";

        public IdentityProperties Properties { get; } = new IdentityProperties();

    }

    public static class IdentityAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityDNSRecordName3 = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityDNSRecordName3");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityDNSRecordName1 = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityDNSRecordName1");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityDNSRecordName2 = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityDNSRecordName2");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityDNSRecordValue3 = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityDNSRecordValue3");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityDNSRecordValue2 = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityDNSRecordValue2");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> IdentityDNSRecordValue1 = new ResourceAttribute<Union<string, IntrinsicFunction>>("IdentityDNSRecordValue1");
    }
}
