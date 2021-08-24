using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3ObjectLambda.AccessPointPolicy
{
    /// <summary>
    /// AWS::S3ObjectLambda::AccessPointPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3objectlambda-accesspointpolicy.html
    /// </summary>
    public class AccessPointPolicyResource : ResourceBase
    {
        public class AccessPointPolicyProperties
        {
            /// <summary>
            /// ObjectLambdaAccessPoint
            /// An access point with an attached AWS Lambda function used to access transformed data from an Amazon
            /// S3 bucket.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ObjectLambdaAccessPoint { get; set; }

            /// <summary>
            /// PolicyDocument
            /// Object Lambda Access Point resource policy document.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        }

        public string Type { get; } = "AWS::S3ObjectLambda::AccessPointPolicy";

        public AccessPointPolicyProperties Properties { get; } = new AccessPointPolicyProperties();

    }
}
