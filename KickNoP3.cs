using System;
using MCGalaxy.Events;
using MCGalaxy.Events.PlayerEvents;

namespace MCGalaxy {
	
	public class PluginKickNoP3 : Plugin {
		public override string creator { get { return "p1glynlol"; } } //made from aleksb385 KickJini.cs
		public override string MCGalaxy_Version { get { return "1.9.3.6"; } }
		public override string name { get { return "KickNoP3"; } }

		public override void Load(bool startup) {
			OnPlayerConnectEvent.Register(KickNoP3, Priority.High);
		}
		
		public override void Unload(bool shutdown) {
			OnPlayerConnectEvent.Unregister(KickNoP3);
		}

		void KickNoP3(Player p) {
			byte protocol = p.ProtocolVersion;            
			if (p.ProtocolVersion != Server.VERSION_0017) {
				p.Leave("Please connect using c0.0.16 only!.", true);
				p.cancellogin = true; 
		    }
		}
    }
}