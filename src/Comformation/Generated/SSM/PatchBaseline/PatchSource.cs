using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.PatchBaseline
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchsource.html
    /// </summary>
    public class PatchSource
    {

        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("Products")]
        public Union<List<string>, IntrinsicFunction> Products { get; set; }

        /// <summary>
        /// Configuration
        /// </summary>
        [JsonProperty("Configuration")]
        public Union<string, IntrinsicFunction> Configuration { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
