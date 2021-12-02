using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_Start.Models
{
    public class Parks
    {
        public string api_version { get; set; }
      //  public Pagination pagination { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public int ID { get; set; }
        public string committee_id { get; set; }
        public object sponsor_candidate_ids { get; set; }
        public int[] cycles { get; set; }
        public string treasurer_name { get; set; }
        public object[] sponsor_candidate_list { get; set; }
        public string party { get; set; }
        public string last_f1_date { get; set; }
        public string affiliated_committee_name { get; set; }
        public string first_f1_date { get; set; }
        public string state { get; set; }
        public string organization_type { get; set; }
        public string organization_type_full { get; set; }
        public string filing_frequency { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string[] candidate_ids { get; set; }
        public string last_file_date { get; set; }
        public string first_file_date { get; set; }
        public string committee_type { get; set; }
        public string party_full { get; set; }
        public string designation_full { get; set; }
        public string committee_type_full { get; set; }
    }
}


