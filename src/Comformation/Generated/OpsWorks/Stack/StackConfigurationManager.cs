using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS::OpsWorks::Stack StackConfigurationManager
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-stackconfigmanager.html
    /// </summary>
    public class StackConfigurationManager
    {

        /// <summary>
        /// Name
        /// The name. This parameter must be set to Chef.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Version
        /// The Chef version. This parameter must be set to 12, 11. 10, or 11. 4 for Linux stacks, and to 12. 2
        /// for Windows stacks. The default value for Linux stacks is 12.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
