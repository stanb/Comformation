using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImageRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ImageRecipe SystemsManagerAgent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-systemsmanageragent.html
    /// </summary>
    public class SystemsManagerAgent
    {

        /// <summary>
        /// UninstallAfterBuild
        /// 		
        /// Controls whether the SSM agent is removed from your final build image, prior to creating 			the new
        /// AMI. If this is set to true, then the agent is removed from the final image. If it&#39;s 			set to
        /// false, then the agent is left in, so that it is included in the new AMI. The default 			value is
        /// false.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UninstallAfterBuild")]
        public Union<bool, IntrinsicFunction> UninstallAfterBuild { get; set; }

    }
}
