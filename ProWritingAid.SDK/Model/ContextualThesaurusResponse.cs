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
    * <summary>ContextualThesaurusResponse</summary> 
    */
    [DataContract]
    public partial class ContextualThesaurusResponse :  IEquatable<ContextualThesaurusResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualThesaurusResponse" /> class.
        /// </summary>
        /// <param name="Suggestions">List of context-specific suggestions.</param>
        public ContextualThesaurusResponse(List<string> Suggestions = default(List<string>))
        {
            this.Suggestions = Suggestions;
        }
        
        /// <summary>
        /// List of context-specific suggestions
        /// </summary>
        /// <value>List of context-specific suggestions</value>
        [DataMember(Name="Suggestions", EmitDefaultValue=false)]
        public List<string> Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContextualThesaurusResponse {\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return this.Equals(obj as ContextualThesaurusResponse);
        }

        /// <summary>
        /// Returns true if ContextualThesaurusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContextualThesaurusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextualThesaurusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Suggestions == other.Suggestions ||
                    this.Suggestions != null &&
                    this.Suggestions.SequenceEqual(other.Suggestions)
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
                if (this.Suggestions != null)
                    hash = hash * 59 + this.Suggestions.GetHashCode();
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
