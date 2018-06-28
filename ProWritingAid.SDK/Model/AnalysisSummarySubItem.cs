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
    * <summary>AnalysisSummarySubItem</summary> 
    */
    [DataContract]
    public partial class AnalysisSummarySubItem :  IEquatable<AnalysisSummarySubItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisSummarySubItem" /> class.
        /// </summary>
        /// <param name="TagIds">TagIds.</param>
        /// <param name="Text">Text.</param>
        /// <param name="SuggestionCategory">SuggestionCategory.</param>
        /// <param name="SubCategory">SubCategory.</param>
        /// <param name="SearchTerm">SearchTerm.</param>
        public AnalysisSummarySubItem(List<string> TagIds = default(List<string>), string Text = default(string), string SuggestionCategory = default(string), string SubCategory = default(string), string SearchTerm = default(string))
        {
            this.TagIds = TagIds;
            this.Text = Text;
            this.SuggestionCategory = SuggestionCategory;
            this.SubCategory = SubCategory;
            this.SearchTerm = SearchTerm;
        }
        
        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="TagIds", EmitDefaultValue=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets SuggestionCategory
        /// </summary>
        [DataMember(Name="SuggestionCategory", EmitDefaultValue=false)]
        public string SuggestionCategory { get; set; }

        /// <summary>
        /// Gets or Sets SubCategory
        /// </summary>
        [DataMember(Name="SubCategory", EmitDefaultValue=false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// Gets or Sets SearchTerm
        /// </summary>
        [DataMember(Name="SearchTerm", EmitDefaultValue=false)]
        public string SearchTerm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisSummarySubItem {\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  SuggestionCategory: ").Append(SuggestionCategory).Append("\n");
            sb.Append("  SubCategory: ").Append(SubCategory).Append("\n");
            sb.Append("  SearchTerm: ").Append(SearchTerm).Append("\n");
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
            return this.Equals(obj as AnalysisSummarySubItem);
        }

        /// <summary>
        /// Returns true if AnalysisSummarySubItem instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalysisSummarySubItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisSummarySubItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TagIds == other.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(other.TagIds)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.SuggestionCategory == other.SuggestionCategory ||
                    this.SuggestionCategory != null &&
                    this.SuggestionCategory.Equals(other.SuggestionCategory)
                ) && 
                (
                    this.SubCategory == other.SubCategory ||
                    this.SubCategory != null &&
                    this.SubCategory.Equals(other.SubCategory)
                ) && 
                (
                    this.SearchTerm == other.SearchTerm ||
                    this.SearchTerm != null &&
                    this.SearchTerm.Equals(other.SearchTerm)
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
                if (this.TagIds != null)
                    hash = hash * 59 + this.TagIds.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.SuggestionCategory != null)
                    hash = hash * 59 + this.SuggestionCategory.GetHashCode();
                if (this.SubCategory != null)
                    hash = hash * 59 + this.SubCategory.GetHashCode();
                if (this.SearchTerm != null)
                    hash = hash * 59 + this.SearchTerm.GetHashCode();
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
