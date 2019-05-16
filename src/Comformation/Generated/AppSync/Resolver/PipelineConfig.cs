using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS::AppSync::Resolver PipelineConfig
    /// Use the PipelineConfig property type to specify PipelineConfig for an AWS AppSync resolver.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-pipelineconfig.html
    /// </summary>
    public class PipelineConfig
    {

        /// <summary>
        /// Functions
        /// A list of Function objects.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Functions")]
        public List<Union<string, IntrinsicFunction>> Functions { get; set; }

    }
}
