using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.AccessPoint
{
    /// <summary>
    /// AWS::S3::AccessPoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accesspoint.html
    /// </summary>
    public class AccessPointResource : ResourceBase
    {
        public class AccessPointProperties
        {
            /// <summary>
            /// Name
            /// The name of this access point. If you don&#39;t specify a name, AWS CloudFormation generates a unique ID
            /// and uses that ID for the access point name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Bucket
            /// The name of the bucket associated with this access point.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Bucket { get; set; }

            /// <summary>
            /// VpcConfiguration
            /// The Virtual Private Cloud (VPC) configuration for this access point, if one exists.
            /// Required: No
            /// Type: VpcConfiguration
            /// Update requires: Replacement
            /// </summary>
            public VpcConfiguration VpcConfiguration { get; set; }

            /// <summary>
            /// PublicAccessBlockConfiguration
            /// The PublicAccessBlock configuration that you want to apply to this Amazon S3 bucket. You can enable
            /// the configuration options in any combination. For more information about when Amazon S3 considers a
            /// bucket or object public, see The Meaning of &quot;Public&quot; in the Amazon S3 User Guide.
            /// Required: No
            /// Type: PublicAccessBlockConfiguration
            /// Update requires: Replacement
            /// </summary>
            public PublicAccessBlockConfiguration PublicAccessBlockConfiguration { get; set; }

            /// <summary>
            /// Policy
            /// The access point policy associated with this access point.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Policy { get; set; }

            /// <summary>
            /// PolicyStatus
            /// The container element for a bucket&#39;s policy status.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyStatus { get; set; }

        }

        public string Type { get; } = "AWS::S3::AccessPoint";

        public AccessPointProperties Properties { get; } = new AccessPointProperties();

    }

    public static class AccessPointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Alias = new ResourceAttribute<Union<string, IntrinsicFunction>>("Alias");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NetworkOrigin = new ResourceAttribute<Union<string, IntrinsicFunction>>("NetworkOrigin");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
