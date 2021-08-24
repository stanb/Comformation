using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ResourceGroups.Group
{
    /// <summary>
    /// AWS::ResourceGroups::Group ConfigurationParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-configurationparameter.html
    /// </summary>
    public class ConfigurationParameter
    {

        /// <summary>
        /// Name
        /// The name of the group configuration parameter. For the list of parameters that you can use with each
        /// configuration item type, see Supported resource types and parameters in the AWS Resource Groups User
        /// Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Values
        /// The value or values to be used for the specified parameter. For the list of values you can use with
        /// each parameter, see Supported resource types and parameters.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
