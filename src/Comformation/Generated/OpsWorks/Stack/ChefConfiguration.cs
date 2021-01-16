using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS::OpsWorks::Stack ChefConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-chefconfiguration.html
    /// </summary>
    public class ChefConfiguration
    {

        /// <summary>
        /// BerkshelfVersion
        /// The Berkshelf version.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BerkshelfVersion")]
        public Union<string, IntrinsicFunction> BerkshelfVersion { get; set; }

        /// <summary>
        /// ManageBerkshelf
        /// Whether to enable Berkshelf.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManageBerkshelf")]
        public Union<bool, IntrinsicFunction> ManageBerkshelf { get; set; }

    }
}
