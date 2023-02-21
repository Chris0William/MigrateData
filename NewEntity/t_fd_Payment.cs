using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///付款单表
    ///</summary>
    [SugarTable("t_fd_Payment")]
	[Tenant("newDb")]
    public partial class t_fd_Payment
    {
           public t_fd_Payment(){


           }
           /// <summary>
           /// Desc:审核ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:付款单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FKDNumber {get;set;}

           /// <summary>
           /// Desc:订单类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderType {get;set;}

           /// <summary>
           /// Desc:付款日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PayDate {get;set;}

           /// <summary>
           /// Desc:付款类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayType {get;set;}

           /// <summary>
           /// Desc:申请公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProcess {get;set;}

           /// <summary>
           /// Desc:实际结算金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealityPay {get;set;}

           /// <summary>
           /// Desc:已付
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? PaidPay {get;set;}

           /// <summary>
           /// Desc:申请付款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ApplyPay {get;set;}

           /// <summary>
           /// Desc:合同金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ContractAmount {get;set;}

           /// <summary>
           /// Desc:大写金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyUpper {get;set;}

           /// <summary>
           /// Desc:发票种类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceType {get;set;}

           /// <summary>
           /// Desc:发票情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceCase {get;set;}

           /// <summary>
           /// Desc:发票号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceNumber {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyDate {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:所有审核金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string permitAmountString {get;set;}

           /// <summary>
           /// Desc:最终审核金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? permitAmount {get;set;}

           /// <summary>
           /// Desc:此单剩余未付金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? thisRestAmount {get;set;}

           /// <summary>
           /// Desc:支付状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayStatus {get;set;}

           /// <summary>
           /// Desc:对账单金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CheckBillAmount {get;set;}

           /// <summary>
           /// Desc:预付款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? AdvanceChargeAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? KingPay {get;set;}

           /// <summary>
           /// Desc:创建时间
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
           /// Desc:创建者Id
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
           /// Desc:软删除标记
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
