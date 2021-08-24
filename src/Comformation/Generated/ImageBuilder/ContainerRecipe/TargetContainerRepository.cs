using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ContainerRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ContainerRecipe TargetContainerRepository
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-targetcontainerrepository.html
    /// </summary>
    public class TargetContainerRepository
    {

        /// <summary>
        /// Service
        /// 		
        /// Specifies the service in which this image was registered.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: ECR
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Service")]
        public Union<string, IntrinsicFunction> Service { get; set; }

        /// <summary>
        /// RepositoryName
        /// 		
        /// The name of the container repository where the output container image is stored. This name is
        /// prefixed by the repository location.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RepositoryName")]
        public Union<string, IntrinsicFunction> RepositoryName { get; set; }

    }
}
