using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Pipeline
{
    /// <summary>
    /// AWS::SageMaker::Pipeline
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html
    /// </summary>
    public class PipelineResource : ResourceBase
    {
        public class PipelineProperties
        {
            /// <summary>
            /// PipelineName
            /// The name of the pipeline.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,255}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PipelineName { get; set; }

            /// <summary>
            /// PipelineDisplayName
            /// The display name of the pipeline.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,255}
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PipelineDisplayName { get; set; }

            /// <summary>
            /// PipelineDescription
            /// The description of the pipeline.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 3072
            /// Pattern: . *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PipelineDescription { get; set; }

            /// <summary>
            /// PipelineDefinition
            /// The definition of the pipeline. This can be either a JSON string or an Amazon S3 location.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PipelineDefinition { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role used to execute the pipeline.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// The tags of the pipeline.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Pipeline";

        public PipelineProperties Properties { get; } = new PipelineProperties();

    }
}
