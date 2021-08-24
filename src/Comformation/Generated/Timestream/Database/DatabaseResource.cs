using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Timestream.Database
{
    /// <summary>
    /// AWS::Timestream::Database
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-database.html
    /// </summary>
    public class DatabaseResource : ResourceBase
    {
        public class DatabaseProperties
        {
            /// <summary>
            /// DatabaseName
            /// The name of the Timestream database.
            /// Length Constraints: Minimum length of 3 bytes. Maximum length of 256 bytes.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DatabaseName { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The identifier of the AWS KMS key used to encrypt the data stored in the database.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// Tags
            /// The tags to add to the database.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Timestream::Database";

        public DatabaseProperties Properties { get; } = new DatabaseProperties();

    }

    public static class DatabaseAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
