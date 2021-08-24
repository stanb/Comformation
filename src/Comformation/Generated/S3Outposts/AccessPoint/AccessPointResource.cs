using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.AccessPoint
{
    /// <summary>
    /// AWS::S3Outposts::AccessPoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-accesspoint.html
    /// </summary>
    public class AccessPointResource : ResourceBase
    {
        public class AccessPointProperties
        {
            /// <summary>
            /// Bucket
            /// The Amazon Resource Name (ARN) of the S3 on Outposts bucket that is associated with this access
            /// point.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Bucket { get; set; }

            /// <summary>
            /// Name
            /// The name of this access point.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// VpcConfiguration
            /// The virtual private cloud (VPC) configuration for this access point, if one exists.
            /// Required: Yes
            /// Type: VpcConfiguration
            /// Update requires: Replacement
            /// </summary>
            public VpcConfiguration VpcConfiguration { get; set; }

            /// <summary>
            /// Policy
            /// The access point policy associated with this access point.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Policy { get; set; }

        }

        public string Type { get; } = "AWS::S3Outposts::AccessPoint";

        public AccessPointProperties Properties { get; } = new AccessPointProperties();

    }

    public static class AccessPointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
