using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Faq
{
    /// <summary>
    /// AWS::Kendra::Faq
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-faq.html
    /// </summary>
    public class FaqResource : ResourceBase
    {
        public class FaqProperties
        {
            /// <summary>
            /// IndexId
            /// The identifier of the index that contains the FAQ.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IndexId { get; set; }

            /// <summary>
            /// Name
            /// The name that you assigned the FAQ when you created or updated the FAQ.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: [a-zA-Z0-9][a-zA-Z0-9_-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// A description of the FAQ.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FileFormat
            /// The format of the input file. You can choose between a basic CSV format, a CSV format that includes
            /// customs attributes in a header, and a JSON format that includes custom attributes.
            /// The format must match the format of the file stored in the S3 bucket identified in the S3Path
            /// parameter.
            /// Valid values are:
            /// CSV CSV_WITH_HEADER JSON
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FileFormat { get; set; }

            /// <summary>
            /// S3Path
            /// The Amazon Simple Storage Service (Amazon S3) location of the FAQ input data.
            /// Required: Yes
            /// Type: S3Path
            /// Update requires: Replacement
            /// </summary>
            public S3Path S3Path { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of a role with permission to access the S3 bucket that contains the
            /// FAQ.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Kendra::Faq";

        public FaqProperties Properties { get; } = new FaqProperties();

    }

    public static class FaqAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
