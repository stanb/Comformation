using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Instance
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html
    /// </summary>
    public class TimeBasedAutoScaling
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-friday
        /// </summary>
        [JsonProperty("Friday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Friday { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-monday
        /// </summary>
        [JsonProperty("Monday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Monday { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-saturday
        /// </summary>
        [JsonProperty("Saturday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Saturday { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-sunday
        /// </summary>
        [JsonProperty("Sunday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Sunday { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-thursday
        /// </summary>
        [JsonProperty("Thursday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Thursday { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-tuesday
        /// </summary>
        [JsonProperty("Tuesday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Tuesday { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html#cfn-opsworks-instance-timebasedautoscaling-wednesday
        /// </summary>
        [JsonProperty("Wednesday")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Wednesday { get; set; }

    }
}
