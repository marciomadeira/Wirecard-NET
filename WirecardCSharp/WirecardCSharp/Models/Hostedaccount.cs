using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Hostedaccount
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string redirectHref { get => RedirectHref; set => RedirectHref = value; }
    }
    public partial class Hostedaccount
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}
