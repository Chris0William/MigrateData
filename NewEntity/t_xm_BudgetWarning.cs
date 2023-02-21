using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///成本预警表
    ///</summary>
    [SugarTable("t_xm_BudgetWarning")]
	[Tenant("newDb")]
    public partial class t_xm_BudgetWarning
    {
           public t_xm_BudgetWarning(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

           /// <summary>
           /// Desc:ProjectNo
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:级别1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LV1 {get;set;}

           /// <summary>
           /// Desc:级别2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LV2 {get;set;}

           /// <summary>
           /// Desc:级别3
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LV3 {get;set;}

           /// <summary>
           /// Desc:预警开关
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool On_Off {get;set;}

           /// <summary>
           /// Desc:达到级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReachLV {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreatedUserName {get;set;}

           /// <summary>
           /// Desc:修改者Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UpdatedUserId {get;set;}

           /// <summary>
           /// Desc:修改者名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UpdatedUserName {get;set;}

           /// <summary>
           /// Desc:软删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDeleted {get;set;}

    }
}
