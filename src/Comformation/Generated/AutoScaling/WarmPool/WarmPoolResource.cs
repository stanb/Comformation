using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.WarmPool
{
    /// <summary>
    /// AWS::AutoScaling::WarmPool
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html
    /// </summary>
    public class WarmPoolResource : ResourceBase
    {
        public class WarmPoolProperties
        {
            /// <summary>
            /// AutoScalingGroupName
            /// The name of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// MaxGroupPreparedCapacity
            /// Specifies the maximum number of instances that are allowed to be in the warm pool or in any state
            /// except Terminated for the Auto Scaling group. This is an optional property. Specify it only if you
            /// do not want the warm pool size to be determined by the difference between the group&#39;s maximum
            /// capacity and its desired capacity.
            /// Important If a value for MaxGroupPreparedCapacity is not specified, Amazon EC2 Auto Scaling launches
            /// and maintains the difference between the group&#39;s maximum capacity and its desired capacity. If you
            /// specify a value for MaxGroupPreparedCapacity, Amazon EC2 Auto Scaling uses the difference between
            /// the MaxGroupPreparedCapacity and the desired capacity instead. The size of the warm pool is dynamic.
            /// Only when MaxGroupPreparedCapacity and MinSize are set to the same value does the warm pool have an
            /// absolute size.
            /// If the desired capacity of the Auto Scaling group is higher than the MaxGroupPreparedCapacity, the
            /// capacity of the warm pool is 0, unless you specify a value for MinSize. To remove a value that you
            /// previously set, include the property but specify -1 for the value.
            /// Required: No
            /// Type: Integer
            /// Minimum: -1
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxGroupPreparedCapacity { get; set; }

            /// <summary>
            /// MinSize
            /// Specifies the minimum number of instances to maintain in the warm pool. This helps you to ensure
            /// that there is always a certain number of warmed instances available to handle traffic spikes.
            /// Defaults to 0 if not specified.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// PoolState
            /// Sets the instance state to transition to after the lifecycle actions are complete. Default is
            /// Stopped.
            /// Required: No
            /// Type: String
            /// Allowed values: Running | Stopped
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PoolState { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::WarmPool";

        public WarmPoolProperties Properties { get; } = new WarmPoolProperties();

    }
}
