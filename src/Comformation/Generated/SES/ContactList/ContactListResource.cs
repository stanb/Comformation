using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ContactList
{
    /// <summary>
    /// AWS::SES::ContactList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-contactlist.html
    /// </summary>
    public class ContactListResource : ResourceBase
    {
        public class ContactListProperties
        {
            /// <summary>
            /// ContactListName
            /// The name of the contact list.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ContactListName { get; set; }

            /// <summary>
            /// Description
            /// A description of what the contact list is about.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Topics
            /// An interest group, theme, or label within a list. A contact list can have multiple topics.
            /// Required: No
            /// Type: List of Topic
            /// Update requires: No interruption
            /// </summary>
            public List<Topic> Topics { get; set; }

            /// <summary>
            /// Tags
            /// The tags associated with a contact list.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SES::ContactList";

        public ContactListProperties Properties { get; } = new ContactListProperties();

    }
}
