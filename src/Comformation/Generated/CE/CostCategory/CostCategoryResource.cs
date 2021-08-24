using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CE.CostCategory
{
    /// <summary>
    /// AWS::CE::CostCategory
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html
    /// </summary>
    public class CostCategoryResource : ResourceBase
    {
        public class CostCategoryProperties
        {
            /// <summary>
            /// Name
            /// The unique name of the Cost Category.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RuleVersion
            /// The rule schema version in this particular Cost Category.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleVersion { get; set; }

            /// <summary>
            /// Rules
            /// The array of CostCategoryRule in JSON array format.
            /// Note Rules are processed in order. If there are multiple rules that match the line item, then the
            /// first rule to match is used to determine that Cost Category value.
            /// Required: Yes
            /// Type: String
            /// Maximum: 500
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Rules { get; set; }

            /// <summary>
            /// DefaultValue
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultValue { get; set; }

        }

        public string Type { get; } = "AWS::CE::CostCategory";

        public CostCategoryProperties Properties { get; } = new CostCategoryProperties();

    }

    public static class CostCategoryAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EffectiveStart = new ResourceAttribute<Union<string, IntrinsicFunction>>("EffectiveStart");
    }
}
