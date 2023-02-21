using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///物料库存表
    ///</summary>
    [SugarTable("t_xm_MaterialStock")]
	[Tenant("newDb")]
    public partial class t_xm_MaterialStock
    {
           public t_xm_MaterialStock(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:物料编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MaterialID {get;set;}

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarehouseID {get;set;}

           /// <summary>
           /// Desc:当前数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CurAmount {get;set;}

           /// <summary>
           /// Desc:最小库存数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MinAmount {get;set;}

           /// <summary>
           /// Desc:最大库存数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MaxAmount {get;set;}

           /// <summary>
           /// Desc:虚拟数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? VirtualAmount {get;set;}

           /// <summary>
           /// Desc:扩展字段（暂时未想到如何使用，备用，感觉以后一定有用）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? PurchaseAmount {get;set;}

           /// <summary>
           /// Desc:价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? isDeleted {get;set;}

    }
}
