using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///对账物料明细表
    ///</summary>
    [SugarTable("t_fd_DetailChecBM")]
	[Tenant("newDb")]
    public partial class t_fd_DetailChecBM
    {
           public t_fd_DetailChecBM(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarehouseID {get;set;}

           /// <summary>
           /// Desc:关联t_gm_dm表的主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MUID {get;set;}

           /// <summary>
           /// Desc:物料编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaterialID {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Num {get;set;}

           /// <summary>
           /// Desc:未税订单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OrderPriceNoTax {get;set;}

           /// <summary>
           /// Desc:含税订单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OrderPriceTax {get;set;}

           /// <summary>
           /// Desc:未税结算价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealPriceNoTax {get;set;}

           /// <summary>
           /// Desc:含税结算价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RealPriceTax {get;set;}

           /// <summary>
           /// Desc:前后相差价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Difference {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string dscription {get;set;}

           /// <summary>
           /// Desc:关联对账单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefreenceId {get;set;}

           /// <summary>
           /// Desc:税率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tax {get;set;}

           /// <summary>
           /// Desc:收货单主键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string receiveid {get;set;}

           /// <summary>
           /// Desc:采购单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurchaseMNo {get;set;}

    }
}
