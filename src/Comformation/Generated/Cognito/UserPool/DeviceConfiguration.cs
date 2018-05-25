using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html
    /// </summary>
    public class DeviceConfiguration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html#cfn-cognito-userpool-deviceconfiguration-deviceonlyrememberedonuserprompt
        /// </summary>
        [JsonProperty("DeviceOnlyRememberedOnUserPrompt")]
        public Union<bool, IntrinsicFunction> DeviceOnlyRememberedOnUserPrompt { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-deviceconfiguration.html#cfn-cognito-userpool-deviceconfiguration-challengerequiredonnewdevice
        /// </summary>
        [JsonProperty("ChallengeRequiredOnNewDevice")]
        public Union<bool, IntrinsicFunction> ChallengeRequiredOnNewDevice { get; set; }

    }
}
