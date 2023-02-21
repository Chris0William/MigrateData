using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///审核人员表
    ///</summary>
    [SugarTable("t_sys_checker")]
	[Tenant("newDb")]
    public partial class t_sys_checker
    {
           public t_sys_checker(){


           }
           /// <summary>
           /// Desc:主键唯一GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:CheckerID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckerID {get;set;}

           /// <summary>
           /// Desc:CheckFlowID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckFlowID {get;set;}

           /// <summary>
           /// Desc:lvl1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? lvl1 {get;set;}

           /// <summary>
           /// Desc:lvl2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? lvl2 {get;set;}

    }
}
