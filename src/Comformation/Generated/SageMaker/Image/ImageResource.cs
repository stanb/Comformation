using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Image
{
    /// <summary>
    /// AWS::SageMaker::Image
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-image.html
    /// </summary>
    public class ImageResource : ResourceBase
    {
        public class ImageProperties
        {
            /// <summary>
            /// ImageName
            /// The name of the Image. Must be unique by region in your account.
            /// Length Constraints: Minimum length of 1. Maximum length of 63.
            /// Pattern: ^[a-zA-Z0-9]([-. ]?[a-zA-Z0-9]){0,62}$
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ImageName { get; set; }

            /// <summary>
            /// ImageRoleArn
            /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker to perform tasks on your
            /// behalf.
            /// Length Constraints: Minimum length of 20. Maximum length of 2048.
            /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImageRoleArn { get; set; }

            /// <summary>
            /// ImageDisplayName
            /// The display name of the image.
            /// Length Constraints: Minimum length of 1. Maximum length of 128.
            /// Pattern: ^\S(. *\S)?$
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImageDisplayName { get; set; }

            /// <summary>
            /// ImageDescription
            /// The description of the image.
            /// Length Constraints: Minimum length of 1. Maximum length of 512.
            /// Pattern: . *
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImageDescription { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs to apply to this resource.
            /// Array Members: Minimum number of 0 items. Maximum number of 50 items.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Image";

        public ImageProperties Properties { get; } = new ImageProperties();

    }

    public static class ImageAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ImageArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ImageArn");
    }
}
