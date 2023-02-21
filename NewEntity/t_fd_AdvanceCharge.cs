using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_AdvanceCharge")]
	[Tenant("newDb")]
    public partial class t_fd_AdvanceCharge
    {
           public t_fd_AdvanceCharge(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:所属公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string dept {get;set;}

           /// <summary>
           /// Desc:预付款单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AdvanceChargeNO {get;set;}

           /// <summary>
           /// Desc:申请日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ApplyDate {get;set;}

           /// <summary>
           /// Desc:订单类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderType {get;set;}

           /// <summary>
           /// Desc:订单金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ContractAmount {get;set;}

           /// <summary>
           /// Desc:实际结算金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ReallyAmount {get;set;}

           /// <summary>
           /// Desc:申请付款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ApplicationAmount {get;set;}

           /// <summary>
           /// Desc:剩余未付
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SurplusAmount {get;set;}

           /// <summary>
           /// Desc:预计收到发票日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReceiptInvoiceDate {get;set;}

           /// <summary>
           /// Desc:大写金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AmountInWords {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

           /// <summary>
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuditProcess {get;set;}

           /// <summary>
           /// Desc:付款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayType {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:供应商名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierName {get;set;}

           /// <summary>
           /// Desc:是否已入库
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Stored {get;set;}

           /// <summary>
           /// Desc:是否已对账
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Reconciled {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:金蝶已付金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? payed {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
