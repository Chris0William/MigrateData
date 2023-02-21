using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///材料申请表
    ///</summary>
    [SugarTable("T_PM_ApplyMaterial")]
	[Tenant("oldDb")]
    public partial class T_PM_ApplyMaterial
    {
           public T_PM_ApplyMaterial(){


           }
           /// <summary>
           /// Desc:申请ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ApplyMaterialNo {get;set;}

           /// <summary>
           /// Desc:物资编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaterialNo {get;set;}

           /// <summary>
           /// Desc:物资名称
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
           /// Desc:仓库
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Warehouse {get;set;}

           /// <summary>
           /// Desc:申请数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ApplyNumber {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:物资申请单的编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyID {get;set;}

    }
}
