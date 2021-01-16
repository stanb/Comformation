using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion ComponentDependencyRequirement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-componentdependencyrequirement.html
    /// </summary>
    public class ComponentDependencyRequirement
    {

        /// <summary>
        /// VersionRequirement
        /// The component version requirement for the component dependency.
        /// AWS IoT Greengrass uses semantic version constraints. For more information, see Semantic Versioning.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VersionRequirement")]
        public Union<string, IntrinsicFunction> VersionRequirement { get; set; }

        /// <summary>
        /// DependencyType
        /// The type of this dependency. Choose from the following options:
        /// SOFT – The component doesn&#39;t restart if the dependency changes state. HARD – The component restarts
        /// if the dependency changes state.
        /// Default: HARD
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DependencyType")]
        public Union<string, IntrinsicFunction> DependencyType { get; set; }

    }
}
