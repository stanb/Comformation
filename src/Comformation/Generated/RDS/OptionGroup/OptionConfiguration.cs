using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.OptionGroup
{
    /// <summary>
    /// Amazon Relational Database Service OptionGroup OptionConfiguration
    /// Use the OptionConfigurations property to configure an option and its settings for an AWS::RDS::OptionGroup
    /// resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations.html
    /// </summary>
    public class OptionConfiguration
    {

        /// <summary>
        /// DBSecurityGroupMemberships
        /// A list of database security group names for this option. If the option requires access to a port,
        /// the security groups must allow access to that port. If you specify this property, don&#39;t specify the
        /// VPCSecurityGroupMemberships property.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("DBSecurityGroupMemberships")]
        public Union<List<string>, IntrinsicFunction> DBSecurityGroupMemberships { get; set; }

        /// <summary>
        /// OptionName
        /// The name of the option. For more information about options, see Working with Option Groups in the
        /// Amazon Relational Database Service User Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("OptionName")]
        public Union<string, IntrinsicFunction> OptionName { get; set; }

        /// <summary>
        /// OptionSettings
        /// The settings for this option.
        /// Required: No
        /// Type: List of Amazon RDS OptionGroup OptionSetting
        /// </summary>
        [JsonProperty("OptionSettings")]
        public Union<OptionSetting, IntrinsicFunction> OptionSettings { get; set; }

        /// <summary>
        /// OptionVersion
        /// The version for the option.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("OptionVersion")]
        public Union<string, IntrinsicFunction> OptionVersion { get; set; }

        /// <summary>
        /// Port
        /// The port number that this option uses.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// VpcSecurityGroupMemberships
        /// A list of VPC security group IDs for this option. If the option requires access to a port, the
        /// security groups must allow access to that port. If you specify this property, don&#39;t specify the
        /// DBSecurityGroupMemberships property.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("VpcSecurityGroupMemberships")]
        public Union<List<string>, IntrinsicFunction> VpcSecurityGroupMemberships { get; set; }

    }
}
