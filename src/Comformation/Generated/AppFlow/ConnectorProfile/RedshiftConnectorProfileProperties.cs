using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile RedshiftConnectorProfileProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html
    /// </summary>
    public class RedshiftConnectorProfileProperties
    {

        /// <summary>
        /// DatabaseUrl
        /// The JDBC URL of the Amazon Redshift cluster.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseUrl")]
        public Union<string, IntrinsicFunction> DatabaseUrl { get; set; }

        /// <summary>
        /// BucketName
        /// A name for the associated Amazon S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// BucketPrefix
        /// The object key for the destination bucket in which Amazon AppFlow places the files.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: arn:aws:iam:. *:[0-9]+:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
