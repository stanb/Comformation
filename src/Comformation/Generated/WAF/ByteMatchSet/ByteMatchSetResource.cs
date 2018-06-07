using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.ByteMatchSet
{
    /// <summary>
    /// AWS::WAF::ByteMatchSet
    /// The AWS::WAF::ByteMatchSet resource creates an AWS WAF ByteMatchSet that identifies a part of a web request
    /// that you want to inspect. For more information, see CreateByteMatchSet in the AWS WAF API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-bytematchset.html
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
            /// Type: List of AWS WAF ByteMatchSet ByteMatchTuples
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-bytematchset.html#cfn-waf-bytematchset-bytematchtuples
            /// </summary>
			public Union<List<ByteMatchTuple>, IntrinsicFunction> ByteMatchTuples { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the ByteMatchSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-bytematchset.html#cfn-waf-bytematchset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::ByteMatchSet";
        
        public ByteMatchSetProperties Properties { get; } = new ByteMatchSetProperties();
    }
}
