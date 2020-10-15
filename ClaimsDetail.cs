using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleXMLTest.Models
{
    public class ClaimsDetailModel
    {
        public PhysicianClaimsModel PhysicianClaimsEntity { get; set; }
    }

    #region PhysicianClaims
    public class PhysicianClaimsModel
    {
        public pPhysModel pPhys { get; set; }
        public clmTrailerModel clmTrailer { get; set; }
    }

    public class clmTrailerModel
    {
        public string icnRegionCode { get; set; }
    }

    #region pPhys
    public class pPhysModel
    {
        public string ind_attachment { get; set; }
        public string dte_accident { get; set; }
        public string num_dtl_total { get; set; }
        public string cde_clm_status { get; set; }
        public string cde_clm_type { get; set; }
        public string tpl_amt { get; set; }
        public string dte_billed { get; set; }
        public string amt_billed { get; set; }
        public string amt_patnt_liab { get; set; }
        public string num_pat_acct { get; set; }
        public string dte_first_svc { get; set; }
        public string dte_last_svc { get; set; }
        public string dte_to_hosp { get; set; }
        public string amt_net_billed { get; set; }
        public string amt_co_pay { get; set; }
        public string ind_accident { get; set; }
        public string cde_county { get; set; }
        public string cde_claim_frequency { get; set; }
        public string prov_billing { get; set; }
        public string num_icn { get; set; }
        public string ind_prov_sign { get; set; }
        public string ind_encounter { get; set; }
        public string cde_med_rec_num { get; set; }
        public string ind_carrier_denied { get; set; }
        public physHdrKeyModel physHdrKey { get; set; }
        public clmHdrDeliveryModel clmHdrDelivery { get; set; }
        public List<detailModel> detail { get; set; }
        public List<diag_xrefModel> diag_xref { get; set; }
    }

    #region physHdrKey
    public class physHdrKeyModel
    {
        public string cde_special_program { get; set; }
        public string id_medicaid { get; set; }
        public string clm_recip_fst_nam { get; set; }
        public string clm_lst_nam_recip { get; set; }
        public string qlf_sub_dob_fmt { get; set; }
        public string dte_subscriber_dob { get; set; }
        public string cde_subscriber_gender { get; set; }
        public string cde_med_assignment { get; set; }
        public string ind_benefits_Assignment { get; set; }
        public string cde_release_information { get; set; }
        public string cde_patient_signature { get; set; }
        public string ind_benefits_assignment { get; set; }
        public string cde_accident_state { get; set; }
        public string cde_accident_country { get; set; }
        public string id_provider { get; set; }
        public string id_perf_prov { get; set; }
        public string id_prov_refer { get; set; }
        public string id_prov_referring_2 { get; set; }
        public string cde_related_cause_1 { get; set; }
        public clmSbrModel clmSbr { get; set; }
        public List<clmEntity_physHdrKeyModel> clmEntity { get; set; }
        public List<profOthPyrHdrModel> profOthPyrHdr { get; set; }
        public List<clmNteModel> clmNte { get; set; }
        public List<clmRefModel> clmRef { get; set; }
        public List<clmDtpModel> clmDtp { get; set; }
        public List<clmPwkModel> clmPwk { get; set; }
        public List<clmCrcModel> clmCrc { get; set; }
    }
    public class clmSbrModel
    {
        public string cde_claim_filing_ind { get; set; }
        public string cde_insured_group_number { get; set; }
        public string cde_payer_responsib { get; set; }
        public string cde_ind_relationship { get; set; }
        public string cde_insurance_type { get; set; }
        public string nam_insured_group { get; set; }
    }
    public class profOthPyrHdrModel
    {
        public string ind_release_of_info { get; set; }
        public string ind_ben_assignment { get; set; }
        public string dte_other_sub_dob { get; set; }
        public string cde_release_of_info { get; set; }
        public string amt_alwd_oth_pyr { get; set; }
        public string cde_other_sub_gender { get; set; }
        public string ind_benefits_assignment { get; set; }
        public string dte_clm_adjudication { get; set; }
        public string qlf_claim_adjud_dt { get; set; }
        public string qlf_clm_adjud_dt_fmt { get; set; }
        public List<clmPayerEntityModel> clmPayerEntity { get; set; }
        public clmSbrModel clmSbr { get; set; }
        public List<clmAmtModel> clmAmt { get; set; }
        public List<clmCasModel> clmCas { get; set; }
    }
    public class clmAmtModel
    {
        public string qlf_amount { get; set; }
        public string amt_monetary { get; set; }
    }
    public class clmCasModel
    {
        public string cde_clm_adj_reason { get; set; }
        public string cde_clm_adj_group { get; set; }
        public string amt_adjustment { get; set; }
        public string qty_adjustment { get; set; }
        public string num_cas_seq { get; set; }
        public string num_dtl_svd { get; set; }
        public string num_dtl { get; set; }
    }
    public class clmNteModel
    {
        public string cde_note { get; set; }
        public string dsc_note { get; set; }
        public string num_dtl { get; set; }
    }
    public class clmDtpModel
    {
        public string qlf_date_time { get; set; }
        public string dte_time_period { get; set; }
    }
    public class clmPwkModel
    {
        public string cde_rpt_transmission { get; set; }
        public string cde_attachment_control { get; set; }
    }
    public class clmCrcModel
    {
        public string cde_category { get; set; }
        public string cde_condition { get; set; }
        public string ind_condition { get; set; }
    }
    #endregion
    public class clmHdrDeliveryModel
    {
        public string dte_delivery { get; set; }
    }

    #region detail
    public class detailModel
    {
        public string amt_detail_tpl { get; set; }
        public string amt_co_pay { get; set; }
        public string cde_diag_treat_ind { get; set; }
        public string ind_pregnancy { get; set; }
        public string num_dtl { get; set; }
        public string dte_first_svc { get; set; }
        public string dte_last_svc { get; set; }
        public string qty_billed { get; set; }
        public string qty_allowed { get; set; }
        public string ind_emergency { get; set; }
        public string cde_proc_mod { get; set; }
        public string cde_modifier_2 { get; set; }
        public string cde_modifier_3 { get; set; }
        public string amt_billed { get; set; }
        public string amt_alwd { get; set; }
        public string cde_pos { get; set; }
        public string cde_clm_status { get; set; }
        public string cde_modifier_4 { get; set; }
        public string cde_prov_spec { get; set; }
        public string cde_epsdt_fp { get; set; }

        public physDtlKeyModel physDtlKey { get; set; }
        public clmEapgDtlModel clmEapgDtl { get; set; }
    }

    #region physDtlKey
    public class physDtlKeyModel
    {
        public string cde_proc { get; set; }
        public string ind_less_90 { get; set; }
        public string cde_pos_sub { get; set; }
        public string qlf_procedure_qlf { get; set; }
        public string qlf_svc_line_dte_fmt { get; set; }
        public string id_perf_prov { get; set; }
        public string id_prov_referring { get; set; }
        public List<clmEntityModel> clmEntity { get; set; }
        public List<clmNdcDtlModel> clmNdcDtl { get; set; }
    }

    #region clmEntity
    public class clmEntityModel
    {
        public string qlf_type_org { get; set; }
        public string qlf_entity_type { get; set; }
        public string cde_provider_type { get; set; }
        public string cde_prov_taxonomy { get; set; }
        public List<clmEntNmAdrModel> clmEntNmAdr { get; set; }
    }
    public class clmEntity_physHdrKeyModel
    {
        public string qlf_type_org { get; set; }
        public string qlf_entity_type { get; set; }
        public string cde_provider_type { get; set; }
        public string cde_prov_taxonomy { get; set; }
        public clmEntNmAdrModel clmEntNmAdr { get; set; }
    }
    public class clmEntNmAdrModel
    {
        public string qlf_entity_type { get; set; }
        public string ind_primary_id { get; set; }
        public partyIdentifierModel partyIdentifier { get; set; }
        public clmNameNm1Model clmNameNm1 { get; set; }
    }
    public class partyIdentifierModel
    {
        public string qty_billed_sub { get; set; }
        public string qty_billed_orig { get; set; }
        public string cde_proc_sub { get; set; }        
        public string qlf_id_type { get; set; }
        public string cde_party_id { get; set; }
    }
    public class clmNameNm1Model
    {
        public string nam_first { get; set; }
        public string nam_middle { get; set; }
        public string nam_last { get; set; }
    }

    #endregion

    public class clmNdcDtlModel
    {
        public string sak_short { get; set; }
        public string cde_prod_serv_id { get; set; }
        public string qty_units_svc { get; set; }
        public string cde_unit_measure { get; set; }
        public string amt_drug_unit_price { get; set; }
        public string qlf_prod_serv_id { get; set; }
        public string qlf_prescription_id { get; set; }
        public string num_prescription_id { get; set; }       
    }
    #endregion
    public class clmEapgDtlModel
    {
        public string cde_eapg_sub { get; set; }
    }
    #endregion
  
    public class diag_xrefModel
    {
        public string qlf_code_list { get; set; }
        public string cde_diag_seq { get; set; }
        public string cde_diag { get; set; }
    }

    #endregion

    public class clmPayerEntityModel
    {
        public string qlf_entity_type { get; set; }
        public string qlf_type_org { get; set; }
        public clmPyrEntnmadrModel clmPyrEntnmadr { get; set; }
        public clmRefModel clmRef { get; set; }
    }

    public class clmPyrEntnmadrModel
    {
        public string ind_primary_id { get; set; }
        public string qlf_entity_type { get; set; }
        public string nam_last { get; set; }
        public partyIdentifierModel partyIdentifier { get; set; }
        public clmNameNm1Model clmNameNm1 { get; set; }
    }

    public class clmRefModel
    {
        public string qlf_reference_id { get; set; }
        public string cde_ref_id { get; set; }
        public string qlf_entity_type { get; set; }
    }
    #endregion




}