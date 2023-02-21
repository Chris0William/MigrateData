using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///审核操作记录
    ///</summary>
    [SugarTable("t_sys_Operation_list")]
	[Tenant("newDb")]
    public partial class t_sys_Operation_list
    {
           public t_sys_Operation_list(){


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
           /// Nullable:False
           /// </summary>           
           public string Check_funcID {get;set;}

           /// <summary>
           /// Desc:审核流程ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Check_flowID {get;set;}

           /// <summary>
           /// Desc:审核状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int state {get;set;}

           /// <summary>
           /// Desc:CreateTime
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:Creator
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:菜单URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:步骤
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? step {get;set;}

    }
}
