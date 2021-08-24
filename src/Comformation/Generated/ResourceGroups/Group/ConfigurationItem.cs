using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ResourceGroups.Group
{
    /// <summary>
    /// AWS::ResourceGroups::Group ConfigurationItem
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resourcegroups-group-configurationitem.html
    /// </summary>
    public class ConfigurationItem
    {

        /// <summary>
        /// Type
        /// Specifies the type of configuration item. Each item must have a unique value for type. For the list
        /// of the types that you can specify for a configuration item, see Supported resource types and
        /// parameters in the AWS Resource Groups User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Parameters
        /// A collection of parameters for this configuration item. For the list of parameters that you can use
        /// with each configuration item Type, see Supported resource types and parameters in the AWS Resource
        /// Groups User Guide.
        /// Required: No
        /// Type: List of ConfigurationParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public List<ConfigurationParameter> Parameters { get; set; }

    }
}
