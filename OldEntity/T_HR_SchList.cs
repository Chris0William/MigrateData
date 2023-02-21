using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///考勤类别
    ///</summary>
    [SugarTable("T_HR_SchList")]
	[Tenant("oldDb")]
    public partial class T_HR_SchList
    {
           public T_HR_SchList(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:上午上班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AMClassGoOn {get;set;}

           /// <summary>
           /// Desc:上午上班有效打卡开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ACGST {get;set;}

           /// <summary>
           /// Desc:上午上班有效打卡结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ACGET {get;set;}

           /// <summary>
           /// Desc:上午下班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AMClassOff {get;set;}

           /// <summary>
           /// Desc:上午下班有效打卡开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ACOST {get;set;}

           /// <summary>
           /// Desc:上午下班有效打卡结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ACOET {get;set;}

           /// <summary>
           /// Desc:下午上班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PMClassGoOn {get;set;}

           /// <summary>
           /// Desc:下午上班有效打卡开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PCGST {get;set;}

           /// <summary>
           /// Desc:下午上班有效打卡结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PCGET {get;set;}

           /// <summary>
           /// Desc:下午下班时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PMClassOff {get;set;}

           /// <summary>
           /// Desc:下午下班有效打卡开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PCOST {get;set;}

           /// <summary>
           /// Desc:下午下班有效打卡结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PCOET {get;set;}

           /// <summary>
           /// Desc:2次卡
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Two {get;set;}

           /// <summary>
           /// Desc:4次卡
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? Four {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreaterName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditorName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditeTime {get;set;}

    }
}
