using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable CapacityAutoScalingSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-capacityautoscalingsettings.html
    /// </summary>
    public class CapacityAutoScalingSettings
    {

        /// <summary>
        /// MinCapacity
        /// The minimum provisioned capacity units for the global table.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

        /// <summary>
        /// MaxCapacity
        /// The maximum provisioned capacity units for the global table.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        /// SeedCapacity
        /// When switching billing mode from PAY_PER_REQUEST to PROVISIONED, DynamoDB requires you to specify
        /// read and write capacity unit values for the table and for each global secondary index. These values
        /// will be applied to all replicas. The table will use these provisioned values until CloudFormation
        /// creates the autoscaling policies you configured in your template. CloudFormation cannot determine
        /// what capacity the table and its global secondary indexes will require in this time period, since
        /// they are application-dependent.
        /// If you want to switch a table&#39;s billing mode from PAY_PER_REQUEST to PROVISIONED, you must specify a
        /// value for this property for each autoscaled resource. If you specify different values for the same
        /// resource in different regions, CloudFormation will use the highest value found in either the
        /// SeedCapacity or ReadCapacityUnits properties. For example, if your global secondary index myGSI has
        /// a SeedCapacity of 10 in us-east-1 and a fixed ReadCapacityUnits of 20 in eu-west-1, CloudFormation
        /// will initially set the read capacity for myGSI to 20. Note that if you disable ScaleIn for myGSI in
        /// us-east-1, its read capacity units might not be set back to 10.
        /// You must also specify a value for SeedCapacity when you plan to switch a table&#39;s billing mode from
        /// PROVISIONED to PAY_PER_REQUEST, because CloudFormation might need to roll back the operation
        /// (reverting the billing mode to PROVISIONED) and this cannot succeed without specifying a value for
        /// SeedCapacity.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SeedCapacity")]
        public Union<int, IntrinsicFunction> SeedCapacity { get; set; }

        /// <summary>
        /// TargetTrackingScalingPolicyConfiguration
        /// Defines a target tracking scaling policy.
        /// Required: Yes
        /// Type: TargetTrackingScalingPolicyConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetTrackingScalingPolicyConfiguration")]
        public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration { get; set; }

    }
}
