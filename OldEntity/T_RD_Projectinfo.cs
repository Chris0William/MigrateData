using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.OldEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("T_RD_Projectinfo")]
	[Tenant("oldDb")]
    public partial class T_RD_Projectinfo
    {
           public T_RD_Projectinfo(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GID {get;set;}

           /// <summary>
           /// Desc:公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ProjectNo {get;set;}

           /// <summary>
           /// Desc:负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Responsible {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? StartTime {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EndTime {get;set;}

           /// <summary>
           /// Desc:人工费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Artificial {get;set;}

           /// <summary>
           /// Desc:直接投入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Directinput {get;set;}

           /// <summary>
           /// Desc:售销金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SalesAmount {get;set;}

           /// <summary>
           /// Desc:其他金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OtherAmounts {get;set;}

           /// <summary>
           /// Desc:合计金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TotalAmount {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUser {get;set;}

           /// <summary>
           /// Desc:创建时间 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Createtime {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditUser {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditTime {get;set;}

           /// <summary>
           /// Desc:仓库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarehouseID {get;set;}

           /// <summary>
           /// Desc:立项日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProjectDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AlternateField1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AlternateField2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AlternateField3 {get;set;}

    }
}
