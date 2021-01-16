using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan PredefinedScalingMetricSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedscalingmetricspecification.html
    /// </summary>
    public class PredefinedScalingMetricSpecification
    {

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBRequestCountPerTarget and there is a target group for an Application Load
        /// Balancer attached to the Auto Scaling group, Spot Fleet request, or ECS service.
        /// You create the resource label by appending the final portion of the load balancer ARN and the final
        /// portion of the target group ARN into a single value, separated by a forward slash (/). The format is
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt;/targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt;,
        /// where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the target
        /// group ARN.
        /// This is an example:
        /// app/EC2Co-EcsEl-1TKLTMITMM0EO/f37c06a68c1748aa/targetgroup/EC2Co-Defau-LDNM7Q3ZH1ZN/6d4ea56ca2d6a18d.
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

        /// <summary>
        /// PredefinedScalingMetricType
        /// The metric type. The ALBRequestCountPerTarget metric type applies only to Auto Scaling groups, Spot
        /// Fleet requests, and ECS services.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ALBRequestCountPerTarget | ASGAverageCPUUtilization | ASGAverageNetworkIn |
        /// ASGAverageNetworkOut | DynamoDBReadCapacityUtilization | DynamoDBWriteCapacityUtilization |
        /// EC2SpotFleetRequestAverageCPUUtilization | EC2SpotFleetRequestAverageNetworkIn |
        /// EC2SpotFleetRequestAverageNetworkOut | ECSServiceAverageCPUUtilization |
        /// ECSServiceAverageMemoryUtilization | RDSReaderAverageCPUUtilization |
        /// RDSReaderAverageDatabaseConnections
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedScalingMetricType")]
        public Union<string, IntrinsicFunction> PredefinedScalingMetricType { get; set; }

    }
}
