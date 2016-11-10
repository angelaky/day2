using System;

namespace JSONSerialization
{
    public class Game
    {
        public Game(string provider, string providerGameUrl, string gameUrl)
        {
            this.Id = Guid.NewGuid();
            this.Provider = provider;
            this.ProviderGameUrl = providerGameUrl;
            this.GameUrl = gameUrl;
        }

        public Guid Id { get; set; }

        public GameInfo Gameinfo { get; set; }

        public string Provider { get; set; }

        public string ProviderGameUrl { get; set; }

        public string GameUrl { get; set; }
    }
}
