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
            /// The name of this access point.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
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
            /// bucket or object public, see The Meaning of &quot;Public&quot; in the Amazon Simple Storage Service Developer
            /// Guide.
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

            /// <summary>
            /// NetworkOrigin
            /// Indicates whether this access point allows access from the internet. If VpcConfiguration is
            /// specified for this access point, then NetworkOrigin is VPC, and the access point doesn&#39;t allow
            /// access from the internet. Otherwise, NetworkOrigin is Internet, and the access point allows access
            /// from the internet, subject to the access point and bucket access policies.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkOrigin { get; set; }

        }

        public string Type { get; } = "AWS::S3::AccessPoint";

        public AccessPointProperties Properties { get; } = new AccessPointProperties();

    }
}
