using System;
using MCGalaxy;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

namespace PluginKickNoP5 {
	
	public class KickNoP5 : Plugin {
		public override string creator { get { return "p1glynlol"; } } //made from aleksb385 KickJini.cs
		public override string MCGalaxy_Version { get { return "1.9.3.5"; } }
		public override string name { get { return "KickNoP5"; } }

		public override void Load(bool startup) {
			OnPlayerConnectEvent.Register(KickClient, Priority.High);
		}
		
		public override void Unload(bool shutdown) {
			OnPlayerConnectEvent.Unregister(KickClient);
		}

		void KickClient(Player p) {
			byte protocol = p.ProtocolVersion;
			if (p.ProtocolVersion != Server.VERSION_0019) {
				p.Leave("Please connect using c0.0.19 only!.", true);
				p.cancellogin = true;
		    }
		}
    }
}