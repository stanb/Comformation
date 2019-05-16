using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Build
{
    /// <summary>
    /// AWS::GameLift::Build
    /// The AWS::GameLift::Build resource creates a build that includes all of the components to run your game server
    /// in an Amazon GameLift (GameLift) fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-build.html
    /// </summary>
    public class BuildResource : ResourceBase
    {
        public class BuildProperties
        {
            /// <summary>
            /// Name
            /// Descriptive label that is associated with a build. Build names do not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// StorageLocation
            /// Information indicating where your game build files are stored. Use this parameter only when creating
            /// a build with files stored in an Amazon S3 bucket that you own. The storage location must specify an
            /// Amazon S3 bucket name and key, as well as a the ARN for a role that you set up to allow Amazon
            /// GameLift to access your Amazon S3 bucket. The S3 bucket must be in the same region that you want to
            /// create a new build in.
            /// Required: No
            /// Type: S3Location
            /// Update requires: Replacement
            /// </summary>
			public S3Location StorageLocation { get; set; }

            /// <summary>
            /// Version
            /// Version that is associated with this build. Version strings do not need to be unique.
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
