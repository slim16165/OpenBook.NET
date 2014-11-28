﻿using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public class AdditionalDataResult : Dictionary<string, AdditionalDataResult.UserData>
    {
        public class UserData
        {
            public int CopiersLastWeek { get; set; }
            public LastActivityData LastActivity { get; set; }
            public PNLData PNL { get; set; }

            public class LastActivityData : LocalizedResultBase
            {
                public ActivityData Activity { get; set; }
                public string GUID { get; set; }
                public bool IsCurrentUserFlagged { get; set; }
                public bool IsCurrentUserFollowing { get; set; }
                public bool IsCurrentUserLiked { get; set; }
                public bool IsSpam { get; set; }
                public string ItemType { get; set; }
                public Market Market { get; set; }
                public User Owner { get; set; }
                public string PublishDate { get; set; }

                public struct ActivityData
                {
                    public string GUID;
                    public bool IsBuy;
                    public bool IsOrder;
                    public double OpenRate;
                    public int OrderID;
                    public int PositionID;
                    public string Profit;
                    public string Risk;
                    public string TimeStamp;
                }
            }

            public class PNLData
            {
                public double[] Ticks { get; set; }
            }
        }
    }
}