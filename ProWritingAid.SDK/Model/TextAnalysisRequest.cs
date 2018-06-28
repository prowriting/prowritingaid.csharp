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
    * <summary>## Available Reports
Below is a list of the currently available reports from ProWritingAid. If you would like a different report, or require extra information, such as tokenization, sentence split, parts of speech, etc. then please [get in touch](https://prowritingaid.com/en/Home/Contact).

Report Name | Status | Description
------------ | ------------- | -------------
acronym | Live | Shows all the acronyms in your writing and highlights where they haven&#39;t been defined, or have been defined after the first occurrence, or have been defined multiple times.. |
alliteration | Live | Highlights alliterations in your writing. Alliterations are a linguistic tool used by some writers for effect.. |
allrepeats | Development | Highlights words and phrases that you&#39;ve used repeatedly in your text. |
allsentences | Live | Shows a visual representation of the sentences lengths of your writing. Try and vary the sentence lengths to maintain the interest of the reader.. |
bully | Development | Highlights bullying and vulgar language in your text.. |
cliche | Live | Scours your work for cliches and highlights them. Nobody likes to read a cliche so best to avoid them. Redundant expressions can also be removed as they say the same thing twice.. |
closerepeat | Development | Highlights any words and phrases that you have repeated within a short space of writing. Try and think of something else to say.. |
complex | Live | Highlights complex words in your writing. Words are broken down by number of syllables.. |
consistency | Live | Highlights inconsistency in your text. Picking up inconsistencies in your text can be one of the hardest editing tasks.. |
core | Development | Core findings. |
coreplus | Development | Core findings. |
corporate | Live | Highlights uses of corporate wording that can be simplified to clarify your document.. |
dialog | Live | Highlights the dialogue tags in your text. Editors prefer minimal use of all dialogue tags (except for &#39;said&#39;).. |
diction | Live | Provides a list of possible diction problems and suggestions on how you might revise them.. |
dva | Live | Highlights diction problems, vague and abstract words in your text.. |
eloquence | Live | Designed to help you develop your use of stylistic writing techniques such as alliteration, epistrophe, and hendiadys. The items in this report are not suggestions, just aids to help you along the way.. |
grammar | Live | Checks your text for grammar errors and potential word mis-use.. |
grammarplus | Live | Checks your text for grammar errors and potential word mis-use.. |
homonym | Live | Helps you check for incorrect word usage. Homonyms are words which sound alike yet are spelled differently. For example: there, their and they&#39;re or raw and roar.. |
house | Development | A blank report for you to create your own patterns in. Ideal for a house style. Go to the settings screen to set-up your own patterns. . |
initial | Live | Highlights the initial pronouns in your text. Repetitive use of initial pronouns can lead to boring text, e.g. He did this. He did that. He did another thing.. |
nlp | Development | Our NLP Predicate Words report allows you to easily identify the key modality or representation system of a piece of text. If you are analyzing a document written by someone else then this will give you an idea of their preferred representational system. This may help you tailor your writing in order to build rapport. If you don&#39;t know the modality of your reader then try to use a balance of words from each modality. This will broaden the appeal of your writing.. |
overused | Live | Compares the frequency of commonly overused words in your text to published writing to give you an indication of where you may be over-using words.. |
overusedonly | Live | Compares the frequency of commonly overused words in your text to published writing to give you an indication of where you may be over-using words.. |
overview | Live | Gives you an overview of the key metrics for your document.. |
pacing | Live | Identifies the slower paced parts of your manuscript, such as introspection and backstory so you can spread them out. Try not to have too many slower paced paragraphs in a row as this can get boring.. |
paragraph_readability | Live | Shows you the relative readability of each paragraph in your text.. |
passive | Live | Highlights areas where your writing style might be improved, such as use of passive and hidden verbs.. |
phrases | Live | Provides a summary of all the phrases that you have repeated in your writing. Try and cut down on repeats.. |
plagiarism | Live | Identifies parts of your text that occur in other documents. Scans millions of web-pages, books, and academic papers.. |
plength | Live | A visual representation of the paragraph lengths of your writing. Avoid writing more than five or six sentences in a paragraph. Also try to avoid too many short paragraphs.. |
preadability | Live | Provides a series of readability measures for your text so you can determine if it is suitable for your intended audience.. |
readability | Live | Provides a series of readability measures for your text so you can determine if it is suitable for your intended audience.. |
sentiment | Live | Shows a histogram of the sentiment in your story so you can monitor large swings.. |
sentimentwords | Development | Highlights words that have a sentiment bias in your text, and grades them.. |
seo | Development | Shows how yout text can be optimized to appear higher in Google rankings.. |
slength | Live | Shows a visual representation of the sentences lengths of your writing. Try and vary the sentence lengths to maintain the interest of the reader.. |
ssentences | Live | Shows sticky sentences in your writing. Sticky sentences slow your reader down; try to avoid them.. |
ssentences_noglue | Live | Shows sticky sentences in your writing. Sticky sentences slow your reader down; try to avoid them.. |
structure | Live | Highlights the key structure of a document such as sentences and paragraphs.. |
thesaurus | Beta | Shows possible replacements for nouns, verbs, adjectives and adverbs.. |
time | Live | Highlights any temporal references in your text so you can check for inconsistency and view the time-line of your text.. |
topics | Live | Suggested topics that are related to the subject matter of your text.. |
transition | Live | Highlights the transitions in your report. Transitions help organize ideas. Writing that is short on transitions is often hard to follow. Non-fiction writing that has under 1 transition per 4 sentences tends to be less understandable.. |
vague | Live | Provides a list of words that may be considered vague or abstract. Consider strengthening them.. |
wordcloud | Live | Shows you a word cloud of the most commonly occuring words in your text.. |
wordsandphrases | Deprecated | Highlights any words and phrases that you have repeated within a short space of writing. Try and think of something else to say.. |
wordsphrases | Live | Highlights any words and phrases that you have repeated within a short space of writing. Try and think of something else to say.. |</summary> 
    */
    [DataContract]
    public partial class TextAnalysisRequest :  IEquatable<TextAnalysisRequest>, IValidatableObject
    {
        /// <summary>
        /// Document&#39;s writing style
        /// </summary>
        /// <value>Document&#39;s writing style</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleEnum
        {
            
            /// <summary>
            /// Enum NotSet for "NotSet"
            /// </summary>
            [EnumMember(Value = "NotSet")]
            NotSet,
            
            /// <summary>
            /// Enum General for "General"
            /// </summary>
            [EnumMember(Value = "General")]
            General,
            
            /// <summary>
            /// Enum Academic for "Academic"
            /// </summary>
            [EnumMember(Value = "Academic")]
            Academic,
            
            /// <summary>
            /// Enum Business for "Business"
            /// </summary>
            [EnumMember(Value = "Business")]
            Business,
            
            /// <summary>
            /// Enum Technical for "Technical"
            /// </summary>
            [EnumMember(Value = "Technical")]
            Technical,
            
            /// <summary>
            /// Enum Creative for "Creative"
            /// </summary>
            [EnumMember(Value = "Creative")]
            Creative,
            
            /// <summary>
            /// Enum Casual for "Casual"
            /// </summary>
            [EnumMember(Value = "Casual")]
            Casual,
            
            /// <summary>
            /// Enum Web for "Web"
            /// </summary>
            [EnumMember(Value = "Web")]
            Web
        }

        /// <summary>
        /// Document&#39;s language. Set correct UK/US language to get region-specific suggestions
        /// </summary>
        /// <value>Document&#39;s language. Set correct UK/US language to get region-specific suggestions</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageEnum
        {
            
            /// <summary>
            /// Enum EnUS for "en_US"
            /// </summary>
            [EnumMember(Value = "en_US")]
            EnUS,
            
            /// <summary>
            /// Enum EnUK for "en_UK"
            /// </summary>
            [EnumMember(Value = "en_UK")]
            EnUK,
            
            /// <summary>
            /// Enum En for "en"
            /// </summary>
            [EnumMember(Value = "en")]
            En,
            
            /// <summary>
            /// Enum Es for "es"
            /// </summary>
            [EnumMember(Value = "es")]
            Es
        }

        /// <summary>
        /// Document&#39;s writing style
        /// </summary>
        /// <value>Document&#39;s writing style</value>
        [DataMember(Name="Style", EmitDefaultValue=false)]
        public StyleEnum? Style { get; set; }
        /// <summary>
        /// Document&#39;s language. Set correct UK/US language to get region-specific suggestions
        /// </summary>
        /// <value>Document&#39;s language. Set correct UK/US language to get region-specific suggestions</value>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalysisRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextAnalysisRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalysisRequest" /> class.
        /// </summary>
        /// <param name="Text">Text to be processed (required).</param>
        /// <param name="Reports">List of reports - EXAMPLE: [\&quot;grammar\&quot;,\&quot;overused\&quot;] (required).</param>
        /// <param name="Style">Document&#39;s writing style (required) (default to StyleEnum.General).</param>
        /// <param name="Language">Document&#39;s language. Set correct UK/US language to get region-specific suggestions (required) (default to LanguageEnum.En).</param>
        public TextAnalysisRequest(string Text = default(string), List<string> Reports = default(List<string>), StyleEnum? Style = StyleEnum.General, LanguageEnum? Language = LanguageEnum.En)
        {
            // to ensure "Text" is required (not null)
            if (Text == null)
            {
                throw new InvalidDataException("Text is a required property for TextAnalysisRequest and cannot be null");
            }
            else
            {
                this.Text = Text;
            }
            // to ensure "Reports" is required (not null)
            if (Reports == null)
            {
                throw new InvalidDataException("Reports is a required property for TextAnalysisRequest and cannot be null");
            }
            else
            {
                this.Reports = Reports;
            }
            // to ensure "Style" is required (not null)
            if (Style == null)
            {
                throw new InvalidDataException("Style is a required property for TextAnalysisRequest and cannot be null");
            }
            else
            {
                this.Style = Style;
            }
            // to ensure "Language" is required (not null)
            if (Language == null)
            {
                throw new InvalidDataException("Language is a required property for TextAnalysisRequest and cannot be null");
            }
            else
            {
                this.Language = Language;
            }
        }
        
        /// <summary>
        /// Text to be processed
        /// </summary>
        /// <value>Text to be processed</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// List of reports - EXAMPLE: [\&quot;grammar\&quot;,\&quot;overused\&quot;]
        /// </summary>
        /// <value>List of reports - EXAMPLE: [\&quot;grammar\&quot;,\&quot;overused\&quot;]</value>
        [DataMember(Name="Reports", EmitDefaultValue=false)]
        public List<string> Reports { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextAnalysisRequest {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Reports: ").Append(Reports).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(obj as TextAnalysisRequest);
        }

        /// <summary>
        /// Returns true if TextAnalysisRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TextAnalysisRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextAnalysisRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Reports == other.Reports ||
                    this.Reports != null &&
                    this.Reports.SequenceEqual(other.Reports)
                ) && 
                (
                    this.Style == other.Style ||
                    this.Style != null &&
                    this.Style.Equals(other.Style)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Reports != null)
                    hash = hash * 59 + this.Reports.GetHashCode();
                if (this.Style != null)
                    hash = hash * 59 + this.Style.GetHashCode();
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
