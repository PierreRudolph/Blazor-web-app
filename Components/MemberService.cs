using Blazor_App.Models;

namespace Blazor_App.Components
{
    public class MemberService
{
        public void AddContact(MemberViewModel member)
        {
            memberList.Add(member);
        }

        public List<MemberViewModel> GetMembers()
        {
            return memberList; 
        }

        public List<MemberViewModel> memberList =
        [
            new MemberViewModel
            {
                MemberId="someId1233",
                MemberName="Johann",
                Email="johann@mail.de",
                Age=46,
                JoiningDate=new DateTime(2024,11,23)
            },
            new MemberViewModel
            {
                MemberId="someId1234",
                MemberName="Sybille",
                Email="bille@mail.de",
                Age=46,
                JoiningDate=new DateTime(2020,5,11)
            },
            new MemberViewModel
            {
                MemberId="someId1235",
                MemberName="Sebastian",
                Email="basti@mail.de",
                Age=46,
                JoiningDate=new DateTime(2022,1,4)
            },
            new MemberViewModel
            {
                MemberId="someId1236",
                MemberName="Jörg",
                Email="jörg@mail.de",
                Age=46,
                JoiningDate=new DateTime(2021,12,9)
            }
        ];
    }

}
