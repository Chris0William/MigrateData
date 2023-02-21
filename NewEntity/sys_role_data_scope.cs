using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///角色数据范围表
    ///</summary>
    [SugarTable("sys_role_data_scope")]
	[Tenant("newDb")]
    public partial class sys_role_data_scope
    {
           public sys_role_data_scope(){


           }
           /// <summary>
           /// Desc:角色Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysRoleId {get;set;}

           /// <summary>
           /// Desc:机构Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysOrgId {get;set;}

    }
}
