using HohoemaLive.Models.Niconico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HohoemaLive.Interfaces
{
    public interface ICommentFilter
    {
        bool IsHiddenComment(Comment comment);
        string TransformCommentText(string CommentText);
        bool IsIgnoreCommand(string command);
    }
}
