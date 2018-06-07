using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SizeConstraintSet
{
    /// <summary>
    /// AWS::WAF::SizeConstraintSet
    /// The AWS::WAF::SizeConstraintSet resource specifies a size constraint that AWS WAF uses to check the size of a
    /// web request and which parts of the request to check. For more information, see CreateSizeConstraintSet in the
    /// AWS WAF API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html
    /// </summary>
    public class SizeConstraintSetResource : ResourceBase
    {
        public class SizeConstraintSetProperties
        {
            /// <summary>
            /// Name
            /// A friendly name or description for the SizeConstraintSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SizeConstraints
            /// The size constraint and the part of the web request to check.
            /// Required: Yes
            /// Type: List of AWS WAF SizeConstraintSet SizeConstraint
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-sizeconstraints
            /// </summary>
			public Union<List<SizeConstraint>, IntrinsicFunction> SizeConstraints { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::SizeConstraintSet";
        
        public SizeConstraintSetProperties Properties { get; } = new SizeConstraintSetProperties();
    }
}
