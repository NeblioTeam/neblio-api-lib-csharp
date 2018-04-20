/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.1.1
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// IssueTokenRequestMetadataEncryptions
    /// </summary>
    [DataContract]
    public partial class IssueTokenRequestMetadataEncryptions :  IEquatable<IssueTokenRequestMetadataEncryptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenRequestMetadataEncryptions" /> class.
        /// </summary>
        /// <param name="Key">userData key to encrypt.</param>
        /// <param name="Pubkey">RSA public key used for encryption.</param>
        /// <param name="Format">key format (pem or der).</param>
        /// <param name="Type">pkcs1 or pkcs8.</param>
        public IssueTokenRequestMetadataEncryptions(string Key = default(string), string Pubkey = default(string), string Format = default(string), string Type = default(string))
        {
            this.Key = Key;
            this.Pubkey = Pubkey;
            this.Format = Format;
            this.Type = Type;
        }
        
        /// <summary>
        /// userData key to encrypt
        /// </summary>
        /// <value>userData key to encrypt</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// RSA public key used for encryption
        /// </summary>
        /// <value>RSA public key used for encryption</value>
        [DataMember(Name="pubkey", EmitDefaultValue=false)]
        public string Pubkey { get; set; }

        /// <summary>
        /// key format (pem or der)
        /// </summary>
        /// <value>key format (pem or der)</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// pkcs1 or pkcs8
        /// </summary>
        /// <value>pkcs1 or pkcs8</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenRequestMetadataEncryptions {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Pubkey: ").Append(Pubkey).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueTokenRequestMetadataEncryptions);
        }

        /// <summary>
        /// Returns true if IssueTokenRequestMetadataEncryptions instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenRequestMetadataEncryptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenRequestMetadataEncryptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Pubkey == input.Pubkey ||
                    (this.Pubkey != null &&
                    this.Pubkey.Equals(input.Pubkey))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Pubkey != null)
                    hashCode = hashCode * 59 + this.Pubkey.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
