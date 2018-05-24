using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html
    /// </summary>
    public class PasswordPolicy
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requirenumbers
        /// </summary>
        [JsonProperty("RequireNumbers")]
        public Union<bool?, IntrinsicFunction> RequireNumbers { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-minimumlength
        /// </summary>
        [JsonProperty("MinimumLength")]
        public Union<int?, IntrinsicFunction> MinimumLength { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requireuppercase
        /// </summary>
        [JsonProperty("RequireUppercase")]
        public Union<bool?, IntrinsicFunction> RequireUppercase { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requirelowercase
        /// </summary>
        [JsonProperty("RequireLowercase")]
        public Union<bool?, IntrinsicFunction> RequireLowercase { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-passwordpolicy.html#cfn-cognito-userpool-passwordpolicy-requiresymbols
        /// </summary>
        [JsonProperty("RequireSymbols")]
        public Union<bool?, IntrinsicFunction> RequireSymbols { get; set; }

    }
}
