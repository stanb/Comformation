using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy PredefinedMetricSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predefinedmetricspecification.html
    /// </summary>
    public class PredefinedMetricSpecification
    {

        /// <summary>
        /// PredefinedMetricType
        /// The metric type. The ALBRequestCountPerTarget metric type applies only to Spot fleet requests and
        /// ECS services.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALBRequestCountPerTarget | AppStreamAverageCapacityUtilization |
        /// CassandraReadCapacityUtilization | CassandraWriteCapacityUtilization |
        /// ComprehendInferenceUtilization | DynamoDBReadCapacityUtilization | DynamoDBWriteCapacityUtilization
        /// | EC2SpotFleetRequestAverageCPUUtilization | EC2SpotFleetRequestAverageNetworkIn |
        /// EC2SpotFleetRequestAverageNetworkOut | ECSServiceAverageCPUUtilization |
        /// ECSServiceAverageMemoryUtilization | ElastiCacheDatabaseMemoryUsageCountedForEvictPercentage |
        /// ElastiCachePrimaryEngineCPUUtilization | ElastiCacheReplicaEngineCPUUtilization |
        /// KafkaBrokerStorageUtilization | LambdaProvisionedConcurrencyUtilization |
        /// RDSReaderAverageCPUUtilization | RDSReaderAverageDatabaseConnections |
        /// SageMakerVariantInvocationsPerInstance
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public Union<string, IntrinsicFunction> PredefinedMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBRequestCountPerTarget and there is a target group attached to the Spot Fleet
        /// request or ECS service.
        /// You create the resource label by appending the final portion of the load balancer ARN and the final
        /// portion of the target group ARN into a single value, separated by a forward slash (/). The format of
        /// the resource label is:
        /// app/my-alb/778d41231b141a0f/targetgroup/my-alb-target-group/943f017f100becff.
        /// Where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the target
        /// group ARN.
        /// To find the ARN for an Application Load Balancer, use the DescribeLoadBalancers API operation. To
        /// find the ARN for the target group, use the DescribeTargetGroups API operation.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1023
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

    }
}
