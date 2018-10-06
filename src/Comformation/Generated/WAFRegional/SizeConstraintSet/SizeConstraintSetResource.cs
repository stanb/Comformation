using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SizeConstraintSet
{
    /// <summary>
    /// AWS::WAFRegional::SizeConstraintSet
    /// The AWS::WAFRegional::SizeConstraintSet resource specifies a size constraint that AWS WAF uses to check the
    /// size of a web request and which parts of the request to check. For more information, see
    /// CreateSizeConstraintSet in the AWS WAF Regional API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-sizeconstraintset.html
    /// </summary>
    public class SizeConstraintSetResource : ResourceBase
    {
        public class SizeConstraintSetProperties
        {
            /// <summary>
            /// SizeConstraints
            /// The size constraint and the part of the web request to check.
            /// Required: Yes
            /// Type: List of AWS WAF Regional SizeConstraintSet SizeConstraint
            /// Update requires: No interruption
            /// </summary>
			public List<SizeConstraint> SizeConstraints { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description for the SizeConstraintSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAFRegional::SizeConstraintSet";
        
        public SizeConstraintSetProperties Properties { get; } = new SizeConstraintSetProperties();

    }
}
