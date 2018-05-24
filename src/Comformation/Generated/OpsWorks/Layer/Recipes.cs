using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html
    /// </summary>
    public class Recipes
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html#cfn-opsworks-layer-customrecipes-configure
        /// </summary>
        [JsonProperty("Configure")]
        public Union<List<string>, IntrinsicFunction> Configure { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html#cfn-opsworks-layer-customrecipes-deploy
        /// </summary>
        [JsonProperty("Deploy")]
        public Union<List<string>, IntrinsicFunction> Deploy { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html#cfn-opsworks-layer-customrecipes-setup
        /// </summary>
        [JsonProperty("Setup")]
        public Union<List<string>, IntrinsicFunction> Setup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html#cfn-opsworks-layer-customrecipes-shutdown
        /// </summary>
        [JsonProperty("Shutdown")]
        public Union<List<string>, IntrinsicFunction> Shutdown { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html#cfn-opsworks-layer-customrecipes-undeploy
        /// </summary>
        [JsonProperty("Undeploy")]
        public Union<List<string>, IntrinsicFunction> Undeploy { get; set; }

    }
}
