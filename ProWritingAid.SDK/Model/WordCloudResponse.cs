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
    * <summary>WordCloudResponse</summary> 
    */
    [DataContract]
    public partial class WordCloudResponse :  IEquatable<WordCloudResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordCloudResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WordCloudResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WordCloudResponse" /> class.
        /// </summary>
        /// <param name="Url">the URL of the Word Cloud (required).</param>
        /// <param name="Language">The detected language of the text.</param>
        public WordCloudResponse(string Url = default(string), string Language = default(string))
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for WordCloudResponse and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            this.Language = Language;
        }
        
        /// <summary>
        /// the URL of the Word Cloud
        /// </summary>
        /// <value>the URL of the Word Cloud</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// The detected language of the text
        /// </summary>
        /// <value>The detected language of the text</value>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WordCloudResponse {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(obj as WordCloudResponse);
        }

        /// <summary>
        /// Returns true if WordCloudResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WordCloudResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WordCloudResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
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
