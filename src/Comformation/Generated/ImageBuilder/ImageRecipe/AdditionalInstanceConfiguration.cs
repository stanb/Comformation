using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImageRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ImageRecipe AdditionalInstanceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-additionalinstanceconfiguration.html
    /// </summary>
    public class AdditionalInstanceConfiguration
    {

        /// <summary>
        /// SystemsManagerAgent
        /// 		
        /// Contains settings for the SSM agent on your build instance.
        /// 	
        /// Required: No
        /// Type: SystemsManagerAgent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SystemsManagerAgent")]
        public SystemsManagerAgent SystemsManagerAgent { get; set; }

        /// <summary>
        /// UserDataOverride
        /// 		
        /// Use this property to provide commands or a command script to run when you launch 			your build
        /// instance.
        /// 		
        /// Note The userDataOverride property replaces any commands that Image Builder might have added to
        /// ensure 				that SSM is installed on your Linux build instance. If you override the user data,
        /// 				make sure that you add commands to install SSM, if it is not pre-installed on your 				source
        /// image.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 21847
        /// Pattern: ^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserDataOverride")]
        public Union<string, IntrinsicFunction> UserDataOverride { get; set; }

    }
}
