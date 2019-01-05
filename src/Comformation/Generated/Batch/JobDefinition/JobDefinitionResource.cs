using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition
    /// The AWS::Batch::JobDefinition resource specifies the parameters for an AWS Batch job definition. For more
    /// information, see Job Definitions in the AWS Batch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html
    /// </summary>
    public class JobDefinitionResource : ResourceBase
    {
        public class JobDefinitionProperties
        {
            /// <summary>
            /// Type
            /// The type of job definition.
            /// Required: Yes
            /// Type: String
            /// Update requires: No Interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Parameters
            /// Default parameters or parameter substitution placeholders that are set in the job definition.
            /// Parameters are specified as a key-value pair mapping. For more information about specifying
            /// parameters, see Job Definition Parameters in the AWS Batch User Guide.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No Interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// NodeProperties
            /// An object representing the node properties of a multi-node parallel job.
            /// Required: No
            /// Type: NodeProperties
            /// Update requires: No interruption
            /// </summary>
			public NodeProperties NodeProperties { get; set; }

            /// <summary>
            /// Timeout
            /// Specifies a job timeout configuration.
            /// Required: No
            /// Type: AWS Batch JobDefinition Timeout
            /// Update requires: No Interruption
            /// </summary>
			public Timeout Timeout { get; set; }

            /// <summary>
            /// ContainerProperties
            /// An object with various properties specific to container-based jobs.
            /// Required: No
            /// Type: AWS Batch JobDefinition ContainerProperties
            /// Update requires: No Interruption
            /// </summary>
			public ContainerProperties ContainerProperties { get; set; }

            /// <summary>
            /// JobDefinitionName
            /// The name of the job definition.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobDefinitionName { get; set; }

            /// <summary>
            /// RetryStrategy
            /// The retry strategy to use for failed jobs that are submitted with this job definition.
            /// Required: No
            /// Type: AWS Batch JobDefinition RetryStrategy
            /// Update requires: No Interruption
            /// </summary>
			public RetryStrategy RetryStrategy { get; set; }

        }

        public string Type { get; } = "AWS::Batch::JobDefinition";

        public JobDefinitionProperties Properties { get; } = new JobDefinitionProperties();

    }
}
