using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3ObjectLambda.AccessPoint
{
    /// <summary>
    /// AWS::S3ObjectLambda::AccessPoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3objectlambda-accesspoint.html
    /// </summary>
    public class AccessPointResource : ResourceBase
    {
        public class AccessPointProperties
        {
            /// <summary>
            /// Name
            /// The name of this access point.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ObjectLambdaConfiguration
            /// A configuration used when creating an Object Lambda Access Point.
            /// Required: No
            /// Type: ObjectLambdaConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ObjectLambdaConfiguration ObjectLambdaConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::S3ObjectLambda::AccessPoint";

        public AccessPointProperties Properties { get; } = new AccessPointProperties();

    }

    public static class AccessPointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationDate = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationDate");
    }
}
