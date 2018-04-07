/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.0.0
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
    /// IssueTokenResponse
    /// </summary>
    [DataContract]
    public partial class IssueTokenResponse :  IEquatable<IssueTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenResponse" /> class.
        /// </summary>
        /// <param name="TokenId">TokenId of the to be issued token.</param>
        /// <param name="TxHex">Unsigned, raw transaction hex of the transaction to issue the token.</param>
        public IssueTokenResponse(string TokenId = default(string), string TxHex = default(string))
        {
            this.TokenId = TokenId;
            this.TxHex = TxHex;
        }
        
        /// <summary>
        /// TokenId of the to be issued token
        /// </summary>
        /// <value>TokenId of the to be issued token</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Unsigned, raw transaction hex of the transaction to issue the token
        /// </summary>
        /// <value>Unsigned, raw transaction hex of the transaction to issue the token</value>
        [DataMember(Name="txHex", EmitDefaultValue=false)]
        public string TxHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TxHex: ").Append(TxHex).Append("\n");
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
            return this.Equals(input as IssueTokenResponse);
        }

        /// <summary>
        /// Returns true if IssueTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TxHex == input.TxHex ||
                    (this.TxHex != null &&
                    this.TxHex.Equals(input.TxHex))
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.TxHex != null)
                    hashCode = hashCode * 59 + this.TxHex.GetHashCode();
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
