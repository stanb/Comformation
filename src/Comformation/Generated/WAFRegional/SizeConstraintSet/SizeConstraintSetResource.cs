using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SizeConstraintSet
{
    /// <summary>
    /// AWS::WAFRegional::SizeConstraintSet
    /// A complex type that contains SizeConstraint objects, which specify the parts of web requests that you 			want
    /// AWS WAF to inspect the size of. If a SizeConstraintSet contains more than one SizeConstraint 			object, a
    /// request only needs to match one constraint to be considered a match.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sizeconstraintset.html
    /// </summary>
    public class SizeConstraintSetResource : ResourceBase
    {
        public class SizeConstraintSetProperties
        {
            /// <summary>
            /// SizeConstraints
            /// The size constraint and the part of the web request to check.
            /// 	
            /// Required: No
            /// Type: List of SizeConstraint
            /// Update requires: No interruption
            /// </summary>
			public List<SizeConstraint> SizeConstraints { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name, if any, of the SizeConstraintSet.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::SizeConstraintSet";

        public SizeConstraintSetProperties Properties { get; } = new SizeConstraintSetProperties();

    }
}
