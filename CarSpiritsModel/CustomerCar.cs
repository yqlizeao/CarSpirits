using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// CustomerCar:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class CustomerCar
	{
		public CustomerCar()
		{}
		#region Model
		private int _���;
		private string _�ͻ����;
		private string _�û���;
		private string _�ͻ�����;
		private string _���ƺ�;
		private string _�ͺ�;
		private string _Ʒ��;
		private string _����;
		private string _��ɫ;
		private string _����;
		private string _����;
		private string _����ά����Ϣ;
		/// <summary>
		/// 
		/// </summary>
		public int ���
		{
			set{ _���=value;}
			get{return _���;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �ͻ����
		{
			set{ _�ͻ����=value;}
			get{return _�ͻ����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �û���
		{
			set{ _�û���=value;}
			get{return _�û���;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �ͻ�����
		{
			set{ _�ͻ�����=value;}
			get{return _�ͻ�����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ���ƺ�
		{
			set{ _���ƺ�=value;}
			get{return _���ƺ�;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �ͺ�
		{
			set{ _�ͺ�=value;}
			get{return _�ͺ�;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ʒ��
		{
			set{ _Ʒ��=value;}
			get{return _Ʒ��;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ����
		{
			set{ _����=value;}
			get{return _����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ��ɫ
		{
			set{ _��ɫ=value;}
			get{return _��ɫ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ����
		{
			set{ _����=value;}
			get{return _����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ����
		{
			set{ _����=value;}
			get{return _����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ����ά����Ϣ
		{
			set{ _����ά����Ϣ=value;}
			get{return _����ά����Ϣ;}
		}
		#endregion Model

	}
}

