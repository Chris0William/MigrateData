using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///专门记录单位的表
    ///</summary>
    [SugarTable("T_GM_MeasuringUnit")]
	[Tenant("oldDb")]
    public partial class T_GM_MeasuringUnit
    {
           public T_GM_MeasuringUnit(){


           }
           /// <summary>
           /// Desc:计量单位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MeasuringUnitID {get;set;}

           /// <summary>
           /// Desc:单位名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MeasuringUnitName {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Descripition {get;set;}

           /// <summary>
           /// Desc:创建者
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedBy {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

    }
}
