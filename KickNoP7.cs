using System;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

namespace MCGalaxy {
	
	public class PluginKickNoP7 : Plugin {
		public override string creator { get { return "p1glynlol"; } } //made from aleksb385 KickJini.cs
		public override string MCGalaxy_Version { get { return "1.9.3.6"; } }
		public override string name { get { return "KickNoP7"; } }

		public override void Load(bool startup) {
			OnPlayerConnectEvent.Register(KickNoP7, Priority.High);
		}
		
		public override void Unload(bool shutdown) {
			OnPlayerConnectEvent.Unregister(KickNoP7);
		}

		void KickNoP7(Player p) {
			byte protocol = p.ProtocolVersion;            
			if (p.ProtocolVersion != Server.VERSION_0030) {
				p.Leave("Please connect using c0.28-c0.30-renew only!.", true);
				p.cancellogin = true; 
		    }
		}
    }
}