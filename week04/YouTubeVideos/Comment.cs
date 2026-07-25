using System;
using System.Collections.Generic;

public class Comment
{
    public string _commentText;
    public string _commenter;

    public Comment(string commenterName, string commentText)
    {
        _commenter = commenterName;
        _commentText = commentText;
    }
}
