/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.1
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
    /// Object containing an array of transaction objects
    /// </summary>
    [DataContract]
    public partial class GetTxsResponse :  IEquatable<GetTxsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTxsResponse" /> class.
        /// </summary>
        /// <param name="pagesTotal">Number of pages of transactions.</param>
        /// <param name="txs">Array of transaction objects.</param>
        public GetTxsResponse(decimal? pagesTotal = default(decimal?), List<GetTxResponse> txs = default(List<GetTxResponse>))
        {
            this.PagesTotal = pagesTotal;
            this.Txs = txs;
        }
        
        /// <summary>
        /// Number of pages of transactions
        /// </summary>
        /// <value>Number of pages of transactions</value>
        [DataMember(Name="pagesTotal", EmitDefaultValue=false)]
        public decimal? PagesTotal { get; set; }

        /// <summary>
        /// Array of transaction objects
        /// </summary>
        /// <value>Array of transaction objects</value>
        [DataMember(Name="txs", EmitDefaultValue=false)]
        public List<GetTxResponse> Txs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTxsResponse {\n");
            sb.Append("  PagesTotal: ").Append(PagesTotal).Append("\n");
            sb.Append("  Txs: ").Append(Txs).Append("\n");
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
            return this.Equals(input as GetTxsResponse);
        }

        /// <summary>
        /// Returns true if GetTxsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTxsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTxsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PagesTotal == input.PagesTotal ||
                    (this.PagesTotal != null &&
                    this.PagesTotal.Equals(input.PagesTotal))
                ) && 
                (
                    this.Txs == input.Txs ||
                    this.Txs != null &&
                    this.Txs.SequenceEqual(input.Txs)
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
                if (this.PagesTotal != null)
                    hashCode = hashCode * 59 + this.PagesTotal.GetHashCode();
                if (this.Txs != null)
                    hashCode = hashCode * 59 + this.Txs.GetHashCode();
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
