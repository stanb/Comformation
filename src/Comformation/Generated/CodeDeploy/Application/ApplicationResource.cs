using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.Application
{
    /// <summary>
    /// AWS::CodeDeploy::Application
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-application.html
    /// </summary>
    public class ApplicationResource : ResourceBase
    {
        public class ApplicationProperties
        {
            /// <summary>
            /// ApplicationName
            /// A name for the application. If you don&#39;t specify a name, AWS CloudFormation generates a unique
            /// physical ID and uses that ID for the application name. For more information, see Name Type.
            /// Note Updates to ApplicationName are not supported.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// ComputePlatform
            /// The compute platform that CodeDeploy deploys the application to.
            /// Required: No
            /// Type: String
            /// Allowed values: ECS | Lambda | Server
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ComputePlatform { get; set; }

        }

        public string Type { get; } = "AWS::CodeDeploy::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
