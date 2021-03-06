/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.3.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Neblio.API.Client.OpenAPIDateConverter;

namespace Neblio.API.Model
{
    /// <summary>
    /// IssueTokenRequestMetadataUrls
    /// </summary>
    [DataContract]
    public partial class IssueTokenRequestMetadataUrls :  IEquatable<IssueTokenRequestMetadataUrls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenRequestMetadataUrls" /> class.
        /// </summary>
        /// <param name="name">Name of the URL.</param>
        /// <param name="url">Actual URL.</param>
        /// <param name="mimeType">mimeType of URL content.</param>
        /// <param name="dataHash">Hash of data at the URL, used for verification.</param>
        public IssueTokenRequestMetadataUrls(string name = default(string), string url = default(string), string mimeType = default(string), string dataHash = default(string))
        {
            this.Name = name;
            this.Url = url;
            this.MimeType = mimeType;
            this.DataHash = dataHash;
        }
        
        /// <summary>
        /// Name of the URL
        /// </summary>
        /// <value>Name of the URL</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Actual URL
        /// </summary>
        /// <value>Actual URL</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// mimeType of URL content
        /// </summary>
        /// <value>mimeType of URL content</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Hash of data at the URL, used for verification
        /// </summary>
        /// <value>Hash of data at the URL, used for verification</value>
        [DataMember(Name="dataHash", EmitDefaultValue=false)]
        public string DataHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenRequestMetadataUrls {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  DataHash: ").Append(DataHash).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueTokenRequestMetadataUrls);
        }

        /// <summary>
        /// Returns true if IssueTokenRequestMetadataUrls instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenRequestMetadataUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenRequestMetadataUrls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.DataHash == input.DataHash ||
                    (this.DataHash != null &&
                    this.DataHash.Equals(input.DataHash))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.DataHash != null)
                    hashCode = hashCode * 59 + this.DataHash.GetHashCode();
                return hashCode;
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
