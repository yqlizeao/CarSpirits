using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// OwnCar:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
		/// ���ƺ�
		/// </summary>
		public string PlateNumber
		{
			set{ _platenumber=value;}
			get{return _platenumber;}
		}
		/// <summary>
		/// �ͺ�
		/// </summary>
		public string GasOline
		{
			set{ _gasoline=value;}
			get{return _gasoline;}
		}
		/// <summary>
		/// �������
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
		/// ����
		/// </summary>
		public string OilMass
		{
			set{ _oilmass=value;}
			get{return _oilmass;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Mileage
		{
			set{ _mileage=value;}
			get{return _mileage;}
		}
		/// <summary>
		/// ���������
		/// </summary>
		public string CarBreakDown
		{
			set{ _carbreakdown=value;}
			get{return _carbreakdown;}
		}
		#endregion Model

	}
}

