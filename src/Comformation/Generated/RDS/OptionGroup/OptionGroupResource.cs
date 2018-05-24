using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.OptionGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html
    /// </summary>
    public class OptionGroupResource : ResourceBase
    {
        public class OptionGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-enginename
            /// </summary>
			public Union<string, IntrinsicFunction> EngineName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-majorengineversion
            /// </summary>
			public Union<string, IntrinsicFunction> MajorEngineVersion { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-optionconfigurations
            /// </summary>
			public Union<List<OptionConfiguration>, IntrinsicFunction> OptionConfigurations { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-optiongroupdescription
            /// </summary>
			public Union<string, IntrinsicFunction> OptionGroupDescription { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::OptionGroup";
        
        public OptionGroupProperties Properties { get; } = new OptionGroupProperties();
    }
}
