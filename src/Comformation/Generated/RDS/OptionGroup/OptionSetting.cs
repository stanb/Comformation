using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.OptionGroup
{
    /// <summary>
    /// Amazon Relational Database Service OptionGroup OptionSetting
    /// Use the OptionSettings property to specify settings for an option in the OptionConfigurations property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-optiongroup-optionconfigurations-optionsettings.html
    /// </summary>
    public class OptionSetting
    {

        /// <summary>
        /// Name
        /// The name of the option setting that you want to specify.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value of the option setting.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
