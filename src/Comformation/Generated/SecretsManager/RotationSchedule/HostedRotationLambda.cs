using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.RotationSchedule
{
    /// <summary>
    /// AWS::SecretsManager::RotationSchedule HostedRotationLambda
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html
    /// </summary>
    public class HostedRotationLambda
    {

        /// <summary>
        /// RotationType
        /// Specifies the type of RotationSchedule used by Secrets Manager. You can specify one of the following
        /// RotationTypes:
        /// MySQLSingleUser MySQLMultiUser PostgreSQLSingleUser PostgreSQLMultiUser OracleSingleUser
        /// OracleMultiUser MariaDBSingleUser MariaDBMultiUser SQLServerSingleUser SQLServerMultiUser
        /// RedshiftSingleUser RedshiftMultiUser MongoDBSingleUser MongoDBMultiUser
        /// The rotation type uses a combination of the target database and the rotation strategy. For more
        /// information on single user and multi user rotation, see Rotating Secrets in the AWS Secrets Manager
        /// User’s Guide. .
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RotationType")]
        public Union<string, IntrinsicFunction> RotationType { get; set; }

        /// <summary>
        /// RotationLambdaName
        /// Specifies the name of the Lambda created to rotate your secret.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RotationLambdaName")]
        public Union<string, IntrinsicFunction> RotationLambdaName { get; set; }

        /// <summary>
        /// KmsKeyArn
        /// Specifies the ARN of the KMS key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyArn")]
        public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

        /// <summary>
        /// MasterSecretArn
        /// Specifies the ARN of the MasterSecret that contains a privileged user’s credentials. The Lambda uses
        /// this secret to rotate the current secret. See Permissions Required to Automatically Rotate Secrets.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MasterSecretArn")]
        public Union<string, IntrinsicFunction> MasterSecretArn { get; set; }

        /// <summary>
        /// VpcSecurityGroupIds
        /// Specifies the comma-separated list of security group IDs applied on the target with a secret in
        /// rotation.
        /// The templates applies the same security groups as on the rotation Lambda created as part of this
        /// stack
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcSecurityGroupIds")]
        public Union<string, IntrinsicFunction> VpcSecurityGroupIds { get; set; }

        /// <summary>
        /// MasterSecretKmsKeyArn
        /// Specifies the ARN of the KMS key used to encrypt the master secret. You only need this property if
        /// you use a master secret to rotate the current secret, and you encrypt the master secret with a
        /// custom CMK.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MasterSecretKmsKeyArn")]
        public Union<string, IntrinsicFunction> MasterSecretKmsKeyArn { get; set; }

        /// <summary>
        /// VpcSubnetIds
        /// Specifies the comma separated list of VPC subnet IDs of the target database network. The rotation
        /// Lambda resides in the same subnet group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcSubnetIds")]
        public Union<string, IntrinsicFunction> VpcSubnetIds { get; set; }

    }
}
