using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion LambdaFunctionRecipeSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-componentversion-lambdafunctionrecipesource.html
    /// </summary>
    public class LambdaFunctionRecipeSource
    {

        /// <summary>
        /// LambdaArn
        /// The ARN of the Lambda function. The ARN must include the version of the function to import. You
        /// can&#39;t use version aliases like $LATEST.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LambdaArn")]
        public Union<string, IntrinsicFunction> LambdaArn { get; set; }

        /// <summary>
        /// ComponentName
        /// The name of the component.
        /// Defaults to the name of the Lambda function.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentName")]
        public Union<string, IntrinsicFunction> ComponentName { get; set; }

        /// <summary>
        /// ComponentVersion
        /// The version of the component.
        /// Defaults to the version of the Lambda function as a semantic version. For example, if your function
        /// version is 3, the component version becomes 3. 0. 0.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentVersion")]
        public Union<string, IntrinsicFunction> ComponentVersion { get; set; }

        /// <summary>
        /// ComponentPlatforms
        /// The platforms that the component version supports.
        /// Required: No
        /// Type: List of ComponentPlatform
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentPlatforms")]
        public List<ComponentPlatform> ComponentPlatforms { get; set; }

        /// <summary>
        /// ComponentDependencies
        /// The component versions on which this Lambda function component depends.
        /// Required: No
        /// Type: Map of ComponentDependencyRequirement
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentDependencies")]
        public Dictionary<string, ComponentDependencyRequirement> ComponentDependencies { get; set; }

        /// <summary>
        /// ComponentLambdaParameters
        /// The system and runtime parameters for the Lambda function as it runs on the Greengrass core device.
        /// Required: No
        /// Type: LambdaExecutionParameters
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentLambdaParameters")]
        public LambdaExecutionParameters ComponentLambdaParameters { get; set; }

    }
}
