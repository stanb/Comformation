using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMContacts.Contact
{
    /// <summary>
    /// AWS::SSMContacts::Contact
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html
    /// </summary>
    public class ContactResource : ResourceBase
    {
        public class ContactProperties
        {
            /// <summary>
            /// Alias
            /// The unique and identifiable alias of the contact or escalation plan.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: ^[a-z0-9_\-]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Alias { get; set; }

            /// <summary>
            /// DisplayName
            /// The full name of the contact or escalation plan.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 255
            /// Pattern: ^[\p{L}\p{Z}\p{N}_. \-]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// Type
            /// Refers to the type of contact. A single contact is type PERSONAL and an escalation plan is type
            /// ESCALATION.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ESCALATION | PERSONAL
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Plan
            /// A list of stages. A contact has an engagement plan with stages that contact specified contact
            /// channels. An escalation plan uses stages that contact specified contacts.
            /// Required: Yes
            /// Type: List of Stage
            /// Update requires: No interruption
            /// </summary>
            public List<Stage> Plan { get; set; }

        }

        public string Type { get; } = "AWS::SSMContacts::Contact";

        public ContactProperties Properties { get; } = new ContactProperties();

    }

    public static class ContactAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
