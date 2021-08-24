using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition EvaluateOnExit
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-evaluateonexit.html
    /// </summary>
    public class EvaluateOnExit
    {

        /// <summary>
        /// Action
        /// Specifies the action to take if all of the specified conditions (onStatusReason, onReason, and
        /// onExitCode) are met. The values aren&#39;t case sensitive.
        /// Required: Yes
        /// Type: String
        /// Allowed values: EXIT | RETRY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// OnExitCode
        /// Contains a glob pattern to match against the decimal representation of the ExitCode returned for a
        /// job. The pattern can be up to 512 characters in length. It can contain only numbers, and can
        /// optionally end with an asterisk (*) so that only the start of the string needs to be an exact match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnExitCode")]
        public Union<string, IntrinsicFunction> OnExitCode { get; set; }

        /// <summary>
        /// OnReason
        /// Contains a glob pattern to match against the Reason returned for a job. The pattern can be up to 512
        /// characters in length. It can contain letters, numbers, periods (. ), colons (:), and white space
        /// (including spaces and tabs). It can optionally end with an asterisk (*) so that only the start of
        /// the string needs to be an exact match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnReason")]
        public Union<string, IntrinsicFunction> OnReason { get; set; }

        /// <summary>
        /// OnStatusReason
        /// Contains a glob pattern to match against the StatusReason returned for a job. The pattern can be up
        /// to 512 characters in length. It can contain letters, numbers, periods (. ), colons (:), and white
        /// space (including spaces or tabs). It can optionally end with an asterisk (*) so that only the start
        /// of the string needs to be an exact match.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnStatusReason")]
        public Union<string, IntrinsicFunction> OnStatusReason { get; set; }

    }
}
