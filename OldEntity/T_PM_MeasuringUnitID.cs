using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///专门记录单位的表
    ///</summary>
    [SugarTable("T_PM_MeasuringUnitID")]
	[Tenant("oldDb")]
    public partial class T_PM_MeasuringUnitID
    {
           public T_PM_MeasuringUnitID(){


           }
           /// <summary>
           /// Desc:计量单位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public Guid MeasuringUnitID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MeasuringUnit {get;set;}

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
