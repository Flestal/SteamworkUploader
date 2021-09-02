using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamworks;

namespace SteamAPI
{
    class SteamAPI
    {
        public void Init()
        {
            try
            {
                SteamClient.Init(1256670U, true);
                SteamId steamId = SteamClient.SteamId;
                this.LogError(steamId);
            }
            catch (Exception message)
            {
                this.LogError(message);
            }
        }
        public void Update()
        {
            try
            {
                SteamClient.RunCallbacks();
            }
            catch (Exception message)
            {
                this.LogError(message);
            }
        }
        public void ShutDown()
        {
            try
            {
                SteamClient.Shutdown();
            }
            catch (Exception message)
            {
                this.LogError(message);
            }
        }
        public void LogError(object message)
        {
        }
    }
}
