using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///每小时工资
    ///</summary>
    [SugarTable("T_HR_SalaryPerHour")]
	[Tenant("oldDb")]
    public partial class T_HR_SalaryPerHour
    {
           public T_HR_SalaryPerHour(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:单位时间工资，直接员工为小时，间接员工为天
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SalaryPerTime {get;set;}

           /// <summary>
           /// Desc:员工类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string StaffStype {get;set;}

           /// <summary>
           /// Desc:是否生效
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsValid {get;set;}

           /// <summary>
           /// Desc:生效时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ValidTime {get;set;}

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
           public DateTime? EditeTime {get;set;}

    }
}
