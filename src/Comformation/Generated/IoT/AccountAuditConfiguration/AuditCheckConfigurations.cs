using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.AccountAuditConfiguration
{
    /// <summary>
    /// AWS::IoT::AccountAuditConfiguration AuditCheckConfigurations
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-accountauditconfiguration-auditcheckconfigurations.html
    /// </summary>
    public class AuditCheckConfigurations
    {

        /// <summary>
        /// AuthenticatedCognitoRoleOverlyPermissiveCheck
        /// Checks the permissiveness of an authenticated Amazon Cognito identity pool role. For this check, AWS
        /// IoT Device Defender audits all Amazon Cognito identity pools that have been used to connect to the
        /// AWS IoT message broker during the 31 days before the audit is performed.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticatedCognitoRoleOverlyPermissiveCheck")]
        public AuditCheckConfiguration AuthenticatedCognitoRoleOverlyPermissiveCheck { get; set; }

        /// <summary>
        /// CaCertificateExpiringCheck
        /// Checks if a CA certificate is expiring. This check applies to CA certificates expiring within 30
        /// days or that have expired.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaCertificateExpiringCheck")]
        public AuditCheckConfiguration CaCertificateExpiringCheck { get; set; }

        /// <summary>
        /// CaCertificateKeyQualityCheck
        /// Checks the quality of the CA certificate key. The quality checks if the key is in a valid format,
        /// not expired, and if the key meets a minimum required size. This check applies to CA certificates
        /// that are ACTIVE or PENDING_TRANSFER.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaCertificateKeyQualityCheck")]
        public AuditCheckConfiguration CaCertificateKeyQualityCheck { get; set; }

        /// <summary>
        /// ConflictingClientIdsCheck
        /// Checks if multiple devices connect using the same client ID.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConflictingClientIdsCheck")]
        public AuditCheckConfiguration ConflictingClientIdsCheck { get; set; }

        /// <summary>
        /// DeviceCertificateExpiringCheck
        /// Checks if a device certificate is expiring. This check applies to device certificates expiring
        /// within 30 days or that have expired.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceCertificateExpiringCheck")]
        public AuditCheckConfiguration DeviceCertificateExpiringCheck { get; set; }

        /// <summary>
        /// DeviceCertificateKeyQualityCheck
        /// Checks the quality of the device certificate key. The quality checks if the key is in a valid
        /// format, not expired, signed by a registered certificate authority, and if the key meets a minimum
        /// required size.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceCertificateKeyQualityCheck")]
        public AuditCheckConfiguration DeviceCertificateKeyQualityCheck { get; set; }

        /// <summary>
        /// DeviceCertificateSharedCheck
        /// Checks if multiple concurrent connections use the same X. 509 certificate to authenticate with AWS
        /// IoT.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceCertificateSharedCheck")]
        public AuditCheckConfiguration DeviceCertificateSharedCheck { get; set; }

        /// <summary>
        /// IotPolicyOverlyPermissiveCheck
        /// Checks the permissiveness of a policy attached to an authenticated Amazon Cognito identity pool
        /// role.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotPolicyOverlyPermissiveCheck")]
        public AuditCheckConfiguration IotPolicyOverlyPermissiveCheck { get; set; }

        /// <summary>
        /// IotRoleAliasAllowsAccessToUnusedServicesCheck
        /// Checks if a role alias has access to services that haven&#39;t been used for the AWS IoT device in the
        /// last year.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotRoleAliasAllowsAccessToUnusedServicesCheck")]
        public AuditCheckConfiguration IotRoleAliasAllowsAccessToUnusedServicesCheck { get; set; }

        /// <summary>
        /// IotRoleAliasOverlyPermissiveCheck
        /// Checks if the temporary credentials provided by AWS IoT role aliases are overly permissive.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotRoleAliasOverlyPermissiveCheck")]
        public AuditCheckConfiguration IotRoleAliasOverlyPermissiveCheck { get; set; }

        /// <summary>
        /// LoggingDisabledCheck
        /// Checks if AWS IoT logs are disabled.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoggingDisabledCheck")]
        public AuditCheckConfiguration LoggingDisabledCheck { get; set; }

        /// <summary>
        /// RevokedCaCertificateStillActiveCheck
        /// Checks if a revoked CA certificate is still active.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RevokedCaCertificateStillActiveCheck")]
        public AuditCheckConfiguration RevokedCaCertificateStillActiveCheck { get; set; }

        /// <summary>
        /// RevokedDeviceCertificateStillActiveCheck
        /// Checks if a revoked device certificate is still active.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RevokedDeviceCertificateStillActiveCheck")]
        public AuditCheckConfiguration RevokedDeviceCertificateStillActiveCheck { get; set; }

        /// <summary>
        /// UnauthenticatedCognitoRoleOverlyPermissiveCheck
        /// Checks if policy attached to an unauthenticated Amazon Cognito identity pool role is too permissive.
        /// Required: No
        /// Type: AuditCheckConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnauthenticatedCognitoRoleOverlyPermissiveCheck")]
        public AuditCheckConfiguration UnauthenticatedCognitoRoleOverlyPermissiveCheck { get; set; }

    }
}
