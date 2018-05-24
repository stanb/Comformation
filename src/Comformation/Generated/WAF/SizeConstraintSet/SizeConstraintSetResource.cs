using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SizeConstraintSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html
    /// </summary>
    public class SizeConstraintSetResource : ResourceBase
    {
        public class SizeConstraintSetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-sizeconstraints
            /// </summary>
			public Union<List<SizeConstraint>, IntrinsicFunction> SizeConstraints { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::SizeConstraintSet";
        
        public SizeConstraintSetProperties Properties { get; } = new SizeConstraintSetProperties();
    }
}
