using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.CapacityProvider
{
    /// <summary>
    /// AWS::ECS::CapacityProvider AutoScalingGroupProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-autoscalinggroupprovider.html
    /// </summary>
    public class AutoScalingGroupProvider
    {

        /// <summary>
        /// AutoScalingGroupArn
        /// The Amazon Resource Name (ARN) or short name that identifies the Auto Scaling group.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AutoScalingGroupArn")]
        public Union<string, IntrinsicFunction> AutoScalingGroupArn { get; set; }

        /// <summary>
        /// ManagedScaling
        /// 		
        /// The managed scaling settings for the Auto Scaling group capacity provider.
        /// 	
        /// Required: No
        /// Type: ManagedScaling
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ManagedScaling")]
        public ManagedScaling ManagedScaling { get; set; }

        /// <summary>
        /// ManagedTerminationProtection
        /// 		
        /// The managed termination protection setting to use for the Auto Scaling group capacity 			provider.
        /// This determines whether the Auto Scaling group has managed termination 			protection.
        /// 		
        /// Important When using managed termination protection, managed scaling must also be used 				otherwise
        /// managed termination protection will not work.
        /// 		
        /// When managed termination protection is enabled, Amazon ECS prevents the Amazon EC2 instances in
        /// 			an Auto Scaling group that contain tasks from being terminated during a scale-in action. 			The
        /// Auto Scaling group and each instance in the Auto Scaling group must have instance 			protection from
        /// scale-in actions enabled as well. For more information, see Instance Protection in the AWS Auto
        /// Scaling User Guide.
        /// 		
        /// When managed termination protection is disabled, your Amazon EC2 instances are not 			protected from
        /// termination when the Auto Scaling group scales in.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ManagedTerminationProtection")]
        public Union<string, IntrinsicFunction> ManagedTerminationProtection { get; set; }

    }
}
