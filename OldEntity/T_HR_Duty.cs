using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///职务表
    ///</summary>
    [SugarTable("T_HR_Duty")]
	[Tenant("oldDb")]
    public partial class T_HR_Duty
    {
           public T_HR_Duty(){


           }
           /// <summary>
           /// Desc:职务ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DutyID {get;set;}

           /// <summary>
           /// Desc:职务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DutyName {get;set;}

           /// <summary>
           /// Desc:职位类别ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PositionCategoryID {get;set;}

           /// <summary>
           /// Desc:层级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? DutyLevel {get;set;}

           /// <summary>
           /// Desc:职级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DutyRank {get;set;}

           /// <summary>
           /// Desc:职能序列
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FunctionList {get;set;}

           /// <summary>
           /// Desc:职务类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DutyType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

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
           public DateTime? EditorTime {get;set;}

    }
}
