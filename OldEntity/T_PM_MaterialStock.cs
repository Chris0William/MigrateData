using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PM_MaterialStock")]
	[Tenant("oldDb")]
    public partial class T_PM_MaterialStock
    {
           public T_PM_MaterialStock(){


           }
           /// <summary>
           /// Desc:材料在仓库中的ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MaterialStockID {get;set;}

           /// <summary>
           /// Desc:材料编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaterialID {get;set;}

           /// <summary>
           /// Desc:材料名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaterialName {get;set;}

           /// <summary>
           /// Desc:型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Size {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Unit {get;set;}

           /// <summary>
           /// Desc:预算价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Price {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:库存数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? Number {get;set;}

           /// <summary>
           /// Desc:仓库地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Warehouse {get;set;}

    }
}
