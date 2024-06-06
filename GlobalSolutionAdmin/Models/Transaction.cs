

namespace GlobalSolutionAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int transaction_id { get; set; }
        public Nullable<int> site_id { get; set; }
        public Nullable<int> seller_client_id { get; set; }
        public Nullable<int> buyer_client_id { get; set; }
        public System.DateTime transaction_date { get; set; }
        public string transaction_type { get; set; }
        public decimal amount { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Client Client1 { get; set; }
        public virtual Site Site { get; set; }
    }
}
