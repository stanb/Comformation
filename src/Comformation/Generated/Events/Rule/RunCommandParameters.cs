using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule RunCommandParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandparameters.html
    /// </summary>
    public class RunCommandParameters
    {

        /// <summary>
        /// RunCommandTargets
        /// Currently, we support including only one RunCommandTarget block, which specifies either an array of
        /// InstanceIds or a tag.
        /// Required: Yes
        /// Type: List of RunCommandTarget
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunCommandTargets")]
        public List<RunCommandTarget> RunCommandTargets { get; set; }

    }
}
