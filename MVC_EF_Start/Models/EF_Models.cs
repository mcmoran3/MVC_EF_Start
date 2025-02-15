﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Start.Models
{
    public class Company
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public bool isEnabled { get; set; }
        public string type { get; set; }
        public string iexId { get; set; }
        public List<Quote> Quotes { get; set; }
    }

    public class Quote
    {
        public int Id { get; set; }
        public string date { get; set; }
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public float change { get; set; }
        public float changePercent { get; set; }
        public float vwap { get; set; }
        public string label { get; set; }
        public float changeOverTime { get; set; }
        public string ClassDemo { get; set; }
        public Company Company { get; set; }
    }

    public class Candidate_Master  
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string party { get; set; }

        public string year { get; set; }
        public string state { get; set; }
        //  public Company party { get; set; }
    }

    public class Committee_Master
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }

        public string Memo { get; set; }
        public string CandidateID  { get; set; }
   
    }

    public class ContributionByIndividual
    {
        public int Id { get; set; }
        public string IndividualName { get; set; }
        public string State { get; set; }

        public string Occupation { get; set; }
        public string Amount { get; set; }

    }

    public class ContributionByCommittee
    {
        public int Id { get; set; }
        public string TransactionDate { get; set; }
        public string Amount { get; set; }

        public string Memo { get; set; }
        public string CandidateID  { get; set; }

    }

    public class ChartRoot
    {
        public Quote[] chart { get; set; }
    }
}