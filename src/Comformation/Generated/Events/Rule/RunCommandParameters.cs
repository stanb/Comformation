using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule RunCommandParameters
    /// The RunCommandParameters property type specifies the parameters to use when a rule invokes the AWS Systems
    /// Manager Run Command.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandparameters.html
    /// </summary>
    public class RunCommandParameters
    {

        /// <summary>
        /// RunCommandTargets
        /// The criteria (either InstanceIds or a tag) that specifies which EC2 instances the command is sent
        /// to.
        /// Note Currently, you can include only one RunCommandTarget block, which specifies a list of
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
