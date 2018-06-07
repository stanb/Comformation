using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentConfig
    /// The AWS::CodeDeploy::DeploymentConfig resource creates a set of deployment rules, deployment success
    /// conditions, and deployment failure conditions that AWS CodeDeploy uses during a deployment. The deployment
    /// configuration specifies, through the use of a MinimumHealthyHosts value, the number or percentage of instances
    /// that must remain available at any time during a deployment.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html
    /// </summary>
    public class DeploymentConfigResource : ResourceBase
    {
        public class DeploymentConfigProperties
        {
            /// <summary>
            /// DeploymentConfigName
            /// A name for the deployment configuration. If you don't specify a name, AWS CloudFormation generates a
            /// unique physical ID and uses that ID for the deployment configuration name. For more information, see
            /// Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-deploymentconfigname
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentConfigName { get; set; }

            /// <summary>
            /// MinimumHealthyHosts
            /// The minimum number of healthy instances that must be available at any time during an AWS CodeDeploy
            /// deployment. For example, for a fleet of nine instances, if you specify a minimum of six healthy
            /// instances, AWS CodeDeploy deploys your application up to three instances at a time so that you
            /// always have six healthy instances. The deployment succeeds if your application successfully deploys
            /// to six or more instances; otherwise, the deployment fails.
            /// For more information about instance health, see AWS CodeDeploy Instance Health in the AWS CodeDeploy
            /// User Guide.
            /// Required: Yes
            /// Type: AWS CodeDeploy DeploymentConfig MinimumHealthyHosts
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts
            /// </summary>
			public Union<MinimumHealthyHosts, IntrinsicFunction> MinimumHealthyHosts { get; set; }

        }
    
        public string Type { get; } = "AWS::CodeDeploy::DeploymentConfig";
        
        public DeploymentConfigProperties Properties { get; } = new DeploymentConfigProperties();
    }
}
