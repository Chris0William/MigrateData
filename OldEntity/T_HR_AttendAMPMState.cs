using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_HR_AttendAMPMState")]
	[Tenant("oldDb")]
    public partial class T_HR_AttendAMPMState
    {
           public T_HR_AttendAMPMState(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AMorPMState {get;set;}

           /// <summary>
           /// Desc:判断上午或下午状态正常或异常
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StateName {get;set;}

           /// <summary>
           /// Desc:状态描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StateDescription {get;set;}

    }
}
