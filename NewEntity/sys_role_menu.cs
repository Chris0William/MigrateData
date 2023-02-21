using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///角色菜单表
    ///</summary>
    [SugarTable("sys_role_menu")]
	[Tenant("newDb")]
    public partial class sys_role_menu
    {
           public sys_role_menu(){


           }
           /// <summary>
           /// Desc:角色Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysRoleId {get;set;}

           /// <summary>
           /// Desc:菜单Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysMenuId {get;set;}

    }
}
