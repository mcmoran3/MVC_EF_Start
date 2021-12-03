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
        public Resultind[] resultinds{ get; set; }
        public Committee[] Committees { get; set; }
    }

    public class Resultind
    {
        public string line_number { get; set; }
        public string schedule_type_full { get; set; }
        public object back_reference_schedule_name { get; set; }
        public string sub_id { get; set; }
        public object candidate_name { get; set; }
        public object candidate_office_state { get; set; }
        public string contributor_city { get; set; }
        public string contributor_state { get; set; }
        public string contributor_suffix { get; set; }
        public string schedule_type { get; set; }
        public int two_year_transaction_period { get; set; }
        public string contributor_last_name { get; set; }
        public bool is_individual { get; set; }
        public object contribution_receipt_date { get; set; }
        public object increased_limit { get; set; }
        public object national_committee_nonfederal_account { get; set; }
        public object receipt_type_full { get; set; }
        public string contributor_name { get; set; }
        public object candidate_last_name { get; set; }
        public string contributor_zip { get; set; }
        public object contributor_prefix { get; set; }
        public int report_year { get; set; }
        public object conduit_committee_zip { get; set; }
        public string image_number { get; set; }
        public string committee_id { get; set; }
        public string receipt_type { get; set; }
        public string entity_type_desc { get; set; }
        public object contributor_id { get; set; }
        public string election_type { get; set; }
        public long link_id { get; set; }
        public object back_reference_transaction_id { get; set; }
        public float contributor_aggregate_ytd { get; set; }
        public Committee committee { get; set; }
        public string entity_type { get; set; }
        public object original_sub_id { get; set; }
        public object candidate_middle_name { get; set; }
        public object donor_committee_name { get; set; }
        public object memo_code_full { get; set; }
        public object conduit_committee_street1 { get; set; }
        public float contribution_receipt_amount { get; set; }
        public object candidate_id { get; set; }
        public string contributor_first_name { get; set; }
        public string report_type { get; set; }
        public string recipient_committee_org_type { get; set; }
        public object conduit_committee_state { get; set; }
        public string receipt_type_desc { get; set; }
        public string amendment_indicator { get; set; }
        public string contributor_street_2 { get; set; }
        public string contributor_occupation { get; set; }
        public string unused_contbr_id { get; set; }
        public int file_number { get; set; }
        public string recipient_committee_designation { get; set; }
        public string filing_form { get; set; }
        public object candidate_office_full { get; set; }
        public object candidate_office { get; set; }
        public object candidate_first_name { get; set; }
        public string line_number_label { get; set; }
        public object candidate_suffix { get; set; }
        public string amendment_indicator_desc { get; set; }
        public object fec_election_year { get; set; }
        public object memo_code { get; set; }
        public object candidate_prefix { get; set; }
        public string contributor_middle_name { get; set; }
        public DateTime load_date { get; set; }
        public string pdf_url { get; set; }
        public string contributor_street_1 { get; set; }
        public string fec_election_type_desc { get; set; }
        public object memo_text { get; set; }
        public object candidate_office_district { get; set; }
        public object committee_name { get; set; }
        public object conduit_committee_street2 { get; set; }
        public string recipient_committee_type { get; set; }
        public object election_type_full { get; set; }
        public object candidate_office_state_full { get; set; }
        public object conduit_committee_id { get; set; }
        public object conduit_committee_name { get; set; }
        public string contributor_employer { get; set; }
        public bool memoed_subtotal { get; set; }
        public object conduit_committee_city { get; set; }
        public object transaction_id { get; set; }
        public object contributor { get; set; }
    }

    public class Result
    {
        public int ID { get; set; }
        public string candidate_id { get; set; }
        public string committee_id { get; set; }
        public int[] election_years { get; set; }

     
        public string[] election_districts { get; set; }
        public string office { get; set; }
    
        public bool candidate_inactive { get; set; }

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

   
    public class Committee
    {
        public string street_1 { get; set; }
        public object sponsor_candidate_ids { get; set; }
        public object former_committee_name { get; set; }
        public object former_candidate_id { get; set; }
        public string state { get; set; }
        public string filing_frequency { get; set; }
        public string last_file_date { get; set; }
        public int[] cycles { get; set; }
        public string first_f1_date { get; set; }
        public bool convert_to_pac_flag { get; set; }
        public int last_cycle_has_activity { get; set; }
        public string zip { get; set; }
        public string designation_full { get; set; }
        public string party { get; set; }
        public int[] cycles_has_activity { get; set; }
        public string organization_type { get; set; }
        public bool is_active { get; set; }
        public object former_candidate_name { get; set; }
        public string committee_id { get; set; }
        public int cycle { get; set; }
        public string state_full { get; set; }
        public string[] candidate_ids { get; set; }
        public string organization_type_full { get; set; }
        public string street_2 { get; set; }
        public int[] cycles_has_financial { get; set; }
        public string treasurer_name { get; set; }
        public string party_full { get; set; }
        public string committee_type { get; set; }
        public string affiliated_committee_name { get; set; }
        public string last_f1_date { get; set; }
        public string name { get; set; }
        public int last_cycle_has_financial { get; set; }
        public string city { get; set; }
        public object former_candidate_election_year { get; set; }
        public string committee_type_full { get; set; }
        public string designation { get; set; }
        public string first_file_date { get; set; }
    }


}


