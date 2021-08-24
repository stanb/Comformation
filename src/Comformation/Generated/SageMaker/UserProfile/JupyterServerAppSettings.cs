using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.UserProfile
{
    /// <summary>
    /// AWS::SageMaker::UserProfile JupyterServerAppSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterserverappsettings.html
    /// </summary>
    public class JupyterServerAppSettings
    {

        /// <summary>
        /// DefaultResourceSpec
        /// The default instance type and the Amazon Resource Name (ARN) of the default SageMaker image used by
        /// the JupyterServer app.
        /// Required: No
        /// Type: ResourceSpec
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultResourceSpec")]
        public ResourceSpec DefaultResourceSpec { get; set; }

    }
}
