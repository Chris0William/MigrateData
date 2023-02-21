using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///记录单号的类型字典
    ///</summary>
    [SugarTable("t_sys_TypeNo")]
	[Tenant("newDb")]
    public partial class t_sys_TypeNo
    {
           public t_sys_TypeNo(){


           }
           /// <summary>
           /// Desc:单号ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string TypeID {get;set;}

           /// <summary>
           /// Desc:单号名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TypeName {get;set;}

           /// <summary>
           /// Desc:开关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Switch {get;set;}

    }
}
