using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Domain
{
    /// <summary>
    /// AWS::CustomerProfiles::Domain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domain.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// DomainName
            /// The unique name of the domain.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DeadLetterQueueUrl
            /// The URL of the SQS dead letter queue, which is used for reporting errors associated with ingesting
            /// data from third party applications. You must set up a policy on the DeadLetterQueue for the
            /// SendMessage operation to enable Amazon Connect Customer Profiles to send messages to the
            /// DeadLetterQueue.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeadLetterQueueUrl { get; set; }

            /// <summary>
            /// DefaultEncryptionKey
            /// The default encryption key, which is an AWS managed key, is used when no specific type of encryption
            /// key is specified. It is used to encrypt all data before it is placed in permanent or semi-permanent
            /// storage.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultEncryptionKey { get; set; }

            /// <summary>
            /// DefaultExpirationDays
            /// The default number of days until the data within the domain expires.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> DefaultExpirationDays { get; set; }

            /// <summary>
            /// Tags
            /// The tags used to organize, track, or control access for this resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CustomerProfiles::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }

    public static class DomainAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedAt");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedAt");
    }
}
