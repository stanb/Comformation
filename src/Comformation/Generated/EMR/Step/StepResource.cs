using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Step
{
    /// <summary>
    /// AWS::EMR::Step
    /// The AWS::EMR::Step resource creates a unit of work (a job flow step) that you submit to an Amazon EMR (Amazon
    /// EMR) cluster. The job flow step contains instructions for processing data on the cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html
    /// </summary>
    public class StepResource : ResourceBase
    {
        public class StepProperties
        {
            /// <summary>
            /// ActionOnFailure
            /// The action to take if the job flow step fails. Currently, AWS CloudFormation supports CONTINUE and
            /// CANCEL_AND_WAIT.
            /// 		
            /// 		 		 		 TERMINATE_CLUSTER indicates that all associated cluster resources terminate if the step
            /// fails, and no subsequent steps or jobs are attempted. 		 		 CANCEL_AND_WAIT indicates that the step
            /// is canceled, and all subsequent steps and jobs are attempted. 		
            /// 		
            /// For more information, see Managing Cluster Termination in the Amazon EMR Management Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ActionOnFailure { get; set; }

            /// <summary>
            /// HadoopJarStep
            /// The JAR file that includes the main function that Amazon EMR executes.
            /// Required: Yes
            /// Type: Amazon EMR Step HadoopJarStepConfig
            /// Update requires: Replacement
            /// </summary>
			public Union<HadoopJarStepConfig, IntrinsicFunction> HadoopJarStep { get; set; }

            /// <summary>
            /// JobFlowId
            /// The ID of a cluster in which you want to run this job flow step.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobFlowId { get; set; }

            /// <summary>
            /// Name
            /// A name for the job flow step.
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
