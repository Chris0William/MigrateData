using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///用户角色表
    ///</summary>
    [SugarTable("sys_user_role")]
	[Tenant("newDb")]
    public partial class sys_user_role
    {
           public sys_user_role(){


           }
           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysUserId {get;set;}

           /// <summary>
           /// Desc:角色Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysRoleId {get;set;}

    }
}
