using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_RM_CostDetail")]
	[Tenant("oldDb")]
    public partial class T_RM_CostDetail
    {
           public T_RM_CostDetail(){


           }
           /// <summary>
           /// Desc:GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:成本表的ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReferenceId {get;set;}

           /// <summary>
           /// Desc:专业/分项
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Item {get;set;}

           /// <summary>
           /// Desc:材料成本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MaterialCost {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LaborCost {get;set;}

    }
}
