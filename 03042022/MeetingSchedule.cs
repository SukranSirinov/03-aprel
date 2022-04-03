using System;
using System.Collections.Generic;
using System.Text;

namespace _03042022
{
    internal class MeetingSchedule
    {
        List<Meeting> _meetingList;
        public MeetingSchedule()
        {
            _meetingList = MeetingList;
        }
        public List<Meeting> MeetingList
        {
            get => _meetingList;
        }
        public int FindMeetingsCount(DateTime time)
        {
            if(time == null)
            {
                throw new Exception("Null daxil etdiniz");
            }
            else
            {
                int count = 0;  
                foreach(Meeting meeting in _meetingList)
                {
                    if (time > meeting.FromDate)
                    {
                        count++;
                    }
                }
                return count;
            }
               
             
        }
        public bool IsExistsMeetingByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Null daxil edildi");
            else
            {
                foreach (Meeting meeting in _meetingList)
                {
                    if(meeting.Name.Contains(name))
                        return true;
                }
                return false;
            }
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Null daxil etdiniz");
            else
            {
                List<Meeting>newMeetinglist=new List<Meeting>();
                foreach (Meeting meeting in _meetingList)
                {
                    if (meeting.Name.Contains(name)) 
                        newMeetinglist.Add(meeting);
                }
                return newMeetinglist;
            }
        }
    }
}
