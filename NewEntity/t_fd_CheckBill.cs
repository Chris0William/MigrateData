using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_CheckBill")]
	[Tenant("newDb")]
    public partial class t_fd_CheckBill
    {
           public t_fd_CheckBill(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:供应商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:对账单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BillNo {get;set;}

           /// <summary>
           /// Desc:对账时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BillTime {get;set;}

           /// <summary>
           /// Desc:对账月份
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BillMonth {get;set;}

           /// <summary>
           /// Desc:对账状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BillState {get;set;}

           /// <summary>
           /// Desc:对账金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:税率
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:凭证是否已录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string isVoucher {get;set;}

           /// <summary>
           /// Desc:发票是否已录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string isInvoice {get;set;}

           /// <summary>
           /// Desc:币种
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
           /// Desc:付款单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnotherState {get;set;}

           /// <summary>
           /// Desc:订单类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderType {get;set;}

           /// <summary>
           /// Desc:是否二次付款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Secondary {get;set;}

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
