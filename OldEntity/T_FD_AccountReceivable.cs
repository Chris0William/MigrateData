using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_FD_AccountReceivable")]
	[Tenant("oldDb")]
    public partial class T_FD_AccountReceivable
    {
           public T_FD_AccountReceivable(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'项目名称'
           /// Nullable:False
           /// </summary>           
           public string ProjectID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:N'订单号（中标的报价单）'
           /// Nullable:True
           /// </summary>           
           public string BudgetID {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CustomerName {get;set;}

           /// <summary>
           /// Desc:完工进度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompletionPercent {get;set;}

           /// <summary>
           /// Desc:是否开发票
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool InvoiceOrnot {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceNum {get;set;}

           /// <summary>
           /// Desc:发票类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceType {get;set;}

           /// <summary>
           /// Desc:发票金额（应收金额）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal InvoiceAmount {get;set;}

           /// <summary>
           /// Desc:订单总金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal BudgetSum {get;set;}

           /// <summary>
           /// Desc:已收到金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal HaveReceive {get;set;}

           /// <summary>
           /// Desc:剩余项目款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RestAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// Desc:收款状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentState {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnnetPath {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealReceiveAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Actualreceivables {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Paymentype {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Paymentmethod {get;set;}

    }
}
