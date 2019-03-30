using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.Application
{
    /// <summary>
    /// AWS::CodeDeploy::Application
    /// The AWS::CodeDeploy::Application resource creates an CodeDeploy application. In CodeDeploy, an application is
    /// a name that functions as a container to ensure that the correct combination of revision, deployment
    /// configuration, and deployment group are referenced during a deployment. You can use the
    /// AWS::CodeDeploy::DeploymentGroup resource to associate the application with an CodeDeploy deployment group.
    /// For more information, see CodeDeploy Deployments in the AWS CodeDeploy User Guide.
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
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// ComputePlatform
            /// The compute platform that CodeDeploy deploys the application to. For valid values see
            /// CreateApplication in the CodeDeploy API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ComputePlatform { get; set; }

        }

        public string Type { get; } = "AWS::CodeDeploy::Application";

        public ApplicationProperties Properties { get; } = new ApplicationProperties();

    }
}
