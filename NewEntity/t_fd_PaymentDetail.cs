using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_PaymentDetail")]
	[Tenant("newDb")]
    public partial class t_fd_PaymentDetail
    {
           public t_fd_PaymentDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:总金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal amount {get;set;}

           /// <summary>
           /// Desc:付款金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal payment {get;set;}

           /// <summary>
           /// Desc:剩余未付金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Unpaid {get;set;}

           /// <summary>
           /// Desc:付款单号码(金蝶)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IC_NUMBER {get;set;}

           /// <summary>
           /// Desc:付款单日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? IC_DATE {get;set;}

           /// <summary>
           /// Desc:支付日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? IC_FinanceDate {get;set;}

           /// <summary>
           /// Desc:核算项目类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IC_Kind {get;set;}

           /// <summary>
           /// Desc:核算项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IC_SupplyID {get;set;}

           /// <summary>
           /// Desc:币别代号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IC_Currency {get;set;}

           /// <summary>
           /// Desc:结算实付金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? IC_Amount {get;set;}

           /// <summary>
           /// Desc:结算折扣金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? IC_TaxAmount {get;set;}

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
