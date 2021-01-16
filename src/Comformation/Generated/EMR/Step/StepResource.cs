using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Step
{
    /// <summary>
    /// AWS::EMR::Step
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html
    /// </summary>
    public class StepResource : ResourceBase
    {
        public class StepProperties
        {
            /// <summary>
            /// ActionOnFailure
            /// This specifies what action to take when the cluster step fails. Possible values are CANCEL_AND_WAIT
            /// and CONTINUE.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ActionOnFailure { get; set; }

            /// <summary>
            /// HadoopJarStep
            /// The HadoopJarStepConfig property type specifies a job flow step consisting of a JAR file whose main
            /// function will be executed. The main function submits a job for the cluster to execute as a step on
            /// the master node, and then waits for the job to finish or fail before executing subsequent steps.
            /// Required: Yes
            /// Type: HadoopJarStepConfig
            /// Update requires: Replacement
            /// </summary>
            public HadoopJarStepConfig HadoopJarStep { get; set; }

            /// <summary>
            /// JobFlowId
            /// A string that uniquely identifies the cluster (job flow).
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> JobFlowId { get; set; }

            /// <summary>
            /// Name
            /// The name of the cluster step.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::EMR::Step";

        public StepProperties Properties { get; } = new StepProperties();

    }
}
