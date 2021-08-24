using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe RecipeParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-recipeparameters.html
    /// </summary>
    public class RecipeParameters
    {

        /// <summary>
        /// AggregateFunction
        /// The name of an aggregation function to apply.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AggregateFunction")]
        public Union<string, IntrinsicFunction> AggregateFunction { get; set; }

        /// <summary>
        /// Base
        /// The number of digits used in a counting system.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Base")]
        public Union<string, IntrinsicFunction> Base { get; set; }

        /// <summary>
        /// CaseStatement
        /// A case statement associated with a recipe.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaseStatement")]
        public Union<string, IntrinsicFunction> CaseStatement { get; set; }

        /// <summary>
        /// CategoryMap
        /// A category map used for one-hot encoding.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CategoryMap")]
        public Union<string, IntrinsicFunction> CategoryMap { get; set; }

        /// <summary>
        /// CharsToRemove
        /// Characters to remove from a step that applies one-hot encoding or tokenization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CharsToRemove")]
        public Union<string, IntrinsicFunction> CharsToRemove { get; set; }

        /// <summary>
        /// CollapseConsecutiveWhitespace
        /// Remove any non-word non-punctuation character.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CollapseConsecutiveWhitespace")]
        public Union<string, IntrinsicFunction> CollapseConsecutiveWhitespace { get; set; }

        /// <summary>
        /// ColumnDataType
        /// The data type of the column.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnDataType")]
        public Union<string, IntrinsicFunction> ColumnDataType { get; set; }

        /// <summary>
        /// ColumnRange
        /// A range of columns to which a step is applied.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnRange")]
        public Union<string, IntrinsicFunction> ColumnRange { get; set; }

        /// <summary>
        /// Count
        /// The number of times a string needs to be repeated.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<string, IntrinsicFunction> Count { get; set; }

        /// <summary>
        /// CustomCharacters
        /// One or more characters that can be substituted or removed, depending on the context.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomCharacters")]
        public Union<string, IntrinsicFunction> CustomCharacters { get; set; }

        /// <summary>
        /// CustomStopWords
        /// A list of words to ignore in a step that applies word tokenization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomStopWords")]
        public Union<string, IntrinsicFunction> CustomStopWords { get; set; }

        /// <summary>
        /// CustomValue
        /// A list of custom values to use in a step that requires that you provide a value to finish the
        /// operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomValue")]
        public Union<string, IntrinsicFunction> CustomValue { get; set; }

        /// <summary>
        /// DatasetsColumns
        /// A list of the dataset columns included in a project.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetsColumns")]
        public Union<string, IntrinsicFunction> DatasetsColumns { get; set; }

        /// <summary>
        /// DateAddValue
        /// A value that specifies how many units of time to add or subtract for a date math operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DateAddValue")]
        public Union<string, IntrinsicFunction> DateAddValue { get; set; }

        /// <summary>
        /// DateTimeFormat
        /// A date format to apply to a date.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DateTimeFormat")]
        public Union<string, IntrinsicFunction> DateTimeFormat { get; set; }

        /// <summary>
        /// DateTimeParameters
        /// A set of parameters associated with a datetime.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DateTimeParameters")]
        public Union<string, IntrinsicFunction> DateTimeParameters { get; set; }

        /// <summary>
        /// DeleteOtherRows
        /// Determines whether unmapped rows in a categorical mapping should be deleted
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteOtherRows")]
        public Union<string, IntrinsicFunction> DeleteOtherRows { get; set; }

        /// <summary>
        /// Delimiter
        /// The delimiter to use when parsing separated values in a text file.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

        /// <summary>
        /// EndPattern
        /// The end pattern to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndPattern")]
        public Union<string, IntrinsicFunction> EndPattern { get; set; }

        /// <summary>
        /// EndPosition
        /// The end position to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndPosition")]
        public Union<string, IntrinsicFunction> EndPosition { get; set; }

        /// <summary>
        /// EndValue
        /// The end value to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndValue")]
        public Union<string, IntrinsicFunction> EndValue { get; set; }

        /// <summary>
        /// ExpandContractions
        /// A list of word contractions and what they expand to. For eample: can&#39;t; cannot; can not.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExpandContractions")]
        public Union<string, IntrinsicFunction> ExpandContractions { get; set; }

        /// <summary>
        /// Exponent
        /// The exponent to apply in an exponential operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exponent")]
        public Union<string, IntrinsicFunction> Exponent { get; set; }

        /// <summary>
        /// FalseString
        /// A value that represents FALSE.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FalseString")]
        public Union<string, IntrinsicFunction> FalseString { get; set; }

        /// <summary>
        /// GroupByAggFunctionOptions
        /// Specifies options to apply to the GROUP BY used in an aggregation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupByAggFunctionOptions")]
        public Union<string, IntrinsicFunction> GroupByAggFunctionOptions { get; set; }

        /// <summary>
        /// GroupByColumns
        /// The columns to use in the GROUP BY clause.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupByColumns")]
        public Union<string, IntrinsicFunction> GroupByColumns { get; set; }

        /// <summary>
        /// HiddenColumns
        /// A list of columns to hide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HiddenColumns")]
        public Union<string, IntrinsicFunction> HiddenColumns { get; set; }

        /// <summary>
        /// IgnoreCase
        /// Indicates that lower and upper case letters are treated equally.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public Union<string, IntrinsicFunction> IgnoreCase { get; set; }

        /// <summary>
        /// IncludeInSplit
        /// Indicates if this column is participating in a split transform.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeInSplit")]
        public Union<string, IntrinsicFunction> IncludeInSplit { get; set; }

        /// <summary>
        /// Interval
        /// The number of characters to split by.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<string, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        /// IsText
        /// Indicates if the content is text.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsText")]
        public Union<string, IntrinsicFunction> IsText { get; set; }

        /// <summary>
        /// JoinKeys
        /// The keys or columns involved in a join.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JoinKeys")]
        public Union<string, IntrinsicFunction> JoinKeys { get; set; }

        /// <summary>
        /// JoinType
        /// The type of join to use, for example, INNER JOIN, OUTER JOIN, and so on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JoinType")]
        public Union<string, IntrinsicFunction> JoinType { get; set; }

        /// <summary>
        /// LeftColumns
        /// The columns on the left side of the join.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LeftColumns")]
        public Union<string, IntrinsicFunction> LeftColumns { get; set; }

        /// <summary>
        /// Limit
        /// The number of times to perform split or replaceBy in a string
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Limit")]
        public Union<string, IntrinsicFunction> Limit { get; set; }

        /// <summary>
        /// LowerBound
        /// The lower boundary for a value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LowerBound")]
        public Union<string, IntrinsicFunction> LowerBound { get; set; }

        /// <summary>
        /// MapType
        /// The type of mappings to apply to construct a new dynamic frame.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MapType")]
        public Union<string, IntrinsicFunction> MapType { get; set; }

        /// <summary>
        /// ModeType
        /// Determines the manner in which mode value is calculated, in case there is more than one mode value.
        /// Valid values: NONE | AVERAGE | MINIMUM | MAXIMUM
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ModeType")]
        public Union<string, IntrinsicFunction> ModeType { get; set; }

        /// <summary>
        /// MultiLine
        /// Specifies whether JSON input contains embedded new line characters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MultiLine")]
        public Union<bool, IntrinsicFunction> MultiLine { get; set; }

        /// <summary>
        /// NumRows
        /// The number of rows to consider in a window.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRows")]
        public Union<string, IntrinsicFunction> NumRows { get; set; }

        /// <summary>
        /// NumRowsAfter
        /// The number of rows to consider after the current row in a window
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRowsAfter")]
        public Union<string, IntrinsicFunction> NumRowsAfter { get; set; }

        /// <summary>
        /// NumRowsBefore
        /// The number of rows to consider before the current row in a window
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRowsBefore")]
        public Union<string, IntrinsicFunction> NumRowsBefore { get; set; }

        /// <summary>
        /// OrderByColumn
        /// A column to sort the results by.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrderByColumn")]
        public Union<string, IntrinsicFunction> OrderByColumn { get; set; }

        /// <summary>
        /// OrderByColumns
        /// The columns to sort the results by.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrderByColumns")]
        public Union<string, IntrinsicFunction> OrderByColumns { get; set; }

        /// <summary>
        /// Other
        /// The value to assign to unmapped cells, in categorical mapping
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Other")]
        public Union<string, IntrinsicFunction> Other { get; set; }

        /// <summary>
        /// Pattern
        /// The pattern to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pattern")]
        public Union<string, IntrinsicFunction> Pattern { get; set; }

        /// <summary>
        /// PatternOption1
        /// The starting pattern to split between.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternOption1")]
        public Union<string, IntrinsicFunction> PatternOption1 { get; set; }

        /// <summary>
        /// PatternOption2
        /// The ending pattern to split between.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternOption2")]
        public Union<string, IntrinsicFunction> PatternOption2 { get; set; }

        /// <summary>
        /// PatternOptions
        /// For splitting by multiple delimiters: A JSON-encoded string that lists the patterns in the format.
        /// For example: [{\&quot;pattern\&quot;:\&quot;1\&quot;,\&quot;includeInSplit\&quot;:true}]
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternOptions")]
        public Union<string, IntrinsicFunction> PatternOptions { get; set; }

        /// <summary>
        /// Period
        /// The size of the rolling window.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Period")]
        public Union<string, IntrinsicFunction> Period { get; set; }

        /// <summary>
        /// Position
        /// The character index within a string
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Position")]
        public Union<string, IntrinsicFunction> Position { get; set; }

        /// <summary>
        /// RemoveAllPunctuation
        /// If true, removes all of the following characters: . . ! . , . ?
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveAllPunctuation")]
        public Union<string, IntrinsicFunction> RemoveAllPunctuation { get; set; }

        /// <summary>
        /// RemoveAllQuotes
        /// If true, removes all single quotes and double quotes.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveAllQuotes")]
        public Union<string, IntrinsicFunction> RemoveAllQuotes { get; set; }

        /// <summary>
        /// RemoveAllWhitespace
        /// If true, removes all whitespaces from the value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveAllWhitespace")]
        public Union<string, IntrinsicFunction> RemoveAllWhitespace { get; set; }

        /// <summary>
        /// RemoveCustomCharacters
        /// If true, removes all chraracters specified by CustomCharacters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveCustomCharacters")]
        public Union<string, IntrinsicFunction> RemoveCustomCharacters { get; set; }

        /// <summary>
        /// RemoveCustomValue
        /// If true, removes all chraracters specified by CustomValue.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveCustomValue")]
        public Union<string, IntrinsicFunction> RemoveCustomValue { get; set; }

        /// <summary>
        /// RemoveLeadingAndTrailingPunctuation
        /// If true, removes the following characters if they occur at the start or end of the value: . ! , ?
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveLeadingAndTrailingPunctuation")]
        public Union<string, IntrinsicFunction> RemoveLeadingAndTrailingPunctuation { get; set; }

        /// <summary>
        /// RemoveLeadingAndTrailingQuotes
        /// If true, removes single quotes and double quotes from the beginning and end of the value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveLeadingAndTrailingQuotes")]
        public Union<string, IntrinsicFunction> RemoveLeadingAndTrailingQuotes { get; set; }

        /// <summary>
        /// RemoveLeadingAndTrailingWhitespace
        /// If true, removes all whitespaces from the beginning and end of the value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveLeadingAndTrailingWhitespace")]
        public Union<string, IntrinsicFunction> RemoveLeadingAndTrailingWhitespace { get; set; }

        /// <summary>
        /// RemoveLetters
        /// If true, removes all uppercase and lowercase alphabetic characters (A through Z; a through z).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveLetters")]
        public Union<string, IntrinsicFunction> RemoveLetters { get; set; }

        /// <summary>
        /// RemoveNumbers
        /// If true, removes all numeric characters (0 through 9).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveNumbers")]
        public Union<string, IntrinsicFunction> RemoveNumbers { get; set; }

        /// <summary>
        /// RemoveSourceColumn
        /// If true, the source column will be removed after un-nesting that column. (Used with nested column
        /// types, such as Map, Struct, or Array. )
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveSourceColumn")]
        public Union<string, IntrinsicFunction> RemoveSourceColumn { get; set; }

        /// <summary>
        /// RemoveSpecialCharacters
        /// If true, removes all of the following characters: ! &quot; # $ % &amp;amp; &#39; ( ) * + , - . / : ; &amp;lt; = &amp;gt;
        /// ? @ [ \ ] ^ _ ` { | } ~
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveSpecialCharacters")]
        public Union<string, IntrinsicFunction> RemoveSpecialCharacters { get; set; }

        /// <summary>
        /// RightColumns
        /// The columns on the right side of a join.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RightColumns")]
        public Union<string, IntrinsicFunction> RightColumns { get; set; }

        /// <summary>
        /// SampleSize
        /// The number of rows in the sample.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SampleSize")]
        public Union<string, IntrinsicFunction> SampleSize { get; set; }

        /// <summary>
        /// SampleType
        /// The sampling type to apply to the dataset. Valid values: FIRST_N | LAST_N | RANDOM
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SampleType")]
        public Union<string, IntrinsicFunction> SampleType { get; set; }

        /// <summary>
        /// SecondInput
        /// A object value to indicate the second dataset used in a join.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondInput")]
        public Union<string, IntrinsicFunction> SecondInput { get; set; }

        /// <summary>
        /// SecondaryInputs
        /// A list of secondary inputs in a UNION transform
        /// Required: No
        /// Type: List of SecondaryInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryInputs")]
        public List<SecondaryInput> SecondaryInputs { get; set; }

        /// <summary>
        /// SourceColumn
        /// A source column needed for an operation, step, or transform.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceColumn")]
        public Union<string, IntrinsicFunction> SourceColumn { get; set; }

        /// <summary>
        /// SourceColumn1
        /// A source column needed for an operation, step, or transform.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceColumn1")]
        public Union<string, IntrinsicFunction> SourceColumn1 { get; set; }

        /// <summary>
        /// SourceColumn2
        /// A source column needed for an operation, step, or transform.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceColumn2")]
        public Union<string, IntrinsicFunction> SourceColumn2 { get; set; }

        /// <summary>
        /// SourceColumns
        /// A list of source columns needed for an operation, step, or transform.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceColumns")]
        public Union<string, IntrinsicFunction> SourceColumns { get; set; }

        /// <summary>
        /// StartColumnIndex
        /// The index number of the first column used by an operation, step, or transform.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartColumnIndex")]
        public Union<string, IntrinsicFunction> StartColumnIndex { get; set; }

        /// <summary>
        /// StartPattern
        /// The starting pattern to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartPattern")]
        public Union<string, IntrinsicFunction> StartPattern { get; set; }

        /// <summary>
        /// StartPosition
        /// The starting position to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartPosition")]
        public Union<string, IntrinsicFunction> StartPosition { get; set; }

        /// <summary>
        /// StartValue
        /// The starting value to locate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartValue")]
        public Union<string, IntrinsicFunction> StartValue { get; set; }

        /// <summary>
        /// StemmingMode
        /// Indicates this operation uses stems and lemmas (base words) for word tokenization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StemmingMode")]
        public Union<string, IntrinsicFunction> StemmingMode { get; set; }

        /// <summary>
        /// StepCount
        /// The total number of transforms in this recipe.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StepCount")]
        public Union<string, IntrinsicFunction> StepCount { get; set; }

        /// <summary>
        /// StepIndex
        /// The index ID of a step.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StepIndex")]
        public Union<string, IntrinsicFunction> StepIndex { get; set; }

        /// <summary>
        /// StopWordsMode
        /// Indicates this operation uses stop words as part of word tokenization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StopWordsMode")]
        public Union<string, IntrinsicFunction> StopWordsMode { get; set; }

        /// <summary>
        /// Strategy
        /// The resolution strategy to apply in resolving ambiguities.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Strategy")]
        public Union<string, IntrinsicFunction> Strategy { get; set; }

        /// <summary>
        /// SheetNames
        /// Oone or more named sheets in the Excel file, which will be included in a dataset.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SheetNames")]
        public List<Union<string, IntrinsicFunction>> SheetNames { get; set; }

        /// <summary>
        /// SheetIndexes
        /// One or more sheet numbers in the Excel file, which will be included in a dataset.
        /// Required: No
        /// Type: List of Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SheetIndexes")]
        public List<Union<int, IntrinsicFunction>> SheetIndexes { get; set; }

        /// <summary>
        /// TargetColumn
        /// The column targeted by this operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetColumn")]
        public Union<string, IntrinsicFunction> TargetColumn { get; set; }

        /// <summary>
        /// TargetColumnNames
        /// The names to give columns altered by this operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetColumnNames")]
        public Union<string, IntrinsicFunction> TargetColumnNames { get; set; }

        /// <summary>
        /// TargetDateFormat
        /// The date format to convert to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetDateFormat")]
        public Union<string, IntrinsicFunction> TargetDateFormat { get; set; }

        /// <summary>
        /// TargetIndex
        /// The index number of an object that is targeted by this operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetIndex")]
        public Union<string, IntrinsicFunction> TargetIndex { get; set; }

        /// <summary>
        /// TimeZone
        /// The current timezone that you want to use for dates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeZone")]
        public Union<string, IntrinsicFunction> TimeZone { get; set; }

        /// <summary>
        /// TokenizerPattern
        /// A regex expression to use when splitting text into terms, also called words or tokens.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TokenizerPattern")]
        public Union<string, IntrinsicFunction> TokenizerPattern { get; set; }

        /// <summary>
        /// TrueString
        /// A value to use to represent TRUE.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TrueString")]
        public Union<string, IntrinsicFunction> TrueString { get; set; }

        /// <summary>
        /// UdfLang
        /// The language that&#39;s used in the user-defined function.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UdfLang")]
        public Union<string, IntrinsicFunction> UdfLang { get; set; }

        /// <summary>
        /// Units
        /// Specifies a unit of time. For example: MINUTES; SECONDS; HOURS; etc.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Units")]
        public Union<string, IntrinsicFunction> Units { get; set; }

        /// <summary>
        /// UnpivotColumn
        /// Cast columns as rows, so that each value is a different row in a single column.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnpivotColumn")]
        public Union<string, IntrinsicFunction> UnpivotColumn { get; set; }

        /// <summary>
        /// UpperBound
        /// The upper boundary for a value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpperBound")]
        public Union<string, IntrinsicFunction> UpperBound { get; set; }

        /// <summary>
        /// UseNewDataFrame
        /// Create a new container to hold a dataset.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseNewDataFrame")]
        public Union<string, IntrinsicFunction> UseNewDataFrame { get; set; }

        /// <summary>
        /// Value
        /// A static value that can be used in a comparison, a substitution, or in another context-specific way.
        /// A Value can be a number, string, or other datatype, depending on the recipe action in which it&#39;s
        /// used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Value1
        /// A value that&#39;s used by this operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value1")]
        public Union<string, IntrinsicFunction> Value1 { get; set; }

        /// <summary>
        /// Value2
        /// A value that&#39;s used by this operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value2")]
        public Union<string, IntrinsicFunction> Value2 { get; set; }

        /// <summary>
        /// ValueColumn
        /// The column that is provided as a value that&#39;s used by this operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ValueColumn")]
        public Union<string, IntrinsicFunction> ValueColumn { get; set; }

        /// <summary>
        /// ViewFrame
        /// The subset of rows currently available for viewing.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewFrame")]
        public Union<string, IntrinsicFunction> ViewFrame { get; set; }

        /// <summary>
        /// Input
        /// The input location to load the dataset from - Amazon S3 or AWS Glue Data Catalog.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Input")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Input { get; set; }

    }
}
