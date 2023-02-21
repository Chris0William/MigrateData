using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_AccountReceivable")]
	[Tenant("newDb")]
    public partial class t_fd_AccountReceivable
    {
           public t_fd_AccountReceivable(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:客户订单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerOrder {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:True
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
           /// Desc:发票号码
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
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? InvoiceAmount {get;set;}

           /// <summary>
           /// Desc:订单总金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BudgetSum {get;set;}

           /// <summary>
           /// Desc:已收到金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? HaveReceive {get;set;}

           /// <summary>
           /// Desc:剩余项目款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RestAmount {get;set;}

           /// <summary>
           /// Desc:收款状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentState {get;set;}

           /// <summary>
           /// Desc:附件路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnnetPath {get;set;}

           /// <summary>
           /// Desc:实际应收金额
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
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string description {get;set;}

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

           /// <summary>
           /// Desc:收款类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Paymentype {get;set;}

           /// <summary>
           /// Desc:收款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Paymentmethod {get;set;}

    }
}
