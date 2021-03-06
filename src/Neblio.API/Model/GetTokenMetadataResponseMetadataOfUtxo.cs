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
    /// Metadata set for UTXO
    /// </summary>
    [DataContract]
    public partial class GetTokenMetadataResponseMetadataOfUtxo :  IEquatable<GetTokenMetadataResponseMetadataOfUtxo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenMetadataResponseMetadataOfUtxo" /> class.
        /// </summary>
        /// <param name="userData">userData.</param>
        public GetTokenMetadataResponseMetadataOfUtxo(GetTokenMetadataResponseMetadataOfUtxoUserData userData = default(GetTokenMetadataResponseMetadataOfUtxoUserData))
        {
            this.UserData = userData;
        }
        
        /// <summary>
        /// Gets or Sets UserData
        /// </summary>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public GetTokenMetadataResponseMetadataOfUtxoUserData UserData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenMetadataResponseMetadataOfUtxo {\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
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
            return this.Equals(input as GetTokenMetadataResponseMetadataOfUtxo);
        }

        /// <summary>
        /// Returns true if GetTokenMetadataResponseMetadataOfUtxo instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenMetadataResponseMetadataOfUtxo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenMetadataResponseMetadataOfUtxo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
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
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
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
