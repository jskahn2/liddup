using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Liddup.Models;

namespace Liddup
{
    class SongManager
    {
        /*
        public delegate void ReloadDataDelegate();

        private static readonly Database m_database;

        static SongManager()
        {
            m_database = Manager.SharedInstance.GetDatabase("liddupsongs");
        }

        public static Song GetSong(string id)
        {
            var doc = m_database.GetDocument(id);
            var props = doc.UserProperties;
            var song = new Song
            {
                Id = id,
                Title = props["title"].ToString(),
                Description = props["description"].ToString()
            };

            return song;
        }

        public static ObservableCollection<Song> GetSongs()
        {
            var query = m_database.CreateAllDocumentsQuery();
            var results = query.Run();
            var songs = new ObservableCollection<Song>();

            foreach (var row in results)
            {
                var song = new Song
                {
                    Id = row.DocumentId,
                    Title = row.Document.UserProperties["title"].ToString(),
                    Description = row.Document.UserProperties["description"].ToString()
                };
                songs.Add(song);
            }

            return songs;
        }

        public static string SaveSong(Song song)
        {
            Document doc;

            if (song.Id == null)
            {
                doc = m_database.CreateDocument();
                doc.PutProperties(song.ToDictionary());
                song.Id = doc.Id;
            }
            else
            {
                doc = m_database.GetDocument(song.Id);
                try
                {
                    doc.Update(newRevision =>
                    {
                        var props = newRevision.Properties;
                        props["title"] = song.Title;
                        props["description"] = song.Description;
                        return true;
                    });
                }
                catch (Exception ex)
                {
                }
            }
            return doc.Id;
        }

        public static void DeleteSong(Song song)
        {
            var doc = m_database.GetExistingDocument(song.Id);
            doc?.Delete();
        }

        public static void StartReplications(ReloadDataDelegate refresher)
        {
            var pull = m_database.CreatePullReplication(CreateSyncUri());
            var push = m_database.CreatePushReplication(CreateSyncUri());

            pull.Continuous = true;
            push.Start();

            pull.Changed += (sender, e) =>
            {
                refresher?.Invoke();
            };

            push.Changed += (sender, e) =>
            {
                refresher?.Invoke();
            };
        }

        private static Uri CreateSyncUri()
        {
            Uri syncUri = null;

            const string scheme = "http";
            const string host = "172.16.29.132";
            const string dbName = "liddupsongs";
            const int port = 4984;

            try
            {
                var uriBuilder = new UriBuilder(scheme, host, port, dbName);
                syncUri = uriBuilder.Uri;
            }
            catch
            {

            }

            return syncUri;
        }
    */
    }
}
