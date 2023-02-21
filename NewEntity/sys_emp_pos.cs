using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///员工职位表
    ///</summary>
    [SugarTable("sys_emp_pos")]
	[Tenant("newDb")]
    public partial class sys_emp_pos
    {
           public sys_emp_pos(){


           }
           /// <summary>
           /// Desc:员工Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysEmpId {get;set;}

           /// <summary>
           /// Desc:职位Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SysPosId {get;set;}

    }
}
