using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster StepConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-stepconfig.html
    /// </summary>
    public class StepConfig
    {

        /// <summary>
        /// ActionOnFailure
        /// The action to take when the cluster step fails. Possible values are CANCEL_AND_WAIT and CONTINUE.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionOnFailure")]
        public Union<string, IntrinsicFunction> ActionOnFailure { get; set; }

        /// <summary>
        /// HadoopJarStep
        /// The JAR file used for the step.
        /// Required: Yes
        /// Type: HadoopJarStepConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HadoopJarStep")]
        public HadoopJarStepConfig HadoopJarStep { get; set; }

        /// <summary>
        /// Name
        /// The name of the step.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
