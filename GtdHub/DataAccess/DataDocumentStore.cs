using System;
using Raven.Client;
using Raven.Client.Embedded;

namespace GtdHubApp.DataAccess
{
    public class DataDocumentStore
    {
        private static IDocumentStore _instance;
        public static IDocumentStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new InvalidOperationException("IDocument store has not been initialized");
                }
                return _instance;
            }
        }
        public static IDocumentStore Initialize()
        {
            _instance = new EmbeddableDocumentStore
            {
                DataDirectory = "GTDHubData2"
            };
            _instance.Conventions.IdentityPartsSeparator = "-";
            _instance.Initialize();
            _instance.DisableAggressiveCaching();
            return _instance;
        }
    }
}
