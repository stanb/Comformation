using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS::AutoScalingPlans::ScalingPlan PredefinedScalingMetricSpecification
    /// PredefinedScalingMetricSpecification is a subproperty of TargetTrackingConfiguration that specifies a
    /// customized scaling metric for a target tracking configuration to use with AWS Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedscalingmetricspecification.html
    /// </summary>
    public class PredefinedScalingMetricSpecification
    {

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBRequestCountPerTarget and there is a target group for an Application Load
        /// Balancer attached to the Auto Scaling group, Spot Fleet request, or ECS service.
        /// The format is
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt;/targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt;,
        /// where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN. targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the
        /// target group ARN.
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
        /// Allowed Values: ALBRequestCountPerTarget | ASGAverageCPUUtilization | ASGAverageNetworkIn |
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
