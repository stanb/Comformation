using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.OptionGroup
{
    /// <summary>
    /// AWS::RDS::OptionGroup
    /// Use the AWS::RDS::OptionGroup resource to create an option group that can make managing data and databases
    /// easier. For more information about option groups, see Working with Option Groups in the Amazon Relational
    /// Database Service User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html
    /// </summary>
    public class OptionGroupResource : ResourceBase
    {
        public class OptionGroupProperties
        {
            /// <summary>
            /// EngineName
            /// The name of the database engine that this option group is associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-enginename
            /// </summary>
			public Union<string, IntrinsicFunction> EngineName { get; set; }

            /// <summary>
            /// MajorEngineVersion
            /// The major version number of the database engine that this option group is associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-majorengineversion
            /// </summary>
			public Union<string, IntrinsicFunction> MajorEngineVersion { get; set; }

            /// <summary>
            /// OptionConfigurations
            /// The configurations for this option group.
            /// Required: Yes
            /// Type: List of Amazon RDS OptionGroup OptionConfiguration
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-optionconfigurations
            /// </summary>
			public Union<List<OptionConfiguration>, IntrinsicFunction> OptionConfigurations { get; set; }

            /// <summary>
            /// OptionGroupDescription
            /// A description of the option group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-optiongroupdescription
            /// </summary>
			public Union<string, IntrinsicFunction> OptionGroupDescription { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this option group.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html#cfn-rds-optiongroup-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::OptionGroup";
        
        public OptionGroupProperties Properties { get; } = new OptionGroupProperties();
    }
}
