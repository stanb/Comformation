using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html
    /// </summary>
    public class AdminCreateUserConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-invitemessagetemplate
        /// </summary>
        [JsonProperty("InviteMessageTemplate")]
        public Union<InviteMessageTemplate, IntrinsicFunction> InviteMessageTemplate { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-unusedaccountvaliditydays
        /// </summary>
        [JsonProperty("UnusedAccountValidityDays")]
        public Union<double, IntrinsicFunction> UnusedAccountValidityDays { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-admincreateuserconfig.html#cfn-cognito-userpool-admincreateuserconfig-allowadmincreateuseronly
        /// </summary>
        [JsonProperty("AllowAdminCreateUserOnly")]
        public Union<bool, IntrinsicFunction> AllowAdminCreateUserOnly { get; set; }

    }
}
