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
            /// Required: yes
            /// Type: String
            /// Update requires: No Interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Parameters
            /// Default parameters or parameter substitution placeholders that are set in the job definition.
            /// Parameters are specified as a key-value pair mapping.
            /// Required: yes
            /// Type: JSON object
            /// Update requires: No Interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Timeout
            /// </summary>
			public Union<Timeout, IntrinsicFunction> Timeout { get; set; }

            /// <summary>
            /// ContainerProperties
            /// An object with various properties specific to container-based jobs.
            /// Required: yes
            /// Type: AWS Batch JobDefinition ContainerProperties
            /// Update requires: No Interruption
            /// </summary>
			public Union<ContainerProperties, IntrinsicFunction> ContainerProperties { get; set; }

            /// <summary>
            /// JobDefinitionName
            /// The name of the job definition.
            /// Required: no
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> JobDefinitionName { get; set; }

            /// <summary>
            /// RetryStrategy
            /// The retry strategy to use for failed jobs that are submitted with this job definition.
            /// Required: no
            /// Type: AWS Batch JobDefinition RetryStrategy
            /// Update requires: No Interruption
            /// </summary>
			public Union<RetryStrategy, IntrinsicFunction> RetryStrategy { get; set; }

        }
    
        public string Type { get; } = "AWS::Batch::JobDefinition";
        
        public JobDefinitionProperties Properties { get; } = new JobDefinitionProperties();
    }
}
