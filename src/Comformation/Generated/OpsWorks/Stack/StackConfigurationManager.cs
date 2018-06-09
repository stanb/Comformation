using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS OpsWorks StackConfigurationManager Type
    /// Describes the stack configuration manager for the AWS::OpsWorks::Stack resource type. For more information,
    /// see StackConfigurationManager in the AWS OpsWorks Stacks API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-stackconfigmanager.html
    /// </summary>
    public class StackConfigurationManager
    {

        /// <summary>
        /// Name
        /// The name of the configuration manager.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Version
        /// The Chef version.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
