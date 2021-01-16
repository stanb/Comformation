using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform FindMatchesParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformparameters-findmatchesparameters.html
    /// </summary>
    public class FindMatchesParameters
    {

        /// <summary>
        /// PrecisionRecallTradeoff
        /// The value selected when tuning your transform for a balance between precision and recall. A value of
        /// 0. 5 means no preference; a value of 1. 0 means a bias purely for precision, and a value of 0. 0
        /// means a bias for recall. Because this is a tradeoff, choosing values close to 1. 0 means very low
        /// recall, and choosing values close to 0. 0 results in very low precision.
        /// 	 	
        /// The precision metric indicates how often your model is correct when it predicts a match.
        /// 	 	
        /// The recall metric indicates that for an actual match, how often your model predicts the match.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrecisionRecallTradeoff")]
        public Union<double, IntrinsicFunction> PrecisionRecallTradeoff { get; set; }

        /// <summary>
        /// EnforceProvidedLabels
        /// The value to switch on or off to force the output to match the provided labels from users. If the
        /// value is True, the find matches transform forces the output to match the provided labels. The
        /// results override the normal conflation results. If the value is False, the find matches transform
        /// does not ensure all the labels provided are respected, and the results rely on the trained model.
        /// Note that setting this value to true may increase the conflation execution time.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnforceProvidedLabels")]
        public Union<bool, IntrinsicFunction> EnforceProvidedLabels { get; set; }

        /// <summary>
        /// PrimaryKeyColumnName
        /// The name of a column that uniquely identifies rows in the source table. Used to help identify
        /// matching records.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PrimaryKeyColumnName")]
        public Union<string, IntrinsicFunction> PrimaryKeyColumnName { get; set; }

        /// <summary>
        /// AccuracyCostTradeoff
        /// The value that is selected when tuning your transform for a balance between accuracy and cost. A
        /// value of 0. 5 means that the system balances accuracy and cost concerns. A value of 1. 0 means a
        /// bias purely for accuracy, which typically results in a higher cost, sometimes substantially higher.
        /// A value of 0. 0 means a bias purely for cost, which results in a less accurate FindMatches
        /// transform, sometimes with unacceptable accuracy.
        /// 	 	
        /// Accuracy measures how well the transform finds true positives and true negatives. Increasing
        /// accuracy requires more machine resources and cost. But it also results in increased recall.
        /// 	 	
        /// Cost measures how many compute resources, and thus money, are consumed to run the transform.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccuracyCostTradeoff")]
        public Union<double, IntrinsicFunction> AccuracyCostTradeoff { get; set; }

    }
}
