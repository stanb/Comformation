using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer Recipes
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html
    /// </summary>
    public class Recipes
    {

        /// <summary>
        /// Configure
        /// An array of custom recipe names to be run following a configure event.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Configure")]
        public List<Union<string, IntrinsicFunction>> Configure { get; set; }

        /// <summary>
        /// Deploy
        /// An array of custom recipe names to be run following a deploy event.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Deploy")]
        public List<Union<string, IntrinsicFunction>> Deploy { get; set; }

        /// <summary>
        /// Setup
        /// An array of custom recipe names to be run following a setup event.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Setup")]
        public List<Union<string, IntrinsicFunction>> Setup { get; set; }

        /// <summary>
        /// Shutdown
        /// An array of custom recipe names to be run following a shutdown event.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Shutdown")]
        public List<Union<string, IntrinsicFunction>> Shutdown { get; set; }

        /// <summary>
        /// Undeploy
        /// An array of custom recipe names to be run following a undeploy event.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Undeploy")]
        public List<Union<string, IntrinsicFunction>> Undeploy { get; set; }

    }
}
