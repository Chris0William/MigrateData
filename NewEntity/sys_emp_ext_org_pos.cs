using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///员工附属机构职位表
    ///</summary>
    [SugarTable("sys_emp_ext_org_pos")]
	[Tenant("newDb")]
    public partial class sys_emp_ext_org_pos
    {
           public sys_emp_ext_org_pos(){


           }
           /// <summary>
           /// Desc:员工Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysEmpId {get;set;}

           /// <summary>
           /// Desc:机构Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysOrgId {get;set;}

           /// <summary>
           /// Desc:职位Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysPosId {get;set;}

    }
}
