using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///项目报价单
    ///</summary>
    [SugarTable("t_xm_budget")]
	[Tenant("newDb")]
    public partial class t_xm_budget
    {
           public t_xm_budget(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

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
           /// Desc:所属公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string company {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClientName {get;set;}

           /// <summary>
           /// Desc:版本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? version {get;set;}

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
           public string description {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AttachmentPath {get;set;}

           /// <summary>
           /// Desc:毛利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RateMargin {get;set;}

           /// <summary>
           /// Desc:净利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NetMargin {get;set;}

           /// <summary>
           /// Desc:是否有合同
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsContract {get;set;}

           /// <summary>
           /// Desc:币别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Currency {get;set;}

           /// <summary>
           /// Desc:汇率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ExchangeRate {get;set;}

           /// <summary>
           /// Desc:经办时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
