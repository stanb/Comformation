using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS Glue Trigger Action
    /// The Action property type specifies the actions that an AWS Glue job trigger initiates when it fires.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// JobName
        /// The name of the associated job. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobName")]
        public Union<string, IntrinsicFunction> JobName { get; set; }

        /// <summary>
        /// Arguments
        /// UTF-8 string–to–UTF-8 string key-value pairs that specify the arguments for the action.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arguments")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Arguments { get; set; }

    }
}
