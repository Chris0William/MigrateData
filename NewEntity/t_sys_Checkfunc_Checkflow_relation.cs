using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///审核功能—审核流程关系表
    ///</summary>
    [SugarTable("t_sys_Checkfunc_Checkflow_relation")]
	[Tenant("newDb")]
    public partial class t_sys_Checkfunc_Checkflow_relation
    {
           public t_sys_Checkfunc_Checkflow_relation(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:审核功能ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Check_funcID {get;set;}

           /// <summary>
           /// Desc:审核流程ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Check_flowID {get;set;}

    }
}
