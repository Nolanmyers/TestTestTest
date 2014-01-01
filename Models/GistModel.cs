using System;
using System.Collections.Generic;

namespace GitHubSharp.Models
{
    [Serializable]
    public class GistModel
    {
        public string Url { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public bool Public { get; set; }
        public BasicUserModel User { get; set; }
        public Dictionary<string, GistFileModel> Files { get; set; }
        public ulong Comments { get; set; }
        public string CommentsUrl { get; set; }
        public string HtmlUrl { get; set; }
        public string GitPullUrl { get; set; }
        public string GitPushUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public List<ForkModel> Forks { get; set; }
        public List<HistoryModel> History { get; set; }
    }

    [Serializable]
    public class GistFileModel
    {
        public ulong Size { get; set; }
        public string Filename { get; set; }
        public string RawUrl { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
    }

    [Serializable]
    public class GistCommentModel
    {
        public ulong Id { get; set; }
        public string Url { get; set; }
        public string Body { get; set; }
        public BasicUserModel User { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    [Serializable]
    public class GistEditModel
    {
        public string Description { get; set; }
        public Dictionary<string, File> Files { get; set; }
    
        [Serializable]
        public class File
        {
            public string Filename { get; set; }
            public string Content { get; set; }
        }
    }

    [Serializable]
    public class GistCreateModel
    {
        public string Description { get; set; }
        public bool Public { get; set; }
        public Dictionary<string, File> Files { get; set; }

        [Serializable]
        public class File
        {
            public string Content { get; set; }
        }
    }
}
