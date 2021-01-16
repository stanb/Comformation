using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.StackSet
{
    /// <summary>
    /// AWS::CloudFormation::StackSet OperationPreferences
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html
    /// </summary>
    public class OperationPreferences
    {

        /// <summary>
        /// FailureToleranceCount
        /// The number of accounts, per Region, for which this operation can fail before AWS CloudFormation
        /// stops the operation in that Region. If the operation is stopped in a Region, AWS CloudFormation
        /// doesn&#39;t attempt the operation in any subsequent Regions.
        /// Conditional: You must specify either FailureToleranceCount or FailureTolerancePercentage (but not
        /// both).
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailureToleranceCount")]
        public Union<int, IntrinsicFunction> FailureToleranceCount { get; set; }

        /// <summary>
        /// FailureTolerancePercentage
        /// The percentage of accounts, per Region, for which this stack operation can fail before AWS
        /// CloudFormation stops the operation in that Region. If the operation is stopped in a Region, AWS
        /// CloudFormation doesn&#39;t attempt the operation in any subsequent Regions.
        /// When calculating the number of accounts based on the specified percentage, AWS CloudFormation rounds
        /// down to the next whole number.
        /// Conditional: You must specify either FailureToleranceCount or FailureTolerancePercentage, but not
        /// both.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailureTolerancePercentage")]
        public Union<int, IntrinsicFunction> FailureTolerancePercentage { get; set; }

        /// <summary>
        /// MaxConcurrentCount
        /// The maximum number of accounts in which to perform this operation at one time. This is dependent on
        /// the value of FailureToleranceCount. MaxConcurrentCount is at most one more than the
        /// FailureToleranceCount.
        /// Note that this setting lets you specify the maximum for operations. For large deployments, under
        /// certain circumstances the actual number of accounts acted upon concurrently may be lower due to
        /// service throttling.
        /// Conditional: You must specify either MaxConcurrentCount or MaxConcurrentPercentage, but not both.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConcurrentCount")]
        public Union<int, IntrinsicFunction> MaxConcurrentCount { get; set; }

        /// <summary>
        /// MaxConcurrentPercentage
        /// The maximum percentage of accounts in which to perform this operation at one time.
        /// When calculating the number of accounts based on the specified percentage, AWS CloudFormation rounds
        /// down to the next whole number. This is true except in cases where rounding down would result is
        /// zero. In this case, CloudFormation sets the number as one instead.
        /// Note that this setting lets you specify the maximum for operations. For large deployments, under
        /// certain circumstances the actual number of accounts acted upon concurrently may be lower due to
        /// service throttling.
        /// Conditional: You must specify either MaxConcurrentCount or MaxConcurrentPercentage, but not both.
        /// Required: Conditional
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxConcurrentPercentage")]
        public Union<int, IntrinsicFunction> MaxConcurrentPercentage { get; set; }

        /// <summary>
        /// RegionOrder
        /// The order of the Regions where you want to perform the stack operation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegionOrder")]
        public List<Union<string, IntrinsicFunction>> RegionOrder { get; set; }

    }
}
