using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.Deployment
{
    /// <summary>
    /// AWS::AppConfig::Deployment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html
    /// </summary>
    public class DeploymentResource : ResourceBase
    {
        public class DeploymentProperties
        {
            /// <summary>
            /// DeploymentStrategyId
            /// The deployment strategy ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DeploymentStrategyId { get; set; }

            /// <summary>
            /// ConfigurationProfileId
            /// The configuration profile ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigurationProfileId { get; set; }

            /// <summary>
            /// EnvironmentId
            /// The environment ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EnvironmentId { get; set; }

            /// <summary>
            /// Description
            /// A description of the deployment.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ConfigurationVersion
            /// The configuration version to deploy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigurationVersion { get; set; }

            /// <summary>
            /// ApplicationId
            /// The application ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// Tags
            /// Metadata to assign to the deployment. Tags help organize and categorize your AWS AppConfig
            /// resources. Each tag consists of a key and an optional value, both of which you define.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tags> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppConfig::Deployment";

        public DeploymentProperties Properties { get; } = new DeploymentProperties();

    }
}
