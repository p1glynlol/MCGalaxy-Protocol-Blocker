using System;
using MCGalaxy;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

namespace PluginKickNoP6 {
	
	public class KickNoP6 : Plugin {
		public override string creator { get { return "p1glynlol"; } } //made from aleksb385 KickJini.cs
		public override string MCGalaxy_Version { get { return "1.9.3.5"; } }
		public override string name { get { return "KickNoP6"; } }

		public override void Load(bool startup) {
			OnPlayerConnectEvent.Register(KickClient, Priority.High);
		}
		
		public override void Unload(bool shutdown) {
			OnPlayerConnectEvent.Unregister(KickClient);
		}

		void KickClient(Player p) {
			byte protocol = p.ProtocolVersion;
			if (p.ProtocolVersion != Server.VERSION_0020) {
				p.Leave("Please connect using c0.0.20a_01-c0.0.23a_01 only!.", true);
				p.cancellogin = true;
		    }
		}
    }
}