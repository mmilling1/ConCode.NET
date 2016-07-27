﻿using System.Linq;
using System.Collections.Generic;

namespace ConCode.NET.Core.Domain
{
    public interface ITalkService
    {
        IQueryable<Talk> GetTalks();

        Talk GetTalk(int talkId);

        IEnumerable<TalkType> GetTalkTypes();

        TalkType GetTalkType(int talkTypeId);
    }
}
