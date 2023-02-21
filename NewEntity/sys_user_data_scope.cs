using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///用户数据范围表
    ///</summary>
    [SugarTable("sys_user_data_scope")]
	[Tenant("newDb")]
    public partial class sys_user_data_scope
    {
           public sys_user_data_scope(){


           }
           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysUserId {get;set;}

           /// <summary>
           /// Desc:机构Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysOrgId {get;set;}

    }
}
