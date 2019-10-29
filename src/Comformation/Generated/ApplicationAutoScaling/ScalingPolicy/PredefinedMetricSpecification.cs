using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy PredefinedMetricSpecification
    /// PredefinedMetricSpecification is a subproperty of TargetTrackingScalingPolicyConfiguration that configures a
    /// predefined metric for a target tracking scaling policy to use with Application Auto Scaling.
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
        /// Allowed Values: ALBRequestCountPerTarget | DynamoDBReadCapacityUtilization |
        /// DynamoDBWriteCapacityUtilization | EC2SpotFleetRequestAverageCPUUtilization |
        /// EC2SpotFleetRequestAverageNetworkIn | EC2SpotFleetRequestAverageNetworkOut |
        /// ECSServiceAverageCPUUtilization | ECSServiceAverageMemoryUtilization |
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
        /// The format is
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt;/targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt;,
        /// where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the target
        /// group ARN.
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
