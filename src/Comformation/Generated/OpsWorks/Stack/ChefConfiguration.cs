using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS OpsWorks ChefConfiguration Type
    /// Describes the Chef configuration for the AWS::OpsWorks::Stack resource type. For more information, see
    /// ChefConfiguration in the AWS OpsWorks Stacks API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-chefconfiguration.html
    /// </summary>
    public class ChefConfiguration
    {

        /// <summary>
        /// BerkshelfVersion
        /// The Berkshelf version.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("BerkshelfVersion")]
        public Union<string, IntrinsicFunction> BerkshelfVersion { get; set; }

        /// <summary>
        /// ManageBerkshelf
        /// Whether to enable Berkshelf.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("ManageBerkshelf")]
        public Union<bool, IntrinsicFunction> ManageBerkshelf { get; set; }

    }
}
