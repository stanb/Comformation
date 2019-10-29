using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.OptionGroup
{
    /// <summary>
    /// AWS::RDS::OptionGroup OptionConfiguration
    /// The OptionConfiguration property type specifies an individual option, and its settings, within an
    /// AWS::RDS::OptionGroup resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html
    /// </summary>
    public class OptionConfiguration
    {

        /// <summary>
        /// DBSecurityGroupMemberships
        /// A list of DBSecurityGroupMembership name strings used for this option.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DBSecurityGroupMemberships")]
        public List<Union<string, IntrinsicFunction>> DBSecurityGroupMemberships { get; set; }

        /// <summary>
        /// OptionName
        /// The configuration of options to include in a group.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OptionName")]
        public Union<string, IntrinsicFunction> OptionName { get; set; }

        /// <summary>
        /// OptionSettings
        /// The option settings to include in an option group.
        /// Required: No
        /// Type: List of OptionSetting
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OptionSettings")]
        public List<OptionSetting> OptionSettings { get; set; }

        /// <summary>
        /// OptionVersion
        /// The version for the option.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OptionVersion")]
        public Union<string, IntrinsicFunction> OptionVersion { get; set; }

        /// <summary>
        /// Port
        /// The optional port for the option.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// VpcSecurityGroupMemberships
        /// A list of VpcSecurityGroupMembership name strings used for this option.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcSecurityGroupMemberships")]
        public List<Union<string, IntrinsicFunction>> VpcSecurityGroupMemberships { get; set; }

    }
}
