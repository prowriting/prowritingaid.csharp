/* 
 * ProWritingAid API V2
 *
 * Official ProWritingAid API Version 2
 *
 * OpenAPI spec version: v2
 * Contact: hello@prowritingaid.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ProWritingAid.SDK.Client.SwaggerDateConverter;

namespace ProWritingAid.SDK.Model
{
    /** 
    * <summary>TextAnalysisResponse</summary> 
    */
    [DataContract]
    public partial class TextAnalysisResponse :  IEquatable<TextAnalysisResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalysisResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextAnalysisResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalysisResponse" /> class.
        /// </summary>
        /// <param name="Tags">List of found suggestions (required).</param>
        /// <param name="WordCount">Number of processed words (required).</param>
        /// <param name="Summaries"> (required).</param>
        public TextAnalysisResponse(List<DocTag> Tags = default(List<DocTag>), int? WordCount = default(int?), List<AnalysisSummary> Summaries = default(List<AnalysisSummary>))
        {
            // to ensure "Tags" is required (not null)
            if (Tags == null)
            {
                throw new InvalidDataException("Tags is a required property for TextAnalysisResponse and cannot be null");
            }
            else
            {
                this.Tags = Tags;
            }
            // to ensure "WordCount" is required (not null)
            if (WordCount == null)
            {
                throw new InvalidDataException("WordCount is a required property for TextAnalysisResponse and cannot be null");
            }
            else
            {
                this.WordCount = WordCount;
            }
            // to ensure "Summaries" is required (not null)
            if (Summaries == null)
            {
                throw new InvalidDataException("Summaries is a required property for TextAnalysisResponse and cannot be null");
            }
            else
            {
                this.Summaries = Summaries;
            }
        }
        
        /// <summary>
        /// List of found suggestions
        /// </summary>
        /// <value>List of found suggestions</value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<DocTag> Tags { get; set; }

        /// <summary>
        /// Number of processed words
        /// </summary>
        /// <value>Number of processed words</value>
        [DataMember(Name="WordCount", EmitDefaultValue=false)]
        public int? WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Summaries", EmitDefaultValue=false)]
        public List<AnalysisSummary> Summaries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextAnalysisResponse {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  WordCount: ").Append(WordCount).Append("\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TextAnalysisResponse);
        }

        /// <summary>
        /// Returns true if TextAnalysisResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TextAnalysisResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextAnalysisResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.WordCount == other.WordCount ||
                    this.WordCount != null &&
                    this.WordCount.Equals(other.WordCount)
                ) && 
                (
                    this.Summaries == other.Summaries ||
                    this.Summaries != null &&
                    this.Summaries.SequenceEqual(other.Summaries)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.WordCount != null)
                    hash = hash * 59 + this.WordCount.GetHashCode();
                if (this.Summaries != null)
                    hash = hash * 59 + this.Summaries.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
