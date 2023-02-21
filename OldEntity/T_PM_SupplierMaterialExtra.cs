using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PM_SupplierMaterialExtra")]
	[Tenant("oldDb")]
    public partial class T_PM_SupplierMaterialExtra
    {
           public T_PM_SupplierMaterialExtra(){


           }
           /// <summary>
           /// Desc:商家订单材料的ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string SupplierMaterialNo {get;set;}

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
           /// Desc:申请数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ApplyNumber {get;set;}

           /// <summary>
           /// Desc:实际配置数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ActualNumber {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

           /// <summary>
           /// Desc:商家订单配置的编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierOrderID {get;set;}

           /// <summary>
           /// Desc:项目材料申请单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ApplyMaterialID {get;set;}

    }
}
