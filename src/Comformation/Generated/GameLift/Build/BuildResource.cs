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
            /// An identifier to associate with this build. Build names don&#39;t need to be unique.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// StorageLocation
            /// The Amazon Simple Storage Service (Amazon S3) location where your build package files are located.
            /// Required: No, but we recommend that you specify a location. If you don&#39;t specify this property, you
            /// must manually upload your build package files to GameLift.
            /// Type: Amazon GameLift Build StorageLocation
            /// Update requires: Replacement
            /// </summary>
			public S3Location StorageLocation { get; set; }

            /// <summary>
            /// Version
            /// A version to associate with this build. Version is useful if you want to track updates to your build
            /// package files. Versions don&#39;t need to be unique.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::Build";

        public BuildProperties Properties { get; } = new BuildProperties();

    }
}
