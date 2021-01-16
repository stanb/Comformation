using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Signer.ProfilePermission
{
    /// <summary>
    /// AWS::Signer::ProfilePermission
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-signer-profilepermission.html
    /// </summary>
    public class ProfilePermissionResource : ResourceBase
    {
        public class ProfilePermissionProperties
        {
            /// <summary>
            /// ProfileName
            /// The human-readable name of the signing profile.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProfileName { get; set; }

            /// <summary>
            /// ProfileVersion
            /// The version of the signing profile.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProfileVersion { get; set; }

            /// <summary>
            /// Action
            /// The AWS Signer action permitted as part of cross-account permissions.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// Principal
            /// The AWS principal receiving cross-account permissions. This may be an IAM role or another AWS
            /// account ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Principal { get; set; }

            /// <summary>
            /// StatementId
            /// A unique identifier for the cross-account permission statement.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StatementId { get; set; }

        }

        public string Type { get; } = "AWS::Signer::ProfilePermission";

        public ProfilePermissionProperties Properties { get; } = new ProfilePermissionProperties();

    }
}
