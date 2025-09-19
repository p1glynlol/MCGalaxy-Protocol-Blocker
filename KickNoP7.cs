using System;
using MCGalaxy;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

public class KickNoP7 : Plugin {
		public override string creator { get { return "p1glynlol"; } } //forked from Alex_ KickJini.cs
		public override string MCGalaxy_Version { get { return "1.9.4.3"; } }
		public override string name { get { return "KickNoP7"; } }

		public override void Load(bool startup) {
			OnPlayerFinishConnectingEvent.Register(KickClient, Priority.High);
		}
		
		public override void Unload(bool shutdown) {
			OnPlayerFinishConnectingEvent.Unregister(KickClient);
		}

		void KickClient(Player p) {
			byte protocol = p.Session.ProtocolVersion;
			if (p.Session.ProtocolVersion != Server.VERSION_0030) {
				p.Leave("Please connect using c0.28-c0.30-renew only!.", true);
				p.cancelconnecting = true;
		    }
		}
}