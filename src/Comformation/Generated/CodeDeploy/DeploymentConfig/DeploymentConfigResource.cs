using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html
    /// </summary>
    public class DeploymentConfigResource : ResourceBase
    {
        public class DeploymentConfigProperties
        {
            /// <summary>
            /// DeploymentConfigName
            /// A name for the deployment configuration. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique physical ID and uses that ID for the deployment configuration name. For more information, see
            /// Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DeploymentConfigName { get; set; }

            /// <summary>
            /// MinimumHealthyHosts
            /// The minimum number of healthy instances that should be available at any time during the deployment.
            /// There are two parameters expected in the input: type and value.
            /// The type parameter takes either of the following values:
            /// HOST_COUNT: The value parameter represents the minimum number of healthy instances as an absolute
            /// value. FLEET_PERCENT: The value parameter represents the minimum number of healthy instances as a
            /// percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the
            /// start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance
            /// and rounds up fractional instances.
            /// The value parameter takes an integer.
            /// For example, to set a minimum of 95% healthy instance, specify a type of FLEET_PERCENT and a value
            /// of 95.
            /// For more information about instance health, see CodeDeploy Instance Health in the AWS CodeDeploy
            /// User Guide.
            /// Required: No
            /// Type: MinimumHealthyHosts
            /// Update requires: Replacement
            /// </summary>
            public MinimumHealthyHosts MinimumHealthyHosts { get; set; }

        }

        public string Type { get; } = "AWS::CodeDeploy::DeploymentConfig";

        public DeploymentConfigProperties Properties { get; } = new DeploymentConfigProperties();

    }
}
