using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster StepConfig
    /// StepConfig is a property of the AWS::EMR::Cluster resource. The StepConfig property type specifies a cluster
    /// (job flow) step, which runs only on the master node. Steps are used to submit data processing jobs to the
    /// cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-stepconfig.html
    /// </summary>
    public class StepConfig
    {

        /// <summary>
        /// ActionOnFailure
        /// The action to take when the cluster step fails. Possible values are TERMINATE_CLUSTER,
        /// CANCEL_AND_WAIT, and CONTINUE. TERMINATE_JOB_FLOW is provided for backward compatibility. We
        /// recommend using TERMINATE_CLUSTER instead.
        /// Required: No
        /// Type: String
        /// Allowed Values: CANCEL_AND_WAIT | CONTINUE | TERMINATE_CLUSTER | TERMINATE_JOB_FLOW
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
