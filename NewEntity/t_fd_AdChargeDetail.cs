using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///预付款每次付款明细（金蝶）
    ///</summary>
    [SugarTable("t_fd_AdChargeDetail")]
	[Tenant("newDb")]
    public partial class t_fd_AdChargeDetail
    {
           public t_fd_AdChargeDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:预付款单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AdvanceChargeNo {get;set;}

           /// <summary>
           /// Desc:上一次总金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LastPay {get;set;}

           /// <summary>
           /// Desc:本次付款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Pay {get;set;}

           /// <summary>
           /// Desc:本次剩余未付金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? AfterPay {get;set;}

           /// <summary>
           /// Desc:关联预付款单主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string referenceId {get;set;}

           /// <summary>
           /// Desc:付款单号码（金蝶）
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
           /// Desc:核算类型项目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IC_Kind {get;set;}

           /// <summary>
           /// Desc:核算项目类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IC_SupplyID {get;set;}

           /// <summary>
           /// Desc:币种代号
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
           /// Nullable:False
           /// </summary>           
           public decimal IC_DiscountAmount {get;set;}

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
