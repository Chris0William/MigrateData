using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///记录单号的类型
    ///</summary>
    [SugarTable("T_GM_TypeNo")]
	[Tenant("oldDb")]
    public partial class T_GM_TypeNo
    {
           public T_GM_TypeNo(){


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
