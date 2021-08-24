using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service ImageRepository
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-imagerepository.html
    /// </summary>
    public class ImageRepository
    {

        /// <summary>
        /// ImageIdentifier
        /// The identifier of an image.
        /// For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the image
        /// name format, see Pulling an image in the Amazon ECR User Guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ([0-9]{12}. dkr. ecr. [a-z\-]+-[0-9]{1}. amazonaws. com\/. *)|(^public\. ecr\. aws\/. +\/.
        /// +)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageIdentifier")]
        public Union<string, IntrinsicFunction> ImageIdentifier { get; set; }

        /// <summary>
        /// ImageConfiguration
        /// Configuration for running the identified image.
        /// Required: No
        /// Type: ImageConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageConfiguration")]
        public ImageConfiguration ImageConfiguration { get; set; }

        /// <summary>
        /// ImageRepositoryType
        /// The type of the image repository. This reflects the repository provider and whether the repository
        /// is private or public.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ECR | ECR_PUBLIC
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageRepositoryType")]
        public Union<string, IntrinsicFunction> ImageRepositoryType { get; set; }

    }
}
