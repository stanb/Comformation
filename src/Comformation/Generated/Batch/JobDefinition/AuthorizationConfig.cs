using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition AuthorizationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-authorizationconfig.html
    /// </summary>
    public class AuthorizationConfig
    {

        /// <summary>
        /// Iam
        /// Whether or not to use the AWS Batch job IAM role defined in a job definition when mounting the
        /// Amazon EFS file system. If enabled, transit encryption must be enabled in the
        /// EFSVolumeConfiguration. If this parameter is omitted, the default value of DISABLED is used. For
        /// more information, see Using Amazon EFS Access Points in the AWS Batch User Guide. EFS IAM
        /// authorization requires that TransitEncryption be ENABLED and that a JobRoleArn is specified.
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Iam")]
        public Union<string, IntrinsicFunction> Iam { get; set; }

        /// <summary>
        /// AccessPointId
        /// The Amazon EFS access point ID to use. If an access point is specified, the root directory value
        /// specified in the EFSVolumeConfiguration must either be omitted or set to / which will enforce the
        /// path set on the EFS access point. If an access point is used, transit encryption must be enabled in
        /// the EFSVolumeConfiguration. For more information, see Working with Amazon EFS Access Points in the
        /// Amazon Elastic File System User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessPointId")]
        public Union<string, IntrinsicFunction> AccessPointId { get; set; }

    }
}
