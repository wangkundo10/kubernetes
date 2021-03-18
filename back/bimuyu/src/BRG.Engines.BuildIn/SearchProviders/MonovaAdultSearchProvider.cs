namespace BRG.Engines.BuildIn.SearchProviders
{
	using System.ComponentModel.Composition;
	using BRG.Service;

	[Export(typeof(IResourceProvider))]
	class MonovaAdultSearchProvider : MonovaSearchProvider
	{
		public MonovaAdultSearchProvider() : base(new BuildinServerInfo("Monova[A]", Properties.Resources.favicon_monova, "�ṩ�� monova[adult] ������֧��"))

		{
			SiteID = SiteData.SiteID_MonovaAdult;
		}

		/// <summary>
		/// ����
		/// </summary>
		public override void Connect()
		{
			base.Connect();

			DefaultHost = "adult.monova.org";
			ReferUrlPage = $"https://{Host}/";
		}

		/// <summary>
		/// ��ָ���汾����
		/// </summary>
		/// <param name="oldVersion"></param>
		public override void UpgradeFrom(string oldVersion, string currentVersion)
		{
			base.UpgradeFrom(oldVersion, currentVersion);

			Disabled = true;
		}
	}
}