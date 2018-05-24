using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html
    /// </summary>
    public class DeploymentConfigResource : ResourceBase
    {
        public class DeploymentConfigProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-deploymentconfigname
            /// </summary>
			public Union<string, IntrinsicFunction> DeploymentConfigName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-deploymentconfig.html#cfn-codedeploy-deploymentconfig-minimumhealthyhosts
            /// </summary>
			public Union<MinimumHealthyHosts, IntrinsicFunction> MinimumHealthyHosts { get; set; }

        }
    
        public string Type { get; } = "AWS::CodeDeploy::DeploymentConfig";
        
        public DeploymentConfigProperties Properties { get; } = new DeploymentConfigProperties();
    }
}
