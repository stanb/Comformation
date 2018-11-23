using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS AppSync Resolver PipelineConfig
    /// Use the PipelineConfig property type to specify PipelineConfig for an AWS AppSync resolver.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-pipelineconfig.html
    /// </summary>
    public class PipelineConfig
    {

        /// <summary>
        /// Functions
        /// The FunctionsIds of the functions attached with the resolver.
        /// Required: No
        /// Type: Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Functions")]
        public List<Union<string, IntrinsicFunction>> Functions { get; set; }

    }
}
