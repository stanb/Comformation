using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Macie.CustomDataIdentifier
{
    /// <summary>
    /// AWS::Macie::CustomDataIdentifier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-macie-customdataidentifier.html
    /// </summary>
    public class CustomDataIdentifierResource : ResourceBase
    {
        public class CustomDataIdentifierProperties
        {
            /// <summary>
            /// Name
            /// A custom name for the custom data identifier. The name can contain as many as 128 characters.
            /// We strongly recommend that you avoid including any sensitive data in the name of a custom data
            /// identifier. Other users of your account might be able to see the identifier&#39;s name, depending on the
            /// actions that they&#39;re allowed to perform in Amazon Macie.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the custom data identifier. The description can contain as many as 512
            /// characters.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Regex
            /// The regular expression (regex) that defines the pattern to match. The expression can contain as many
            /// as 512 characters.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Regex { get; set; }

            /// <summary>
            /// MaximumMatchDistance
            /// The maximum number of characters that can exist between text that matches the regex pattern and the
            /// character sequences specified by the Keywords array. Amazon Macie includes or excludes a result
            /// based on the proximity of a keyword to text that matches the regex pattern. The distance can be
            /// 1-300 characters. The default value is 50.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumMatchDistance { get; set; }

            /// <summary>
            /// Keywords
            /// An array that lists specific character sequences (keywords), one of which must be within proximity
            /// (MaximumMatchDistance) of the regular expression to match. The array can contain as many as 50
            /// keywords. Each keyword can contain 3-90 characters. Keywords aren&#39;t case sensitive.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Keywords { get; set; }

            /// <summary>
            /// IgnoreWords
            /// An array that lists specific character sequences (ignore words) to exclude from the results. If the
            /// text matched by the regular expression is the same as any string in this array, Amazon Macie ignores
            /// it. The array can contain as many as 10 ignore words. Each ignore word can contain 4-90 characters.
            /// Ignore words are case sensitive.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> IgnoreWords { get; set; }

        }

        public string Type { get; } = "AWS::Macie::CustomDataIdentifier";

        public CustomDataIdentifierProperties Properties { get; } = new CustomDataIdentifierProperties();

    }

    public static class CustomDataIdentifierAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedAt");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> Deleted = new ResourceAttribute<Union<bool, IntrinsicFunction>>("Deleted");
    }
}
