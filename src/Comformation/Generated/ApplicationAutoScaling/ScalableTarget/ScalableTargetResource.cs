using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalableTarget
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html
    /// </summary>
    public class ScalableTargetResource : ResourceBase
    {
        public class ScalableTargetProperties
        {
            /// <summary>
            /// MaxCapacity
            /// The maximum value that you plan to scale out to. When a scaling policy is in effect, Application
            /// Auto Scaling can scale out (expand) as needed to the maximum capacity limit in response to changing
            /// demand.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

            /// <summary>
            /// MinCapacity
            /// The minimum value that you plan to scale in to. When a scaling policy is in effect, Application Auto
            /// Scaling can scale in (contract) as needed to the minimum capacity limit in response to changing
            /// demand.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinCapacity { get; set; }

            /// <summary>
            /// ResourceId
            /// The identifier of the resource associated with the scalable target. This string consists of the
            /// resource type and unique identifier.
            /// ECS service - The resource type is service and the unique identifier is the cluster name and service
            /// name. Example: service/default/sample-webapp. Spot Fleet request - The resource type is
            /// spot-fleet-request and the unique identifier is the Spot Fleet request ID. Example:
            /// spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE. EMR cluster - The resource type is
            /// instancegroup and the unique identifier is the cluster ID and instance group ID. Example:
            /// instancegroup/j-2EEZNYKUA1NTV/ig-1791Y4E1L8YI0. AppStream 2. 0 fleet - The resource type is fleet
            /// and the unique identifier is the fleet name. Example: fleet/sample-fleet. DynamoDB table - The
            /// resource type is table and the unique identifier is the table name. Example: table/my-table.
            /// DynamoDB global secondary index - The resource type is index and the unique identifier is the index
            /// name. Example: table/my-table/index/my-table-index. Aurora DB cluster - The resource type is cluster
            /// and the unique identifier is the cluster name. Example: cluster:my-db-cluster. Amazon SageMaker
            /// endpoint variant - The resource type is variant and the unique identifier is the resource ID.
            /// Example: endpoint/my-end-point/variant/KMeansClustering. Custom resources are not supported with a
            /// resource type. This parameter must specify the OutputValue from the CloudFormation template stack
            /// used to access the resources. The unique identifier is defined by the service provider. More
            /// information is available in our GitHub repository. Amazon Comprehend document classification
            /// endpoint - The resource type and unique identifier are specified using the endpoint ARN. Example:
            /// arn:aws:comprehend:us-west-2:123456789012:document-classifier-endpoint/EXAMPLE. Amazon Comprehend
            /// entity recognizer endpoint - The resource type and unique identifier are specified using the
            /// endpoint ARN. Example: arn:aws:comprehend:us-west-2:123456789012:entity-recognizer-endpoint/EXAMPLE.
            /// Lambda provisioned concurrency - The resource type is function and the unique identifier is the
            /// function name with a function version or alias name suffix that is not $LATEST. Example:
            /// function:my-function:prod or function:my-function:1. Amazon Keyspaces table - The resource type is
            /// table and the unique identifier is the table name. Example: keyspace/mykeyspace/table/mytable.
            /// Amazon MSK cluster - The resource type and unique identifier are specified using the cluster ARN.
            /// Example:
            /// arn:aws:kafka:us-east-1:123456789012:cluster/demo-cluster-1/6357e0b2-0e6a-4b86-a0b4-70df934c2e31-5.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// RoleARN
            /// Specify the Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that
            /// allows Application Auto Scaling to modify the scalable target on your behalf. This can be either an
            /// IAM service role that Application Auto Scaling can assume to make calls to other AWS resources on
            /// your behalf, or a service-linked role for the specified service. For more information, see How
            /// Application Auto Scaling works with IAM in the Application Auto Scaling User Guide.
            /// To automatically create a service-linked role (recommended), specify the full ARN of the
            /// service-linked role in your stack template. To find the exact ARN of the service-linked role for
            /// your AWS or custom resource, see the Service-linked roles topic in the Application Auto Scaling User
            /// Guide. Look for the ARN in the table at the bottom of the page.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleARN { get; set; }

            /// <summary>
            /// ScalableDimension
            /// The scalable dimension associated with the scalable target. This string consists of the service
            /// namespace, resource type, and scaling property.
            /// ecs:service:DesiredCount - The desired task count of an ECS service.
            /// ec2:spot-fleet-request:TargetCapacity - The target capacity of a Spot Fleet request.
            /// elasticmapreduce:instancegroup:InstanceCount - The instance count of an EMR Instance Group.
            /// appstream:fleet:DesiredCapacity - The desired capacity of an AppStream 2. 0 fleet.
            /// dynamodb:table:ReadCapacityUnits - The provisioned read capacity for a DynamoDB table.
            /// dynamodb:table:WriteCapacityUnits - The provisioned write capacity for a DynamoDB table.
            /// dynamodb:index:ReadCapacityUnits - The provisioned read capacity for a DynamoDB global secondary
            /// index. dynamodb:index:WriteCapacityUnits - The provisioned write capacity for a DynamoDB global
            /// secondary index. rds:cluster:ReadReplicaCount - The count of Aurora Replicas in an Aurora DB
            /// cluster. Available for Aurora MySQL-compatible edition and Aurora PostgreSQL-compatible edition.
            /// sagemaker:variant:DesiredInstanceCount - The number of EC2 instances for an Amazon SageMaker model
            /// endpoint variant. custom-resource:ResourceType:Property - The scalable dimension for a custom
            /// resource provided by your own application or service.
            /// comprehend:document-classifier-endpoint:DesiredInferenceUnits - The number of inference units for an
            /// Amazon Comprehend document classification endpoint.
            /// comprehend:entity-recognizer-endpoint:DesiredInferenceUnits - The number of inference units for an
            /// Amazon Comprehend entity recognizer endpoint. lambda:function:ProvisionedConcurrency - The
            /// provisioned concurrency for a Lambda function. cassandra:table:ReadCapacityUnits - The provisioned
            /// read capacity for an Amazon Keyspaces table. cassandra:table:WriteCapacityUnits - The provisioned
            /// write capacity for an Amazon Keyspaces table. kafka:broker-storage:VolumeSize - The provisioned
            /// volume size (in GiB) for brokers in an Amazon MSK cluster.
            /// Required: Yes
            /// Type: String
            /// Allowed values: appstream:fleet:DesiredCapacity | cassandra:table:ReadCapacityUnits |
            /// cassandra:table:WriteCapacityUnits | comprehend:document-classifier-endpoint:DesiredInferenceUnits |
            /// comprehend:entity-recognizer-endpoint:DesiredInferenceUnits | custom-resource:ResourceType:Property
            /// | dynamodb:index:ReadCapacityUnits | dynamodb:index:WriteCapacityUnits |
            /// dynamodb:table:ReadCapacityUnits | dynamodb:table:WriteCapacityUnits |
            /// ec2:spot-fleet-request:TargetCapacity | ecs:service:DesiredCount |
            /// elasticmapreduce:instancegroup:InstanceCount | kafka:broker-storage:VolumeSize |
            /// lambda:function:ProvisionedConcurrency | rds:cluster:ReadReplicaCount |
            /// sagemaker:variant:DesiredInstanceCount
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

            /// <summary>
            /// ScheduledActions
            /// The scheduled actions for the scalable target. Duplicates aren&#39;t allowed.
            /// For more information about using scheduled scaling, see Scheduled scaling in the Application Auto
            /// Scaling User Guide.
            /// Required: No
            /// Type: List of ScheduledAction
            /// Update requires: No interruption
            /// </summary>
            public List<ScheduledAction> ScheduledActions { get; set; }

            /// <summary>
            /// ServiceNamespace
            /// The namespace of the AWS service that provides the resource, or a custom-resource.
            /// Required: Yes
            /// Type: String
            /// Allowed values: appstream | cassandra | comprehend | custom-resource | dynamodb | ec2 | ecs |
            /// elasticmapreduce | kafka | lambda | rds | sagemaker
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

            /// <summary>
            /// SuspendedState
            /// An embedded object that contains attributes and attribute values that are used to suspend and resume
            /// automatic scaling. Setting the value of an attribute to true suspends the specified scaling
            /// activities. Setting it to false (default) resumes the specified scaling activities.
            /// Suspension Outcomes
            /// For DynamicScalingInSuspended, while a suspension is in effect, all scale-in activities that are
            /// triggered by a scaling policy are suspended. For DynamicScalingOutSuspended, while a suspension is
            /// in effect, all scale-out activities that are triggered by a scaling policy are suspended. For
            /// ScheduledScalingSuspended, while a suspension is in effect, all scaling activities that involve
            /// scheduled actions are suspended.
            /// For more information, see Suspending and resuming scaling in the Application Auto Scaling User
            /// Guide.
            /// Required: No
            /// Type: SuspendedState
            /// Update requires: No interruption
            /// </summary>
            public SuspendedState SuspendedState { get; set; }

        }

        public string Type { get; } = "AWS::ApplicationAutoScaling::ScalableTarget";

        public ScalableTargetProperties Properties { get; } = new ScalableTargetProperties();

    }
}
