using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// CustomerCar:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CustomerCar
	{
		public CustomerCar()
		{}
		#region Model
		private int _编号;
		private string _客户编号;
		private string _用户名;
		private string _客户姓名;
		private string _车牌号;
		private string _油号;
		private string _品牌;
		private string _车型;
		private string _颜色;
		private string _油量;
		private string _里数;
		private string _车身维护信息;
		/// <summary>
		/// 
		/// </summary>
		public int 编号
		{
			set{ _编号=value;}
			get{return _编号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 客户编号
		{
			set{ _客户编号=value;}
			get{return _客户编号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 用户名
		{
			set{ _用户名=value;}
			get{return _用户名;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 客户姓名
		{
			set{ _客户姓名=value;}
			get{return _客户姓名;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 车牌号
		{
			set{ _车牌号=value;}
			get{return _车牌号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 油号
		{
			set{ _油号=value;}
			get{return _油号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 品牌
		{
			set{ _品牌=value;}
			get{return _品牌;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 车型
		{
			set{ _车型=value;}
			get{return _车型;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 颜色
		{
			set{ _颜色=value;}
			get{return _颜色;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 油量
		{
			set{ _油量=value;}
			get{return _油量;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 里数
		{
			set{ _里数=value;}
			get{return _里数;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 车身维护信息
		{
			set{ _车身维护信息=value;}
			get{return _车身维护信息;}
		}
		#endregion Model

	}
}

