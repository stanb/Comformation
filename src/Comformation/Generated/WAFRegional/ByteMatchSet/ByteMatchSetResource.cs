using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.ByteMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::ByteMatchSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-bytematchset.html
    /// </summary>
    public class ByteMatchSetResource : ResourceBase
    {
        public class ByteMatchSetProperties
        {
            /// <summary>
            /// ByteMatchTuples
            /// 		
            /// Specifies the bytes (typically a string that corresponds with ASCII characters) that you want AWS
            /// WAF to search for in web requests, the location in requests that you want AWS WAF to search, and
            /// other settings.
            /// 	
            /// Required: No
            /// Type: List of ByteMatchTuple
            /// Update requires: No interruption
            /// </summary>
            public List<ByteMatchTuple> ByteMatchTuples { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the ByteMatchSet. You can&#39;t change Name after you create a
            /// ByteMatchSet.
            /// 	 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::ByteMatchSet";

        public ByteMatchSetProperties Properties { get; } = new ByteMatchSetProperties();

    }
}
