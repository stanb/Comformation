using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// PatchSource
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
        /// Required: Yes
        /// Type: String to String map
        /// </summary>
        [JsonProperty("Products")]
        public List<Union<string, IntrinsicFunction>> Products { get; set; }

        /// <summary>
        /// Configuration
        /// The value of the yum repo configuration.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Configuration")]
        public Union<string, IntrinsicFunction> Configuration { get; set; }

        /// <summary>
        /// Name
        /// The name specified to identify the patch source.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
