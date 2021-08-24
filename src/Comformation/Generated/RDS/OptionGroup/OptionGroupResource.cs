using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.OptionGroup
{
    /// <summary>
    /// AWS::RDS::OptionGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-optiongroup.html
    /// </summary>
    public class OptionGroupResource : ResourceBase
    {
        public class OptionGroupProperties
        {
            /// <summary>
            /// EngineName
            /// Specifies the name of the engine that this option group should be associated with.
            /// Valid Values:
            /// mariadb mysql oracle-ee oracle-se2 oracle-se1 oracle-se postgres sqlserver-ee sqlserver-se
            /// sqlserver-ex sqlserver-web
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineName { get; set; }

            /// <summary>
            /// MajorEngineVersion
            /// Specifies the major version of the engine that this option group should be associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MajorEngineVersion { get; set; }

            /// <summary>
            /// OptionConfigurations
            /// A list of options and the settings for each option.
            /// Required: Conditional
            /// Type: List of OptionConfiguration
            /// Update requires: Replacement
            /// </summary>
            public List<OptionConfiguration> OptionConfigurations { get; set; }

            /// <summary>
            /// OptionGroupDescription
            /// The description of the option group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OptionGroupDescription { get; set; }

            /// <summary>
            /// Tags
            /// Tags to assign to the option group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::RDS::OptionGroup";

        public OptionGroupProperties Properties { get; } = new OptionGroupProperties();

    }
}
