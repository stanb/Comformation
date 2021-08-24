using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html
    /// </summary>
    public class ComputeEnvironmentResource : ResourceBase
    {
        public class ComputeEnvironmentProperties
        {
            /// <summary>
            /// Type
            /// The type of the compute environment: MANAGED or UNMANAGED. For more information, see Compute
            /// Environments in the AWS Batch User Guide.
            /// Required: Yes
            /// Type: String
            /// Allowed values: MANAGED | UNMANAGED
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// ServiceRole
            /// The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS
            /// services on your behalf. For more information, see AWS Batch service IAM role in the AWS Batch User
            /// Guide.
            /// Important If your account already created the AWS Batch service-linked role, that role is used by
            /// default for your compute environment unless you specify a different role here. If the AWS Batch
            /// service-linked role doesn&#39;t exist in your account, and no role is specified here, the service
            /// attempts to create the AWS Batch service-linked role in your account.
            /// If your specified role has a path other than /, then you must specify either the full role ARN
            /// (recommended) or prefix the role name with the path. For example, if a role with the name bar has a
            /// path of /foo/ then you would specify /foo/bar as the role name. For more information, see Friendly
            /// names and paths in the IAM User Guide.
            /// Note Depending on how you created your AWS Batch service role, its ARN might contain the
            /// service-role path prefix. When you only specify the name of the service role, AWS Batch assumes that
            /// your ARN doesn&#39;t use the service-role path prefix. Because of this, we recommend that you specify
            /// the full ARN of your service role when you create compute environments.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// ComputeEnvironmentName
            /// The name for your compute environment. Up to 128 letters (uppercase and lowercase), numbers,
            /// hyphens, and underscores are allowed.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ComputeEnvironmentName { get; set; }

            /// <summary>
            /// ComputeResources
            /// The ComputeResources property type specifies details of the compute resources managed by the compute
            /// environment. This parameter is required for managed compute environments. For more information, see
            /// Compute Environments in the AWS Batch User Guide.
            /// Required: No
            /// Type: ComputeResources
            /// Update requires: No interruption
            /// </summary>
            public ComputeResources ComputeResources { get; set; }

            /// <summary>
            /// State
            /// The state of the compute environment. If the state is ENABLED, then the compute environment accepts
            /// jobs from a queue and can scale out automatically based on queues.
            /// If the state is ENABLED, then the AWS Batch scheduler can attempt to place jobs from an associated
            /// job queue on the compute resources within the environment. If the compute environment is managed,
            /// then it can scale its instances out or in automatically, based on the job queue demand.
            /// If the state is DISABLED, then the AWS Batch scheduler doesn&#39;t attempt to place jobs within the
            /// environment. Jobs in a STARTING or RUNNING state continue to progress normally. Managed compute
            /// environments in the DISABLED state don&#39;t scale out. However, they scale in to minvCpus value after
            /// instances become idle.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// Tags
            /// The tags applied to the compute environment.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Batch::ComputeEnvironment";

        public ComputeEnvironmentProperties Properties { get; } = new ComputeEnvironmentProperties();

    }
}
