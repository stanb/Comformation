using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.DeploymentStrategy
{
    /// <summary>
    /// AWS::AppConfig::DeploymentStrategy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deploymentstrategy.html
    /// </summary>
    public class DeploymentStrategyResource : ResourceBase
    {
        public class DeploymentStrategyProperties
        {
            /// <summary>
            /// ReplicateTo
            /// Save the deployment strategy to a Systems Manager (SSM) document.
            /// Required: Yes
            /// Type: String
            /// Allowed values: NONE | SSM_DOCUMENT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ReplicateTo { get; set; }

            /// <summary>
            /// GrowthType
            /// The algorithm used to define how percentage grows over time. AWS AppConfig supports the following
            /// growth types:
            /// Linear: For this type, AppConfig processes the deployment by dividing the total number of targets by
            /// the value specified for Step percentage. For example, a linear deployment that uses a Step
            /// percentage of 10 deploys the configuration to 10 percent of the hosts. After those deployments are
            /// complete, the system deploys the configuration to the next 10 percent. This continues until 100% of
            /// the targets have successfully received the configuration.
            /// Exponential: For this type, AppConfig processes the deployment exponentially using the following
            /// formula: G*(2^N). In this formula, G is the growth factor specified by the user and N is the number
            /// of steps until the configuration is deployed to all targets. For example, if you specify a growth
            /// factor of 2, then the system rolls out the configuration as follows:
            /// 2*(2^0)
            /// 2*(2^1)
            /// 2*(2^2)
            /// Expressed numerically, the deployment rolls out as follows: 2% of the targets, 4% of the targets, 8%
            /// of the targets, and continues until the configuration has been deployed to all targets.
            /// Required: No
            /// Type: String
            /// Allowed values: EXPONENTIAL | LINEAR
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GrowthType { get; set; }

            /// <summary>
            /// Description
            /// A description of the deployment strategy.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DeploymentDurationInMinutes
            /// Total amount of time for a deployment to last.
            /// Required: Yes
            /// Type: Double
            /// Minimum: 0
            /// Maximum: 1440
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> DeploymentDurationInMinutes { get; set; }

            /// <summary>
            /// GrowthFactor
            /// The percentage of targets to receive a deployed configuration during each interval.
            /// Required: Yes
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> GrowthFactor { get; set; }

            /// <summary>
            /// FinalBakeTimeInMinutes
            /// The amount of time AWS AppConfig monitors for alarms before considering the deployment to be
            /// complete and no longer eligible for automatic roll back.
            /// Required: No
            /// Type: Double
            /// Minimum: 0
            /// Maximum: 1440
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> FinalBakeTimeInMinutes { get; set; }

            /// <summary>
            /// Tags
            /// Metadata to assign to an AWS AppConfig resource. Tags help organize and categorize your AWS
            /// AppConfig resources. Each tag consists of a key and an optional value, both of which you define. You
            /// can specify a maximum of 50 tags for a resource.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tags> Tags { get; set; }

            /// <summary>
            /// Name
            /// A name for the deployment strategy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::AppConfig::DeploymentStrategy";

        public DeploymentStrategyProperties Properties { get; } = new DeploymentStrategyProperties();

    }
}
