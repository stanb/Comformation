using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// AWS::SSM::PatchBaseline PatchSource
    /// PatchSource is the property type for the Sources resource of the AWS::SSM::PatchBaseline resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchsource.html
    /// </summary>
    public class PatchSource
    {

        /// <summary>
        /// Products
        /// The specific operating system versions a patch repository applies to, such as &quot;Ubuntu16. 04&quot;,
        /// &quot;AmazonLinux2016. 09&quot;, &quot;RedhatEnterpriseLinux7. 2&quot; or &quot;Suse12. 7&quot;. For lists of supported product
        /// values, see PatchFilter in the AWS Systems Manager API Reference.
        /// Required: No
        /// Type: List of String
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Products")]
        public List<Union<string, IntrinsicFunction>> Products { get; set; }

        /// <summary>
        /// Configuration
        /// The value of the yum repo configuration. For example:
        /// [main]
        /// cachedir=/var/cache/yum/$basesearch$releasever
        /// keepcache=0
        /// debuglevel=2
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Configuration")]
        public Union<string, IntrinsicFunction> Configuration { get; set; }

        /// <summary>
        /// Name
        /// The name specified to identify the patch source.
        /// Required: No
        /// Type: String
        /// Pattern: ^[a-zA-Z0-9_\-. ]{3,50}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
