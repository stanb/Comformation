using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html
    /// </summary>
    public class HealthCheck
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html#cfn-elb-healthcheck-healthythreshold
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public Union<string, IntrinsicFunction> HealthyThreshold { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html#cfn-elb-healthcheck-interval
        /// </summary>
        [JsonProperty("Interval")]
        public Union<string, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html#cfn-elb-healthcheck-target
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html#cfn-elb-healthcheck-timeout
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<string, IntrinsicFunction> Timeout { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html#cfn-elb-healthcheck-unhealthythreshold
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public Union<string, IntrinsicFunction> UnhealthyThreshold { get; set; }

    }
}
