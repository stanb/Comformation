using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan PredefinedLoadMetricSpecification
    /// The PredefinedLoadMetricSpecification property type specifies a predefined load metric for predictive scaling
    /// to use with AWS Auto Scaling.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedloadmetricspecification.html
    /// </summary>
    public class PredefinedLoadMetricSpecification
    {

        /// <summary>
        /// PredefinedLoadMetricType
        /// The metric type. For more information, see PredefinedLoadMetricSpecification in the AWS Auto Scaling
        /// API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PredefinedLoadMetricType")]
        public Union<string, IntrinsicFunction> PredefinedLoadMetricType { get; set; }

        /// <summary>
        /// ResourceLabel
        /// Identifies the resource associated with the metric type. You can&#39;t specify a resource label unless
        /// the metric type is ALBRequestCountPerTarget and there is a target group for an Application Load
        /// Balancer attached to the Auto Scaling group.
        /// The format is
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt;/targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt;,
        /// where:
        /// app/&amp;lt;load-balancer-name&amp;gt;/&amp;lt;load-balancer-id&amp;gt; is the final portion of the load balancer
        /// ARN. targetgroup/&amp;lt;target-group-name&amp;gt;/&amp;lt;target-group-id&amp;gt; is the final portion of the
        /// target group ARN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public Union<string, IntrinsicFunction> ResourceLabel { get; set; }

    }
}
