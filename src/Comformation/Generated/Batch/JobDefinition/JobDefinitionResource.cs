using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html
    /// </summary>
    public class JobDefinitionResource : ResourceBase
    {
        public class JobDefinitionProperties
        {
            /// <summary>
            /// Type
            /// The type of job definition. For more information about multi-node parallel jobs, see Creating a
            /// multi-node parallel job definition in the AWS Batch User Guide.
            /// Note If the job is run on Fargate resources, then multinode isn&#39;t supported.
            /// Required: Yes
            /// Type: String
            /// Allowed values: container | multinode
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Parameters
            /// Default parameters or parameter substitution placeholders that are set in the job definition.
            /// Parameters are specified as a key-value pair mapping. Parameters in a SubmitJob request override any
            /// corresponding parameter defaults from the job definition. For more information about specifying
            /// parameters, see Job Definition Parameters in the AWS Batch User Guide.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// NodeProperties
            /// An object with various properties specific to multi-node parallel jobs.
            /// Note If the job runs on Fargate resources, then you must not specify nodeProperties; use
            /// containerProperties instead.
            /// Required: No
            /// Type: NodeProperties
            /// Update requires: No interruption
            /// </summary>
            public NodeProperties NodeProperties { get; set; }

            /// <summary>
            /// Timeout
            /// The timeout configuration for jobs that are submitted with this job definition. You can specify a
            /// timeout duration after which AWS Batch terminates your jobs if they haven&#39;t finished.
            /// Required: No
            /// Type: Timeout
            /// Update requires: No interruption
            /// </summary>
            public Timeout Timeout { get; set; }

            /// <summary>
            /// ContainerProperties
            /// An object with various properties specific to container-based jobs.
            /// Required: No
            /// Type: ContainerProperties
            /// Update requires: No interruption
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
            /// PropagateTags
            /// Specifies whether to propagate the tags from the job or job definition to the corresponding Amazon
            /// ECS task. If no value is specified, the tags aren&#39;t propagated. Tags can only be propagated to the
            /// tasks during task creation. For tags with the same name, job tags are given priority over job
            /// definitions tags. If the total number of combined tags from the job and job definition is over 50,
            /// the job is moved to the FAILED state.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> PropagateTags { get; set; }

            /// <summary>
            /// PlatformCapabilities
            /// The platform capabilities required by the job definition. If no value is specified, it defaults to
            /// EC2. Jobs run on Fargate resources specify FARGATE.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> PlatformCapabilities { get; set; }

            /// <summary>
            /// RetryStrategy
            /// The retry strategy to use for failed jobs that are submitted with this job definition.
            /// Required: No
            /// Type: RetryStrategy
            /// Update requires: No interruption
            /// </summary>
            public RetryStrategy RetryStrategy { get; set; }

            /// <summary>
            /// Tags
            /// The tags applied to the job definition.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Batch::JobDefinition";

        public JobDefinitionProperties Properties { get; } = new JobDefinitionProperties();

    }
}
