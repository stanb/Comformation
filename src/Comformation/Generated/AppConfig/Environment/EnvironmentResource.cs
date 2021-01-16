using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.Environment
{
    /// <summary>
    /// AWS::AppConfig::Environment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-environment.html
    /// </summary>
    public class EnvironmentResource : ResourceBase
    {
        public class EnvironmentProperties
        {
            /// <summary>
            /// Description
            /// A description of the environment.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Monitors
            /// Amazon CloudWatch alarms to monitor during the deployment process.
            /// Required: No
            /// Type: List of Monitors
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Monitors> Monitors { get; set; }

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
            /// Metadata to assign to the environment. Tags help organize and categorize your AWS AppConfig
            /// resources. Each tag consists of a key and an optional value, both of which you define.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tags> Tags { get; set; }

            /// <summary>
            /// Name
            /// A name for the environment.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::AppConfig::Environment";

        public EnvironmentProperties Properties { get; } = new EnvironmentProperties();

    }
}
