using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.ByteMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::ByteMatchSet
    /// The AWS::WAFRegional::ByteMatchSet resource creates an AWS WAF Regional ByteMatchSet that identifies a part of
    /// a web request that you want to inspect. For more information, see CreateByteMatchSet in the AWS WAF Regional
    /// API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-bytematchset.html
    /// </summary>
    public class ByteMatchSetResource : ResourceBase
    {
        public class ByteMatchSetProperties
        {
            /// <summary>
            /// ByteMatchTuples
            /// Settings for the ByteMatchSet, such as the bytes (typically a string that corresponds with ASCII
            /// characters) that you want AWS WAF to search for in web requests.
            /// Required: No
            /// Type: List of AWS WAF Regional ByteMatchSet ByteMatchTuples
            /// Update requires: No interruption
            /// </summary>
			public List<ByteMatchTuple> ByteMatchTuples { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the ByteMatchSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::ByteMatchSet";

        public ByteMatchSetProperties Properties { get; } = new ByteMatchSetProperties();

    }
}
