using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///研发立项信息
    ///</summary>
    [SugarTable("t_xm_Projectinfo")]
	[Tenant("newDb")]
    public partial class t_xm_Projectinfo
    {
           public t_xm_Projectinfo(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Id {get;set;}

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
           /// Desc:创建人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CreatedUserId {get;set;}

           /// <summary>
           /// Desc:创建时间 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreatedTime {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdatedTime {get;set;}

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
           /// Desc:审核流程
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CheckProcess {get;set;}

           /// <summary>
           /// Desc:项目地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectAdress {get;set;}

           /// <summary>
           /// Desc:备用字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AlternateField3 {get;set;}

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
