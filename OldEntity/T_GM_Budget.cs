using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///报价单
    ///</summary>
    [SugarTable("T_GM_Budget")]
	[Tenant("oldDb")]
    public partial class T_GM_Budget
    {
           public T_GM_Budget(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GID {get;set;}

           /// <summary>
           /// Desc:报价单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string QuotationNo {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AuditProgress {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClientName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Version {get;set;}

           /// <summary>
           /// Desc:订单状态（modified once，null ，施工-》完工）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BudgetStatus {get;set;}

           /// <summary>
           /// Desc:报价日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OfferDate {get;set;}

           /// <summary>
           /// Desc:报价总额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal OfferMoney {get;set;}

           /// <summary>
           /// Desc:成本总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CostMoney {get;set;}

           /// <summary>
           /// Desc:材料报价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MaterialOffer {get;set;}

           /// <summary>
           /// Desc:人工报价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LaborOffer {get;set;}

           /// <summary>
           /// Desc:材料成本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MaterialCost {get;set;}

           /// <summary>
           /// Desc:人工成本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LaborCost {get;set;}

           /// <summary>
           /// Desc:其他费用报价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OtherFeeOffer {get;set;}

           /// <summary>
           /// Desc:其他费用成本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OtherFeeCost {get;set;}

           /// <summary>
           /// Desc:税率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxRate {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AttachmentPath {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AgentMan {get;set;}

           /// <summary>
           /// Desc:经办日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AgentDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RateMargin {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NetMargin {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IsContract {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Currency {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ExchangeRate {get;set;}

    }
}
