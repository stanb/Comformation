using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Build
{
    /// <summary>
    /// AWS::GameLift::Build
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-build.html
    /// </summary>
    public class BuildResource : ResourceBase
    {
        public class BuildProperties
        {
            /// <summary>
            /// Name
            /// A descriptive label that is associated with a build. Build names do not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// OperatingSystem
            /// The operating system that the game server binaries are built to run on. This value determines the
            /// type of fleet resources that you can use for this build. If your game build contains multiple
            /// executables, they all must run on the same operating system. If an operating system is not specified
            /// when creating a build, Amazon GameLift uses the default value (WINDOWS_2012). This value cannot be
            /// changed later.
            /// Required: No
            /// Type: String
            /// Allowed values: AMAZON_LINUX | AMAZON_LINUX_2 | WINDOWS_2012
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OperatingSystem { get; set; }

            /// <summary>
            /// StorageLocation
            /// Information indicating where your game build files are stored. Use this parameter only when creating
            /// a build with files stored in an S3 bucket that you own. The storage location must specify an S3
            /// bucket name and key. The location must also specify a role ARN that you set up to allow Amazon
            /// GameLift to access your S3 bucket. The S3 bucket and your new build must be in the same Region.
            /// Required: No
            /// Type: S3Location
            /// Update requires: Replacement
            /// </summary>
            public S3Location StorageLocation { get; set; }

            /// <summary>
            /// Version
            /// Version information that is associated with this build. Version strings do not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::Build";

        public BuildProperties Properties { get; } = new BuildProperties();

    }
}
