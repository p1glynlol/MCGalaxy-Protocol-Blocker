using System;
using MCGalaxy;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

public class KickNoP3 : Plugin {
		public override string creator { get { return "p1glynlol"; } } //forked from Alex_ KickJini.cs
		public override string MCGalaxy_Version { get { return "1.9.4.3"; } }
		public override string name { get { return "KickNoP3"; } }

		public override void Load(bool startup) {
			OnPlayerFinishConnectingEvent.Register(KickClient, Priority.High);
		}
		
		public override void Unload(bool shutdown) {
			OnPlayerFinishConnectingEvent.Unregister(KickClient);
		}

		void KickClient(Player p) {
			byte protocol = p.Session.ProtocolVersion;
			if (p.Session.ProtocolVersion != Server.VERSION_0016) {
				p.Leave("Please connect using c0.0.16 only!.", true);
				p.cancelconnecting = true;
		    }
		}
}