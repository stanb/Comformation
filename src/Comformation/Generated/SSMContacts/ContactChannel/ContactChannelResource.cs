using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMContacts.ContactChannel
{
    /// <summary>
    /// AWS::SSMContacts::ContactChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contactchannel.html
    /// </summary>
    public class ContactChannelResource : ResourceBase
    {
        public class ContactChannelProperties
        {
            /// <summary>
            /// ContactId
            /// The Amazon Resource Name (ARN) of the contact you are adding the contact channel to.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: arn:(aws|aws-cn|aws-us-gov):ssm-contacts:[-\w+=\/,. @]*:[0-9]+:([\w+=\/,. @:-]+)*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ContactId { get; set; }

            /// <summary>
            /// ChannelName
            /// The name of the contact channel.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: ^[\p{L}\p{Z}\p{N}_. \-]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ChannelName { get; set; }

            /// <summary>
            /// ChannelType
            /// The type of the contact channel. Incident Manager supports three contact methods:
            /// SMS VOICE EMAIL
            /// Required: Yes
            /// Type: String
            /// Allowed values: EMAIL | SMS | VOICE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ChannelType { get; set; }

            /// <summary>
            /// DeferActivation
            /// If you want to activate the channel at a later time, you can choose to defer activation. Incident
            /// Manager can&#39;t engage your contact channel until it has been activated.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeferActivation { get; set; }

            /// <summary>
            /// ChannelAddress
            /// The details that Incident Manager uses when trying to engage the contact channel.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ChannelAddress { get; set; }

        }

        public string Type { get; } = "AWS::SSMContacts::ContactChannel";

        public ContactChannelProperties Properties { get; } = new ContactChannelProperties();

    }

    public static class ContactChannelAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
