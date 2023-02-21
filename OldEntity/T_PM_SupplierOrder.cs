using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_PM_SupplierOrder")]
	[Tenant("oldDb")]
    public partial class T_PM_SupplierOrder
    {
           public T_PM_SupplierOrder(){


           }
           /// <summary>
           /// Desc:商家订单编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string SupplierOrderNo {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:订单配置人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MakeMan {get;set;}

           /// <summary>
           /// Desc:订单配置日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? MakeDate {get;set;}

           /// <summary>
           /// Desc:审核人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckMan {get;set;}

           /// <summary>
           /// Desc:审核日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CheckDate {get;set;}

           /// <summary>
           /// Desc:审核状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckStatus {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extra {get;set;}

    }
}
