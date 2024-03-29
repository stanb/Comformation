using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html
    /// </summary>
    public class ScalingPolicyResource : ResourceBase
    {
        public class ScalingPolicyProperties
        {
            /// <summary>
            /// PolicyName
            /// The name of the scaling policy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: \p{Print}+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// PolicyType
            /// The Application Auto Scaling policy type.
            /// The following policy types are supported:
            /// TargetTrackingScaling—Not supported for Amazon EMR
            /// StepScaling—Not supported for DynamoDB, Amazon Comprehend, Lambda, Amazon Keyspaces (for Apache
            /// Cassandra), Amazon MSK, or Amazon ElastiCache for Redis.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PolicyType { get; set; }

            /// <summary>
            /// ResourceId
            /// The identifier of the resource associated with the scaling policy. This string consists of the
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
            /// Amazon ElastiCache replication group - The resource type is replication-group and the unique
            /// identifier is the replication group name. Example: replication-group/mycluster.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// ScalableDimension
            /// The scalable dimension. This string consists of the service namespace, resource type, and scaling
            /// property.
            /// ecs:service:DesiredCount - The desired task count of an ECS service.
            /// elasticmapreduce:instancegroup:InstanceCount - The instance count of an EMR Instance Group.
            /// ec2:spot-fleet-request:TargetCapacity - The target capacity of a Spot Fleet request.
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
            /// volume size (in GiB) for brokers in an Amazon MSK cluster. elasticache:replication-group:NodeGroups
            /// - The number of node groups for an Amazon ElastiCache replication group.
            /// elasticache:replication-group:Replicas - The number of replicas per node group for an Amazon
            /// ElastiCache replication group.
            /// Required: No
            /// Type: String
            /// Allowed values: appstream:fleet:DesiredCapacity | cassandra:table:ReadCapacityUnits |
            /// cassandra:table:WriteCapacityUnits | comprehend:document-classifier-endpoint:DesiredInferenceUnits |
            /// comprehend:entity-recognizer-endpoint:DesiredInferenceUnits | custom-resource:ResourceType:Property
            /// | dynamodb:index:ReadCapacityUnits | dynamodb:index:WriteCapacityUnits |
            /// dynamodb:table:ReadCapacityUnits | dynamodb:table:WriteCapacityUnits |
            /// ec2:spot-fleet-request:TargetCapacity | ecs:service:DesiredCount |
            /// elasticache:replication-group:NodeGroups | elasticache:replication-group:Replicas |
            /// elasticmapreduce:instancegroup:InstanceCount | kafka:broker-storage:VolumeSize |
            /// lambda:function:ProvisionedConcurrency | rds:cluster:ReadReplicaCount |
            /// sagemaker:variant:DesiredInstanceCount
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

            /// <summary>
            /// ScalingTargetId
            /// The CloudFormation-generated ID of an Application Auto Scaling scalable target. For more information
            /// about the ID, see the Return Value section of the AWS::ApplicationAutoScaling::ScalableTarget
            /// resource.
            /// Important You must specify either the ScalingTargetId property, or the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ScalingTargetId { get; set; }

            /// <summary>
            /// ServiceNamespace
            /// The namespace of the AWS service that provides the resource, or a custom-resource.
            /// Required: No
            /// Type: String
            /// Allowed values: appstream | cassandra | comprehend | custom-resource | dynamodb | ec2 | ecs |
            /// elasticache | elasticmapreduce | kafka | lambda | rds | sagemaker
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

            /// <summary>
            /// StepScalingPolicyConfiguration
            /// A step scaling policy.
            /// Required: No
            /// Type: StepScalingPolicyConfiguration
            /// Update requires: No interruption
            /// </summary>
            public StepScalingPolicyConfiguration StepScalingPolicyConfiguration { get; set; }

            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// A target tracking scaling policy.
            /// Required: No
            /// Type: TargetTrackingScalingPolicyConfiguration
            /// Update requires: No interruption
            /// </summary>
            public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::ApplicationAutoScaling::ScalingPolicy";

        public ScalingPolicyProperties Properties { get; } = new ScalingPolicyProperties();

    }
}
