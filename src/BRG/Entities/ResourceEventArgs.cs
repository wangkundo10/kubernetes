namespace BRG.Entities
{
	using System;

	public class ResourceEventArgs : EventArgs
	{
		public IResourceInfo Torrent { get; private set; }

		/// <summary>
		/// ���� <see cref="TorrentEventArgs" />  ����ʵ��(TorrentEventArgs)
		/// </summary>
		/// <param name="torrent"></param>
		public ResourceEventArgs(IResourceInfo torrent)
		{
			Torrent = torrent;
		}

	}
}