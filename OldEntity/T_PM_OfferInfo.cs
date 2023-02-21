using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PM_OfferInfo")]
	[Tenant("oldDb")]
    public partial class T_PM_OfferInfo
    {
           public T_PM_OfferInfo(){


           }
           /// <summary>
           /// Desc:报价单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OfferID {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:客户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ClientName {get;set;}

           /// <summary>
           /// Desc:报价日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OfferDate {get;set;}

           /// <summary>
           /// Desc:报价总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OfferMoney {get;set;}

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
           /// Desc:成本总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CostMoney {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:报价单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OfferStatus {get;set;}

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

    }
}
