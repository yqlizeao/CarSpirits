using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// OwnCar:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OwnCar
	{
		public OwnCar()
		{}
		#region Model
		private int _id;
		private string _customerid;
		private string _platenumber;
		private string _gasoline;
		private string _brand;
		private string _style;
		private string _color;
		private string _oilmass;
		private string _mileage;
		private string _carbreakdown;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string PlateNumber
		{
			set{ _platenumber=value;}
			get{return _platenumber;}
		}
		/// <summary>
		/// 油号
		/// </summary>
		public string GasOline
		{
			set{ _gasoline=value;}
			get{return _gasoline;}
		}
		/// <summary>
		/// 车辆编号
		/// </summary>
		public string Brand
		{
			set{ _brand=value;}
			get{return _brand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Style
		{
			set{ _style=value;}
			get{return _style;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 油量
		/// </summary>
		public string OilMass
		{
			set{ _oilmass=value;}
			get{return _oilmass;}
		}
		/// <summary>
		/// 里数
		/// </summary>
		public string Mileage
		{
			set{ _mileage=value;}
			get{return _mileage;}
		}
		/// <summary>
		/// 汽车损坏与否
		/// </summary>
		public string CarBreakDown
		{
			set{ _carbreakdown=value;}
			get{return _carbreakdown;}
		}
		#endregion Model

	}
}

