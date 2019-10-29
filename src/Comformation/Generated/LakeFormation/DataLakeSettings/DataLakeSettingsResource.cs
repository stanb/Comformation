using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.DataLakeSettings
{
    /// <summary>
    /// AWS::LakeFormation::DataLakeSettings
    /// The AWS::LakeFormation::DataLakeSettings resource is an AWS Lake Formation resource type that manages data
    /// lake settings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html
    /// </summary>
    public class DataLakeSettingsResource : ResourceBase
    {
        public class DataLakeSettingsProperties
        {
            /// <summary>
            /// Admins
            /// 	
            /// A list of AWS Lake Formation principals.
            /// Required: No
            /// Type: Admins
            /// Update requires: No interruption
            /// </summary>
			public List<DataLakePrincipal> Admins { get; set; }

        }

        public string Type { get; } = "AWS::LakeFormation::DataLakeSettings";

        public DataLakeSettingsProperties Properties { get; } = new DataLakeSettingsProperties();

    }
}
