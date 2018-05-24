using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-bounceaction
        /// </summary>
        [JsonProperty("BounceAction")]
        public Union<BounceAction, IntrinsicFunction> BounceAction { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-s3action
        /// </summary>
        [JsonProperty("S3Action")]
        public Union<S3Action, IntrinsicFunction> S3Action { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-stopaction
        /// </summary>
        [JsonProperty("StopAction")]
        public Union<StopAction, IntrinsicFunction> StopAction { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-snsaction
        /// </summary>
        [JsonProperty("SNSAction")]
        public Union<SNSAction, IntrinsicFunction> SNSAction { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-workmailaction
        /// </summary>
        [JsonProperty("WorkmailAction")]
        public Union<WorkmailAction, IntrinsicFunction> WorkmailAction { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-addheaderaction
        /// </summary>
        [JsonProperty("AddHeaderAction")]
        public Union<AddHeaderAction, IntrinsicFunction> AddHeaderAction { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-lambdaaction
        /// </summary>
        [JsonProperty("LambdaAction")]
        public Union<LambdaAction, IntrinsicFunction> LambdaAction { get; set; }

    }
}
