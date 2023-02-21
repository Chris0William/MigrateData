using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///成本明细表
    ///</summary>
    [SugarTable("T_RM_CostDetail")]
	[Tenant("newDb")]
    public partial class T_RM_CostDetail
    {
           public T_RM_CostDetail(){


           }
           /// <summary>
           /// Desc:主键自增id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:关联成本表的ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReferenceId {get;set;}

           /// <summary>
           /// Desc:专业分项
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
           /// Desc:人工成本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LaborCost {get;set;}

    }
}
